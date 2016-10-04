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
open System.Security

open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type internal AstInheritableVisitorGenerator() =
  inherit AstVisitorGeneratorBase()

  // TODO: Async<SynExpr> - replace all expr with Async/Async workflow/let! NO EXCEPTS, very hard...

  /// Construct function strings for DU case.
  let generateByUnion visitTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields()
    let decls = [|
      yield "context: 'TContext"
      yield! fields |> Seq.map Utilities.formatDeclaration
    |]
    let visited = fields |> Seq.map (VisitorUtilities.formatArgument visitTargets "this.Visit{0} context {1}" "_rwh_")
    let args = [|
      yield "context"
      yield! visited |> Seq.map (fun vr -> vr.ToString())   // Composed argument string
    |]
    let isUsingRef = visited |> Seq.exists (fun vr -> vr.IsUsingRef)   // Require using reference cell
    let fieldNames = fields |> Seq.map Utilities.formatFieldName |> Seq.toArray

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
      "{9}" +
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
      Utilities.formatTypeFullName unionType,
      SecurityElement.Escape unionType.Name,
      unionCase.Name,
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      String.Join(" *\r\n    ", decls),
      String.Join(",\r\n      ", decls),
      String.Join(",\r\n      ", args),
      (if Array.isEmpty fieldNames then "" else String.Format("({0})", String.Join(", ", fieldNames))),
      if isUsingRef then "    use _rwh_ = new RefWrapperHolder()\r\n" else "")

  /// Construct expression string for match.
  let generateMatcher (unionType: Type) (unionCase: UnionCaseInfo) =
    let fieldNames = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    let args = [|
      yield "context"
      yield! fieldNames
    |]
    String.Format(
      "      | {0}{1} ->\r\n        this.BeforeVisit{2}_{3}({4})\r\n",
      VisitorUtilities.formatUnionCaseName unionType unionCase,
      (if Array.isEmpty fieldNames then "" else String.Format("({0})", String.Join(", ", fieldNames))),
      VisitorUtilities.formatUnionTypeShortName unionType,
      unionCase.Name,
      String.Join(", ", args))

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
      SecurityElement.Escape unionType.Name,
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatCamelcase unionType.Name,
      Utilities.formatTypeFullName unionType)
    let unionCases = FSharpType.GetUnionCases unionType
    yield! unionCases |> Seq.map (generateMatcher unionType)
    yield
      "    finally\r\n" +
      "      parents.Pop() |> ignore\r\n" +
      "\r\n"
  |]
  
  /// <summary>
  /// Generate body lines.
  /// </summary>
  /// <returns>Generated lines.</returns>
  override __.GenerateBodies () =
    let lines = base.GenerateBodies()
    seq {
     yield! lines
     yield "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit the parsed input (Entry point).\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"symbolInformation\">Symbol information.</param>\r\n" +
      "  /// <param name=\"parsedInput\">Target for ParsedInput instance.</param>\r\n" +
      "  /// <returns>Visited instance.</returns>\r\n" +
      "  member this.Visit(symbolInformation, parsedInput) = \r\n" +
      "    symInf <- Some symbolInformation\r\n" +
      "    try\r\n" +
      "      this.VisitInput (new 'TContext()) parsedInput\r\n" +
      "    finally\r\n" +
      "      symInf <- None\r\n"
     yield "\r\n" +
      "  interface IAstVisitor with\r\n" +
      "    /// <summary>\r\n" +
      "    /// Visit the parsed input (Entry point).\r\n" +
      "    /// </summary>\r\n" +
      "    /// <param name=\"symbolInformation\">Symbol information.</param>\r\n" +
      "    /// <param name=\"parsedInput\">Target for ParsedInput instance.</param>\r\n" +
      "    /// <returns>Visited instance.</returns>\r\n" +
      "    member this.Visit(symbolInformation, parsedInput) = \r\n" +
      "      this.Visit(symbolInformation, parsedInput)\r\n" +
      "\r\n"
  }
