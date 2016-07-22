//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

{1}

  abstract member VisitSynExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="expr">Target expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitSynExpr parents expr context =
    let currentParents = expr :: parents
    match expr with
{2}
