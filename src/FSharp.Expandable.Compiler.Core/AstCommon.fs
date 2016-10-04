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

//////////////////////////////////////////////////////////////////////////////

/// Non generic view of RefWrapper.
type private IRefWrapper =
  abstract UpdateIf : unit -> unit

/// RefWrapper.
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type private RefWrapper<'T>(origRef: 'T ref, visited: 'T) =
  member __.Delegator : 'T ref = ref visited
  interface IRefWrapper with
    member this.UpdateIf() =
      if not (obj.ReferenceEquals(visited, this.Delegator.Value)) then
        origRef.Value <- this.Delegator.Value

/// <summary>
/// Registering reference cell and wrapping visitor.
/// </summary>
/// <remarks>
/// Safe delegation reference cell with already visited instance.
/// Require invoke Dispose() if completed scope.
/// </remarks>
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type RefWrapperHolder() =
  let wrappers = new ResizeArray<IRefWrapper>()

  /// <summary>
  /// Wrapping reference cell.
  /// </summary>
  /// <param name="origRef">Original reference cell instance.</param>
  /// <param name="visited">Visited instance.</param>
  /// <returns>Wrapped reference cell instance.</returns>
  member __.Wrap (origRef: 'T ref) (visited: 'T) : 'T ref =
    let wrapper = new RefWrapper<'T>(origRef, visited)
    wrappers.Add wrapper
    wrapper.Delegator

  interface System.IDisposable with
    member __.Dispose() =
      for wrapper in wrappers do wrapper.UpdateIf()

//////////////////////////////////////////////////////////////////////////////

/// <summary>
/// Target interface for fscx filter.
/// </summary>
type IAstVisitor =

  /// <summary>
  /// Visit the parsed input (Entry point).
  /// </summary>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="parsedInput">Target for ParsedInput instance.</param>
  /// <returns>Visited instance.</returns>
  abstract Visit :
    symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * parsedInput: Microsoft.FSharp.Compiler.Ast.ParsedInput ->
    Microsoft.FSharp.Compiler.Ast.ParsedInput

/// Context means no additional information.
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type NoContext() = class end
