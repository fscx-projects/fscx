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

  // TODO: FunctionalVisitor can delegation only SynExpr (arg "fv" is 'TC -> SynExpr -> SynExpr).
  //   If can handling any AST types, fv is required holding all AST types mapped delegated visitors.
  //   Sounds like AstDelegatableVisitors...

  let generateByUnion visitorTargets (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields()
    let fieldNames = fields |> Seq.map Utilities.formatFieldName |> Seq.toArray
    let visited = fields |> Seq.map (VisitorUtilities.formatArgument visitorTargets "visit{0} context {1} dlgVisitor" "_rwh_")
    let args = visited |> Seq.map (fun vr -> vr.ToString()) |> Seq.toArray   // Composed argument string
    let isProjected = visited |> Seq.exists (function Projected _ -> true | _ -> false) // Args projected?
    let isUsingRef = visited |> Seq.exists (fun vr -> vr.IsUsingRef)  // Require using reference cell
    match isProjected with
    | true ->
      String.Format(
        "    | {0}{1} ->\r\n" +
        "{2}" +
        "      {0}\r\n" +
        "        {3}\r\n",
        VisitorUtilities.formatUnionCaseName unionType unionCase,
        (if fieldNames.Length = 0 then "" else String.Format("({0})", String.Join(", ", fieldNames))),
        (if isUsingRef then "      use _rwh_ = new RefWrapperHolder()\r\n" else ""),
        (if args.Length = 0 then "" else String.Format("({0})", String.Join(",\r\n         ", args))))
    | false ->
      String.Format(
        "    | {0} _ -> target\r\n",
        VisitorUtilities.formatUnionCaseName unionType unionCase)

  /// <summary>
  /// Generate lines by type declaration.
  /// </summary>
  /// <param name="visitorTargets">Targets for require invoke visitor.</param>
  /// <param name="unionType">Target DU type.</param>
  /// <returns>Generated lines.</returns>
  override __.GenerateByType visitorTargets (unionType: Type) = [|
    let header =
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Expression visitor function: {0}\r\n" +
      "  /// </summary>\r\n" +
      "  /// <typeparam name=\"'TContext\">Context instance type.</typeparam>\r\n" +
      "  /// <param name=\"context\">Context instance.</param>\r\n" +
      "  /// <param name=\"target\">Visit target expression.</param>\r\n" +
      "  /// <param name=\"dlgVisitor\">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>\r\n" +
      "  /// <returns>Visited expression.</returns>\r\n"
    let isSynExpr = unionType = typeof<SynExpr>
    yield String.Format(
      header +
      "  and {3}visit{1}\r\n" +
      "     (context: 'TContext)\r\n" +
      "     (target: {2})\r\n" +
      //     vvv --- hard coded delegation type is SynExpr.
      "     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =\r\n" +
      "    match target with\r\n",
      unionType.Name,
      VisitorUtilities.formatUnionTypeShortName unionType,
      Utilities.formatTypeFullName unionType,
      if isSynExpr then "private __" else "")
    yield! FSharpType.GetUnionCases unionType |> Seq.map (generateByUnion visitorTargets unionType)
    if isSynExpr then
      yield String.Format(
        header +
        "  and visitExpr\r\n" +
        "     (context: 'TContext)\r\n" +
        "     (target: SynExpr)\r\n" +
        //     vvv --- hard coded delegation type is SynExpr.
        "     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =\r\n" +
        "    match dlgVisitor context target with\r\n" +
        "    | Some expr -> expr\r\n" +
        "    | None -> __visitExpr context target dlgVisitor\r\n",
        "SynExpr")
  |]
