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

[<Sealed>]
type internal AstInheritableVisitorGenerator() =
  inherit GeneratorBase()

  // TODO: Async<SynExpr> - replace all expr with Async/Async workflow/let! NO EXCEPTS, very hard...

  /// Construct function strings for DU case.
  let generateByUnion visitTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let decls = [|
      yield "context: 'TContext"
      yield! unionCase.GetFields() |> Seq.map Utilities.formatDeclaration
    |]
    let args = [|
      yield "context"
      yield! unionCase.GetFields() |> Seq.map (VisitorUtilities.formatArgument visitTargets "this")
    |]
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Before visit \"{2}.{3}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}_{3}\".</remarks>\r\n" +
      "  abstract member BeforeVisit{0}_{3}:\r\n" +
      "    {5} -> {1}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Before visit \"{2}.{3}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}_{3}\".</remarks>\r\n" +
      "  default this.BeforeVisit{0}_{3}\r\n" +
      "     ({6}) =\r\n" +
      "    this.Visit{0}_{3}(\r\n" +
      "      {7})\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{2}.{3}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"{2}.{3}\".</remarks>\r\n" +
      "  abstract member Visit{0}_{3}:\r\n" +
      "    {5} -> {1}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{2}.{3}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"{2}.{3}\".</remarks>\r\n" +
      "  default __.Visit{0}_{3}\r\n" +
      "     ({6}) =\r\n" +
      "    {4}{8}\r\n" +
      "\r\n",
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatTypeName unionType,
      unionType.Name,
      unionCase.Name,
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      String.Join(" *\r\n    ", decls),
      String.Join(",\r\n      ", decls),
      String.Join(",\r\n      ", args),
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))))

  /// Construct expression string for match.
  let generateMatcher (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    let args = [|
      yield "context"
      yield! fields
    |]
    String.Format(
      "      | {0}{1} ->\r\n        this.BeforeVisit{2}_{3}({4})\r\n",
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))),
      VisitorUtilities.formatUnionTypeShortName unionType,
      unionCase.Name,
      String.Join(", ", args))

  let generateByType exprs (unionType: Type) = [|
    yield String.Format(
      "  //////////////////////////////////////////////\r\n" +
      "  // Expression: {0}\r\n" +
      "\r\n",
      unionType.Name)
    yield! FSharpType.GetUnionCases unionType |> Seq.map (generateByUnion exprs unionType)
    yield "\r\n"
    yield String.Format(
      "  /// <summary>\r\n" +
      "  /// Visit and dispatch \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <param name=\"{2}\">{0} expression.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  member this.Visit{1}\r\n" +
      "      (context: 'TContext)\r\n" +
      "      ({2}: {3}) =\r\n" +
      "    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.{1} {2})\r\n" +
      "    try\r\n" +
      "      match {2} with\r\n",
      unionType.Name,
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatCamelcase unionType.Name,
      Utilities.formatTypeName unionType)
    let unionCases = FSharpType.GetUnionCases unionType
    yield! unionCases |> Seq.map (generateMatcher unionType)
    yield
      "    finally\r\n" +
      "      parents.Pop() |> ignore\r\n" +
      "\r\n"
  |]

  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t -> (FSharpType.IsUnion t) && (t.DeclaringType = astType) && (t.Name.StartsWith "Syn"))
      |> Seq.sortBy (fun t -> t.Name)
    let exprs = types.ToDictionary((fun t -> t), (fun t -> VisitorUtilities.formatUnionTypeShortName t)) :> IReadOnlyDictionary<_, _>
    exprs.Keys |> Seq.collect (generateByType exprs)
