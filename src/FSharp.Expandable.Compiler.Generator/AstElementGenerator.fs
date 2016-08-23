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
open System.Reflection

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

[<Sealed>]
type internal AstElementGenerator() =
  inherit GeneratorBase()

  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t -> (FSharpType.IsUnion t) && (t.DeclaringType = astType) && (t.Name.StartsWith "Syn"))
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.map (fun t ->
      String.Format(
        "  | {0} of {1}\r\n",
        t.Name.Substring 3,
        t.Name))
