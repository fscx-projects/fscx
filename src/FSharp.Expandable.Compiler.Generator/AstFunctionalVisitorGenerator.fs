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

open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type internal AstFunctionalVisitorGenerator() =
  inherit AstVisitorGeneratorBase()

  // TODO: Async<SynExpr> - replace all expr with Async/Async workflow/let! NO EXCEPTS, very hard...

  let generateByUnion visitorTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields()
    let fieldNames = fields |> Seq.map Utilities.formatFieldName |> Seq.toArray
    let visited = fields |> Seq.map (VisitorUtilities.formatArgument visitorTargets "visit{0} f context" "_rwh_")
    let args = visited |> Seq.map fst |> Seq.toArray   // Composed argument string
    let isUsingRef = visited |> Seq.exists snd  // Require using reference cell
    String.Format(
      "    | {0}{1} ->\r\n" +
      "{2}" +
      "      {0}{3}\r\n",
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      (if fieldNames.Length = 0 then "" else String.Format("({0})", String.Join(", ", fieldNames))),
      (if isUsingRef then "      use _rwh_ = new RefWrapperHolder()\r\n" else ""),
      (if args.Length = 0 then "" else String.Format("({0})", String.Join(", ", args))))

  /// <summary>
  /// Generate lines by type declaration.
  /// </summary>
  /// <param name="visitorTargets">Targets for require invoke visitor.</param>
  /// <param name="unionType">Target DU type.</param>
  /// <returns>Generated lines.</returns>
  override __.GenerateByType visitorTargets (unionType: Type) = [|
    yield String.Format(
      "\r\n" +
      "  //////////////////////////////////////////////\r\n" +
      "  // Expression: {0}\r\n" +
      "  and visit{1} f context (target: {2}) =\r\n" +
      "    match target with\r\n",
      unionType.Name,
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatTypeName unionType)
    yield! FSharpType.GetUnionCases unionType |> Seq.map (generateByUnion visitorTargets unionType)
  |]
