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
type internal AstVisitorGenerator() =
  inherit GeneratorBase()
  
  let generateByUnion (t: Type) (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map Utilities.formatFieldName |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"{0}.{1}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed expression.</returns>\r\n" +
      "  let init{1} {2} =\r\n" +
      "    {0}.{1}{3}\r\n",
      t.Name,
      unionCase.Name,
      (if Array.isEmpty fields then "()" else String.Join(" ", fields)),
      (if Array.isEmpty fields then "" else String.Format("({0})", String.Join(", ", fields))))

  let generateByType (t: Type) = [|
    yield String.Format(
      "//////////////////////////////////////////////\r\n" +
      "\r\n" +
      "/// <summary>\r\n" +
      "/// {0} cons definitions.\r\n" +
      "/// </summary>\r\n" +
      "[<AutoOpen>]\r\n" +
      "module {0} =\r\n",
      t.Name)
    yield! FSharpType.GetUnionCases t |> Seq.sortBy (fun t -> t.Name) |> Seq.map (generateByUnion t)
    yield "\r\n"
  |]

  override __.GenerateBodies () =
    let astType = typeof<SynExpr>.DeclaringType
    let assembly = astType.Assembly
    let types =
      assembly.GetTypes()
      |> Seq.filter (fun t -> (FSharpType.IsUnion t) && (t.DeclaringType = astType))
      |> Seq.sortBy (fun t -> t.Name)
    types |> Seq.collect generateByType


#if aaa
type internal AstConsGenerator() =

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

  let rec formatSynExprOperators isAsync (opers: string list) =
    if List.isEmpty opers then
      String.Format(
        "(fun expr -> this.{0}VisitSynExpr expr context)",
        (if isAsync then "Async" else ""))
    else
      String.Format(
        "({0} {1})",
        List.head opers,
        formatSynExprOperators isAsync (List.skip 1 opers))

  let rec formatArgument0 isAsync name (t: Type) (opers: string list) =
    if t = typeof<SynExpr> then
      String.Format(
        "({0} |> {1})",
        name,
        formatSynExprOperators isAsync opers)
    else if t.IsGenericType = false then
      name
    else
      let genericArguments = t.GetGenericArguments()
      if genericArguments.Length <> 1 then
        name
      else
        // Auto mapping supported only Option<> or List<>.
        let outerType = t.GetGenericTypeDefinition()
        let innerType = genericArguments.[0]
        if outerType = typedefof<Option<obj>> then
          formatArgument0 isAsync name innerType ("Option.map" :: opers)
        else if outerType = typedefof<List<obj>> then
          formatArgument0 isAsync name innerType ("List.map" :: opers)
        else
          name

  let formatArgument isAsync (field: PropertyInfo) = 
    formatArgument0 isAsync (formatFieldName field) field.PropertyType []

  let astType = typeof<SynExpr>.DeclaringType
  let assembly = astType.Assembly
  let types = assembly.GetTypes()
  let unionTypes =
    types |> Array.filter (fun t -> t.IsNestedPublic && (FSharpType.IsUnion t))
  let astUnionTypes =
    unionTypes |> Array.filter (fun t -> t.DeclaringType = astType)

  //////////////////////////////////
  // {1}

  let formatPlace1 (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Construct \"SynExpr.{0}\".\r\n" +
      "  /// </summary>\r\n" +
      "  /// <returns>Constructed expression.</returns>\r\n" +
      "  let init{0} {1} =\r\n" +
      "    SynExpr.{0}({2})\r\n",
      unionCase.Name,
      String.Join(" ", fields),
      String.Join(", ", fields))
  let place1 =
    String.Join(
      "\r\n",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace1)

  //////////////////////////////////
  // {2}

  let formatPlace2 isAsync (unionCase: UnionCaseInfo) =
    let decls = unionCase.GetFields() |> Seq.map formatDeclaration |> Seq.toArray
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    let args = unionCase.GetFields() |> Seq.map (formatArgument isAsync) |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Before visit \"{0}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}\".</remarks>\r\n" +
      "  abstract member {4}BeforeVisit{0}: {1} -> context: 'TContext -> {8}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Before visit \"{0}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}\".</remarks>\r\n" +
      "  default this.{4}BeforeVisit{0} {2} context =\r\n" +
      "    this.{4}Visit{0} {3} context\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"SynExpr.init{0}\".</remarks>\r\n" +
      "  abstract member {4}Visit{0}: {2} -> context: 'TContext -> {8}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"SynExpr.init{0}\".</remarks>\r\n" +
      "  default __.{4}Visit{0} {2} context {5}\r\n" +
      "    {7}SynExpr.init{0} {2}\r\n" +
      "{6}",
      unionCase.Name,
      String.Join(" -> ", decls),
      String.Join(" ", fields),
      String.Join(" ", args),
      (if isAsync then "Async" else ""),
      (if isAsync then "= async {" else "="),
      (if isAsync then "  }" else ""),
      (if isAsync then "return " else ""),
      (if isAsync then "Async<SynExpr>" else "SynExpr"))
  let place2 isAsync =
    String.Join(
      "\r\n",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map (formatPlace2 isAsync))

  //////////////////////////////////
  // {3}

  let formatPlace3 isAsync (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    String.Format(
      "      | SynExpr.{0}({1}) ->\r\n        this.{3}BeforeVisit{0} {2} context\r\n",
      unionCase.Name,
      String.Join(", ", fields),
      String.Join(" ", fields),
      (if isAsync then "Async" else ""))
  let place3 isAsync =
    String.Join(
      "",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map (formatPlace3 isAsync))

  //////////////////////////////////

  let template = readTemplate()
  let formatted = String.Format(template, DateTime.UtcNow, place1, place2 false, place3 false)

  File.WriteAllText(argv.[0], formatted)
  0
#endif
