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

open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

type internal Bracket = {
  Left: string
  Right: string
}

[<Sealed>]
type internal AstVisitorGenerator() =
  inherit GeneratorBase()

  // TODO: Async<SynExpr> - replace all expr with Async/Async workflow/let! NO EXCEPTS, very hard...

  // Type pattern examples:
  // value                  --> value
  // Option<value>          --> value
  // List<values>           --> values
  // Option<List<values>>   --> values

  // synExpr                --> synExpr |> this.VisitSynExpr parents context
  // Option<synExpr>        --> synExpr |> Option.map (this.VisitSynExpr parents context)
  // List<synExprs>         --> synExprs |> List.map (this.VisitSynExpr parents context)
  // Option<List<synExprs>> --> synExprs |> Option.map (List.map (this.VisitSynExpr parents context))

  // Another way:
  // synExpr                --> this.VisitSynExpr parents context synExpr
  // Option<synExpr>        --> Option.map (this.VisitSynExpr parents context) synExprs
  // List<synExprs>         --> List.map (this.VisitSynExpr parents context) synExprs
  // Option<List<synExprs>> --> Option.map (List.map (this.VisitSynExpr parents context)) synExprs

  // SynAccess --> Access
  let formatUnionTypeShortName (unionType: Type) =
    unionType.Name.Substring 3

  // HACK: If casename = typename: compiler meaning 1st name is casename, cause 2nd name is invalid...
  // https://gitter.im/fsugjp/public?at=57a1776100663f5b1b46528e
  //   ...SynAccess.Public --> ...SynAccess.Public
  //   ...SynArgInfo.SynArgInfo --> ...SynArgInfo
  let formatUnionCaseName (unionType: Type) (unionCase: UnionCaseInfo) =
    if unionCase.Name = unionType.Name then
      Utilities.formatTypeName unionType
    else
      String.Format(
        "{0}.{1}",
        Utilities.formatTypeName unionType,
        unionCase.Name)

  let boolType = typeof<bool>
  let intType = typeof<int>
  let stringType = typeof<string>
  let astType = typeof<SynExpr>.DeclaringType

  let rec formatWithOperators (name: string) (t: Type) (exprs: IReadOnlyDictionary<Type, string>) =
    // "Array.map (fun v -> v) arg0"
    if t.IsArray then
      let elementType = t.GetElementType()
      String.Format(
        "{0} |> Array.map (fun v -> {1})",
        name,
        formatWithOperators "v" elementType exprs)
    // "(let v0, v1 = arg0 in v0, v1)"
    else if FSharpType.IsTuple t then
      let elementTypes = FSharpType.GetTupleElements t
      String.Format(
        "(let {0} = {1} in {2})",
        String.Join(
          ", ",
          elementTypes |> Seq.mapi (fun index _ -> "v" + index.ToString())),
        name,
        String.Join(
          ", ",
          elementTypes |> Seq.mapi (fun index elementType -> formatWithOperators ("v" + index.ToString()) elementType exprs)))
    // "{ V0 = arg0.V0; V1 = arg0.V1 }"
    else if FSharpType.IsRecord t then
      let fields = FSharpType.GetRecordFields t
      String.Format(
        "{{ {0} }}",
        String.Join(
          "; ",
          fields |> Seq.map (fun field -> String.Format("{0} = {1}", field.Name, formatWithOperators (name + "." + field.Name) field.PropertyType exprs))))
    // "this.VisitHoge context arg0"
    else if exprs.ContainsKey t then
      String.Format(
        "this.Visit{0} context {1}",
        formatUnionTypeShortName t,
        name)
    else if t.IsGenericType then
      let gas = t.GetGenericArguments()
      // "arg0 |> Option.map (fun v -> v)"
      if gas.Length = 1 then
        String.Format(
          "{0} |> {1}.map (fun v -> {2})",
          name,
          Utilities.formatSafeTypeName t,
          formatWithOperators "v" gas.[0] exprs)
      // "arg0"
      else
        name
    // "arg0"
    else
      name

  /// Construct expression string of visitor body with applied args for DU case.
  let formatArgument exprs (field: PropertyInfo) = 
    formatWithOperators (Utilities.formatFieldName field) field.PropertyType exprs

  /// Construct function strings for DU case.
  let generateByUnion exprs (unionType: Type) (unionCase: UnionCaseInfo) =
    let decls = [|
      yield "context: 'TContext"
      yield! unionCase.GetFields() |> Seq.map Utilities.formatDeclaration
    |]
    let args = [|
      yield "context"
      yield! unionCase.GetFields() |> Seq.map (formatArgument exprs)
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
      formatUnionTypeShortName unionType,
      Utilities.formatTypeName unionType,
      unionType.Name,
      unionCase.Name,
      formatUnionCaseName unionType unionCase,
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
      formatUnionCaseName unionType unionCase,
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))),
      formatUnionTypeShortName unionType,
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
      formatUnionTypeShortName unionType,
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
    let exprs = types.ToDictionary((fun t -> t), (fun t -> formatUnionTypeShortName t)) :> IReadOnlyDictionary<_, _>
    exprs.Keys |> Seq.collect (generateByType exprs)
