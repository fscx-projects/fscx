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
type internal AstUnionConsGenerator() =
  inherit GeneratorBase()

  let generateByCase (t: Type) (c: UnionCaseInfo) =
    let fields = c.GetFields()
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"{0}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed record.</returns>\r\n" +
      "  let gen{1} {2} =\r\n" +
      "    {0}\r\n" +
      "{3}" +
      "\r\n",
      VisitorUtilities.formatUnionCaseName t c,
      c.Name,
      (if fields.Length = 0 then "()" else String.Join(" ", fields |> Seq.map Utilities.formatFieldName)),
      (if fields.Length = 0 then "" else String.Format("      ({0})\r\n", String.Join(",\r\n       ", fields |> Seq.map Utilities.formatFieldName))))

  let generateByType (t: Type) =
    let cases = FSharpType.GetUnionCases t
    seq {
      yield String.Format(
        "  ////////////////////////////////////////////////////\r\n" +
        "  /// Construct \"{0}\".\r\n" +
        "\r\n",
        Utilities.formatTypeName t)
      yield! cases |> Seq.map (generateByCase t)
    }

 /// <summary>
  /// Generate body lines.
  /// </summary>
  /// <returns>Generated lines.</returns>
  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t ->
        (FSharpType.IsUnion t) &&
        (t.Namespace.StartsWith "Microsoft.FSharp.Compiler") &&
        ((FSharpType.GetUnionCases t).Length >= 1) &&
        (t.DeclaringType <> t.BaseType) &&
        (not (FSharpType.IsUnion t.BaseType)) &&
        (not (t.IsDefined(typeof<ObsoleteAttribute>, true)))
        // Conflict ILType, ignore...
        && (not ((Utilities.formatTypeName t) = "Microsoft.FSharp.Compiler.AbstractIL.IL.ILType"))
        )
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.collect generateByType
