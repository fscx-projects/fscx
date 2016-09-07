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
type internal AstRecordConsGenerator() =
  inherit GeneratorBase()
  
  let generateByType (t: Type) =
#if aaa
    let tn =
      match t.IsDefined(typeof<RequireQualifiedAccessAttribute>, true) with
      | true -> (Utilities.formatSafeTypeName t) + "."
      | false -> ""
#else
    let tn = (Utilities.formatSafeTypeName t) + "."
#endif
    let fields = FSharpType.GetRecordFields t
    let args = fields |> Array.map (fun field -> String.Format("({0})", Utilities.formatDeclaration field))
    let inits = fields |> Array.map (fun field -> String.Format("{0} = {1}", tn + field.Name, Utilities.formatFieldName field))
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"{0}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed record.</returns>\r\n" +
      "  let init{1}\r\n" +
      "     {2} =\r\n" +
      "    {{ {3} }}\r\n" +
      "\r\n",
      Utilities.formatTypeName t,
      t.Name,
      String.Join("\r\n     ", args),
      String.Join(";\r\n      ", inits))

  /// <summary>
  /// Generate body lines.
  /// </summary>
  /// <returns>Generated lines.</returns>
  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t -> (FSharpType.IsRecord t) && (not t.IsGenericType) && (t.Namespace.StartsWith "Microsoft.FSharp.Compiler") && ((FSharpType.GetRecordFields t).Length >= 1))
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.map generateByType
