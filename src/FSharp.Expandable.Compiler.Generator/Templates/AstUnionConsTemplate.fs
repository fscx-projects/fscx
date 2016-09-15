//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

/// Construct discriminal union types arguments less.
[<AutoOpen>]
module AstUnionCons =
#if disabl
  let genStringLit lit =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const
      (Microsoft.FSharp.Compiler.Ast.SynConst.String(lit, zeroRange), zeroRange)

  let genIdent name =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident
      (Microsoft.FSharp.Compiler.Ast.Ident(name, zeroRange))

  let genParen x = Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(x, zeroRange, None, zeroRange)

  let genAppFun (name, arg) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic, false, genIdent name, arg, zeroRange)

  let genOpChain (op, operands) =
    operands
    |> List.reduce (fun acc operand ->
       let func =
         Microsoft.FSharp.Compiler.Ast.SynExpr.App
           (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.NonAtomic, true, genIdent op, acc, zeroRange)
       Microsoft.FSharp.Compiler.Ast.SynExpr.App
         (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.NonAtomic, false, func, operand, zeroRange))

  let genCallStaticMethod (mi: MethodInfo, args: SynExpr list) =
    let argExpr =
      match args with
      | [] ->
        Microsoft.FSharp.Compiler.Ast.SynExpr.Const
          (Microsoft.FSharp.Compiler.Ast.SynConst.Unit, zeroRange)
      | [x] -> x
      | xs ->
        Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
          (xs, (List.replicate (xs.Length - 1) zeroRange), zeroRange)
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic,
       false,
       MethodInfo.toIdent mi,
       genParen argExpr,
       zeroRange)

  let genLetExpr (name, value, expr) =
    let binding =
     Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(
      None,
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding,
      false,
      false,
      [],
      PreXmlDocEmpty,
      Microsoft.FSharp.Compiler.Ast.SynValData
        (None,
         Microsoft.FSharp.Compiler.Ast.SynValInfo
           ([], Microsoft.FSharp.Compiler.Ast.SynArgInfo([], false, None)),
         None),
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        (Microsoft.FSharp.Compiler.Ast.SynPat.Wild(zeroRange),
         Microsoft.FSharp.Compiler.Ast.Ident(name, zeroRange),
         false,
         None,
         zeroRange),
      None,
      value,
      zeroRange,
      NoSequencePointAtInvisibleBinding)
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(false, false, [binding], expr, zeroRange)

  let genTryExpr (tryExpr, clauses, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(
      tryExpr,
      zeroRange,
      clauses,
      zeroRange,
      zeroRange,
      Microsoft.FSharp.Compiler.Ast.SequencePointAtTry range,  // Make break point data (pdb)
      NoSequencePointAtWith)

  let genClause (identName, expr) =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(
      Microsoft.FSharp.Compiler.Ast.SynPat.Named(
        Microsoft.FSharp.Compiler.Ast.SynPat.Wild(zeroRange),
        Microsoft.FSharp.Compiler.Ast.Ident(identName, zeroRange),
        false,
        None,
        zeroRange),
      None,
      expr,
      zeroRange,
      SuppressSequencePointAtTarget)

  let genReraise () =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App(
      Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic,
      false,
      genIdent "reraise",
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        (Microsoft.FSharp.Compiler.Ast.SynExpr.Const
          (Microsoft.FSharp.Compiler.Ast.SynConst.Unit, zeroRange),
         zeroRange, None, zeroRange),
      zeroRange)
#endif
