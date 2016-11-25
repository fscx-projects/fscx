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

open FSharp.Expandable

/// <summary>
/// Declare aspect visitor.
/// </summary>
/// <typeparam name="'TAspect">Duck-typed aspect class.</typeparam>
/// <remarks>This class provide IDeclareFscxVisitor implementation.
/// Can decl aspect visitor for using this inherited public class.</remarks>
[<NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInjectAspectVisitor<'TAspect>() =
  inherit DeclareFscxInheritableVisitor<FscxInjectAspectVisitor<'TAspect>>()
  
/// <summary>
/// Declare aspect visitor.
/// </summary>
/// <remarks>This class provide IDeclareFscxVisitor implementation.
/// Can decl aspect visitor for using this inherited public class.</remarks>
[<NoEquality; NoComparison; AutoSerializable(false)>]
type DeclareFscxInjectAspectVisitor(aspectTypeName) =
  inherit DeclareFscxInheritableVisitorBase<FscxInjectAspectVisitor>()

  override __.CreateVisitor() = new FscxInjectAspectVisitor(aspectTypeName)
