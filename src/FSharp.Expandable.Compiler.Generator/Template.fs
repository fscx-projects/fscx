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
type SynExprVisitor() =

{1}

  /// <summary>
  /// Visitor entry function.
  /// </summary>
  abstract member Visit: Microsoft.FSharp.Compiler.Ast.SynExpr -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.Visit expr context =
    match expr with
{2}
