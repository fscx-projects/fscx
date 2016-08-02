//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 02 Aug 2016 09:02:59 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

  // TODO: du element
  let parents = new System.Collections.Generic.Stack<obj>()

  /// <summary>
  /// Parent nodes
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  //////////////////////////////////////////////
  // Expression: SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPublic".</remarks>
  abstract member BeforeVisitSynAccessPublic: context: 'TContext -> SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPublic".</remarks>
  default this.BeforeVisitSynAccessPublic(context: 'TContext) =
    this.VisitSynAccessPublic(context)

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  abstract member VisitSynAccessPublic: context: 'TContext -> SynAccess

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  default __.VisitSynAccessPublic(context: 'TContext) =
    SynAccess.Public 

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInternal".</remarks>
  abstract member BeforeVisitSynAccessInternal: context: 'TContext -> SynAccess

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInternal".</remarks>
  default this.BeforeVisitSynAccessInternal(context: 'TContext) =
    this.VisitSynAccessInternal(context)

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  abstract member VisitSynAccessInternal: context: 'TContext -> SynAccess

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  default __.VisitSynAccessInternal(context: 'TContext) =
    SynAccess.Internal 

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPrivate".</remarks>
  abstract member BeforeVisitSynAccessPrivate: context: 'TContext -> SynAccess

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPrivate".</remarks>
  default this.BeforeVisitSynAccessPrivate(context: 'TContext) =
    this.VisitSynAccessPrivate(context)

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  abstract member VisitSynAccessPrivate: context: 'TContext -> SynAccess

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  default __.VisitSynAccessPrivate(context: 'TContext) =
    SynAccess.Private 


  /// <summary>
  /// Visit and dispatch "SynAccess" expression.
  /// </summary>
  /// <param name="synAccess">SynAccess expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynAccess(synAccess: SynAccess, context: 'TContext) =
    parents.Push(synAccess)
    try
      match synAccess with
      | SynAccess.Public ->
        this.BeforeVisitSynAccessPublic(context)
      | SynAccess.Internal ->
        this.BeforeVisitSynAccessInternal(context)
      | SynAccess.Private ->
        this.BeforeVisitSynAccessPrivate(context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynArgInfo".</remarks>
  abstract member BeforeVisitSynArgInfoSynArgInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * optional: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynArgInfo".</remarks>
  default this.BeforeVisitSynArgInfoSynArgInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, optional: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    this.VisitSynArgInfoSynArgInfo(attributes, optional, id, context)

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  abstract member VisitSynArgInfoSynArgInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * optional: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> SynArgInfo

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  default __.VisitSynArgInfoSynArgInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, optional: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    SynArgInfo.SynArgInfo (attributes, optional, id)


  /// <summary>
  /// Visit and dispatch "SynArgInfo" expression.
  /// </summary>
  /// <param name="synArgInfo">SynArgInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynArgInfo(synArgInfo: SynArgInfo, context: 'TContext) =
    parents.Push(synArgInfo)
    try
      match synArgInfo with
      | SynArgInfo.SynArgInfo(attributes, optional, id) ->
        this.BeforeVisitSynArgInfoSynArgInfo(attributes, optional, id, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding".</remarks>
  abstract member BeforeVisitSynBindingBinding: access: Microsoft.FSharp.Compiler.Ast.SynAccess option * bindingKind: SynBindingKind * mustInline: bool * isMutable: bool * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * xmlDoc: PreXmlDoc * item7: SynValData * headPat: SynPat * item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option * expr: SynExpr * lhsRange: Microsoft.FSharp.Compiler.Range.range * spBind: SequencePointInfoForBinding * context: 'TContext -> SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding".</remarks>
  default this.BeforeVisitSynBindingBinding(access: Microsoft.FSharp.Compiler.Ast.SynAccess option, bindingKind: SynBindingKind, mustInline: bool, isMutable: bool, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, xmlDoc: PreXmlDoc, item7: SynValData, headPat: SynPat, item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option, expr: SynExpr, lhsRange: Microsoft.FSharp.Compiler.Range.range, spBind: SequencePointInfoForBinding, context: 'TContext) =
    this.VisitSynBindingBinding(access |> (Option.map (fun v -> this.VisitSynAccess(v, context))), bindingKind |> (fun v -> this.VisitSynBindingKind(v, context)), mustInline, isMutable, attributes, xmlDoc, item7 |> (fun v -> this.VisitSynValData(v, context)), headPat |> (fun v -> this.VisitSynPat(v, context)), item9 |> (Option.map (fun v -> this.VisitSynBindingReturnInfo(v, context))), expr |> (fun v -> this.VisitSynExpr(v, context)), lhsRange, spBind, context)

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  abstract member VisitSynBindingBinding: access: Microsoft.FSharp.Compiler.Ast.SynAccess option * bindingKind: SynBindingKind * mustInline: bool * isMutable: bool * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * xmlDoc: PreXmlDoc * item7: SynValData * headPat: SynPat * item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option * expr: SynExpr * lhsRange: Microsoft.FSharp.Compiler.Range.range * spBind: SequencePointInfoForBinding * context: 'TContext -> SynBinding

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  default __.VisitSynBindingBinding(access: Microsoft.FSharp.Compiler.Ast.SynAccess option, bindingKind: SynBindingKind, mustInline: bool, isMutable: bool, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, xmlDoc: PreXmlDoc, item7: SynValData, headPat: SynPat, item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option, expr: SynExpr, lhsRange: Microsoft.FSharp.Compiler.Range.range, spBind: SequencePointInfoForBinding, context: 'TContext) =
    SynBinding.Binding (access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)


  /// <summary>
  /// Visit and dispatch "SynBinding" expression.
  /// </summary>
  /// <param name="synBinding">SynBinding expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynBinding(synBinding: SynBinding, context: 'TContext) =
    parents.Push(synBinding)
    try
      match synBinding with
      | SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
        this.BeforeVisitSynBindingBinding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStandaloneExpression".</remarks>
  abstract member BeforeVisitSynBindingKindStandaloneExpression: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStandaloneExpression".</remarks>
  default this.BeforeVisitSynBindingKindStandaloneExpression(context: 'TContext) =
    this.VisitSynBindingKindStandaloneExpression(context)

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  abstract member VisitSynBindingKindStandaloneExpression: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  default __.VisitSynBindingKindStandaloneExpression(context: 'TContext) =
    SynBindingKind.StandaloneExpression 

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNormalBinding".</remarks>
  abstract member BeforeVisitSynBindingKindNormalBinding: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNormalBinding".</remarks>
  default this.BeforeVisitSynBindingKindNormalBinding(context: 'TContext) =
    this.VisitSynBindingKindNormalBinding(context)

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  abstract member VisitSynBindingKindNormalBinding: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  default __.VisitSynBindingKindNormalBinding(context: 'TContext) =
    SynBindingKind.NormalBinding 

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBinding".</remarks>
  abstract member BeforeVisitSynBindingKindDoBinding: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBinding".</remarks>
  default this.BeforeVisitSynBindingKindDoBinding(context: 'TContext) =
    this.VisitSynBindingKindDoBinding(context)

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  abstract member VisitSynBindingKindDoBinding: context: 'TContext -> SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  default __.VisitSynBindingKindDoBinding(context: 'TContext) =
    SynBindingKind.DoBinding 


  /// <summary>
  /// Visit and dispatch "SynBindingKind" expression.
  /// </summary>
  /// <param name="synBindingKind">SynBindingKind expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynBindingKind(synBindingKind: SynBindingKind, context: 'TContext) =
    parents.Push(synBindingKind)
    try
      match synBindingKind with
      | SynBindingKind.StandaloneExpression ->
        this.BeforeVisitSynBindingKindStandaloneExpression(context)
      | SynBindingKind.NormalBinding ->
        this.BeforeVisitSynBindingKindNormalBinding(context)
      | SynBindingKind.DoBinding ->
        this.BeforeVisitSynBindingKindDoBinding(context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynBindingReturnInfo".</remarks>
  abstract member BeforeVisitSynBindingReturnInfoSynBindingReturnInfo: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * context: 'TContext -> SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynBindingReturnInfo".</remarks>
  default this.BeforeVisitSynBindingReturnInfoSynBindingReturnInfo(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, context: 'TContext) =
    this.VisitSynBindingReturnInfoSynBindingReturnInfo(typeName |> (fun v -> this.VisitSynType(v, context)), range, attributes, context)

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  abstract member VisitSynBindingReturnInfoSynBindingReturnInfo: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * context: 'TContext -> SynBindingReturnInfo

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  default __.VisitSynBindingReturnInfoSynBindingReturnInfo(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, context: 'TContext) =
    SynBindingReturnInfo.SynBindingReturnInfo (typeName, range, attributes)


  /// <summary>
  /// Visit and dispatch "SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="synBindingReturnInfo">SynBindingReturnInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynBindingReturnInfo(synBindingReturnInfo: SynBindingReturnInfo, context: 'TContext) =
    parents.Push(synBindingReturnInfo)
    try
      match synBindingReturnInfo with
      | SynBindingReturnInfo.SynBindingReturnInfo(typeName, range, attributes) ->
        this.BeforeVisitSynBindingReturnInfoSynBindingReturnInfo(typeName, range, attributes, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo".</remarks>
  abstract member BeforeVisitSynComponentInfoComponentInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * item4: Microsoft.FSharp.Compiler.Ast.Ident list * xmlDoc: PreXmlDoc * preferPostfix: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo".</remarks>
  default this.BeforeVisitSynComponentInfoComponentInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, item4: Microsoft.FSharp.Compiler.Ast.Ident list, xmlDoc: PreXmlDoc, preferPostfix: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynComponentInfoComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  abstract member VisitSynComponentInfoComponentInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * item4: Microsoft.FSharp.Compiler.Ast.Ident list * xmlDoc: PreXmlDoc * preferPostfix: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynComponentInfo

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  default __.VisitSynComponentInfoComponentInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, item4: Microsoft.FSharp.Compiler.Ast.Ident list, xmlDoc: PreXmlDoc, preferPostfix: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynComponentInfo.ComponentInfo (attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynComponentInfo" expression.
  /// </summary>
  /// <param name="synComponentInfo">SynComponentInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynComponentInfo(synComponentInfo: SynComponentInfo, context: 'TContext) =
    parents.Push(synComponentInfo)
    try
      match synComponentInfo with
      | SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
        this.BeforeVisitSynComponentInfoComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnit".</remarks>
  abstract member BeforeVisitSynConstUnit: context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnit".</remarks>
  default this.BeforeVisitSynConstUnit(context: 'TContext) =
    this.VisitSynConstUnit(context)

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  abstract member VisitSynConstUnit: context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  default __.VisitSynConstUnit(context: 'TContext) =
    SynConst.Unit 

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBool".</remarks>
  abstract member BeforeVisitSynConstBool: item: bool * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBool".</remarks>
  default this.BeforeVisitSynConstBool(item: bool, context: 'TContext) =
    this.VisitSynConstBool(item, context)

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  abstract member VisitSynConstBool: item: bool * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  default __.VisitSynConstBool(item: bool, context: 'TContext) =
    SynConst.Bool (item)

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSByte".</remarks>
  abstract member BeforeVisitSynConstSByte: item: System.SByte * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSByte".</remarks>
  default this.BeforeVisitSynConstSByte(item: System.SByte, context: 'TContext) =
    this.VisitSynConstSByte(item, context)

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  abstract member VisitSynConstSByte: item: System.SByte * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  default __.VisitSynConstSByte(item: System.SByte, context: 'TContext) =
    SynConst.SByte (item)

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitByte".</remarks>
  abstract member BeforeVisitSynConstByte: item: System.Byte * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitByte".</remarks>
  default this.BeforeVisitSynConstByte(item: System.Byte, context: 'TContext) =
    this.VisitSynConstByte(item, context)

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  abstract member VisitSynConstByte: item: System.Byte * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  default __.VisitSynConstByte(item: System.Byte, context: 'TContext) =
    SynConst.Byte (item)

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt16".</remarks>
  abstract member BeforeVisitSynConstInt16: item: System.Int16 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt16".</remarks>
  default this.BeforeVisitSynConstInt16(item: System.Int16, context: 'TContext) =
    this.VisitSynConstInt16(item, context)

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  abstract member VisitSynConstInt16: item: System.Int16 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  default __.VisitSynConstInt16(item: System.Int16, context: 'TContext) =
    SynConst.Int16 (item)

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt16".</remarks>
  abstract member BeforeVisitSynConstUInt16: item: System.UInt16 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt16".</remarks>
  default this.BeforeVisitSynConstUInt16(item: System.UInt16, context: 'TContext) =
    this.VisitSynConstUInt16(item, context)

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  abstract member VisitSynConstUInt16: item: System.UInt16 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  default __.VisitSynConstUInt16(item: System.UInt16, context: 'TContext) =
    SynConst.UInt16 (item)

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt32".</remarks>
  abstract member BeforeVisitSynConstInt32: item: int * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt32".</remarks>
  default this.BeforeVisitSynConstInt32(item: int, context: 'TContext) =
    this.VisitSynConstInt32(item, context)

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  abstract member VisitSynConstInt32: item: int * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  default __.VisitSynConstInt32(item: int, context: 'TContext) =
    SynConst.Int32 (item)

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt32".</remarks>
  abstract member BeforeVisitSynConstUInt32: item: System.UInt32 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt32".</remarks>
  default this.BeforeVisitSynConstUInt32(item: System.UInt32, context: 'TContext) =
    this.VisitSynConstUInt32(item, context)

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  abstract member VisitSynConstUInt32: item: System.UInt32 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  default __.VisitSynConstUInt32(item: System.UInt32, context: 'TContext) =
    SynConst.UInt32 (item)

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt64".</remarks>
  abstract member BeforeVisitSynConstInt64: item: int64 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInt64".</remarks>
  default this.BeforeVisitSynConstInt64(item: int64, context: 'TContext) =
    this.VisitSynConstInt64(item, context)

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  abstract member VisitSynConstInt64: item: int64 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  default __.VisitSynConstInt64(item: int64, context: 'TContext) =
    SynConst.Int64 (item)

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt64".</remarks>
  abstract member BeforeVisitSynConstUInt64: item: System.UInt64 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt64".</remarks>
  default this.BeforeVisitSynConstUInt64(item: System.UInt64, context: 'TContext) =
    this.VisitSynConstUInt64(item, context)

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  abstract member VisitSynConstUInt64: item: System.UInt64 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  default __.VisitSynConstUInt64(item: System.UInt64, context: 'TContext) =
    SynConst.UInt64 (item)

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIntPtr".</remarks>
  abstract member BeforeVisitSynConstIntPtr: item: int64 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIntPtr".</remarks>
  default this.BeforeVisitSynConstIntPtr(item: int64, context: 'TContext) =
    this.VisitSynConstIntPtr(item, context)

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  abstract member VisitSynConstIntPtr: item: int64 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  default __.VisitSynConstIntPtr(item: int64, context: 'TContext) =
    SynConst.IntPtr (item)

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUIntPtr".</remarks>
  abstract member BeforeVisitSynConstUIntPtr: item: System.UInt64 * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUIntPtr".</remarks>
  default this.BeforeVisitSynConstUIntPtr(item: System.UInt64, context: 'TContext) =
    this.VisitSynConstUIntPtr(item, context)

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  abstract member VisitSynConstUIntPtr: item: System.UInt64 * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  default __.VisitSynConstUIntPtr(item: System.UInt64, context: 'TContext) =
    SynConst.UIntPtr (item)

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSingle".</remarks>
  abstract member BeforeVisitSynConstSingle: item: System.Single * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSingle".</remarks>
  default this.BeforeVisitSynConstSingle(item: System.Single, context: 'TContext) =
    this.VisitSynConstSingle(item, context)

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  abstract member VisitSynConstSingle: item: System.Single * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  default __.VisitSynConstSingle(item: System.Single, context: 'TContext) =
    SynConst.Single (item)

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDouble".</remarks>
  abstract member BeforeVisitSynConstDouble: item: System.Double * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDouble".</remarks>
  default this.BeforeVisitSynConstDouble(item: System.Double, context: 'TContext) =
    this.VisitSynConstDouble(item, context)

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  abstract member VisitSynConstDouble: item: System.Double * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  default __.VisitSynConstDouble(item: System.Double, context: 'TContext) =
    SynConst.Double (item)

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitChar".</remarks>
  abstract member BeforeVisitSynConstChar: item: System.Char * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitChar".</remarks>
  default this.BeforeVisitSynConstChar(item: System.Char, context: 'TContext) =
    this.VisitSynConstChar(item, context)

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  abstract member VisitSynConstChar: item: System.Char * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  default __.VisitSynConstChar(item: System.Char, context: 'TContext) =
    SynConst.Char (item)

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDecimal".</remarks>
  abstract member BeforeVisitSynConstDecimal: item: System.Decimal * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDecimal".</remarks>
  default this.BeforeVisitSynConstDecimal(item: System.Decimal, context: 'TContext) =
    this.VisitSynConstDecimal(item, context)

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  abstract member VisitSynConstDecimal: item: System.Decimal * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  default __.VisitSynConstDecimal(item: System.Decimal, context: 'TContext) =
    SynConst.Decimal (item)

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUserNum".</remarks>
  abstract member BeforeVisitSynConstUserNum: item: (string * string) * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUserNum".</remarks>
  default this.BeforeVisitSynConstUserNum(item: (string * string), context: 'TContext) =
    this.VisitSynConstUserNum(item, context)

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  abstract member VisitSynConstUserNum: item: (string * string) * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  default __.VisitSynConstUserNum(item: (string * string), context: 'TContext) =
    SynConst.UserNum (item)

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitString".</remarks>
  abstract member BeforeVisitSynConstString: text: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitString".</remarks>
  default this.BeforeVisitSynConstString(text: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynConstString(text, range, context)

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  abstract member VisitSynConstString: text: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  default __.VisitSynConstString(text: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynConst.String (text, range)

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBytes".</remarks>
  abstract member BeforeVisitSynConstBytes: bytes: System.Byte[] * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBytes".</remarks>
  default this.BeforeVisitSynConstBytes(bytes: System.Byte[], range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynConstBytes(bytes, range, context)

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  abstract member VisitSynConstBytes: bytes: System.Byte[] * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  default __.VisitSynConstBytes(bytes: System.Byte[], range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynConst.Bytes (bytes, range)

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt16s".</remarks>
  abstract member BeforeVisitSynConstUInt16s: item: System.UInt16[] * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUInt16s".</remarks>
  default this.BeforeVisitSynConstUInt16s(item: System.UInt16[], context: 'TContext) =
    this.VisitSynConstUInt16s(item, context)

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  abstract member VisitSynConstUInt16s: item: System.UInt16[] * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  default __.VisitSynConstUInt16s(item: System.UInt16[], context: 'TContext) =
    SynConst.UInt16s (item)

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure".</remarks>
  abstract member BeforeVisitSynConstMeasure: constant: SynConst * item2: SynMeasure * context: 'TContext -> SynConst

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure".</remarks>
  default this.BeforeVisitSynConstMeasure(constant: SynConst, item2: SynMeasure, context: 'TContext) =
    this.VisitSynConstMeasure(constant |> (fun v -> this.VisitSynConst(v, context)), item2 |> (fun v -> this.VisitSynMeasure(v, context)), context)

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  abstract member VisitSynConstMeasure: constant: SynConst * item2: SynMeasure * context: 'TContext -> SynConst

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  default __.VisitSynConstMeasure(constant: SynConst, item2: SynMeasure, context: 'TContext) =
    SynConst.Measure (constant, item2)


  /// <summary>
  /// Visit and dispatch "SynConst" expression.
  /// </summary>
  /// <param name="synConst">SynConst expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynConst(synConst: SynConst, context: 'TContext) =
    parents.Push(synConst)
    try
      match synConst with
      | SynConst.Unit ->
        this.BeforeVisitSynConstUnit(context)
      | SynConst.Bool(item) ->
        this.BeforeVisitSynConstBool(item, context)
      | SynConst.SByte(item) ->
        this.BeforeVisitSynConstSByte(item, context)
      | SynConst.Byte(item) ->
        this.BeforeVisitSynConstByte(item, context)
      | SynConst.Int16(item) ->
        this.BeforeVisitSynConstInt16(item, context)
      | SynConst.UInt16(item) ->
        this.BeforeVisitSynConstUInt16(item, context)
      | SynConst.Int32(item) ->
        this.BeforeVisitSynConstInt32(item, context)
      | SynConst.UInt32(item) ->
        this.BeforeVisitSynConstUInt32(item, context)
      | SynConst.Int64(item) ->
        this.BeforeVisitSynConstInt64(item, context)
      | SynConst.UInt64(item) ->
        this.BeforeVisitSynConstUInt64(item, context)
      | SynConst.IntPtr(item) ->
        this.BeforeVisitSynConstIntPtr(item, context)
      | SynConst.UIntPtr(item) ->
        this.BeforeVisitSynConstUIntPtr(item, context)
      | SynConst.Single(item) ->
        this.BeforeVisitSynConstSingle(item, context)
      | SynConst.Double(item) ->
        this.BeforeVisitSynConstDouble(item, context)
      | SynConst.Char(item) ->
        this.BeforeVisitSynConstChar(item, context)
      | SynConst.Decimal(item) ->
        this.BeforeVisitSynConstDecimal(item, context)
      | SynConst.UserNum(item) ->
        this.BeforeVisitSynConstUserNum(item, context)
      | SynConst.String(text, range) ->
        this.BeforeVisitSynConstString(text, range, context)
      | SynConst.Bytes(bytes, range) ->
        this.BeforeVisitSynConstBytes(bytes, range, context)
      | SynConst.UInt16s(item) ->
        this.BeforeVisitSynConstUInt16s(item, context)
      | SynConst.Measure(constant, item2) ->
        this.BeforeVisitSynConstMeasure(constant, item2, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPats".</remarks>
  abstract member BeforeVisitSynConstructorArgsPats: item: Microsoft.FSharp.Compiler.Ast.SynPat list * context: 'TContext -> SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPats".</remarks>
  default this.BeforeVisitSynConstructorArgsPats(item: Microsoft.FSharp.Compiler.Ast.SynPat list, context: 'TContext) =
    this.VisitSynConstructorArgsPats(item, context)

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  abstract member VisitSynConstructorArgsPats: item: Microsoft.FSharp.Compiler.Ast.SynPat list * context: 'TContext -> SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  default __.VisitSynConstructorArgsPats(item: Microsoft.FSharp.Compiler.Ast.SynPat list, context: 'TContext) =
    SynConstructorArgs.Pats (item)

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamePatPairs".</remarks>
  abstract member BeforeVisitSynConstructorArgsNamePatPairs: item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamePatPairs".</remarks>
  default this.BeforeVisitSynConstructorArgsNamePatPairs(item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynConstructorArgsNamePatPairs(item1, range, context)

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  abstract member VisitSynConstructorArgsNamePatPairs: item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  default __.VisitSynConstructorArgsNamePatPairs(item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynConstructorArgs.NamePatPairs (item1, range)


  /// <summary>
  /// Visit and dispatch "SynConstructorArgs" expression.
  /// </summary>
  /// <param name="synConstructorArgs">SynConstructorArgs expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynConstructorArgs(synConstructorArgs: SynConstructorArgs, context: 'TContext) =
    parents.Push(synConstructorArgs)
    try
      match synConstructorArgs with
      | SynConstructorArgs.Pats(item) ->
        this.BeforeVisitSynConstructorArgsPats(item, context)
      | SynConstructorArgs.NamePatPairs(item1, range) ->
        this.BeforeVisitSynConstructorArgsNamePatPairs(item1, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase".</remarks>
  abstract member BeforeVisitSynEnumCaseEnumCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * item3: SynConst * xmlDoc: PreXmlDoc * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase".</remarks>
  default this.BeforeVisitSynEnumCaseEnumCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, item3: SynConst, xmlDoc: PreXmlDoc, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynEnumCaseEnumCase(attributes, id, item3 |> (fun v -> this.VisitSynConst(v, context)), xmlDoc, range, context)

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  abstract member VisitSynEnumCaseEnumCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * item3: SynConst * xmlDoc: PreXmlDoc * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynEnumCase

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  default __.VisitSynEnumCaseEnumCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, item3: SynConst, xmlDoc: PreXmlDoc, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynEnumCase.EnumCase (attributes, id, item3, xmlDoc, range)


  /// <summary>
  /// Visit and dispatch "SynEnumCase" expression.
  /// </summary>
  /// <param name="synEnumCase">SynEnumCase expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynEnumCase(synEnumCase: SynEnumCase, context: 'TContext) =
    parents.Push(synEnumCase)
    try
      match synEnumCase with
      | SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
        this.BeforeVisitSynEnumCaseEnumCase(attributes, id, item3, xmlDoc, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionDefn".</remarks>
  abstract member BeforeVisitSynExceptionDefnSynExceptionDefn: exnRepr: SynExceptionDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionDefn".</remarks>
  default this.BeforeVisitSynExceptionDefnSynExceptionDefn(exnRepr: SynExceptionDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExceptionDefnSynExceptionDefn(exnRepr |> (fun v -> this.VisitSynExceptionDefnRepr(v, context)), members, range, context)

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  abstract member VisitSynExceptionDefnSynExceptionDefn: exnRepr: SynExceptionDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionDefn

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  default __.VisitSynExceptionDefnSynExceptionDefn(exnRepr: SynExceptionDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExceptionDefn.SynExceptionDefn (exnRepr, members, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefn" expression.
  /// </summary>
  /// <param name="synExceptionDefn">SynExceptionDefn expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExceptionDefn(synExceptionDefn: SynExceptionDefn, context: 'TContext) =
    parents.Push(synExceptionDefn)
    try
      match synExceptionDefn with
      | SynExceptionDefn.SynExceptionDefn(exnRepr, members, range) ->
        this.BeforeVisitSynExceptionDefnSynExceptionDefn(exnRepr, members, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionDefnRepr".</remarks>
  abstract member BeforeVisitSynExceptionDefnReprSynExceptionDefnRepr: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * case: SynUnionCase * longId: Microsoft.FSharp.Compiler.Ast.Ident list option * xmlDoc: PreXmlDoc * accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionDefnRepr".</remarks>
  default this.BeforeVisitSynExceptionDefnReprSynExceptionDefnRepr(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, case: SynUnionCase, longId: Microsoft.FSharp.Compiler.Ast.Ident list option, xmlDoc: PreXmlDoc, accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExceptionDefnReprSynExceptionDefnRepr(item1, case |> (fun v -> this.VisitSynUnionCase(v, context)), longId, xmlDoc, accesibility |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  abstract member VisitSynExceptionDefnReprSynExceptionDefnRepr: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * case: SynUnionCase * longId: Microsoft.FSharp.Compiler.Ast.Ident list option * xmlDoc: PreXmlDoc * accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionDefnRepr

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  default __.VisitSynExceptionDefnReprSynExceptionDefnRepr(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, case: SynUnionCase, longId: Microsoft.FSharp.Compiler.Ast.Ident list option, xmlDoc: PreXmlDoc, accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExceptionDefnRepr.SynExceptionDefnRepr (item1, case, longId, xmlDoc, accesibility, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="synExceptionDefnRepr">SynExceptionDefnRepr expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExceptionDefnRepr(synExceptionDefnRepr: SynExceptionDefnRepr, context: 'TContext) =
    parents.Push(synExceptionDefnRepr)
    try
      match synExceptionDefnRepr with
      | SynExceptionDefnRepr.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
        this.BeforeVisitSynExceptionDefnReprSynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionSig".</remarks>
  abstract member BeforeVisitSynExceptionSigSynExceptionSig: exnRepr: SynExceptionDefnRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynExceptionSig".</remarks>
  default this.BeforeVisitSynExceptionSigSynExceptionSig(exnRepr: SynExceptionDefnRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExceptionSigSynExceptionSig(exnRepr |> (fun v -> this.VisitSynExceptionDefnRepr(v, context)), memberSigs, range, context)

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  abstract member VisitSynExceptionSigSynExceptionSig: exnRepr: SynExceptionDefnRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExceptionSig

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  default __.VisitSynExceptionSigSynExceptionSig(exnRepr: SynExceptionDefnRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExceptionSig.SynExceptionSig (exnRepr, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionSig" expression.
  /// </summary>
  /// <param name="synExceptionSig">SynExceptionSig expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExceptionSig(synExceptionSig: SynExceptionSig, context: 'TContext) =
    parents.Push(synExceptionSig)
    try
      match synExceptionSig with
      | SynExceptionSig.SynExceptionSig(exnRepr, memberSigs, range) ->
        this.BeforeVisitSynExceptionSigSynExceptionSig(exnRepr, memberSigs, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  abstract member BeforeVisitSynExprParen: expr: SynExpr * leftParenRange: Microsoft.FSharp.Compiler.Range.range * rightParenRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitSynExprParen(expr: SynExpr, leftParenRange: Microsoft.FSharp.Compiler.Range.range, rightParenRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprParen(expr |> (fun v -> this.VisitSynExpr(v, context)), leftParenRange, rightParenRange, range, context)

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  abstract member VisitSynExprParen: expr: SynExpr * leftParenRange: Microsoft.FSharp.Compiler.Range.range * rightParenRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  default __.VisitSynExprParen(expr: SynExpr, leftParenRange: Microsoft.FSharp.Compiler.Range.range, rightParenRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Paren (expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitSynExprQuote: operator: SynExpr * isRaw: bool * quotedSynExpr: SynExpr * isFromQueryExpression: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitSynExprQuote(operator: SynExpr, isRaw: bool, quotedSynExpr: SynExpr, isFromQueryExpression: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprQuote(operator |> (fun v -> this.VisitSynExpr(v, context)), isRaw, quotedSynExpr |> (fun v -> this.VisitSynExpr(v, context)), isFromQueryExpression, range, context)

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  abstract member VisitSynExprQuote: operator: SynExpr * isRaw: bool * quotedSynExpr: SynExpr * isFromQueryExpression: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  default __.VisitSynExprQuote(operator: SynExpr, isRaw: bool, quotedSynExpr: SynExpr, isFromQueryExpression: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Quote (operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitSynExprConst: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitSynExprConst(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprConst(constant |> (fun v -> this.VisitSynConst(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  abstract member VisitSynExprConst: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  default __.VisitSynExprConst(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Const (constant, range)

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitSynExprTyped: expr: SynExpr * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitSynExprTyped(expr: SynExpr, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprTyped(expr |> (fun v -> this.VisitSynExpr(v, context)), typeSig |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  abstract member VisitSynExprTyped: expr: SynExpr * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  default __.VisitSynExprTyped(expr: SynExpr, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Typed (expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitSynExprTuple: exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitSynExprTuple(exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprTuple(exprs, commaRanges, range, context)

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  abstract member VisitSynExprTuple: exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  default __.VisitSynExprTuple(exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Tuple (exprs, commaRanges, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitSynExprArrayOrList: isList: bool * exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitSynExprArrayOrList(isList: bool, exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprArrayOrList(isList, exprs, range, context)

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  abstract member VisitSynExprArrayOrList: isList: bool * exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  default __.VisitSynExprArrayOrList(isList: bool, exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ArrayOrList (isList, exprs, range)

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitSynExprRecord: baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option * copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option * recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitSynExprRecord(baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option, copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option, recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprRecord(baseInfo, copyInfo, recordFields, range, context)

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  abstract member VisitSynExprRecord: baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option * copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option * recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  default __.VisitSynExprRecord(baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option, copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option, recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Record (baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitSynExprNew: isProtected: bool * typeName: SynType * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitSynExprNew(isProtected: bool, typeName: SynType, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprNew(isProtected, typeName |> (fun v -> this.VisitSynType(v, context)), expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  abstract member VisitSynExprNew: isProtected: bool * typeName: SynType * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  default __.VisitSynExprNew(isProtected: bool, typeName: SynType, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.New (isProtected, typeName, expr, range)

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitSynExprObjExpr: objType: SynType * argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list * newPos: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitSynExprObjExpr(objType: SynType, argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list, newPos: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprObjExpr(objType |> (fun v -> this.VisitSynType(v, context)), argOpt, bindings, extraImpls, newPos, range, context)

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  abstract member VisitSynExprObjExpr: objType: SynType * argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list * newPos: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  default __.VisitSynExprObjExpr(objType: SynType, argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list, newPos: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ObjExpr (objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitSynExprWhile: spWhile: SequencePointInfoForWhileLoop * whileBody: SynExpr * doBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitSynExprWhile(spWhile: SequencePointInfoForWhileLoop, whileBody: SynExpr, doBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprWhile(spWhile, whileBody |> (fun v -> this.VisitSynExpr(v, context)), doBody |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  abstract member VisitSynExprWhile: spWhile: SequencePointInfoForWhileLoop * whileBody: SynExpr * doBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  default __.VisitSynExprWhile(spWhile: SequencePointInfoForWhileLoop, whileBody: SynExpr, doBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.While (spWhile, whileBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitSynExprFor: spFor: SequencePointInfoForForLoop * id: Ident * idBody: SynExpr * item4: bool * toBody: SynExpr * doBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitSynExprFor(spFor: SequencePointInfoForForLoop, id: Ident, idBody: SynExpr, item4: bool, toBody: SynExpr, doBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprFor(spFor, id, idBody |> (fun v -> this.VisitSynExpr(v, context)), item4, toBody |> (fun v -> this.VisitSynExpr(v, context)), doBody |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  abstract member VisitSynExprFor: spFor: SequencePointInfoForForLoop * id: Ident * idBody: SynExpr * item4: bool * toBody: SynExpr * doBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  default __.VisitSynExprFor(spFor: SequencePointInfoForForLoop, id: Ident, idBody: SynExpr, item4: bool, toBody: SynExpr, doBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.For (spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitSynExprForEach: spFor: SequencePointInfoForForLoop * seqExprOnly: SeqExprOnly * isFromSource: bool * pattern: SynPat * enumExpr: SynExpr * bodyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitSynExprForEach(spFor: SequencePointInfoForForLoop, seqExprOnly: SeqExprOnly, isFromSource: bool, pattern: SynPat, enumExpr: SynExpr, bodyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprForEach(spFor, seqExprOnly, isFromSource, pattern |> (fun v -> this.VisitSynPat(v, context)), enumExpr |> (fun v -> this.VisitSynExpr(v, context)), bodyExpr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  abstract member VisitSynExprForEach: spFor: SequencePointInfoForForLoop * seqExprOnly: SeqExprOnly * isFromSource: bool * pattern: SynPat * enumExpr: SynExpr * bodyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  default __.VisitSynExprForEach(spFor: SequencePointInfoForForLoop, seqExprOnly: SeqExprOnly, isFromSource: bool, pattern: SynPat, enumExpr: SynExpr, bodyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ForEach (spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitSynExprArrayOrListOfSeqExpr: isList: bool * elements: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitSynExprArrayOrListOfSeqExpr(isList: bool, elements: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprArrayOrListOfSeqExpr(isList, elements |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  abstract member VisitSynExprArrayOrListOfSeqExpr: isList: bool * elements: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  default __.VisitSynExprArrayOrListOfSeqExpr(isList: bool, elements: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ArrayOrListOfSeqExpr (isList, elements, range)

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitSynExprCompExpr: isArrayOrList: bool * isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitSynExprCompExpr(isArrayOrList: bool, isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool>, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprCompExpr(isArrayOrList, isNotNakedRefCell, expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  abstract member VisitSynExprCompExpr: isArrayOrList: bool * isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  default __.VisitSynExprCompExpr(isArrayOrList: bool, isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool>, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.CompExpr (isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitSynExprLambda: fromMethod: bool * inLambdaSeq: bool * args: SynSimplePats * body: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitSynExprLambda(fromMethod: bool, inLambdaSeq: bool, args: SynSimplePats, body: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLambda(fromMethod, inLambdaSeq, args |> (fun v -> this.VisitSynSimplePats(v, context)), body |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  abstract member VisitSynExprLambda: fromMethod: bool * inLambdaSeq: bool * args: SynSimplePats * body: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  default __.VisitSynExprLambda(fromMethod: bool, inLambdaSeq: bool, args: SynSimplePats, body: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Lambda (fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitSynExprMatchLambda: item1: bool * item2: Microsoft.FSharp.Compiler.Range.range * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * spBind: SequencePointInfoForBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitSynExprMatchLambda(item1: bool, item2: Microsoft.FSharp.Compiler.Range.range, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, spBind: SequencePointInfoForBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprMatchLambda(item1, item2, clauses, spBind, range, context)

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  abstract member VisitSynExprMatchLambda: item1: bool * item2: Microsoft.FSharp.Compiler.Range.range * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * spBind: SequencePointInfoForBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  default __.VisitSynExprMatchLambda(item1: bool, item2: Microsoft.FSharp.Compiler.Range.range, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, spBind: SequencePointInfoForBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.MatchLambda (item1, item2, clauses, spBind, range)

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitSynExprMatch: spBind: SequencePointInfoForBinding * matchExpr: SynExpr * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * isCexprExceptionMatch: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitSynExprMatch(spBind: SequencePointInfoForBinding, matchExpr: SynExpr, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, isCexprExceptionMatch: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprMatch(spBind, matchExpr |> (fun v -> this.VisitSynExpr(v, context)), clauses, isCexprExceptionMatch, range, context)

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  abstract member VisitSynExprMatch: spBind: SequencePointInfoForBinding * matchExpr: SynExpr * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * isCexprExceptionMatch: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  default __.VisitSynExprMatch(spBind: SequencePointInfoForBinding, matchExpr: SynExpr, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, isCexprExceptionMatch: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Match (spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitSynExprDo: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitSynExprDo(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDo(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  abstract member VisitSynExprDo: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  default __.VisitSynExprDo(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Do (expr, range)

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitSynExprAssert: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitSynExprAssert(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprAssert(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  abstract member VisitSynExprAssert: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  default __.VisitSynExprAssert(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Assert (expr, range)

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitSynExprApp: exprAtomicFlag: ExprAtomicFlag * isInfix: bool * funcExpr: SynExpr * argExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitSynExprApp(exprAtomicFlag: ExprAtomicFlag, isInfix: bool, funcExpr: SynExpr, argExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprApp(exprAtomicFlag, isInfix, funcExpr |> (fun v -> this.VisitSynExpr(v, context)), argExpr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  abstract member VisitSynExprApp: exprAtomicFlag: ExprAtomicFlag * isInfix: bool * funcExpr: SynExpr * argExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  default __.VisitSynExprApp(exprAtomicFlag: ExprAtomicFlag, isInfix: bool, funcExpr: SynExpr, argExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.App (exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitSynExprTypeApp: expr: SynExpr * leftAngleRange: Microsoft.FSharp.Compiler.Range.range * typeNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitSynExprTypeApp(expr: SynExpr, leftAngleRange: Microsoft.FSharp.Compiler.Range.range, typeNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprTypeApp(expr |> (fun v -> this.VisitSynExpr(v, context)), leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range, context)

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  abstract member VisitSynExprTypeApp: expr: SynExpr * leftAngleRange: Microsoft.FSharp.Compiler.Range.range * typeNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  default __.VisitSynExprTypeApp(expr: SynExpr, leftAngleRange: Microsoft.FSharp.Compiler.Range.range, typeNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.TypeApp (expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitSynExprLetOrUse: isRecursive: bool * isUse: bool * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * exprBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitSynExprLetOrUse(isRecursive: bool, isUse: bool, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, exprBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLetOrUse(isRecursive, isUse, bindings, exprBody |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  abstract member VisitSynExprLetOrUse: isRecursive: bool * isUse: bool * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * exprBody: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  default __.VisitSynExprLetOrUse(isRecursive: bool, isUse: bool, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, exprBody: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LetOrUse (isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitSynExprTryWith: tryExpr: SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * item4: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * spTry: SequencePointInfoForTry * spWith: SequencePointInfoForWith * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitSynExprTryWith(tryExpr: SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, item4: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, spTry: SequencePointInfoForTry, spWith: SequencePointInfoForWith, context: 'TContext) =
    this.VisitSynExprTryWith(tryExpr |> (fun v -> this.VisitSynExpr(v, context)), item2, item3, item4, range, spTry, spWith, context)

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  abstract member VisitSynExprTryWith: tryExpr: SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * item4: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * spTry: SequencePointInfoForTry * spWith: SequencePointInfoForWith * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  default __.VisitSynExprTryWith(tryExpr: SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, item4: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, spTry: SequencePointInfoForTry, spWith: SequencePointInfoForWith, context: 'TContext) =
    SynExpr.TryWith (tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitSynExprTryFinally: tryExpr: SynExpr * finallyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTry: SequencePointInfoForTry * spFinally: SequencePointInfoForFinally * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitSynExprTryFinally(tryExpr: SynExpr, finallyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTry: SequencePointInfoForTry, spFinally: SequencePointInfoForFinally, context: 'TContext) =
    this.VisitSynExprTryFinally(tryExpr |> (fun v -> this.VisitSynExpr(v, context)), finallyExpr |> (fun v -> this.VisitSynExpr(v, context)), range, spTry, spFinally, context)

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  abstract member VisitSynExprTryFinally: tryExpr: SynExpr * finallyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTry: SequencePointInfoForTry * spFinally: SequencePointInfoForFinally * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  default __.VisitSynExprTryFinally(tryExpr: SynExpr, finallyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTry: SequencePointInfoForTry, spFinally: SequencePointInfoForFinally, context: 'TContext) =
    SynExpr.TryFinally (tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitSynExprLazy: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitSynExprLazy(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLazy(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  abstract member VisitSynExprLazy: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  default __.VisitSynExprLazy(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Lazy (expr, range)

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSynExprSequential: spSeq: SequencePointInfoForSeq * isTrueSeq: bool * expr1: SynExpr * expr2: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSynExprSequential(spSeq: SequencePointInfoForSeq, isTrueSeq: bool, expr1: SynExpr, expr2: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprSequential(spSeq, isTrueSeq, expr1 |> (fun v -> this.VisitSynExpr(v, context)), expr2 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  abstract member VisitSynExprSequential: spSeq: SequencePointInfoForSeq * isTrueSeq: bool * expr1: SynExpr * expr2: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  default __.VisitSynExprSequential(spSeq: SequencePointInfoForSeq, isTrueSeq: bool, expr1: SynExpr, expr2: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Sequential (spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitSynExprIfThenElse: exprGuard: SynExpr * exprThen: SynExpr * optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option * spIfToThen: SequencePointInfoForBinding * isFromErrorRecovery: bool * ifToThen: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitSynExprIfThenElse(exprGuard: SynExpr, exprThen: SynExpr, optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option, spIfToThen: SequencePointInfoForBinding, isFromErrorRecovery: bool, ifToThen: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprIfThenElse(exprGuard |> (fun v -> this.VisitSynExpr(v, context)), exprThen |> (fun v -> this.VisitSynExpr(v, context)), optionalExprElse |> (Option.map (fun v -> this.VisitSynExpr(v, context))), spIfToThen, isFromErrorRecovery, ifToThen, range, context)

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  abstract member VisitSynExprIfThenElse: exprGuard: SynExpr * exprThen: SynExpr * optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option * spIfToThen: SequencePointInfoForBinding * isFromErrorRecovery: bool * ifToThen: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  default __.VisitSynExprIfThenElse(exprGuard: SynExpr, exprThen: SynExpr, optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option, spIfToThen: SequencePointInfoForBinding, isFromErrorRecovery: bool, ifToThen: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.IfThenElse (exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitSynExprIdent: item: Ident * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitSynExprIdent(item: Ident, context: 'TContext) =
    this.VisitSynExprIdent(item, context)

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  abstract member VisitSynExprIdent: item: Ident * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  default __.VisitSynExprIdent(item: Ident, context: 'TContext) =
    SynExpr.Ident (item)

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitSynExprLongIdent: isOptional: bool * longIdent: LongIdentWithDots * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitSynExprLongIdent(isOptional: bool, longIdent: LongIdentWithDots, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLongIdent(isOptional, longIdent, altNameRefCell, range, context)

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  abstract member VisitSynExprLongIdent: isOptional: bool * longIdent: LongIdentWithDots * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  default __.VisitSynExprLongIdent(isOptional: bool, longIdent: LongIdentWithDots, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LongIdent (isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitSynExprLongIdentSet: dotId: LongIdentWithDots * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitSynExprLongIdentSet(dotId: LongIdentWithDots, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLongIdentSet(dotId, expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  abstract member VisitSynExprLongIdentSet: dotId: LongIdentWithDots * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  default __.VisitSynExprLongIdentSet(dotId: LongIdentWithDots, expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LongIdentSet (dotId, expr, range)

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitSynExprDotGet: expr: SynExpr * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * dotId: LongIdentWithDots * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitSynExprDotGet(expr: SynExpr, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, dotId: LongIdentWithDots, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDotGet(expr |> (fun v -> this.VisitSynExpr(v, context)), rangeOfDot, dotId, range, context)

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  abstract member VisitSynExprDotGet: expr: SynExpr * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * dotId: LongIdentWithDots * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  default __.VisitSynExprDotGet(expr: SynExpr, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, dotId: LongIdentWithDots, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DotGet (expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitSynExprDotSet: expr: SynExpr * dotId: LongIdentWithDots * exprValue: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitSynExprDotSet(expr: SynExpr, dotId: LongIdentWithDots, exprValue: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDotSet(expr |> (fun v -> this.VisitSynExpr(v, context)), dotId, exprValue |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  abstract member VisitSynExprDotSet: expr: SynExpr * dotId: LongIdentWithDots * exprValue: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  default __.VisitSynExprDotSet(expr: SynExpr, dotId: LongIdentWithDots, exprValue: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DotSet (expr, dotId, exprValue, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitSynExprDotIndexedGet: expr: SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitSynExprDotIndexedGet(expr: SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDotIndexedGet(expr |> (fun v -> this.VisitSynExpr(v, context)), indexExprs, item3, range, context)

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  abstract member VisitSynExprDotIndexedGet: expr: SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  default __.VisitSynExprDotIndexedGet(expr: SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DotIndexedGet (expr, indexExprs, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitSynExprDotIndexedSet: objectExpr: SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * valueExpr: SynExpr * rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitSynExprDotIndexedSet(objectExpr: SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, valueExpr: SynExpr, rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDotIndexedSet(objectExpr |> (fun v -> this.VisitSynExpr(v, context)), indexExprs, valueExpr |> (fun v -> this.VisitSynExpr(v, context)), rangeOfLeftOfSet, rangeOfDot, range, context)

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  abstract member VisitSynExprDotIndexedSet: objectExpr: SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * valueExpr: SynExpr * rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  default __.VisitSynExprDotIndexedSet(objectExpr: SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, valueExpr: SynExpr, rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DotIndexedSet (objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitSynExprNamedIndexedPropertySet: item1: LongIdentWithDots * item2: SynExpr * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitSynExprNamedIndexedPropertySet(item1: LongIdentWithDots, item2: SynExpr, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprNamedIndexedPropertySet(item1, item2 |> (fun v -> this.VisitSynExpr(v, context)), item3 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  abstract member VisitSynExprNamedIndexedPropertySet: item1: LongIdentWithDots * item2: SynExpr * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  default __.VisitSynExprNamedIndexedPropertySet(item1: LongIdentWithDots, item2: SynExpr, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.NamedIndexedPropertySet (item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitSynExprDotNamedIndexedPropertySet: item1: SynExpr * item2: LongIdentWithDots * item3: SynExpr * item4: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitSynExprDotNamedIndexedPropertySet(item1: SynExpr, item2: LongIdentWithDots, item3: SynExpr, item4: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDotNamedIndexedPropertySet(item1 |> (fun v -> this.VisitSynExpr(v, context)), item2, item3 |> (fun v -> this.VisitSynExpr(v, context)), item4 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  abstract member VisitSynExprDotNamedIndexedPropertySet: item1: SynExpr * item2: LongIdentWithDots * item3: SynExpr * item4: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  default __.VisitSynExprDotNamedIndexedPropertySet(item1: SynExpr, item2: LongIdentWithDots, item3: SynExpr, item4: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DotNamedIndexedPropertySet (item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitSynExprTypeTest: expr: SynExpr * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitSynExprTypeTest(expr: SynExpr, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprTypeTest(expr |> (fun v -> this.VisitSynExpr(v, context)), typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  abstract member VisitSynExprTypeTest: expr: SynExpr * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  default __.VisitSynExprTypeTest(expr: SynExpr, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.TypeTest (expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitSynExprUpcast: expr: SynExpr * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitSynExprUpcast(expr: SynExpr, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprUpcast(expr |> (fun v -> this.VisitSynExpr(v, context)), typeSig |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  abstract member VisitSynExprUpcast: expr: SynExpr * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  default __.VisitSynExprUpcast(expr: SynExpr, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Upcast (expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitSynExprDowncast: expr: SynExpr * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitSynExprDowncast(expr: SynExpr, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDowncast(expr |> (fun v -> this.VisitSynExpr(v, context)), typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  abstract member VisitSynExprDowncast: expr: SynExpr * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  default __.VisitSynExprDowncast(expr: SynExpr, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Downcast (expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitSynExprInferredUpcast: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitSynExprInferredUpcast(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprInferredUpcast(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  abstract member VisitSynExprInferredUpcast: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  default __.VisitSynExprInferredUpcast(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.InferredUpcast (expr, range)

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitSynExprInferredDowncast: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitSynExprInferredDowncast(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprInferredDowncast(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  abstract member VisitSynExprInferredDowncast: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  default __.VisitSynExprInferredDowncast(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.InferredDowncast (expr, range)

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitSynExprNull: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitSynExprNull(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprNull(range, context)

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  abstract member VisitSynExprNull: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  default __.VisitSynExprNull(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Null (range)

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitSynExprAddressOf: item1: bool * item2: SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitSynExprAddressOf(item1: bool, item2: SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprAddressOf(item1, item2 |> (fun v -> this.VisitSynExpr(v, context)), item3, range, context)

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  abstract member VisitSynExprAddressOf: item1: bool * item2: SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  default __.VisitSynExprAddressOf(item1: bool, item2: SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.AddressOf (item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitSynExprTraitCall: item1: Microsoft.FSharp.Compiler.Ast.SynTypar list * item2: SynMemberSig * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitSynExprTraitCall(item1: Microsoft.FSharp.Compiler.Ast.SynTypar list, item2: SynMemberSig, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprTraitCall(item1, item2 |> (fun v -> this.VisitSynMemberSig(v, context)), item3 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  abstract member VisitSynExprTraitCall: item1: Microsoft.FSharp.Compiler.Ast.SynTypar list * item2: SynMemberSig * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  default __.VisitSynExprTraitCall(item1: Microsoft.FSharp.Compiler.Ast.SynTypar list, item2: SynMemberSig, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.TraitCall (item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitSynExprJoinIn: item1: SynExpr * inPos: Microsoft.FSharp.Compiler.Range.range * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitSynExprJoinIn(item1: SynExpr, inPos: Microsoft.FSharp.Compiler.Range.range, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprJoinIn(item1 |> (fun v -> this.VisitSynExpr(v, context)), inPos, item3 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  abstract member VisitSynExprJoinIn: item1: SynExpr * inPos: Microsoft.FSharp.Compiler.Range.range * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  default __.VisitSynExprJoinIn(item1: SynExpr, inPos: Microsoft.FSharp.Compiler.Range.range, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.JoinIn (item1, inPos, item3, range)

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitSynExprImplicitZero: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitSynExprImplicitZero(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprImplicitZero(range, context)

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  abstract member VisitSynExprImplicitZero: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  default __.VisitSynExprImplicitZero(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ImplicitZero (range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitSynExprYieldOrReturn: item1: (bool * bool) * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitSynExprYieldOrReturn(item1: (bool * bool), expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprYieldOrReturn(item1, expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  abstract member VisitSynExprYieldOrReturn: item1: (bool * bool) * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  default __.VisitSynExprYieldOrReturn(item1: (bool * bool), expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.YieldOrReturn (item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitSynExprYieldOrReturnFrom: item1: (bool * bool) * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitSynExprYieldOrReturnFrom(item1: (bool * bool), expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprYieldOrReturnFrom(item1, expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  abstract member VisitSynExprYieldOrReturnFrom: item1: (bool * bool) * expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  default __.VisitSynExprYieldOrReturnFrom(item1: (bool * bool), expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.YieldOrReturnFrom (item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitSynExprLetOrUseBang: spBind: SequencePointInfoForBinding * isUse: bool * isFromSource: bool * pattern: SynPat * rhsExpr: SynExpr * bodyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitSynExprLetOrUseBang(spBind: SequencePointInfoForBinding, isUse: bool, isFromSource: bool, pattern: SynPat, rhsExpr: SynExpr, bodyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLetOrUseBang(spBind, isUse, isFromSource, pattern |> (fun v -> this.VisitSynPat(v, context)), rhsExpr |> (fun v -> this.VisitSynExpr(v, context)), bodyExpr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  abstract member VisitSynExprLetOrUseBang: spBind: SequencePointInfoForBinding * isUse: bool * isFromSource: bool * pattern: SynPat * rhsExpr: SynExpr * bodyExpr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  default __.VisitSynExprLetOrUseBang(spBind: SequencePointInfoForBinding, isUse: bool, isFromSource: bool, pattern: SynPat, rhsExpr: SynExpr, bodyExpr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LetOrUseBang (spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitSynExprDoBang: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitSynExprDoBang(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDoBang(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  abstract member VisitSynExprDoBang: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  default __.VisitSynExprDoBang(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DoBang (expr, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitSynExprLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] * item2: Microsoft.FSharp.Compiler.Ast.SynType list * item3: Microsoft.FSharp.Compiler.Ast.SynExpr list * item4: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitSynExprLibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[], item2: Microsoft.FSharp.Compiler.Ast.SynType list, item3: Microsoft.FSharp.Compiler.Ast.SynExpr list, item4: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLibraryOnlyILAssembly(item1, item2, item3, item4, range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitSynExprLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] * item2: Microsoft.FSharp.Compiler.Ast.SynType list * item3: Microsoft.FSharp.Compiler.Ast.SynExpr list * item4: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  default __.VisitSynExprLibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[], item2: Microsoft.FSharp.Compiler.Ast.SynType list, item3: Microsoft.FSharp.Compiler.Ast.SynExpr list, item4: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LibraryOnlyILAssembly (item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitSynExprLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list * item2: SynExpr * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitSynExprLibraryOnlyStaticOptimization(item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list, item2: SynExpr, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLibraryOnlyStaticOptimization(item1, item2 |> (fun v -> this.VisitSynExpr(v, context)), item3 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  abstract member VisitSynExprLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list * item2: SynExpr * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  default __.VisitSynExprLibraryOnlyStaticOptimization(item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list, item2: SynExpr, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LibraryOnlyStaticOptimization (item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitSynExprLibraryOnlyUnionCaseFieldGet: item1: SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitSynExprLibraryOnlyUnionCaseFieldGet(item1: SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLibraryOnlyUnionCaseFieldGet(item1 |> (fun v -> this.VisitSynExpr(v, context)), longId, item3, range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitSynExprLibraryOnlyUnionCaseFieldGet: item1: SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitSynExprLibraryOnlyUnionCaseFieldGet(item1: SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LibraryOnlyUnionCaseFieldGet (item1, longId, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitSynExprLibraryOnlyUnionCaseFieldSet: item1: SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * item4: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitSynExprLibraryOnlyUnionCaseFieldSet(item1: SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, item4: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprLibraryOnlyUnionCaseFieldSet(item1 |> (fun v -> this.VisitSynExpr(v, context)), longId, item3, item4 |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitSynExprLibraryOnlyUnionCaseFieldSet: item1: SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * item4: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitSynExprLibraryOnlyUnionCaseFieldSet(item1: SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, item4: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.LibraryOnlyUnionCaseFieldSet (item1, longId, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitSynExprArbitraryAfterError: debugStr: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitSynExprArbitraryAfterError(debugStr: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprArbitraryAfterError(debugStr, range, context)

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  abstract member VisitSynExprArbitraryAfterError: debugStr: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  default __.VisitSynExprArbitraryAfterError(debugStr: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.ArbitraryAfterError (debugStr, range)

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitSynExprFromParseError: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitSynExprFromParseError(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprFromParseError(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  abstract member VisitSynExprFromParseError: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  default __.VisitSynExprFromParseError(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.FromParseError (expr, range)

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitSynExprDiscardAfterMissingQualificationAfterDot: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitSynExprDiscardAfterMissingQualificationAfterDot(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprDiscardAfterMissingQualificationAfterDot(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitSynExprDiscardAfterMissingQualificationAfterDot: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitSynExprDiscardAfterMissingQualificationAfterDot(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.DiscardAfterMissingQualificationAfterDot (expr, range)

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitSynExprFixed: item1: SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitSynExprFixed(item1: SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynExprFixed(item1 |> (fun v -> this.VisitSynExpr(v, context)), item2, context)

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  abstract member VisitSynExprFixed: item1: SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  default __.VisitSynExprFixed(item1: SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynExpr.Fixed (item1, item2)


  /// <summary>
  /// Visit and dispatch "SynExpr" expression.
  /// </summary>
  /// <param name="synExpr">SynExpr expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr(synExpr: SynExpr, context: 'TContext) =
    parents.Push(synExpr)
    try
      match synExpr with
      | SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
        this.BeforeVisitSynExprParen(expr, leftParenRange, rightParenRange, range, context)
      | SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        this.BeforeVisitSynExprQuote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range, context)
      | SynExpr.Const(constant, range) ->
        this.BeforeVisitSynExprConst(constant, range, context)
      | SynExpr.Typed(expr, typeSig, range) ->
        this.BeforeVisitSynExprTyped(expr, typeSig, range, context)
      | SynExpr.Tuple(exprs, commaRanges, range) ->
        this.BeforeVisitSynExprTuple(exprs, commaRanges, range, context)
      | SynExpr.ArrayOrList(isList, exprs, range) ->
        this.BeforeVisitSynExprArrayOrList(isList, exprs, range, context)
      | SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        this.BeforeVisitSynExprRecord(baseInfo, copyInfo, recordFields, range, context)
      | SynExpr.New(isProtected, typeName, expr, range) ->
        this.BeforeVisitSynExprNew(isProtected, typeName, expr, range, context)
      | SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        this.BeforeVisitSynExprObjExpr(objType, argOpt, bindings, extraImpls, newPos, range, context)
      | SynExpr.While(spWhile, whileBody, doBody, range) ->
        this.BeforeVisitSynExprWhile(spWhile, whileBody, doBody, range, context)
      | SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        this.BeforeVisitSynExprFor(spFor, id, idBody, item4, toBody, doBody, range, context)
      | SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        this.BeforeVisitSynExprForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range, context)
      | SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        this.BeforeVisitSynExprArrayOrListOfSeqExpr(isList, elements, range, context)
      | SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        this.BeforeVisitSynExprCompExpr(isArrayOrList, isNotNakedRefCell, expr, range, context)
      | SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        this.BeforeVisitSynExprLambda(fromMethod, inLambdaSeq, args, body, range, context)
      | SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        this.BeforeVisitSynExprMatchLambda(item1, item2, clauses, spBind, range, context)
      | SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        this.BeforeVisitSynExprMatch(spBind, matchExpr, clauses, isCexprExceptionMatch, range, context)
      | SynExpr.Do(expr, range) ->
        this.BeforeVisitSynExprDo(expr, range, context)
      | SynExpr.Assert(expr, range) ->
        this.BeforeVisitSynExprAssert(expr, range, context)
      | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        this.BeforeVisitSynExprApp(exprAtomicFlag, isInfix, funcExpr, argExpr, range, context)
      | SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        this.BeforeVisitSynExprTypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range, context)
      | SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        this.BeforeVisitSynExprLetOrUse(isRecursive, isUse, bindings, exprBody, range, context)
      | SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        this.BeforeVisitSynExprTryWith(tryExpr, item2, item3, item4, range, spTry, spWith, context)
      | SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        this.BeforeVisitSynExprTryFinally(tryExpr, finallyExpr, range, spTry, spFinally, context)
      | SynExpr.Lazy(expr, range) ->
        this.BeforeVisitSynExprLazy(expr, range, context)
      | SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        this.BeforeVisitSynExprSequential(spSeq, isTrueSeq, expr1, expr2, range, context)
      | SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        this.BeforeVisitSynExprIfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range, context)
      | SynExpr.Ident(item) ->
        this.BeforeVisitSynExprIdent(item, context)
      | SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        this.BeforeVisitSynExprLongIdent(isOptional, longIdent, altNameRefCell, range, context)
      | SynExpr.LongIdentSet(dotId, expr, range) ->
        this.BeforeVisitSynExprLongIdentSet(dotId, expr, range, context)
      | SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        this.BeforeVisitSynExprDotGet(expr, rangeOfDot, dotId, range, context)
      | SynExpr.DotSet(expr, dotId, exprValue, range) ->
        this.BeforeVisitSynExprDotSet(expr, dotId, exprValue, range, context)
      | SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        this.BeforeVisitSynExprDotIndexedGet(expr, indexExprs, item3, range, context)
      | SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        this.BeforeVisitSynExprDotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range, context)
      | SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        this.BeforeVisitSynExprNamedIndexedPropertySet(item1, item2, item3, range, context)
      | SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        this.BeforeVisitSynExprDotNamedIndexedPropertySet(item1, item2, item3, item4, range, context)
      | SynExpr.TypeTest(expr, typeName, range) ->
        this.BeforeVisitSynExprTypeTest(expr, typeName, range, context)
      | SynExpr.Upcast(expr, typeSig, range) ->
        this.BeforeVisitSynExprUpcast(expr, typeSig, range, context)
      | SynExpr.Downcast(expr, typeName, range) ->
        this.BeforeVisitSynExprDowncast(expr, typeName, range, context)
      | SynExpr.InferredUpcast(expr, range) ->
        this.BeforeVisitSynExprInferredUpcast(expr, range, context)
      | SynExpr.InferredDowncast(expr, range) ->
        this.BeforeVisitSynExprInferredDowncast(expr, range, context)
      | SynExpr.Null(range) ->
        this.BeforeVisitSynExprNull(range, context)
      | SynExpr.AddressOf(item1, item2, item3, range) ->
        this.BeforeVisitSynExprAddressOf(item1, item2, item3, range, context)
      | SynExpr.TraitCall(item1, item2, item3, range) ->
        this.BeforeVisitSynExprTraitCall(item1, item2, item3, range, context)
      | SynExpr.JoinIn(item1, inPos, item3, range) ->
        this.BeforeVisitSynExprJoinIn(item1, inPos, item3, range, context)
      | SynExpr.ImplicitZero(range) ->
        this.BeforeVisitSynExprImplicitZero(range, context)
      | SynExpr.YieldOrReturn(item1, expr, range) ->
        this.BeforeVisitSynExprYieldOrReturn(item1, expr, range, context)
      | SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        this.BeforeVisitSynExprYieldOrReturnFrom(item1, expr, range, context)
      | SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        this.BeforeVisitSynExprLetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range, context)
      | SynExpr.DoBang(expr, range) ->
        this.BeforeVisitSynExprDoBang(expr, range, context)
      | SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        this.BeforeVisitSynExprLibraryOnlyILAssembly(item1, item2, item3, item4, range, context)
      | SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        this.BeforeVisitSynExprLibraryOnlyStaticOptimization(item1, item2, item3, range, context)
      | SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        this.BeforeVisitSynExprLibraryOnlyUnionCaseFieldGet(item1, longId, item3, range, context)
      | SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        this.BeforeVisitSynExprLibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range, context)
      | SynExpr.ArbitraryAfterError(debugStr, range) ->
        this.BeforeVisitSynExprArbitraryAfterError(debugStr, range, context)
      | SynExpr.FromParseError(expr, range) ->
        this.BeforeVisitSynExprFromParseError(expr, range, context)
      | SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        this.BeforeVisitSynExprDiscardAfterMissingQualificationAfterDot(expr, range, context)
      | SynExpr.Fixed(item1, item2) ->
        this.BeforeVisitSynExprFixed(item1, item2, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField".</remarks>
  abstract member BeforeVisitSynFieldField: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * typeName: SynType * item5: bool * xmlDoc: PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField".</remarks>
  default this.BeforeVisitSynFieldField(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, typeName: SynType, item5: bool, xmlDoc: PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynFieldField(attributes, isStatic, id, typeName |> (fun v -> this.VisitSynType(v, context)), item5, xmlDoc, accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  abstract member VisitSynFieldField: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * typeName: SynType * item5: bool * xmlDoc: PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynField

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  default __.VisitSynFieldField(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, typeName: SynType, item5: bool, xmlDoc: PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynField.Field (attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynField" expression.
  /// </summary>
  /// <param name="synField">SynField expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynField(synField: SynField, context: 'TContext) =
    parents.Push(synField)
    try
      match synField with
      | SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
        this.BeforeVisitSynFieldField(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTwo".</remarks>
  abstract member BeforeVisitSynIndexerArgTwo: item1: SynExpr * item2: SynExpr * context: 'TContext -> SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTwo".</remarks>
  default this.BeforeVisitSynIndexerArgTwo(item1: SynExpr, item2: SynExpr, context: 'TContext) =
    this.VisitSynIndexerArgTwo(item1 |> (fun v -> this.VisitSynExpr(v, context)), item2 |> (fun v -> this.VisitSynExpr(v, context)), context)

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  abstract member VisitSynIndexerArgTwo: item1: SynExpr * item2: SynExpr * context: 'TContext -> SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  default __.VisitSynIndexerArgTwo(item1: SynExpr, item2: SynExpr, context: 'TContext) =
    SynIndexerArg.Two (item1, item2)

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOne".</remarks>
  abstract member BeforeVisitSynIndexerArgOne: item: SynExpr * context: 'TContext -> SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOne".</remarks>
  default this.BeforeVisitSynIndexerArgOne(item: SynExpr, context: 'TContext) =
    this.VisitSynIndexerArgOne(item |> (fun v -> this.VisitSynExpr(v, context)), context)

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  abstract member VisitSynIndexerArgOne: item: SynExpr * context: 'TContext -> SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  default __.VisitSynIndexerArgOne(item: SynExpr, context: 'TContext) =
    SynIndexerArg.One (item)


  /// <summary>
  /// Visit and dispatch "SynIndexerArg" expression.
  /// </summary>
  /// <param name="synIndexerArg">SynIndexerArg expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynIndexerArg(synIndexerArg: SynIndexerArg, context: 'TContext) =
    parents.Push(synIndexerArg)
    try
      match synIndexerArg with
      | SynIndexerArg.Two(item1, item2) ->
        this.BeforeVisitSynIndexerArgTwo(item1, item2, context)
      | SynIndexerArg.One(item) ->
        this.BeforeVisitSynIndexerArgOne(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl".</remarks>
  abstract member BeforeVisitSynInterfaceImplInterfaceImpl: item1: SynType * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl".</remarks>
  default this.BeforeVisitSynInterfaceImplInterfaceImpl(item1: SynType, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynInterfaceImplInterfaceImpl(item1 |> (fun v -> this.VisitSynType(v, context)), bindings, range, context)

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  abstract member VisitSynInterfaceImplInterfaceImpl: item1: SynType * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynInterfaceImpl

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  default __.VisitSynInterfaceImplInterfaceImpl(item1: SynType, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynInterfaceImpl.InterfaceImpl (item1, bindings, range)


  /// <summary>
  /// Visit and dispatch "SynInterfaceImpl" expression.
  /// </summary>
  /// <param name="synInterfaceImpl">SynInterfaceImpl expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynInterfaceImpl(synInterfaceImpl: SynInterfaceImpl, context: 'TContext) =
    parents.Push(synInterfaceImpl)
    try
      match synInterfaceImpl with
      | SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
        this.BeforeVisitSynInterfaceImplInterfaceImpl(item1, bindings, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitClause".</remarks>
  abstract member BeforeVisitSynMatchClauseClause: item1: SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynExpr option * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTarget: SequencePointInfoForTarget * context: 'TContext -> SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitClause".</remarks>
  default this.BeforeVisitSynMatchClauseClause(item1: SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynExpr option, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTarget: SequencePointInfoForTarget, context: 'TContext) =
    this.VisitSynMatchClauseClause(item1 |> (fun v -> this.VisitSynPat(v, context)), item2 |> (Option.map (fun v -> this.VisitSynExpr(v, context))), item3 |> (fun v -> this.VisitSynExpr(v, context)), range, spTarget, context)

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  abstract member VisitSynMatchClauseClause: item1: SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynExpr option * item3: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTarget: SequencePointInfoForTarget * context: 'TContext -> SynMatchClause

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  default __.VisitSynMatchClauseClause(item1: SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynExpr option, item3: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTarget: SequencePointInfoForTarget, context: 'TContext) =
    SynMatchClause.Clause (item1, item2, item3, range, spTarget)


  /// <summary>
  /// Visit and dispatch "SynMatchClause" expression.
  /// </summary>
  /// <param name="synMatchClause">SynMatchClause expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynMatchClause(synMatchClause: SynMatchClause, context: 'TContext) =
    parents.Push(synMatchClause)
    try
      match synMatchClause with
      | SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
        this.BeforeVisitSynMatchClauseClause(item1, item2, item3, range, spTarget, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamed".</remarks>
  abstract member BeforeVisitSynMeasureNamed: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamed".</remarks>
  default this.BeforeVisitSynMeasureNamed(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureNamed(longId, range, context)

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  abstract member VisitSynMeasureNamed: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  default __.VisitSynMeasureNamed(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Named (longId, range)

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitProduct".</remarks>
  abstract member BeforeVisitSynMeasureProduct: item1: SynMeasure * item2: SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitProduct".</remarks>
  default this.BeforeVisitSynMeasureProduct(item1: SynMeasure, item2: SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureProduct(item1 |> (fun v -> this.VisitSynMeasure(v, context)), item2 |> (fun v -> this.VisitSynMeasure(v, context)), range, context)

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  abstract member VisitSynMeasureProduct: item1: SynMeasure * item2: SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  default __.VisitSynMeasureProduct(item1: SynMeasure, item2: SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Product (item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSeq".</remarks>
  abstract member BeforeVisitSynMeasureSeq: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSeq".</remarks>
  default this.BeforeVisitSynMeasureSeq(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureSeq(item1, range, context)

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  abstract member VisitSynMeasureSeq: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  default __.VisitSynMeasureSeq(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Seq (item1, range)

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDivide".</remarks>
  abstract member BeforeVisitSynMeasureDivide: item1: SynMeasure * item2: SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDivide".</remarks>
  default this.BeforeVisitSynMeasureDivide(item1: SynMeasure, item2: SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureDivide(item1 |> (fun v -> this.VisitSynMeasure(v, context)), item2 |> (fun v -> this.VisitSynMeasure(v, context)), range, context)

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  abstract member VisitSynMeasureDivide: item1: SynMeasure * item2: SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  default __.VisitSynMeasureDivide(item1: SynMeasure, item2: SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Divide (item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPower".</remarks>
  abstract member BeforeVisitSynMeasurePower: item1: SynMeasure * item2: SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPower".</remarks>
  default this.BeforeVisitSynMeasurePower(item1: SynMeasure, item2: SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasurePower(item1 |> (fun v -> this.VisitSynMeasure(v, context)), item2 |> (fun v -> this.VisitSynRationalConst(v, context)), range, context)

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  abstract member VisitSynMeasurePower: item1: SynMeasure * item2: SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  default __.VisitSynMeasurePower(item1: SynMeasure, item2: SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Power (item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOne".</remarks>
  abstract member BeforeVisitSynMeasureOne: context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOne".</remarks>
  default this.BeforeVisitSynMeasureOne(context: 'TContext) =
    this.VisitSynMeasureOne(context)

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  abstract member VisitSynMeasureOne: context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  default __.VisitSynMeasureOne(context: 'TContext) =
    SynMeasure.One 

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnon".</remarks>
  abstract member BeforeVisitSynMeasureAnon: item: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnon".</remarks>
  default this.BeforeVisitSynMeasureAnon(item: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureAnon(item, context)

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  abstract member VisitSynMeasureAnon: item: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  default __.VisitSynMeasureAnon(item: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Anon (item)

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVar".</remarks>
  abstract member BeforeVisitSynMeasureVar: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVar".</remarks>
  default this.BeforeVisitSynMeasureVar(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMeasureVar(item1 |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  abstract member VisitSynMeasureVar: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  default __.VisitSynMeasureVar(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMeasure.Var (item1, range)


  /// <summary>
  /// Visit and dispatch "SynMeasure" expression.
  /// </summary>
  /// <param name="synMeasure">SynMeasure expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynMeasure(synMeasure: SynMeasure, context: 'TContext) =
    parents.Push(synMeasure)
    try
      match synMeasure with
      | SynMeasure.Named(longId, range) ->
        this.BeforeVisitSynMeasureNamed(longId, range, context)
      | SynMeasure.Product(item1, item2, range) ->
        this.BeforeVisitSynMeasureProduct(item1, item2, range, context)
      | SynMeasure.Seq(item1, range) ->
        this.BeforeVisitSynMeasureSeq(item1, range, context)
      | SynMeasure.Divide(item1, item2, range) ->
        this.BeforeVisitSynMeasureDivide(item1, item2, range, context)
      | SynMeasure.Power(item1, item2, range) ->
        this.BeforeVisitSynMeasurePower(item1, item2, range, context)
      | SynMeasure.One ->
        this.BeforeVisitSynMeasureOne(context)
      | SynMeasure.Anon(item) ->
        this.BeforeVisitSynMeasureAnon(item, context)
      | SynMeasure.Var(item1, range) ->
        this.BeforeVisitSynMeasureVar(item1, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  abstract member BeforeVisitSynMemberDefnOpen: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  default this.BeforeVisitSynMemberDefnOpen(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnOpen(longId, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  abstract member VisitSynMemberDefnOpen: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  default __.VisitSynMemberDefnOpen(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.Open (longId, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMember".</remarks>
  abstract member BeforeVisitSynMemberDefnMember: memberDefn: SynBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMember".</remarks>
  default this.BeforeVisitSynMemberDefnMember(memberDefn: SynBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnMember(memberDefn |> (fun v -> this.VisitSynBinding(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  abstract member VisitSynMemberDefnMember: memberDefn: SynBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  default __.VisitSynMemberDefnMember(memberDefn: SynBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.Member (memberDefn, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitCtor".</remarks>
  abstract member BeforeVisitSynMemberDefnImplicitCtor: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitCtor".</remarks>
  default this.BeforeVisitSynMemberDefnImplicitCtor(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnImplicitCtor(accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), attributes, ctorArgs, selfIdentifier, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  abstract member VisitSynMemberDefnImplicitCtor: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  default __.VisitSynMemberDefnImplicitCtor(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.ImplicitCtor (accessiblity, attributes, ctorArgs, selfIdentifier, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitInherit".</remarks>
  abstract member BeforeVisitSynMemberDefnImplicitInherit: inheritType: SynType * inheritArgs: SynExpr * inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitInherit".</remarks>
  default this.BeforeVisitSynMemberDefnImplicitInherit(inheritType: SynType, inheritArgs: SynExpr, inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnImplicitInherit(inheritType |> (fun v -> this.VisitSynType(v, context)), inheritArgs |> (fun v -> this.VisitSynExpr(v, context)), inheritAlias, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  abstract member VisitSynMemberDefnImplicitInherit: inheritType: SynType * inheritArgs: SynExpr * inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  default __.VisitSynMemberDefnImplicitInherit(inheritType: SynType, inheritArgs: SynExpr, inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.ImplicitInherit (inheritType, inheritArgs, inheritAlias, range)

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetBindings".</remarks>
  abstract member BeforeVisitSynMemberDefnLetBindings: bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * isStatic: bool * isRecursive: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetBindings".</remarks>
  default this.BeforeVisitSynMemberDefnLetBindings(bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, isStatic: bool, isRecursive: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnLetBindings(bindings, isStatic, isRecursive, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  abstract member VisitSynMemberDefnLetBindings: bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * isStatic: bool * isRecursive: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  default __.VisitSynMemberDefnLetBindings(bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, isStatic: bool, isRecursive: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.LetBindings (bindings, isStatic, isRecursive, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAbstractSlot".</remarks>
  abstract member BeforeVisitSynMemberDefnAbstractSlot: valSig: SynValSig * memberFlags: MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAbstractSlot".</remarks>
  default this.BeforeVisitSynMemberDefnAbstractSlot(valSig: SynValSig, memberFlags: MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnAbstractSlot(valSig |> (fun v -> this.VisitSynValSig(v, context)), memberFlags, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  abstract member VisitSynMemberDefnAbstractSlot: valSig: SynValSig * memberFlags: MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  default __.VisitSynMemberDefnAbstractSlot(valSig: SynValSig, memberFlags: MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.AbstractSlot (valSig, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterface".</remarks>
  abstract member BeforeVisitSynMemberDefnInterface: typeName: SynType * interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterface".</remarks>
  default this.BeforeVisitSynMemberDefnInterface(typeName: SynType, interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnInterface(typeName |> (fun v -> this.VisitSynType(v, context)), interfaceMembers, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  abstract member VisitSynMemberDefnInterface: typeName: SynType * interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  default __.VisitSynMemberDefnInterface(typeName: SynType, interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.Interface (typeName, interfaceMembers, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInherit".</remarks>
  abstract member BeforeVisitSynMemberDefnInherit: typeName: SynType * id: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInherit".</remarks>
  default this.BeforeVisitSynMemberDefnInherit(typeName: SynType, id: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnInherit(typeName |> (fun v -> this.VisitSynType(v, context)), id, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  abstract member VisitSynMemberDefnInherit: typeName: SynType * id: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  default __.VisitSynMemberDefnInherit(typeName: SynType, id: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.Inherit (typeName, id, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValField".</remarks>
  abstract member BeforeVisitSynMemberDefnValField: field: SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValField".</remarks>
  default this.BeforeVisitSynMemberDefnValField(field: SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnValField(field |> (fun v -> this.VisitSynField(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  abstract member VisitSynMemberDefnValField: field: SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  default __.VisitSynMemberDefnValField(field: SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.ValField (field, range)

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedType".</remarks>
  abstract member BeforeVisitSynMemberDefnNestedType: typeDefn: SynTypeDefn * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedType".</remarks>
  default this.BeforeVisitSynMemberDefnNestedType(typeDefn: SynTypeDefn, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnNestedType(typeDefn |> (fun v -> this.VisitSynTypeDefn(v, context)), accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  abstract member VisitSynMemberDefnNestedType: typeDefn: SynTypeDefn * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  default __.VisitSynMemberDefnNestedType(typeDefn: SynTypeDefn, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.NestedType (typeDefn, accessiblity, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAutoProperty".</remarks>
  abstract member BeforeVisitSynMemberDefnAutoProperty: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Ident * tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option * propKind: MemberKind * memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) * xmlDoc: PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: SynExpr * getSetPos: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAutoProperty".</remarks>
  default this.BeforeVisitSynMemberDefnAutoProperty(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Ident, tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option, propKind: MemberKind, memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags), xmlDoc: PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: SynExpr, getSetPos: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberDefnAutoProperty(attributes, isStatic, id, tyOpt |> (Option.map (fun v -> this.VisitSynType(v, context))), propKind, memberFlags, xmlDoc, accessibility |> (Option.map (fun v -> this.VisitSynAccess(v, context))), expr |> (fun v -> this.VisitSynExpr(v, context)), getSetPos, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  abstract member VisitSynMemberDefnAutoProperty: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Ident * tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option * propKind: MemberKind * memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) * xmlDoc: PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: SynExpr * getSetPos: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  default __.VisitSynMemberDefnAutoProperty(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Ident, tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option, propKind: MemberKind, memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags), xmlDoc: PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: SynExpr, getSetPos: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberDefn.AutoProperty (attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)


  /// <summary>
  /// Visit and dispatch "SynMemberDefn" expression.
  /// </summary>
  /// <param name="synMemberDefn">SynMemberDefn expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynMemberDefn(synMemberDefn: SynMemberDefn, context: 'TContext) =
    parents.Push(synMemberDefn)
    try
      match synMemberDefn with
      | SynMemberDefn.Open(longId, range) ->
        this.BeforeVisitSynMemberDefnOpen(longId, range, context)
      | SynMemberDefn.Member(memberDefn, range) ->
        this.BeforeVisitSynMemberDefnMember(memberDefn, range, context)
      | SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
        this.BeforeVisitSynMemberDefnImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range, context)
      | SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
        this.BeforeVisitSynMemberDefnImplicitInherit(inheritType, inheritArgs, inheritAlias, range, context)
      | SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
        this.BeforeVisitSynMemberDefnLetBindings(bindings, isStatic, isRecursive, range, context)
      | SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
        this.BeforeVisitSynMemberDefnAbstractSlot(valSig, memberFlags, range, context)
      | SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
        this.BeforeVisitSynMemberDefnInterface(typeName, interfaceMembers, range, context)
      | SynMemberDefn.Inherit(typeName, id, range) ->
        this.BeforeVisitSynMemberDefnInherit(typeName, id, range, context)
      | SynMemberDefn.ValField(field, range) ->
        this.BeforeVisitSynMemberDefnValField(field, range, context)
      | SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
        this.BeforeVisitSynMemberDefnNestedType(typeDefn, accessiblity, range, context)
      | SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
        this.BeforeVisitSynMemberDefnAutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMember".</remarks>
  abstract member BeforeVisitSynMemberSigMember: item1: SynValSig * memberFlags: MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMember".</remarks>
  default this.BeforeVisitSynMemberSigMember(item1: SynValSig, memberFlags: MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberSigMember(item1 |> (fun v -> this.VisitSynValSig(v, context)), memberFlags, range, context)

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  abstract member VisitSynMemberSigMember: item1: SynValSig * memberFlags: MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  default __.VisitSynMemberSigMember(item1: SynValSig, memberFlags: MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberSig.Member (item1, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterface".</remarks>
  abstract member BeforeVisitSynMemberSigInterface: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterface".</remarks>
  default this.BeforeVisitSynMemberSigInterface(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberSigInterface(typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  abstract member VisitSynMemberSigInterface: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  default __.VisitSynMemberSigInterface(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberSig.Interface (typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInherit".</remarks>
  abstract member BeforeVisitSynMemberSigInherit: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInherit".</remarks>
  default this.BeforeVisitSynMemberSigInherit(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberSigInherit(typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  abstract member VisitSynMemberSigInherit: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  default __.VisitSynMemberSigInherit(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberSig.Inherit (typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValField".</remarks>
  abstract member BeforeVisitSynMemberSigValField: field: SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValField".</remarks>
  default this.BeforeVisitSynMemberSigValField(field: SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberSigValField(field |> (fun v -> this.VisitSynField(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  abstract member VisitSynMemberSigValField: field: SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  default __.VisitSynMemberSigValField(field: SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberSig.ValField (field, range)

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedType".</remarks>
  abstract member BeforeVisitSynMemberSigNestedType: typeDefnSig: SynTypeDefnSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedType".</remarks>
  default this.BeforeVisitSynMemberSigNestedType(typeDefnSig: SynTypeDefnSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynMemberSigNestedType(typeDefnSig |> (fun v -> this.VisitSynTypeDefnSig(v, context)), range, context)

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  abstract member VisitSynMemberSigNestedType: typeDefnSig: SynTypeDefnSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  default __.VisitSynMemberSigNestedType(typeDefnSig: SynTypeDefnSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynMemberSig.NestedType (typeDefnSig, range)


  /// <summary>
  /// Visit and dispatch "SynMemberSig" expression.
  /// </summary>
  /// <param name="synMemberSig">SynMemberSig expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynMemberSig(synMemberSig: SynMemberSig, context: 'TContext) =
    parents.Push(synMemberSig)
    try
      match synMemberSig with
      | SynMemberSig.Member(item1, memberFlags, range) ->
        this.BeforeVisitSynMemberSigMember(item1, memberFlags, range, context)
      | SynMemberSig.Interface(typeName, range) ->
        this.BeforeVisitSynMemberSigInterface(typeName, range, context)
      | SynMemberSig.Inherit(typeName, range) ->
        this.BeforeVisitSynMemberSigInherit(typeName, range, context)
      | SynMemberSig.ValField(field, range) ->
        this.BeforeVisitSynMemberSigValField(field, range, context)
      | SynMemberSig.NestedType(typeDefnSig, range) ->
        this.BeforeVisitSynMemberSigNestedType(typeDefnSig, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleAbbrev".</remarks>
  abstract member BeforeVisitSynModuleDeclModuleAbbrev: item1: Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleAbbrev".</remarks>
  default this.BeforeVisitSynModuleDeclModuleAbbrev(item1: Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclModuleAbbrev(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  abstract member VisitSynModuleDeclModuleAbbrev: item1: Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  default __.VisitSynModuleDeclModuleAbbrev(item1: Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.ModuleAbbrev (item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedModule".</remarks>
  abstract member BeforeVisitSynModuleDeclNestedModule: item1: SynComponentInfo * isRec: bool * item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * item4: bool * item5: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedModule".</remarks>
  default this.BeforeVisitSynModuleDeclNestedModule(item1: SynComponentInfo, isRec: bool, item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, item4: bool, item5: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclNestedModule(item1 |> (fun v -> this.VisitSynComponentInfo(v, context)), isRec, item3, item4, item5, context)

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  abstract member VisitSynModuleDeclNestedModule: item1: SynComponentInfo * isRec: bool * item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * item4: bool * item5: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  default __.VisitSynModuleDeclNestedModule(item1: SynComponentInfo, isRec: bool, item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, item4: bool, item5: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.NestedModule (item1, isRec, item3, item4, item5)

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLet".</remarks>
  abstract member BeforeVisitSynModuleDeclLet: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynBinding list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLet".</remarks>
  default this.BeforeVisitSynModuleDeclLet(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynBinding list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclLet(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  abstract member VisitSynModuleDeclLet: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynBinding list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  default __.VisitSynModuleDeclLet(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynBinding list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.Let (item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoExpr".</remarks>
  abstract member BeforeVisitSynModuleDeclDoExpr: item1: SequencePointInfoForBinding * item2: SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoExpr".</remarks>
  default this.BeforeVisitSynModuleDeclDoExpr(item1: SequencePointInfoForBinding, item2: SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclDoExpr(item1, item2 |> (fun v -> this.VisitSynExpr(v, context)), item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  abstract member VisitSynModuleDeclDoExpr: item1: SequencePointInfoForBinding * item2: SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  default __.VisitSynModuleDeclDoExpr(item1: SequencePointInfoForBinding, item2: SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.DoExpr (item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypes".</remarks>
  abstract member BeforeVisitSynModuleDeclTypes: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypes".</remarks>
  default this.BeforeVisitSynModuleDeclTypes(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclTypes(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  abstract member VisitSynModuleDeclTypes: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  default __.VisitSynModuleDeclTypes(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.Types (item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  abstract member BeforeVisitSynModuleDeclException: item1: SynExceptionDefn * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  default this.BeforeVisitSynModuleDeclException(item1: SynExceptionDefn, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclException(item1 |> (fun v -> this.VisitSynExceptionDefn(v, context)), item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  abstract member VisitSynModuleDeclException: item1: SynExceptionDefn * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  default __.VisitSynModuleDeclException(item1: SynExceptionDefn, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.Exception (item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  abstract member BeforeVisitSynModuleDeclOpen: item1: LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  default this.BeforeVisitSynModuleDeclOpen(item1: LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclOpen(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  abstract member VisitSynModuleDeclOpen: item1: LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  default __.VisitSynModuleDeclOpen(item1: LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.Open (item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttributes".</remarks>
  abstract member BeforeVisitSynModuleDeclAttributes: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttributes".</remarks>
  default this.BeforeVisitSynModuleDeclAttributes(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclAttributes(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  abstract member VisitSynModuleDeclAttributes: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  default __.VisitSynModuleDeclAttributes(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.Attributes (item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashDirective".</remarks>
  abstract member BeforeVisitSynModuleDeclHashDirective: item1: ParsedHashDirective * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashDirective".</remarks>
  default this.BeforeVisitSynModuleDeclHashDirective(item1: ParsedHashDirective, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleDeclHashDirective(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  abstract member VisitSynModuleDeclHashDirective: item1: ParsedHashDirective * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  default __.VisitSynModuleDeclHashDirective(item1: ParsedHashDirective, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleDecl.HashDirective (item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamespaceFragment".</remarks>
  abstract member BeforeVisitSynModuleDeclNamespaceFragment: item: SynModuleOrNamespace * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamespaceFragment".</remarks>
  default this.BeforeVisitSynModuleDeclNamespaceFragment(item: SynModuleOrNamespace, context: 'TContext) =
    this.VisitSynModuleDeclNamespaceFragment(item |> (fun v -> this.VisitSynModuleOrNamespace(v, context)), context)

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  abstract member VisitSynModuleDeclNamespaceFragment: item: SynModuleOrNamespace * context: 'TContext -> SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  default __.VisitSynModuleDeclNamespaceFragment(item: SynModuleOrNamespace, context: 'TContext) =
    SynModuleDecl.NamespaceFragment (item)


  /// <summary>
  /// Visit and dispatch "SynModuleDecl" expression.
  /// </summary>
  /// <param name="synModuleDecl">SynModuleDecl expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynModuleDecl(synModuleDecl: SynModuleDecl, context: 'TContext) =
    parents.Push(synModuleDecl)
    try
      match synModuleDecl with
      | SynModuleDecl.ModuleAbbrev(item1, item2, item3) ->
        this.BeforeVisitSynModuleDeclModuleAbbrev(item1, item2, item3, context)
      | SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
        this.BeforeVisitSynModuleDeclNestedModule(item1, isRec, item3, item4, item5, context)
      | SynModuleDecl.Let(item1, item2, item3) ->
        this.BeforeVisitSynModuleDeclLet(item1, item2, item3, context)
      | SynModuleDecl.DoExpr(item1, item2, item3) ->
        this.BeforeVisitSynModuleDeclDoExpr(item1, item2, item3, context)
      | SynModuleDecl.Types(item1, item2) ->
        this.BeforeVisitSynModuleDeclTypes(item1, item2, context)
      | SynModuleDecl.Exception(item1, item2) ->
        this.BeforeVisitSynModuleDeclException(item1, item2, context)
      | SynModuleDecl.Open(item1, item2) ->
        this.BeforeVisitSynModuleDeclOpen(item1, item2, context)
      | SynModuleDecl.Attributes(item1, item2) ->
        this.BeforeVisitSynModuleDeclAttributes(item1, item2, context)
      | SynModuleDecl.HashDirective(item1, item2) ->
        this.BeforeVisitSynModuleDeclHashDirective(item1, item2, context)
      | SynModuleDecl.NamespaceFragment(item) ->
        this.BeforeVisitSynModuleDeclNamespaceFragment(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynModuleOrNamespace".</remarks>
  abstract member BeforeVisitSynModuleOrNamespaceSynModuleOrNamespace: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * xmlDoc: PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * access: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynModuleOrNamespace".</remarks>
  default this.BeforeVisitSynModuleOrNamespaceSynModuleOrNamespace(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, xmlDoc: PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, access: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleOrNamespaceSynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  abstract member VisitSynModuleOrNamespaceSynModuleOrNamespace: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * xmlDoc: PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * access: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleOrNamespace

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  default __.VisitSynModuleOrNamespaceSynModuleOrNamespace(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, xmlDoc: PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, access: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleOrNamespace.SynModuleOrNamespace (id, isRec, isModule, decls, xmlDoc, attributes, access, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="synModuleOrNamespace">SynModuleOrNamespace expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynModuleOrNamespace(synModuleOrNamespace: SynModuleOrNamespace, context: 'TContext) =
    parents.Push(synModuleOrNamespace)
    try
      match synModuleOrNamespace with
      | SynModuleOrNamespace.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
        this.BeforeVisitSynModuleOrNamespaceSynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynModuleOrNamespaceSig".</remarks>
  abstract member BeforeVisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * xmlDoc: PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item7: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynModuleOrNamespaceSig".</remarks>
  default this.BeforeVisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, xmlDoc: PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item7: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7 |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  abstract member VisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * xmlDoc: PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item7: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleOrNamespaceSig

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  default __.VisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, xmlDoc: PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item7: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleOrNamespaceSig.SynModuleOrNamespaceSig (id, isRec, isModule, item4, xmlDoc, attributes, item7, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="synModuleOrNamespaceSig">SynModuleOrNamespaceSig expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynModuleOrNamespaceSig(synModuleOrNamespaceSig: SynModuleOrNamespaceSig, context: 'TContext) =
    parents.Push(synModuleOrNamespaceSig)
    try
      match synModuleOrNamespaceSig with
      | SynModuleOrNamespaceSig.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
        this.BeforeVisitSynModuleOrNamespaceSigSynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleAbbrev".</remarks>
  abstract member BeforeVisitSynModuleSigDeclModuleAbbrev: id: Ident * longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleAbbrev".</remarks>
  default this.BeforeVisitSynModuleSigDeclModuleAbbrev(id: Ident, longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclModuleAbbrev(id, longId, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  abstract member VisitSynModuleSigDeclModuleAbbrev: id: Ident * longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  default __.VisitSynModuleSigDeclModuleAbbrev(id: Ident, longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.ModuleAbbrev (id, longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedModule".</remarks>
  abstract member BeforeVisitSynModuleSigDeclNestedModule: item1: SynComponentInfo * isRec: bool * moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNestedModule".</remarks>
  default this.BeforeVisitSynModuleSigDeclNestedModule(item1: SynComponentInfo, isRec: bool, moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclNestedModule(item1 |> (fun v -> this.VisitSynComponentInfo(v, context)), isRec, moduleSigDecls, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  abstract member VisitSynModuleSigDeclNestedModule: item1: SynComponentInfo * isRec: bool * moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  default __.VisitSynModuleSigDeclNestedModule(item1: SynComponentInfo, isRec: bool, moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.NestedModule (item1, isRec, moduleSigDecls, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVal".</remarks>
  abstract member BeforeVisitSynModuleSigDeclVal: valSig: SynValSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVal".</remarks>
  default this.BeforeVisitSynModuleSigDeclVal(valSig: SynValSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclVal(valSig |> (fun v -> this.VisitSynValSig(v, context)), range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  abstract member VisitSynModuleSigDeclVal: valSig: SynValSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  default __.VisitSynModuleSigDeclVal(valSig: SynValSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.Val (valSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypes".</remarks>
  abstract member BeforeVisitSynModuleSigDeclTypes: typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypes".</remarks>
  default this.BeforeVisitSynModuleSigDeclTypes(typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclTypes(typeDefSigs, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  abstract member VisitSynModuleSigDeclTypes: typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  default __.VisitSynModuleSigDeclTypes(typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.Types (typeDefSigs, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  abstract member BeforeVisitSynModuleSigDeclException: exnSig: SynExceptionSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  default this.BeforeVisitSynModuleSigDeclException(exnSig: SynExceptionSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclException(exnSig |> (fun v -> this.VisitSynExceptionSig(v, context)), range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  abstract member VisitSynModuleSigDeclException: exnSig: SynExceptionSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  default __.VisitSynModuleSigDeclException(exnSig: SynExceptionSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.Exception (exnSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  abstract member BeforeVisitSynModuleSigDeclOpen: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOpen".</remarks>
  default this.BeforeVisitSynModuleSigDeclOpen(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclOpen(longId, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  abstract member VisitSynModuleSigDeclOpen: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  default __.VisitSynModuleSigDeclOpen(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.Open (longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashDirective".</remarks>
  abstract member BeforeVisitSynModuleSigDeclHashDirective: hashDirective: ParsedHashDirective * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashDirective".</remarks>
  default this.BeforeVisitSynModuleSigDeclHashDirective(hashDirective: ParsedHashDirective, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynModuleSigDeclHashDirective(hashDirective, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  abstract member VisitSynModuleSigDeclHashDirective: hashDirective: ParsedHashDirective * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  default __.VisitSynModuleSigDeclHashDirective(hashDirective: ParsedHashDirective, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynModuleSigDecl.HashDirective (hashDirective, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamespaceFragment".</remarks>
  abstract member BeforeVisitSynModuleSigDeclNamespaceFragment: item: SynModuleOrNamespaceSig * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamespaceFragment".</remarks>
  default this.BeforeVisitSynModuleSigDeclNamespaceFragment(item: SynModuleOrNamespaceSig, context: 'TContext) =
    this.VisitSynModuleSigDeclNamespaceFragment(item |> (fun v -> this.VisitSynModuleOrNamespaceSig(v, context)), context)

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  abstract member VisitSynModuleSigDeclNamespaceFragment: item: SynModuleOrNamespaceSig * context: 'TContext -> SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  default __.VisitSynModuleSigDeclNamespaceFragment(item: SynModuleOrNamespaceSig, context: 'TContext) =
    SynModuleSigDecl.NamespaceFragment (item)


  /// <summary>
  /// Visit and dispatch "SynModuleSigDecl" expression.
  /// </summary>
  /// <param name="synModuleSigDecl">SynModuleSigDecl expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynModuleSigDecl(synModuleSigDecl: SynModuleSigDecl, context: 'TContext) =
    parents.Push(synModuleSigDecl)
    try
      match synModuleSigDecl with
      | SynModuleSigDecl.ModuleAbbrev(id, longId, range) ->
        this.BeforeVisitSynModuleSigDeclModuleAbbrev(id, longId, range, context)
      | SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
        this.BeforeVisitSynModuleSigDeclNestedModule(item1, isRec, moduleSigDecls, range, context)
      | SynModuleSigDecl.Val(valSig, range) ->
        this.BeforeVisitSynModuleSigDeclVal(valSig, range, context)
      | SynModuleSigDecl.Types(typeDefSigs, range) ->
        this.BeforeVisitSynModuleSigDeclTypes(typeDefSigs, range, context)
      | SynModuleSigDecl.Exception(exnSig, range) ->
        this.BeforeVisitSynModuleSigDeclException(exnSig, range, context)
      | SynModuleSigDecl.Open(longId, range) ->
        this.BeforeVisitSynModuleSigDeclOpen(longId, range, context)
      | SynModuleSigDecl.HashDirective(hashDirective, range) ->
        this.BeforeVisitSynModuleSigDeclHashDirective(hashDirective, range, context)
      | SynModuleSigDecl.NamespaceFragment(item) ->
        this.BeforeVisitSynModuleSigDeclNamespaceFragment(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitSynPatConst: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitSynPatConst(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatConst(constant |> (fun v -> this.VisitSynConst(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  abstract member VisitSynPatConst: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  default __.VisitSynPatConst(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Const (constant, range)

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWild".</remarks>
  abstract member BeforeVisitSynPatWild: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWild".</remarks>
  default this.BeforeVisitSynPatWild(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatWild(range, context)

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  abstract member VisitSynPatWild: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  default __.VisitSynPatWild(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Wild (range)

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamed".</remarks>
  abstract member BeforeVisitSynPatNamed: item1: SynPat * id: Ident * isThisVar: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamed".</remarks>
  default this.BeforeVisitSynPatNamed(item1: SynPat, id: Ident, isThisVar: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatNamed(item1 |> (fun v -> this.VisitSynPat(v, context)), id, isThisVar, accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  abstract member VisitSynPatNamed: item1: SynPat * id: Ident * isThisVar: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  default __.VisitSynPatNamed(item1: SynPat, id: Ident, isThisVar: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Named (item1, id, isThisVar, accessiblity, range)

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitSynPatTyped: item1: SynPat * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitSynPatTyped(item1: SynPat, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatTyped(item1 |> (fun v -> this.VisitSynPat(v, context)), typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  abstract member VisitSynPatTyped: item1: SynPat * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  default __.VisitSynPatTyped(item1: SynPat, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Typed (item1, typeName, range)

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttrib".</remarks>
  abstract member BeforeVisitSynPatAttrib: item1: SynPat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttrib".</remarks>
  default this.BeforeVisitSynPatAttrib(item1: SynPat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatAttrib(item1 |> (fun v -> this.VisitSynPat(v, context)), attributes, range, context)

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  abstract member VisitSynPatAttrib: item1: SynPat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  default __.VisitSynPatAttrib(item1: SynPat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Attrib (item1, attributes, range)

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOr".</remarks>
  abstract member BeforeVisitSynPatOr: item1: SynPat * item2: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOr".</remarks>
  default this.BeforeVisitSynPatOr(item1: SynPat, item2: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatOr(item1 |> (fun v -> this.VisitSynPat(v, context)), item2 |> (fun v -> this.VisitSynPat(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  abstract member VisitSynPatOr: item1: SynPat * item2: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  default __.VisitSynPatOr(item1: SynPat, item2: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Or (item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnds".</remarks>
  abstract member BeforeVisitSynPatAnds: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnds".</remarks>
  default this.BeforeVisitSynPatAnds(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatAnds(item1, range, context)

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  abstract member VisitSynPatAnds: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  default __.VisitSynPatAnds(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Ands (item1, range)

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitSynPatLongIdent: dotId: LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.Ident option * item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option * item4: SynConstructorArgs * item5: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitSynPatLongIdent(dotId: LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.Ident option, item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option, item4: SynConstructorArgs, item5: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatLongIdent(dotId, item2, item3 |> (Option.map (fun v -> this.VisitSynValTyparDecls(v, context))), item4 |> (fun v -> this.VisitSynConstructorArgs(v, context)), item5 |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  abstract member VisitSynPatLongIdent: dotId: LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.Ident option * item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option * item4: SynConstructorArgs * item5: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  default __.VisitSynPatLongIdent(dotId: LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.Ident option, item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option, item4: SynConstructorArgs, item5: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.LongIdent (dotId, item2, item3, item4, item5, range)

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitSynPatTuple: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitSynPatTuple(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatTuple(item1, range, context)

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  abstract member VisitSynPatTuple: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  default __.VisitSynPatTuple(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Tuple (item1, range)

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  abstract member BeforeVisitSynPatParen: item1: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitSynPatParen(item1: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatParen(item1 |> (fun v -> this.VisitSynPat(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  abstract member VisitSynPatParen: item1: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  default __.VisitSynPatParen(item1: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Paren (item1, range)

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitSynPatArrayOrList: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitSynPatArrayOrList(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatArrayOrList(item1, item2, range, context)

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  abstract member VisitSynPatArrayOrList: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  default __.VisitSynPatArrayOrList(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.ArrayOrList (item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitSynPatRecord: fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitSynPatRecord(fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatRecord(fields, range, context)

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  abstract member VisitSynPatRecord: fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  default __.VisitSynPatRecord(fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Record (fields, range)

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitSynPatNull: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitSynPatNull(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatNull(range, context)

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  abstract member VisitSynPatNull: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  default __.VisitSynPatNull(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.Null (range)

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOptionalVal".</remarks>
  abstract member BeforeVisitSynPatOptionalVal: item1: Ident * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitOptionalVal".</remarks>
  default this.BeforeVisitSynPatOptionalVal(item1: Ident, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatOptionalVal(item1, range, context)

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  abstract member VisitSynPatOptionalVal: item1: Ident * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  default __.VisitSynPatOptionalVal(item1: Ident, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.OptionalVal (item1, range)

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIsInst".</remarks>
  abstract member BeforeVisitSynPatIsInst: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIsInst".</remarks>
  default this.BeforeVisitSynPatIsInst(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatIsInst(typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  abstract member VisitSynPatIsInst: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  default __.VisitSynPatIsInst(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.IsInst (typeName, range)

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuoteExpr".</remarks>
  abstract member BeforeVisitSynPatQuoteExpr: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuoteExpr".</remarks>
  default this.BeforeVisitSynPatQuoteExpr(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatQuoteExpr(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  abstract member VisitSynPatQuoteExpr: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  default __.VisitSynPatQuoteExpr(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.QuoteExpr (expr, range)

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDeprecatedCharRange".</remarks>
  abstract member BeforeVisitSynPatDeprecatedCharRange: item1: System.Char * item2: System.Char * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDeprecatedCharRange".</remarks>
  default this.BeforeVisitSynPatDeprecatedCharRange(item1: System.Char, item2: System.Char, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatDeprecatedCharRange(item1, item2, range, context)

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  abstract member VisitSynPatDeprecatedCharRange: item1: System.Char * item2: System.Char * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  default __.VisitSynPatDeprecatedCharRange(item1: System.Char, item2: System.Char, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.DeprecatedCharRange (item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInstanceMember".</remarks>
  abstract member BeforeVisitSynPatInstanceMember: item1: Ident * item2: Ident * item3: Microsoft.FSharp.Compiler.Ast.Ident option * accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInstanceMember".</remarks>
  default this.BeforeVisitSynPatInstanceMember(item1: Ident, item2: Ident, item3: Microsoft.FSharp.Compiler.Ast.Ident option, accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatInstanceMember(item1, item2, item3, accesiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  abstract member VisitSynPatInstanceMember: item1: Ident * item2: Ident * item3: Microsoft.FSharp.Compiler.Ast.Ident option * accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  default __.VisitSynPatInstanceMember(item1: Ident, item2: Ident, item3: Microsoft.FSharp.Compiler.Ast.Ident option, accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.InstanceMember (item1, item2, item3, accesiblity, range)

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitSynPatFromParseError: item1: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitSynPatFromParseError(item1: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynPatFromParseError(item1 |> (fun v -> this.VisitSynPat(v, context)), range, context)

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  abstract member VisitSynPatFromParseError: item1: SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynPat

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  default __.VisitSynPatFromParseError(item1: SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynPat.FromParseError (item1, range)


  /// <summary>
  /// Visit and dispatch "SynPat" expression.
  /// </summary>
  /// <param name="synPat">SynPat expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynPat(synPat: SynPat, context: 'TContext) =
    parents.Push(synPat)
    try
      match synPat with
      | SynPat.Const(constant, range) ->
        this.BeforeVisitSynPatConst(constant, range, context)
      | SynPat.Wild(range) ->
        this.BeforeVisitSynPatWild(range, context)
      | SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
        this.BeforeVisitSynPatNamed(item1, id, isThisVar, accessiblity, range, context)
      | SynPat.Typed(item1, typeName, range) ->
        this.BeforeVisitSynPatTyped(item1, typeName, range, context)
      | SynPat.Attrib(item1, attributes, range) ->
        this.BeforeVisitSynPatAttrib(item1, attributes, range, context)
      | SynPat.Or(item1, item2, range) ->
        this.BeforeVisitSynPatOr(item1, item2, range, context)
      | SynPat.Ands(item1, range) ->
        this.BeforeVisitSynPatAnds(item1, range, context)
      | SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
        this.BeforeVisitSynPatLongIdent(dotId, item2, item3, item4, item5, range, context)
      | SynPat.Tuple(item1, range) ->
        this.BeforeVisitSynPatTuple(item1, range, context)
      | SynPat.Paren(item1, range) ->
        this.BeforeVisitSynPatParen(item1, range, context)
      | SynPat.ArrayOrList(item1, item2, range) ->
        this.BeforeVisitSynPatArrayOrList(item1, item2, range, context)
      | SynPat.Record(fields, range) ->
        this.BeforeVisitSynPatRecord(fields, range, context)
      | SynPat.Null(range) ->
        this.BeforeVisitSynPatNull(range, context)
      | SynPat.OptionalVal(item1, range) ->
        this.BeforeVisitSynPatOptionalVal(item1, range, context)
      | SynPat.IsInst(typeName, range) ->
        this.BeforeVisitSynPatIsInst(typeName, range, context)
      | SynPat.QuoteExpr(expr, range) ->
        this.BeforeVisitSynPatQuoteExpr(expr, range, context)
      | SynPat.DeprecatedCharRange(item1, item2, range) ->
        this.BeforeVisitSynPatDeprecatedCharRange(item1, item2, range, context)
      | SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
        this.BeforeVisitSynPatInstanceMember(item1, item2, item3, accesiblity, range, context)
      | SynPat.FromParseError(item1, range) ->
        this.BeforeVisitSynPatFromParseError(item1, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInteger".</remarks>
  abstract member BeforeVisitSynRationalConstInteger: item: int * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInteger".</remarks>
  default this.BeforeVisitSynRationalConstInteger(item: int, context: 'TContext) =
    this.VisitSynRationalConstInteger(item, context)

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  abstract member VisitSynRationalConstInteger: item: int * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  default __.VisitSynRationalConstInteger(item: int, context: 'TContext) =
    SynRationalConst.Integer (item)

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRational".</remarks>
  abstract member BeforeVisitSynRationalConstRational: item1: int * item2: int * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRational".</remarks>
  default this.BeforeVisitSynRationalConstRational(item1: int, item2: int, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynRationalConstRational(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  abstract member VisitSynRationalConstRational: item1: int * item2: int * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  default __.VisitSynRationalConstRational(item1: int, item2: int, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynRationalConst.Rational (item1, item2, item3)

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNegate".</remarks>
  abstract member BeforeVisitSynRationalConstNegate: item: SynRationalConst * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNegate".</remarks>
  default this.BeforeVisitSynRationalConstNegate(item: SynRationalConst, context: 'TContext) =
    this.VisitSynRationalConstNegate(item |> (fun v -> this.VisitSynRationalConst(v, context)), context)

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  abstract member VisitSynRationalConstNegate: item: SynRationalConst * context: 'TContext -> SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  default __.VisitSynRationalConstNegate(item: SynRationalConst, context: 'TContext) =
    SynRationalConst.Negate (item)


  /// <summary>
  /// Visit and dispatch "SynRationalConst" expression.
  /// </summary>
  /// <param name="synRationalConst">SynRationalConst expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynRationalConst(synRationalConst: SynRationalConst, context: 'TContext) =
    parents.Push(synRationalConst)
    try
      match synRationalConst with
      | SynRationalConst.Integer(item) ->
        this.BeforeVisitSynRationalConstInteger(item, context)
      | SynRationalConst.Rational(item1, item2, item3) ->
        this.BeforeVisitSynRationalConstRational(item1, item2, item3, context)
      | SynRationalConst.Negate(item) ->
        this.BeforeVisitSynRationalConstNegate(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynReturnInfo".</remarks>
  abstract member BeforeVisitSynReturnInfoSynReturnInfo: item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynReturnInfo".</remarks>
  default this.BeforeVisitSynReturnInfoSynReturnInfo(item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo), range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynReturnInfoSynReturnInfo(item1, range, context)

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  abstract member VisitSynReturnInfoSynReturnInfo: item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynReturnInfo

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  default __.VisitSynReturnInfoSynReturnInfo(item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo), range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynReturnInfo.SynReturnInfo (item1, range)


  /// <summary>
  /// Visit and dispatch "SynReturnInfo" expression.
  /// </summary>
  /// <param name="synReturnInfo">SynReturnInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynReturnInfo(synReturnInfo: SynReturnInfo, context: 'TContext) =
    parents.Push(synReturnInfo)
    try
      match synReturnInfo with
      | SynReturnInfo.SynReturnInfo(item1, range) ->
        this.BeforeVisitSynReturnInfoSynReturnInfo(item1, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitId".</remarks>
  abstract member BeforeVisitSynSimplePatId: ident: Ident * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * isCompilerGenerated: bool * isThisVar: bool * isOptArg: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitId".</remarks>
  default this.BeforeVisitSynSimplePatId(ident: Ident, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, isCompilerGenerated: bool, isThisVar: bool, isOptArg: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynSimplePatId(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range, context)

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  abstract member VisitSynSimplePatId: ident: Ident * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * isCompilerGenerated: bool * isThisVar: bool * isOptArg: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  default __.VisitSynSimplePatId(ident: Ident, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, isCompilerGenerated: bool, isThisVar: bool, isOptArg: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynSimplePat.Id (ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitSynSimplePatTyped: item1: SynSimplePat * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitSynSimplePatTyped(item1: SynSimplePat, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynSimplePatTyped(item1 |> (fun v -> this.VisitSynSimplePat(v, context)), typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  abstract member VisitSynSimplePatTyped: item1: SynSimplePat * typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  default __.VisitSynSimplePatTyped(item1: SynSimplePat, typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynSimplePat.Typed (item1, typeName, range)

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttrib".</remarks>
  abstract member BeforeVisitSynSimplePatAttrib: item1: SynSimplePat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAttrib".</remarks>
  default this.BeforeVisitSynSimplePatAttrib(item1: SynSimplePat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynSimplePatAttrib(item1 |> (fun v -> this.VisitSynSimplePat(v, context)), attributes, range, context)

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  abstract member VisitSynSimplePatAttrib: item1: SynSimplePat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  default __.VisitSynSimplePatAttrib(item1: SynSimplePat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynSimplePat.Attrib (item1, attributes, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePat" expression.
  /// </summary>
  /// <param name="synSimplePat">SynSimplePat expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynSimplePat(synSimplePat: SynSimplePat, context: 'TContext) =
    parents.Push(synSimplePat)
    try
      match synSimplePat with
      | SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
        this.BeforeVisitSynSimplePatId(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range, context)
      | SynSimplePat.Typed(item1, typeName, range) ->
        this.BeforeVisitSynSimplePatTyped(item1, typeName, range, context)
      | SynSimplePat.Attrib(item1, attributes, range) ->
        this.BeforeVisitSynSimplePatAttrib(item1, attributes, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUndecided".</remarks>
  abstract member BeforeVisitSynSimplePatAlternativeIdInfoUndecided: item: Ident * context: 'TContext -> SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUndecided".</remarks>
  default this.BeforeVisitSynSimplePatAlternativeIdInfoUndecided(item: Ident, context: 'TContext) =
    this.VisitSynSimplePatAlternativeIdInfoUndecided(item, context)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  abstract member VisitSynSimplePatAlternativeIdInfoUndecided: item: Ident * context: 'TContext -> SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  default __.VisitSynSimplePatAlternativeIdInfoUndecided(item: Ident, context: 'TContext) =
    SynSimplePatAlternativeIdInfo.Undecided (item)

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDecided".</remarks>
  abstract member BeforeVisitSynSimplePatAlternativeIdInfoDecided: item: Ident * context: 'TContext -> SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDecided".</remarks>
  default this.BeforeVisitSynSimplePatAlternativeIdInfoDecided(item: Ident, context: 'TContext) =
    this.VisitSynSimplePatAlternativeIdInfoDecided(item, context)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  abstract member VisitSynSimplePatAlternativeIdInfoDecided: item: Ident * context: 'TContext -> SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  default __.VisitSynSimplePatAlternativeIdInfoDecided(item: Ident, context: 'TContext) =
    SynSimplePatAlternativeIdInfo.Decided (item)


  /// <summary>
  /// Visit and dispatch "SynSimplePatAlternativeIdInfo" expression.
  /// </summary>
  /// <param name="synSimplePatAlternativeIdInfo">SynSimplePatAlternativeIdInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynSimplePatAlternativeIdInfo(synSimplePatAlternativeIdInfo: SynSimplePatAlternativeIdInfo, context: 'TContext) =
    parents.Push(synSimplePatAlternativeIdInfo)
    try
      match synSimplePatAlternativeIdInfo with
      | SynSimplePatAlternativeIdInfo.Undecided(item) ->
        this.BeforeVisitSynSimplePatAlternativeIdInfoUndecided(item, context)
      | SynSimplePatAlternativeIdInfo.Decided(item) ->
        this.BeforeVisitSynSimplePatAlternativeIdInfoDecided(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats".</remarks>
  abstract member BeforeVisitSynSimplePatsSimplePats: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats".</remarks>
  default this.BeforeVisitSynSimplePatsSimplePats(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynSimplePatsSimplePats(item1, range, context)

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  abstract member VisitSynSimplePatsSimplePats: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  default __.VisitSynSimplePatsSimplePats(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynSimplePats.SimplePats (item1, range)

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitSynSimplePatsTyped: item1: SynSimplePats * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitSynSimplePatsTyped(item1: SynSimplePats, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynSimplePatsTyped(item1 |> (fun v -> this.VisitSynSimplePats(v, context)), item2 |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  abstract member VisitSynSimplePatsTyped: item1: SynSimplePats * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  default __.VisitSynSimplePatsTyped(item1: SynSimplePats, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynSimplePats.Typed (item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePats" expression.
  /// </summary>
  /// <param name="synSimplePats">SynSimplePats expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynSimplePats(synSimplePats: SynSimplePats, context: 'TContext) =
    parents.Push(synSimplePats)
    try
      match synSimplePats with
      | SynSimplePats.SimplePats(item1, range) ->
        this.BeforeVisitSynSimplePatsSimplePats(item1, range, context)
      | SynSimplePats.Typed(item1, item2, range) ->
        this.BeforeVisitSynSimplePatsTyped(item1, item2, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhenTyparTyconEqualsTycon".</remarks>
  abstract member BeforeVisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon: item1: SynTypar * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhenTyparTyconEqualsTycon".</remarks>
  default this.BeforeVisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon(item1: SynTypar, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon(item1 |> (fun v -> this.VisitSynTypar(v, context)), item2 |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  abstract member VisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon: item1: SynTypar * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  default __.VisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon(item1: SynTypar, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon (item1, item2, range)

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhenTyparIsStruct".</remarks>
  abstract member BeforeVisitSynStaticOptimizationConstraintWhenTyparIsStruct: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhenTyparIsStruct".</remarks>
  default this.BeforeVisitSynStaticOptimizationConstraintWhenTyparIsStruct(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynStaticOptimizationConstraintWhenTyparIsStruct(item1 |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  abstract member VisitSynStaticOptimizationConstraintWhenTyparIsStruct: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  default __.VisitSynStaticOptimizationConstraintWhenTyparIsStruct(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynStaticOptimizationConstraint.WhenTyparIsStruct (item1, range)


  /// <summary>
  /// Visit and dispatch "SynStaticOptimizationConstraint" expression.
  /// </summary>
  /// <param name="synStaticOptimizationConstraint">SynStaticOptimizationConstraint expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynStaticOptimizationConstraint(synStaticOptimizationConstraint: SynStaticOptimizationConstraint, context: 'TContext) =
    parents.Push(synStaticOptimizationConstraint)
    try
      match synStaticOptimizationConstraint with
      | SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
        this.BeforeVisitSynStaticOptimizationConstraintWhenTyparTyconEqualsTycon(item1, item2, range, context)
      | SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
        this.BeforeVisitSynStaticOptimizationConstraintWhenTyparIsStruct(item1, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar".</remarks>
  abstract member BeforeVisitSynTyparTypar: id: Ident * staticReq: TyparStaticReq * isCompGen: bool * context: 'TContext -> SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar".</remarks>
  default this.BeforeVisitSynTyparTypar(id: Ident, staticReq: TyparStaticReq, isCompGen: bool, context: 'TContext) =
    this.VisitSynTyparTypar(id, staticReq, isCompGen, context)

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  abstract member VisitSynTyparTypar: id: Ident * staticReq: TyparStaticReq * isCompGen: bool * context: 'TContext -> SynTypar

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  default __.VisitSynTyparTypar(id: Ident, staticReq: TyparStaticReq, isCompGen: bool, context: 'TContext) =
    SynTypar.Typar (id, staticReq, isCompGen)


  /// <summary>
  /// Visit and dispatch "SynTypar" expression.
  /// </summary>
  /// <param name="synTypar">SynTypar expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypar(synTypar: SynTypar, context: 'TContext) =
    parents.Push(synTypar)
    try
      match synTypar with
      | SynTypar.Typar(id, staticReq, isCompGen) ->
        this.BeforeVisitSynTyparTypar(id, staticReq, isCompGen, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl".</remarks>
  abstract member BeforeVisitSynTyparDeclTyparDecl: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: SynTypar * context: 'TContext -> SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl".</remarks>
  default this.BeforeVisitSynTyparDeclTyparDecl(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: SynTypar, context: 'TContext) =
    this.VisitSynTyparDeclTyparDecl(attributes, item2 |> (fun v -> this.VisitSynTypar(v, context)), context)

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  abstract member VisitSynTyparDeclTyparDecl: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: SynTypar * context: 'TContext -> SynTyparDecl

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  default __.VisitSynTyparDeclTyparDecl(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: SynTypar, context: 'TContext) =
    SynTyparDecl.TyparDecl (attributes, item2)


  /// <summary>
  /// Visit and dispatch "SynTyparDecl" expression.
  /// </summary>
  /// <param name="synTyparDecl">SynTyparDecl expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTyparDecl(synTyparDecl: SynTyparDecl, context: 'TContext) =
    parents.Push(synTyparDecl)
    try
      match synTyparDecl with
      | SynTyparDecl.TyparDecl(attributes, item2) ->
        this.BeforeVisitSynTyparDeclTyparDecl(attributes, item2, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitSynTypeLongIdent: item: LongIdentWithDots * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitSynTypeLongIdent(item: LongIdentWithDots, context: 'TContext) =
    this.VisitSynTypeLongIdent(item, context)

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  abstract member VisitSynTypeLongIdent: item: LongIdentWithDots * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  default __.VisitSynTypeLongIdent(item: LongIdentWithDots, context: 'TContext) =
    SynType.LongIdent (item)

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitSynTypeApp: typeName: SynType * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * isPostfix: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitSynTypeApp(typeName: SynType, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, isPostfix: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeApp(typeName |> (fun v -> this.VisitSynType(v, context)), leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range, context)

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  abstract member VisitSynTypeApp: typeName: SynType * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * isPostfix: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  default __.VisitSynTypeApp(typeName: SynType, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, isPostfix: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.App (typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentApp".</remarks>
  abstract member BeforeVisitSynTypeLongIdentApp: typeName: SynType * dotId: LongIdentWithDots * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * genericNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentApp".</remarks>
  default this.BeforeVisitSynTypeLongIdentApp(typeName: SynType, dotId: LongIdentWithDots, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, genericNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeLongIdentApp(typeName |> (fun v -> this.VisitSynType(v, context)), dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range, context)

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  abstract member VisitSynTypeLongIdentApp: typeName: SynType * dotId: LongIdentWithDots * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * genericNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  default __.VisitSynTypeLongIdentApp(typeName: SynType, dotId: LongIdentWithDots, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, genericNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.LongIdentApp (typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitSynTypeTuple: item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitSynTypeTuple(item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeTuple(item1, range, context)

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  abstract member VisitSynTypeTuple: item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  default __.VisitSynTypeTuple(item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.Tuple (item1, range)

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArray".</remarks>
  abstract member BeforeVisitSynTypeArray: item1: int * elementType: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArray".</remarks>
  default this.BeforeVisitSynTypeArray(item1: int, elementType: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeArray(item1, elementType |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  abstract member VisitSynTypeArray: item1: int * elementType: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  default __.VisitSynTypeArray(item1: int, elementType: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.Array (item1, elementType, range)

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFun".</remarks>
  abstract member BeforeVisitSynTypeFun: argType: SynType * returnType: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFun".</remarks>
  default this.BeforeVisitSynTypeFun(argType: SynType, returnType: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeFun(argType |> (fun v -> this.VisitSynType(v, context)), returnType |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  abstract member VisitSynTypeFun: argType: SynType * returnType: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  default __.VisitSynTypeFun(argType: SynType, returnType: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.Fun (argType, returnType, range)

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVar".</remarks>
  abstract member BeforeVisitSynTypeVar: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitVar".</remarks>
  default this.BeforeVisitSynTypeVar(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeVar(item1 |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  abstract member VisitSynTypeVar: item1: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  default __.VisitSynTypeVar(item1: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.Var (item1, range)

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnon".</remarks>
  abstract member BeforeVisitSynTypeAnon: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAnon".</remarks>
  default this.BeforeVisitSynTypeAnon(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeAnon(range, context)

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  abstract member VisitSynTypeAnon: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  default __.VisitSynTypeAnon(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.Anon (range)

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWithGlobalConstraints".</remarks>
  abstract member BeforeVisitSynTypeWithGlobalConstraints: typeName: SynType * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWithGlobalConstraints".</remarks>
  default this.BeforeVisitSynTypeWithGlobalConstraints(typeName: SynType, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeWithGlobalConstraints(typeName |> (fun v -> this.VisitSynType(v, context)), constraints, range, context)

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  abstract member VisitSynTypeWithGlobalConstraints: typeName: SynType * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  default __.VisitSynTypeWithGlobalConstraints(typeName: SynType, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.WithGlobalConstraints (typeName, constraints, range)

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashConstraint".</remarks>
  abstract member BeforeVisitSynTypeHashConstraint: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitHashConstraint".</remarks>
  default this.BeforeVisitSynTypeHashConstraint(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeHashConstraint(typeName |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  abstract member VisitSynTypeHashConstraint: typeName: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  default __.VisitSynTypeHashConstraint(typeName: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.HashConstraint (typeName, range)

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasureDivide".</remarks>
  abstract member BeforeVisitSynTypeMeasureDivide: typeName: SynType * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasureDivide".</remarks>
  default this.BeforeVisitSynTypeMeasureDivide(typeName: SynType, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeMeasureDivide(typeName |> (fun v -> this.VisitSynType(v, context)), item2 |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  abstract member VisitSynTypeMeasureDivide: typeName: SynType * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  default __.VisitSynTypeMeasureDivide(typeName: SynType, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.MeasureDivide (typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasurePower".</remarks>
  abstract member BeforeVisitSynTypeMeasurePower: typeName: SynType * item2: SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasurePower".</remarks>
  default this.BeforeVisitSynTypeMeasurePower(typeName: SynType, item2: SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeMeasurePower(typeName |> (fun v -> this.VisitSynType(v, context)), item2 |> (fun v -> this.VisitSynRationalConst(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  abstract member VisitSynTypeMeasurePower: typeName: SynType * item2: SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  default __.VisitSynTypeMeasurePower(typeName: SynType, item2: SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.MeasurePower (typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstant".</remarks>
  abstract member BeforeVisitSynTypeStaticConstant: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstant".</remarks>
  default this.BeforeVisitSynTypeStaticConstant(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeStaticConstant(constant |> (fun v -> this.VisitSynConst(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  abstract member VisitSynTypeStaticConstant: constant: SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  default __.VisitSynTypeStaticConstant(constant: SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.StaticConstant (constant, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstantExpr".</remarks>
  abstract member BeforeVisitSynTypeStaticConstantExpr: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstantExpr".</remarks>
  default this.BeforeVisitSynTypeStaticConstantExpr(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeStaticConstantExpr(expr |> (fun v -> this.VisitSynExpr(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  abstract member VisitSynTypeStaticConstantExpr: expr: SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  default __.VisitSynTypeStaticConstantExpr(expr: SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.StaticConstantExpr (expr, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstantNamed".</remarks>
  abstract member BeforeVisitSynTypeStaticConstantNamed: item1: SynType * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticConstantNamed".</remarks>
  default this.BeforeVisitSynTypeStaticConstantNamed(item1: SynType, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeStaticConstantNamed(item1 |> (fun v -> this.VisitSynType(v, context)), item2 |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  abstract member VisitSynTypeStaticConstantNamed: item1: SynType * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynType

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  default __.VisitSynTypeStaticConstantNamed(item1: SynType, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynType.StaticConstantNamed (item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynType" expression.
  /// </summary>
  /// <param name="synType">SynType expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynType(synType: SynType, context: 'TContext) =
    parents.Push(synType)
    try
      match synType with
      | SynType.LongIdent(item) ->
        this.BeforeVisitSynTypeLongIdent(item, context)
      | SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
        this.BeforeVisitSynTypeApp(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range, context)
      | SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
        this.BeforeVisitSynTypeLongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range, context)
      | SynType.Tuple(item1, range) ->
        this.BeforeVisitSynTypeTuple(item1, range, context)
      | SynType.Array(item1, elementType, range) ->
        this.BeforeVisitSynTypeArray(item1, elementType, range, context)
      | SynType.Fun(argType, returnType, range) ->
        this.BeforeVisitSynTypeFun(argType, returnType, range, context)
      | SynType.Var(item1, range) ->
        this.BeforeVisitSynTypeVar(item1, range, context)
      | SynType.Anon(range) ->
        this.BeforeVisitSynTypeAnon(range, context)
      | SynType.WithGlobalConstraints(typeName, constraints, range) ->
        this.BeforeVisitSynTypeWithGlobalConstraints(typeName, constraints, range, context)
      | SynType.HashConstraint(typeName, range) ->
        this.BeforeVisitSynTypeHashConstraint(typeName, range, context)
      | SynType.MeasureDivide(typeName, item2, range) ->
        this.BeforeVisitSynTypeMeasureDivide(typeName, item2, range, context)
      | SynType.MeasurePower(typeName, item2, range) ->
        this.BeforeVisitSynTypeMeasurePower(typeName, item2, range, context)
      | SynType.StaticConstant(constant, range) ->
        this.BeforeVisitSynTypeStaticConstant(constant, range, context)
      | SynType.StaticConstantExpr(expr, range) ->
        this.BeforeVisitSynTypeStaticConstantExpr(expr, range, context)
      | SynType.StaticConstantNamed(item1, item2, range) ->
        this.BeforeVisitSynTypeStaticConstantNamed(item1, item2, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsValueType".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsValueType: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsValueType".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsValueType(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsValueType(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsValueType: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsValueType(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsValueType (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsReferenceType".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsReferenceType: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsReferenceType".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsReferenceType(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsReferenceType(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsReferenceType: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsReferenceType(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsReferenceType (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsUnmanaged".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsUnmanaged: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsUnmanaged".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsUnmanaged(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsUnmanaged(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsUnmanaged: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsUnmanaged(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsUnmanaged (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSupportsNull".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparSupportsNull: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSupportsNull".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparSupportsNull(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparSupportsNull(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparSupportsNull: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  default __.VisitSynTypeConstraintWhereTyparSupportsNull(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparSupportsNull (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsComparable".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsComparable: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsComparable".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsComparable(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsComparable(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsComparable: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsComparable(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsComparable (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsEquatable".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsEquatable: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsEquatable".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsEquatable(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsEquatable(genericName |> (fun v -> this.VisitSynTypar(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsEquatable: genericName: SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsEquatable(genericName: SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsEquatable (genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparDefaultsToType".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparDefaultsToType: genericName: SynTypar * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparDefaultsToType".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparDefaultsToType(genericName: SynTypar, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparDefaultsToType(genericName |> (fun v -> this.VisitSynTypar(v, context)), typeSig |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparDefaultsToType: genericName: SynTypar * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  default __.VisitSynTypeConstraintWhereTyparDefaultsToType(genericName: SynTypar, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparDefaultsToType (genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSubtypeOfType".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparSubtypeOfType: genericName: SynTypar * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSubtypeOfType".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparSubtypeOfType(genericName: SynTypar, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparSubtypeOfType(genericName |> (fun v -> this.VisitSynTypar(v, context)), typeSig |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparSubtypeOfType: genericName: SynTypar * typeSig: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  default __.VisitSynTypeConstraintWhereTyparSubtypeOfType(genericName: SynTypar, typeSig: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparSubtypeOfType (genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSupportsMember".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparSupportsMember: genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list * memberSig: SynMemberSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparSupportsMember".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparSupportsMember(genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list, memberSig: SynMemberSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparSupportsMember(genericNames, memberSig |> (fun v -> this.VisitSynMemberSig(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparSupportsMember: genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list * memberSig: SynMemberSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  default __.VisitSynTypeConstraintWhereTyparSupportsMember(genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list, memberSig: SynMemberSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparSupportsMember (genericNames, memberSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsEnum".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsEnum: genericName: SynTypar * enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsEnum".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsEnum(genericName: SynTypar, enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsEnum(genericName |> (fun v -> this.VisitSynTypar(v, context)), enumTypes, range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsEnum: genericName: SynTypar * enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsEnum(genericName: SynTypar, enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsEnum (genericName, enumTypes, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsDelegate".</remarks>
  abstract member BeforeVisitSynTypeConstraintWhereTyparIsDelegate: genericName: SynTypar * delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhereTyparIsDelegate".</remarks>
  default this.BeforeVisitSynTypeConstraintWhereTyparIsDelegate(genericName: SynTypar, delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeConstraintWhereTyparIsDelegate(genericName |> (fun v -> this.VisitSynTypar(v, context)), delegateTypes, range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  abstract member VisitSynTypeConstraintWhereTyparIsDelegate: genericName: SynTypar * delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  default __.VisitSynTypeConstraintWhereTyparIsDelegate(genericName: SynTypar, delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeConstraint.WhereTyparIsDelegate (genericName, delegateTypes, range)


  /// <summary>
  /// Visit and dispatch "SynTypeConstraint" expression.
  /// </summary>
  /// <param name="synTypeConstraint">SynTypeConstraint expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeConstraint(synTypeConstraint: SynTypeConstraint, context: 'TContext) =
    parents.Push(synTypeConstraint)
    try
      match synTypeConstraint with
      | SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsValueType(genericName, range, context)
      | SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsReferenceType(genericName, range, context)
      | SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsUnmanaged(genericName, range, context)
      | SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparSupportsNull(genericName, range, context)
      | SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsComparable(genericName, range, context)
      | SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsEquatable(genericName, range, context)
      | SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparDefaultsToType(genericName, typeSig, range, context)
      | SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparSubtypeOfType(genericName, typeSig, range, context)
      | SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparSupportsMember(genericNames, memberSig, range, context)
      | SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsEnum(genericName, enumTypes, range, context)
      | SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
        this.BeforeVisitSynTypeConstraintWhereTyparIsDelegate(genericName, delegateTypes, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn".</remarks>
  abstract member BeforeVisitSynTypeDefnTypeDefn: item1: SynComponentInfo * item2: SynTypeDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn".</remarks>
  default this.BeforeVisitSynTypeDefnTypeDefn(item1: SynComponentInfo, item2: SynTypeDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnTypeDefn(item1 |> (fun v -> this.VisitSynComponentInfo(v, context)), item2 |> (fun v -> this.VisitSynTypeDefnRepr(v, context)), members, range, context)

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  abstract member VisitSynTypeDefnTypeDefn: item1: SynComponentInfo * item2: SynTypeDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefn

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  default __.VisitSynTypeDefnTypeDefn(item1: SynComponentInfo, item2: SynTypeDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefn.TypeDefn (item1, item2, members, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefn" expression.
  /// </summary>
  /// <param name="synTypeDefn">SynTypeDefn expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefn(synTypeDefn: SynTypeDefn, context: 'TContext) =
    parents.Push(synTypeDefn)
    try
      match synTypeDefn with
      | SynTypeDefn.TypeDefn(item1, item2, members, range) ->
        this.BeforeVisitSynTypeDefnTypeDefn(item1, item2, members, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconUnspecified".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconUnspecified: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconUnspecified".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconUnspecified(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconUnspecified(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  abstract member VisitSynTypeDefnKindTyconUnspecified: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  default __.VisitSynTypeDefnKindTyconUnspecified(context: 'TContext) =
    SynTypeDefnKind.TyconUnspecified 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconClass".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconClass: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconClass".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconClass(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconClass(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  abstract member VisitSynTypeDefnKindTyconClass: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  default __.VisitSynTypeDefnKindTyconClass(context: 'TContext) =
    SynTypeDefnKind.TyconClass 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconInterface".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconInterface: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconInterface".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconInterface(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconInterface(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  abstract member VisitSynTypeDefnKindTyconInterface: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  default __.VisitSynTypeDefnKindTyconInterface(context: 'TContext) =
    SynTypeDefnKind.TyconInterface 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconStruct".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconStruct: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconStruct".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconStruct(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconStruct(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  abstract member VisitSynTypeDefnKindTyconStruct: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  default __.VisitSynTypeDefnKindTyconStruct(context: 'TContext) =
    SynTypeDefnKind.TyconStruct 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconRecord".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconRecord: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconRecord".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconRecord(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconRecord(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  abstract member VisitSynTypeDefnKindTyconRecord: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  default __.VisitSynTypeDefnKindTyconRecord(context: 'TContext) =
    SynTypeDefnKind.TyconRecord 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconUnion".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconUnion: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconUnion".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconUnion(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconUnion(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  abstract member VisitSynTypeDefnKindTyconUnion: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  default __.VisitSynTypeDefnKindTyconUnion(context: 'TContext) =
    SynTypeDefnKind.TyconUnion 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconAbbrev".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconAbbrev: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconAbbrev".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconAbbrev(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconAbbrev(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  abstract member VisitSynTypeDefnKindTyconAbbrev: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  default __.VisitSynTypeDefnKindTyconAbbrev(context: 'TContext) =
    SynTypeDefnKind.TyconAbbrev 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconHiddenRepr".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconHiddenRepr: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconHiddenRepr".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconHiddenRepr(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconHiddenRepr(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  abstract member VisitSynTypeDefnKindTyconHiddenRepr: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  default __.VisitSynTypeDefnKindTyconHiddenRepr(context: 'TContext) =
    SynTypeDefnKind.TyconHiddenRepr 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconAugmentation".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconAugmentation: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconAugmentation".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconAugmentation(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconAugmentation(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  abstract member VisitSynTypeDefnKindTyconAugmentation: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  default __.VisitSynTypeDefnKindTyconAugmentation(context: 'TContext) =
    SynTypeDefnKind.TyconAugmentation 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconILAssemblyCode".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconILAssemblyCode: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconILAssemblyCode".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconILAssemblyCode(context: 'TContext) =
    this.VisitSynTypeDefnKindTyconILAssemblyCode(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  abstract member VisitSynTypeDefnKindTyconILAssemblyCode: context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  default __.VisitSynTypeDefnKindTyconILAssemblyCode(context: 'TContext) =
    SynTypeDefnKind.TyconILAssemblyCode 

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconDelegate".</remarks>
  abstract member BeforeVisitSynTypeDefnKindTyconDelegate: item1: SynType * item2: SynValInfo * context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyconDelegate".</remarks>
  default this.BeforeVisitSynTypeDefnKindTyconDelegate(item1: SynType, item2: SynValInfo, context: 'TContext) =
    this.VisitSynTypeDefnKindTyconDelegate(item1 |> (fun v -> this.VisitSynType(v, context)), item2 |> (fun v -> this.VisitSynValInfo(v, context)), context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  abstract member VisitSynTypeDefnKindTyconDelegate: item1: SynType * item2: SynValInfo * context: 'TContext -> SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  default __.VisitSynTypeDefnKindTyconDelegate(item1: SynType, item2: SynValInfo, context: 'TContext) =
    SynTypeDefnKind.TyconDelegate (item1, item2)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnKind" expression.
  /// </summary>
  /// <param name="synTypeDefnKind">SynTypeDefnKind expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefnKind(synTypeDefnKind: SynTypeDefnKind, context: 'TContext) =
    parents.Push(synTypeDefnKind)
    try
      match synTypeDefnKind with
      | SynTypeDefnKind.TyconUnspecified ->
        this.BeforeVisitSynTypeDefnKindTyconUnspecified(context)
      | SynTypeDefnKind.TyconClass ->
        this.BeforeVisitSynTypeDefnKindTyconClass(context)
      | SynTypeDefnKind.TyconInterface ->
        this.BeforeVisitSynTypeDefnKindTyconInterface(context)
      | SynTypeDefnKind.TyconStruct ->
        this.BeforeVisitSynTypeDefnKindTyconStruct(context)
      | SynTypeDefnKind.TyconRecord ->
        this.BeforeVisitSynTypeDefnKindTyconRecord(context)
      | SynTypeDefnKind.TyconUnion ->
        this.BeforeVisitSynTypeDefnKindTyconUnion(context)
      | SynTypeDefnKind.TyconAbbrev ->
        this.BeforeVisitSynTypeDefnKindTyconAbbrev(context)
      | SynTypeDefnKind.TyconHiddenRepr ->
        this.BeforeVisitSynTypeDefnKindTyconHiddenRepr(context)
      | SynTypeDefnKind.TyconAugmentation ->
        this.BeforeVisitSynTypeDefnKindTyconAugmentation(context)
      | SynTypeDefnKind.TyconILAssemblyCode ->
        this.BeforeVisitSynTypeDefnKindTyconILAssemblyCode(context)
      | SynTypeDefnKind.TyconDelegate(item1, item2) ->
        this.BeforeVisitSynTypeDefnKindTyconDelegate(item1, item2, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjectModel".</remarks>
  abstract member BeforeVisitSynTypeDefnReprObjectModel: item1: SynTypeDefnKind * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjectModel".</remarks>
  default this.BeforeVisitSynTypeDefnReprObjectModel(item1: SynTypeDefnKind, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnReprObjectModel(item1 |> (fun v -> this.VisitSynTypeDefnKind(v, context)), members, range, context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  abstract member VisitSynTypeDefnReprObjectModel: item1: SynTypeDefnKind * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  default __.VisitSynTypeDefnReprObjectModel(item1: SynTypeDefnKind, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnRepr.ObjectModel (item1, members, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimple".</remarks>
  abstract member BeforeVisitSynTypeDefnReprSimple: item1: SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimple".</remarks>
  default this.BeforeVisitSynTypeDefnReprSimple(item1: SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnReprSimple(item1 |> (fun v -> this.VisitSynTypeDefnSimpleRepr(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  abstract member VisitSynTypeDefnReprSimple: item1: SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  default __.VisitSynTypeDefnReprSimple(item1: SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnRepr.Simple (item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  abstract member BeforeVisitSynTypeDefnReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  default this.BeforeVisitSynTypeDefnReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    this.VisitSynTypeDefnReprException(item |> (fun v -> this.VisitSynExceptionDefnRepr(v, context)), context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  abstract member VisitSynTypeDefnReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  default __.VisitSynTypeDefnReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    SynTypeDefnRepr.Exception (item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnRepr" expression.
  /// </summary>
  /// <param name="synTypeDefnRepr">SynTypeDefnRepr expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefnRepr(synTypeDefnRepr: SynTypeDefnRepr, context: 'TContext) =
    parents.Push(synTypeDefnRepr)
    try
      match synTypeDefnRepr with
      | SynTypeDefnRepr.ObjectModel(item1, members, range) ->
        this.BeforeVisitSynTypeDefnReprObjectModel(item1, members, range, context)
      | SynTypeDefnRepr.Simple(item1, range) ->
        this.BeforeVisitSynTypeDefnReprSimple(item1, range, context)
      | SynTypeDefnRepr.Exception(item) ->
        this.BeforeVisitSynTypeDefnReprException(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig".</remarks>
  abstract member BeforeVisitSynTypeDefnSigTypeDefnSig: item1: SynComponentInfo * item2: SynTypeDefnSigRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig".</remarks>
  default this.BeforeVisitSynTypeDefnSigTypeDefnSig(item1: SynComponentInfo, item2: SynTypeDefnSigRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSigTypeDefnSig(item1 |> (fun v -> this.VisitSynComponentInfo(v, context)), item2 |> (fun v -> this.VisitSynTypeDefnSigRepr(v, context)), memberSigs, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  abstract member VisitSynTypeDefnSigTypeDefnSig: item1: SynComponentInfo * item2: SynTypeDefnSigRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSig

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  default __.VisitSynTypeDefnSigTypeDefnSig(item1: SynComponentInfo, item2: SynTypeDefnSigRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSig.TypeDefnSig (item1, item2, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSig" expression.
  /// </summary>
  /// <param name="synTypeDefnSig">SynTypeDefnSig expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefnSig(synTypeDefnSig: SynTypeDefnSig, context: 'TContext) =
    parents.Push(synTypeDefnSig)
    try
      match synTypeDefnSig with
      | SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
        this.BeforeVisitSynTypeDefnSigTypeDefnSig(item1, item2, memberSigs, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjectModel".</remarks>
  abstract member BeforeVisitSynTypeDefnSigReprObjectModel: item1: SynTypeDefnKind * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjectModel".</remarks>
  default this.BeforeVisitSynTypeDefnSigReprObjectModel(item1: SynTypeDefnKind, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSigReprObjectModel(item1 |> (fun v -> this.VisitSynTypeDefnKind(v, context)), memberSigs, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  abstract member VisitSynTypeDefnSigReprObjectModel: item1: SynTypeDefnKind * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  default __.VisitSynTypeDefnSigReprObjectModel(item1: SynTypeDefnKind, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSigRepr.ObjectModel (item1, memberSigs, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimple".</remarks>
  abstract member BeforeVisitSynTypeDefnSigReprSimple: item1: SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimple".</remarks>
  default this.BeforeVisitSynTypeDefnSigReprSimple(item1: SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSigReprSimple(item1 |> (fun v -> this.VisitSynTypeDefnSimpleRepr(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  abstract member VisitSynTypeDefnSigReprSimple: item1: SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  default __.VisitSynTypeDefnSigReprSimple(item1: SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSigRepr.Simple (item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  abstract member BeforeVisitSynTypeDefnSigReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  default this.BeforeVisitSynTypeDefnSigReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    this.VisitSynTypeDefnSigReprException(item |> (fun v -> this.VisitSynExceptionDefnRepr(v, context)), context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  abstract member VisitSynTypeDefnSigReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  default __.VisitSynTypeDefnSigReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    SynTypeDefnSigRepr.Exception (item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSigRepr" expression.
  /// </summary>
  /// <param name="synTypeDefnSigRepr">SynTypeDefnSigRepr expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefnSigRepr(synTypeDefnSigRepr: SynTypeDefnSigRepr, context: 'TContext) =
    parents.Push(synTypeDefnSigRepr)
    try
      match synTypeDefnSigRepr with
      | SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
        this.BeforeVisitSynTypeDefnSigReprObjectModel(item1, memberSigs, range, context)
      | SynTypeDefnSigRepr.Simple(item1, range) ->
        this.BeforeVisitSynTypeDefnSigReprSimple(item1, range, context)
      | SynTypeDefnSigRepr.Exception(item) ->
        this.BeforeVisitSynTypeDefnSigReprException(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnion".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprUnion: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnion".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprUnion(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprUnion(accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), cases, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  abstract member VisitSynTypeDefnSimpleReprUnion: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  default __.VisitSynTypeDefnSimpleReprUnion(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.Union (accessiblity, cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnum".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprEnum: cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnum".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprEnum(cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprEnum(cases, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  abstract member VisitSynTypeDefnSimpleReprEnum: cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  default __.VisitSynTypeDefnSimpleReprEnum(cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.Enum (cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprRecord: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * fields: Microsoft.FSharp.Compiler.Ast.SynField list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprRecord(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, fields: Microsoft.FSharp.Compiler.Ast.SynField list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprRecord(accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), fields, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  abstract member VisitSynTypeDefnSimpleReprRecord: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * fields: Microsoft.FSharp.Compiler.Ast.SynField list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  default __.VisitSynTypeDefnSimpleReprRecord(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, fields: Microsoft.FSharp.Compiler.Ast.SynField list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.Record (accessiblity, fields, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitGeneral".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprGeneral: item1: SynTypeDefnKind * item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list * item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list * item4: Microsoft.FSharp.Compiler.Ast.SynField list * item5: bool * item6: bool * item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitGeneral".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprGeneral(item1: SynTypeDefnKind, item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list, item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list, item4: Microsoft.FSharp.Compiler.Ast.SynField list, item5: bool, item6: bool, item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprGeneral(item1 |> (fun v -> this.VisitSynTypeDefnKind(v, context)), item2, item3, item4, item5, item6, item7, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  abstract member VisitSynTypeDefnSimpleReprGeneral: item1: SynTypeDefnKind * item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list * item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list * item4: Microsoft.FSharp.Compiler.Ast.SynField list * item5: bool * item6: bool * item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  default __.VisitSynTypeDefnSimpleReprGeneral(item1: SynTypeDefnKind, item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list, item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list, item4: Microsoft.FSharp.Compiler.Ast.SynField list, item5: bool, item6: bool, item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.General (item1, item2, item3, item4, item5, item6, item7, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprLibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprLibraryOnlyILAssembly(item1, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitSynTypeDefnSimpleReprLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  default __.VisitSynTypeDefnSimpleReprLibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.LibraryOnlyILAssembly (item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeAbbrev".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprTypeAbbrev: item1: ParserDetail * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeAbbrev".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprTypeAbbrev(item1: ParserDetail, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprTypeAbbrev(item1, item2 |> (fun v -> this.VisitSynType(v, context)), range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  abstract member VisitSynTypeDefnSimpleReprTypeAbbrev: item1: ParserDetail * item2: SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  default __.VisitSynTypeDefnSimpleReprTypeAbbrev(item1: ParserDetail, item2: SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.TypeAbbrev (item1, item2, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNone".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprNone: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNone".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprNone(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprNone(range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  abstract member VisitSynTypeDefnSimpleReprNone: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  default __.VisitSynTypeDefnSimpleReprNone(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynTypeDefnSimpleRepr.None (range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  abstract member BeforeVisitSynTypeDefnSimpleReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitException".</remarks>
  default this.BeforeVisitSynTypeDefnSimpleReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    this.VisitSynTypeDefnSimpleReprException(item |> (fun v -> this.VisitSynExceptionDefnRepr(v, context)), context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  abstract member VisitSynTypeDefnSimpleReprException: item: SynExceptionDefnRepr * context: 'TContext -> SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  default __.VisitSynTypeDefnSimpleReprException(item: SynExceptionDefnRepr, context: 'TContext) =
    SynTypeDefnSimpleRepr.Exception (item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSimpleRepr" expression.
  /// </summary>
  /// <param name="synTypeDefnSimpleRepr">SynTypeDefnSimpleRepr expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynTypeDefnSimpleRepr(synTypeDefnSimpleRepr: SynTypeDefnSimpleRepr, context: 'TContext) =
    parents.Push(synTypeDefnSimpleRepr)
    try
      match synTypeDefnSimpleRepr with
      | SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprUnion(accessiblity, cases, range, context)
      | SynTypeDefnSimpleRepr.Enum(cases, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprEnum(cases, range, context)
      | SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprRecord(accessiblity, fields, range, context)
      | SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprGeneral(item1, item2, item3, item4, item5, item6, item7, range, context)
      | SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprLibraryOnlyILAssembly(item1, range, context)
      | SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
        this.BeforeVisitSynTypeDefnSimpleReprTypeAbbrev(item1, item2, range, context)
      | SynTypeDefnSimpleRepr.None(range) ->
        this.BeforeVisitSynTypeDefnSimpleReprNone(range, context)
      | SynTypeDefnSimpleRepr.Exception(item) ->
        this.BeforeVisitSynTypeDefnSimpleReprException(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase".</remarks>
  abstract member BeforeVisitSynUnionCaseUnionCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * caseType: SynUnionCaseType * xmlDoc: PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase".</remarks>
  default this.BeforeVisitSynUnionCaseUnionCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, caseType: SynUnionCaseType, xmlDoc: PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynUnionCaseUnionCase(attributes, id, caseType |> (fun v -> this.VisitSynUnionCaseType(v, context)), xmlDoc, accessibility |> (Option.map (fun v -> this.VisitSynAccess(v, context))), range, context)

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  abstract member VisitSynUnionCaseUnionCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * caseType: SynUnionCaseType * xmlDoc: PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynUnionCase

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  default __.VisitSynUnionCaseUnionCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, caseType: SynUnionCaseType, xmlDoc: PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynUnionCase.UnionCase (attributes, id, caseType, xmlDoc, accessibility, range)


  /// <summary>
  /// Visit and dispatch "SynUnionCase" expression.
  /// </summary>
  /// <param name="synUnionCase">SynUnionCase expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynUnionCase(synUnionCase: SynUnionCase, context: 'TContext) =
    parents.Push(synUnionCase)
    try
      match synUnionCase with
      | SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
        this.BeforeVisitSynUnionCaseUnionCase(attributes, id, caseType, xmlDoc, accessibility, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseFields".</remarks>
  abstract member BeforeVisitSynUnionCaseTypeUnionCaseFields: cases: Microsoft.FSharp.Compiler.Ast.SynField list * context: 'TContext -> SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseFields".</remarks>
  default this.BeforeVisitSynUnionCaseTypeUnionCaseFields(cases: Microsoft.FSharp.Compiler.Ast.SynField list, context: 'TContext) =
    this.VisitSynUnionCaseTypeUnionCaseFields(cases, context)

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  abstract member VisitSynUnionCaseTypeUnionCaseFields: cases: Microsoft.FSharp.Compiler.Ast.SynField list * context: 'TContext -> SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  default __.VisitSynUnionCaseTypeUnionCaseFields(cases: Microsoft.FSharp.Compiler.Ast.SynField list, context: 'TContext) =
    SynUnionCaseType.UnionCaseFields (cases)

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseFullType".</remarks>
  abstract member BeforeVisitSynUnionCaseTypeUnionCaseFullType: item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) * context: 'TContext -> SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseFullType".</remarks>
  default this.BeforeVisitSynUnionCaseTypeUnionCaseFullType(item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo), context: 'TContext) =
    this.VisitSynUnionCaseTypeUnionCaseFullType(item, context)

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  abstract member VisitSynUnionCaseTypeUnionCaseFullType: item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) * context: 'TContext -> SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  default __.VisitSynUnionCaseTypeUnionCaseFullType(item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo), context: 'TContext) =
    SynUnionCaseType.UnionCaseFullType (item)


  /// <summary>
  /// Visit and dispatch "SynUnionCaseType" expression.
  /// </summary>
  /// <param name="synUnionCaseType">SynUnionCaseType expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynUnionCaseType(synUnionCaseType: SynUnionCaseType, context: 'TContext) =
    parents.Push(synUnionCaseType)
    try
      match synUnionCaseType with
      | SynUnionCaseType.UnionCaseFields(cases) ->
        this.BeforeVisitSynUnionCaseTypeUnionCaseFields(cases, context)
      | SynUnionCaseType.UnionCaseFullType(item) ->
        this.BeforeVisitSynUnionCaseTypeUnionCaseFullType(item, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValData".</remarks>
  abstract member BeforeVisitSynValDataSynValData: item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option * item2: SynValInfo * item3: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValData".</remarks>
  default this.BeforeVisitSynValDataSynValData(item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option, item2: SynValInfo, item3: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    this.VisitSynValDataSynValData(item1, item2 |> (fun v -> this.VisitSynValInfo(v, context)), item3, context)

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  abstract member VisitSynValDataSynValData: item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option * item2: SynValInfo * item3: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> SynValData

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  default __.VisitSynValDataSynValData(item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option, item2: SynValInfo, item3: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    SynValData.SynValData (item1, item2, item3)


  /// <summary>
  /// Visit and dispatch "SynValData" expression.
  /// </summary>
  /// <param name="synValData">SynValData expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynValData(synValData: SynValData, context: 'TContext) =
    parents.Push(synValData)
    try
      match synValData with
      | SynValData.SynValData(item1, item2, item3) ->
        this.BeforeVisitSynValDataSynValData(item1, item2, item3, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValInfo".</remarks>
  abstract member BeforeVisitSynValInfoSynValInfo: item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list * item2: SynArgInfo * context: 'TContext -> SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValInfo".</remarks>
  default this.BeforeVisitSynValInfoSynValInfo(item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list, item2: SynArgInfo, context: 'TContext) =
    this.VisitSynValInfoSynValInfo(item1, item2 |> (fun v -> this.VisitSynArgInfo(v, context)), context)

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  abstract member VisitSynValInfoSynValInfo: item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list * item2: SynArgInfo * context: 'TContext -> SynValInfo

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  default __.VisitSynValInfoSynValInfo(item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list, item2: SynArgInfo, context: 'TContext) =
    SynValInfo.SynValInfo (item1, item2)


  /// <summary>
  /// Visit and dispatch "SynValInfo" expression.
  /// </summary>
  /// <param name="synValInfo">SynValInfo expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynValInfo(synValInfo: SynValInfo, context: 'TContext) =
    parents.Push(synValInfo)
    try
      match synValInfo with
      | SynValInfo.SynValInfo(item1, item2) ->
        this.BeforeVisitSynValInfoSynValInfo(item1, item2, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSpfn".</remarks>
  abstract member BeforeVisitSynValSigValSpfn: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * typeParams: SynValTyparDecls * typeName: SynType * valInfo: SynValInfo * item6: bool * isMutable: bool * xmlDoc: PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSpfn".</remarks>
  default this.BeforeVisitSynValSigValSpfn(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, typeParams: SynValTyparDecls, typeName: SynType, valInfo: SynValInfo, item6: bool, isMutable: bool, xmlDoc: PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSynValSigValSpfn(attributes, id, typeParams |> (fun v -> this.VisitSynValTyparDecls(v, context)), typeName |> (fun v -> this.VisitSynType(v, context)), valInfo |> (fun v -> this.VisitSynValInfo(v, context)), item6, isMutable, xmlDoc, accessiblity |> (Option.map (fun v -> this.VisitSynAccess(v, context))), expr |> (Option.map (fun v -> this.VisitSynExpr(v, context))), range, context)

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  abstract member VisitSynValSigValSpfn: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Ident * typeParams: SynValTyparDecls * typeName: SynType * valInfo: SynValInfo * item6: bool * isMutable: bool * xmlDoc: PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> SynValSig

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  default __.VisitSynValSigValSpfn(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Ident, typeParams: SynValTyparDecls, typeName: SynType, valInfo: SynValInfo, item6: bool, isMutable: bool, xmlDoc: PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    SynValSig.ValSpfn (attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)


  /// <summary>
  /// Visit and dispatch "SynValSig" expression.
  /// </summary>
  /// <param name="synValSig">SynValSig expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynValSig(synValSig: SynValSig, context: 'TContext) =
    parents.Push(synValSig)
    try
      match synValSig with
      | SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
        this.BeforeVisitSynValSigValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValTyparDecls".</remarks>
  abstract member BeforeVisitSynValTyparDeclsSynValTyparDecls: item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * item2: bool * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * context: 'TContext -> SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSynValTyparDecls".</remarks>
  default this.BeforeVisitSynValTyparDeclsSynValTyparDecls(item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, item2: bool, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, context: 'TContext) =
    this.VisitSynValTyparDeclsSynValTyparDecls(item1, item2, constraints, context)

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  abstract member VisitSynValTyparDeclsSynValTyparDecls: item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * item2: bool * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * context: 'TContext -> SynValTyparDecls

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  default __.VisitSynValTyparDeclsSynValTyparDecls(item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, item2: bool, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, context: 'TContext) =
    SynValTyparDecls.SynValTyparDecls (item1, item2, constraints)


  /// <summary>
  /// Visit and dispatch "SynValTyparDecls" expression.
  /// </summary>
  /// <param name="synValTyparDecls">SynValTyparDecls expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynValTyparDecls(synValTyparDecls: SynValTyparDecls, context: 'TContext) =
    parents.Push(synValTyparDecls)
    try
      match synValTyparDecls with
      | SynValTyparDecls.SynValTyparDecls(item1, item2, constraints) ->
        this.BeforeVisitSynValTyparDeclsSynValTyparDecls(item1, item2, constraints, context)
    finally
      parents.Pop() |> ignore

