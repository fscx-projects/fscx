//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

#nowarn "1182"

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST delegatable visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
[<Obsolete>]
type AstDelegatableVisitor<'TContext> private (parentParents: System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.Visitor.AstElement>) =

  // TODO: du element
  let parents = parentParents

  /// <summary>
  /// Constructor.
  /// </summary>
  new() =
    AstDelegatableVisitor<'TContext>(new System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.Visitor.AstElement>())

  /// <summary>
  /// Parent nodes
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  /// <summary>
  /// Create child visitor.
  /// </summary> 
  /// <returns>Child empty visitor.</returns>
  member __.CreateChild() =
    new AstDelegatableVisitor<'TContext>(parents)
