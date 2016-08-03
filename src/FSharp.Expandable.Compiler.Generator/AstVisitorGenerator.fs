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

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

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

  /// Construct expression string of recursive visitor invoker.
  let rec formatVisitOperators (unionName: string) (opers: string list) =
    if List.isEmpty opers then
      String.Format(
        "this.Visit{0} context",
        unionName)
    else
      String.Format(
        "{0} ({1})",
        List.head opers,
        formatVisitOperators unionName (List.skip 1 opers))

  /// Construct expression string of visitor body with applied args.
  let rec formatArgument0 name (fieldType: Type) (opers: string list) (exprs: IReadOnlyDictionary<Type, Type>) =
    if exprs.ContainsKey fieldType then
      String.Format(
        "{0} |> ({1})",
        name,
        formatVisitOperators (formatUnionTypeShortName fieldType) opers)
    else if fieldType.IsGenericType = false then
      name
    else
      let genericArguments = fieldType.GetGenericArguments()
      if genericArguments.Length <> 1 then
        name
      else
        // Auto mapping supported only Option<> or List<>.
        let outerType = fieldType.GetGenericTypeDefinition()
        let innerType = genericArguments.[0]
        if outerType = typedefof<Option<obj>> then
          formatArgument0 name innerType ("Option.map" :: opers) exprs
        else if outerType = typedefof<List<obj>> then
          formatArgument0 name innerType ("List.map" :: opers) exprs
        else
          name

  /// Construct expression string of visitor body with applied args for DU case.
  let formatArgument exprs (field: PropertyInfo) = 
    formatArgument0 (Utilities.formatFieldName field) field.PropertyType [] exprs

  /// Construct function strings for DU case.
  let generateByUnion exprs (unionType: Type) (unionCase: UnionCaseInfo) =
    let decls = [|
      yield! unionCase.GetFields() |> Seq.map Utilities.formatDeclaration
      yield "context: 'TContext"
    |]
    let args = [|
      yield! unionCase.GetFields() |> Seq.map (formatArgument exprs)
      yield "context"
    |]
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Before visit \"{2}.{3}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}_{3}\".</remarks>\r\n" +
      "  abstract member BeforeVisit{0}_{3}: {5} -> {1}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Before visit \"{2}.{3}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}_{3}\".</remarks>\r\n" +
      "  default this.BeforeVisit{0}_{3}({6}) =\r\n" +
      "    this.Visit{0}_{3}({7})\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{2}.{3}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"{2}.{3}\".</remarks>\r\n" +
      "  abstract member Visit{0}_{3}: {5} -> {1}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{2}.{3}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"{2}.{3}\".</remarks>\r\n" +
      "  default __.Visit{0}_{3}({6}) =\r\n" +
      "    {4}{8}\r\n" +
      "\r\n",
      formatUnionTypeShortName unionType,
      Utilities.formatTypeName unionType,
      unionType.Name,
      unionCase.Name,
      formatUnionCaseName unionType unionCase,
      String.Join(" * ", decls),
      String.Join(", ", decls),
      String.Join(", ", args),
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))))

  /// Construct expression string for match.
  let generateMatcher (unionType: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    let args = [|
      yield! fields
      yield "context"
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
      "  member this.Visit{1} (context: 'TContext) ({2}: {3}) =\r\n" +
      "    parents.Push(AstElement.{1} {2})\r\n" +
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
    let exprs = Enumerable.ToDictionary(types, fun t -> t) :> IReadOnlyDictionary<_, _>
    exprs.Keys |> Seq.collect (generateByType exprs)
