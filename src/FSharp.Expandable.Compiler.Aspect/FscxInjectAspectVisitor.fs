//////////////////////////////////////////////////////////////////////////////
// 
// fscx - Expandable F# compiler project
//   Author: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift)
//   GutHub: https://github.com/fscx-projects/
//
// Creative Commons Legal Code
// 
// CC0 1.0 Universal
// 
//   CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
//   LEGAL SERVICES.DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
//   ATTORNEY-CLIENT RELATIONSHIP.CREATIVE COMMONS PROVIDES THIS
//   INFORMATION ON AN "AS-IS" BASIS.CREATIVE COMMONS MAKES NO WARRANTIES
//   REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
//   PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
//   THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
//   HEREUNDER.
//
//////////////////////////////////////////////////////////////////////////////

namespace FSharp.Expandable

open System
open System.IO
open System.Linq
open System.Reflection
open System.Text.RegularExpressions
open FSharp.Expandable
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.Ast.Visitors
open Microsoft.FSharp.Compiler.SourceCodeServices

////////////////////////////////////////////////////////////////

[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type private FscxInjectAspectVisitorImpl<'TAspect> private () =

  static let typeName = typeof<'TAspect>.FullName

  static let assertLookup f name =
    let mi = f name
    if mi = null then
      raise (InvalidOperationException name)
    else
      mi

  static let enterMethod =
    assertLookup (fun name ->
      typeof<'TAspect>.GetMethod(
        name,
        BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.DeclaredOnly))
      "Enter"
  static let leaveMethod =
    assertLookup (fun name ->
      enterMethod.ReturnType.GetMethod(
        name,
        BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly))
      "Leave"
  static let caughtMethod =
    assertLookup (fun name ->
      enterMethod.ReturnType.GetMethod(
        name,
        BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly))
      "Caught"

  static member TypeName = typeName

////////////////////////////////////////////////////////////////
//
// Can use aspect implementation duck-typed class...
// runtime constraints below:
//
// type IInjectAspectContext =
//   abstract Leave : 'TResult -> 'TResult
//   abstract Caught : exn -> unit
//
// type InjectAspect =
//   static member Enter : (methodName: string, fileName: string, line:int, column: int, args:obj[]) -> IInjectAspectContext

// TODO: Async/Task methods may be handling async computation...

