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

namespace FSharp.Expandable

open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.Ast.Visitors
open Microsoft.FSharp.Compiler.SourceCodeServices

#nowarn "44"

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInheritableVisitor<'TContext when 'TContext : (new: unit -> 'TContext)>() =
  inherit AstInheritableVisitor<'TContext>()

  let mutable filterArgs: Map<string, string[]> option = None
  let mutable symInf: FSharpCheckFileResults option = None

  /// <summary>
  /// Filter arguments.
  /// </summary>
  member __.FilterArguments =
    match filterArgs with
    | Some(args) -> args
    | None -> failwith "Not given filter arguments for current state."

  /// <summary>
  /// Symbol information.
  /// </summary>
  member __.SymbolInformation =
    match symInf with
    | Some(si) -> si
    | None -> failwith "Not given symbol information for current state."

  /// <summary>
  /// Hook point for before visit the parsed input.
  /// </summary>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  abstract member BeforeVisit:
    parsedInput: ParsedInput -> unit

  /// <summary>
  /// Hook point for before visit the parsed input.
  /// </summary>
  /// <remarks>Default implementation is nothing.</remarks>
  default __.BeforeVisit _ = ()

  /// <summary>
  /// Hook point for after visit the parsed input.
  /// </summary>
  abstract member AfterVisit:
    unit -> unit

  /// <summary>
  /// Hook point for after visit the parsed input.
  /// </summary>
  /// <remarks>Default implementation is nothing.</remarks>
  default __.AfterVisit() = ()
          
  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="filterArguments">Filter arguments.</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  member this.Visit(filterArguments: Map<string, string[]>, symbolInformation, parsedInput) =
    filterArgs <- Some filterArguments
    symInf <- Some symbolInformation
    try
      this.BeforeVisit parsedInput
      this.VisitInput (new 'TContext()) parsedInput
    finally
      this.AfterVisit()
      filterArgs <- None
      symInf <- None

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInheritableVisitor() =
  inherit FscxInheritableVisitor<NoContext>()

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Target interface for fscx filter.
/// </summary>
type IDeclareFscxVisitor =

  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="filterArguments">Filter arguments.</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  abstract Visit :
    filterArguments: Map<string, string[]> * symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * parsedInput: Microsoft.FSharp.Compiler.Ast.ParsedInput ->
    Microsoft.FSharp.Compiler.Ast.ParsedInput
    
//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TVisitor">Custom visitor type.</typeparam>
/// <typeparam name="'TContext">Custom context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInheritableVisitorBase<'TVisitor,'TContext when 'TVisitor :> FscxInheritableVisitor<'TContext> and 'TContext : (new: unit -> 'TContext)>() =

  abstract CreateVisitor : unit -> 'TVisitor

  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="filterArguments">Filter arguments.</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  member this.Visit(filterArguments, symbolInformation, parsedInput) = 
    let visitor = this.CreateVisitor()
    visitor.Visit(filterArguments, symbolInformation, parsedInput)

  interface IDeclareFscxVisitor with
    /// <summary>
    /// Visit the parsed input (Entry point).
    /// </summary>
    /// <param name="filterArguments">Filter arguments.</param>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.Visit(filterArguments, symbolInformation, parsedInput) = 
      this.Visit(filterArguments, symbolInformation, parsedInput)

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TVisitor">Custom visitor type.</typeparam>
/// <typeparam name="'TContext">Custom context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInheritableVisitor<'TVisitor,'TContext when 'TVisitor : (new: unit -> 'TVisitor) and 'TVisitor :> FscxInheritableVisitor<'TContext> and 'TContext : (new: unit -> 'TContext)>() =
  inherit DeclareFscxInheritableVisitorBase<'TVisitor, 'TContext>()

  override __.CreateVisitor() = new 'TVisitor()

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInheritableVisitorBase<'TVisitor when 'TVisitor :> FscxInheritableVisitor<NoContext>>() =
  inherit DeclareFscxInheritableVisitorBase<'TVisitor, NoContext>()

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInheritableVisitor<'TVisitor when 'TVisitor : (new: unit -> 'TVisitor) and 'TVisitor :> FscxInheritableVisitor<NoContext>>() =
  inherit DeclareFscxInheritableVisitor<'TVisitor, NoContext>()

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxFunctionalVisitor<'TContext when 'TContext: (new: unit -> 'TContext)>
    (visitor: ( (* default: *) FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * (* symbolInformation: *) FSharpCheckFileResults * (* context: *) 'TContext * (* target: *) SynExpr -> SynExpr option) =

  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="filterArguments">Filter arguments.</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  member __.Visit(filterArguments, symbolInformation, parsedInput) =
    // TODO: How to delive arguments into functional visitor?
    AstFunctionalVisitor.visitInput(visitor, symbolInformation, new 'TContext(), parsedInput)

  interface IDeclareFscxVisitor with
    /// <summary>
    /// Visit the parsed input (Entry point).
    /// </summary>
    /// <param name="filterArguments">Filter arguments.</param>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.Visit(filterArguments, symbolInformation, parsedInput) = 
      this.Visit(filterArguments, symbolInformation, parsedInput)

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxFunctionalVisitor
    (visitor: ( (* default: *) FSharpCheckFileResults * NoContext * SynExpr -> SynExpr) * (* symbolInformation: *) FSharpCheckFileResults * (* context: *) NoContext * (* target: *) SynExpr -> SynExpr option) =
  inherit DeclareFscxFunctionalVisitor<NoContext>(visitor)
