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
      (ExprAtomicFlag.Atomic,
       false,
       createIdent idents zeroRange,
       SynExpr.Paren
         (appExpr,
          zeroRange,
          None,
          zeroRange),
       zeroRange)

  // TODO: Maybe invalid operation...
  static let createSequence exprs =
    exprs |> Seq.reduceBack (fun expr0 expr1 ->
      SynExpr.Sequential
        (SequencePointInfoForSeq.SuppressSequencePointOnExprOfSequential,
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
          SynValData.SynValData(None, SynValInfo.SynValInfo([], SynArgInfo.SynArgInfo(SynAttributes.Empty, false, None)), None),
          createNamedPattern name,
          None,
          bindExpr,
          zeroRange,
          spBind)],
       bodyExpr,
       zeroRange)

  //////////////////////

  // Extract idented args from three variations:
  static let (|IdentForSymbol|_|) expr =
    match expr with
    | SynExpr.Ident ident ->
      Some ident.idText
    | SynExpr.LongIdent (_, longIdent, _, range) ->
      let elements = longIdent.Lid |> List.map (fun i -> i.idText)
      Some (String.Join(".", elements))
    | _ -> None

  static let (|Arguments|_|) expr =
    match expr with
    | SynExpr.Paren(SynExpr.Tuple(exprs, _, _), _, _, _) ->
      Some exprs
    | SynExpr.Paren(expr, _, _, _) ->
      Some [expr]
    | SynExpr.Const(SynConst.Unit, _) as u ->
      Some [u]
    | _ -> None

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
    | _ -> failwith ""
    
  static let createArrayWithArgs exprs =
    SynExpr.ArrayOrListOfSeqExpr
      (true,
       SynExpr.CompExpr
         (true,
          ref true,
          createSequence (exprs |> List.mapi (fun index (expr: SynExpr) -> createIdent [getArgName index] zeroRange)),
          zeroRange),
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
  //   let __context = Aspect.Enter("f1", "Sample.fs", 12, 34, [|__arg_0;__arg_1;__arg_2|])
  //   try
  //     __context.Leave(System.String.Format(__arg_0, __arg_1, __arg_2))
  //   with
  //   | ex ->
  //     __context.Caught(ex)
  //     reraise()

  // Insert aspect core code:
  member private this.InsertAspectToAppExpr
    (funcExpr,
     symbolName,
     argExpr,
     deconstructedExprs,
     appRange: Microsoft.FSharp.Compiler.Range.range) =

    // Step1:
    //   Construct bound arguments.
    //   Bound arguments named with "__arg_n".
    let newArgExpr =
      deconstructedExprs
      |> List.mapi (fun index _ -> createIdent [getArgName index] zeroRange)
      |> createArgumentExpr argExpr
    
    // Step2:
    //   Construct new inner App expr.
    //   "System.String.Format(__arg_0, __arg_1, __arg_2)"
    let innerBodyApp =
      SynExpr.App(
        ExprAtomicFlag.Atomic,
        false,
        funcExpr,
        newArgExpr, // Step1
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

    ////////////////////////////////////////////////////////////////////
    // DEBUG:
    let orig = this.Parents |> Enumerable.Last |> sprintf "%A"
    let generated = sprintf "%A" generatedExpr
    ////////////////////////////////////////////////////////////////////

    generatedExpr

  //////////////////////

  // Hook "SynExpr.App"
  override this.VisitExpr_App
     (context,
      exprAtomicFlag,
      isInfix,
      funcExpr,
      argExpr,
      appRange) =

    match funcExpr, argExpr with
    | IdentForSymbol symbolName, Arguments deconstructedExprs ->
      this.InsertAspectToAppExpr(funcExpr, symbolName, argExpr, deconstructedExprs, appRange)
    | _ ->
      base.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor<'TAspect(* when 'TAspect :> InjectAspect *)>() = 
  inherit FscxInjectAspectVisitor(FscxInjectAspectVisitorImpl<'TAspect>.TypeName)
