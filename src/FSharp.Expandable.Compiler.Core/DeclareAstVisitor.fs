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
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.Ast.Visitor
open Microsoft.FSharp.Compiler.SourceCodeServices

#nowarn "44"

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstInheritableVisitor() =
  inherit AstInheritableVisitor<NoContext>()

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareAstFunctionalVisitor<'TContext when 'TContext: (new: unit -> 'TContext)>
    (visitor: ( (* default: *) FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * (* symbolInformation: *) FSharpCheckFileResults * (* context: *) 'TContext * (* target: *) SynExpr -> SynExpr option) =

  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  member __.Visit(symbolInformation, parsedInput) = 
    AstFunctionalVisitor.visitInput(visitor, symbolInformation, new 'TContext(), parsedInput)

  interface IAstVisitor with
    /// <summary>
    /// Visit the parsed input (Entry point).
    /// </summary>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.Visit(symbolInformation, parsedInput) = 
      this.Visit(symbolInformation, parsedInput)

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareAstFunctionalVisitor
    (visitor: ( (* default: *) FSharpCheckFileResults * NoContext * SynExpr -> SynExpr) * (* symbolInformation: *) FSharpCheckFileResults * (* context: *) NoContext * (* target: *) SynExpr -> SynExpr option) =
  inherit DeclareAstFunctionalVisitor<NoContext>(visitor)
