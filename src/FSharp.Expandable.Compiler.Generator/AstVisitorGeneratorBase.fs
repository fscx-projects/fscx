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

namespace FSharp.Expandable.Compiler.Generator

open System
open System.Collections.Generic
open System.Linq

/// Base type of visitor generator.
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type internal AstVisitorGeneratorBase() =
  inherit GeneratorBase()

  /// <summary>
  /// Generate lines by type declaration.
  /// </summary>
  /// <param name="visitorTargets">Targets for require invoke visitor.</param>
  /// <param name="unionType">Target DU type.</param>
  /// <returns>Generated lines.</returns>
  abstract member GenerateByType : visitorTargets:IReadOnlyDictionary<Type, string> -> unionType:Type -> string[]

  /// <summary>
  /// Generate body lines.
  /// </summary>
  /// <returns>Generated lines.</returns>
  override this.GenerateBodies () =
    let types = VisitorUtilities.getTargetAstTypes()
    let exprs = types.ToDictionary((fun t -> t), (fun t -> VisitorUtilities.formatUnionTypeShortName t)) :> IReadOnlyDictionary<_, _>
    exprs.Keys |> Seq.collect (this.GenerateByType exprs)
