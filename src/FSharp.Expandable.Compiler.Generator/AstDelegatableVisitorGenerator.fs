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
type internal AstDelegatableVisitorGenerator() =
  inherit AstVisitorGeneratorBase()

  // TODO: Async<SynExpr> - replace all expr with Async/Async workflow/let! NO EXCEPTS, very hard...

  /// Construct function strings for DU case.
  let generateByUnion visitTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields()
    let decls = [|
      yield "visitor: AstDelegatableVisitor<'TContext>"
      yield "context: 'TContext"
      yield! fields |> Seq.map Utilities.formatDeclaration
    |]

    String.Format(
      "  /// <summary>\r\n" +
      "  /// Before visit \"{2}.{3}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"visitor\">Visitor instance.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed expression or None if defaulted.</returns>\r\n" +
      "  member val BeforeVisit{0}_{3} =\r\n" +
      "    fun\r\n" +
      "      ({5}) -> None\r\n" +
      "    with get, set\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{2}.{3}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"visitor\">Visitor instance.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed expression or None if defaulted.</returns>\r\n" +
      "  member val Visit{0}_{3} =\r\n" +
      "    fun\r\n" +
      "      ({5}) -> None\r\n" +
      "    with get, set\r\n" +
      "\r\n",
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatTypeName unionType,
      unionType.Name,
      unionCase.Name,
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      String.Join(",\r\n       ", decls))

  /// Construct expression string for match.
  let generateMatcher visitorTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields()
    let visited = fields |> Seq.map (VisitorUtilities.formatArgument visitorTargets "this" "_rwh_")
    let args = visited |> Seq.map fst |> Seq.toArray   // Composed argument string
    let isUsingRef = visited |> Seq.exists snd  // Require using reference cell
    let fieldNames = [|
      yield "this"
      yield "context"
      yield! fields |> Seq.map Utilities.formatFieldName
    |]
    let decls = fields |> Seq.map Utilities.formatFieldName |> Seq.toArray
    
    String.Format(
      "      | {0}{1} ->\r\n" +
      "        match this.BeforeVisit{2}_{3}({4}) with\r\n" +
      "        | Some result -> result\r\n" +
      "        | None ->\r\n" +
      "{5}" +
      "{6}" +
      "          match this.Visit{2}_{3}({4}) with\r\n" +
      "          | Some result -> result\r\n" +
      "          | None -> {0}{1}\r\n",
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      (if decls.Length = 0 then "" else String.Format("({0})", String.Join(", ", decls))),
      VisitorUtilities.formatUnionTypeShortName unionType,
      unionCase.Name,
      String.Join(", ", fieldNames),
      (if isUsingRef then "          use _rwh_ = new RefWrapperHolder()\r\n" else ""),
      (if decls.Length = 0 then "" else String.Format("          let {0} = {1}\r\n", String.Join(", ", decls), String.Join(", ", args))))

  /// <summary>
  /// Generate lines by type declaration.
  /// </summary>
  /// <param name="visitorTargets">Targets for require invoke visitor.</param>
  /// <param name="unionType">Target DU type.</param>
  /// <returns>Generated lines.</returns>
  override __.GenerateByType visitorTargets (unionType: Type) = [|
    yield String.Format(
      "  //////////////////////////////////////////////\r\n" +
      "  // Expression: {0}\r\n" +
      "\r\n",
      unionType.Name)
    yield! FSharpType.GetUnionCases unionType |> Seq.map (generateByUnion visitorTargets unionType)
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
      "    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.{1} {2})\r\n" +
      "    try\r\n" +
      "      match {2} with\r\n",
      unionType.Name,
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatCamelcase unionType.Name,
      Utilities.formatTypeName unionType)
    let unionCases = FSharpType.GetUnionCases unionType
    yield! unionCases |> Seq.map (generateMatcher visitorTargets unionType)
    yield
      "    finally\r\n" +
      "      parents.Pop() |> ignore\r\n" +
      "\r\n"
  |]
