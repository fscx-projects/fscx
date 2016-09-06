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
open System.IO
open System.Reflection
open System.Text

open Microsoft.FSharp.Core
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Compiler.Ast

module internal Utilities =

 let rec formatSafeTypeName (t: Type) : string =
    // Basic name
    let safeName =
      let cna = t.GetCustomAttribute<CompiledNameAttribute>()
      let name =
        if cna = Unchecked.defaultof<_> then t.Name
        else cna.CompiledName
      let name =
        match t.IsGenericType with
        // Remove generic parameter
        | true -> name.Substring(0, name.IndexOf('`'))
        | false -> name
      // If F#'s short naming: FSharpOption --> Option
      match t.Namespace, name.StartsWith "FSharp" with
      | "Microsoft.FSharp.Core", true
      | "Microsoft.FSharp.Collections", true -> name.Substring(6)
      | _ -> name
    // Safe type name
    match t.DeclaringType with
    | null -> String.Format("{0}.{1}", t.Namespace, safeName)
    | declaringType -> String.Format("{0}.{1}", formatSafeTypeName declaringType, safeName)

 let rec private formatTypeName0 (t: Type) : string =
  // Array
  if t.IsArray then
    let elementTypeName = formatTypeName0 (t.GetElementType())
    String.Format(
      "{0}[]",
      elementTypeName)
  // F# tuple
  else if FSharpType.IsTuple t then
    let tupleSignature =
      String.Join(" * ", FSharpType.GetTupleElements t |> Seq.map formatTypeName0)
    String.Format(
      "({0})",
      tupleSignature)
  // F# function
  else if FSharpType.IsFunction t then
    let argType, returnType =
      FSharpType.GetFunctionElements t
    String.Format(
      "({0} -> {1})",
      formatTypeName0 argType,
      formatTypeName0 returnType)
  else
    // Basic name
    let safeName =
      let cna = t.GetCustomAttribute<CompiledNameAttribute>()
      let name =
        if cna = Unchecked.defaultof<_> then t.Name
        else cna.CompiledName
      let name =
        match t.IsGenericType with
        // Remove generic parameter
        | true -> name.Substring(0, name.IndexOf('`'))
        | false -> name
      // If F#'s short naming: FSharpOption --> Option
      match t.Namespace, name.StartsWith "FSharp" with
      | "Microsoft.FSharp.Core", true
      | "Microsoft.FSharp.Collections", true -> name.Substring(6)
      | _ -> name
    // Safe type name
    let safeTypeName =
      match t.DeclaringType with
      | null -> String.Format("{0}.{1}", t.Namespace, safeName)
      | declaringType ->
        // TODO: Infinite recursivity for generic type.
        match declaringType.IsGenericType with
        | true -> String.Format("{0}.{1}.{2}", t.Namespace, t.Name, safeName)
        | false -> String.Format("{0}.{1}", formatTypeName0 declaringType, safeName)
    match t.IsGenericType, safeTypeName with
    // HACK: smaller codes
    | false, "System.Void" -> "unit"
    | false, "System.Boolean" -> "bool"
    | false, "System.Byte" -> "byte"
    | false, "System.Int16" -> "int16"
    | false, "System.Int32" -> "int"
    | false, "System.Int64" -> "int64"
    | false, "System.Char" -> "char"
    | false, "System.String" -> "string"
    // Others
    | false, _ -> safeTypeName
    // Generic types
    | true, _ ->
      match safeTypeName with
      // Option
      | "Microsoft.FSharp.Core.Option" ->
        String.Format(
          "{0} option",
          formatTypeName0 (t.GetGenericArguments().[0]))
      // Ref
      | "Microsoft.FSharp.Core.Ref" ->
        String.Format(
          "{0} ref",
          formatTypeName0 (t.GetGenericArguments().[0]))
      // Seq (IE<'T>)
      | "System.Collections.Generic.IEnumerable" ->
        String.Format(
          "{0} seq",
          formatTypeName0 (t.GetGenericArguments().[0]))
      // List
      | "Microsoft.FSharp.Collections.List" ->
        String.Format(
          "{0} list",
          formatTypeName0 (t.GetGenericArguments().[0]))
      // Other
      | _ ->
        let genericArgumentSignature =
          String.Join(", ", t.GetGenericArguments() |> Seq.map formatTypeName0)
        String.Format(
          "{0}<{1}>",
          safeTypeName,
          genericArgumentSignature)

 let formatTypeName (t: Type) =
   formatTypeName0 t

 let formatFieldType (field: PropertyInfo) =
  formatTypeName field.PropertyType

 let formatCamelcase (name: string) =
  Char.ToLowerInvariant(name.[0]).ToString() + name.Substring(1)

 let formatFieldName (field: PropertyInfo) =
   let name = formatCamelcase field.Name
   match name with
   | "method"
   | "type"
   | "class"
   | "interface"
   | "delegate"
   | "module"
   | "public"
   | "private"
   | "internal"
   | "static"
   | "let"
   | "val"
   | "fun"
   | "function"
   | "mutable"
   | "member"
   | "override"
   | "abstract"
   | "default"
   | "when"
   | "get"
   | "set"
   | "of"
   | "and"
   | "or"
   | "not"
   | "as"
   | "base"
   | "begin"
   | "end"
   | "bool"
   | "byte"
   | "sbyte"
   | "int"
   | "int16"
   | "int64"
   | "string"
   | "char"
   | "unit"
   | "void"
   | "true"
   | "false"
   | "null"
   | "seq"
   | "list"
   | "ref"
   | "option"
   | "async"
   | "use"
   | "if"
   | "then"
   | "else"
   | "elif"
   | "for"
   | "do"
   | "done"
   | "to"
   | "in"
   | "on"
   | "match"
   | "with"
   | "while"
   | "yield"
   | "lazy"
   | "return"
   | "upcast"
   | "downcast"
   | "exception"
   | "exn"
   | "try"
   | "finally"
   | "raise"
   | "failwith"
   | "namespace"
   | "open"
   | "rec"
   | "new"
   | "select"
   | "from"
   | "global"
   | "inherit"
   | "inline"
   | "extern" -> "_" + name
   | _ -> name

 let formatDeclaration (field: PropertyInfo) =
  String.Format(
    "{0}: {1}",
    formatFieldName field,
    formatFieldType field)

 let readTemplate name =
  use fs = Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
  let tr = new StreamReader(fs, Encoding.UTF8)
  tr.ReadToEnd()

