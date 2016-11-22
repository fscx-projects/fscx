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
type FscxInjectAspectVisitor<'TAspect(* when 'TAspect :> InjectAspect *)>() = 
  inherit FscxInheritableVisitor()

  static let enterMethod =
    typeof<'TAspect>.GetMethod(
      "Enter",
      BindingFlags.Public ||| BindingFlags.Static ||| BindingFlags.DeclaredOnly)
  static let leaveMethod =
    enterMethod.ReturnType.GetMethod(
      "Leave",
      BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
  static let caughtMethod =
    enterMethod.ReturnType.GetMethod(
      "Caught",
      BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)

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
    let newTupleExprs = tupleExprs |> List.mapi (fun index (expr: SynExpr) -> createIdent ["arg" + index.ToString()] zeroRange)
    let newTuple = SynExpr.Tuple(newTupleExprs, tupleCommaRanges, tupleRange)
    let newParen = SynExpr.Paren(newTuple, leftParenRange, rightParenRange, parenRange)
    SynExpr.App(exprAtomicFlag, isInfix, funcExpr, newParen, appRange)

  static let createArrayWithArgsApp exprs =
    SynExpr.ArrayOrListOfSeqExpr
      (true,
       SynExpr.CompExpr
         (true,
          ref true,
          createSequence (exprs |> List.mapi (fun index (expr: SynExpr) -> createIdent ["arg" + index.ToString()] zeroRange)),
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

  static let getMethodIdent (mi: MethodBase) =
    let typeIdent = getTypeIdent mi.DeclaringType
    let name = getMethodName mi
    List.append typeIdent [name]

  static let getFuncSignature memberExpr tupleExprs =
    match memberExpr with
    | SynExpr.LongIdent(_, LongIdentWithDots(ids, _), _, _) ->
      System.String.Join(".", ids) + "()"   // TODO:
    | _ -> failwith ""

  //////////////////////

  override this.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange) =
  
    match argExpr with
    // System.String.Format("ABC", 123, 456)
    | SynExpr.Paren(SynExpr.Tuple(tupleExprs, tupleCommaRanges, tupleRange), leftParenRange, rightParenRange, parenRange) ->

      // let arg0 = "ABC"
      // let arg1 = 123
      // let arg2 = 456
      // let arg3 = 789
      // let context = Aspect.Enter("Sample.fs", 12, 34, [|arg0;arg1;arg2;arg3|])
      // try
      //   context.Leave(System.String.Format(arg0, arg1, arg2, arg3))
      // with
      // | ex ->
      //   context.Caught(ex)
      //   reraise()

      // 1. "System.String.Format(arg0, arg1, arg2, arg3)"
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
        createApp ["context"; leaveMethod.Name] innerBodyApp

      // 3. "context.Caught(ex)"
      let caughtApp =
        createApp ["context"; caughtMethod.Name] (createIdent ["ex"] zeroRange)

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
       
      // 8. [|arg0;arg1;arg2;arg3|]
      let argsExpr =
        createArrayWithArgsApp tupleExprs

      // 9. "System.String.Format()"
      let funcSignature =
        getFuncSignature funcExpr tupleExprs

      // 10. Aspect.Enter("System.String.Format()", "Sample.fs", 12, 34, [|arg0;arg1;arg2;arg3|])
      let enterApp =
        createApp
          (getMethodIdent enterMethod)
          (createTuple [constString funcSignature; constString appRange.FileName; constInt32 appRange.StartLine; constInt32 appRange.StartColumn; argsExpr])

      // 11. let context = Aspect.Enter(...) in try...
      let contextBound =
        createLetBinding
          "context"
          enterApp
          tryWith

      // 12. let arg0 = expr0 in let arg1 = expr1 in ... in let context = ...
      let totalExpr =
        List.foldBack
          (fun (name, expr) lastExpr -> createLetBinding name expr lastExpr)
          (tupleExprs |> List.mapi (fun index expr -> ("arg" + index.ToString()), expr))
           contextBound

      totalExpr

    | _ -> base.VisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, appRange)