type FscxInjectAspectVisitorContext<'TContext> = {
  SymbolInformation: FSharpCheckFileResults
  FilterArguments: Map<string, string[]>
  TargetAssemblies: Regex[]
  AspectTargetCount: int
  Context: 'TContext
}

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor<'TContext when 'TContext: (new: unit -> 'TContext)> private (aspectEnter: string list) = 
  inherit FscxInheritableVisitor<FscxInjectAspectVisitorContext<'TContext>>()

  static let constUnit =
    SynExpr.Const(SynConst.Unit, zeroRange)

  static let constString value =
    SynExpr.Const(SynConst.String(value, zeroRange), zeroRange)

  static let constInt32 value =
    SynExpr.Const(SynConst.Int32(value), zeroRange)

  static let createIdent (idents: string list) range =
    match idents with
    | [ident] ->
      SynExpr.Ident(Ident(ident, range))
    | _ ->
      SynExpr.LongIdent
        (false,
         LongIdentWithDots
           (idents |> List.map (fun ident -> Ident(ident, zeroRange)),
            List.init (idents |> List.length) (fun _ -> zeroRange)),
         None,
         range)

  static let createTuple exprs =
    SynExpr.Tuple
      (exprs,
       exprs |> List.skip 1 |> List.map (fun _ -> zeroRange),
       zeroRange)

  static let createApp idents appExpr =
    SynExpr.App
      (ExprAtomicFlag.NonAtomic,
       false,
       createIdent idents zeroRange,
       SynExpr.Paren
         (appExpr,
          zeroRange,
          None,
          zeroRange),
       zeroRange)

  static let createSequence exprs =
    exprs |> Seq.reduceBack (fun expr0 expr1 ->
      SynExpr.Sequential
        (SequencePointInfoForSeq.SuppressSequencePointOnStmtOfSequential,
         true,
         expr0,
         expr1,
         zeroRange))

  static let createNamedPattern name =
    SynPat.Named(
      SynPat.Wild(zeroRange),
      Ident(name, zeroRange),
      false,
      None,
      zeroRange)

  static let createMatchClause pattern expr =
    SynMatchClause.Clause
      (pattern,
       None,
       expr,
       zeroRange,
       SequencePointInfoForTarget.SuppressSequencePointAtTarget)

  static let createLetBinding name bindExpr bodyExpr spBind =
    SynExpr.LetOrUse
      (false,
       false,
       [SynBinding.Binding
         (None,
          SynBindingKind.NormalBinding,
          false,
          false,
          [],
          PreXmlDoc.Empty,
          SynValData.Empty,
          createNamedPattern name,
          None,
          bindExpr,
          zeroRange,
          spBind)],
       bodyExpr,
       zeroRange)

  //////////////////////

  // Extract symbol name from three variations
  static let rec identForSymbol expr =
    match expr with
    // Traverse currying apply
    | SynExpr.App (_, _, funcExpr, _, _) ->
      identForSymbol funcExpr
    // Single symbol
    | SynExpr.Ident ident ->
      Some (expr, [ ident ], ident.idText)
    // Multiple structuring symbols
    | SynExpr.LongIdent (_, longIdent, _, _) ->
      let elements = longIdent.Lid |> List.map (fun i -> i.idText)
      Some (expr, longIdent.Lid, String.Join(".", elements))
    // Other, do not apply custom visitor.
    | _ ->
      None

  // Active pattern: Extract symbol name from three variations
  static let (|IdentForSymbol|_|) expr =
    identForSymbol expr

  //////////////////////

  static let rec argumentsByCurrying funcExpr argExpr argExprs =
    let argExprs = argExpr :: argExprs
    match funcExpr, argExpr with
    // Curryable arguments
    | SynExpr.App (_, _, funcExpr, argExpr, _), _ ->
      argumentsByCurrying funcExpr argExpr argExprs
    // Other
    | _ ->
      argExprs

  // Active pattern: Extract args
  static let (|Arguments|) (funcExpr, argExpr) =
    match funcExpr, argExpr with
    // Curryable arguments
    | SynExpr.App _, _ ->
      (argumentsByCurrying funcExpr argExpr []), true  // currying
    // Tuple arguments
    | _, SynExpr.Paren(SynExpr.Tuple(exprs, _, _), _, _, _) ->
      exprs, false
    // Argument nothing (Paren only)
    | _, SynExpr.Const(SynConst.Unit, _) ->
      [], false
    // Other
    | _ ->
      [argExpr], false

  //////////////////////

  static let getArgName (index: int) =
    "__arg_" + index.ToString()

  static let createArgumentExpr origExpr exprs =
    match origExpr, exprs with
    | SynExpr.Paren(SynExpr.Tuple(_, _, _), _, _, _), _ ->
      SynExpr.Paren(SynExpr.Tuple(exprs, [], zeroRange), zeroRange, None, zeroRange)
    | SynExpr.Paren(_, _, _, _), [expr] ->
      SynExpr.Paren(expr, zeroRange, None, zeroRange)
    | SynExpr.Const(SynConst.Unit, _), _ ->
      SynExpr.Const(SynConst.Unit, zeroRange)
    | _, [expr] ->
      expr
    | _ ->
      failwith ""
    
  static let createArrayWithArgs exprs =
    SynExpr.ArrayOrList
      (true,
       exprs |> List.mapi (fun index _ -> createIdent [getArgName index] zeroRange),
       zeroRange)

  //////////////////////

  static let getSymbolUseAtIdent (symbolInformation: FSharpCheckFileResults) (ids: Ident list) =
    let head = ids |> Seq.map (fun id -> id.idRange) |> Seq.head
    let last = ids |> Seq.map (fun id -> id.idRange) |> Enumerable.Last
    let names = ids |> Seq.map (fun id -> id.idText) |> Seq.toList
    let text = String.Join(".", names)
    symbolInformation.GetSymbolUseAtLocation
      (head.StartLine,
       last.EndColumn,
       text,
       names)

  //////////////////////

  // Public constructor
  new (aspectTypeName: string) =
    FscxInjectAspectVisitor([ yield! aspectTypeName.Split('.'); yield "Enter"])

  //////////////////////

  // ORIGINAL EXPR:
  //   System.String.Format(123, a + b, "ABC")  // This is SynExpr.App
  //
  // INSERTED EXPR:
  //   let __arg_0 = 123
  //   let __arg_1 = a + b
  //   let __arg_2 = "ABC"
  //   let __context = Aspect.Enter("System.String.Format", "Sample.fs", 12, 34, [|__arg_0;__arg_1;__arg_2|])
  //   try
  //     __context.Leave(System.String.Format(__arg_0, __arg_1, __arg_2))
  //   with
  //   | ex ->
  //     __context.Caught(ex)
  //     reraise()

  // Insert aspect core code:
  member private __.InsertAspectToAppExpr
    (identExpr,
     symbolName,
     argExpr,
     deconstructedExprs,
     currying,
     appRange: Microsoft.FSharp.Compiler.Range.range) =

    // Step2:
    //   Construct new inner App expr.
    //   "System.String.Format(__arg_0, __arg_1, __arg_2)"
    let innerBodyApp =
      // Construct bound arguments.
      // Bound arguments named with "__arg_n".
      let argExprs =
        deconstructedExprs
        |> List.mapi (fun index _ -> createIdent [getArgName index] zeroRange)
      if currying then
        // Step1-1:
        //   Construct bound arguments.
        //   Bound arguments named with "__arg_n".
        List.foldBack
          (fun expr lastExpr ->
            SynExpr.App(
              ExprAtomicFlag.NonAtomic,
              false,
              lastExpr,
              expr,
              zeroRange))
          (argExprs |> List.rev)
          identExpr
      else
        // Step1-2:
        //   Construct bound arguments.
        //   Bound arguments named with "__arg_n".
        SynExpr.App(
          ExprAtomicFlag.NonAtomic,
          false,
          identExpr,
          argExprs |> createArgumentExpr argExpr,
          zeroRange)

    // Step3:
    //  Invoke __context.Leave.
    let leaveApp =
      createApp ["__context"; "Leave" ] innerBodyApp

    // Step4:
    //   Invoke __context.Caught.
    let caughtApp =
      createApp ["__context"; "Caught" ] (createIdent ["ex"] zeroRange)

    // Step5:
    //   "reraise()"
    let reraiseApp =
      createApp ["reraise"] constUnit

    // Step6:
    //   Combined with-block exprs
    let withSequence =
      createSequence [caughtApp; reraiseApp]

    // Step7:
    //   Construct with clause
    let withClause =
      createMatchClause (createNamedPattern "ex") withSequence
                 
    // Step8:
    //   Construct try-with
    let tryWith =
      SynExpr.TryWith
        (leaveApp,
         zeroRange,
         [withClause],
         zeroRange,
         zeroRange,
         SequencePointInfoForTry.NoSequencePointAtTry,
         SequencePointInfoForWith.NoSequencePointAtWith)

    // Step9:
    //   [|__arg_0;__arg_1;__arg_2;__arg_3|]
    let argsExpr =
      createArrayWithArgs deconstructedExprs

    // Step10:
    //   Aspect.Enter("System.String.Format", "Sample.fs", 12, 34, [|__arg_0;__arg_1;__arg_2;__arg_3|])
    let enterApp =
      createApp
        aspectEnter
        (createTuple [constString symbolName; constString appRange.FileName; constInt32 appRange.StartLine; constInt32 appRange.StartColumn; argsExpr])
        
    // Step11:
    //   let __context = Aspect.Enter(...) in try...
    let contextBound =
      createLetBinding
        "__context"
        enterApp
        tryWith
        SequencePointInfoForBinding.NoSequencePointAtLetBinding

    // Step12:
    //   let arg0 = expr0 in let arg1 = expr1 in ... in let __context = ...
    let generatedExpr =
      List.foldBack
        (fun (index, expr) lastExpr ->
          createLetBinding
            (getArgName index)
            expr
            lastExpr
            (if index = 0 then
               SequencePointInfoForBinding.SequencePointAtBinding appRange
             else
               SequencePointInfoForBinding.NoSequencePointAtLetBinding))
        (deconstructedExprs |> List.mapi (fun index expr -> index, expr))
        contextBound

    generatedExpr

  //////////////////////

  /// <summary>
  /// Hook point for before visit the parsed input.
  /// </summary>
  /// <param name="filterArguments">Filter arguments.</param>
  /// <param name="symbolInformation">Symbol information.</param>
  override __.CreateContext(filterArguments, symbolInformation) =
    let targets =
      match filterArguments.TryFind "FSharp.Expandable.Compiler.Aspect" with
      | Some args -> args
      | None -> [| ".*" |]  // Targetting for all source file and functions.
    let targetAssemblies =
      targets
      |> Array.map (fun matchExpr -> new Regex(matchExpr, RegexOptions.Compiled ||| RegexOptions.Singleline))

    { FilterArguments = filterArguments;
      SymbolInformation = symbolInformation;
      TargetAssemblies = targetAssemblies;
      AspectTargetCount = 0;
      Context = new 'TContext() }

  /// <summary>
  /// Hook "SynBinding.Binding" (Before visit)
  /// </summary>
  override __.BeforeVisitBinding_Binding
     (context,
      access,
      bindingKind,
      mustInline,
      isMutable,
      attributes,
      xmlDoc,
      item7,
      headPat,
      item9,
      expr,
      lhsRange,
      spBind) =

    let newContext =
      // Check if applied attributes:
      let found =
        attributes.AsParallel().Any
         (new Func<SynAttribute, bool>(fun attribute ->
          // Binding expression has one or more attributes
          let ids = attribute.TypeName.Lid
          let result =
            getSymbolUseAtIdent context.SymbolInformation ids
            |> Async.RunSynchronously   // Cannot async wait
          match result with
          | Some symbolUse ->
            // Duck-typed naming "AspectTargetAttribute"
            // (Not required decision for where is assembly)
            let name = symbolUse.Symbol.FullName
            if name = "FSharp.Expandable.Compiler.AspectTargetAttribute" then
              true
            else
              false
          | _ -> false))

      // Found AspectTargetAttribute
      if found then
        // Enter aspect block:
        { context with AspectTargetCount = context.AspectTargetCount + 1 }
      else
        context

    // Fallback default impls.
    base.BeforeVisitBinding_Binding
     (newContext,
      access,
      bindingKind,
      mustInline,
      isMutable,
      attributes,
      xmlDoc,
      item7,
      headPat,
      item9,
      expr,
      lhsRange,
      spBind)

  /// <summary>
  /// Hook "SynExpr.App" (Before visit)
  /// </summary>
  override this.BeforeVisitExpr_App
     (context,
      exprAtomicFlag,
      isInfix,
      funcExpr,
      argExpr,
      appRange) =

    // This expr already applied "AspectTargetAttribute."
    if context.AspectTargetCount >= 1 then
      match funcExpr, (funcExpr, argExpr) with
      | IdentForSymbol(identExpr, ids, symbolName), Arguments(deconstructedExprs, currying) ->
        // Try lookup symbol to typed reference:
        let result =
          getSymbolUseAtIdent context.SymbolInformation ids
          |> Async.RunSynchronously   // Cannot async wait
        match result with
        // Found:
        | Some symbolUse ->
          // Typed assembly name:
          let qualifiedName = symbolUse.Symbol.Assembly.QualifiedName
          let simpleName = symbolUse.Symbol.Assembly.SimpleName
          let foundForQualified =
            context.TargetAssemblies
            |> Seq.exists (fun regex -> regex.IsMatch qualifiedName)
          let found =
            foundForQualified ||
            (context.TargetAssemblies |> Seq.exists (fun regex -> regex.IsMatch simpleName))
          if found then
            // Deconstructed exprs visit manually.
            // (funcExpr not visit, because IdentForSymbol traversed on original AST structures and decomposed identity.)
            let visitedDeconstractedExprs = deconstructedExprs |> List.map (this.VisitExpr context)
            // Insert aspect
            this.InsertAspectToAppExpr(identExpr, symbolName, argExpr, visitedDeconstractedExprs, currying, appRange)
          else
            // Continue visit
            base.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)
        | _ ->
          // Continue visit
          base.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)
      | _ ->
        // Continue visit
        base.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)

    else
      // Continue visit
      base.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor<'TAspect(* when 'TAspect :> InjectAspect *), 'TContext when 'TContext: (new: unit -> 'TContext)>() = 
  inherit FscxInjectAspectVisitor<'TContext>(FscxInjectAspectVisitorImpl<'TAspect>.TypeName)
