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

module internal VisitorUtilities =

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

  ///////////////////////////////////////////////////////////////////////////////
  // Examine and compose expression to string:
  //   "Projected" means invoke visitor function.
  //   If non-projected all expression leafs, expression string is simply the symbol name.

  /// Partial composed expression result.
  type private ExprResult =
    | Projected of string     // Expr projected             (ex: fun v -> visitor.Visit v)
    | NonProjected of string  // Expr totally non projected (ex: fun v -> v)
    with
      override this.ToString() =
        match this with
        | Projected composed -> composed
        | NonProjected rawName -> rawName

  /// String composer for ExprResult.
  [<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
  type private ExprComposer() =
    /// Contains one or more projected exprs?
    static member private isExistProjected (exprs: 'T seq) =
      exprs |> Seq.exists (fun expr ->
        match expr :> obj with
        | :? ExprResult as er -> match er with Projected _ -> true | NonProjected _ -> false
        | _ -> false)
    /// Similar String.Join for ExprResult.
    static member Join(name: string, separator: string, exprs: 'T seq) =
      let c = exprs |> Seq.toArray
      if ExprComposer.isExistProjected c then
        let join = String.Join(separator, c)
        Projected join
      else
        NonProjected name
    /// Similar String.Format for ExprResult.
    static member Format(name: string, format: string, [<ParamArray>] exprs: obj[]) =
      if ExprComposer.isExistProjected exprs then
        let formatted = String.Format(format, exprs)
        Projected formatted
      else
        NonProjected name
    /// Similar String.Format for ExprResult.
    static member ForceFormat(format: string, [<ParamArray>] exprs: obj[]) =
      let formatted = String.Format(format, exprs)
      if ExprComposer.isExistProjected exprs then
        Projected formatted
      else
        NonProjected formatted

  // Reflection patterns.
  let private (|Array|_|) (t: Type) = match t.IsArray with true -> Some (t.GetElementType()) | false -> None
  let private (|Tuple|_|) (t: Type) = match FSharpType.IsTuple t with true -> Some (FSharpType.GetTupleElements t) | false -> None
  let private (|RefCell|_|) (t: Type) =
    if (t.IsGenericType) && (typedefof<Ref<obj>>.IsAssignableFrom(t.GetGenericTypeDefinition())) then
      Some (t.GetGenericArguments().[0])
    else
      None
  let private (|Record|_|) (t: Type) = match FSharpType.IsRecord t with true -> Some (FSharpType.GetRecordFields t) | false -> None
  let private (|Generic|_|) (t: Type) = match t.IsGenericType with true -> Some (t.GetGenericArguments()) | false -> None

  /// <summary>
  /// Core visitor expression composer.
  /// </summary>
  /// <param name="name">Reference target value symbol.</param>
  /// <param name="t">Target type.</param>
  /// <param name="visitorName">Visitor symbol.</param>
  /// <param name="visitTargets">Dicts of require visit target.</param>
  let rec private formatWithOperators0
      (name: string)
      (t: Type)
      (visitorName: string)
      (visitTargets: IReadOnlyDictionary<Type, string>) =

    let (|VisitTarget|_|) (t:Type) =
      match visitTargets.TryGetValue t with
      | true, targetSymbolName -> Some targetSymbolName
      | false, _ -> None

    match t with
    // "Array.map (fun v -> ?) arg0"
    | Array elementType ->
      ExprComposer.Format(
        name,
        "{0} |> Array.map (fun v -> {1})",
        name,
        formatWithOperators0 "v" elementType visitorName visitTargets)
    // "(let v0, v1 = arg0 in v0, v1)"
    | Tuple elementTypes ->
      let args = elementTypes |> Array.mapi (fun index elementType -> ("v" + index.ToString()), elementType)
      let decomposeExpr = String.Join(", ", args |> Seq.map fst)
      let exprs =
        ExprComposer.Join(
          name,
          ", ",
          args |> Seq.map (fun (argName, argType) -> formatWithOperators0 argName argType visitorName visitTargets))
      ExprComposer.Format(
        name,
        "(let {0} = {1} in {2})",
        decomposeExpr,
        name,
        exprs)
    // Reference cell (FSharpRef<'T>)
    | RefCell innerType ->
      Projected "TODO:"
    // "AstRecordCons.initSynAttribute arg0.V0 arg0.V1"
    | Record fields ->
      ExprComposer.Format(
        name,
        "AstRecordCons.init{0} {1}",
        t.Name,
        ExprComposer.Join(
          name,
          " ",
          fields |> Seq.map (fun field -> formatWithOperators0 (name + "." + field.Name) field.PropertyType visitorName visitTargets)))
    // "this.VisitHoge context arg0"
    | VisitTarget targetSymbolName ->
      // Invoke visitor function, so result force Projected.
      Projected(
        String.Format(
          "({0}.Visit{1} context {2})",
          visitorName,
          formatUnionTypeShortName t,
          name))
    // Other generic types with one argument.
    | Generic [|argType|] ->
      // "arg0 |> Option.map (fun v -> ?)"
      // HACK: Assuming declarates map function in t's.
      // TODO: Invalid code generation for reference cell (FSharp.Ref<'T>)
      ExprComposer.Format(
        name,
        "{0} |> {1}.map (fun v -> {2})",
        name,
        Utilities.formatSafeTypeName t,
        formatWithOperators0 "v" argType visitorName visitTargets)
    // Other types ("arg0")
    | _ ->
      NonProjected name

  let private formatWithOperators name t visitorName visitTargets =
    let exprResult = formatWithOperators0 name t visitorName visitTargets
    exprResult.ToString()

  /// Construct expression string of visitor body with applied args for DU case.
  let formatArgument visitTargets (visitorName: string) (field: PropertyInfo) = 
    formatWithOperators (Utilities.formatFieldName field) field.PropertyType visitorName visitTargets
