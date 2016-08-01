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

  let rec formatOperator (opers: string list) =
    if List.isEmpty opers then
      "(this.VisitSynExpr parents context)"
    else
      String.Format(
        "({0} {1})",
        List.head opers,
        formatOperator (List.skip 1 opers))

  let rec formatArgument0 name (t: Type) (opers: string list) =
    if t = typeof<SynExpr> then
      String.Format(
        "({0} |> {1})",
        name,
        formatOperator opers)
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
          formatArgument0 name innerType ("Option.map" :: opers)
        else if outerType = typedefof<List<obj>> then
          formatArgument0 name innerType ("List.map" :: opers)
        else
          name

  let formatArgument (field: PropertyInfo) =
    formatArgument0 (formatFieldName field) field.PropertyType []

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
      "    Microsoft.FSharp.Compiler.Ast.SynExpr.{0}({2})\r\n",
      unionCase.Name,
      String.Join(" ", fields),
      String.Join(", ", fields))
  let place1 =
    String.Join(
      "\r\n",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace1)

  //////////////////////////////////
  // {2}

  let formatPlace2 (unionCase: UnionCaseInfo) =
    let decls = unionCase.GetFields() |> Seq.map formatDeclaration |> Seq.toArray
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    let args = unionCase.GetFields() |> Seq.map formatArgument |> Seq.toArray
    String.Format(
      "  /// <summary>\r\n" +
      "  /// Before visit \"{0}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}\".</remarks>\r\n" +
      "  abstract member BeforeVisit{0}: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> {1} -> Microsoft.FSharp.Compiler.Ast.SynExpr\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Before visit \"{0}\" arguments.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"Visit{0}\".</remarks>\r\n" +
      "  default this.BeforeVisit{0} parents context {2} =\r\n" +
      "    this.Visit{0} parents context {3}\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"SynExpr.init{0}\".</remarks>\r\n" +
      "  abstract member Visit{0}: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> {1} -> Microsoft.FSharp.Compiler.Ast.SynExpr\r\n" +
      "\r\n" +
      "  /// <summary>\r\n" +
      "  /// Visit \"{0}\" expression.\r\n" +
      "  /// </summary>\r\n" +
      "  /// <param name=\"parents\">Parent expression list.</param>\r\n" +
      "  /// <param name=\"context\">Context object.</param>\r\n" +
      "  /// <returns>Constructed (or target) expression.</returns>\r\n" +
      "  /// <remarks>Default implementation invoked \"SynExpr.init{0}\".</remarks>\r\n" +
      "  default __.Visit{0} parents context {2} =\r\n" +
      "    SynExpr.init{0} {2}\r\n",
      unionCase.Name,
      String.Join(" -> ", decls),
      String.Join(" ", fields),
      String.Join(" ", args))
  let place2 =
    String.Join(
      "\r\n",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace2)

  //////////////////////////////////
  // {3}

  let formatPlace3 (unionCase: UnionCaseInfo) =
    let fields = unionCase.GetFields() |> Seq.map formatFieldName |> Seq.toArray
    String.Format(
      "    | Microsoft.FSharp.Compiler.Ast.SynExpr.{0}({1}) ->\r\n      this.BeforeVisit{0} currentParents context {2}\r\n",
      unionCase.Name,
      String.Join(", ", fields),
      String.Join(" ", fields))
  let place3 =
    String.Join(
      "",
      FSharpType.GetUnionCases typeof<SynExpr> |> Seq.map formatPlace3)

  //////////////////////////////////

  let template = readTemplate()
  let formatted = String.Format(template, DateTime.UtcNow, place1, place2, place3)

  File.WriteAllText(argv.[0], formatted)
  0
