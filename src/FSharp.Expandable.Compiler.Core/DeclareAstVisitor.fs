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

/// <summary>
/// Basic delegatable visitor base type.
/// </summary>
/// <typeparam name="'TContext">Visitor context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstDelegatableVisitor, and override SetupVisitor method.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
[<Obsolete>]
type DeclareAstDelegatableVisitor<'TContext>() =

  /// <summary>
  /// Setup visitor.
  /// </summary>
  /// <param name="visitor">Target visitor instance.</param>
  abstract SetupVisitor : visitor:AstDelegatableVisitor<'TContext> -> unit

  interface IAstVisitor<'TContext> with
    /// <summary>
    /// Visit the parsed input.
    /// </summary>
    /// <param name="context">Visito context.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.VisitInput context parsedInput = 
      let visitor = new AstDelegatableVisitor<'TContext>()
      this.SetupVisitor visitor
      visitor.VisitInput context parsedInput

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TContext">Visitor context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareAstFunctionalVisitor<'TContext>(visitor: 'TContext -> ParsedInput -> ParsedInput) =

  interface IAstVisitor<'TContext> with
    /// <summary>
    /// Visit the parsed input.
    /// </summary>
    /// <param name="context">Visito context.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.VisitInput context parsedInput = 
      AstFunctionalVisitor.visitInput visitor context parsedInput
