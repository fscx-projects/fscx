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

open System
open System.IO
open System.Reflection
open System.Text

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

let rec formatTypeName (t: Type) : string =
  if t.IsArray then
    let elementTypeName = formatTypeName (t.GetElementType())
    String.Format(
      "{0}[]",
      elementTypeName)
  else if FSharpType.IsTuple t then
    let tupleSignature =
      String.Join(" * ", FSharpType.GetTupleElements t |> Seq.map formatTypeName)
    String.Format(
      "({0})",
      tupleSignature)
  else
    let safeName =
      let cna = t.GetCustomAttribute<CompiledNameAttribute>()
      let name =
        if cna = Unchecked.defaultof<_> then t.Name
        else cna.CompiledName
      let name =
        match t.IsGenericType with
        | true -> name.Substring(0, name.IndexOf('`'))
        | false -> name
      match t.Namespace, name.StartsWith "FSharp" with
      | "Microsoft.FSharp.Core", true
      | "Microsoft.FSharp.Collections", true -> name.Substring(6)
      | _ -> name
    let safeTypeName =
      match t.DeclaringType with
      | null -> String.Format("{0}.{1}", t.Namespace, safeName)
      | declaringType -> String.Format("{0}.{1}", formatTypeName declaringType, safeName)
    match t.IsGenericType with
    | false -> safeTypeName
    | true ->
      let genericArgumentSignature =
        String.Join(", ", t.GetGenericArguments() |> Seq.map formatTypeName)
      String.Format(
        "{0}<{1}>",
        safeTypeName,
        genericArgumentSignature)

let formatFieldType (field: PropertyInfo) =
  formatTypeName field.PropertyType

let formatFieldName (field: PropertyInfo) =
  Char.ToLowerInvariant(field.Name.[0]).ToString() + field.Name.Substring(1)

let formatDeclaration (field: PropertyInfo) =
  String.Format(
    "{0}: {1}",
    formatFieldName field,
    formatFieldType field)

let readTemplate () =
  use fs = Assembly.GetExecutingAssembly().GetManifestResourceStream("AstVisitorTemplate.fs")
  let tr = new StreamReader(fs, Encoding.UTF8)
  tr.ReadToEnd()

[<EntryPoint>]
let main argv = 

  // TODO: nested SynExpr types
  let objlistType = typedefof<obj list>
  let formatArgument0 (source: string) (t: Type) =
    if typeof<SynExpr>.IsAssignableFrom t then
      String.Format(
        "{0} (this.VisitSynExpr parents context)",
        source)
    else
      source
  let formatArgument (field: PropertyInfo) =
    let t = field.PropertyType
    if t.IsGenericType then
      let gtd = t.GetGenericTypeDefinition()
      if gtd = objlistType then
        let ta = t.GetGenericArguments().[0]
        formatArgument0 (String.Format("{0} |> List.map", formatFieldName field)) ta
      else
        formatArgument0 (String.Format("{0} |>", formatFieldName field)) t
    else
      formatArgument0 (String.Format("{0} |>", formatFieldName field)) t

  let formatPlace0 (unionCase: UnionCaseInfo) =
    let decls = unionCase.GetFields() |> Seq.map formatDeclaration |> Seq.toArray
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    let args = unionCase.GetFields() |> Seq.map formatArgument |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Pre visit \"{0}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Pre visited arguments.</returns>\r\n" +
      "  member this.PreVisit{0} parents context {2} =\r\n" +
      "    {3}\r\n" +
      "\r\n" +
      "  abstract member Visit{0}: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> {1} -> Microsoft.FSharp.Compiler.Ast.SynExpr\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  default this.Visit{0} parents context {2} =\r\n" +
      "    let args = this.PreVisit{0} parents context {2}\r\n" +
      "    Microsoft.FSharp.Compiler.Ast.SynExpr.{0} args\r\n",
      unionCase.Name,
      String.Join(" -> ", decls),
      String.Join(" ", fields),
      String.Join(", ", args))
  let place0 =
    String.Join(
      "\r\n",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace0)

  let formatPlace1 (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    String.Format(
      "    | Microsoft.FSharp.Compiler.Ast.SynExpr.{0}({1}) ->\r\n      this.Visit{0} currentParents context {2}\r\n",
      unionCase.Name,
      String.Join(", ", fields),
      String.Join(" ", fields))
  let place1 =
    String.Join(
      "",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace1)

  let template = readTemplate()
  let formatted = String.Format(template, DateTime.UtcNow, place0, place1)

  File.WriteAllText(argv.[0], formatted)
  0
