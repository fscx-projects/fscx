//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

{1}

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  abstract member VisitSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitSynExpr expr context =
    match expr with
{2}
