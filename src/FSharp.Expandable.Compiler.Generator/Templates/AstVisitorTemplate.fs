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
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

  // TODO: du element
  let parents = new System.Collections.Generic.Stack<obj>()

  /// <summary>
  /// Parent nodes
  /// </summary>
  member __.Parents = parents |> List.ofSeq
