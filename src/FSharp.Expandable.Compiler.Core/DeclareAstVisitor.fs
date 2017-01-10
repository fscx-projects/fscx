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
/// Visitor raw context record. Contains context, FCS's check file results and filter arguments.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
type FscxVisitorContext<'TContext> = 
    { Context : 'TContext
      SymbolInformation : FSharpCheckFileResults
      FilterArguments : Map<string, string []> }

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInheritableVisitor<'TContext>() = 
    inherit AstInheritableVisitor<'TContext>()
    
    /// <summary>
    /// Create context.
    /// </summary>
    /// <param name="filterArguments">Filter arguments.</param>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <returns>Context instance</returns>
    abstract CreateContext : filterArguments:Map<string, string []> * symbolInformation:FSharpCheckFileResults
     -> 'TContext
    
    /// <summary>
    /// Hook point for after visit the parsed input.
    /// </summary>
    abstract Finish : context:'TContext -> unit
    
    /// <summary>
    /// Hook point for after visit the parsed input.
    /// </summary>
    /// <remarks>Default implementation is nothing.</remarks>
    override __.Finish _ = ()
    
    /// <summary>
    /// Visit the parsed input (Entry point).
    /// </summary>
    /// <param name="filterArguments">Filter arguments.</param>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member this.Visit(filterArguments : Map<string, string []>, symbolInformation, parsedInput) = 
        let context = this.CreateContext(filterArguments, symbolInformation)
        try 
            this.VisitInput context parsedInput
        finally
            this.Finish context

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type FscxInheritableVisitor() = 
    inherit FscxInheritableVisitor<FscxVisitorContext<NoContext>>()

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
    abstract Visit : filterArguments:Map<string, string []> * symbolInformation:Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * parsedInput:Microsoft.FSharp.Compiler.Ast.ParsedInput
     -> Microsoft.FSharp.Compiler.Ast.ParsedInput

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
type DeclareFscxInheritableVisitorBase<'TVisitor, 'TContext when 'TVisitor :> FscxInheritableVisitor<'TContext>>() = 
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

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Basic functional visitor base type.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
/// <remarks>
/// Inherit this class if use AstFunctionalVisitor.
/// </remarks>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxFunctionalVisitor<'TContext when 'TContext : (new : unit -> 'TContext)>(visitor : ((* default: *) FscxVisitorContext<'TContext> * SynExpr -> SynExpr) * (* context: *) FscxVisitorContext<'TContext> * (* target: *) SynExpr -> SynExpr option) = 
    
    /// <summary>
    /// Visit the parsed input (Entry point).
    /// </summary>
    /// <param name="filterArguments">Filter arguments.</param>
    /// <param name="symbolInformation">Symbol information.</param>
    /// <param name="parsedInput">Target for ParsedInput instance.</param>
    /// <returns>Visited instance.</returns>
    member __.Visit(filterArguments, symbolInformation, parsedInput) = 
        let context = 
            { Context = new 'TContext()
              SymbolInformation = symbolInformation
              FilterArguments = filterArguments }
        AstFunctionalVisitor.visitInput (visitor, context, parsedInput)
    
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
type DeclareFscxFunctionalVisitor(visitor : ((* default: *) FscxVisitorContext<NoContext> * SynExpr -> SynExpr) * (* context: *) FscxVisitorContext<NoContext> * (* target: *) SynExpr -> SynExpr option) = 
    inherit DeclareFscxFunctionalVisitor<NoContext>(visitor)
