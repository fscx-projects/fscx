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
open System.Reflection
open Microsoft.FSharp.Compiler.Ast
open FSharp.Expandable

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

  // TODO: Maybe invalid orientation...
  static let createSequence exprs =
    exprs |> Seq.reduce (fun expr0 expr1 ->
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

  static let createLetBinding name bindExpr bodyExpr =
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
          SequencePointInfoForBinding.NoSequencePointAtLetBinding)],
          bodyExpr,
          zeroRange)

  //////////////////////

  static let getArgName (index: int) = "__arg_" + index.ToString()

  static let createLetBoundWithArgsApp
    (exprAtomicFlag,
     isInfix,
     funcExpr,
     tupleExprs,
     tupleCommaRanges,
     tupleRange,
     leftParenRange,
     rightParenRange,
     parenRange,
     appRange) =
    let newTupleExprs = tupleExprs |> List.mapi (fun index (expr: SynExpr) -> createIdent [getArgName index] zeroRange)
    let newTuple = SynExpr.Tuple(newTupleExprs, tupleCommaRanges, tupleRange)
    let newParen = SynExpr.Paren(newTuple, leftParenRange, rightParenRange, parenRange)
    SynExpr.App(exprAtomicFlag, isInfix, funcExpr, newParen, appRange)

  static let createArrayWithArgsApp exprs =
    SynExpr.ArrayOrListOfSeqExpr
      (true,
       SynExpr.CompExpr
         (true,
          ref true,
          createSequence (exprs |> List.mapi (fun index (expr: SynExpr) -> createIdent [getArgName index] zeroRange)),
          zeroRange),
       zeroRange)

  static let getTypeIdent (t: Type) =
    let name = t.FullName.Replace('+', '.')
    let index = name.IndexOf('`')
    let name = if index >= 0 then name.Substring(0, index) else name
    name.Split('.') |> Array.toList

  static let getMethodName (mi: MethodBase) =
    let name = mi.Name
    let index = name.IndexOf('`')
    if index >= 0 then name.Substring(0, index) else name

  static let getFuncSignature memberExpr tupleExprs =
    match memberExpr with
    | SynExpr.LongIdent(_, LongIdentWithDots(ids, _), _, _) ->
      System.String.Join(".", ids)
    | _ -> failwith ""
    
  //////////////////////

  new (aspectTypeName: string) =
    FscxInjectAspectVisitor([ yield! aspectTypeName.Split('.'); yield "Enter"])

  //////////////////////

  override this.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange) =
  
    match argExpr with
    // System.String.Format("ABC", 123, 456)
    | SynExpr.Paren(SynExpr.Tuple(tupleExprs, tupleCommaRanges, tupleRange), leftParenRange, rightParenRange, parenRange) ->

      // let __arg_0 = "ABC"
      // let __arg_1 = 123
      // let __arg_2 = 456
      // let __arg_3 = 789
      // let __context = Aspect.Enter("Sample.fs", 12, 34, [|__arg_0;__arg_1;__arg_2;__arg_3|])
      // try
      //   __context.Leave(System.String.Format(__arg_0, __arg_1, __arg_2, __arg_3))
      // with
      // | ex ->
      //   __context.Caught(ex)
      //   reraise()

      // 1. "System.String.Format(__arg_0, __arg_1, __arg_2, __arg_3)"
      //   * All arguments retargeting to let-bound references.
      let innerBodyApp =
        createLetBoundWithArgsApp
          (exprAtomicFlag,
           isInfix,
           funcExpr,
           tupleExprs,
           tupleCommaRanges,
           tupleRange,
           leftParenRange,
           rightParenRange,
           parenRange,
           appRange)

      // 2. "context.Leave(newApp)"
      let leaveApp =
        createApp ["__context"; "Leave" ] innerBodyApp

      // 3. "context.Caught(ex)"
      let caughtApp =
        createApp ["__context"; "Caught" ] (createIdent ["ex"] zeroRange)

      // 4. "reraise()"
      let reraiseApp =
        createApp ["reraise"] constUnit

      // 5. Combined with-block exprs
      let withSequence =
        createSequence [caughtApp; reraiseApp]

      // 6. Construct with clause
      let withClause =
        createMatchClause (createNamedPattern "ex") withSequence
           
      // 7. Construct try-with
      let tryWith =
        SynExpr.TryWith
          (leaveApp,
           zeroRange,
           [withClause],
           zeroRange,
           zeroRange,
           SequencePointInfoForTry.NoSequencePointAtTry,
           SequencePointInfoForWith.NoSequencePointAtWith)
       
      // 8. [|__arg_0;__arg_1;__arg_2;__arg_3|]
      let argsExpr =
        createArrayWithArgsApp tupleExprs

      // 9. "System.String.Format()"
      let funcSignature =
        getFuncSignature funcExpr tupleExprs

      // 10. Aspect.Enter("System.String.Format()", "Sample.fs", 12, 34, [|__arg_0;__arg_1;__arg_2;__arg_3|])
      let enterApp =
        createApp
          aspectEnter
          (createTuple [constString funcSignature; constString appRange.FileName; constInt32 appRange.StartLine; constInt32 appRange.StartColumn; argsExpr])

      // 11. let __context = Aspect.Enter(...) in try...
      let contextBound =
        createLetBinding
          "__context"
          enterApp
          tryWith

      // 12. let arg0 = expr0 in let arg1 = expr1 in ... in let __context = ...
      let totalExpr =
        List.foldBack
          (fun (name, expr) lastExpr -> createLetBinding name expr lastExpr)
          (tupleExprs |> List.mapi (fun index expr -> getArgName index, expr))
           contextBound

      let total = sprintf "%A" totalExpr

      totalExpr

    | _ -> base.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)

[<NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInjectAspectVisitor<'TAspect(* when 'TAspect :> InjectAspect *)>() = 
  inherit FscxInjectAspectVisitor(FscxInjectAspectVisitorImpl<'TAspect>.TypeName)
