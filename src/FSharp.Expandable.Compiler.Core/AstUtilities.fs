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

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System
open System.Reflection
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.Ast.Visitor

//////////////////////////////////////////////////////////////////////////////

[<AutoOpen>]
module AstUtilities =

  let zeroRange = Microsoft.FSharp.Compiler.Range.range.Zero

  module MethodInfo =

    let extract (expr: Expr) =
      match expr with
      | Call(_, mi, _) -> mi
      | _ -> failwith "oops!"

    let toIdent (mi: MethodInfo) =
      assert mi.IsStatic
      // TODO : +とかジェネリックも考慮する
      let typFullName = mi.DeclaringType.FullName
      let elems = typFullName.Split('.') |> Array.toList
      let name = mi.Name
      let ids =
        List.concat [ elems; [name] ]
        |> List.map (fun x -> Ident(x, zeroRange))
      SynExpr.LongIdent(false, LongIdentWithDots(ids, List.replicate elems.Length zeroRange), None, zeroRange)

  let genStringLit lit =
    SynExpr.Const(SynConst.String(lit, zeroRange), zeroRange)

  let genIdent name =
    SynExpr.Ident(Ident(name, zeroRange))

  let genParen x =
    SynExpr.Paren(x, zeroRange, None, zeroRange)

  let genAppFun (name, arg) =
    SynExpr.App(ExprAtomicFlag.Atomic, false, genIdent name, arg, zeroRange)

  let genOpChain (op, operands) =
    operands
    |> List.reduce (fun acc operand ->
       let func =
         SynExpr.App(ExprAtomicFlag.NonAtomic, true, genIdent op, acc, zeroRange)
       SynExpr.App(ExprAtomicFlag.NonAtomic, false, func, operand, zeroRange))

  let genCallStaticMethod (mi: MethodInfo, args: SynExpr list) =
    let argExpr =
      match args with
      | [] ->
        SynExpr.Const(SynConst.Unit, zeroRange)
      | [x] -> x
      | xs ->
        SynExpr.Tuple(xs, (List.replicate (xs.Length - 1) zeroRange), zeroRange)
    SynExpr.App(
       ExprAtomicFlag.Atomic,
       false,
       MethodInfo.toIdent mi,
       genParen argExpr,
       zeroRange)

  let genLetExpr (name, value, expr) =
    let binding =
      SynBinding.Binding
       (None,
        SynBindingKind.NormalBinding,
        false,
        false,
        [],
        PreXmlDocEmpty,
        SynValData
         (None,
          SynValInfo([], SynArgInfo([], false, None)),
          None),
        SynPat.Named(SynPat.Wild(zeroRange), Ident(name, zeroRange),
          false,
          None,
          zeroRange),
        None,
        value,
        zeroRange,
        NoSequencePointAtInvisibleBinding)
    SynExpr.LetOrUse(false, false, [binding], expr, zeroRange)

  let genTryExpr (tryExpr, clauses, range) =
    SynExpr.TryWith(
      tryExpr,
      zeroRange,
      clauses,
      zeroRange,
      zeroRange,
      SequencePointAtTry range,  // Make break point data (pdb)
      NoSequencePointAtWith)

  let genClause (identName, expr) =
    SynMatchClause.Clause(
      SynPat.Named(
        SynPat.Wild(zeroRange),
        Ident(identName, zeroRange),
        false,
        None,
        zeroRange),
      None,
      expr,
      zeroRange,
      SuppressSequencePointAtTarget)

  let genReraise () =
    SynExpr.App(
      ExprAtomicFlag.Atomic,
      false,
      genIdent "reraise",
      SynExpr.Paren(SynExpr.Const(SynConst.Unit, zeroRange), zeroRange, None, zeroRange), zeroRange)
