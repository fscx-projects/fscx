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
open System.Security

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

[<Sealed>]
type internal AstUnionConsGenerator() =
  inherit GeneratorBase()

  let generateByCase (t: Type) (c: UnionCaseInfo) =
    let typeName = Utilities.formatTypeName t
    let fields = c.GetFields()
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"{0}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed instance.</returns>\r\n" +
      "  let gen{2}({3}) =\r\n" +
      "    {1}\r\n" +
      "{4}" +
      "\r\n",
      SecurityElement.Escape (VisitorUtilities.formatUnionCaseName t c),
      VisitorUtilities.formatUnionCaseName t c,
      (if VisitorUtilities.requireQualifiedCaseName t then (typeName + "_" + c.Name) else c.Name),
      String.Join(", ", fields |> Seq.map Utilities.formatFieldName),
      (if fields.Length = 0 then "" else String.Format("      ({0})\r\n", String.Join(",\r\n       ", fields |> Seq.map Utilities.formatFieldName))))

  let generateByType (t: Type) =
    let cases = FSharpType.GetUnionCases t
    seq {
      yield "  ////////////////////////////////////////////////////\r\n" + "\r\n"
      yield! cases |> Seq.filter (fun c -> c.GetFields().Length >= 2) |> Seq.map (generateByCase t)
    }

  let isTargetDUType (t: Type) =
    let cases = FSharpType.GetUnionCases t
    cases |> Seq.exists (fun c -> c.GetFields().Length >= 2);

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
        (isTargetDUType t) &&
        (t.DeclaringType <> t.BaseType) &&
        (not (FSharpType.IsUnion t.BaseType)) &&
        (not (t.IsDefined(typeof<ObsoleteAttribute>, true)))
        // Conflict ILType, ignore...
        && (not ((Utilities.formatTypeFullName t) = "Microsoft.FSharp.Compiler.AbstractIL.IL.ILType")))
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.collect generateByType
