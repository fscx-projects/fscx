//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST expression auguments.
/// </summary>
[<AutoOpen>]
module SynExpr =

{1}

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

{2}

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr parents context =
    let currentParents = expr :: parents
    match expr with
{3}

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

{2}

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr parents context =
    let currentParents = expr :: parents
    match expr with
{3}

