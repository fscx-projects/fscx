//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast

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
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

  let parents = new System.Collections.Generic.Stack<SynExpr>()

  /// <summary>
  /// Parent ASTs
  /// </summary>
  member __.Parents = parents |> List.ofSeq

{2}

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr (context: 'TContext) =
    parents.Push(expr)
    try
      match expr with
{3}
    finally
      parents.Pop() |> ignore
