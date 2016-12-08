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
open System.Linq
open System.Reflection
open Microsoft.FSharp.Compiler.Ast
open FSharp.Expandable

////////////////////////////////////////////////////////////////

[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type internal FscxInjectAspectVisitorImpl<'TAspect> private () =

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

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor private (aspectEnter: string list) = 
  inherit FscxInheritableVisitor()

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
      if ident.idText.StartsWith "op_" then
        None
      else
        Some (expr, ident.idText)
    // Multiple structuring symbols
    | SynExpr.LongIdent (_, longIdent, _, _) ->
      let elements = longIdent.Lid |> List.map (fun i -> i.idText)
      Some (expr, String.Join(".", elements))
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
       exprs |> List.mapi (fun index (expr: SynExpr) -> createIdent [getArgName index] zeroRange),
       zeroRange)

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
  member private this.InsertAspectToAppExpr
    (funcExpr,
     identExpr,
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

  // Hook "SynExpr.App" (Before visit)
  override this.BeforeVisitExpr_App
     (context,
      exprAtomicFlag,
      isInfix,
      funcExpr,
      argExpr,
      appRange) =

    match funcExpr, (funcExpr, argExpr) with
    | IdentForSymbol(identExpr, symbolName), Arguments(deconstructedExprs, currying) ->
      // Deconstructed exprs visit manually.
      // (funcExpr not visit, because IdentForSymbol was traversal on original structure and decomposed identity.)
      let visitedDeconstractedExprs = deconstructedExprs |> List.map (this.VisitExpr context)
      // Insert aspect
      this.InsertAspectToAppExpr(funcExpr, identExpr, symbolName, argExpr, visitedDeconstractedExprs, currying, appRange)
    | _ ->
      // Continue visit
      base.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor<'TAspect(* when 'TAspect :> InjectAspect *)>() = 
  inherit FscxInjectAspectVisitor(FscxInjectAspectVisitorImpl<'TAspect>.TypeName)
