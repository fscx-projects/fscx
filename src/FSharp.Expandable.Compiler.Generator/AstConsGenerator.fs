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

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

[<Sealed>]
type internal AstConsGenerator() =
  inherit GeneratorBase()
  
  let generateByUnion (t: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"{0}.{1}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed expression.</returns>\r\n" +
      "  let init{1} {2} =\r\n" +
      "    {0}.{1}{3}\r\n",
      t.Name,
      unionCase.Name,
      (if Array.isEmpty fields then "()" else String.Join(" ", fields)),
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))))

  let generateByType (t: Type) = [|
    yield String.Format(
      "//////////////////////////////////////////////\r\n" +
      "\r\n" +
      "/// <summary>\r\n" +
      "/// {0} cons definitions.\r\n" +
      "/// </summary>\r\n" +
      "[<AutoOpen>]\r\n" +
      "module {0} =\r\n",
      t.Name)
    yield! FSharpType.GetUnionCases t |> Seq.sortBy (fun t -> t.Name) |> Seq.map (generateByUnion t)
    yield "\r\n"
  |]

  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t -> (FSharpType.IsUnion t) && (t.DeclaringType = astType))
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.collect generateByType
