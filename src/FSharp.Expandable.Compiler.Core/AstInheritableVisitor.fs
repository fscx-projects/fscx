//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 06 Sep 2016 06:09:29 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

#nowarn "1182"

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstInheritableVisitor<'TContext>() =

  // TODO: du element
  let parents = new System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.AstElement>()

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
  /// <remarks>Default implementation invoked "VisitAccess_Public".</remarks>
  abstract member BeforeVisitAccess_Public:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Public".</remarks>
  default this.BeforeVisitAccess_Public
     (context: 'TContext) =
    this.VisitAccess_Public(
      context)

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  abstract member VisitAccess_Public:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  default __.VisitAccess_Public
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Public

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Internal".</remarks>
  abstract member BeforeVisitAccess_Internal:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Internal".</remarks>
  default this.BeforeVisitAccess_Internal
     (context: 'TContext) =
    this.VisitAccess_Internal(
      context)

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  abstract member VisitAccess_Internal:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  default __.VisitAccess_Internal
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Internal

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Private".</remarks>
  abstract member BeforeVisitAccess_Private:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Private".</remarks>
  default this.BeforeVisitAccess_Private
     (context: 'TContext) =
    this.VisitAccess_Private(
      context)

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  abstract member VisitAccess_Private:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  default __.VisitAccess_Private
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Private


  /// <summary>
  /// Visit and dispatch "SynAccess" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synAccess">SynAccess expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitAccess
      (context: 'TContext)
      (synAccess: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Access synAccess)
    try
      match synAccess with
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Public ->
        this.BeforeVisitAccess_Public(context)
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal ->
        this.BeforeVisitAccess_Internal(context)
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Private ->
        this.BeforeVisitAccess_Private(context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArgInfo_SynArgInfo".</remarks>
  abstract member BeforeVisitArgInfo_SynArgInfo:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    optional: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident option -> Microsoft.FSharp.Compiler.Ast.SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArgInfo_SynArgInfo".</remarks>
  default this.BeforeVisitArgInfo_SynArgInfo
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      optional: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident option) =
    this.VisitArgInfo_SynArgInfo(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      optional,
      id)

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  abstract member VisitArgInfo_SynArgInfo:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    optional: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident option -> Microsoft.FSharp.Compiler.Ast.SynArgInfo

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  default __.VisitArgInfo_SynArgInfo
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      optional: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident option) =
    Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id)


  /// <summary>
  /// Visit and dispatch "SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synArgInfo">SynArgInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitArgInfo
      (context: 'TContext)
      (synArgInfo: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ArgInfo synArgInfo)
    try
      match synArgInfo with
      | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
        this.BeforeVisitArgInfo_SynArgInfo(context, attributes, optional, id)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding_Binding".</remarks>
  abstract member BeforeVisitBinding_Binding:
    context: 'TContext *
    access: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind *
    mustInline: bool *
    isMutable: bool *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    item7: Microsoft.FSharp.Compiler.Ast.SynValData *
    headPat: Microsoft.FSharp.Compiler.Ast.SynPat *
    item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    lhsRange: Microsoft.FSharp.Compiler.Range.range *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Ast.SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding_Binding".</remarks>
  default this.BeforeVisitBinding_Binding
     (context: 'TContext,
      access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind,
      mustInline: bool,
      isMutable: bool,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      item7: Microsoft.FSharp.Compiler.Ast.SynValData,
      headPat: Microsoft.FSharp.Compiler.Ast.SynPat,
      item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      lhsRange: Microsoft.FSharp.Compiler.Range.range,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) =
    this.VisitBinding_Binding(
      context,
      access |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      this.VisitBindingKind context bindingKind,
      mustInline,
      isMutable,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      xmlDoc,
      this.VisitValData context item7,
      this.VisitPat context headPat,
      item9 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitBindingReturnInfo context v),
      this.VisitExpr context expr,
      lhsRange,
      spBind)

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  abstract member VisitBinding_Binding:
    context: 'TContext *
    access: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind *
    mustInline: bool *
    isMutable: bool *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    item7: Microsoft.FSharp.Compiler.Ast.SynValData *
    headPat: Microsoft.FSharp.Compiler.Ast.SynPat *
    item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    lhsRange: Microsoft.FSharp.Compiler.Range.range *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Ast.SynBinding

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  default __.VisitBinding_Binding
     (context: 'TContext,
      access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind,
      mustInline: bool,
      isMutable: bool,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      item7: Microsoft.FSharp.Compiler.Ast.SynValData,
      headPat: Microsoft.FSharp.Compiler.Ast.SynPat,
      item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      lhsRange: Microsoft.FSharp.Compiler.Range.range,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) =
    Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)


  /// <summary>
  /// Visit and dispatch "SynBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBinding">SynBinding expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBinding
      (context: 'TContext)
      (synBinding: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Binding synBinding)
    try
      match synBinding with
      | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
        this.BeforeVisitBinding_Binding(context, access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_StandaloneExpression".</remarks>
  abstract member BeforeVisitBindingKind_StandaloneExpression:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_StandaloneExpression".</remarks>
  default this.BeforeVisitBindingKind_StandaloneExpression
     (context: 'TContext) =
    this.VisitBindingKind_StandaloneExpression(
      context)

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  abstract member VisitBindingKind_StandaloneExpression:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  default __.VisitBindingKind_StandaloneExpression
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_NormalBinding".</remarks>
  abstract member BeforeVisitBindingKind_NormalBinding:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_NormalBinding".</remarks>
  default this.BeforeVisitBindingKind_NormalBinding
     (context: 'TContext) =
    this.VisitBindingKind_NormalBinding(
      context)

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  abstract member VisitBindingKind_NormalBinding:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  default __.VisitBindingKind_NormalBinding
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_DoBinding".</remarks>
  abstract member BeforeVisitBindingKind_DoBinding:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_DoBinding".</remarks>
  default this.BeforeVisitBindingKind_DoBinding
     (context: 'TContext) =
    this.VisitBindingKind_DoBinding(
      context)

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  abstract member VisitBindingKind_DoBinding:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  default __.VisitBindingKind_DoBinding
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding


  /// <summary>
  /// Visit and dispatch "SynBindingKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingKind">SynBindingKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingKind
      (context: 'TContext)
      (synBindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.BindingKind synBindingKind)
    try
      match synBindingKind with
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression ->
        this.BeforeVisitBindingKind_StandaloneExpression(context)
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding ->
        this.BeforeVisitBindingKind_NormalBinding(context)
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding ->
        this.BeforeVisitBindingKind_DoBinding(context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingReturnInfo_SynBindingReturnInfo".</remarks>
  abstract member BeforeVisitBindingReturnInfo_SynBindingReturnInfo:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list -> Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingReturnInfo_SynBindingReturnInfo".</remarks>
  default this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) =
    this.VisitBindingReturnInfo_SynBindingReturnInfo(
      context,
      this.VisitType context typeName,
      range,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)))

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  abstract member VisitBindingReturnInfo_SynBindingReturnInfo:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list -> Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  default __.VisitBindingReturnInfo_SynBindingReturnInfo
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) =
    Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes)


  /// <summary>
  /// Visit and dispatch "SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingReturnInfo">SynBindingReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingReturnInfo
      (context: 'TContext)
      (synBindingReturnInfo: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.BindingReturnInfo synBindingReturnInfo)
    try
      match synBindingReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
        this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo(context, typeName, range, attributes)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo_ComponentInfo".</remarks>
  abstract member BeforeVisitComponentInfo_ComponentInfo:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list *
    item4: Microsoft.FSharp.Compiler.Ast.Ident list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    preferPostfix: bool *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo_ComponentInfo".</remarks>
  default this.BeforeVisitComponentInfo_ComponentInfo
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
      item4: Microsoft.FSharp.Compiler.Ast.Ident list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      preferPostfix: bool,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitComponentInfo_ComponentInfo(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTyparDecl context v),
      constraints |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypeConstraint context v),
      item4,
      xmlDoc,
      preferPostfix,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  abstract member VisitComponentInfo_ComponentInfo:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list *
    item4: Microsoft.FSharp.Compiler.Ast.Ident list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    preferPostfix: bool *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynComponentInfo

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  default __.VisitComponentInfo_ComponentInfo
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
      item4: Microsoft.FSharp.Compiler.Ast.Ident list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      preferPostfix: bool,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synComponentInfo">SynComponentInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitComponentInfo
      (context: 'TContext)
      (synComponentInfo: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ComponentInfo synComponentInfo)
    try
      match synComponentInfo with
      | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
        this.BeforeVisitComponentInfo_ComponentInfo(context, attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Unit".</remarks>
  abstract member BeforeVisitConst_Unit:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Unit".</remarks>
  default this.BeforeVisitConst_Unit
     (context: 'TContext) =
    this.VisitConst_Unit(
      context)

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  abstract member VisitConst_Unit:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  default __.VisitConst_Unit
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Unit

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bool".</remarks>
  abstract member BeforeVisitConst_Bool:
    context: 'TContext *
    item: bool -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bool".</remarks>
  default this.BeforeVisitConst_Bool
     (context: 'TContext,
      item: bool) =
    this.VisitConst_Bool(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  abstract member VisitConst_Bool:
    context: 'TContext *
    item: bool -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  default __.VisitConst_Bool
     (context: 'TContext,
      item: bool) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item)

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_SByte".</remarks>
  abstract member BeforeVisitConst_SByte:
    context: 'TContext *
    item: System.SByte -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_SByte".</remarks>
  default this.BeforeVisitConst_SByte
     (context: 'TContext,
      item: System.SByte) =
    this.VisitConst_SByte(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  abstract member VisitConst_SByte:
    context: 'TContext *
    item: System.SByte -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  default __.VisitConst_SByte
     (context: 'TContext,
      item: System.SByte) =
    Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item)

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Byte".</remarks>
  abstract member BeforeVisitConst_Byte:
    context: 'TContext *
    item: byte -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Byte".</remarks>
  default this.BeforeVisitConst_Byte
     (context: 'TContext,
      item: byte) =
    this.VisitConst_Byte(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  abstract member VisitConst_Byte:
    context: 'TContext *
    item: byte -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  default __.VisitConst_Byte
     (context: 'TContext,
      item: byte) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item)

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int16".</remarks>
  abstract member BeforeVisitConst_Int16:
    context: 'TContext *
    item: int16 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int16".</remarks>
  default this.BeforeVisitConst_Int16
     (context: 'TContext,
      item: int16) =
    this.VisitConst_Int16(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  abstract member VisitConst_Int16:
    context: 'TContext *
    item: int16 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  default __.VisitConst_Int16
     (context: 'TContext,
      item: int16) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item)

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16".</remarks>
  abstract member BeforeVisitConst_UInt16:
    context: 'TContext *
    item: System.UInt16 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16".</remarks>
  default this.BeforeVisitConst_UInt16
     (context: 'TContext,
      item: System.UInt16) =
    this.VisitConst_UInt16(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  abstract member VisitConst_UInt16:
    context: 'TContext *
    item: System.UInt16 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  default __.VisitConst_UInt16
     (context: 'TContext,
      item: System.UInt16) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item)

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int32".</remarks>
  abstract member BeforeVisitConst_Int32:
    context: 'TContext *
    item: int -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int32".</remarks>
  default this.BeforeVisitConst_Int32
     (context: 'TContext,
      item: int) =
    this.VisitConst_Int32(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  abstract member VisitConst_Int32:
    context: 'TContext *
    item: int -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  default __.VisitConst_Int32
     (context: 'TContext,
      item: int) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item)

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt32".</remarks>
  abstract member BeforeVisitConst_UInt32:
    context: 'TContext *
    item: System.UInt32 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt32".</remarks>
  default this.BeforeVisitConst_UInt32
     (context: 'TContext,
      item: System.UInt32) =
    this.VisitConst_UInt32(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  abstract member VisitConst_UInt32:
    context: 'TContext *
    item: System.UInt32 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  default __.VisitConst_UInt32
     (context: 'TContext,
      item: System.UInt32) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item)

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int64".</remarks>
  abstract member BeforeVisitConst_Int64:
    context: 'TContext *
    item: int64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int64".</remarks>
  default this.BeforeVisitConst_Int64
     (context: 'TContext,
      item: int64) =
    this.VisitConst_Int64(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  abstract member VisitConst_Int64:
    context: 'TContext *
    item: int64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  default __.VisitConst_Int64
     (context: 'TContext,
      item: int64) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item)

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt64".</remarks>
  abstract member BeforeVisitConst_UInt64:
    context: 'TContext *
    item: System.UInt64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt64".</remarks>
  default this.BeforeVisitConst_UInt64
     (context: 'TContext,
      item: System.UInt64) =
    this.VisitConst_UInt64(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  abstract member VisitConst_UInt64:
    context: 'TContext *
    item: System.UInt64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  default __.VisitConst_UInt64
     (context: 'TContext,
      item: System.UInt64) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item)

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_IntPtr".</remarks>
  abstract member BeforeVisitConst_IntPtr:
    context: 'TContext *
    item: int64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_IntPtr".</remarks>
  default this.BeforeVisitConst_IntPtr
     (context: 'TContext,
      item: int64) =
    this.VisitConst_IntPtr(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  abstract member VisitConst_IntPtr:
    context: 'TContext *
    item: int64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  default __.VisitConst_IntPtr
     (context: 'TContext,
      item: int64) =
    Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item)

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UIntPtr".</remarks>
  abstract member BeforeVisitConst_UIntPtr:
    context: 'TContext *
    item: System.UInt64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UIntPtr".</remarks>
  default this.BeforeVisitConst_UIntPtr
     (context: 'TContext,
      item: System.UInt64) =
    this.VisitConst_UIntPtr(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  abstract member VisitConst_UIntPtr:
    context: 'TContext *
    item: System.UInt64 -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  default __.VisitConst_UIntPtr
     (context: 'TContext,
      item: System.UInt64) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item)

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Single".</remarks>
  abstract member BeforeVisitConst_Single:
    context: 'TContext *
    item: System.Single -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Single".</remarks>
  default this.BeforeVisitConst_Single
     (context: 'TContext,
      item: System.Single) =
    this.VisitConst_Single(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  abstract member VisitConst_Single:
    context: 'TContext *
    item: System.Single -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  default __.VisitConst_Single
     (context: 'TContext,
      item: System.Single) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Single(item)

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Double".</remarks>
  abstract member BeforeVisitConst_Double:
    context: 'TContext *
    item: System.Double -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Double".</remarks>
  default this.BeforeVisitConst_Double
     (context: 'TContext,
      item: System.Double) =
    this.VisitConst_Double(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  abstract member VisitConst_Double:
    context: 'TContext *
    item: System.Double -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  default __.VisitConst_Double
     (context: 'TContext,
      item: System.Double) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Double(item)

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Char".</remarks>
  abstract member BeforeVisitConst_Char:
    context: 'TContext *
    item: char -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Char".</remarks>
  default this.BeforeVisitConst_Char
     (context: 'TContext,
      item: char) =
    this.VisitConst_Char(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  abstract member VisitConst_Char:
    context: 'TContext *
    item: char -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  default __.VisitConst_Char
     (context: 'TContext,
      item: char) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Char(item)

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Decimal".</remarks>
  abstract member BeforeVisitConst_Decimal:
    context: 'TContext *
    item: System.Decimal -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Decimal".</remarks>
  default this.BeforeVisitConst_Decimal
     (context: 'TContext,
      item: System.Decimal) =
    this.VisitConst_Decimal(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  abstract member VisitConst_Decimal:
    context: 'TContext *
    item: System.Decimal -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  default __.VisitConst_Decimal
     (context: 'TContext,
      item: System.Decimal) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item)

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UserNum".</remarks>
  abstract member BeforeVisitConst_UserNum:
    context: 'TContext *
    item: (string * string) -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UserNum".</remarks>
  default this.BeforeVisitConst_UserNum
     (context: 'TContext,
      item: (string * string)) =
    this.VisitConst_UserNum(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  abstract member VisitConst_UserNum:
    context: 'TContext *
    item: (string * string) -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  default __.VisitConst_UserNum
     (context: 'TContext,
      item: (string * string)) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item)

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_String".</remarks>
  abstract member BeforeVisitConst_String:
    context: 'TContext *
    text: string *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_String".</remarks>
  default this.BeforeVisitConst_String
     (context: 'TContext,
      text: string,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitConst_String(
      context,
      text,
      range)

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  abstract member VisitConst_String:
    context: 'TContext *
    text: string *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  default __.VisitConst_String
     (context: 'TContext,
      text: string,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range)

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bytes".</remarks>
  abstract member BeforeVisitConst_Bytes:
    context: 'TContext *
    bytes: byte[] *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bytes".</remarks>
  default this.BeforeVisitConst_Bytes
     (context: 'TContext,
      bytes: byte[],
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitConst_Bytes(
      context,
      bytes,
      range)

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  abstract member VisitConst_Bytes:
    context: 'TContext *
    bytes: byte[] *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  default __.VisitConst_Bytes
     (context: 'TContext,
      bytes: byte[],
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range)

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16s".</remarks>
  abstract member BeforeVisitConst_UInt16s:
    context: 'TContext *
    item: System.UInt16[] -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16s".</remarks>
  default this.BeforeVisitConst_UInt16s
     (context: 'TContext,
      item: System.UInt16[]) =
    this.VisitConst_UInt16s(
      context,
      item)

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  abstract member VisitConst_UInt16s:
    context: 'TContext *
    item: System.UInt16[] -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  default __.VisitConst_UInt16s
     (context: 'TContext,
      item: System.UInt16[]) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item)

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Measure".</remarks>
  abstract member BeforeVisitConst_Measure:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Measure".</remarks>
  default this.BeforeVisitConst_Measure
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    this.VisitConst_Measure(
      context,
      this.VisitConst context constant,
      this.VisitMeasure context item2)

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  abstract member VisitConst_Measure:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  default __.VisitConst_Measure
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2)


  /// <summary>
  /// Visit and dispatch "SynConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConst">SynConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConst
      (context: 'TContext)
      (synConst: Microsoft.FSharp.Compiler.Ast.SynConst) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Const synConst)
    try
      match synConst with
      | Microsoft.FSharp.Compiler.Ast.SynConst.Unit ->
        this.BeforeVisitConst_Unit(context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item) ->
        this.BeforeVisitConst_Bool(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item) ->
        this.BeforeVisitConst_SByte(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item) ->
        this.BeforeVisitConst_Byte(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item) ->
        this.BeforeVisitConst_Int16(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item) ->
        this.BeforeVisitConst_UInt16(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item) ->
        this.BeforeVisitConst_Int32(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item) ->
        this.BeforeVisitConst_UInt32(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item) ->
        this.BeforeVisitConst_Int64(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item) ->
        this.BeforeVisitConst_UInt64(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item) ->
        this.BeforeVisitConst_IntPtr(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item) ->
        this.BeforeVisitConst_UIntPtr(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Single(item) ->
        this.BeforeVisitConst_Single(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Double(item) ->
        this.BeforeVisitConst_Double(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Char(item) ->
        this.BeforeVisitConst_Char(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item) ->
        this.BeforeVisitConst_Decimal(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item) ->
        this.BeforeVisitConst_UserNum(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range) ->
        this.BeforeVisitConst_String(context, text, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range) ->
        this.BeforeVisitConst_Bytes(context, bytes, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item) ->
        this.BeforeVisitConst_UInt16s(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
        this.BeforeVisitConst_Measure(context, constant, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_Pats".</remarks>
  abstract member BeforeVisitConstructorArgs_Pats:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynPat list -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_Pats".</remarks>
  default this.BeforeVisitConstructorArgs_Pats
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynPat list) =
    this.VisitConstructorArgs_Pats(
      context,
      item |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitPat context v))

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  abstract member VisitConstructorArgs_Pats:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynPat list -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  default __.VisitConstructorArgs_Pats
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynPat list) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item)

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_NamePatPairs".</remarks>
  abstract member BeforeVisitConstructorArgs_NamePatPairs:
    context: 'TContext *
    item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_NamePatPairs".</remarks>
  default this.BeforeVisitConstructorArgs_NamePatPairs
     (context: 'TContext,
      item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitConstructorArgs_NamePatPairs(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in v0, this.VisitPat context v1)),
      range)

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  abstract member VisitConstructorArgs_NamePatPairs:
    context: 'TContext *
    item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  default __.VisitConstructorArgs_NamePatPairs
     (context: 'TContext,
      item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range)


  /// <summary>
  /// Visit and dispatch "SynConstructorArgs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConstructorArgs">SynConstructorArgs expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConstructorArgs
      (context: 'TContext)
      (synConstructorArgs: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ConstructorArgs synConstructorArgs)
    try
      match synConstructorArgs with
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
        this.BeforeVisitConstructorArgs_Pats(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
        this.BeforeVisitConstructorArgs_NamePatPairs(context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase_EnumCase".</remarks>
  abstract member BeforeVisitEnumCase_EnumCase:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    item3: Microsoft.FSharp.Compiler.Ast.SynConst *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase_EnumCase".</remarks>
  default this.BeforeVisitEnumCase_EnumCase
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      item3: Microsoft.FSharp.Compiler.Ast.SynConst,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitEnumCase_EnumCase(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      id,
      this.VisitConst context item3,
      xmlDoc,
      range)

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  abstract member VisitEnumCase_EnumCase:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    item3: Microsoft.FSharp.Compiler.Ast.SynConst *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynEnumCase

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  default __.VisitEnumCase_EnumCase
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      item3: Microsoft.FSharp.Compiler.Ast.SynConst,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range)


  /// <summary>
  /// Visit and dispatch "SynEnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synEnumCase">SynEnumCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitEnumCase
      (context: 'TContext)
      (synEnumCase: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.EnumCase synEnumCase)
    try
      match synEnumCase with
      | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
        this.BeforeVisitEnumCase_EnumCase(context, attributes, id, item3, xmlDoc, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefn_SynExceptionDefn".</remarks>
  abstract member BeforeVisitExceptionDefn_SynExceptionDefn:
    context: 'TContext *
    exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefn_SynExceptionDefn".</remarks>
  default this.BeforeVisitExceptionDefn_SynExceptionDefn
     (context: 'TContext,
      exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExceptionDefn_SynExceptionDefn(
      context,
      this.VisitExceptionDefnRepr context exnRepr,
      members |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberDefn context v),
      range)

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  abstract member VisitExceptionDefn_SynExceptionDefn:
    context: 'TContext *
    exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefn

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  default __.VisitExceptionDefn_SynExceptionDefn
     (context: 'TContext,
      exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefn">SynExceptionDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefn
      (context: 'TContext)
      (synExceptionDefn: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ExceptionDefn synExceptionDefn)
    try
      match synExceptionDefn with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
        this.BeforeVisitExceptionDefn_SynExceptionDefn(context, exnRepr, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefnRepr_SynExceptionDefnRepr".</remarks>
  abstract member BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    case: Microsoft.FSharp.Compiler.Ast.SynUnionCase *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list option *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefnRepr_SynExceptionDefnRepr".</remarks>
  default this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExceptionDefnRepr_SynExceptionDefnRepr(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      this.VisitUnionCase context case,
      longId,
      xmlDoc,
      accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  abstract member VisitExceptionDefnRepr_SynExceptionDefnRepr:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    case: Microsoft.FSharp.Compiler.Ast.SynUnionCase *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list option *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  default __.VisitExceptionDefnRepr_SynExceptionDefnRepr
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefnRepr">SynExceptionDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefnRepr
      (context: 'TContext)
      (synExceptionDefnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ExceptionDefnRepr synExceptionDefnRepr)
    try
      match synExceptionDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
        this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr(context, item1, case, longId, xmlDoc, accesibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionSig_SynExceptionSig".</remarks>
  abstract member BeforeVisitExceptionSig_SynExceptionSig:
    context: 'TContext *
    exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionSig_SynExceptionSig".</remarks>
  default this.BeforeVisitExceptionSig_SynExceptionSig
     (context: 'TContext,
      exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExceptionSig_SynExceptionSig(
      context,
      this.VisitExceptionDefnRepr context exnRepr,
      memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberSig context v),
      range)

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  abstract member VisitExceptionSig_SynExceptionSig:
    context: 'TContext *
    exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExceptionSig

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  default __.VisitExceptionSig_SynExceptionSig
     (context: 'TContext,
      exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionSig">SynExceptionSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionSig
      (context: 'TContext)
      (synExceptionSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ExceptionSig synExceptionSig)
    try
      match synExceptionSig with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
        this.BeforeVisitExceptionSig_SynExceptionSig(context, exnRepr, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Paren".</remarks>
  abstract member BeforeVisitExpr_Paren:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    leftParenRange: Microsoft.FSharp.Compiler.Range.range *
    rightParenRange: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Paren".</remarks>
  default this.BeforeVisitExpr_Paren
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      leftParenRange: Microsoft.FSharp.Compiler.Range.range,
      rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Paren(
      context,
      this.VisitExpr context expr,
      leftParenRange,
      rightParenRange,
      range)

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  abstract member VisitExpr_Paren:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    leftParenRange: Microsoft.FSharp.Compiler.Range.range *
    rightParenRange: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  default __.VisitExpr_Paren
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      leftParenRange: Microsoft.FSharp.Compiler.Range.range,
      rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Quote".</remarks>
  abstract member BeforeVisitExpr_Quote:
    context: 'TContext *
    operator: Microsoft.FSharp.Compiler.Ast.SynExpr *
    isRaw: bool *
    quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    isFromQueryExpression: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Quote".</remarks>
  default this.BeforeVisitExpr_Quote
     (context: 'TContext,
      operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
      isRaw: bool,
      quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      isFromQueryExpression: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Quote(
      context,
      this.VisitExpr context operator,
      isRaw,
      this.VisitExpr context quotedSynExpr,
      isFromQueryExpression,
      range)

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  abstract member VisitExpr_Quote:
    context: 'TContext *
    operator: Microsoft.FSharp.Compiler.Ast.SynExpr *
    isRaw: bool *
    quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    isFromQueryExpression: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  default __.VisitExpr_Quote
     (context: 'TContext,
      operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
      isRaw: bool,
      quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      isFromQueryExpression: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Const".</remarks>
  abstract member BeforeVisitExpr_Const:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Const".</remarks>
  default this.BeforeVisitExpr_Const
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Const(
      context,
      this.VisitConst context constant,
      range)

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  abstract member VisitExpr_Const:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  default __.VisitExpr_Const
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range)

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Typed".</remarks>
  abstract member BeforeVisitExpr_Typed:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Typed".</remarks>
  default this.BeforeVisitExpr_Typed
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Typed(
      context,
      this.VisitExpr context expr,
      this.VisitType context typeSig,
      range)

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  abstract member VisitExpr_Typed:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  default __.VisitExpr_Typed
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Tuple".</remarks>
  abstract member BeforeVisitExpr_Tuple:
    context: 'TContext *
    exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Tuple".</remarks>
  default this.BeforeVisitExpr_Tuple
     (context: 'TContext,
      exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Tuple(
      context,
      exprs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitExpr context v),
      commaRanges,
      range)

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  abstract member VisitExpr_Tuple:
    context: 'TContext *
    exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  default __.VisitExpr_Tuple
     (context: 'TContext,
      exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrList".</remarks>
  abstract member BeforeVisitExpr_ArrayOrList:
    context: 'TContext *
    isList: bool *
    exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrList".</remarks>
  default this.BeforeVisitExpr_ArrayOrList
     (context: 'TContext,
      isList: bool,
      exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ArrayOrList(
      context,
      isList,
      exprs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitExpr context v),
      range)

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  abstract member VisitExpr_ArrayOrList:
    context: 'TContext *
    isList: bool *
    exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  default __.VisitExpr_ArrayOrList
     (context: 'TContext,
      isList: bool,
      exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range)

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Record".</remarks>
  abstract member BeforeVisitExpr_Record:
    context: 'TContext *
    baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option *
    copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option *
    recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Record".</remarks>
  default this.BeforeVisitExpr_Record
     (context: 'TContext,
      baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
      copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
      recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Record(
      context,
      baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v = v in this.VisitType context v0, this.VisitExpr context v1, v2, v3, v4)),
      copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v = v in this.VisitExpr context v0, v1)),
      recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitExpr context v), v2)),
      range)

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  abstract member VisitExpr_Record:
    context: 'TContext *
    baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option *
    copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option *
    recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  default __.VisitExpr_Record
     (context: 'TContext,
      baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
      copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
      recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_New".</remarks>
  abstract member BeforeVisitExpr_New:
    context: 'TContext *
    isProtected: bool *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_New".</remarks>
  default this.BeforeVisitExpr_New
     (context: 'TContext,
      isProtected: bool,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_New(
      context,
      isProtected,
      this.VisitType context typeName,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  abstract member VisitExpr_New:
    context: 'TContext *
    isProtected: bool *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  default __.VisitExpr_New
     (context: 'TContext,
      isProtected: bool,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range)

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ObjExpr".</remarks>
  abstract member BeforeVisitExpr_ObjExpr:
    context: 'TContext *
    objType: Microsoft.FSharp.Compiler.Ast.SynType *
    argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list *
    newPos: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ObjExpr".</remarks>
  default this.BeforeVisitExpr_ObjExpr
     (context: 'TContext,
      objType: Microsoft.FSharp.Compiler.Ast.SynType,
      argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
      newPos: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ObjExpr(
      context,
      this.VisitType context objType,
      argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v = v in this.VisitExpr context v0, v1)),
      bindings |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitBinding context v),
      extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitInterfaceImpl context v),
      newPos,
      range)

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  abstract member VisitExpr_ObjExpr:
    context: 'TContext *
    objType: Microsoft.FSharp.Compiler.Ast.SynType *
    argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list *
    newPos: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  default __.VisitExpr_ObjExpr
     (context: 'TContext,
      objType: Microsoft.FSharp.Compiler.Ast.SynType,
      argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
      newPos: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_While".</remarks>
  abstract member BeforeVisitExpr_While:
    context: 'TContext *
    spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop *
    whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    doBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_While".</remarks>
  default this.BeforeVisitExpr_While
     (context: 'TContext,
      spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
      whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_While(
      context,
      spWhile,
      this.VisitExpr context whileBody,
      this.VisitExpr context doBody,
      range)

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  abstract member VisitExpr_While:
    context: 'TContext *
    spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop *
    whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    doBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  default __.VisitExpr_While
     (context: 'TContext,
      spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
      whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_For".</remarks>
  abstract member BeforeVisitExpr_For:
    context: 'TContext *
    spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    idBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item4: bool *
    toBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    doBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_For".</remarks>
  default this.BeforeVisitExpr_For
     (context: 'TContext,
      spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item4: bool,
      toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_For(
      context,
      spFor,
      id,
      this.VisitExpr context idBody,
      item4,
      this.VisitExpr context toBody,
      this.VisitExpr context doBody,
      range)

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  abstract member VisitExpr_For:
    context: 'TContext *
    spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    idBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item4: bool *
    toBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    doBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  default __.VisitExpr_For
     (context: 'TContext,
      spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item4: bool,
      toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ForEach".</remarks>
  abstract member BeforeVisitExpr_ForEach:
    context: 'TContext *
    spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop *
    seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly *
    isFromSource: bool *
    pattern: Microsoft.FSharp.Compiler.Ast.SynPat *
    enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ForEach".</remarks>
  default this.BeforeVisitExpr_ForEach
     (context: 'TContext,
      spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
      seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
      isFromSource: bool,
      pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
      enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ForEach(
      context,
      spFor,
      seqExprOnly,
      isFromSource,
      this.VisitPat context pattern,
      this.VisitExpr context enumExpr,
      this.VisitExpr context bodyExpr,
      range)

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  abstract member VisitExpr_ForEach:
    context: 'TContext *
    spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop *
    seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly *
    isFromSource: bool *
    pattern: Microsoft.FSharp.Compiler.Ast.SynPat *
    enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  default __.VisitExpr_ForEach
     (context: 'TContext,
      spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
      seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
      isFromSource: bool,
      pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
      enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitExpr_ArrayOrListOfSeqExpr:
    context: 'TContext *
    isList: bool *
    elements: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitExpr_ArrayOrListOfSeqExpr
     (context: 'TContext,
      isList: bool,
      elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ArrayOrListOfSeqExpr(
      context,
      isList,
      this.VisitExpr context elements,
      range)

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  abstract member VisitExpr_ArrayOrListOfSeqExpr:
    context: 'TContext *
    isList: bool *
    elements: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  default __.VisitExpr_ArrayOrListOfSeqExpr
     (context: 'TContext,
      isList: bool,
      elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_CompExpr".</remarks>
  abstract member BeforeVisitExpr_CompExpr:
    context: 'TContext *
    isArrayOrList: bool *
    isNotNakedRefCell: bool ref *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_CompExpr".</remarks>
  default this.BeforeVisitExpr_CompExpr
     (context: 'TContext,
      isArrayOrList: bool,
      isNotNakedRefCell: bool ref,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_CompExpr(
      context,
      isArrayOrList,
      isNotNakedRefCell,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  abstract member VisitExpr_CompExpr:
    context: 'TContext *
    isArrayOrList: bool *
    isNotNakedRefCell: bool ref *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  default __.VisitExpr_CompExpr
     (context: 'TContext,
      isArrayOrList: bool,
      isNotNakedRefCell: bool ref,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lambda".</remarks>
  abstract member BeforeVisitExpr_Lambda:
    context: 'TContext *
    fromMethod: bool *
    inLambdaSeq: bool *
    args: Microsoft.FSharp.Compiler.Ast.SynSimplePats *
    body: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lambda".</remarks>
  default this.BeforeVisitExpr_Lambda
     (context: 'TContext,
      fromMethod: bool,
      inLambdaSeq: bool,
      args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
      body: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Lambda(
      context,
      fromMethod,
      inLambdaSeq,
      this.VisitSimplePats context args,
      this.VisitExpr context body,
      range)

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  abstract member VisitExpr_Lambda:
    context: 'TContext *
    fromMethod: bool *
    inLambdaSeq: bool *
    args: Microsoft.FSharp.Compiler.Ast.SynSimplePats *
    body: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  default __.VisitExpr_Lambda
     (context: 'TContext,
      fromMethod: bool,
      inLambdaSeq: bool,
      args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
      body: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_MatchLambda".</remarks>
  abstract member BeforeVisitExpr_MatchLambda:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Range.range *
    clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_MatchLambda".</remarks>
  default this.BeforeVisitExpr_MatchLambda
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Range.range,
      clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_MatchLambda(
      context,
      item1,
      item2,
      clauses |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMatchClause context v),
      spBind,
      range)

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  abstract member VisitExpr_MatchLambda:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Range.range *
    clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  default __.VisitExpr_MatchLambda
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Range.range,
      clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range)

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Match".</remarks>
  abstract member BeforeVisitExpr_Match:
    context: 'TContext *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    isCexprExceptionMatch: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Match".</remarks>
  default this.BeforeVisitExpr_Match
     (context: 'TContext,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      isCexprExceptionMatch: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Match(
      context,
      spBind,
      this.VisitExpr context matchExpr,
      clauses |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMatchClause context v),
      isCexprExceptionMatch,
      range)

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  abstract member VisitExpr_Match:
    context: 'TContext *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    isCexprExceptionMatch: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  default __.VisitExpr_Match
     (context: 'TContext,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      isCexprExceptionMatch: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Do".</remarks>
  abstract member BeforeVisitExpr_Do:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Do".</remarks>
  default this.BeforeVisitExpr_Do
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Do(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  abstract member VisitExpr_Do:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  default __.VisitExpr_Do
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Assert".</remarks>
  abstract member BeforeVisitExpr_Assert:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Assert".</remarks>
  default this.BeforeVisitExpr_Assert
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Assert(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  abstract member VisitExpr_Assert:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  default __.VisitExpr_Assert
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range)

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_App".</remarks>
  abstract member BeforeVisitExpr_App:
    context: 'TContext *
    exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag *
    isInfix: bool *
    funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_App".</remarks>
  default this.BeforeVisitExpr_App
     (context: 'TContext,
      exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
      isInfix: bool,
      funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_App(
      context,
      exprAtomicFlag,
      isInfix,
      this.VisitExpr context funcExpr,
      this.VisitExpr context argExpr,
      range)

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  abstract member VisitExpr_App:
    context: 'TContext *
    exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag *
    isInfix: bool *
    funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  default __.VisitExpr_App
     (context: 'TContext,
      exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
      isInfix: bool,
      funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeApp".</remarks>
  abstract member BeforeVisitExpr_TypeApp:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range *
    typeNames: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    typeArgs: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeApp".</remarks>
  default this.BeforeVisitExpr_TypeApp
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
      typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      typeArgs: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_TypeApp(
      context,
      this.VisitExpr context expr,
      leftAngleRange,
      typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      commaRanges,
      rightAngleRange,
      typeArgs,
      range)

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  abstract member VisitExpr_TypeApp:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range *
    typeNames: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    typeArgs: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  default __.VisitExpr_TypeApp
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
      typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      typeArgs: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUse".</remarks>
  abstract member BeforeVisitExpr_LetOrUse:
    context: 'TContext *
    isRecursive: bool *
    isUse: bool *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUse".</remarks>
  default this.BeforeVisitExpr_LetOrUse
     (context: 'TContext,
      isRecursive: bool,
      isUse: bool,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LetOrUse(
      context,
      isRecursive,
      isUse,
      bindings |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitBinding context v),
      this.VisitExpr context exprBody,
      range)

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  abstract member VisitExpr_LetOrUse:
    context: 'TContext *
    isRecursive: bool *
    isUse: bool *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  default __.VisitExpr_LetOrUse
     (context: 'TContext,
      isRecursive: bool,
      isUse: bool,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryWith".</remarks>
  abstract member BeforeVisitExpr_TryWith:
    context: 'TContext *
    tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Range.range *
    item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    item4: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry *
    spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryWith".</remarks>
  default this.BeforeVisitExpr_TryWith
     (context: 'TContext,
      tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Range.range,
      item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      item4: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
      spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) =
    this.VisitExpr_TryWith(
      context,
      this.VisitExpr context tryExpr,
      item2,
      item3 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMatchClause context v),
      item4,
      range,
      spTry,
      spWith)

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  abstract member VisitExpr_TryWith:
    context: 'TContext *
    tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Range.range *
    item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list *
    item4: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry *
    spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  default __.VisitExpr_TryWith
     (context: 'TContext,
      tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Range.range,
      item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
      item4: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
      spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryFinally".</remarks>
  abstract member BeforeVisitExpr_TryFinally:
    context: 'TContext *
    tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry *
    spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryFinally".</remarks>
  default this.BeforeVisitExpr_TryFinally
     (context: 'TContext,
      tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
      spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) =
    this.VisitExpr_TryFinally(
      context,
      this.VisitExpr context tryExpr,
      this.VisitExpr context finallyExpr,
      range,
      spTry,
      spFinally)

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  abstract member VisitExpr_TryFinally:
    context: 'TContext *
    tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry *
    spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  default __.VisitExpr_TryFinally
     (context: 'TContext,
      tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
      spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lazy".</remarks>
  abstract member BeforeVisitExpr_Lazy:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lazy".</remarks>
  default this.BeforeVisitExpr_Lazy
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Lazy(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  abstract member VisitExpr_Lazy:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  default __.VisitExpr_Lazy
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Sequential".</remarks>
  abstract member BeforeVisitExpr_Sequential:
    context: 'TContext *
    spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq *
    isTrueSeq: bool *
    expr1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    expr2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Sequential".</remarks>
  default this.BeforeVisitExpr_Sequential
     (context: 'TContext,
      spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
      isTrueSeq: bool,
      expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Sequential(
      context,
      spSeq,
      isTrueSeq,
      this.VisitExpr context expr1,
      this.VisitExpr context expr2,
      range)

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  abstract member VisitExpr_Sequential:
    context: 'TContext *
    spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq *
    isTrueSeq: bool *
    expr1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    expr2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  default __.VisitExpr_Sequential
     (context: 'TContext,
      spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
      isTrueSeq: bool,
      expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_IfThenElse".</remarks>
  abstract member BeforeVisitExpr_IfThenElse:
    context: 'TContext *
    exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr *
    exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr *
    optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    isFromErrorRecovery: bool *
    ifToThen: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_IfThenElse".</remarks>
  default this.BeforeVisitExpr_IfThenElse
     (context: 'TContext,
      exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
      exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
      optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      isFromErrorRecovery: bool,
      ifToThen: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_IfThenElse(
      context,
      this.VisitExpr context exprGuard,
      this.VisitExpr context exprThen,
      optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitExpr context v),
      spIfToThen,
      isFromErrorRecovery,
      ifToThen,
      range)

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  abstract member VisitExpr_IfThenElse:
    context: 'TContext *
    exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr *
    exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr *
    optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    isFromErrorRecovery: bool *
    ifToThen: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  default __.VisitExpr_IfThenElse
     (context: 'TContext,
      exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
      exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
      optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      isFromErrorRecovery: bool,
      ifToThen: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Ident".</remarks>
  abstract member BeforeVisitExpr_Ident:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Ident".</remarks>
  default this.BeforeVisitExpr_Ident
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    this.VisitExpr_Ident(
      context,
      item)

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  abstract member VisitExpr_Ident:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  default __.VisitExpr_Ident
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdent".</remarks>
  abstract member BeforeVisitExpr_LongIdent:
    context: 'TContext *
    isOptional: bool *
    longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdent".</remarks>
  default this.BeforeVisitExpr_LongIdent
     (context: 'TContext,
      isOptional: bool,
      longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LongIdent(
      context,
      isOptional,
      longIdent,
      altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> AstRecordCons.initFSharpRef`1 (this.VisitSimplePatAlternativeIdInfo context v.contents)),
      range)

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  abstract member VisitExpr_LongIdent:
    context: 'TContext *
    isOptional: bool *
    longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  default __.VisitExpr_LongIdent
     (context: 'TContext,
      isOptional: bool,
      longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdentSet".</remarks>
  abstract member BeforeVisitExpr_LongIdentSet:
    context: 'TContext *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdentSet".</remarks>
  default this.BeforeVisitExpr_LongIdentSet
     (context: 'TContext,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LongIdentSet(
      context,
      dotId,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  abstract member VisitExpr_LongIdentSet:
    context: 'TContext *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  default __.VisitExpr_LongIdentSet
     (context: 'TContext,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range)

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotGet".</remarks>
  abstract member BeforeVisitExpr_DotGet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    rangeOfDot: Microsoft.FSharp.Compiler.Range.range *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotGet".</remarks>
  default this.BeforeVisitExpr_DotGet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DotGet(
      context,
      this.VisitExpr context expr,
      rangeOfDot,
      dotId,
      range)

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  abstract member VisitExpr_DotGet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    rangeOfDot: Microsoft.FSharp.Compiler.Range.range *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  default __.VisitExpr_DotGet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotSet".</remarks>
  abstract member BeforeVisitExpr_DotSet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotSet".</remarks>
  default this.BeforeVisitExpr_DotSet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DotSet(
      context,
      this.VisitExpr context expr,
      dotId,
      this.VisitExpr context exprValue,
      range)

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  abstract member VisitExpr_DotSet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  default __.VisitExpr_DotSet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedGet".</remarks>
  abstract member BeforeVisitExpr_DotIndexedGet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list *
    item3: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedGet".</remarks>
  default this.BeforeVisitExpr_DotIndexedGet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
      item3: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DotIndexedGet(
      context,
      this.VisitExpr context expr,
      indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitIndexerArg context v),
      item3,
      range)

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  abstract member VisitExpr_DotIndexedGet:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list *
    item3: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  default __.VisitExpr_DotIndexedGet
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
      item3: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedSet".</remarks>
  abstract member BeforeVisitExpr_DotIndexedSet:
    context: 'TContext *
    objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list *
    valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range *
    rangeOfDot: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedSet".</remarks>
  default this.BeforeVisitExpr_DotIndexedSet
     (context: 'TContext,
      objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
      valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
      rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DotIndexedSet(
      context,
      this.VisitExpr context objectExpr,
      indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitIndexerArg context v),
      this.VisitExpr context valueExpr,
      rangeOfLeftOfSet,
      rangeOfDot,
      range)

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  abstract member VisitExpr_DotIndexedSet:
    context: 'TContext *
    objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list *
    valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range *
    rangeOfDot: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  default __.VisitExpr_DotIndexedSet
     (context: 'TContext,
      objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
      valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
      rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_NamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitExpr_NamedIndexedPropertySet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_NamedIndexedPropertySet".</remarks>
  default this.BeforeVisitExpr_NamedIndexedPropertySet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_NamedIndexedPropertySet(
      context,
      item1,
      this.VisitExpr context item2,
      this.VisitExpr context item3,
      range)

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  abstract member VisitExpr_NamedIndexedPropertySet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  default __.VisitExpr_NamedIndexedPropertySet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitExpr_DotNamedIndexedPropertySet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item4: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitExpr_DotNamedIndexedPropertySet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DotNamedIndexedPropertySet(
      context,
      this.VisitExpr context item1,
      item2,
      this.VisitExpr context item3,
      this.VisitExpr context item4,
      range)

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  abstract member VisitExpr_DotNamedIndexedPropertySet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item4: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  default __.VisitExpr_DotNamedIndexedPropertySet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeTest".</remarks>
  abstract member BeforeVisitExpr_TypeTest:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeTest".</remarks>
  default this.BeforeVisitExpr_TypeTest
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_TypeTest(
      context,
      this.VisitExpr context expr,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  abstract member VisitExpr_TypeTest:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  default __.VisitExpr_TypeTest
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Upcast".</remarks>
  abstract member BeforeVisitExpr_Upcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Upcast".</remarks>
  default this.BeforeVisitExpr_Upcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Upcast(
      context,
      this.VisitExpr context expr,
      this.VisitType context typeSig,
      range)

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  abstract member VisitExpr_Upcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  default __.VisitExpr_Upcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Downcast".</remarks>
  abstract member BeforeVisitExpr_Downcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Downcast".</remarks>
  default this.BeforeVisitExpr_Downcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Downcast(
      context,
      this.VisitExpr context expr,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  abstract member VisitExpr_Downcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  default __.VisitExpr_Downcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredUpcast".</remarks>
  abstract member BeforeVisitExpr_InferredUpcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredUpcast".</remarks>
  default this.BeforeVisitExpr_InferredUpcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_InferredUpcast(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  abstract member VisitExpr_InferredUpcast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  default __.VisitExpr_InferredUpcast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range)

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredDowncast".</remarks>
  abstract member BeforeVisitExpr_InferredDowncast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredDowncast".</remarks>
  default this.BeforeVisitExpr_InferredDowncast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_InferredDowncast(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  abstract member VisitExpr_InferredDowncast:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  default __.VisitExpr_InferredDowncast
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Null".</remarks>
  abstract member BeforeVisitExpr_Null:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Null".</remarks>
  default this.BeforeVisitExpr_Null
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Null(
      context,
      range)

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  abstract member VisitExpr_Null:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  default __.VisitExpr_Null
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_AddressOf".</remarks>
  abstract member BeforeVisitExpr_AddressOf:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_AddressOf".</remarks>
  default this.BeforeVisitExpr_AddressOf
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_AddressOf(
      context,
      item1,
      this.VisitExpr context item2,
      item3,
      range)

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  abstract member VisitExpr_AddressOf:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Range.range *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  default __.VisitExpr_AddressOf
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Range.range,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TraitCall".</remarks>
  abstract member BeforeVisitExpr_TraitCall:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar list *
    item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TraitCall".</remarks>
  default this.BeforeVisitExpr_TraitCall
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
      item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_TraitCall(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypar context v),
      this.VisitMemberSig context item2,
      this.VisitExpr context item3,
      range)

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  abstract member VisitExpr_TraitCall:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar list *
    item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  default __.VisitExpr_TraitCall
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
      item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_JoinIn".</remarks>
  abstract member BeforeVisitExpr_JoinIn:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    inPos: Microsoft.FSharp.Compiler.Range.range *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_JoinIn".</remarks>
  default this.BeforeVisitExpr_JoinIn
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      inPos: Microsoft.FSharp.Compiler.Range.range,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_JoinIn(
      context,
      this.VisitExpr context item1,
      inPos,
      this.VisitExpr context item3,
      range)

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  abstract member VisitExpr_JoinIn:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    inPos: Microsoft.FSharp.Compiler.Range.range *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  default __.VisitExpr_JoinIn
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      inPos: Microsoft.FSharp.Compiler.Range.range,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range)

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ImplicitZero".</remarks>
  abstract member BeforeVisitExpr_ImplicitZero:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ImplicitZero".</remarks>
  default this.BeforeVisitExpr_ImplicitZero
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ImplicitZero(
      context,
      range)

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  abstract member VisitExpr_ImplicitZero:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  default __.VisitExpr_ImplicitZero
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturn".</remarks>
  abstract member BeforeVisitExpr_YieldOrReturn:
    context: 'TContext *
    item1: (bool * bool) *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturn".</remarks>
  default this.BeforeVisitExpr_YieldOrReturn
     (context: 'TContext,
      item1: (bool * bool),
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_YieldOrReturn(
      context,
      item1,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  abstract member VisitExpr_YieldOrReturn:
    context: 'TContext *
    item1: (bool * bool) *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  default __.VisitExpr_YieldOrReturn
     (context: 'TContext,
      item1: (bool * bool),
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturnFrom".</remarks>
  abstract member BeforeVisitExpr_YieldOrReturnFrom:
    context: 'TContext *
    item1: (bool * bool) *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturnFrom".</remarks>
  default this.BeforeVisitExpr_YieldOrReturnFrom
     (context: 'TContext,
      item1: (bool * bool),
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_YieldOrReturnFrom(
      context,
      item1,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  abstract member VisitExpr_YieldOrReturnFrom:
    context: 'TContext *
    item1: (bool * bool) *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  default __.VisitExpr_YieldOrReturnFrom
     (context: 'TContext,
      item1: (bool * bool),
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUseBang".</remarks>
  abstract member BeforeVisitExpr_LetOrUseBang:
    context: 'TContext *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    isUse: bool *
    isFromSource: bool *
    pattern: Microsoft.FSharp.Compiler.Ast.SynPat *
    rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUseBang".</remarks>
  default this.BeforeVisitExpr_LetOrUseBang
     (context: 'TContext,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      isUse: bool,
      isFromSource: bool,
      pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
      rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LetOrUseBang(
      context,
      spBind,
      isUse,
      isFromSource,
      this.VisitPat context pattern,
      this.VisitExpr context rhsExpr,
      this.VisitExpr context bodyExpr,
      range)

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  abstract member VisitExpr_LetOrUseBang:
    context: 'TContext *
    spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    isUse: bool *
    isFromSource: bool *
    pattern: Microsoft.FSharp.Compiler.Ast.SynPat *
    rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  default __.VisitExpr_LetOrUseBang
     (context: 'TContext,
      spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      isUse: bool,
      isFromSource: bool,
      pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
      rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DoBang".</remarks>
  abstract member BeforeVisitExpr_DoBang:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DoBang".</remarks>
  default this.BeforeVisitExpr_DoBang
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DoBang(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  abstract member VisitExpr_DoBang:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  default __.VisitExpr_DoBang
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyILAssembly:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] *
    item2: Microsoft.FSharp.Compiler.Ast.SynType list *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    item4: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyILAssembly
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
      item2: Microsoft.FSharp.Compiler.Ast.SynType list,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      item4: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LibraryOnlyILAssembly(
      context,
      item1,
      item2 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      item3 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitExpr context v),
      item4 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      range)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitExpr_LibraryOnlyILAssembly:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] *
    item2: Microsoft.FSharp.Compiler.Ast.SynType list *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr list *
    item4: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  default __.VisitExpr_LibraryOnlyILAssembly
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
      item2: Microsoft.FSharp.Compiler.Ast.SynType list,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
      item4: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyStaticOptimization:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyStaticOptimization
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LibraryOnlyStaticOptimization(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitStaticOptimizationConstraint context v),
      this.VisitExpr context item2,
      this.VisitExpr context item3,
      range)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  abstract member VisitExpr_LibraryOnlyStaticOptimization:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  default __.VisitExpr_LibraryOnlyStaticOptimization
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: int *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: int,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LibraryOnlyUnionCaseFieldGet(
      context,
      this.VisitExpr context item1,
      longId,
      item3,
      range)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitExpr_LibraryOnlyUnionCaseFieldGet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: int *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitExpr_LibraryOnlyUnionCaseFieldGet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: int,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: int *
    item4: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: int,
      item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_LibraryOnlyUnionCaseFieldSet(
      context,
      this.VisitExpr context item1,
      longId,
      item3,
      this.VisitExpr context item4,
      range)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitExpr_LibraryOnlyUnionCaseFieldSet:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: int *
    item4: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitExpr_LibraryOnlyUnionCaseFieldSet
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: int,
      item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArbitraryAfterError".</remarks>
  abstract member BeforeVisitExpr_ArbitraryAfterError:
    context: 'TContext *
    debugStr: string *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArbitraryAfterError".</remarks>
  default this.BeforeVisitExpr_ArbitraryAfterError
     (context: 'TContext,
      debugStr: string,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_ArbitraryAfterError(
      context,
      debugStr,
      range)

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  abstract member VisitExpr_ArbitraryAfterError:
    context: 'TContext *
    debugStr: string *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  default __.VisitExpr_ArbitraryAfterError
     (context: 'TContext,
      debugStr: string,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_FromParseError".</remarks>
  abstract member BeforeVisitExpr_FromParseError:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_FromParseError".</remarks>
  default this.BeforeVisitExpr_FromParseError
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_FromParseError(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  abstract member VisitExpr_FromParseError:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  default __.VisitExpr_FromParseError
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range)

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_DiscardAfterMissingQualificationAfterDot(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitExpr_DiscardAfterMissingQualificationAfterDot:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitExpr_DiscardAfterMissingQualificationAfterDot
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Fixed".</remarks>
  abstract member BeforeVisitExpr_Fixed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Fixed".</remarks>
  default this.BeforeVisitExpr_Fixed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitExpr_Fixed(
      context,
      this.VisitExpr context item1,
      item2)

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  abstract member VisitExpr_Fixed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  default __.VisitExpr_Fixed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExpr">SynExpr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExpr
      (context: 'TContext)
      (synExpr: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Expr synExpr)
    try
      match synExpr with
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
        this.BeforeVisitExpr_Paren(context, expr, leftParenRange, rightParenRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        this.BeforeVisitExpr_Quote(context, operator, isRaw, quotedSynExpr, isFromQueryExpression, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
        this.BeforeVisitExpr_Const(context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
        this.BeforeVisitExpr_Typed(context, expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
        this.BeforeVisitExpr_Tuple(context, exprs, commaRanges, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
        this.BeforeVisitExpr_ArrayOrList(context, isList, exprs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        this.BeforeVisitExpr_Record(context, baseInfo, copyInfo, recordFields, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
        this.BeforeVisitExpr_New(context, isProtected, typeName, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        this.BeforeVisitExpr_ObjExpr(context, objType, argOpt, bindings, extraImpls, newPos, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
        this.BeforeVisitExpr_While(context, spWhile, whileBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        this.BeforeVisitExpr_For(context, spFor, id, idBody, item4, toBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_ForEach(context, spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        this.BeforeVisitExpr_ArrayOrListOfSeqExpr(context, isList, elements, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        this.BeforeVisitExpr_CompExpr(context, isArrayOrList, isNotNakedRefCell, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        this.BeforeVisitExpr_Lambda(context, fromMethod, inLambdaSeq, args, body, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        this.BeforeVisitExpr_MatchLambda(context, item1, item2, clauses, spBind, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        this.BeforeVisitExpr_Match(context, spBind, matchExpr, clauses, isCexprExceptionMatch, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
        this.BeforeVisitExpr_Do(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
        this.BeforeVisitExpr_Assert(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        this.BeforeVisitExpr_App(context, exprAtomicFlag, isInfix, funcExpr, argExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        this.BeforeVisitExpr_TypeApp(context, expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        this.BeforeVisitExpr_LetOrUse(context, isRecursive, isUse, bindings, exprBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        this.BeforeVisitExpr_TryWith(context, tryExpr, item2, item3, item4, range, spTry, spWith)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        this.BeforeVisitExpr_TryFinally(context, tryExpr, finallyExpr, range, spTry, spFinally)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
        this.BeforeVisitExpr_Lazy(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        this.BeforeVisitExpr_Sequential(context, spSeq, isTrueSeq, expr1, expr2, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        this.BeforeVisitExpr_IfThenElse(context, exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
        this.BeforeVisitExpr_Ident(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        this.BeforeVisitExpr_LongIdent(context, isOptional, longIdent, altNameRefCell, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
        this.BeforeVisitExpr_LongIdentSet(context, dotId, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        this.BeforeVisitExpr_DotGet(context, expr, rangeOfDot, dotId, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
        this.BeforeVisitExpr_DotSet(context, expr, dotId, exprValue, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        this.BeforeVisitExpr_DotIndexedGet(context, expr, indexExprs, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        this.BeforeVisitExpr_DotIndexedSet(context, objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        this.BeforeVisitExpr_NamedIndexedPropertySet(context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_DotNamedIndexedPropertySet(context, item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
        this.BeforeVisitExpr_TypeTest(context, expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
        this.BeforeVisitExpr_Upcast(context, expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
        this.BeforeVisitExpr_Downcast(context, expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
        this.BeforeVisitExpr_InferredUpcast(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
        this.BeforeVisitExpr_InferredDowncast(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
        this.BeforeVisitExpr_Null(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
        this.BeforeVisitExpr_AddressOf(context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
        this.BeforeVisitExpr_TraitCall(context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
        this.BeforeVisitExpr_JoinIn(context, item1, inPos, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
        this.BeforeVisitExpr_ImplicitZero(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturn(context, item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturnFrom(context, item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_LetOrUseBang(context, spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
        this.BeforeVisitExpr_DoBang(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyILAssembly(context, item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyStaticOptimization(context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet(context, item1, longId, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet(context, item1, longId, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
        this.BeforeVisitExpr_ArbitraryAfterError(context, debugStr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
        this.BeforeVisitExpr_FromParseError(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
        this.BeforeVisitExpr_Fixed(context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField_Field".</remarks>
  abstract member BeforeVisitField_Field:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    isStatic: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident option *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item5: bool *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField_Field".</remarks>
  default this.BeforeVisitField_Field
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      isStatic: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident option,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item5: bool,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitField_Field(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      isStatic,
      id,
      this.VisitType context typeName,
      item5,
      xmlDoc,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  abstract member VisitField_Field:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    isStatic: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident option *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item5: bool *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynField

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  default __.VisitField_Field
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      isStatic: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident option,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item5: bool,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synField">SynField expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitField
      (context: 'TContext)
      (synField: Microsoft.FSharp.Compiler.Ast.SynField) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Field synField)
    try
      match synField with
      | Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
        this.BeforeVisitField_Field(context, attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_Two".</remarks>
  abstract member BeforeVisitIndexerArg_Two:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_Two".</remarks>
  default this.BeforeVisitIndexerArg_Two
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    this.VisitIndexerArg_Two(
      context,
      this.VisitExpr context item1,
      this.VisitExpr context item2)

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  abstract member VisitIndexerArg_Two:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  default __.VisitIndexerArg_Two
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2)

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_One".</remarks>
  abstract member BeforeVisitIndexerArg_One:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_One".</remarks>
  default this.BeforeVisitIndexerArg_One
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    this.VisitIndexerArg_One(
      context,
      this.VisitExpr context item)

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  abstract member VisitIndexerArg_One:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  default __.VisitIndexerArg_One
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item)


  /// <summary>
  /// Visit and dispatch "SynIndexerArg" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synIndexerArg">SynIndexerArg expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitIndexerArg
      (context: 'TContext)
      (synIndexerArg: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.IndexerArg synIndexerArg)
    try
      match synIndexerArg with
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
        this.BeforeVisitIndexerArg_Two(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
        this.BeforeVisitIndexerArg_One(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl_InterfaceImpl".</remarks>
  abstract member BeforeVisitInterfaceImpl_InterfaceImpl:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl_InterfaceImpl".</remarks>
  default this.BeforeVisitInterfaceImpl_InterfaceImpl
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitInterfaceImpl_InterfaceImpl(
      context,
      this.VisitType context item1,
      bindings |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitBinding context v),
      range)

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  abstract member VisitInterfaceImpl_InterfaceImpl:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  default __.VisitInterfaceImpl_InterfaceImpl
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range)


  /// <summary>
  /// Visit and dispatch "SynInterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synInterfaceImpl">SynInterfaceImpl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitInterfaceImpl
      (context: 'TContext)
      (synInterfaceImpl: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.InterfaceImpl synInterfaceImpl)
    try
      match synInterfaceImpl with
      | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
        this.BeforeVisitInterfaceImpl_InterfaceImpl(context, item1, bindings, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchClause_Clause".</remarks>
  abstract member BeforeVisitMatchClause_Clause:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget -> Microsoft.FSharp.Compiler.Ast.SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchClause_Clause".</remarks>
  default this.BeforeVisitMatchClause_Clause
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) =
    this.VisitMatchClause_Clause(
      context,
      this.VisitPat context item1,
      item2 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitExpr context v),
      this.VisitExpr context item3,
      range,
      spTarget)

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  abstract member VisitMatchClause_Clause:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    item3: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range *
    spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget -> Microsoft.FSharp.Compiler.Ast.SynMatchClause

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  default __.VisitMatchClause_Clause
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range,
      spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget)


  /// <summary>
  /// Visit and dispatch "SynMatchClause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMatchClause">SynMatchClause expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMatchClause
      (context: 'TContext)
      (synMatchClause: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.MatchClause synMatchClause)
    try
      match synMatchClause with
      | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
        this.BeforeVisitMatchClause_Clause(context, item1, item2, item3, range, spTarget)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Named".</remarks>
  abstract member BeforeVisitMeasure_Named:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Named".</remarks>
  default this.BeforeVisitMeasure_Named
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Named(
      context,
      longId,
      range)

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  abstract member VisitMeasure_Named:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  default __.VisitMeasure_Named
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range)

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Product".</remarks>
  abstract member BeforeVisitMeasure_Product:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Product".</remarks>
  default this.BeforeVisitMeasure_Product
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Product(
      context,
      this.VisitMeasure context item1,
      this.VisitMeasure context item2,
      range)

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  abstract member VisitMeasure_Product:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  default __.VisitMeasure_Product
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Seq".</remarks>
  abstract member BeforeVisitMeasure_Seq:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Seq".</remarks>
  default this.BeforeVisitMeasure_Seq
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Seq(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMeasure context v),
      range)

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  abstract member VisitMeasure_Seq:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  default __.VisitMeasure_Seq
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range)

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Divide".</remarks>
  abstract member BeforeVisitMeasure_Divide:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Divide".</remarks>
  default this.BeforeVisitMeasure_Divide
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Divide(
      context,
      this.VisitMeasure context item1,
      this.VisitMeasure context item2,
      range)

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  abstract member VisitMeasure_Divide:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  default __.VisitMeasure_Divide
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Power".</remarks>
  abstract member BeforeVisitMeasure_Power:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Power".</remarks>
  default this.BeforeVisitMeasure_Power
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Power(
      context,
      this.VisitMeasure context item1,
      this.VisitRationalConst context item2,
      range)

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  abstract member VisitMeasure_Power:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynMeasure *
    item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  default __.VisitMeasure_Power
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_One".</remarks>
  abstract member BeforeVisitMeasure_One:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_One".</remarks>
  default this.BeforeVisitMeasure_One
     (context: 'TContext) =
    this.VisitMeasure_One(
      context)

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  abstract member VisitMeasure_One:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  default __.VisitMeasure_One
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.One

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Anon".</remarks>
  abstract member BeforeVisitMeasure_Anon:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Anon".</remarks>
  default this.BeforeVisitMeasure_Anon
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Anon(
      context,
      item)

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  abstract member VisitMeasure_Anon:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  default __.VisitMeasure_Anon
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item)

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Var".</remarks>
  abstract member BeforeVisitMeasure_Var:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Var".</remarks>
  default this.BeforeVisitMeasure_Var
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMeasure_Var(
      context,
      this.VisitTypar context item1,
      range)

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  abstract member VisitMeasure_Var:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  default __.VisitMeasure_Var
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range)


  /// <summary>
  /// Visit and dispatch "SynMeasure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMeasure">SynMeasure expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMeasure
      (context: 'TContext)
      (synMeasure: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Measure synMeasure)
    try
      match synMeasure with
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range) ->
        this.BeforeVisitMeasure_Named(context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
        this.BeforeVisitMeasure_Product(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
        this.BeforeVisitMeasure_Seq(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
        this.BeforeVisitMeasure_Divide(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
        this.BeforeVisitMeasure_Power(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.One ->
        this.BeforeVisitMeasure_One(context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item) ->
        this.BeforeVisitMeasure_Anon(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
        this.BeforeVisitMeasure_Var(context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Open".</remarks>
  abstract member BeforeVisitMemberDefn_Open:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Open".</remarks>
  default this.BeforeVisitMemberDefn_Open
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_Open(
      context,
      longId,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  abstract member VisitMemberDefn_Open:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  default __.VisitMemberDefn_Open
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Member".</remarks>
  abstract member BeforeVisitMemberDefn_Member:
    context: 'TContext *
    memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Member".</remarks>
  default this.BeforeVisitMemberDefn_Member
     (context: 'TContext,
      memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_Member(
      context,
      this.VisitBinding context memberDefn,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  abstract member VisitMemberDefn_Member:
    context: 'TContext *
    memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  default __.VisitMemberDefn_Member
     (context: 'TContext,
      memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitCtor".</remarks>
  abstract member BeforeVisitMemberDefn_ImplicitCtor:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list *
    selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitCtor".</remarks>
  default this.BeforeVisitMemberDefn_ImplicitCtor
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
      selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_ImplicitCtor(
      context,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitSimplePat context v),
      selfIdentifier,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  abstract member VisitMemberDefn_ImplicitCtor:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list *
    selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  default __.VisitMemberDefn_ImplicitCtor
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
      selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitInherit".</remarks>
  abstract member BeforeVisitMemberDefn_ImplicitInherit:
    context: 'TContext *
    inheritType: Microsoft.FSharp.Compiler.Ast.SynType *
    inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr *
    inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitInherit".</remarks>
  default this.BeforeVisitMemberDefn_ImplicitInherit
     (context: 'TContext,
      inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
      inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
      inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_ImplicitInherit(
      context,
      this.VisitType context inheritType,
      this.VisitExpr context inheritArgs,
      inheritAlias,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  abstract member VisitMemberDefn_ImplicitInherit:
    context: 'TContext *
    inheritType: Microsoft.FSharp.Compiler.Ast.SynType *
    inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr *
    inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  default __.VisitMemberDefn_ImplicitInherit
     (context: 'TContext,
      inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
      inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
      inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range)

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_LetBindings".</remarks>
  abstract member BeforeVisitMemberDefn_LetBindings:
    context: 'TContext *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    isStatic: bool *
    isRecursive: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_LetBindings".</remarks>
  default this.BeforeVisitMemberDefn_LetBindings
     (context: 'TContext,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      isStatic: bool,
      isRecursive: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_LetBindings(
      context,
      bindings |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitBinding context v),
      isStatic,
      isRecursive,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  abstract member VisitMemberDefn_LetBindings:
    context: 'TContext *
    bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    isStatic: bool *
    isRecursive: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  default __.VisitMemberDefn_LetBindings
     (context: 'TContext,
      bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      isStatic: bool,
      isRecursive: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AbstractSlot".</remarks>
  abstract member BeforeVisitMemberDefn_AbstractSlot:
    context: 'TContext *
    valSig: Microsoft.FSharp.Compiler.Ast.SynValSig *
    memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AbstractSlot".</remarks>
  default this.BeforeVisitMemberDefn_AbstractSlot
     (context: 'TContext,
      valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
      memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_AbstractSlot(
      context,
      this.VisitValSig context valSig,
      memberFlags,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  abstract member VisitMemberDefn_AbstractSlot:
    context: 'TContext *
    valSig: Microsoft.FSharp.Compiler.Ast.SynValSig *
    memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  default __.VisitMemberDefn_AbstractSlot
     (context: 'TContext,
      valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
      memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Interface".</remarks>
  abstract member BeforeVisitMemberDefn_Interface:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Interface".</remarks>
  default this.BeforeVisitMemberDefn_Interface
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_Interface(
      context,
      this.VisitType context typeName,
      interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberDefn context v)),
      range)

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  abstract member VisitMemberDefn_Interface:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  default __.VisitMemberDefn_Interface
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Inherit".</remarks>
  abstract member BeforeVisitMemberDefn_Inherit:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    id: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Inherit".</remarks>
  default this.BeforeVisitMemberDefn_Inherit
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      id: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_Inherit(
      context,
      this.VisitType context typeName,
      id,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  abstract member VisitMemberDefn_Inherit:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    id: Microsoft.FSharp.Compiler.Ast.Ident option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  default __.VisitMemberDefn_Inherit
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      id: Microsoft.FSharp.Compiler.Ast.Ident option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ValField".</remarks>
  abstract member BeforeVisitMemberDefn_ValField:
    context: 'TContext *
    field: Microsoft.FSharp.Compiler.Ast.SynField *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ValField".</remarks>
  default this.BeforeVisitMemberDefn_ValField
     (context: 'TContext,
      field: Microsoft.FSharp.Compiler.Ast.SynField,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_ValField(
      context,
      this.VisitField context field,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  abstract member VisitMemberDefn_ValField:
    context: 'TContext *
    field: Microsoft.FSharp.Compiler.Ast.SynField *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  default __.VisitMemberDefn_ValField
     (context: 'TContext,
      field: Microsoft.FSharp.Compiler.Ast.SynField,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range)

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_NestedType".</remarks>
  abstract member BeforeVisitMemberDefn_NestedType:
    context: 'TContext *
    typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_NestedType".</remarks>
  default this.BeforeVisitMemberDefn_NestedType
     (context: 'TContext,
      typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_NestedType(
      context,
      this.VisitTypeDefn context typeDefn,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  abstract member VisitMemberDefn_NestedType:
    context: 'TContext *
    typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  default __.VisitMemberDefn_NestedType
     (context: 'TContext,
      typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AutoProperty".</remarks>
  abstract member BeforeVisitMemberDefn_AutoProperty:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    isStatic: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option *
    propKind: Microsoft.FSharp.Compiler.Ast.MemberKind *
    memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    getSetPos: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AutoProperty".</remarks>
  default this.BeforeVisitMemberDefn_AutoProperty
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      isStatic: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option,
      propKind: Microsoft.FSharp.Compiler.Ast.MemberKind,
      memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags),
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      getSetPos: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberDefn_AutoProperty(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      isStatic,
      id,
      tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitType context v),
      propKind,
      memberFlags,
      xmlDoc,
      accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      this.VisitExpr context expr,
      getSetPos,
      range)

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  abstract member VisitMemberDefn_AutoProperty:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    isStatic: bool *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option *
    propKind: Microsoft.FSharp.Compiler.Ast.MemberKind *
    memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    getSetPos: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  default __.VisitMemberDefn_AutoProperty
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      isStatic: bool,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option,
      propKind: Microsoft.FSharp.Compiler.Ast.MemberKind,
      memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags),
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      getSetPos: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)


  /// <summary>
  /// Visit and dispatch "SynMemberDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberDefn">SynMemberDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberDefn
      (context: 'TContext)
      (synMemberDefn: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.MemberDefn synMemberDefn)
    try
      match synMemberDefn with
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range) ->
        this.BeforeVisitMemberDefn_Open(context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
        this.BeforeVisitMemberDefn_Member(context, memberDefn, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
        this.BeforeVisitMemberDefn_ImplicitCtor(context, accessiblity, attributes, ctorArgs, selfIdentifier, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
        this.BeforeVisitMemberDefn_ImplicitInherit(context, inheritType, inheritArgs, inheritAlias, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
        this.BeforeVisitMemberDefn_LetBindings(context, bindings, isStatic, isRecursive, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
        this.BeforeVisitMemberDefn_AbstractSlot(context, valSig, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
        this.BeforeVisitMemberDefn_Interface(context, typeName, interfaceMembers, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
        this.BeforeVisitMemberDefn_Inherit(context, typeName, id, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
        this.BeforeVisitMemberDefn_ValField(context, field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
        this.BeforeVisitMemberDefn_NestedType(context, typeDefn, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
        this.BeforeVisitMemberDefn_AutoProperty(context, attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Member".</remarks>
  abstract member BeforeVisitMemberSig_Member:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynValSig *
    memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Member".</remarks>
  default this.BeforeVisitMemberSig_Member
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
      memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberSig_Member(
      context,
      this.VisitValSig context item1,
      memberFlags,
      range)

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  abstract member VisitMemberSig_Member:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynValSig *
    memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  default __.VisitMemberSig_Member
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
      memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Interface".</remarks>
  abstract member BeforeVisitMemberSig_Interface:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Interface".</remarks>
  default this.BeforeVisitMemberSig_Interface
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberSig_Interface(
      context,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  abstract member VisitMemberSig_Interface:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  default __.VisitMemberSig_Interface
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Inherit".</remarks>
  abstract member BeforeVisitMemberSig_Inherit:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Inherit".</remarks>
  default this.BeforeVisitMemberSig_Inherit
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberSig_Inherit(
      context,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  abstract member VisitMemberSig_Inherit:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  default __.VisitMemberSig_Inherit
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_ValField".</remarks>
  abstract member BeforeVisitMemberSig_ValField:
    context: 'TContext *
    field: Microsoft.FSharp.Compiler.Ast.SynField *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_ValField".</remarks>
  default this.BeforeVisitMemberSig_ValField
     (context: 'TContext,
      field: Microsoft.FSharp.Compiler.Ast.SynField,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberSig_ValField(
      context,
      this.VisitField context field,
      range)

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  abstract member VisitMemberSig_ValField:
    context: 'TContext *
    field: Microsoft.FSharp.Compiler.Ast.SynField *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  default __.VisitMemberSig_ValField
     (context: 'TContext,
      field: Microsoft.FSharp.Compiler.Ast.SynField,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range)

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_NestedType".</remarks>
  abstract member BeforeVisitMemberSig_NestedType:
    context: 'TContext *
    typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_NestedType".</remarks>
  default this.BeforeVisitMemberSig_NestedType
     (context: 'TContext,
      typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitMemberSig_NestedType(
      context,
      this.VisitTypeDefnSig context typeDefnSig,
      range)

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  abstract member VisitMemberSig_NestedType:
    context: 'TContext *
    typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  default __.VisitMemberSig_NestedType
     (context: 'TContext,
      typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range)


  /// <summary>
  /// Visit and dispatch "SynMemberSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberSig">SynMemberSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberSig
      (context: 'TContext)
      (synMemberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.MemberSig synMemberSig)
    try
      match synMemberSig with
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
        this.BeforeVisitMemberSig_Member(context, item1, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
        this.BeforeVisitMemberSig_Interface(context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
        this.BeforeVisitMemberSig_Inherit(context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
        this.BeforeVisitMemberSig_ValField(context, field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
        this.BeforeVisitMemberSig_NestedType(context, typeDefnSig, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_ModuleAbbrev".</remarks>
  abstract member BeforeVisitModuleDecl_ModuleAbbrev:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    item2: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_ModuleAbbrev".</remarks>
  default this.BeforeVisitModuleDecl_ModuleAbbrev
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      item2: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_ModuleAbbrev(
      context,
      item1,
      item2,
      item3)

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  abstract member VisitModuleDecl_ModuleAbbrev:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    item2: Microsoft.FSharp.Compiler.Ast.Ident list *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  default __.VisitModuleDecl_ModuleAbbrev
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      item2: Microsoft.FSharp.Compiler.Ast.Ident list,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NestedModule".</remarks>
  abstract member BeforeVisitModuleDecl_NestedModule:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    isRec: bool *
    item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list *
    item4: bool *
    item5: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NestedModule".</remarks>
  default this.BeforeVisitModuleDecl_NestedModule
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      isRec: bool,
      item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
      item4: bool,
      item5: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_NestedModule(
      context,
      this.VisitComponentInfo context item1,
      isRec,
      item3 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitModuleDecl context v),
      item4,
      item5)

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  abstract member VisitModuleDecl_NestedModule:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    isRec: bool *
    item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list *
    item4: bool *
    item5: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  default __.VisitModuleDecl_NestedModule
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      isRec: bool,
      item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
      item4: bool,
      item5: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5)

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Let".</remarks>
  abstract member BeforeVisitModuleDecl_Let:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Let".</remarks>
  default this.BeforeVisitModuleDecl_Let
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_Let(
      context,
      item1,
      item2 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitBinding context v),
      item3)

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  abstract member VisitModuleDecl_Let:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynBinding list *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  default __.VisitModuleDecl_Let
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_DoExpr".</remarks>
  abstract member BeforeVisitModuleDecl_DoExpr:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_DoExpr".</remarks>
  default this.BeforeVisitModuleDecl_DoExpr
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_DoExpr(
      context,
      item1,
      this.VisitExpr context item2,
      item3)

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  abstract member VisitModuleDecl_DoExpr:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding *
    item2: Microsoft.FSharp.Compiler.Ast.SynExpr *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  default __.VisitModuleDecl_DoExpr
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
      item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Types".</remarks>
  abstract member BeforeVisitModuleDecl_Types:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Types".</remarks>
  default this.BeforeVisitModuleDecl_Types
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_Types(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypeDefn context v),
      item2)

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  abstract member VisitModuleDecl_Types:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  default __.VisitModuleDecl_Types
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Exception".</remarks>
  abstract member BeforeVisitModuleDecl_Exception:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Exception".</remarks>
  default this.BeforeVisitModuleDecl_Exception
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_Exception(
      context,
      this.VisitExceptionDefn context item1,
      item2)

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  abstract member VisitModuleDecl_Exception:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  default __.VisitModuleDecl_Exception
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Open".</remarks>
  abstract member BeforeVisitModuleDecl_Open:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Open".</remarks>
  default this.BeforeVisitModuleDecl_Open
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_Open(
      context,
      item1,
      item2)

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  abstract member VisitModuleDecl_Open:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  default __.VisitModuleDecl_Open
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Attributes".</remarks>
  abstract member BeforeVisitModuleDecl_Attributes:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Attributes".</remarks>
  default this.BeforeVisitModuleDecl_Attributes
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_Attributes(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      item2)

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  abstract member VisitModuleDecl_Attributes:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  default __.VisitModuleDecl_Attributes
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_HashDirective".</remarks>
  abstract member BeforeVisitModuleDecl_HashDirective:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_HashDirective".</remarks>
  default this.BeforeVisitModuleDecl_HashDirective
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleDecl_HashDirective(
      context,
      item1,
      item2)

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  abstract member VisitModuleDecl_HashDirective:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective *
    item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  default __.VisitModuleDecl_HashDirective
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
      item2: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NamespaceFragment".</remarks>
  abstract member BeforeVisitModuleDecl_NamespaceFragment:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NamespaceFragment".</remarks>
  default this.BeforeVisitModuleDecl_NamespaceFragment
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    this.VisitModuleDecl_NamespaceFragment(
      context,
      this.VisitModuleOrNamespace context item)

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  abstract member VisitModuleDecl_NamespaceFragment:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  default __.VisitModuleDecl_NamespaceFragment
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item)


  /// <summary>
  /// Visit and dispatch "SynModuleDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleDecl">SynModuleDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleDecl
      (context: 'TContext)
      (synModuleDecl: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ModuleDecl synModuleDecl)
    try
      match synModuleDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_ModuleAbbrev(context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
        this.BeforeVisitModuleDecl_NestedModule(context, item1, isRec, item3, item4, item5)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_Let(context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_DoExpr(context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
        this.BeforeVisitModuleDecl_Types(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
        this.BeforeVisitModuleDecl_Exception(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2) ->
        this.BeforeVisitModuleDecl_Open(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
        this.BeforeVisitModuleDecl_Attributes(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
        this.BeforeVisitModuleDecl_HashDirective(context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleDecl_NamespaceFragment(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespace_SynModuleOrNamespace".</remarks>
  abstract member BeforeVisitModuleOrNamespace_SynModuleOrNamespace:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident list *
    isRec: bool *
    isModule: bool *
    decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    access: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespace_SynModuleOrNamespace".</remarks>
  default this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident list,
      isRec: bool,
      isModule: bool,
      decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleOrNamespace_SynModuleOrNamespace(
      context,
      id,
      isRec,
      isModule,
      decls |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitModuleDecl context v),
      xmlDoc,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      access |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  abstract member VisitModuleOrNamespace_SynModuleOrNamespace:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident list *
    isRec: bool *
    isModule: bool *
    decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    access: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  default __.VisitModuleOrNamespace_SynModuleOrNamespace
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident list,
      isRec: bool,
      isModule: bool,
      decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespace">SynModuleOrNamespace expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespace
      (context: 'TContext)
      (synModuleOrNamespace: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ModuleOrNamespace synModuleOrNamespace)
    try
      match synModuleOrNamespace with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
        this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace(context, id, isRec, isModule, decls, xmlDoc, attributes, access, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig".</remarks>
  abstract member BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident list *
    isRec: bool *
    isModule: bool *
    item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item7: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig".</remarks>
  default this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident list,
      isRec: bool,
      isModule: bool,
      item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(
      context,
      id,
      isRec,
      isModule,
      item4 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitModuleSigDecl context v),
      xmlDoc,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      item7 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  abstract member VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident list *
    isRec: bool *
    isModule: bool *
    item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item7: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  default __.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident list,
      isRec: bool,
      isModule: bool,
      item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespaceSig">SynModuleOrNamespaceSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespaceSig
      (context: 'TContext)
      (synModuleOrNamespaceSig: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ModuleOrNamespaceSig synModuleOrNamespaceSig)
    try
      match synModuleOrNamespaceSig with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
        this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(context, id, isRec, isModule, item4, xmlDoc, attributes, item7, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_ModuleAbbrev".</remarks>
  abstract member BeforeVisitModuleSigDecl_ModuleAbbrev:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_ModuleAbbrev".</remarks>
  default this.BeforeVisitModuleSigDecl_ModuleAbbrev
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_ModuleAbbrev(
      context,
      id,
      longId,
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  abstract member VisitModuleSigDecl_ModuleAbbrev:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  default __.VisitModuleSigDecl_ModuleAbbrev
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NestedModule".</remarks>
  abstract member BeforeVisitModuleSigDecl_NestedModule:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    isRec: bool *
    moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NestedModule".</remarks>
  default this.BeforeVisitModuleSigDecl_NestedModule
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      isRec: bool,
      moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_NestedModule(
      context,
      this.VisitComponentInfo context item1,
      isRec,
      moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitModuleSigDecl context v),
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  abstract member VisitModuleSigDecl_NestedModule:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    isRec: bool *
    moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  default __.VisitModuleSigDecl_NestedModule
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      isRec: bool,
      moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Val".</remarks>
  abstract member BeforeVisitModuleSigDecl_Val:
    context: 'TContext *
    valSig: Microsoft.FSharp.Compiler.Ast.SynValSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Val".</remarks>
  default this.BeforeVisitModuleSigDecl_Val
     (context: 'TContext,
      valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_Val(
      context,
      this.VisitValSig context valSig,
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  abstract member VisitModuleSigDecl_Val:
    context: 'TContext *
    valSig: Microsoft.FSharp.Compiler.Ast.SynValSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  default __.VisitModuleSigDecl_Val
     (context: 'TContext,
      valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Types".</remarks>
  abstract member BeforeVisitModuleSigDecl_Types:
    context: 'TContext *
    typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Types".</remarks>
  default this.BeforeVisitModuleSigDecl_Types
     (context: 'TContext,
      typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_Types(
      context,
      typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypeDefnSig context v),
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  abstract member VisitModuleSigDecl_Types:
    context: 'TContext *
    typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  default __.VisitModuleSigDecl_Types
     (context: 'TContext,
      typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Exception".</remarks>
  abstract member BeforeVisitModuleSigDecl_Exception:
    context: 'TContext *
    exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Exception".</remarks>
  default this.BeforeVisitModuleSigDecl_Exception
     (context: 'TContext,
      exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_Exception(
      context,
      this.VisitExceptionSig context exnSig,
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  abstract member VisitModuleSigDecl_Exception:
    context: 'TContext *
    exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  default __.VisitModuleSigDecl_Exception
     (context: 'TContext,
      exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Open".</remarks>
  abstract member BeforeVisitModuleSigDecl_Open:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Open".</remarks>
  default this.BeforeVisitModuleSigDecl_Open
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_Open(
      context,
      longId,
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  abstract member VisitModuleSigDecl_Open:
    context: 'TContext *
    longId: Microsoft.FSharp.Compiler.Ast.Ident list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  default __.VisitModuleSigDecl_Open
     (context: 'TContext,
      longId: Microsoft.FSharp.Compiler.Ast.Ident list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_HashDirective".</remarks>
  abstract member BeforeVisitModuleSigDecl_HashDirective:
    context: 'TContext *
    hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_HashDirective".</remarks>
  default this.BeforeVisitModuleSigDecl_HashDirective
     (context: 'TContext,
      hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitModuleSigDecl_HashDirective(
      context,
      hashDirective,
      range)

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  abstract member VisitModuleSigDecl_HashDirective:
    context: 'TContext *
    hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  default __.VisitModuleSigDecl_HashDirective
     (context: 'TContext,
      hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NamespaceFragment".</remarks>
  abstract member BeforeVisitModuleSigDecl_NamespaceFragment:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NamespaceFragment".</remarks>
  default this.BeforeVisitModuleSigDecl_NamespaceFragment
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    this.VisitModuleSigDecl_NamespaceFragment(
      context,
      this.VisitModuleOrNamespaceSig context item)

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  abstract member VisitModuleSigDecl_NamespaceFragment:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  default __.VisitModuleSigDecl_NamespaceFragment
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item)


  /// <summary>
  /// Visit and dispatch "SynModuleSigDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleSigDecl">SynModuleSigDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleSigDecl
      (context: 'TContext)
      (synModuleSigDecl: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ModuleSigDecl synModuleSigDecl)
    try
      match synModuleSigDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range) ->
        this.BeforeVisitModuleSigDecl_ModuleAbbrev(context, id, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
        this.BeforeVisitModuleSigDecl_NestedModule(context, item1, isRec, moduleSigDecls, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
        this.BeforeVisitModuleSigDecl_Val(context, valSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
        this.BeforeVisitModuleSigDecl_Types(context, typeDefSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
        this.BeforeVisitModuleSigDecl_Exception(context, exnSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range) ->
        this.BeforeVisitModuleSigDecl_Open(context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
        this.BeforeVisitModuleSigDecl_HashDirective(context, hashDirective, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleSigDecl_NamespaceFragment(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Const".</remarks>
  abstract member BeforeVisitPat_Const:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Const".</remarks>
  default this.BeforeVisitPat_Const
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Const(
      context,
      this.VisitConst context constant,
      range)

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  abstract member VisitPat_Const:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  default __.VisitPat_Const
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range)

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Wild".</remarks>
  abstract member BeforeVisitPat_Wild:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Wild".</remarks>
  default this.BeforeVisitPat_Wild
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Wild(
      context,
      range)

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  abstract member VisitPat_Wild:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  default __.VisitPat_Wild
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range)

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Named".</remarks>
  abstract member BeforeVisitPat_Named:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    isThisVar: bool *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Named".</remarks>
  default this.BeforeVisitPat_Named
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      isThisVar: bool,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Named(
      context,
      this.VisitPat context item1,
      id,
      isThisVar,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  abstract member VisitPat_Named:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    isThisVar: bool *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  default __.VisitPat_Named
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      isThisVar: bool,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range)

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Typed".</remarks>
  abstract member BeforeVisitPat_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Typed".</remarks>
  default this.BeforeVisitPat_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Typed(
      context,
      this.VisitPat context item1,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  abstract member VisitPat_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  default __.VisitPat_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range)

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Attrib".</remarks>
  abstract member BeforeVisitPat_Attrib:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Attrib".</remarks>
  default this.BeforeVisitPat_Attrib
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Attrib(
      context,
      this.VisitPat context item1,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      range)

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  abstract member VisitPat_Attrib:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  default __.VisitPat_Attrib
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range)

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Or".</remarks>
  abstract member BeforeVisitPat_Or:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    item2: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Or".</remarks>
  default this.BeforeVisitPat_Or
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      item2: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Or(
      context,
      this.VisitPat context item1,
      this.VisitPat context item2,
      range)

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  abstract member VisitPat_Or:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    item2: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  default __.VisitPat_Or
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      item2: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Ands".</remarks>
  abstract member BeforeVisitPat_Ands:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Ands".</remarks>
  default this.BeforeVisitPat_Ands
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Ands(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitPat context v),
      range)

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  abstract member VisitPat_Ands:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  default __.VisitPat_Ands
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range)

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_LongIdent".</remarks>
  abstract member BeforeVisitPat_LongIdent:
    context: 'TContext *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Ast.Ident option *
    item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option *
    item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs *
    item5: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_LongIdent".</remarks>
  default this.BeforeVisitPat_LongIdent
     (context: 'TContext,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Ast.Ident option,
      item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
      item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
      item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_LongIdent(
      context,
      dotId,
      item2,
      item3 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitValTyparDecls context v),
      this.VisitConstructorArgs context item4,
      item5 |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  abstract member VisitPat_LongIdent:
    context: 'TContext *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    item2: Microsoft.FSharp.Compiler.Ast.Ident option *
    item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option *
    item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs *
    item5: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  default __.VisitPat_LongIdent
     (context: 'TContext,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      item2: Microsoft.FSharp.Compiler.Ast.Ident option,
      item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
      item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
      item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range)

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Tuple".</remarks>
  abstract member BeforeVisitPat_Tuple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Tuple".</remarks>
  default this.BeforeVisitPat_Tuple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Tuple(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitPat context v),
      range)

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  abstract member VisitPat_Tuple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  default __.VisitPat_Tuple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range)

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Paren".</remarks>
  abstract member BeforeVisitPat_Paren:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Paren".</remarks>
  default this.BeforeVisitPat_Paren
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Paren(
      context,
      this.VisitPat context item1,
      range)

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  abstract member VisitPat_Paren:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  default __.VisitPat_Paren
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range)

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_ArrayOrList".</remarks>
  abstract member BeforeVisitPat_ArrayOrList:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_ArrayOrList".</remarks>
  default this.BeforeVisitPat_ArrayOrList
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_ArrayOrList(
      context,
      item1,
      item2 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitPat context v),
      range)

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  abstract member VisitPat_ArrayOrList:
    context: 'TContext *
    item1: bool *
    item2: Microsoft.FSharp.Compiler.Ast.SynPat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  default __.VisitPat_ArrayOrList
     (context: 'TContext,
      item1: bool,
      item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Record".</remarks>
  abstract member BeforeVisitPat_Record:
    context: 'TContext *
    fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Record".</remarks>
  default this.BeforeVisitPat_Record
     (context: 'TContext,
      fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Record(
      context,
      fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in v0, this.VisitPat context v1)),
      range)

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  abstract member VisitPat_Record:
    context: 'TContext *
    fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  default __.VisitPat_Record
     (context: 'TContext,
      fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range)

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Null".</remarks>
  abstract member BeforeVisitPat_Null:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Null".</remarks>
  default this.BeforeVisitPat_Null
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_Null(
      context,
      range)

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  abstract member VisitPat_Null:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  default __.VisitPat_Null
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Null(range)

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_OptionalVal".</remarks>
  abstract member BeforeVisitPat_OptionalVal:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_OptionalVal".</remarks>
  default this.BeforeVisitPat_OptionalVal
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_OptionalVal(
      context,
      item1,
      range)

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  abstract member VisitPat_OptionalVal:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  default __.VisitPat_OptionalVal
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range)

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_IsInst".</remarks>
  abstract member BeforeVisitPat_IsInst:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_IsInst".</remarks>
  default this.BeforeVisitPat_IsInst
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_IsInst(
      context,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  abstract member VisitPat_IsInst:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  default __.VisitPat_IsInst
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range)

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_QuoteExpr".</remarks>
  abstract member BeforeVisitPat_QuoteExpr:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_QuoteExpr".</remarks>
  default this.BeforeVisitPat_QuoteExpr
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_QuoteExpr(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  abstract member VisitPat_QuoteExpr:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  default __.VisitPat_QuoteExpr
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range)

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_DeprecatedCharRange".</remarks>
  abstract member BeforeVisitPat_DeprecatedCharRange:
    context: 'TContext *
    item1: char *
    item2: char *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_DeprecatedCharRange".</remarks>
  default this.BeforeVisitPat_DeprecatedCharRange
     (context: 'TContext,
      item1: char,
      item2: char,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_DeprecatedCharRange(
      context,
      item1,
      item2,
      range)

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  abstract member VisitPat_DeprecatedCharRange:
    context: 'TContext *
    item1: char *
    item2: char *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  default __.VisitPat_DeprecatedCharRange
     (context: 'TContext,
      item1: char,
      item2: char,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_InstanceMember".</remarks>
  abstract member BeforeVisitPat_InstanceMember:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    item2: Microsoft.FSharp.Compiler.Ast.Ident *
    item3: Microsoft.FSharp.Compiler.Ast.Ident option *
    accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_InstanceMember".</remarks>
  default this.BeforeVisitPat_InstanceMember
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      item2: Microsoft.FSharp.Compiler.Ast.Ident,
      item3: Microsoft.FSharp.Compiler.Ast.Ident option,
      accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_InstanceMember(
      context,
      item1,
      item2,
      item3,
      accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  abstract member VisitPat_InstanceMember:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.Ident *
    item2: Microsoft.FSharp.Compiler.Ast.Ident *
    item3: Microsoft.FSharp.Compiler.Ast.Ident option *
    accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  default __.VisitPat_InstanceMember
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.Ident,
      item2: Microsoft.FSharp.Compiler.Ast.Ident,
      item3: Microsoft.FSharp.Compiler.Ast.Ident option,
      accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range)

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_FromParseError".</remarks>
  abstract member BeforeVisitPat_FromParseError:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_FromParseError".</remarks>
  default this.BeforeVisitPat_FromParseError
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitPat_FromParseError(
      context,
      this.VisitPat context item1,
      range)

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  abstract member VisitPat_FromParseError:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynPat *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  default __.VisitPat_FromParseError
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynPat,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range)


  /// <summary>
  /// Visit and dispatch "SynPat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synPat">SynPat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitPat
      (context: 'TContext)
      (synPat: Microsoft.FSharp.Compiler.Ast.SynPat) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Pat synPat)
    try
      match synPat with
      | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
        this.BeforeVisitPat_Const(context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range) ->
        this.BeforeVisitPat_Wild(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
        this.BeforeVisitPat_Named(context, item1, id, isThisVar, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
        this.BeforeVisitPat_Typed(context, item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
        this.BeforeVisitPat_Attrib(context, item1, attributes, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
        this.BeforeVisitPat_Or(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
        this.BeforeVisitPat_Ands(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
        this.BeforeVisitPat_LongIdent(context, dotId, item2, item3, item4, item5, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
        this.BeforeVisitPat_Tuple(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
        this.BeforeVisitPat_Paren(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
        this.BeforeVisitPat_ArrayOrList(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
        this.BeforeVisitPat_Record(context, fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Null(range) ->
        this.BeforeVisitPat_Null(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range) ->
        this.BeforeVisitPat_OptionalVal(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
        this.BeforeVisitPat_IsInst(context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
        this.BeforeVisitPat_QuoteExpr(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range) ->
        this.BeforeVisitPat_DeprecatedCharRange(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
        this.BeforeVisitPat_InstanceMember(context, item1, item2, item3, accesiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
        this.BeforeVisitPat_FromParseError(context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Integer".</remarks>
  abstract member BeforeVisitRationalConst_Integer:
    context: 'TContext *
    item: int -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Integer".</remarks>
  default this.BeforeVisitRationalConst_Integer
     (context: 'TContext,
      item: int) =
    this.VisitRationalConst_Integer(
      context,
      item)

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  abstract member VisitRationalConst_Integer:
    context: 'TContext *
    item: int -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  default __.VisitRationalConst_Integer
     (context: 'TContext,
      item: int) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item)

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Rational".</remarks>
  abstract member BeforeVisitRationalConst_Rational:
    context: 'TContext *
    item1: int *
    item2: int *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Rational".</remarks>
  default this.BeforeVisitRationalConst_Rational
     (context: 'TContext,
      item1: int,
      item2: int,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitRationalConst_Rational(
      context,
      item1,
      item2,
      item3)

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  abstract member VisitRationalConst_Rational:
    context: 'TContext *
    item1: int *
    item2: int *
    item3: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  default __.VisitRationalConst_Rational
     (context: 'TContext,
      item1: int,
      item2: int,
      item3: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3)

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Negate".</remarks>
  abstract member BeforeVisitRationalConst_Negate:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynRationalConst -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Negate".</remarks>
  default this.BeforeVisitRationalConst_Negate
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    this.VisitRationalConst_Negate(
      context,
      this.VisitRationalConst context item)

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  abstract member VisitRationalConst_Negate:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynRationalConst -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  default __.VisitRationalConst_Negate
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item)


  /// <summary>
  /// Visit and dispatch "SynRationalConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synRationalConst">SynRationalConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitRationalConst
      (context: 'TContext)
      (synRationalConst: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.RationalConst synRationalConst)
    try
      match synRationalConst with
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item) ->
        this.BeforeVisitRationalConst_Integer(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3) ->
        this.BeforeVisitRationalConst_Rational(context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
        this.BeforeVisitRationalConst_Negate(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitReturnInfo_SynReturnInfo".</remarks>
  abstract member BeforeVisitReturnInfo_SynReturnInfo:
    context: 'TContext *
    item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitReturnInfo_SynReturnInfo".</remarks>
  default this.BeforeVisitReturnInfo_SynReturnInfo
     (context: 'TContext,
      item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitReturnInfo_SynReturnInfo(
      context,
      (let item1 = item1 in this.VisitType context v0, this.VisitArgInfo context v1),
      range)

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  abstract member VisitReturnInfo_SynReturnInfo:
    context: 'TContext *
    item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynReturnInfo

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  default __.VisitReturnInfo_SynReturnInfo
     (context: 'TContext,
      item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range)


  /// <summary>
  /// Visit and dispatch "SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synReturnInfo">SynReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitReturnInfo
      (context: 'TContext)
      (synReturnInfo: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ReturnInfo synReturnInfo)
    try
      match synReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
        this.BeforeVisitReturnInfo_SynReturnInfo(context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Id".</remarks>
  abstract member BeforeVisitSimplePat_Id:
    context: 'TContext *
    ident: Microsoft.FSharp.Compiler.Ast.Ident *
    altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option *
    isCompilerGenerated: bool *
    isThisVar: bool *
    isOptArg: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Id".</remarks>
  default this.BeforeVisitSimplePat_Id
     (context: 'TContext,
      ident: Microsoft.FSharp.Compiler.Ast.Ident,
      altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
      isCompilerGenerated: bool,
      isThisVar: bool,
      isOptArg: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitSimplePat_Id(
      context,
      ident,
      altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> AstRecordCons.initFSharpRef`1 (this.VisitSimplePatAlternativeIdInfo context v.contents)),
      isCompilerGenerated,
      isThisVar,
      isOptArg,
      range)

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  abstract member VisitSimplePat_Id:
    context: 'TContext *
    ident: Microsoft.FSharp.Compiler.Ast.Ident *
    altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option *
    isCompilerGenerated: bool *
    isThisVar: bool *
    isOptArg: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  default __.VisitSimplePat_Id
     (context: 'TContext,
      ident: Microsoft.FSharp.Compiler.Ast.Ident,
      altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
      isCompilerGenerated: bool,
      isThisVar: bool,
      isOptArg: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Typed".</remarks>
  abstract member BeforeVisitSimplePat_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Typed".</remarks>
  default this.BeforeVisitSimplePat_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitSimplePat_Typed(
      context,
      this.VisitSimplePat context item1,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  abstract member VisitSimplePat_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  default __.VisitSimplePat_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range)

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Attrib".</remarks>
  abstract member BeforeVisitSimplePat_Attrib:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Attrib".</remarks>
  default this.BeforeVisitSimplePat_Attrib
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitSimplePat_Attrib(
      context,
      this.VisitSimplePat context item1,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      range)

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  abstract member VisitSimplePat_Attrib:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  default __.VisitSimplePat_Attrib
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePat">SynSimplePat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePat
      (context: 'TContext)
      (synSimplePat: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.SimplePat synSimplePat)
    try
      match synSimplePat with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
        this.BeforeVisitSimplePat_Id(context, ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
        this.BeforeVisitSimplePat_Typed(context, item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
        this.BeforeVisitSimplePat_Attrib(context, item1, attributes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Undecided".</remarks>
  abstract member BeforeVisitSimplePatAlternativeIdInfo_Undecided:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Undecided".</remarks>
  default this.BeforeVisitSimplePatAlternativeIdInfo_Undecided
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    this.VisitSimplePatAlternativeIdInfo_Undecided(
      context,
      item)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  abstract member VisitSimplePatAlternativeIdInfo_Undecided:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  default __.VisitSimplePatAlternativeIdInfo_Undecided
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item)

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Decided".</remarks>
  abstract member BeforeVisitSimplePatAlternativeIdInfo_Decided:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Decided".</remarks>
  default this.BeforeVisitSimplePatAlternativeIdInfo_Decided
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    this.VisitSimplePatAlternativeIdInfo_Decided(
      context,
      item)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  abstract member VisitSimplePatAlternativeIdInfo_Decided:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  default __.VisitSimplePatAlternativeIdInfo_Decided
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.Ident) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item)


  /// <summary>
  /// Visit and dispatch "SynSimplePatAlternativeIdInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePatAlternativeIdInfo">SynSimplePatAlternativeIdInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePatAlternativeIdInfo
      (context: 'TContext)
      (synSimplePatAlternativeIdInfo: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.SimplePatAlternativeIdInfo synSimplePatAlternativeIdInfo)
    try
      match synSimplePatAlternativeIdInfo with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item) ->
        this.BeforeVisitSimplePatAlternativeIdInfo_Undecided(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item) ->
        this.BeforeVisitSimplePatAlternativeIdInfo_Decided(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_SimplePats".</remarks>
  abstract member BeforeVisitSimplePats_SimplePats:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_SimplePats".</remarks>
  default this.BeforeVisitSimplePats_SimplePats
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitSimplePats_SimplePats(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitSimplePat context v),
      range)

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  abstract member VisitSimplePats_SimplePats:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  default __.VisitSimplePats_SimplePats
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range)

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_Typed".</remarks>
  abstract member BeforeVisitSimplePats_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_Typed".</remarks>
  default this.BeforeVisitSimplePats_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitSimplePats_Typed(
      context,
      this.VisitSimplePats context item1,
      this.VisitType context item2,
      range)

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  abstract member VisitSimplePats_Typed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  default __.VisitSimplePats_Typed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePats">SynSimplePats expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePats
      (context: 'TContext)
      (synSimplePats: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.SimplePats synSimplePats)
    try
      match synSimplePats with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
        this.BeforeVisitSimplePats_SimplePats(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
        this.BeforeVisitSimplePats_Typed(context, item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon".</remarks>
  abstract member BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon".</remarks>
  default this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(
      context,
      this.VisitTypar context item1,
      this.VisitType context item2,
      range)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  abstract member VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  default __.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range)

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparIsStruct".</remarks>
  abstract member BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparIsStruct".</remarks>
  default this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitStaticOptimizationConstraint_WhenTyparIsStruct(
      context,
      this.VisitTypar context item1,
      range)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  abstract member VisitStaticOptimizationConstraint_WhenTyparIsStruct:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  default __.VisitStaticOptimizationConstraint_WhenTyparIsStruct
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range)


  /// <summary>
  /// Visit and dispatch "SynStaticOptimizationConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synStaticOptimizationConstraint">SynStaticOptimizationConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitStaticOptimizationConstraint
      (context: 'TContext)
      (synStaticOptimizationConstraint: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.StaticOptimizationConstraint synStaticOptimizationConstraint)
    try
      match synStaticOptimizationConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct(context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar_Typar".</remarks>
  abstract member BeforeVisitTypar_Typar:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq *
    isCompGen: bool -> Microsoft.FSharp.Compiler.Ast.SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar_Typar".</remarks>
  default this.BeforeVisitTypar_Typar
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
      isCompGen: bool) =
    this.VisitTypar_Typar(
      context,
      id,
      staticReq,
      isCompGen)

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  abstract member VisitTypar_Typar:
    context: 'TContext *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq *
    isCompGen: bool -> Microsoft.FSharp.Compiler.Ast.SynTypar

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  default __.VisitTypar_Typar
     (context: 'TContext,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
      isCompGen: bool) =
    Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen)


  /// <summary>
  /// Visit and dispatch "SynTypar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypar">SynTypar expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypar
      (context: 'TContext)
      (synTypar: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Typar synTypar)
    try
      match synTypar with
      | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen) ->
        this.BeforeVisitTypar_Typar(context, id, staticReq, isCompGen)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl_TyparDecl".</remarks>
  abstract member BeforeVisitTyparDecl_TyparDecl:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypar -> Microsoft.FSharp.Compiler.Ast.SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl_TyparDecl".</remarks>
  default this.BeforeVisitTyparDecl_TyparDecl
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    this.VisitTyparDecl_TyparDecl(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      this.VisitTypar context item2)

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  abstract member VisitTyparDecl_TyparDecl:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypar -> Microsoft.FSharp.Compiler.Ast.SynTyparDecl

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  default __.VisitTyparDecl_TyparDecl
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2)


  /// <summary>
  /// Visit and dispatch "SynTyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTyparDecl">SynTyparDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTyparDecl
      (context: 'TContext)
      (synTyparDecl: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TyparDecl synTyparDecl)
    try
      match synTyparDecl with
      | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
        this.BeforeVisitTyparDecl_TyparDecl(context, attributes, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdent".</remarks>
  abstract member BeforeVisitType_LongIdent:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdent".</remarks>
  default this.BeforeVisitType_LongIdent
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) =
    this.VisitType_LongIdent(
      context,
      item)

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  abstract member VisitType_LongIdent:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  default __.VisitType_LongIdent
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item)

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_App".</remarks>
  abstract member BeforeVisitType_App:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    isPostfix: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_App".</remarks>
  default this.BeforeVisitType_App
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      isPostfix: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_App(
      context,
      this.VisitType context typeName,
      leftAngleRange,
      typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      commaRanges,
      rightAngleRange,
      isPostfix,
      range)

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  abstract member VisitType_App:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    isPostfix: bool *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  default __.VisitType_App
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      isPostfix: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdentApp".</remarks>
  abstract member BeforeVisitType_LongIdentApp:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    genericNames: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdentApp".</remarks>
  default this.BeforeVisitType_LongIdentApp
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_LongIdentApp(
      context,
      this.VisitType context typeName,
      dotId,
      leftAngleRange,
      genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      commaRanges,
      rightAngleRange,
      range)

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  abstract member VisitType_LongIdentApp:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots *
    leftAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    genericNames: Microsoft.FSharp.Compiler.Ast.SynType list *
    commaRanges: Microsoft.FSharp.Compiler.Range.range list *
    rightAngleRange: Microsoft.FSharp.Compiler.Range.range option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  default __.VisitType_LongIdentApp
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
      commaRanges: Microsoft.FSharp.Compiler.Range.range list,
      rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Tuple".</remarks>
  abstract member BeforeVisitType_Tuple:
    context: 'TContext *
    item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Tuple".</remarks>
  default this.BeforeVisitType_Tuple
     (context: 'TContext,
      item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_Tuple(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in v0, this.VisitType context v1)),
      range)

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  abstract member VisitType_Tuple:
    context: 'TContext *
    item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  default __.VisitType_Tuple
     (context: 'TContext,
      item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range)

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Array".</remarks>
  abstract member BeforeVisitType_Array:
    context: 'TContext *
    item1: int *
    elementType: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Array".</remarks>
  default this.BeforeVisitType_Array
     (context: 'TContext,
      item1: int,
      elementType: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_Array(
      context,
      item1,
      this.VisitType context elementType,
      range)

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  abstract member VisitType_Array:
    context: 'TContext *
    item1: int *
    elementType: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  default __.VisitType_Array
     (context: 'TContext,
      item1: int,
      elementType: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range)

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Fun".</remarks>
  abstract member BeforeVisitType_Fun:
    context: 'TContext *
    argType: Microsoft.FSharp.Compiler.Ast.SynType *
    returnType: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Fun".</remarks>
  default this.BeforeVisitType_Fun
     (context: 'TContext,
      argType: Microsoft.FSharp.Compiler.Ast.SynType,
      returnType: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_Fun(
      context,
      this.VisitType context argType,
      this.VisitType context returnType,
      range)

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  abstract member VisitType_Fun:
    context: 'TContext *
    argType: Microsoft.FSharp.Compiler.Ast.SynType *
    returnType: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  default __.VisitType_Fun
     (context: 'TContext,
      argType: Microsoft.FSharp.Compiler.Ast.SynType,
      returnType: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range)

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Var".</remarks>
  abstract member BeforeVisitType_Var:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Var".</remarks>
  default this.BeforeVisitType_Var
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_Var(
      context,
      this.VisitTypar context item1,
      range)

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  abstract member VisitType_Var:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  default __.VisitType_Var
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range)

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Anon".</remarks>
  abstract member BeforeVisitType_Anon:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Anon".</remarks>
  default this.BeforeVisitType_Anon
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_Anon(
      context,
      range)

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  abstract member VisitType_Anon:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  default __.VisitType_Anon
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.Anon(range)

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_WithGlobalConstraints".</remarks>
  abstract member BeforeVisitType_WithGlobalConstraints:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_WithGlobalConstraints".</remarks>
  default this.BeforeVisitType_WithGlobalConstraints
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_WithGlobalConstraints(
      context,
      this.VisitType context typeName,
      constraints |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypeConstraint context v),
      range)

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  abstract member VisitType_WithGlobalConstraints:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  default __.VisitType_WithGlobalConstraints
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range)

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_HashConstraint".</remarks>
  abstract member BeforeVisitType_HashConstraint:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_HashConstraint".</remarks>
  default this.BeforeVisitType_HashConstraint
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_HashConstraint(
      context,
      this.VisitType context typeName,
      range)

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  abstract member VisitType_HashConstraint:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  default __.VisitType_HashConstraint
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range)

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasureDivide".</remarks>
  abstract member BeforeVisitType_MeasureDivide:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasureDivide".</remarks>
  default this.BeforeVisitType_MeasureDivide
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_MeasureDivide(
      context,
      this.VisitType context typeName,
      this.VisitType context item2,
      range)

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  abstract member VisitType_MeasureDivide:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  default __.VisitType_MeasureDivide
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasurePower".</remarks>
  abstract member BeforeVisitType_MeasurePower:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasurePower".</remarks>
  default this.BeforeVisitType_MeasurePower
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_MeasurePower(
      context,
      this.VisitType context typeName,
      this.VisitRationalConst context item2,
      range)

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  abstract member VisitType_MeasurePower:
    context: 'TContext *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  default __.VisitType_MeasurePower
     (context: 'TContext,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstant".</remarks>
  abstract member BeforeVisitType_StaticConstant:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstant".</remarks>
  default this.BeforeVisitType_StaticConstant
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_StaticConstant(
      context,
      this.VisitConst context constant,
      range)

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  abstract member VisitType_StaticConstant:
    context: 'TContext *
    constant: Microsoft.FSharp.Compiler.Ast.SynConst *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  default __.VisitType_StaticConstant
     (context: 'TContext,
      constant: Microsoft.FSharp.Compiler.Ast.SynConst,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantExpr".</remarks>
  abstract member BeforeVisitType_StaticConstantExpr:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantExpr".</remarks>
  default this.BeforeVisitType_StaticConstantExpr
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_StaticConstantExpr(
      context,
      this.VisitExpr context expr,
      range)

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  abstract member VisitType_StaticConstantExpr:
    context: 'TContext *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  default __.VisitType_StaticConstantExpr
     (context: 'TContext,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantNamed".</remarks>
  abstract member BeforeVisitType_StaticConstantNamed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantNamed".</remarks>
  default this.BeforeVisitType_StaticConstantNamed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitType_StaticConstantNamed(
      context,
      this.VisitType context item1,
      this.VisitType context item2,
      range)

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  abstract member VisitType_StaticConstantNamed:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  default __.VisitType_StaticConstantNamed
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synType">SynType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitType
      (context: 'TContext)
      (synType: Microsoft.FSharp.Compiler.Ast.SynType) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.Type synType)
    try
      match synType with
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item) ->
        this.BeforeVisitType_LongIdent(context, item)
      | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
        this.BeforeVisitType_App(context, typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
        this.BeforeVisitType_LongIdentApp(context, typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
        this.BeforeVisitType_Tuple(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
        this.BeforeVisitType_Array(context, item1, elementType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
        this.BeforeVisitType_Fun(context, argType, returnType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
        this.BeforeVisitType_Var(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Anon(range) ->
        this.BeforeVisitType_Anon(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
        this.BeforeVisitType_WithGlobalConstraints(context, typeName, constraints, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
        this.BeforeVisitType_HashConstraint(context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
        this.BeforeVisitType_MeasureDivide(context, typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
        this.BeforeVisitType_MeasurePower(context, typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
        this.BeforeVisitType_StaticConstant(context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
        this.BeforeVisitType_StaticConstantExpr(context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
        this.BeforeVisitType_StaticConstantNamed(context, item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsValueType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsValueType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsValueType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsValueType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsValueType(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsValueType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsValueType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsReferenceType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsReferenceType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsReferenceType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsReferenceType(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsReferenceType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsReferenceType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsUnmanaged".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsUnmanaged:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsUnmanaged".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsUnmanaged(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsUnmanaged:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsUnmanaged
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsNull".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSupportsNull:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsNull".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSupportsNull
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparSupportsNull(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSupportsNull:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  default __.VisitTypeConstraint_WhereTyparSupportsNull
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsComparable".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsComparable:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsComparable".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsComparable
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsComparable(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsComparable:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsComparable
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEquatable".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsEquatable:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEquatable".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsEquatable
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsEquatable(
      context,
      this.VisitTypar context genericName,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsEquatable:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsEquatable
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparDefaultsToType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparDefaultsToType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparDefaultsToType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparDefaultsToType(
      context,
      this.VisitTypar context genericName,
      this.VisitType context typeSig,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparDefaultsToType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  default __.VisitTypeConstraint_WhereTyparDefaultsToType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSubtypeOfType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSubtypeOfType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSubtypeOfType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparSubtypeOfType(
      context,
      this.VisitTypar context genericName,
      this.VisitType context typeSig,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSubtypeOfType:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    typeSig: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  default __.VisitTypeConstraint_WhereTyparSubtypeOfType
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsMember".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSupportsMember:
    context: 'TContext *
    genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list *
    memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsMember".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSupportsMember
     (context: 'TContext,
      genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
      memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparSupportsMember(
      context,
      genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypar context v),
      this.VisitMemberSig context memberSig,
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSupportsMember:
    context: 'TContext *
    genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list *
    memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  default __.VisitTypeConstraint_WhereTyparSupportsMember
     (context: 'TContext,
      genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
      memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEnum".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsEnum:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEnum".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsEnum
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsEnum(
      context,
      this.VisitTypar context genericName,
      enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsEnum:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsEnum
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsDelegate".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsDelegate:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsDelegate".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsDelegate
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeConstraint_WhereTyparIsDelegate(
      context,
      this.VisitTypar context genericName,
      delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitType context v),
      range)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsDelegate:
    context: 'TContext *
    genericName: Microsoft.FSharp.Compiler.Ast.SynTypar *
    delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsDelegate
     (context: 'TContext,
      genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
      delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range)


  /// <summary>
  /// Visit and dispatch "SynTypeConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeConstraint">SynTypeConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeConstraint
      (context: 'TContext)
      (synTypeConstraint: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeConstraint synTypeConstraint)
    try
      match synTypeConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsValueType(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsNull(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsComparable(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEquatable(context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType(context, genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType(context, genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsMember(context, genericNames, memberSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEnum(context, genericName, enumTypes, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsDelegate(context, genericName, delegateTypes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn_TypeDefn".</remarks>
  abstract member BeforeVisitTypeDefn_TypeDefn:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn_TypeDefn".</remarks>
  default this.BeforeVisitTypeDefn_TypeDefn
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefn_TypeDefn(
      context,
      this.VisitComponentInfo context item1,
      this.VisitTypeDefnRepr context item2,
      members |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberDefn context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  abstract member VisitTypeDefn_TypeDefn:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefn

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  default __.VisitTypeDefn_TypeDefn
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefn">SynTypeDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefn
      (context: 'TContext)
      (synTypeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefn synTypeDefn)
    try
      match synTypeDefn with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
        this.BeforeVisitTypeDefn_TypeDefn(context, item1, item2, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnspecified".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconUnspecified:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnspecified".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconUnspecified
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconUnspecified(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  abstract member VisitTypeDefnKind_TyconUnspecified:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  default __.VisitTypeDefnKind_TyconUnspecified
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconClass".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconClass:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconClass".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconClass
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconClass(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  abstract member VisitTypeDefnKind_TyconClass:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  default __.VisitTypeDefnKind_TyconClass
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconInterface".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconInterface:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconInterface".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconInterface
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconInterface(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  abstract member VisitTypeDefnKind_TyconInterface:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  default __.VisitTypeDefnKind_TyconInterface
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconStruct".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconStruct:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconStruct".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconStruct
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconStruct(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  abstract member VisitTypeDefnKind_TyconStruct:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  default __.VisitTypeDefnKind_TyconStruct
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconRecord".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconRecord:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconRecord".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconRecord
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconRecord(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  abstract member VisitTypeDefnKind_TyconRecord:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  default __.VisitTypeDefnKind_TyconRecord
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnion".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconUnion:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnion".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconUnion
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconUnion(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  abstract member VisitTypeDefnKind_TyconUnion:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  default __.VisitTypeDefnKind_TyconUnion
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAbbrev".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconAbbrev:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAbbrev".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconAbbrev
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconAbbrev(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  abstract member VisitTypeDefnKind_TyconAbbrev:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  default __.VisitTypeDefnKind_TyconAbbrev
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconHiddenRepr".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconHiddenRepr:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconHiddenRepr".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconHiddenRepr
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconHiddenRepr(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  abstract member VisitTypeDefnKind_TyconHiddenRepr:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  default __.VisitTypeDefnKind_TyconHiddenRepr
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAugmentation".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconAugmentation:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAugmentation".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconAugmentation
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconAugmentation(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  abstract member VisitTypeDefnKind_TyconAugmentation:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  default __.VisitTypeDefnKind_TyconAugmentation
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconILAssemblyCode".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconILAssemblyCode:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconILAssemblyCode".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconILAssemblyCode
     (context: 'TContext) =
    this.VisitTypeDefnKind_TyconILAssemblyCode(
      context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  abstract member VisitTypeDefnKind_TyconILAssemblyCode:
    context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  default __.VisitTypeDefnKind_TyconILAssemblyCode
     (context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconDelegate".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconDelegate:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynValInfo -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconDelegate".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconDelegate
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    this.VisitTypeDefnKind_TyconDelegate(
      context,
      this.VisitType context item1,
      this.VisitValInfo context item2)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  abstract member VisitTypeDefnKind_TyconDelegate:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynType *
    item2: Microsoft.FSharp.Compiler.Ast.SynValInfo -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  default __.VisitTypeDefnKind_TyconDelegate
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynType,
      item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnKind">SynTypeDefnKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnKind
      (context: 'TContext)
      (synTypeDefnKind: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefnKind synTypeDefnKind)
    try
      match synTypeDefnKind with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified ->
        this.BeforeVisitTypeDefnKind_TyconUnspecified(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass ->
        this.BeforeVisitTypeDefnKind_TyconClass(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface ->
        this.BeforeVisitTypeDefnKind_TyconInterface(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct ->
        this.BeforeVisitTypeDefnKind_TyconStruct(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord ->
        this.BeforeVisitTypeDefnKind_TyconRecord(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion ->
        this.BeforeVisitTypeDefnKind_TyconUnion(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev ->
        this.BeforeVisitTypeDefnKind_TyconAbbrev(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr ->
        this.BeforeVisitTypeDefnKind_TyconHiddenRepr(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation ->
        this.BeforeVisitTypeDefnKind_TyconAugmentation(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode ->
        this.BeforeVisitTypeDefnKind_TyconILAssemblyCode(context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
        this.BeforeVisitTypeDefnKind_TyconDelegate(context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_ObjectModel".</remarks>
  abstract member BeforeVisitTypeDefnRepr_ObjectModel:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_ObjectModel".</remarks>
  default this.BeforeVisitTypeDefnRepr_ObjectModel
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnRepr_ObjectModel(
      context,
      this.VisitTypeDefnKind context item1,
      members |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberDefn context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  abstract member VisitTypeDefnRepr_ObjectModel:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  default __.VisitTypeDefnRepr_ObjectModel
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Simple".</remarks>
  abstract member BeforeVisitTypeDefnRepr_Simple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Simple".</remarks>
  default this.BeforeVisitTypeDefnRepr_Simple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnRepr_Simple(
      context,
      this.VisitTypeDefnSimpleRepr context item1,
      range)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  abstract member VisitTypeDefnRepr_Simple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  default __.VisitTypeDefnRepr_Simple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    this.VisitTypeDefnRepr_Exception(
      context,
      this.VisitExceptionDefnRepr context item)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  abstract member VisitTypeDefnRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  default __.VisitTypeDefnRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnRepr">SynTypeDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnRepr
      (context: 'TContext)
      (synTypeDefnRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefnRepr synTypeDefnRepr)
    try
      match synTypeDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
        this.BeforeVisitTypeDefnRepr_ObjectModel(context, item1, members, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnRepr_Simple(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
        this.BeforeVisitTypeDefnRepr_Exception(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig_TypeDefnSig".</remarks>
  abstract member BeforeVisitTypeDefnSig_TypeDefnSig:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig_TypeDefnSig".</remarks>
  default this.BeforeVisitTypeDefnSig_TypeDefnSig
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSig_TypeDefnSig(
      context,
      this.VisitComponentInfo context item1,
      this.VisitTypeDefnSigRepr context item2,
      memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberSig context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  abstract member VisitTypeDefnSig_TypeDefnSig:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo *
    item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  default __.VisitTypeDefnSig_TypeDefnSig
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSig">SynTypeDefnSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSig
      (context: 'TContext)
      (synTypeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefnSig synTypeDefnSig)
    try
      match synTypeDefnSig with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
        this.BeforeVisitTypeDefnSig_TypeDefnSig(context, item1, item2, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_ObjectModel".</remarks>
  abstract member BeforeVisitTypeDefnSigRepr_ObjectModel:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_ObjectModel".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_ObjectModel
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSigRepr_ObjectModel(
      context,
      this.VisitTypeDefnKind context item1,
      memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitMemberSig context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  abstract member VisitTypeDefnSigRepr_ObjectModel:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  default __.VisitTypeDefnSigRepr_ObjectModel
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Simple".</remarks>
  abstract member BeforeVisitTypeDefnSigRepr_Simple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Simple".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_Simple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSigRepr_Simple(
      context,
      this.VisitTypeDefnSimpleRepr context item1,
      range)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  abstract member VisitTypeDefnSigRepr_Simple:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  default __.VisitTypeDefnSigRepr_Simple
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnSigRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    this.VisitTypeDefnSigRepr_Exception(
      context,
      this.VisitExceptionDefnRepr context item)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  abstract member VisitTypeDefnSigRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  default __.VisitTypeDefnSigRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSigRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSigRepr">SynTypeDefnSigRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSigRepr
      (context: 'TContext)
      (synTypeDefnSigRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefnSigRepr synTypeDefnSigRepr)
    try
      match synTypeDefnSigRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
        this.BeforeVisitTypeDefnSigRepr_ObjectModel(context, item1, memberSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnSigRepr_Simple(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSigRepr_Exception(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Union".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Union:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Union".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Union
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_Union(
      context,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      cases |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitUnionCase context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Union:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  default __.VisitTypeDefnSimpleRepr_Union
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Enum".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Enum:
    context: 'TContext *
    cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Enum".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Enum
     (context: 'TContext,
      cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_Enum(
      context,
      cases |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitEnumCase context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Enum:
    context: 'TContext *
    cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  default __.VisitTypeDefnSimpleRepr_Enum
     (context: 'TContext,
      cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Record".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Record:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    fields: Microsoft.FSharp.Compiler.Ast.SynField list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Record".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Record
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      fields: Microsoft.FSharp.Compiler.Ast.SynField list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_Record(
      context,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      fields |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitField context v),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Record:
    context: 'TContext *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    fields: Microsoft.FSharp.Compiler.Ast.SynField list *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  default __.VisitTypeDefnSimpleRepr_Record
     (context: 'TContext,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      fields: Microsoft.FSharp.Compiler.Ast.SynField list,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_General".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_General:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list *
    item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list *
    item4: Microsoft.FSharp.Compiler.Ast.SynField list *
    item5: bool *
    item6: bool *
    item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_General".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_General
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
      item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
      item4: Microsoft.FSharp.Compiler.Ast.SynField list,
      item5: bool,
      item6: bool,
      item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_General(
      context,
      this.VisitTypeDefnKind context item1,
      item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in this.VisitType context v0, v1, v2)),
      item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v = v in this.VisitValSig context v0, v1)),
      item4 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitField context v),
      item5,
      item6,
      item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitSimplePat context v)),
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  abstract member VisitTypeDefnSimpleRepr_General:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind *
    item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list *
    item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list *
    item4: Microsoft.FSharp.Compiler.Ast.SynField list *
    item5: bool *
    item6: bool *
    item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  default __.VisitTypeDefnSimpleRepr_General
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
      item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
      item4: Microsoft.FSharp.Compiler.Ast.SynField list,
      item5: bool,
      item6: bool,
      item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(
      context,
      item1,
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  default __.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_TypeAbbrev".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_TypeAbbrev:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.ParserDetail *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_TypeAbbrev".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_TypeAbbrev(
      context,
      item1,
      this.VisitType context item2,
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  abstract member VisitTypeDefnSimpleRepr_TypeAbbrev:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.ParserDetail *
    item2: Microsoft.FSharp.Compiler.Ast.SynType *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  default __.VisitTypeDefnSimpleRepr_TypeAbbrev
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
      item2: Microsoft.FSharp.Compiler.Ast.SynType,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_None".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_None:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_None".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_None
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitTypeDefnSimpleRepr_None(
      context,
      range)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  abstract member VisitTypeDefnSimpleRepr_None:
    context: 'TContext *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  default __.VisitTypeDefnSimpleRepr_None
     (context: 'TContext,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    this.VisitTypeDefnSimpleRepr_Exception(
      context,
      this.VisitExceptionDefnRepr context item)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Exception:
    context: 'TContext *
    item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  default __.VisitTypeDefnSimpleRepr_Exception
     (context: 'TContext,
      item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSimpleRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSimpleRepr">SynTypeDefnSimpleRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSimpleRepr
      (context: 'TContext)
      (synTypeDefnSimpleRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.TypeDefnSimpleRepr synTypeDefnSimpleRepr)
    try
      match synTypeDefnSimpleRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Union(context, accessiblity, cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Enum(context, cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Record(context, accessiblity, fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_General(context, item1, item2, item3, item4, item5, item6, item7, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev(context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range) ->
        this.BeforeVisitTypeDefnSimpleRepr_None(context, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSimpleRepr_Exception(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase_UnionCase".</remarks>
  abstract member BeforeVisitUnionCase_UnionCase:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase_UnionCase".</remarks>
  default this.BeforeVisitUnionCase_UnionCase
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitUnionCase_UnionCase(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      id,
      this.VisitUnionCaseType context caseType,
      xmlDoc,
      accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      range)

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  abstract member VisitUnionCase_UnionCase:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynUnionCase

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  default __.VisitUnionCase_UnionCase
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range)


  /// <summary>
  /// Visit and dispatch "SynUnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCase">SynUnionCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCase
      (context: 'TContext)
      (synUnionCase: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.UnionCase synUnionCase)
    try
      match synUnionCase with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
        this.BeforeVisitUnionCase_UnionCase(context, attributes, id, caseType, xmlDoc, accessibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFields".</remarks>
  abstract member BeforeVisitUnionCaseType_UnionCaseFields:
    context: 'TContext *
    cases: Microsoft.FSharp.Compiler.Ast.SynField list -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFields".</remarks>
  default this.BeforeVisitUnionCaseType_UnionCaseFields
     (context: 'TContext,
      cases: Microsoft.FSharp.Compiler.Ast.SynField list) =
    this.VisitUnionCaseType_UnionCaseFields(
      context,
      cases |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitField context v))

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  abstract member VisitUnionCaseType_UnionCaseFields:
    context: 'TContext *
    cases: Microsoft.FSharp.Compiler.Ast.SynField list -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  default __.VisitUnionCaseType_UnionCaseFields
     (context: 'TContext,
      cases: Microsoft.FSharp.Compiler.Ast.SynField list) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases)

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFullType".</remarks>
  abstract member BeforeVisitUnionCaseType_UnionCaseFullType:
    context: 'TContext *
    item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFullType".</remarks>
  default this.BeforeVisitUnionCaseType_UnionCaseFullType
     (context: 'TContext,
      item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) =
    this.VisitUnionCaseType_UnionCaseFullType(
      context,
      (let item = item in this.VisitType context v0, this.VisitValInfo context v1))

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  abstract member VisitUnionCaseType_UnionCaseFullType:
    context: 'TContext *
    item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  default __.VisitUnionCaseType_UnionCaseFullType
     (context: 'TContext,
      item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item)


  /// <summary>
  /// Visit and dispatch "SynUnionCaseType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCaseType">SynUnionCaseType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCaseType
      (context: 'TContext)
      (synUnionCaseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.UnionCaseType synUnionCaseType)
    try
      match synUnionCaseType with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
        this.BeforeVisitUnionCaseType_UnionCaseFields(context, cases)
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
        this.BeforeVisitUnionCaseType_UnionCaseFullType(context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValData_SynValData".</remarks>
  abstract member BeforeVisitValData_SynValData:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option *
    item2: Microsoft.FSharp.Compiler.Ast.SynValInfo *
    item3: Microsoft.FSharp.Compiler.Ast.Ident option -> Microsoft.FSharp.Compiler.Ast.SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValData_SynValData".</remarks>
  default this.BeforeVisitValData_SynValData
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
      item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
      item3: Microsoft.FSharp.Compiler.Ast.Ident option) =
    this.VisitValData_SynValData(
      context,
      item1,
      this.VisitValInfo context item2,
      item3)

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  abstract member VisitValData_SynValData:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option *
    item2: Microsoft.FSharp.Compiler.Ast.SynValInfo *
    item3: Microsoft.FSharp.Compiler.Ast.Ident option -> Microsoft.FSharp.Compiler.Ast.SynValData

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  default __.VisitValData_SynValData
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
      item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
      item3: Microsoft.FSharp.Compiler.Ast.Ident option) =
    Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3)


  /// <summary>
  /// Visit and dispatch "SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValData">SynValData expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValData
      (context: 'TContext)
      (synValData: Microsoft.FSharp.Compiler.Ast.SynValData) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ValData synValData)
    try
      match synValData with
      | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
        this.BeforeVisitValData_SynValData(context, item1, item2, item3)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValInfo_SynValInfo".</remarks>
  abstract member BeforeVisitValInfo_SynValInfo:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list *
    item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo -> Microsoft.FSharp.Compiler.Ast.SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValInfo_SynValInfo".</remarks>
  default this.BeforeVisitValInfo_SynValInfo
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
      item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    this.VisitValInfo_SynValInfo(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitArgInfo context v)),
      this.VisitArgInfo context item2)

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  abstract member VisitValInfo_SynValInfo:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list *
    item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo -> Microsoft.FSharp.Compiler.Ast.SynValInfo

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  default __.VisitValInfo_SynValInfo
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
      item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValInfo">SynValInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValInfo
      (context: 'TContext)
      (synValInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ValInfo synValInfo)
    try
      match synValInfo with
      | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
        this.BeforeVisitValInfo_SynValInfo(context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSig_ValSpfn".</remarks>
  abstract member BeforeVisitValSig_ValSpfn:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo *
    item6: bool *
    isMutable: bool *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSig_ValSpfn".</remarks>
  default this.BeforeVisitValSig_ValSpfn
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo,
      item6: bool,
      isMutable: bool,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    this.VisitValSig_ValSpfn(
      context,
      attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute (v.TypeName) (this.VisitExpr context v.ArgExpr) (v.Target) (v.AppliesToGetterAndSetter) (v.Range)),
      id,
      this.VisitValTyparDecls context typeParams,
      this.VisitType context typeName,
      this.VisitValInfo context valInfo,
      item6,
      isMutable,
      xmlDoc,
      accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitAccess context v),
      expr |> Microsoft.FSharp.Core.Option.map (fun v -> this.VisitExpr context v),
      range)

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  abstract member VisitValSig_ValSpfn:
    context: 'TContext *
    attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list *
    id: Microsoft.FSharp.Compiler.Ast.Ident *
    typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls *
    typeName: Microsoft.FSharp.Compiler.Ast.SynType *
    valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo *
    item6: bool *
    isMutable: bool *
    xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc *
    accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option *
    expr: Microsoft.FSharp.Compiler.Ast.SynExpr option *
    range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynValSig

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  default __.VisitValSig_ValSpfn
     (context: 'TContext,
      attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
      id: Microsoft.FSharp.Compiler.Ast.Ident,
      typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls,
      typeName: Microsoft.FSharp.Compiler.Ast.SynType,
      valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo,
      item6: bool,
      isMutable: bool,
      xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
      accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
      expr: Microsoft.FSharp.Compiler.Ast.SynExpr option,
      range: Microsoft.FSharp.Compiler.Range.range) =
    Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)


  /// <summary>
  /// Visit and dispatch "SynValSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValSig">SynValSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValSig
      (context: 'TContext)
      (synValSig: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ValSig synValSig)
    try
      match synValSig with
      | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
        this.BeforeVisitValSig_ValSpfn(context, attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValTyparDecls_SynValTyparDecls".</remarks>
  abstract member BeforeVisitValTyparDecls_SynValTyparDecls:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list *
    item2: bool *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list -> Microsoft.FSharp.Compiler.Ast.SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValTyparDecls_SynValTyparDecls".</remarks>
  default this.BeforeVisitValTyparDecls_SynValTyparDecls
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
      item2: bool,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) =
    this.VisitValTyparDecls_SynValTyparDecls(
      context,
      item1 |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTyparDecl context v),
      item2,
      constraints |> Microsoft.FSharp.Collections.List.map (fun v -> this.VisitTypeConstraint context v))

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  abstract member VisitValTyparDecls_SynValTyparDecls:
    context: 'TContext *
    item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list *
    item2: bool *
    constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list -> Microsoft.FSharp.Compiler.Ast.SynValTyparDecls

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  default __.VisitValTyparDecls_SynValTyparDecls
     (context: 'TContext,
      item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
      item2: bool,
      constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) =
    Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints)


  /// <summary>
  /// Visit and dispatch "SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValTyparDecls">SynValTyparDecls expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValTyparDecls
      (context: 'TContext)
      (synValTyparDecls: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.AstElement.ValTyparDecls synValTyparDecls)
    try
      match synValTyparDecls with
      | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
        this.BeforeVisitValTyparDecls_SynValTyparDecls(context, item1, item2, constraints)
    finally
      parents.Pop() |> ignore

