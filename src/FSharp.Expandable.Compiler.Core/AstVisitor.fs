//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Wed, 03 Aug 2016 06:04:30 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

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
  abstract member BeforeVisitAccess_Public: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Public".</remarks>
  default this.BeforeVisitAccess_Public(context: 'TContext) =
    this.VisitAccess_Public(context)

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  abstract member VisitAccess_Public: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  default __.VisitAccess_Public(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Public

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Internal".</remarks>
  abstract member BeforeVisitAccess_Internal: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Internal".</remarks>
  default this.BeforeVisitAccess_Internal(context: 'TContext) =
    this.VisitAccess_Internal(context)

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  abstract member VisitAccess_Internal: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  default __.VisitAccess_Internal(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Internal

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Private".</remarks>
  abstract member BeforeVisitAccess_Private: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Private".</remarks>
  default this.BeforeVisitAccess_Private(context: 'TContext) =
    this.VisitAccess_Private(context)

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  abstract member VisitAccess_Private: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynAccess

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  default __.VisitAccess_Private(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Private


  /// <summary>
  /// Visit and dispatch "SynAccess" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synAccess">SynAccess expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitAccess (context: 'TContext) (synAccess: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    parents.Push(AstElement.Access synAccess)
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
  abstract member BeforeVisitArgInfo_SynArgInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * optional: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArgInfo_SynArgInfo".</remarks>
  default this.BeforeVisitArgInfo_SynArgInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, optional: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    this.VisitArgInfo_SynArgInfo(attributes, optional, id, context)

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  abstract member VisitArgInfo_SynArgInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * optional: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynArgInfo

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  default __.VisitArgInfo_SynArgInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, optional: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id)


  /// <summary>
  /// Visit and dispatch "SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synArgInfo">SynArgInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitArgInfo (context: 'TContext) (synArgInfo: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    parents.Push(AstElement.ArgInfo synArgInfo)
    try
      match synArgInfo with
      | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
        this.BeforeVisitArgInfo_SynArgInfo(attributes, optional, id, context)
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
  abstract member BeforeVisitBinding_Binding: access: Microsoft.FSharp.Compiler.Ast.SynAccess option * bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind * mustInline: bool * isMutable: bool * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * item7: Microsoft.FSharp.Compiler.Ast.SynValData * headPat: Microsoft.FSharp.Compiler.Ast.SynPat * item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * lhsRange: Microsoft.FSharp.Compiler.Range.range * spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding_Binding".</remarks>
  default this.BeforeVisitBinding_Binding(access: Microsoft.FSharp.Compiler.Ast.SynAccess option, bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind, mustInline: bool, isMutable: bool, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, item7: Microsoft.FSharp.Compiler.Ast.SynValData, headPat: Microsoft.FSharp.Compiler.Ast.SynPat, item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, lhsRange: Microsoft.FSharp.Compiler.Range.range, spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, context: 'TContext) =
    this.VisitBinding_Binding(access |> (Option.map (this.VisitAccess context)), bindingKind |> (this.VisitBindingKind context), mustInline, isMutable, attributes, xmlDoc, item7 |> (this.VisitValData context), headPat |> (this.VisitPat context), item9 |> (Option.map (this.VisitBindingReturnInfo context)), expr |> (this.VisitExpr context), lhsRange, spBind, context)

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  abstract member VisitBinding_Binding: access: Microsoft.FSharp.Compiler.Ast.SynAccess option * bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind * mustInline: bool * isMutable: bool * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * item7: Microsoft.FSharp.Compiler.Ast.SynValData * headPat: Microsoft.FSharp.Compiler.Ast.SynPat * item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * lhsRange: Microsoft.FSharp.Compiler.Range.range * spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBinding

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  default __.VisitBinding_Binding(access: Microsoft.FSharp.Compiler.Ast.SynAccess option, bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind, mustInline: bool, isMutable: bool, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, item7: Microsoft.FSharp.Compiler.Ast.SynValData, headPat: Microsoft.FSharp.Compiler.Ast.SynPat, item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, lhsRange: Microsoft.FSharp.Compiler.Range.range, spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)


  /// <summary>
  /// Visit and dispatch "SynBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBinding">SynBinding expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBinding (context: 'TContext) (synBinding: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    parents.Push(AstElement.Binding synBinding)
    try
      match synBinding with
      | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
        this.BeforeVisitBinding_Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind, context)
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
  abstract member BeforeVisitBindingKind_StandaloneExpression: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_StandaloneExpression".</remarks>
  default this.BeforeVisitBindingKind_StandaloneExpression(context: 'TContext) =
    this.VisitBindingKind_StandaloneExpression(context)

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  abstract member VisitBindingKind_StandaloneExpression: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  default __.VisitBindingKind_StandaloneExpression(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_NormalBinding".</remarks>
  abstract member BeforeVisitBindingKind_NormalBinding: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_NormalBinding".</remarks>
  default this.BeforeVisitBindingKind_NormalBinding(context: 'TContext) =
    this.VisitBindingKind_NormalBinding(context)

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  abstract member VisitBindingKind_NormalBinding: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  default __.VisitBindingKind_NormalBinding(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_DoBinding".</remarks>
  abstract member BeforeVisitBindingKind_DoBinding: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_DoBinding".</remarks>
  default this.BeforeVisitBindingKind_DoBinding(context: 'TContext) =
    this.VisitBindingKind_DoBinding(context)

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  abstract member VisitBindingKind_DoBinding: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingKind

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  default __.VisitBindingKind_DoBinding(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding


  /// <summary>
  /// Visit and dispatch "SynBindingKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingKind">SynBindingKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingKind (context: 'TContext) (synBindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    parents.Push(AstElement.BindingKind synBindingKind)
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
  abstract member BeforeVisitBindingReturnInfo_SynBindingReturnInfo: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingReturnInfo_SynBindingReturnInfo".</remarks>
  default this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, context: 'TContext) =
    this.VisitBindingReturnInfo_SynBindingReturnInfo(typeName |> (this.VisitType context), range, attributes, context)

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  abstract member VisitBindingReturnInfo_SynBindingReturnInfo: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  default __.VisitBindingReturnInfo_SynBindingReturnInfo(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes)


  /// <summary>
  /// Visit and dispatch "SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingReturnInfo">SynBindingReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingReturnInfo (context: 'TContext) (synBindingReturnInfo: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    parents.Push(AstElement.BindingReturnInfo synBindingReturnInfo)
    try
      match synBindingReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
        this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo(typeName, range, attributes, context)
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
  abstract member BeforeVisitComponentInfo_ComponentInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * item4: Microsoft.FSharp.Compiler.Ast.Ident list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * preferPostfix: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo_ComponentInfo".</remarks>
  default this.BeforeVisitComponentInfo_ComponentInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, item4: Microsoft.FSharp.Compiler.Ast.Ident list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, preferPostfix: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitComponentInfo_ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  abstract member VisitComponentInfo_ComponentInfo: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * item4: Microsoft.FSharp.Compiler.Ast.Ident list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * preferPostfix: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynComponentInfo

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  default __.VisitComponentInfo_ComponentInfo(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, item4: Microsoft.FSharp.Compiler.Ast.Ident list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, preferPostfix: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synComponentInfo">SynComponentInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitComponentInfo (context: 'TContext) (synComponentInfo: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    parents.Push(AstElement.ComponentInfo synComponentInfo)
    try
      match synComponentInfo with
      | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
        this.BeforeVisitComponentInfo_ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range, context)
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
  abstract member BeforeVisitConst_Unit: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Unit".</remarks>
  default this.BeforeVisitConst_Unit(context: 'TContext) =
    this.VisitConst_Unit(context)

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  abstract member VisitConst_Unit: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  default __.VisitConst_Unit(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Unit

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bool".</remarks>
  abstract member BeforeVisitConst_Bool: item: bool * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bool".</remarks>
  default this.BeforeVisitConst_Bool(item: bool, context: 'TContext) =
    this.VisitConst_Bool(item, context)

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  abstract member VisitConst_Bool: item: bool * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  default __.VisitConst_Bool(item: bool, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item)

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_SByte".</remarks>
  abstract member BeforeVisitConst_SByte: item: System.SByte * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_SByte".</remarks>
  default this.BeforeVisitConst_SByte(item: System.SByte, context: 'TContext) =
    this.VisitConst_SByte(item, context)

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  abstract member VisitConst_SByte: item: System.SByte * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  default __.VisitConst_SByte(item: System.SByte, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item)

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Byte".</remarks>
  abstract member BeforeVisitConst_Byte: item: System.Byte * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Byte".</remarks>
  default this.BeforeVisitConst_Byte(item: System.Byte, context: 'TContext) =
    this.VisitConst_Byte(item, context)

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  abstract member VisitConst_Byte: item: System.Byte * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  default __.VisitConst_Byte(item: System.Byte, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item)

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int16".</remarks>
  abstract member BeforeVisitConst_Int16: item: System.Int16 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int16".</remarks>
  default this.BeforeVisitConst_Int16(item: System.Int16, context: 'TContext) =
    this.VisitConst_Int16(item, context)

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  abstract member VisitConst_Int16: item: System.Int16 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  default __.VisitConst_Int16(item: System.Int16, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item)

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16".</remarks>
  abstract member BeforeVisitConst_UInt16: item: System.UInt16 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16".</remarks>
  default this.BeforeVisitConst_UInt16(item: System.UInt16, context: 'TContext) =
    this.VisitConst_UInt16(item, context)

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  abstract member VisitConst_UInt16: item: System.UInt16 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  default __.VisitConst_UInt16(item: System.UInt16, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item)

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int32".</remarks>
  abstract member BeforeVisitConst_Int32: item: int * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int32".</remarks>
  default this.BeforeVisitConst_Int32(item: int, context: 'TContext) =
    this.VisitConst_Int32(item, context)

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  abstract member VisitConst_Int32: item: int * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  default __.VisitConst_Int32(item: int, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item)

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt32".</remarks>
  abstract member BeforeVisitConst_UInt32: item: System.UInt32 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt32".</remarks>
  default this.BeforeVisitConst_UInt32(item: System.UInt32, context: 'TContext) =
    this.VisitConst_UInt32(item, context)

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  abstract member VisitConst_UInt32: item: System.UInt32 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  default __.VisitConst_UInt32(item: System.UInt32, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item)

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int64".</remarks>
  abstract member BeforeVisitConst_Int64: item: int64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int64".</remarks>
  default this.BeforeVisitConst_Int64(item: int64, context: 'TContext) =
    this.VisitConst_Int64(item, context)

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  abstract member VisitConst_Int64: item: int64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  default __.VisitConst_Int64(item: int64, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item)

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt64".</remarks>
  abstract member BeforeVisitConst_UInt64: item: System.UInt64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt64".</remarks>
  default this.BeforeVisitConst_UInt64(item: System.UInt64, context: 'TContext) =
    this.VisitConst_UInt64(item, context)

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  abstract member VisitConst_UInt64: item: System.UInt64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  default __.VisitConst_UInt64(item: System.UInt64, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item)

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_IntPtr".</remarks>
  abstract member BeforeVisitConst_IntPtr: item: int64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_IntPtr".</remarks>
  default this.BeforeVisitConst_IntPtr(item: int64, context: 'TContext) =
    this.VisitConst_IntPtr(item, context)

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  abstract member VisitConst_IntPtr: item: int64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  default __.VisitConst_IntPtr(item: int64, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item)

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UIntPtr".</remarks>
  abstract member BeforeVisitConst_UIntPtr: item: System.UInt64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UIntPtr".</remarks>
  default this.BeforeVisitConst_UIntPtr(item: System.UInt64, context: 'TContext) =
    this.VisitConst_UIntPtr(item, context)

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  abstract member VisitConst_UIntPtr: item: System.UInt64 * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  default __.VisitConst_UIntPtr(item: System.UInt64, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item)

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Single".</remarks>
  abstract member BeforeVisitConst_Single: item: System.Single * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Single".</remarks>
  default this.BeforeVisitConst_Single(item: System.Single, context: 'TContext) =
    this.VisitConst_Single(item, context)

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  abstract member VisitConst_Single: item: System.Single * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  default __.VisitConst_Single(item: System.Single, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Single(item)

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Double".</remarks>
  abstract member BeforeVisitConst_Double: item: System.Double * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Double".</remarks>
  default this.BeforeVisitConst_Double(item: System.Double, context: 'TContext) =
    this.VisitConst_Double(item, context)

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  abstract member VisitConst_Double: item: System.Double * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  default __.VisitConst_Double(item: System.Double, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Double(item)

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Char".</remarks>
  abstract member BeforeVisitConst_Char: item: System.Char * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Char".</remarks>
  default this.BeforeVisitConst_Char(item: System.Char, context: 'TContext) =
    this.VisitConst_Char(item, context)

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  abstract member VisitConst_Char: item: System.Char * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  default __.VisitConst_Char(item: System.Char, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Char(item)

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Decimal".</remarks>
  abstract member BeforeVisitConst_Decimal: item: System.Decimal * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Decimal".</remarks>
  default this.BeforeVisitConst_Decimal(item: System.Decimal, context: 'TContext) =
    this.VisitConst_Decimal(item, context)

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  abstract member VisitConst_Decimal: item: System.Decimal * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  default __.VisitConst_Decimal(item: System.Decimal, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item)

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UserNum".</remarks>
  abstract member BeforeVisitConst_UserNum: item: (string * string) * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UserNum".</remarks>
  default this.BeforeVisitConst_UserNum(item: (string * string), context: 'TContext) =
    this.VisitConst_UserNum(item, context)

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  abstract member VisitConst_UserNum: item: (string * string) * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  default __.VisitConst_UserNum(item: (string * string), context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item)

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_String".</remarks>
  abstract member BeforeVisitConst_String: text: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_String".</remarks>
  default this.BeforeVisitConst_String(text: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitConst_String(text, range, context)

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  abstract member VisitConst_String: text: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  default __.VisitConst_String(text: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range)

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bytes".</remarks>
  abstract member BeforeVisitConst_Bytes: bytes: System.Byte[] * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bytes".</remarks>
  default this.BeforeVisitConst_Bytes(bytes: System.Byte[], range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitConst_Bytes(bytes, range, context)

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  abstract member VisitConst_Bytes: bytes: System.Byte[] * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  default __.VisitConst_Bytes(bytes: System.Byte[], range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range)

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16s".</remarks>
  abstract member BeforeVisitConst_UInt16s: item: System.UInt16[] * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16s".</remarks>
  default this.BeforeVisitConst_UInt16s(item: System.UInt16[], context: 'TContext) =
    this.VisitConst_UInt16s(item, context)

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  abstract member VisitConst_UInt16s: item: System.UInt16[] * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  default __.VisitConst_UInt16s(item: System.UInt16[], context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item)

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Measure".</remarks>
  abstract member BeforeVisitConst_Measure: constant: Microsoft.FSharp.Compiler.Ast.SynConst * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Measure".</remarks>
  default this.BeforeVisitConst_Measure(constant: Microsoft.FSharp.Compiler.Ast.SynConst, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, context: 'TContext) =
    this.VisitConst_Measure(constant |> (this.VisitConst context), item2 |> (this.VisitMeasure context), context)

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  abstract member VisitConst_Measure: constant: Microsoft.FSharp.Compiler.Ast.SynConst * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConst

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  default __.VisitConst_Measure(constant: Microsoft.FSharp.Compiler.Ast.SynConst, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2)


  /// <summary>
  /// Visit and dispatch "SynConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConst">SynConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConst (context: 'TContext) (synConst: Microsoft.FSharp.Compiler.Ast.SynConst) =
    parents.Push(AstElement.Const synConst)
    try
      match synConst with
      | Microsoft.FSharp.Compiler.Ast.SynConst.Unit ->
        this.BeforeVisitConst_Unit(context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item) ->
        this.BeforeVisitConst_Bool(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item) ->
        this.BeforeVisitConst_SByte(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item) ->
        this.BeforeVisitConst_Byte(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item) ->
        this.BeforeVisitConst_Int16(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item) ->
        this.BeforeVisitConst_UInt16(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item) ->
        this.BeforeVisitConst_Int32(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item) ->
        this.BeforeVisitConst_UInt32(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item) ->
        this.BeforeVisitConst_Int64(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item) ->
        this.BeforeVisitConst_UInt64(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item) ->
        this.BeforeVisitConst_IntPtr(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item) ->
        this.BeforeVisitConst_UIntPtr(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Single(item) ->
        this.BeforeVisitConst_Single(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Double(item) ->
        this.BeforeVisitConst_Double(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Char(item) ->
        this.BeforeVisitConst_Char(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item) ->
        this.BeforeVisitConst_Decimal(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item) ->
        this.BeforeVisitConst_UserNum(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range) ->
        this.BeforeVisitConst_String(text, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range) ->
        this.BeforeVisitConst_Bytes(bytes, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item) ->
        this.BeforeVisitConst_UInt16s(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
        this.BeforeVisitConst_Measure(constant, item2, context)
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
  abstract member BeforeVisitConstructorArgs_Pats: item: Microsoft.FSharp.Compiler.Ast.SynPat list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_Pats".</remarks>
  default this.BeforeVisitConstructorArgs_Pats(item: Microsoft.FSharp.Compiler.Ast.SynPat list, context: 'TContext) =
    this.VisitConstructorArgs_Pats(item, context)

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  abstract member VisitConstructorArgs_Pats: item: Microsoft.FSharp.Compiler.Ast.SynPat list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  default __.VisitConstructorArgs_Pats(item: Microsoft.FSharp.Compiler.Ast.SynPat list, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item)

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_NamePatPairs".</remarks>
  abstract member BeforeVisitConstructorArgs_NamePatPairs: item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_NamePatPairs".</remarks>
  default this.BeforeVisitConstructorArgs_NamePatPairs(item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitConstructorArgs_NamePatPairs(item1, range, context)

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  abstract member VisitConstructorArgs_NamePatPairs: item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  default __.VisitConstructorArgs_NamePatPairs(item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range)


  /// <summary>
  /// Visit and dispatch "SynConstructorArgs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConstructorArgs">SynConstructorArgs expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConstructorArgs (context: 'TContext) (synConstructorArgs: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    parents.Push(AstElement.ConstructorArgs synConstructorArgs)
    try
      match synConstructorArgs with
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
        this.BeforeVisitConstructorArgs_Pats(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
        this.BeforeVisitConstructorArgs_NamePatPairs(item1, range, context)
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
  abstract member BeforeVisitEnumCase_EnumCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * item3: Microsoft.FSharp.Compiler.Ast.SynConst * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase_EnumCase".</remarks>
  default this.BeforeVisitEnumCase_EnumCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, item3: Microsoft.FSharp.Compiler.Ast.SynConst, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitEnumCase_EnumCase(attributes, id, item3 |> (this.VisitConst context), xmlDoc, range, context)

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  abstract member VisitEnumCase_EnumCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * item3: Microsoft.FSharp.Compiler.Ast.SynConst * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynEnumCase

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  default __.VisitEnumCase_EnumCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, item3: Microsoft.FSharp.Compiler.Ast.SynConst, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range)


  /// <summary>
  /// Visit and dispatch "SynEnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synEnumCase">SynEnumCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitEnumCase (context: 'TContext) (synEnumCase: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    parents.Push(AstElement.EnumCase synEnumCase)
    try
      match synEnumCase with
      | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
        this.BeforeVisitEnumCase_EnumCase(attributes, id, item3, xmlDoc, range, context)
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
  abstract member BeforeVisitExceptionDefn_SynExceptionDefn: exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefn_SynExceptionDefn".</remarks>
  default this.BeforeVisitExceptionDefn_SynExceptionDefn(exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExceptionDefn_SynExceptionDefn(exnRepr |> (this.VisitExceptionDefnRepr context), members, range, context)

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  abstract member VisitExceptionDefn_SynExceptionDefn: exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefn

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  default __.VisitExceptionDefn_SynExceptionDefn(exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefn">SynExceptionDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefn (context: 'TContext) (synExceptionDefn: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    parents.Push(AstElement.ExceptionDefn synExceptionDefn)
    try
      match synExceptionDefn with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
        this.BeforeVisitExceptionDefn_SynExceptionDefn(exnRepr, members, range, context)
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
  abstract member BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * case: Microsoft.FSharp.Compiler.Ast.SynUnionCase * longId: Microsoft.FSharp.Compiler.Ast.Ident list option * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefnRepr_SynExceptionDefnRepr".</remarks>
  default this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, case: Microsoft.FSharp.Compiler.Ast.SynUnionCase, longId: Microsoft.FSharp.Compiler.Ast.Ident list option, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExceptionDefnRepr_SynExceptionDefnRepr(item1, case |> (this.VisitUnionCase context), longId, xmlDoc, accesibility |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  abstract member VisitExceptionDefnRepr_SynExceptionDefnRepr: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * case: Microsoft.FSharp.Compiler.Ast.SynUnionCase * longId: Microsoft.FSharp.Compiler.Ast.Ident list option * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  default __.VisitExceptionDefnRepr_SynExceptionDefnRepr(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, case: Microsoft.FSharp.Compiler.Ast.SynUnionCase, longId: Microsoft.FSharp.Compiler.Ast.Ident list option, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefnRepr">SynExceptionDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefnRepr (context: 'TContext) (synExceptionDefnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    parents.Push(AstElement.ExceptionDefnRepr synExceptionDefnRepr)
    try
      match synExceptionDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
        this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range, context)
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
  abstract member BeforeVisitExceptionSig_SynExceptionSig: exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionSig_SynExceptionSig".</remarks>
  default this.BeforeVisitExceptionSig_SynExceptionSig(exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExceptionSig_SynExceptionSig(exnRepr |> (this.VisitExceptionDefnRepr context), memberSigs, range, context)

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  abstract member VisitExceptionSig_SynExceptionSig: exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExceptionSig

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  default __.VisitExceptionSig_SynExceptionSig(exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionSig">SynExceptionSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionSig (context: 'TContext) (synExceptionSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    parents.Push(AstElement.ExceptionSig synExceptionSig)
    try
      match synExceptionSig with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
        this.BeforeVisitExceptionSig_SynExceptionSig(exnRepr, memberSigs, range, context)
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
  abstract member BeforeVisitExpr_Paren: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * leftParenRange: Microsoft.FSharp.Compiler.Range.range * rightParenRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Paren".</remarks>
  default this.BeforeVisitExpr_Paren(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, leftParenRange: Microsoft.FSharp.Compiler.Range.range, rightParenRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Paren(expr |> (this.VisitExpr context), leftParenRange, rightParenRange, range, context)

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  abstract member VisitExpr_Paren: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * leftParenRange: Microsoft.FSharp.Compiler.Range.range * rightParenRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  default __.VisitExpr_Paren(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, leftParenRange: Microsoft.FSharp.Compiler.Range.range, rightParenRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Quote".</remarks>
  abstract member BeforeVisitExpr_Quote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr * isRaw: bool * quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * isFromQueryExpression: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Quote".</remarks>
  default this.BeforeVisitExpr_Quote(operator: Microsoft.FSharp.Compiler.Ast.SynExpr, isRaw: bool, quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, isFromQueryExpression: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Quote(operator |> (this.VisitExpr context), isRaw, quotedSynExpr |> (this.VisitExpr context), isFromQueryExpression, range, context)

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  abstract member VisitExpr_Quote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr * isRaw: bool * quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * isFromQueryExpression: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  default __.VisitExpr_Quote(operator: Microsoft.FSharp.Compiler.Ast.SynExpr, isRaw: bool, quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, isFromQueryExpression: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Const".</remarks>
  abstract member BeforeVisitExpr_Const: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Const".</remarks>
  default this.BeforeVisitExpr_Const(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Const(constant |> (this.VisitConst context), range, context)

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  abstract member VisitExpr_Const: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  default __.VisitExpr_Const(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range)

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Typed".</remarks>
  abstract member BeforeVisitExpr_Typed: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Typed".</remarks>
  default this.BeforeVisitExpr_Typed(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Typed(expr |> (this.VisitExpr context), typeSig |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  abstract member VisitExpr_Typed: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  default __.VisitExpr_Typed(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Tuple".</remarks>
  abstract member BeforeVisitExpr_Tuple: exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Tuple".</remarks>
  default this.BeforeVisitExpr_Tuple(exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Tuple(exprs, commaRanges, range, context)

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  abstract member VisitExpr_Tuple: exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  default __.VisitExpr_Tuple(exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrList".</remarks>
  abstract member BeforeVisitExpr_ArrayOrList: isList: bool * exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrList".</remarks>
  default this.BeforeVisitExpr_ArrayOrList(isList: bool, exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ArrayOrList(isList, exprs, range, context)

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  abstract member VisitExpr_ArrayOrList: isList: bool * exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  default __.VisitExpr_ArrayOrList(isList: bool, exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range)

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Record".</remarks>
  abstract member BeforeVisitExpr_Record: baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option * copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option * recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Record".</remarks>
  default this.BeforeVisitExpr_Record(baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option, copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option, recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Record(baseInfo, copyInfo, recordFields, range, context)

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  abstract member VisitExpr_Record: baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option * copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option * recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  default __.VisitExpr_Record(baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option, copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option, recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_New".</remarks>
  abstract member BeforeVisitExpr_New: isProtected: bool * typeName: Microsoft.FSharp.Compiler.Ast.SynType * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_New".</remarks>
  default this.BeforeVisitExpr_New(isProtected: bool, typeName: Microsoft.FSharp.Compiler.Ast.SynType, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_New(isProtected, typeName |> (this.VisitType context), expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  abstract member VisitExpr_New: isProtected: bool * typeName: Microsoft.FSharp.Compiler.Ast.SynType * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  default __.VisitExpr_New(isProtected: bool, typeName: Microsoft.FSharp.Compiler.Ast.SynType, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range)

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ObjExpr".</remarks>
  abstract member BeforeVisitExpr_ObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType * argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list * newPos: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ObjExpr".</remarks>
  default this.BeforeVisitExpr_ObjExpr(objType: Microsoft.FSharp.Compiler.Ast.SynType, argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list, newPos: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ObjExpr(objType |> (this.VisitType context), argOpt, bindings, extraImpls, newPos, range, context)

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  abstract member VisitExpr_ObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType * argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list * newPos: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  default __.VisitExpr_ObjExpr(objType: Microsoft.FSharp.Compiler.Ast.SynType, argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list, newPos: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_While".</remarks>
  abstract member BeforeVisitExpr_While: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop * whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr * doBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_While".</remarks>
  default this.BeforeVisitExpr_While(spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop, whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr, doBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_While(spWhile, whileBody |> (this.VisitExpr context), doBody |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  abstract member VisitExpr_While: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop * whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr * doBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  default __.VisitExpr_While(spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop, whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr, doBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_For".</remarks>
  abstract member BeforeVisitExpr_For: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop * id: Microsoft.FSharp.Compiler.Ast.Ident * idBody: Microsoft.FSharp.Compiler.Ast.SynExpr * item4: bool * toBody: Microsoft.FSharp.Compiler.Ast.SynExpr * doBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_For".</remarks>
  default this.BeforeVisitExpr_For(spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop, id: Microsoft.FSharp.Compiler.Ast.Ident, idBody: Microsoft.FSharp.Compiler.Ast.SynExpr, item4: bool, toBody: Microsoft.FSharp.Compiler.Ast.SynExpr, doBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_For(spFor, id, idBody |> (this.VisitExpr context), item4, toBody |> (this.VisitExpr context), doBody |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  abstract member VisitExpr_For: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop * id: Microsoft.FSharp.Compiler.Ast.Ident * idBody: Microsoft.FSharp.Compiler.Ast.SynExpr * item4: bool * toBody: Microsoft.FSharp.Compiler.Ast.SynExpr * doBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  default __.VisitExpr_For(spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop, id: Microsoft.FSharp.Compiler.Ast.Ident, idBody: Microsoft.FSharp.Compiler.Ast.SynExpr, item4: bool, toBody: Microsoft.FSharp.Compiler.Ast.SynExpr, doBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ForEach".</remarks>
  abstract member BeforeVisitExpr_ForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop * seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly * isFromSource: bool * pattern: Microsoft.FSharp.Compiler.Ast.SynPat * enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ForEach".</remarks>
  default this.BeforeVisitExpr_ForEach(spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop, seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly, isFromSource: bool, pattern: Microsoft.FSharp.Compiler.Ast.SynPat, enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ForEach(spFor, seqExprOnly, isFromSource, pattern |> (this.VisitPat context), enumExpr |> (this.VisitExpr context), bodyExpr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  abstract member VisitExpr_ForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop * seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly * isFromSource: bool * pattern: Microsoft.FSharp.Compiler.Ast.SynPat * enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  default __.VisitExpr_ForEach(spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop, seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly, isFromSource: bool, pattern: Microsoft.FSharp.Compiler.Ast.SynPat, enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitExpr_ArrayOrListOfSeqExpr: isList: bool * elements: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitExpr_ArrayOrListOfSeqExpr(isList: bool, elements: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ArrayOrListOfSeqExpr(isList, elements |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  abstract member VisitExpr_ArrayOrListOfSeqExpr: isList: bool * elements: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  default __.VisitExpr_ArrayOrListOfSeqExpr(isList: bool, elements: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_CompExpr".</remarks>
  abstract member BeforeVisitExpr_CompExpr: isArrayOrList: bool * isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_CompExpr".</remarks>
  default this.BeforeVisitExpr_CompExpr(isArrayOrList: bool, isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool>, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_CompExpr(isArrayOrList, isNotNakedRefCell, expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  abstract member VisitExpr_CompExpr: isArrayOrList: bool * isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  default __.VisitExpr_CompExpr(isArrayOrList: bool, isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool>, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lambda".</remarks>
  abstract member BeforeVisitExpr_Lambda: fromMethod: bool * inLambdaSeq: bool * args: Microsoft.FSharp.Compiler.Ast.SynSimplePats * body: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lambda".</remarks>
  default this.BeforeVisitExpr_Lambda(fromMethod: bool, inLambdaSeq: bool, args: Microsoft.FSharp.Compiler.Ast.SynSimplePats, body: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Lambda(fromMethod, inLambdaSeq, args |> (this.VisitSimplePats context), body |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  abstract member VisitExpr_Lambda: fromMethod: bool * inLambdaSeq: bool * args: Microsoft.FSharp.Compiler.Ast.SynSimplePats * body: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  default __.VisitExpr_Lambda(fromMethod: bool, inLambdaSeq: bool, args: Microsoft.FSharp.Compiler.Ast.SynSimplePats, body: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_MatchLambda".</remarks>
  abstract member BeforeVisitExpr_MatchLambda: item1: bool * item2: Microsoft.FSharp.Compiler.Range.range * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_MatchLambda".</remarks>
  default this.BeforeVisitExpr_MatchLambda(item1: bool, item2: Microsoft.FSharp.Compiler.Range.range, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_MatchLambda(item1, item2, clauses, spBind, range, context)

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  abstract member VisitExpr_MatchLambda: item1: bool * item2: Microsoft.FSharp.Compiler.Range.range * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  default __.VisitExpr_MatchLambda(item1: bool, item2: Microsoft.FSharp.Compiler.Range.range, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range)

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Match".</remarks>
  abstract member BeforeVisitExpr_Match: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * isCexprExceptionMatch: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Match".</remarks>
  default this.BeforeVisitExpr_Match(spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, isCexprExceptionMatch: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Match(spBind, matchExpr |> (this.VisitExpr context), clauses, isCexprExceptionMatch, range, context)

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  abstract member VisitExpr_Match: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * isCexprExceptionMatch: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  default __.VisitExpr_Match(spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, isCexprExceptionMatch: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Do".</remarks>
  abstract member BeforeVisitExpr_Do: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Do".</remarks>
  default this.BeforeVisitExpr_Do(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Do(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  abstract member VisitExpr_Do: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  default __.VisitExpr_Do(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Assert".</remarks>
  abstract member BeforeVisitExpr_Assert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Assert".</remarks>
  default this.BeforeVisitExpr_Assert(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Assert(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  abstract member VisitExpr_Assert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  default __.VisitExpr_Assert(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range)

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_App".</remarks>
  abstract member BeforeVisitExpr_App: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag * isInfix: bool * funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_App".</remarks>
  default this.BeforeVisitExpr_App(exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag, isInfix: bool, funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_App(exprAtomicFlag, isInfix, funcExpr |> (this.VisitExpr context), argExpr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  abstract member VisitExpr_App: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag * isInfix: bool * funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  default __.VisitExpr_App(exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag, isInfix: bool, funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeApp".</remarks>
  abstract member BeforeVisitExpr_TypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * leftAngleRange: Microsoft.FSharp.Compiler.Range.range * typeNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeApp".</remarks>
  default this.BeforeVisitExpr_TypeApp(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, leftAngleRange: Microsoft.FSharp.Compiler.Range.range, typeNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_TypeApp(expr |> (this.VisitExpr context), leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range, context)

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  abstract member VisitExpr_TypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * leftAngleRange: Microsoft.FSharp.Compiler.Range.range * typeNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  default __.VisitExpr_TypeApp(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, leftAngleRange: Microsoft.FSharp.Compiler.Range.range, typeNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUse".</remarks>
  abstract member BeforeVisitExpr_LetOrUse: isRecursive: bool * isUse: bool * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUse".</remarks>
  default this.BeforeVisitExpr_LetOrUse(isRecursive: bool, isUse: bool, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LetOrUse(isRecursive, isUse, bindings, exprBody |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  abstract member VisitExpr_LetOrUse: isRecursive: bool * isUse: bool * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  default __.VisitExpr_LetOrUse(isRecursive: bool, isUse: bool, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryWith".</remarks>
  abstract member BeforeVisitExpr_TryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * item4: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry * spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryWith".</remarks>
  default this.BeforeVisitExpr_TryWith(tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, item4: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry, spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith, context: 'TContext) =
    this.VisitExpr_TryWith(tryExpr |> (this.VisitExpr context), item2, item3, item4, range, spTry, spWith, context)

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  abstract member VisitExpr_TryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list * item4: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry * spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  default __.VisitExpr_TryWith(tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list, item4: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry, spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryFinally".</remarks>
  abstract member BeforeVisitExpr_TryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry * spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryFinally".</remarks>
  default this.BeforeVisitExpr_TryFinally(tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry, spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally, context: 'TContext) =
    this.VisitExpr_TryFinally(tryExpr |> (this.VisitExpr context), finallyExpr |> (this.VisitExpr context), range, spTry, spFinally, context)

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  abstract member VisitExpr_TryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry * spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  default __.VisitExpr_TryFinally(tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry, spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lazy".</remarks>
  abstract member BeforeVisitExpr_Lazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lazy".</remarks>
  default this.BeforeVisitExpr_Lazy(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Lazy(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  abstract member VisitExpr_Lazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  default __.VisitExpr_Lazy(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Sequential".</remarks>
  abstract member BeforeVisitExpr_Sequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq * isTrueSeq: bool * expr1: Microsoft.FSharp.Compiler.Ast.SynExpr * expr2: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Sequential".</remarks>
  default this.BeforeVisitExpr_Sequential(spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq, isTrueSeq: bool, expr1: Microsoft.FSharp.Compiler.Ast.SynExpr, expr2: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Sequential(spSeq, isTrueSeq, expr1 |> (this.VisitExpr context), expr2 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  abstract member VisitExpr_Sequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq * isTrueSeq: bool * expr1: Microsoft.FSharp.Compiler.Ast.SynExpr * expr2: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  default __.VisitExpr_Sequential(spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq, isTrueSeq: bool, expr1: Microsoft.FSharp.Compiler.Ast.SynExpr, expr2: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_IfThenElse".</remarks>
  abstract member BeforeVisitExpr_IfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr * exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr * optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option * spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * isFromErrorRecovery: bool * ifToThen: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_IfThenElse".</remarks>
  default this.BeforeVisitExpr_IfThenElse(exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr, exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr, optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option, spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, isFromErrorRecovery: bool, ifToThen: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_IfThenElse(exprGuard |> (this.VisitExpr context), exprThen |> (this.VisitExpr context), optionalExprElse |> (Option.map (this.VisitExpr context)), spIfToThen, isFromErrorRecovery, ifToThen, range, context)

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  abstract member VisitExpr_IfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr * exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr * optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option * spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * isFromErrorRecovery: bool * ifToThen: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  default __.VisitExpr_IfThenElse(exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr, exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr, optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option, spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, isFromErrorRecovery: bool, ifToThen: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Ident".</remarks>
  abstract member BeforeVisitExpr_Ident: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Ident".</remarks>
  default this.BeforeVisitExpr_Ident(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    this.VisitExpr_Ident(item, context)

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  abstract member VisitExpr_Ident: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  default __.VisitExpr_Ident(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdent".</remarks>
  abstract member BeforeVisitExpr_LongIdent: isOptional: bool * longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdent".</remarks>
  default this.BeforeVisitExpr_LongIdent(isOptional: bool, longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LongIdent(isOptional, longIdent, altNameRefCell, range, context)

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  abstract member VisitExpr_LongIdent: isOptional: bool * longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  default __.VisitExpr_LongIdent(isOptional: bool, longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdentSet".</remarks>
  abstract member BeforeVisitExpr_LongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdentSet".</remarks>
  default this.BeforeVisitExpr_LongIdentSet(dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LongIdentSet(dotId, expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  abstract member VisitExpr_LongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  default __.VisitExpr_LongIdentSet(dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range)

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotGet".</remarks>
  abstract member BeforeVisitExpr_DotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotGet".</remarks>
  default this.BeforeVisitExpr_DotGet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DotGet(expr |> (this.VisitExpr context), rangeOfDot, dotId, range, context)

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  abstract member VisitExpr_DotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  default __.VisitExpr_DotGet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotSet".</remarks>
  abstract member BeforeVisitExpr_DotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotSet".</remarks>
  default this.BeforeVisitExpr_DotSet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DotSet(expr |> (this.VisitExpr context), dotId, exprValue |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  abstract member VisitExpr_DotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  default __.VisitExpr_DotSet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedGet".</remarks>
  abstract member BeforeVisitExpr_DotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedGet".</remarks>
  default this.BeforeVisitExpr_DotIndexedGet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DotIndexedGet(expr |> (this.VisitExpr context), indexExprs, item3, range, context)

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  abstract member VisitExpr_DotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  default __.VisitExpr_DotIndexedGet(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedSet".</remarks>
  abstract member BeforeVisitExpr_DotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedSet".</remarks>
  default this.BeforeVisitExpr_DotIndexedSet(objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DotIndexedSet(objectExpr |> (this.VisitExpr context), indexExprs, valueExpr |> (this.VisitExpr context), rangeOfLeftOfSet, rangeOfDot, range, context)

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  abstract member VisitExpr_DotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list * valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range * rangeOfDot: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  default __.VisitExpr_DotIndexedSet(objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list, valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range, rangeOfDot: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_NamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitExpr_NamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_NamedIndexedPropertySet".</remarks>
  default this.BeforeVisitExpr_NamedIndexedPropertySet(item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_NamedIndexedPropertySet(item1, item2 |> (this.VisitExpr context), item3 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  abstract member VisitExpr_NamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  default __.VisitExpr_NamedIndexedPropertySet(item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitExpr_DotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * item4: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitExpr_DotNamedIndexedPropertySet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, item4: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DotNamedIndexedPropertySet(item1 |> (this.VisitExpr context), item2, item3 |> (this.VisitExpr context), item4 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  abstract member VisitExpr_DotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * item4: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  default __.VisitExpr_DotNamedIndexedPropertySet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, item4: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeTest".</remarks>
  abstract member BeforeVisitExpr_TypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeTest".</remarks>
  default this.BeforeVisitExpr_TypeTest(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_TypeTest(expr |> (this.VisitExpr context), typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  abstract member VisitExpr_TypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  default __.VisitExpr_TypeTest(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Upcast".</remarks>
  abstract member BeforeVisitExpr_Upcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Upcast".</remarks>
  default this.BeforeVisitExpr_Upcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Upcast(expr |> (this.VisitExpr context), typeSig |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  abstract member VisitExpr_Upcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  default __.VisitExpr_Upcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range)

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Downcast".</remarks>
  abstract member BeforeVisitExpr_Downcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Downcast".</remarks>
  default this.BeforeVisitExpr_Downcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Downcast(expr |> (this.VisitExpr context), typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  abstract member VisitExpr_Downcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  default __.VisitExpr_Downcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range)

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredUpcast".</remarks>
  abstract member BeforeVisitExpr_InferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredUpcast".</remarks>
  default this.BeforeVisitExpr_InferredUpcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_InferredUpcast(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  abstract member VisitExpr_InferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  default __.VisitExpr_InferredUpcast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range)

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredDowncast".</remarks>
  abstract member BeforeVisitExpr_InferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredDowncast".</remarks>
  default this.BeforeVisitExpr_InferredDowncast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_InferredDowncast(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  abstract member VisitExpr_InferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  default __.VisitExpr_InferredDowncast(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Null".</remarks>
  abstract member BeforeVisitExpr_Null: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Null".</remarks>
  default this.BeforeVisitExpr_Null(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Null(range, context)

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  abstract member VisitExpr_Null: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  default __.VisitExpr_Null(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_AddressOf".</remarks>
  abstract member BeforeVisitExpr_AddressOf: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_AddressOf".</remarks>
  default this.BeforeVisitExpr_AddressOf(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_AddressOf(item1, item2 |> (this.VisitExpr context), item3, range, context)

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  abstract member VisitExpr_AddressOf: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  default __.VisitExpr_AddressOf(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TraitCall".</remarks>
  abstract member BeforeVisitExpr_TraitCall: item1: Microsoft.FSharp.Compiler.Ast.SynTypar list * item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TraitCall".</remarks>
  default this.BeforeVisitExpr_TraitCall(item1: Microsoft.FSharp.Compiler.Ast.SynTypar list, item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_TraitCall(item1, item2 |> (this.VisitMemberSig context), item3 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  abstract member VisitExpr_TraitCall: item1: Microsoft.FSharp.Compiler.Ast.SynTypar list * item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  default __.VisitExpr_TraitCall(item1: Microsoft.FSharp.Compiler.Ast.SynTypar list, item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_JoinIn".</remarks>
  abstract member BeforeVisitExpr_JoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * inPos: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_JoinIn".</remarks>
  default this.BeforeVisitExpr_JoinIn(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, inPos: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_JoinIn(item1 |> (this.VisitExpr context), inPos, item3 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  abstract member VisitExpr_JoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * inPos: Microsoft.FSharp.Compiler.Range.range * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  default __.VisitExpr_JoinIn(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, inPos: Microsoft.FSharp.Compiler.Range.range, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range)

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ImplicitZero".</remarks>
  abstract member BeforeVisitExpr_ImplicitZero: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ImplicitZero".</remarks>
  default this.BeforeVisitExpr_ImplicitZero(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ImplicitZero(range, context)

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  abstract member VisitExpr_ImplicitZero: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  default __.VisitExpr_ImplicitZero(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturn".</remarks>
  abstract member BeforeVisitExpr_YieldOrReturn: item1: (bool * bool) * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturn".</remarks>
  default this.BeforeVisitExpr_YieldOrReturn(item1: (bool * bool), expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_YieldOrReturn(item1, expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  abstract member VisitExpr_YieldOrReturn: item1: (bool * bool) * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  default __.VisitExpr_YieldOrReturn(item1: (bool * bool), expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturnFrom".</remarks>
  abstract member BeforeVisitExpr_YieldOrReturnFrom: item1: (bool * bool) * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturnFrom".</remarks>
  default this.BeforeVisitExpr_YieldOrReturnFrom(item1: (bool * bool), expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_YieldOrReturnFrom(item1, expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  abstract member VisitExpr_YieldOrReturnFrom: item1: (bool * bool) * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  default __.VisitExpr_YieldOrReturnFrom(item1: (bool * bool), expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range)

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUseBang".</remarks>
  abstract member BeforeVisitExpr_LetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * isUse: bool * isFromSource: bool * pattern: Microsoft.FSharp.Compiler.Ast.SynPat * rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUseBang".</remarks>
  default this.BeforeVisitExpr_LetOrUseBang(spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, isUse: bool, isFromSource: bool, pattern: Microsoft.FSharp.Compiler.Ast.SynPat, rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LetOrUseBang(spBind, isUse, isFromSource, pattern |> (this.VisitPat context), rhsExpr |> (this.VisitExpr context), bodyExpr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  abstract member VisitExpr_LetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * isUse: bool * isFromSource: bool * pattern: Microsoft.FSharp.Compiler.Ast.SynPat * rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  default __.VisitExpr_LetOrUseBang(spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, isUse: bool, isFromSource: bool, pattern: Microsoft.FSharp.Compiler.Ast.SynPat, rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DoBang".</remarks>
  abstract member BeforeVisitExpr_DoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DoBang".</remarks>
  default this.BeforeVisitExpr_DoBang(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DoBang(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  abstract member VisitExpr_DoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  default __.VisitExpr_DoBang(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] * item2: Microsoft.FSharp.Compiler.Ast.SynType list * item3: Microsoft.FSharp.Compiler.Ast.SynExpr list * item4: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[], item2: Microsoft.FSharp.Compiler.Ast.SynType list, item3: Microsoft.FSharp.Compiler.Ast.SynExpr list, item4: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LibraryOnlyILAssembly(item1, item2, item3, item4, range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitExpr_LibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] * item2: Microsoft.FSharp.Compiler.Ast.SynType list * item3: Microsoft.FSharp.Compiler.Ast.SynExpr list * item4: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  default __.VisitExpr_LibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[], item2: Microsoft.FSharp.Compiler.Ast.SynType list, item3: Microsoft.FSharp.Compiler.Ast.SynExpr list, item4: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyStaticOptimization(item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LibraryOnlyStaticOptimization(item1, item2 |> (this.VisitExpr context), item3 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  abstract member VisitExpr_LibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  default __.VisitExpr_LibraryOnlyStaticOptimization(item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LibraryOnlyUnionCaseFieldGet(item1 |> (this.VisitExpr context), longId, item3, range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitExpr_LibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitExpr_LibraryOnlyUnionCaseFieldGet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * item4: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, item4: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_LibraryOnlyUnionCaseFieldSet(item1 |> (this.VisitExpr context), longId, item3, item4 |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitExpr_LibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * longId: Microsoft.FSharp.Compiler.Ast.Ident list * item3: int * item4: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitExpr_LibraryOnlyUnionCaseFieldSet(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, longId: Microsoft.FSharp.Compiler.Ast.Ident list, item3: int, item4: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArbitraryAfterError".</remarks>
  abstract member BeforeVisitExpr_ArbitraryAfterError: debugStr: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArbitraryAfterError".</remarks>
  default this.BeforeVisitExpr_ArbitraryAfterError(debugStr: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_ArbitraryAfterError(debugStr, range, context)

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  abstract member VisitExpr_ArbitraryAfterError: debugStr: string * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  default __.VisitExpr_ArbitraryAfterError(debugStr: string, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_FromParseError".</remarks>
  abstract member BeforeVisitExpr_FromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_FromParseError".</remarks>
  default this.BeforeVisitExpr_FromParseError(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_FromParseError(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  abstract member VisitExpr_FromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  default __.VisitExpr_FromParseError(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range)

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_DiscardAfterMissingQualificationAfterDot(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitExpr_DiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitExpr_DiscardAfterMissingQualificationAfterDot(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Fixed".</remarks>
  abstract member BeforeVisitExpr_Fixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Fixed".</remarks>
  default this.BeforeVisitExpr_Fixed(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitExpr_Fixed(item1 |> (this.VisitExpr context), item2, context)

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  abstract member VisitExpr_Fixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  default __.VisitExpr_Fixed(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExpr">SynExpr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExpr (context: 'TContext) (synExpr: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    parents.Push(AstElement.Expr synExpr)
    try
      match synExpr with
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
        this.BeforeVisitExpr_Paren(expr, leftParenRange, rightParenRange, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        this.BeforeVisitExpr_Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
        this.BeforeVisitExpr_Const(constant, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
        this.BeforeVisitExpr_Typed(expr, typeSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
        this.BeforeVisitExpr_Tuple(exprs, commaRanges, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
        this.BeforeVisitExpr_ArrayOrList(isList, exprs, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        this.BeforeVisitExpr_Record(baseInfo, copyInfo, recordFields, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
        this.BeforeVisitExpr_New(isProtected, typeName, expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        this.BeforeVisitExpr_ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
        this.BeforeVisitExpr_While(spWhile, whileBody, doBody, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        this.BeforeVisitExpr_For(spFor, id, idBody, item4, toBody, doBody, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        this.BeforeVisitExpr_ArrayOrListOfSeqExpr(isList, elements, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        this.BeforeVisitExpr_CompExpr(isArrayOrList, isNotNakedRefCell, expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        this.BeforeVisitExpr_Lambda(fromMethod, inLambdaSeq, args, body, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        this.BeforeVisitExpr_MatchLambda(item1, item2, clauses, spBind, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        this.BeforeVisitExpr_Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
        this.BeforeVisitExpr_Do(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
        this.BeforeVisitExpr_Assert(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        this.BeforeVisitExpr_App(exprAtomicFlag, isInfix, funcExpr, argExpr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        this.BeforeVisitExpr_TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        this.BeforeVisitExpr_LetOrUse(isRecursive, isUse, bindings, exprBody, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        this.BeforeVisitExpr_TryWith(tryExpr, item2, item3, item4, range, spTry, spWith, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        this.BeforeVisitExpr_TryFinally(tryExpr, finallyExpr, range, spTry, spFinally, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
        this.BeforeVisitExpr_Lazy(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        this.BeforeVisitExpr_Sequential(spSeq, isTrueSeq, expr1, expr2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        this.BeforeVisitExpr_IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
        this.BeforeVisitExpr_Ident(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        this.BeforeVisitExpr_LongIdent(isOptional, longIdent, altNameRefCell, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
        this.BeforeVisitExpr_LongIdentSet(dotId, expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        this.BeforeVisitExpr_DotGet(expr, rangeOfDot, dotId, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
        this.BeforeVisitExpr_DotSet(expr, dotId, exprValue, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        this.BeforeVisitExpr_DotIndexedGet(expr, indexExprs, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        this.BeforeVisitExpr_DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        this.BeforeVisitExpr_NamedIndexedPropertySet(item1, item2, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_DotNamedIndexedPropertySet(item1, item2, item3, item4, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
        this.BeforeVisitExpr_TypeTest(expr, typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
        this.BeforeVisitExpr_Upcast(expr, typeSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
        this.BeforeVisitExpr_Downcast(expr, typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
        this.BeforeVisitExpr_InferredUpcast(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
        this.BeforeVisitExpr_InferredDowncast(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
        this.BeforeVisitExpr_Null(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
        this.BeforeVisitExpr_AddressOf(item1, item2, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
        this.BeforeVisitExpr_TraitCall(item1, item2, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
        this.BeforeVisitExpr_JoinIn(item1, inPos, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
        this.BeforeVisitExpr_ImplicitZero(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturn(item1, expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturnFrom(item1, expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
        this.BeforeVisitExpr_DoBang(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyILAssembly(item1, item2, item3, item4, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyStaticOptimization(item1, item2, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
        this.BeforeVisitExpr_ArbitraryAfterError(debugStr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
        this.BeforeVisitExpr_FromParseError(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
        this.BeforeVisitExpr_Fixed(item1, item2, context)
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
  abstract member BeforeVisitField_Field: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * typeName: Microsoft.FSharp.Compiler.Ast.SynType * item5: bool * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField_Field".</remarks>
  default this.BeforeVisitField_Field(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, typeName: Microsoft.FSharp.Compiler.Ast.SynType, item5: bool, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitField_Field(attributes, isStatic, id, typeName |> (this.VisitType context), item5, xmlDoc, accessiblity |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  abstract member VisitField_Field: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident option * typeName: Microsoft.FSharp.Compiler.Ast.SynType * item5: bool * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynField

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  default __.VisitField_Field(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident option, typeName: Microsoft.FSharp.Compiler.Ast.SynType, item5: bool, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)


  /// <summary>
  /// Visit and dispatch "SynField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synField">SynField expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitField (context: 'TContext) (synField: Microsoft.FSharp.Compiler.Ast.SynField) =
    parents.Push(AstElement.Field synField)
    try
      match synField with
      | Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
        this.BeforeVisitField_Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range, context)
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
  abstract member BeforeVisitIndexerArg_Two: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_Two".</remarks>
  default this.BeforeVisitIndexerArg_Two(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, context: 'TContext) =
    this.VisitIndexerArg_Two(item1 |> (this.VisitExpr context), item2 |> (this.VisitExpr context), context)

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  abstract member VisitIndexerArg_Two: item1: Microsoft.FSharp.Compiler.Ast.SynExpr * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  default __.VisitIndexerArg_Two(item1: Microsoft.FSharp.Compiler.Ast.SynExpr, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2)

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_One".</remarks>
  abstract member BeforeVisitIndexerArg_One: item: Microsoft.FSharp.Compiler.Ast.SynExpr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_One".</remarks>
  default this.BeforeVisitIndexerArg_One(item: Microsoft.FSharp.Compiler.Ast.SynExpr, context: 'TContext) =
    this.VisitIndexerArg_One(item |> (this.VisitExpr context), context)

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  abstract member VisitIndexerArg_One: item: Microsoft.FSharp.Compiler.Ast.SynExpr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  default __.VisitIndexerArg_One(item: Microsoft.FSharp.Compiler.Ast.SynExpr, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item)


  /// <summary>
  /// Visit and dispatch "SynIndexerArg" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synIndexerArg">SynIndexerArg expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitIndexerArg (context: 'TContext) (synIndexerArg: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    parents.Push(AstElement.IndexerArg synIndexerArg)
    try
      match synIndexerArg with
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
        this.BeforeVisitIndexerArg_Two(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
        this.BeforeVisitIndexerArg_One(item, context)
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
  abstract member BeforeVisitInterfaceImpl_InterfaceImpl: item1: Microsoft.FSharp.Compiler.Ast.SynType * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl_InterfaceImpl".</remarks>
  default this.BeforeVisitInterfaceImpl_InterfaceImpl(item1: Microsoft.FSharp.Compiler.Ast.SynType, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitInterfaceImpl_InterfaceImpl(item1 |> (this.VisitType context), bindings, range, context)

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  abstract member VisitInterfaceImpl_InterfaceImpl: item1: Microsoft.FSharp.Compiler.Ast.SynType * bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  default __.VisitInterfaceImpl_InterfaceImpl(item1: Microsoft.FSharp.Compiler.Ast.SynType, bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range)


  /// <summary>
  /// Visit and dispatch "SynInterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synInterfaceImpl">SynInterfaceImpl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitInterfaceImpl (context: 'TContext) (synInterfaceImpl: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    parents.Push(AstElement.InterfaceImpl synInterfaceImpl)
    try
      match synInterfaceImpl with
      | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
        this.BeforeVisitInterfaceImpl_InterfaceImpl(item1, bindings, range, context)
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
  abstract member BeforeVisitMatchClause_Clause: item1: Microsoft.FSharp.Compiler.Ast.SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynExpr option * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchClause_Clause".</remarks>
  default this.BeforeVisitMatchClause_Clause(item1: Microsoft.FSharp.Compiler.Ast.SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynExpr option, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget, context: 'TContext) =
    this.VisitMatchClause_Clause(item1 |> (this.VisitPat context), item2 |> (Option.map (this.VisitExpr context)), item3 |> (this.VisitExpr context), range, spTarget, context)

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  abstract member VisitMatchClause_Clause: item1: Microsoft.FSharp.Compiler.Ast.SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynExpr option * item3: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMatchClause

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  default __.VisitMatchClause_Clause(item1: Microsoft.FSharp.Compiler.Ast.SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynExpr option, item3: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget)


  /// <summary>
  /// Visit and dispatch "SynMatchClause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMatchClause">SynMatchClause expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMatchClause (context: 'TContext) (synMatchClause: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    parents.Push(AstElement.MatchClause synMatchClause)
    try
      match synMatchClause with
      | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
        this.BeforeVisitMatchClause_Clause(item1, item2, item3, range, spTarget, context)
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
  abstract member BeforeVisitMeasure_Named: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Named".</remarks>
  default this.BeforeVisitMeasure_Named(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Named(longId, range, context)

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  abstract member VisitMeasure_Named: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  default __.VisitMeasure_Named(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range)

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Product".</remarks>
  abstract member BeforeVisitMeasure_Product: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Product".</remarks>
  default this.BeforeVisitMeasure_Product(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Product(item1 |> (this.VisitMeasure context), item2 |> (this.VisitMeasure context), range, context)

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  abstract member VisitMeasure_Product: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  default __.VisitMeasure_Product(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Seq".</remarks>
  abstract member BeforeVisitMeasure_Seq: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Seq".</remarks>
  default this.BeforeVisitMeasure_Seq(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Seq(item1, range, context)

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  abstract member VisitMeasure_Seq: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  default __.VisitMeasure_Seq(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range)

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Divide".</remarks>
  abstract member BeforeVisitMeasure_Divide: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Divide".</remarks>
  default this.BeforeVisitMeasure_Divide(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Divide(item1 |> (this.VisitMeasure context), item2 |> (this.VisitMeasure context), range, context)

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  abstract member VisitMeasure_Divide: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynMeasure * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  default __.VisitMeasure_Divide(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynMeasure, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Power".</remarks>
  abstract member BeforeVisitMeasure_Power: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Power".</remarks>
  default this.BeforeVisitMeasure_Power(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Power(item1 |> (this.VisitMeasure context), item2 |> (this.VisitRationalConst context), range, context)

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  abstract member VisitMeasure_Power: item1: Microsoft.FSharp.Compiler.Ast.SynMeasure * item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  default __.VisitMeasure_Power(item1: Microsoft.FSharp.Compiler.Ast.SynMeasure, item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range)

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_One".</remarks>
  abstract member BeforeVisitMeasure_One: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_One".</remarks>
  default this.BeforeVisitMeasure_One(context: 'TContext) =
    this.VisitMeasure_One(context)

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  abstract member VisitMeasure_One: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  default __.VisitMeasure_One(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.One

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Anon".</remarks>
  abstract member BeforeVisitMeasure_Anon: item: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Anon".</remarks>
  default this.BeforeVisitMeasure_Anon(item: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Anon(item, context)

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  abstract member VisitMeasure_Anon: item: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  default __.VisitMeasure_Anon(item: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item)

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Var".</remarks>
  abstract member BeforeVisitMeasure_Var: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Var".</remarks>
  default this.BeforeVisitMeasure_Var(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMeasure_Var(item1 |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  abstract member VisitMeasure_Var: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMeasure

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  default __.VisitMeasure_Var(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range)


  /// <summary>
  /// Visit and dispatch "SynMeasure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMeasure">SynMeasure expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMeasure (context: 'TContext) (synMeasure: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    parents.Push(AstElement.Measure synMeasure)
    try
      match synMeasure with
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range) ->
        this.BeforeVisitMeasure_Named(longId, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
        this.BeforeVisitMeasure_Product(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
        this.BeforeVisitMeasure_Seq(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
        this.BeforeVisitMeasure_Divide(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
        this.BeforeVisitMeasure_Power(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.One ->
        this.BeforeVisitMeasure_One(context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item) ->
        this.BeforeVisitMeasure_Anon(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
        this.BeforeVisitMeasure_Var(item1, range, context)
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
  abstract member BeforeVisitMemberDefn_Open: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Open".</remarks>
  default this.BeforeVisitMemberDefn_Open(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_Open(longId, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  abstract member VisitMemberDefn_Open: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  default __.VisitMemberDefn_Open(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Member".</remarks>
  abstract member BeforeVisitMemberDefn_Member: memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Member".</remarks>
  default this.BeforeVisitMemberDefn_Member(memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_Member(memberDefn |> (this.VisitBinding context), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  abstract member VisitMemberDefn_Member: memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  default __.VisitMemberDefn_Member(memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitCtor".</remarks>
  abstract member BeforeVisitMemberDefn_ImplicitCtor: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitCtor".</remarks>
  default this.BeforeVisitMemberDefn_ImplicitCtor(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_ImplicitCtor(accessiblity |> (Option.map (this.VisitAccess context)), attributes, ctorArgs, selfIdentifier, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  abstract member VisitMemberDefn_ImplicitCtor: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  default __.VisitMemberDefn_ImplicitCtor(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitInherit".</remarks>
  abstract member BeforeVisitMemberDefn_ImplicitInherit: inheritType: Microsoft.FSharp.Compiler.Ast.SynType * inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr * inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitInherit".</remarks>
  default this.BeforeVisitMemberDefn_ImplicitInherit(inheritType: Microsoft.FSharp.Compiler.Ast.SynType, inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr, inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_ImplicitInherit(inheritType |> (this.VisitType context), inheritArgs |> (this.VisitExpr context), inheritAlias, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  abstract member VisitMemberDefn_ImplicitInherit: inheritType: Microsoft.FSharp.Compiler.Ast.SynType * inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr * inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  default __.VisitMemberDefn_ImplicitInherit(inheritType: Microsoft.FSharp.Compiler.Ast.SynType, inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr, inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range)

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_LetBindings".</remarks>
  abstract member BeforeVisitMemberDefn_LetBindings: bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * isStatic: bool * isRecursive: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_LetBindings".</remarks>
  default this.BeforeVisitMemberDefn_LetBindings(bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, isStatic: bool, isRecursive: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_LetBindings(bindings, isStatic, isRecursive, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  abstract member VisitMemberDefn_LetBindings: bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list * isStatic: bool * isRecursive: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  default __.VisitMemberDefn_LetBindings(bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list, isStatic: bool, isRecursive: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AbstractSlot".</remarks>
  abstract member BeforeVisitMemberDefn_AbstractSlot: valSig: Microsoft.FSharp.Compiler.Ast.SynValSig * memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AbstractSlot".</remarks>
  default this.BeforeVisitMemberDefn_AbstractSlot(valSig: Microsoft.FSharp.Compiler.Ast.SynValSig, memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_AbstractSlot(valSig |> (this.VisitValSig context), memberFlags, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  abstract member VisitMemberDefn_AbstractSlot: valSig: Microsoft.FSharp.Compiler.Ast.SynValSig * memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  default __.VisitMemberDefn_AbstractSlot(valSig: Microsoft.FSharp.Compiler.Ast.SynValSig, memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Interface".</remarks>
  abstract member BeforeVisitMemberDefn_Interface: typeName: Microsoft.FSharp.Compiler.Ast.SynType * interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Interface".</remarks>
  default this.BeforeVisitMemberDefn_Interface(typeName: Microsoft.FSharp.Compiler.Ast.SynType, interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_Interface(typeName |> (this.VisitType context), interfaceMembers, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  abstract member VisitMemberDefn_Interface: typeName: Microsoft.FSharp.Compiler.Ast.SynType * interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  default __.VisitMemberDefn_Interface(typeName: Microsoft.FSharp.Compiler.Ast.SynType, interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range)

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Inherit".</remarks>
  abstract member BeforeVisitMemberDefn_Inherit: typeName: Microsoft.FSharp.Compiler.Ast.SynType * id: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Inherit".</remarks>
  default this.BeforeVisitMemberDefn_Inherit(typeName: Microsoft.FSharp.Compiler.Ast.SynType, id: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_Inherit(typeName |> (this.VisitType context), id, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  abstract member VisitMemberDefn_Inherit: typeName: Microsoft.FSharp.Compiler.Ast.SynType * id: Microsoft.FSharp.Compiler.Ast.Ident option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  default __.VisitMemberDefn_Inherit(typeName: Microsoft.FSharp.Compiler.Ast.SynType, id: Microsoft.FSharp.Compiler.Ast.Ident option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range)

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ValField".</remarks>
  abstract member BeforeVisitMemberDefn_ValField: field: Microsoft.FSharp.Compiler.Ast.SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ValField".</remarks>
  default this.BeforeVisitMemberDefn_ValField(field: Microsoft.FSharp.Compiler.Ast.SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_ValField(field |> (this.VisitField context), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  abstract member VisitMemberDefn_ValField: field: Microsoft.FSharp.Compiler.Ast.SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  default __.VisitMemberDefn_ValField(field: Microsoft.FSharp.Compiler.Ast.SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range)

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_NestedType".</remarks>
  abstract member BeforeVisitMemberDefn_NestedType: typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_NestedType".</remarks>
  default this.BeforeVisitMemberDefn_NestedType(typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_NestedType(typeDefn |> (this.VisitTypeDefn context), accessiblity |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  abstract member VisitMemberDefn_NestedType: typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  default __.VisitMemberDefn_NestedType(typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range)

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AutoProperty".</remarks>
  abstract member BeforeVisitMemberDefn_AutoProperty: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident * tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option * propKind: Microsoft.FSharp.Compiler.Ast.MemberKind * memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * getSetPos: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AutoProperty".</remarks>
  default this.BeforeVisitMemberDefn_AutoProperty(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident, tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option, propKind: Microsoft.FSharp.Compiler.Ast.MemberKind, memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags), xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, getSetPos: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberDefn_AutoProperty(attributes, isStatic, id, tyOpt |> (Option.map (this.VisitType context)), propKind, memberFlags, xmlDoc, accessibility |> (Option.map (this.VisitAccess context)), expr |> (this.VisitExpr context), getSetPos, range, context)

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  abstract member VisitMemberDefn_AutoProperty: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * isStatic: bool * id: Microsoft.FSharp.Compiler.Ast.Ident * tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option * propKind: Microsoft.FSharp.Compiler.Ast.MemberKind * memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags) * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr * getSetPos: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  default __.VisitMemberDefn_AutoProperty(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, isStatic: bool, id: Microsoft.FSharp.Compiler.Ast.Ident, tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option, propKind: Microsoft.FSharp.Compiler.Ast.MemberKind, memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags), xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr, getSetPos: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)


  /// <summary>
  /// Visit and dispatch "SynMemberDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberDefn">SynMemberDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberDefn (context: 'TContext) (synMemberDefn: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    parents.Push(AstElement.MemberDefn synMemberDefn)
    try
      match synMemberDefn with
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range) ->
        this.BeforeVisitMemberDefn_Open(longId, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
        this.BeforeVisitMemberDefn_Member(memberDefn, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
        this.BeforeVisitMemberDefn_ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
        this.BeforeVisitMemberDefn_ImplicitInherit(inheritType, inheritArgs, inheritAlias, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
        this.BeforeVisitMemberDefn_LetBindings(bindings, isStatic, isRecursive, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
        this.BeforeVisitMemberDefn_AbstractSlot(valSig, memberFlags, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
        this.BeforeVisitMemberDefn_Interface(typeName, interfaceMembers, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
        this.BeforeVisitMemberDefn_Inherit(typeName, id, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
        this.BeforeVisitMemberDefn_ValField(field, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
        this.BeforeVisitMemberDefn_NestedType(typeDefn, accessiblity, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
        this.BeforeVisitMemberDefn_AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range, context)
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
  abstract member BeforeVisitMemberSig_Member: item1: Microsoft.FSharp.Compiler.Ast.SynValSig * memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Member".</remarks>
  default this.BeforeVisitMemberSig_Member(item1: Microsoft.FSharp.Compiler.Ast.SynValSig, memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberSig_Member(item1 |> (this.VisitValSig context), memberFlags, range, context)

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  abstract member VisitMemberSig_Member: item1: Microsoft.FSharp.Compiler.Ast.SynValSig * memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  default __.VisitMemberSig_Member(item1: Microsoft.FSharp.Compiler.Ast.SynValSig, memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range)

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Interface".</remarks>
  abstract member BeforeVisitMemberSig_Interface: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Interface".</remarks>
  default this.BeforeVisitMemberSig_Interface(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberSig_Interface(typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  abstract member VisitMemberSig_Interface: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  default __.VisitMemberSig_Interface(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Inherit".</remarks>
  abstract member BeforeVisitMemberSig_Inherit: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Inherit".</remarks>
  default this.BeforeVisitMemberSig_Inherit(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberSig_Inherit(typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  abstract member VisitMemberSig_Inherit: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  default __.VisitMemberSig_Inherit(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range)

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_ValField".</remarks>
  abstract member BeforeVisitMemberSig_ValField: field: Microsoft.FSharp.Compiler.Ast.SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_ValField".</remarks>
  default this.BeforeVisitMemberSig_ValField(field: Microsoft.FSharp.Compiler.Ast.SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberSig_ValField(field |> (this.VisitField context), range, context)

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  abstract member VisitMemberSig_ValField: field: Microsoft.FSharp.Compiler.Ast.SynField * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  default __.VisitMemberSig_ValField(field: Microsoft.FSharp.Compiler.Ast.SynField, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range)

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_NestedType".</remarks>
  abstract member BeforeVisitMemberSig_NestedType: typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_NestedType".</remarks>
  default this.BeforeVisitMemberSig_NestedType(typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitMemberSig_NestedType(typeDefnSig |> (this.VisitTypeDefnSig context), range, context)

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  abstract member VisitMemberSig_NestedType: typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynMemberSig

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  default __.VisitMemberSig_NestedType(typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range)


  /// <summary>
  /// Visit and dispatch "SynMemberSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberSig">SynMemberSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberSig (context: 'TContext) (synMemberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    parents.Push(AstElement.MemberSig synMemberSig)
    try
      match synMemberSig with
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
        this.BeforeVisitMemberSig_Member(item1, memberFlags, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
        this.BeforeVisitMemberSig_Interface(typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
        this.BeforeVisitMemberSig_Inherit(typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
        this.BeforeVisitMemberSig_ValField(field, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
        this.BeforeVisitMemberSig_NestedType(typeDefnSig, range, context)
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
  abstract member BeforeVisitModuleDecl_ModuleAbbrev: item1: Microsoft.FSharp.Compiler.Ast.Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_ModuleAbbrev".</remarks>
  default this.BeforeVisitModuleDecl_ModuleAbbrev(item1: Microsoft.FSharp.Compiler.Ast.Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_ModuleAbbrev(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  abstract member VisitModuleDecl_ModuleAbbrev: item1: Microsoft.FSharp.Compiler.Ast.Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  default __.VisitModuleDecl_ModuleAbbrev(item1: Microsoft.FSharp.Compiler.Ast.Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NestedModule".</remarks>
  abstract member BeforeVisitModuleDecl_NestedModule: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * isRec: bool * item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * item4: bool * item5: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NestedModule".</remarks>
  default this.BeforeVisitModuleDecl_NestedModule(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, isRec: bool, item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, item4: bool, item5: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_NestedModule(item1 |> (this.VisitComponentInfo context), isRec, item3, item4, item5, context)

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  abstract member VisitModuleDecl_NestedModule: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * isRec: bool * item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * item4: bool * item5: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  default __.VisitModuleDecl_NestedModule(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, isRec: bool, item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, item4: bool, item5: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5)

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Let".</remarks>
  abstract member BeforeVisitModuleDecl_Let: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynBinding list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Let".</remarks>
  default this.BeforeVisitModuleDecl_Let(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynBinding list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_Let(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  abstract member VisitModuleDecl_Let: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynBinding list * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  default __.VisitModuleDecl_Let(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynBinding list, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_DoExpr".</remarks>
  abstract member BeforeVisitModuleDecl_DoExpr: item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_DoExpr".</remarks>
  default this.BeforeVisitModuleDecl_DoExpr(item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_DoExpr(item1, item2 |> (this.VisitExpr context), item3, context)

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  abstract member VisitModuleDecl_DoExpr: item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding * item2: Microsoft.FSharp.Compiler.Ast.SynExpr * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  default __.VisitModuleDecl_DoExpr(item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding, item2: Microsoft.FSharp.Compiler.Ast.SynExpr, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3)

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Types".</remarks>
  abstract member BeforeVisitModuleDecl_Types: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Types".</remarks>
  default this.BeforeVisitModuleDecl_Types(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_Types(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  abstract member VisitModuleDecl_Types: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  default __.VisitModuleDecl_Types(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Exception".</remarks>
  abstract member BeforeVisitModuleDecl_Exception: item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Exception".</remarks>
  default this.BeforeVisitModuleDecl_Exception(item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_Exception(item1 |> (this.VisitExceptionDefn context), item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  abstract member VisitModuleDecl_Exception: item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  default __.VisitModuleDecl_Exception(item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Open".</remarks>
  abstract member BeforeVisitModuleDecl_Open: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Open".</remarks>
  default this.BeforeVisitModuleDecl_Open(item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_Open(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  abstract member VisitModuleDecl_Open: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  default __.VisitModuleDecl_Open(item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Attributes".</remarks>
  abstract member BeforeVisitModuleDecl_Attributes: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Attributes".</remarks>
  default this.BeforeVisitModuleDecl_Attributes(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_Attributes(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  abstract member VisitModuleDecl_Attributes: item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  default __.VisitModuleDecl_Attributes(item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_HashDirective".</remarks>
  abstract member BeforeVisitModuleDecl_HashDirective: item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_HashDirective".</remarks>
  default this.BeforeVisitModuleDecl_HashDirective(item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleDecl_HashDirective(item1, item2, context)

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  abstract member VisitModuleDecl_HashDirective: item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective * item2: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  default __.VisitModuleDecl_HashDirective(item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective, item2: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2)

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NamespaceFragment".</remarks>
  abstract member BeforeVisitModuleDecl_NamespaceFragment: item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NamespaceFragment".</remarks>
  default this.BeforeVisitModuleDecl_NamespaceFragment(item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace, context: 'TContext) =
    this.VisitModuleDecl_NamespaceFragment(item |> (this.VisitModuleOrNamespace context), context)

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  abstract member VisitModuleDecl_NamespaceFragment: item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  default __.VisitModuleDecl_NamespaceFragment(item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item)


  /// <summary>
  /// Visit and dispatch "SynModuleDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleDecl">SynModuleDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleDecl (context: 'TContext) (synModuleDecl: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    parents.Push(AstElement.ModuleDecl synModuleDecl)
    try
      match synModuleDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_ModuleAbbrev(item1, item2, item3, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
        this.BeforeVisitModuleDecl_NestedModule(item1, isRec, item3, item4, item5, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_Let(item1, item2, item3, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_DoExpr(item1, item2, item3, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
        this.BeforeVisitModuleDecl_Types(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
        this.BeforeVisitModuleDecl_Exception(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2) ->
        this.BeforeVisitModuleDecl_Open(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
        this.BeforeVisitModuleDecl_Attributes(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
        this.BeforeVisitModuleDecl_HashDirective(item1, item2, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleDecl_NamespaceFragment(item, context)
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
  abstract member BeforeVisitModuleOrNamespace_SynModuleOrNamespace: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * access: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespace_SynModuleOrNamespace".</remarks>
  default this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, access: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleOrNamespace_SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  abstract member VisitModuleOrNamespace_SynModuleOrNamespace: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * access: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  default __.VisitModuleOrNamespace_SynModuleOrNamespace(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, access: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespace">SynModuleOrNamespace expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespace (context: 'TContext) (synModuleOrNamespace: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    parents.Push(AstElement.ModuleOrNamespace synModuleOrNamespace)
    try
      match synModuleOrNamespace with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
        this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range, context)
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
  abstract member BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item7: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig".</remarks>
  default this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item7: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7 |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  abstract member VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig: id: Microsoft.FSharp.Compiler.Ast.Ident list * isRec: bool * isModule: bool * item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item7: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  default __.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(id: Microsoft.FSharp.Compiler.Ast.Ident list, isRec: bool, isModule: bool, item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item7: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range)


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespaceSig">SynModuleOrNamespaceSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespaceSig (context: 'TContext) (synModuleOrNamespaceSig: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    parents.Push(AstElement.ModuleOrNamespaceSig synModuleOrNamespaceSig)
    try
      match synModuleOrNamespaceSig with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
        this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range, context)
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
  abstract member BeforeVisitModuleSigDecl_ModuleAbbrev: id: Microsoft.FSharp.Compiler.Ast.Ident * longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_ModuleAbbrev".</remarks>
  default this.BeforeVisitModuleSigDecl_ModuleAbbrev(id: Microsoft.FSharp.Compiler.Ast.Ident, longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_ModuleAbbrev(id, longId, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  abstract member VisitModuleSigDecl_ModuleAbbrev: id: Microsoft.FSharp.Compiler.Ast.Ident * longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  default __.VisitModuleSigDecl_ModuleAbbrev(id: Microsoft.FSharp.Compiler.Ast.Ident, longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NestedModule".</remarks>
  abstract member BeforeVisitModuleSigDecl_NestedModule: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * isRec: bool * moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NestedModule".</remarks>
  default this.BeforeVisitModuleSigDecl_NestedModule(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, isRec: bool, moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_NestedModule(item1 |> (this.VisitComponentInfo context), isRec, moduleSigDecls, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  abstract member VisitModuleSigDecl_NestedModule: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * isRec: bool * moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  default __.VisitModuleSigDecl_NestedModule(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, isRec: bool, moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Val".</remarks>
  abstract member BeforeVisitModuleSigDecl_Val: valSig: Microsoft.FSharp.Compiler.Ast.SynValSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Val".</remarks>
  default this.BeforeVisitModuleSigDecl_Val(valSig: Microsoft.FSharp.Compiler.Ast.SynValSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_Val(valSig |> (this.VisitValSig context), range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  abstract member VisitModuleSigDecl_Val: valSig: Microsoft.FSharp.Compiler.Ast.SynValSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  default __.VisitModuleSigDecl_Val(valSig: Microsoft.FSharp.Compiler.Ast.SynValSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Types".</remarks>
  abstract member BeforeVisitModuleSigDecl_Types: typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Types".</remarks>
  default this.BeforeVisitModuleSigDecl_Types(typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_Types(typeDefSigs, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  abstract member VisitModuleSigDecl_Types: typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  default __.VisitModuleSigDecl_Types(typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Exception".</remarks>
  abstract member BeforeVisitModuleSigDecl_Exception: exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Exception".</remarks>
  default this.BeforeVisitModuleSigDecl_Exception(exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_Exception(exnSig |> (this.VisitExceptionSig context), range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  abstract member VisitModuleSigDecl_Exception: exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  default __.VisitModuleSigDecl_Exception(exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Open".</remarks>
  abstract member BeforeVisitModuleSigDecl_Open: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Open".</remarks>
  default this.BeforeVisitModuleSigDecl_Open(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_Open(longId, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  abstract member VisitModuleSigDecl_Open: longId: Microsoft.FSharp.Compiler.Ast.Ident list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  default __.VisitModuleSigDecl_Open(longId: Microsoft.FSharp.Compiler.Ast.Ident list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_HashDirective".</remarks>
  abstract member BeforeVisitModuleSigDecl_HashDirective: hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_HashDirective".</remarks>
  default this.BeforeVisitModuleSigDecl_HashDirective(hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitModuleSigDecl_HashDirective(hashDirective, range, context)

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  abstract member VisitModuleSigDecl_HashDirective: hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  default __.VisitModuleSigDecl_HashDirective(hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range)

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NamespaceFragment".</remarks>
  abstract member BeforeVisitModuleSigDecl_NamespaceFragment: item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NamespaceFragment".</remarks>
  default this.BeforeVisitModuleSigDecl_NamespaceFragment(item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig, context: 'TContext) =
    this.VisitModuleSigDecl_NamespaceFragment(item |> (this.VisitModuleOrNamespaceSig context), context)

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  abstract member VisitModuleSigDecl_NamespaceFragment: item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  default __.VisitModuleSigDecl_NamespaceFragment(item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item)


  /// <summary>
  /// Visit and dispatch "SynModuleSigDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleSigDecl">SynModuleSigDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleSigDecl (context: 'TContext) (synModuleSigDecl: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    parents.Push(AstElement.ModuleSigDecl synModuleSigDecl)
    try
      match synModuleSigDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range) ->
        this.BeforeVisitModuleSigDecl_ModuleAbbrev(id, longId, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
        this.BeforeVisitModuleSigDecl_NestedModule(item1, isRec, moduleSigDecls, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
        this.BeforeVisitModuleSigDecl_Val(valSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
        this.BeforeVisitModuleSigDecl_Types(typeDefSigs, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
        this.BeforeVisitModuleSigDecl_Exception(exnSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range) ->
        this.BeforeVisitModuleSigDecl_Open(longId, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
        this.BeforeVisitModuleSigDecl_HashDirective(hashDirective, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleSigDecl_NamespaceFragment(item, context)
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
  abstract member BeforeVisitPat_Const: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Const".</remarks>
  default this.BeforeVisitPat_Const(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Const(constant |> (this.VisitConst context), range, context)

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  abstract member VisitPat_Const: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  default __.VisitPat_Const(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range)

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Wild".</remarks>
  abstract member BeforeVisitPat_Wild: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Wild".</remarks>
  default this.BeforeVisitPat_Wild(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Wild(range, context)

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  abstract member VisitPat_Wild: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  default __.VisitPat_Wild(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range)

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Named".</remarks>
  abstract member BeforeVisitPat_Named: item1: Microsoft.FSharp.Compiler.Ast.SynPat * id: Microsoft.FSharp.Compiler.Ast.Ident * isThisVar: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Named".</remarks>
  default this.BeforeVisitPat_Named(item1: Microsoft.FSharp.Compiler.Ast.SynPat, id: Microsoft.FSharp.Compiler.Ast.Ident, isThisVar: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Named(item1 |> (this.VisitPat context), id, isThisVar, accessiblity |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  abstract member VisitPat_Named: item1: Microsoft.FSharp.Compiler.Ast.SynPat * id: Microsoft.FSharp.Compiler.Ast.Ident * isThisVar: bool * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  default __.VisitPat_Named(item1: Microsoft.FSharp.Compiler.Ast.SynPat, id: Microsoft.FSharp.Compiler.Ast.Ident, isThisVar: bool, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range)

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Typed".</remarks>
  abstract member BeforeVisitPat_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynPat * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Typed".</remarks>
  default this.BeforeVisitPat_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynPat, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Typed(item1 |> (this.VisitPat context), typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  abstract member VisitPat_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynPat * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  default __.VisitPat_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynPat, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range)

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Attrib".</remarks>
  abstract member BeforeVisitPat_Attrib: item1: Microsoft.FSharp.Compiler.Ast.SynPat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Attrib".</remarks>
  default this.BeforeVisitPat_Attrib(item1: Microsoft.FSharp.Compiler.Ast.SynPat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Attrib(item1 |> (this.VisitPat context), attributes, range, context)

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  abstract member VisitPat_Attrib: item1: Microsoft.FSharp.Compiler.Ast.SynPat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  default __.VisitPat_Attrib(item1: Microsoft.FSharp.Compiler.Ast.SynPat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range)

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Or".</remarks>
  abstract member BeforeVisitPat_Or: item1: Microsoft.FSharp.Compiler.Ast.SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Or".</remarks>
  default this.BeforeVisitPat_Or(item1: Microsoft.FSharp.Compiler.Ast.SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Or(item1 |> (this.VisitPat context), item2 |> (this.VisitPat context), range, context)

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  abstract member VisitPat_Or: item1: Microsoft.FSharp.Compiler.Ast.SynPat * item2: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  default __.VisitPat_Or(item1: Microsoft.FSharp.Compiler.Ast.SynPat, item2: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Ands".</remarks>
  abstract member BeforeVisitPat_Ands: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Ands".</remarks>
  default this.BeforeVisitPat_Ands(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Ands(item1, range, context)

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  abstract member VisitPat_Ands: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  default __.VisitPat_Ands(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range)

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_LongIdent".</remarks>
  abstract member BeforeVisitPat_LongIdent: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.Ident option * item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option * item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs * item5: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_LongIdent".</remarks>
  default this.BeforeVisitPat_LongIdent(dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.Ident option, item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option, item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs, item5: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_LongIdent(dotId, item2, item3 |> (Option.map (this.VisitValTyparDecls context)), item4 |> (this.VisitConstructorArgs context), item5 |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  abstract member VisitPat_LongIdent: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * item2: Microsoft.FSharp.Compiler.Ast.Ident option * item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option * item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs * item5: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  default __.VisitPat_LongIdent(dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, item2: Microsoft.FSharp.Compiler.Ast.Ident option, item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option, item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs, item5: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range)

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Tuple".</remarks>
  abstract member BeforeVisitPat_Tuple: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Tuple".</remarks>
  default this.BeforeVisitPat_Tuple(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Tuple(item1, range, context)

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  abstract member VisitPat_Tuple: item1: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  default __.VisitPat_Tuple(item1: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range)

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Paren".</remarks>
  abstract member BeforeVisitPat_Paren: item1: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Paren".</remarks>
  default this.BeforeVisitPat_Paren(item1: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Paren(item1 |> (this.VisitPat context), range, context)

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  abstract member VisitPat_Paren: item1: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  default __.VisitPat_Paren(item1: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range)

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_ArrayOrList".</remarks>
  abstract member BeforeVisitPat_ArrayOrList: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_ArrayOrList".</remarks>
  default this.BeforeVisitPat_ArrayOrList(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_ArrayOrList(item1, item2, range, context)

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  abstract member VisitPat_ArrayOrList: item1: bool * item2: Microsoft.FSharp.Compiler.Ast.SynPat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  default __.VisitPat_ArrayOrList(item1: bool, item2: Microsoft.FSharp.Compiler.Ast.SynPat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Record".</remarks>
  abstract member BeforeVisitPat_Record: fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Record".</remarks>
  default this.BeforeVisitPat_Record(fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Record(fields, range, context)

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  abstract member VisitPat_Record: fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  default __.VisitPat_Record(fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range)

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Null".</remarks>
  abstract member BeforeVisitPat_Null: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Null".</remarks>
  default this.BeforeVisitPat_Null(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_Null(range, context)

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  abstract member VisitPat_Null: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  default __.VisitPat_Null(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.Null(range)

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_OptionalVal".</remarks>
  abstract member BeforeVisitPat_OptionalVal: item1: Microsoft.FSharp.Compiler.Ast.Ident * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_OptionalVal".</remarks>
  default this.BeforeVisitPat_OptionalVal(item1: Microsoft.FSharp.Compiler.Ast.Ident, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_OptionalVal(item1, range, context)

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  abstract member VisitPat_OptionalVal: item1: Microsoft.FSharp.Compiler.Ast.Ident * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  default __.VisitPat_OptionalVal(item1: Microsoft.FSharp.Compiler.Ast.Ident, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range)

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_IsInst".</remarks>
  abstract member BeforeVisitPat_IsInst: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_IsInst".</remarks>
  default this.BeforeVisitPat_IsInst(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_IsInst(typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  abstract member VisitPat_IsInst: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  default __.VisitPat_IsInst(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range)

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_QuoteExpr".</remarks>
  abstract member BeforeVisitPat_QuoteExpr: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_QuoteExpr".</remarks>
  default this.BeforeVisitPat_QuoteExpr(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_QuoteExpr(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  abstract member VisitPat_QuoteExpr: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  default __.VisitPat_QuoteExpr(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range)

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_DeprecatedCharRange".</remarks>
  abstract member BeforeVisitPat_DeprecatedCharRange: item1: System.Char * item2: System.Char * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_DeprecatedCharRange".</remarks>
  default this.BeforeVisitPat_DeprecatedCharRange(item1: System.Char, item2: System.Char, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_DeprecatedCharRange(item1, item2, range, context)

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  abstract member VisitPat_DeprecatedCharRange: item1: System.Char * item2: System.Char * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  default __.VisitPat_DeprecatedCharRange(item1: System.Char, item2: System.Char, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range)

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_InstanceMember".</remarks>
  abstract member BeforeVisitPat_InstanceMember: item1: Microsoft.FSharp.Compiler.Ast.Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident * item3: Microsoft.FSharp.Compiler.Ast.Ident option * accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_InstanceMember".</remarks>
  default this.BeforeVisitPat_InstanceMember(item1: Microsoft.FSharp.Compiler.Ast.Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident, item3: Microsoft.FSharp.Compiler.Ast.Ident option, accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_InstanceMember(item1, item2, item3, accesiblity |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  abstract member VisitPat_InstanceMember: item1: Microsoft.FSharp.Compiler.Ast.Ident * item2: Microsoft.FSharp.Compiler.Ast.Ident * item3: Microsoft.FSharp.Compiler.Ast.Ident option * accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  default __.VisitPat_InstanceMember(item1: Microsoft.FSharp.Compiler.Ast.Ident, item2: Microsoft.FSharp.Compiler.Ast.Ident, item3: Microsoft.FSharp.Compiler.Ast.Ident option, accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range)

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_FromParseError".</remarks>
  abstract member BeforeVisitPat_FromParseError: item1: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_FromParseError".</remarks>
  default this.BeforeVisitPat_FromParseError(item1: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitPat_FromParseError(item1 |> (this.VisitPat context), range, context)

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  abstract member VisitPat_FromParseError: item1: Microsoft.FSharp.Compiler.Ast.SynPat * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynPat

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  default __.VisitPat_FromParseError(item1: Microsoft.FSharp.Compiler.Ast.SynPat, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range)


  /// <summary>
  /// Visit and dispatch "SynPat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synPat">SynPat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitPat (context: 'TContext) (synPat: Microsoft.FSharp.Compiler.Ast.SynPat) =
    parents.Push(AstElement.Pat synPat)
    try
      match synPat with
      | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
        this.BeforeVisitPat_Const(constant, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range) ->
        this.BeforeVisitPat_Wild(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
        this.BeforeVisitPat_Named(item1, id, isThisVar, accessiblity, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
        this.BeforeVisitPat_Typed(item1, typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
        this.BeforeVisitPat_Attrib(item1, attributes, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
        this.BeforeVisitPat_Or(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
        this.BeforeVisitPat_Ands(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
        this.BeforeVisitPat_LongIdent(dotId, item2, item3, item4, item5, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
        this.BeforeVisitPat_Tuple(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
        this.BeforeVisitPat_Paren(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
        this.BeforeVisitPat_ArrayOrList(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
        this.BeforeVisitPat_Record(fields, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Null(range) ->
        this.BeforeVisitPat_Null(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range) ->
        this.BeforeVisitPat_OptionalVal(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
        this.BeforeVisitPat_IsInst(typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
        this.BeforeVisitPat_QuoteExpr(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range) ->
        this.BeforeVisitPat_DeprecatedCharRange(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
        this.BeforeVisitPat_InstanceMember(item1, item2, item3, accesiblity, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
        this.BeforeVisitPat_FromParseError(item1, range, context)
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
  abstract member BeforeVisitRationalConst_Integer: item: int * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Integer".</remarks>
  default this.BeforeVisitRationalConst_Integer(item: int, context: 'TContext) =
    this.VisitRationalConst_Integer(item, context)

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  abstract member VisitRationalConst_Integer: item: int * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  default __.VisitRationalConst_Integer(item: int, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item)

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Rational".</remarks>
  abstract member BeforeVisitRationalConst_Rational: item1: int * item2: int * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Rational".</remarks>
  default this.BeforeVisitRationalConst_Rational(item1: int, item2: int, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitRationalConst_Rational(item1, item2, item3, context)

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  abstract member VisitRationalConst_Rational: item1: int * item2: int * item3: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  default __.VisitRationalConst_Rational(item1: int, item2: int, item3: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3)

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Negate".</remarks>
  abstract member BeforeVisitRationalConst_Negate: item: Microsoft.FSharp.Compiler.Ast.SynRationalConst * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Negate".</remarks>
  default this.BeforeVisitRationalConst_Negate(item: Microsoft.FSharp.Compiler.Ast.SynRationalConst, context: 'TContext) =
    this.VisitRationalConst_Negate(item |> (this.VisitRationalConst context), context)

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  abstract member VisitRationalConst_Negate: item: Microsoft.FSharp.Compiler.Ast.SynRationalConst * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynRationalConst

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  default __.VisitRationalConst_Negate(item: Microsoft.FSharp.Compiler.Ast.SynRationalConst, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item)


  /// <summary>
  /// Visit and dispatch "SynRationalConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synRationalConst">SynRationalConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitRationalConst (context: 'TContext) (synRationalConst: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    parents.Push(AstElement.RationalConst synRationalConst)
    try
      match synRationalConst with
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item) ->
        this.BeforeVisitRationalConst_Integer(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3) ->
        this.BeforeVisitRationalConst_Rational(item1, item2, item3, context)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
        this.BeforeVisitRationalConst_Negate(item, context)
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
  abstract member BeforeVisitReturnInfo_SynReturnInfo: item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitReturnInfo_SynReturnInfo".</remarks>
  default this.BeforeVisitReturnInfo_SynReturnInfo(item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo), range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitReturnInfo_SynReturnInfo(item1, range, context)

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  abstract member VisitReturnInfo_SynReturnInfo: item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo) * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynReturnInfo

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  default __.VisitReturnInfo_SynReturnInfo(item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo), range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range)


  /// <summary>
  /// Visit and dispatch "SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synReturnInfo">SynReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitReturnInfo (context: 'TContext) (synReturnInfo: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    parents.Push(AstElement.ReturnInfo synReturnInfo)
    try
      match synReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
        this.BeforeVisitReturnInfo_SynReturnInfo(item1, range, context)
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
  abstract member BeforeVisitSimplePat_Id: ident: Microsoft.FSharp.Compiler.Ast.Ident * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * isCompilerGenerated: bool * isThisVar: bool * isOptArg: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Id".</remarks>
  default this.BeforeVisitSimplePat_Id(ident: Microsoft.FSharp.Compiler.Ast.Ident, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, isCompilerGenerated: bool, isThisVar: bool, isOptArg: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSimplePat_Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range, context)

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  abstract member VisitSimplePat_Id: ident: Microsoft.FSharp.Compiler.Ast.Ident * altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option * isCompilerGenerated: bool * isThisVar: bool * isOptArg: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  default __.VisitSimplePat_Id(ident: Microsoft.FSharp.Compiler.Ast.Ident, altNameRefCell: Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo> option, isCompilerGenerated: bool, isThisVar: bool, isOptArg: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Typed".</remarks>
  abstract member BeforeVisitSimplePat_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Typed".</remarks>
  default this.BeforeVisitSimplePat_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSimplePat_Typed(item1 |> (this.VisitSimplePat context), typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  abstract member VisitSimplePat_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat * typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  default __.VisitSimplePat_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat, typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range)

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Attrib".</remarks>
  abstract member BeforeVisitSimplePat_Attrib: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Attrib".</remarks>
  default this.BeforeVisitSimplePat_Attrib(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSimplePat_Attrib(item1 |> (this.VisitSimplePat context), attributes, range, context)

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  abstract member VisitSimplePat_Attrib: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat * attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePat

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  default __.VisitSimplePat_Attrib(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat, attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePat">SynSimplePat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePat (context: 'TContext) (synSimplePat: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    parents.Push(AstElement.SimplePat synSimplePat)
    try
      match synSimplePat with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
        this.BeforeVisitSimplePat_Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
        this.BeforeVisitSimplePat_Typed(item1, typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
        this.BeforeVisitSimplePat_Attrib(item1, attributes, range, context)
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
  abstract member BeforeVisitSimplePatAlternativeIdInfo_Undecided: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Undecided".</remarks>
  default this.BeforeVisitSimplePatAlternativeIdInfo_Undecided(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    this.VisitSimplePatAlternativeIdInfo_Undecided(item, context)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  abstract member VisitSimplePatAlternativeIdInfo_Undecided: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  default __.VisitSimplePatAlternativeIdInfo_Undecided(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item)

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Decided".</remarks>
  abstract member BeforeVisitSimplePatAlternativeIdInfo_Decided: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Decided".</remarks>
  default this.BeforeVisitSimplePatAlternativeIdInfo_Decided(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    this.VisitSimplePatAlternativeIdInfo_Decided(item, context)

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  abstract member VisitSimplePatAlternativeIdInfo_Decided: item: Microsoft.FSharp.Compiler.Ast.Ident * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  default __.VisitSimplePatAlternativeIdInfo_Decided(item: Microsoft.FSharp.Compiler.Ast.Ident, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item)


  /// <summary>
  /// Visit and dispatch "SynSimplePatAlternativeIdInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePatAlternativeIdInfo">SynSimplePatAlternativeIdInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePatAlternativeIdInfo (context: 'TContext) (synSimplePatAlternativeIdInfo: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    parents.Push(AstElement.SimplePatAlternativeIdInfo synSimplePatAlternativeIdInfo)
    try
      match synSimplePatAlternativeIdInfo with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item) ->
        this.BeforeVisitSimplePatAlternativeIdInfo_Undecided(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item) ->
        this.BeforeVisitSimplePatAlternativeIdInfo_Decided(item, context)
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
  abstract member BeforeVisitSimplePats_SimplePats: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_SimplePats".</remarks>
  default this.BeforeVisitSimplePats_SimplePats(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSimplePats_SimplePats(item1, range, context)

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  abstract member VisitSimplePats_SimplePats: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  default __.VisitSimplePats_SimplePats(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range)

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_Typed".</remarks>
  abstract member BeforeVisitSimplePats_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_Typed".</remarks>
  default this.BeforeVisitSimplePats_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitSimplePats_Typed(item1 |> (this.VisitSimplePats context), item2 |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  abstract member VisitSimplePats_Typed: item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynSimplePats

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  default __.VisitSimplePats_Typed(item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynSimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePats">SynSimplePats expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePats (context: 'TContext) (synSimplePats: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    parents.Push(AstElement.SimplePats synSimplePats)
    try
      match synSimplePats with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
        this.BeforeVisitSimplePats_SimplePats(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
        this.BeforeVisitSimplePats_Typed(item1, item2, range, context)
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
  abstract member BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon".</remarks>
  default this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(item1 |> (this.VisitTypar context), item2 |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  abstract member VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  default __.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range)

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparIsStruct".</remarks>
  abstract member BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparIsStruct".</remarks>
  default this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitStaticOptimizationConstraint_WhenTyparIsStruct(item1 |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  abstract member VisitStaticOptimizationConstraint_WhenTyparIsStruct: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  default __.VisitStaticOptimizationConstraint_WhenTyparIsStruct(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range)


  /// <summary>
  /// Visit and dispatch "SynStaticOptimizationConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synStaticOptimizationConstraint">SynStaticOptimizationConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitStaticOptimizationConstraint (context: 'TContext) (synStaticOptimizationConstraint: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    parents.Push(AstElement.StaticOptimizationConstraint synStaticOptimizationConstraint)
    try
      match synStaticOptimizationConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct(item1, range, context)
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
  abstract member BeforeVisitTypar_Typar: id: Microsoft.FSharp.Compiler.Ast.Ident * staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq * isCompGen: bool * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar_Typar".</remarks>
  default this.BeforeVisitTypar_Typar(id: Microsoft.FSharp.Compiler.Ast.Ident, staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq, isCompGen: bool, context: 'TContext) =
    this.VisitTypar_Typar(id, staticReq, isCompGen, context)

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  abstract member VisitTypar_Typar: id: Microsoft.FSharp.Compiler.Ast.Ident * staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq * isCompGen: bool * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypar

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  default __.VisitTypar_Typar(id: Microsoft.FSharp.Compiler.Ast.Ident, staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq, isCompGen: bool, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen)


  /// <summary>
  /// Visit and dispatch "SynTypar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypar">SynTypar expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypar (context: 'TContext) (synTypar: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    parents.Push(AstElement.Typar synTypar)
    try
      match synTypar with
      | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen) ->
        this.BeforeVisitTypar_Typar(id, staticReq, isCompGen, context)
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
  abstract member BeforeVisitTyparDecl_TyparDecl: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Ast.SynTypar * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl_TyparDecl".</remarks>
  default this.BeforeVisitTyparDecl_TyparDecl(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Ast.SynTypar, context: 'TContext) =
    this.VisitTyparDecl_TyparDecl(attributes, item2 |> (this.VisitTypar context), context)

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  abstract member VisitTyparDecl_TyparDecl: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * item2: Microsoft.FSharp.Compiler.Ast.SynTypar * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTyparDecl

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  default __.VisitTyparDecl_TyparDecl(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, item2: Microsoft.FSharp.Compiler.Ast.SynTypar, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2)


  /// <summary>
  /// Visit and dispatch "SynTyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTyparDecl">SynTyparDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTyparDecl (context: 'TContext) (synTyparDecl: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    parents.Push(AstElement.TyparDecl synTyparDecl)
    try
      match synTyparDecl with
      | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
        this.BeforeVisitTyparDecl_TyparDecl(attributes, item2, context)
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
  abstract member BeforeVisitType_LongIdent: item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdent".</remarks>
  default this.BeforeVisitType_LongIdent(item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, context: 'TContext) =
    this.VisitType_LongIdent(item, context)

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  abstract member VisitType_LongIdent: item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  default __.VisitType_LongIdent(item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item)

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_App".</remarks>
  abstract member BeforeVisitType_App: typeName: Microsoft.FSharp.Compiler.Ast.SynType * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * isPostfix: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_App".</remarks>
  default this.BeforeVisitType_App(typeName: Microsoft.FSharp.Compiler.Ast.SynType, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, isPostfix: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_App(typeName |> (this.VisitType context), leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range, context)

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  abstract member VisitType_App: typeName: Microsoft.FSharp.Compiler.Ast.SynType * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * isPostfix: bool * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  default __.VisitType_App(typeName: Microsoft.FSharp.Compiler.Ast.SynType, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, isPostfix: bool, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdentApp".</remarks>
  abstract member BeforeVisitType_LongIdentApp: typeName: Microsoft.FSharp.Compiler.Ast.SynType * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * genericNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdentApp".</remarks>
  default this.BeforeVisitType_LongIdentApp(typeName: Microsoft.FSharp.Compiler.Ast.SynType, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, genericNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_LongIdentApp(typeName |> (this.VisitType context), dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range, context)

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  abstract member VisitType_LongIdentApp: typeName: Microsoft.FSharp.Compiler.Ast.SynType * dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * leftAngleRange: Microsoft.FSharp.Compiler.Range.range option * genericNames: Microsoft.FSharp.Compiler.Ast.SynType list * commaRanges: Microsoft.FSharp.Compiler.Range.range list * rightAngleRange: Microsoft.FSharp.Compiler.Range.range option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  default __.VisitType_LongIdentApp(typeName: Microsoft.FSharp.Compiler.Ast.SynType, dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, leftAngleRange: Microsoft.FSharp.Compiler.Range.range option, genericNames: Microsoft.FSharp.Compiler.Ast.SynType list, commaRanges: Microsoft.FSharp.Compiler.Range.range list, rightAngleRange: Microsoft.FSharp.Compiler.Range.range option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Tuple".</remarks>
  abstract member BeforeVisitType_Tuple: item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Tuple".</remarks>
  default this.BeforeVisitType_Tuple(item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_Tuple(item1, range, context)

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  abstract member VisitType_Tuple: item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  default __.VisitType_Tuple(item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range)

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Array".</remarks>
  abstract member BeforeVisitType_Array: item1: int * elementType: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Array".</remarks>
  default this.BeforeVisitType_Array(item1: int, elementType: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_Array(item1, elementType |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  abstract member VisitType_Array: item1: int * elementType: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  default __.VisitType_Array(item1: int, elementType: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range)

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Fun".</remarks>
  abstract member BeforeVisitType_Fun: argType: Microsoft.FSharp.Compiler.Ast.SynType * returnType: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Fun".</remarks>
  default this.BeforeVisitType_Fun(argType: Microsoft.FSharp.Compiler.Ast.SynType, returnType: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_Fun(argType |> (this.VisitType context), returnType |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  abstract member VisitType_Fun: argType: Microsoft.FSharp.Compiler.Ast.SynType * returnType: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  default __.VisitType_Fun(argType: Microsoft.FSharp.Compiler.Ast.SynType, returnType: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range)

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Var".</remarks>
  abstract member BeforeVisitType_Var: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Var".</remarks>
  default this.BeforeVisitType_Var(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_Var(item1 |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  abstract member VisitType_Var: item1: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  default __.VisitType_Var(item1: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range)

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Anon".</remarks>
  abstract member BeforeVisitType_Anon: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Anon".</remarks>
  default this.BeforeVisitType_Anon(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_Anon(range, context)

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  abstract member VisitType_Anon: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  default __.VisitType_Anon(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.Anon(range)

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_WithGlobalConstraints".</remarks>
  abstract member BeforeVisitType_WithGlobalConstraints: typeName: Microsoft.FSharp.Compiler.Ast.SynType * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_WithGlobalConstraints".</remarks>
  default this.BeforeVisitType_WithGlobalConstraints(typeName: Microsoft.FSharp.Compiler.Ast.SynType, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_WithGlobalConstraints(typeName |> (this.VisitType context), constraints, range, context)

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  abstract member VisitType_WithGlobalConstraints: typeName: Microsoft.FSharp.Compiler.Ast.SynType * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  default __.VisitType_WithGlobalConstraints(typeName: Microsoft.FSharp.Compiler.Ast.SynType, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range)

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_HashConstraint".</remarks>
  abstract member BeforeVisitType_HashConstraint: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_HashConstraint".</remarks>
  default this.BeforeVisitType_HashConstraint(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_HashConstraint(typeName |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  abstract member VisitType_HashConstraint: typeName: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  default __.VisitType_HashConstraint(typeName: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range)

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasureDivide".</remarks>
  abstract member BeforeVisitType_MeasureDivide: typeName: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasureDivide".</remarks>
  default this.BeforeVisitType_MeasureDivide(typeName: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_MeasureDivide(typeName |> (this.VisitType context), item2 |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  abstract member VisitType_MeasureDivide: typeName: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  default __.VisitType_MeasureDivide(typeName: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasurePower".</remarks>
  abstract member BeforeVisitType_MeasurePower: typeName: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasurePower".</remarks>
  default this.BeforeVisitType_MeasurePower(typeName: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_MeasurePower(typeName |> (this.VisitType context), item2 |> (this.VisitRationalConst context), range, context)

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  abstract member VisitType_MeasurePower: typeName: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  default __.VisitType_MeasurePower(typeName: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range)

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstant".</remarks>
  abstract member BeforeVisitType_StaticConstant: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstant".</remarks>
  default this.BeforeVisitType_StaticConstant(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_StaticConstant(constant |> (this.VisitConst context), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  abstract member VisitType_StaticConstant: constant: Microsoft.FSharp.Compiler.Ast.SynConst * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  default __.VisitType_StaticConstant(constant: Microsoft.FSharp.Compiler.Ast.SynConst, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantExpr".</remarks>
  abstract member BeforeVisitType_StaticConstantExpr: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantExpr".</remarks>
  default this.BeforeVisitType_StaticConstantExpr(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_StaticConstantExpr(expr |> (this.VisitExpr context), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  abstract member VisitType_StaticConstantExpr: expr: Microsoft.FSharp.Compiler.Ast.SynExpr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  default __.VisitType_StaticConstantExpr(expr: Microsoft.FSharp.Compiler.Ast.SynExpr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range)

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantNamed".</remarks>
  abstract member BeforeVisitType_StaticConstantNamed: item1: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantNamed".</remarks>
  default this.BeforeVisitType_StaticConstantNamed(item1: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitType_StaticConstantNamed(item1 |> (this.VisitType context), item2 |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  abstract member VisitType_StaticConstantNamed: item1: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynType

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  default __.VisitType_StaticConstantNamed(item1: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range)


  /// <summary>
  /// Visit and dispatch "SynType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synType">SynType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitType (context: 'TContext) (synType: Microsoft.FSharp.Compiler.Ast.SynType) =
    parents.Push(AstElement.Type synType)
    try
      match synType with
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item) ->
        this.BeforeVisitType_LongIdent(item, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
        this.BeforeVisitType_App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
        this.BeforeVisitType_LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
        this.BeforeVisitType_Tuple(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
        this.BeforeVisitType_Array(item1, elementType, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
        this.BeforeVisitType_Fun(argType, returnType, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
        this.BeforeVisitType_Var(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.Anon(range) ->
        this.BeforeVisitType_Anon(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
        this.BeforeVisitType_WithGlobalConstraints(typeName, constraints, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
        this.BeforeVisitType_HashConstraint(typeName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
        this.BeforeVisitType_MeasureDivide(typeName, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
        this.BeforeVisitType_MeasurePower(typeName, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
        this.BeforeVisitType_StaticConstant(constant, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
        this.BeforeVisitType_StaticConstantExpr(expr, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
        this.BeforeVisitType_StaticConstantNamed(item1, item2, range, context)
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
  abstract member BeforeVisitTypeConstraint_WhereTyparIsValueType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsValueType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsValueType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsValueType(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsValueType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsValueType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsReferenceType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsReferenceType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsReferenceType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsReferenceType(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsReferenceType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsReferenceType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsUnmanaged".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsUnmanaged: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsUnmanaged".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsUnmanaged(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsUnmanaged: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsUnmanaged(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsNull".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSupportsNull: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsNull".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSupportsNull(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparSupportsNull(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSupportsNull: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  default __.VisitTypeConstraint_WhereTyparSupportsNull(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsComparable".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsComparable: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsComparable".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsComparable(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsComparable(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsComparable: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsComparable(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEquatable".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsEquatable: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEquatable".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsEquatable(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsEquatable(genericName |> (this.VisitTypar context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsEquatable: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsEquatable(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparDefaultsToType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparDefaultsToType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparDefaultsToType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparDefaultsToType(genericName |> (this.VisitTypar context), typeSig |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparDefaultsToType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  default __.VisitTypeConstraint_WhereTyparDefaultsToType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSubtypeOfType".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSubtypeOfType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSubtypeOfType".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparSubtypeOfType(genericName |> (this.VisitTypar context), typeSig |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSubtypeOfType: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * typeSig: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  default __.VisitTypeConstraint_WhereTyparSubtypeOfType(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, typeSig: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsMember".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparSupportsMember: genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list * memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsMember".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparSupportsMember(genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list, memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparSupportsMember(genericNames, memberSig |> (this.VisitMemberSig context), range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  abstract member VisitTypeConstraint_WhereTyparSupportsMember: genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list * memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  default __.VisitTypeConstraint_WhereTyparSupportsMember(genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list, memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEnum".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsEnum: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEnum".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsEnum(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsEnum(genericName |> (this.VisitTypar context), enumTypes, range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsEnum: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsEnum(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range)

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsDelegate".</remarks>
  abstract member BeforeVisitTypeConstraint_WhereTyparIsDelegate: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsDelegate".</remarks>
  default this.BeforeVisitTypeConstraint_WhereTyparIsDelegate(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeConstraint_WhereTyparIsDelegate(genericName |> (this.VisitTypar context), delegateTypes, range, context)

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  abstract member VisitTypeConstraint_WhereTyparIsDelegate: genericName: Microsoft.FSharp.Compiler.Ast.SynTypar * delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  default __.VisitTypeConstraint_WhereTyparIsDelegate(genericName: Microsoft.FSharp.Compiler.Ast.SynTypar, delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range)


  /// <summary>
  /// Visit and dispatch "SynTypeConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeConstraint">SynTypeConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeConstraint (context: 'TContext) (synTypeConstraint: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    parents.Push(AstElement.TypeConstraint synTypeConstraint)
    try
      match synTypeConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsValueType(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsNull(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsComparable(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEquatable(genericName, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType(genericName, typeSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType(genericName, typeSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsMember(genericNames, memberSig, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEnum(genericName, enumTypes, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsDelegate(genericName, delegateTypes, range, context)
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
  abstract member BeforeVisitTypeDefn_TypeDefn: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn_TypeDefn".</remarks>
  default this.BeforeVisitTypeDefn_TypeDefn(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefn_TypeDefn(item1 |> (this.VisitComponentInfo context), item2 |> (this.VisitTypeDefnRepr context), members, range, context)

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  abstract member VisitTypeDefn_TypeDefn: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefn

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  default __.VisitTypeDefn_TypeDefn(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefn">SynTypeDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefn (context: 'TContext) (synTypeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    parents.Push(AstElement.TypeDefn synTypeDefn)
    try
      match synTypeDefn with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
        this.BeforeVisitTypeDefn_TypeDefn(item1, item2, members, range, context)
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
  abstract member BeforeVisitTypeDefnKind_TyconUnspecified: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnspecified".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconUnspecified(context: 'TContext) =
    this.VisitTypeDefnKind_TyconUnspecified(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  abstract member VisitTypeDefnKind_TyconUnspecified: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  default __.VisitTypeDefnKind_TyconUnspecified(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconClass".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconClass: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconClass".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconClass(context: 'TContext) =
    this.VisitTypeDefnKind_TyconClass(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  abstract member VisitTypeDefnKind_TyconClass: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  default __.VisitTypeDefnKind_TyconClass(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconInterface".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconInterface: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconInterface".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconInterface(context: 'TContext) =
    this.VisitTypeDefnKind_TyconInterface(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  abstract member VisitTypeDefnKind_TyconInterface: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  default __.VisitTypeDefnKind_TyconInterface(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconStruct".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconStruct: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconStruct".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconStruct(context: 'TContext) =
    this.VisitTypeDefnKind_TyconStruct(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  abstract member VisitTypeDefnKind_TyconStruct: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  default __.VisitTypeDefnKind_TyconStruct(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconRecord".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconRecord: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconRecord".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconRecord(context: 'TContext) =
    this.VisitTypeDefnKind_TyconRecord(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  abstract member VisitTypeDefnKind_TyconRecord: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  default __.VisitTypeDefnKind_TyconRecord(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnion".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconUnion: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnion".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconUnion(context: 'TContext) =
    this.VisitTypeDefnKind_TyconUnion(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  abstract member VisitTypeDefnKind_TyconUnion: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  default __.VisitTypeDefnKind_TyconUnion(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAbbrev".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconAbbrev: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAbbrev".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconAbbrev(context: 'TContext) =
    this.VisitTypeDefnKind_TyconAbbrev(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  abstract member VisitTypeDefnKind_TyconAbbrev: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  default __.VisitTypeDefnKind_TyconAbbrev(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconHiddenRepr".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconHiddenRepr: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconHiddenRepr".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconHiddenRepr(context: 'TContext) =
    this.VisitTypeDefnKind_TyconHiddenRepr(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  abstract member VisitTypeDefnKind_TyconHiddenRepr: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  default __.VisitTypeDefnKind_TyconHiddenRepr(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAugmentation".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconAugmentation: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAugmentation".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconAugmentation(context: 'TContext) =
    this.VisitTypeDefnKind_TyconAugmentation(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  abstract member VisitTypeDefnKind_TyconAugmentation: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  default __.VisitTypeDefnKind_TyconAugmentation(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconILAssemblyCode".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconILAssemblyCode: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconILAssemblyCode".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconILAssemblyCode(context: 'TContext) =
    this.VisitTypeDefnKind_TyconILAssemblyCode(context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  abstract member VisitTypeDefnKind_TyconILAssemblyCode: context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  default __.VisitTypeDefnKind_TyconILAssemblyCode(context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconDelegate".</remarks>
  abstract member BeforeVisitTypeDefnKind_TyconDelegate: item1: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynValInfo * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconDelegate".</remarks>
  default this.BeforeVisitTypeDefnKind_TyconDelegate(item1: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynValInfo, context: 'TContext) =
    this.VisitTypeDefnKind_TyconDelegate(item1 |> (this.VisitType context), item2 |> (this.VisitValInfo context), context)

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  abstract member VisitTypeDefnKind_TyconDelegate: item1: Microsoft.FSharp.Compiler.Ast.SynType * item2: Microsoft.FSharp.Compiler.Ast.SynValInfo * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  default __.VisitTypeDefnKind_TyconDelegate(item1: Microsoft.FSharp.Compiler.Ast.SynType, item2: Microsoft.FSharp.Compiler.Ast.SynValInfo, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnKind">SynTypeDefnKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnKind (context: 'TContext) (synTypeDefnKind: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
    parents.Push(AstElement.TypeDefnKind synTypeDefnKind)
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
        this.BeforeVisitTypeDefnKind_TyconDelegate(item1, item2, context)
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
  abstract member BeforeVisitTypeDefnRepr_ObjectModel: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_ObjectModel".</remarks>
  default this.BeforeVisitTypeDefnRepr_ObjectModel(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnRepr_ObjectModel(item1 |> (this.VisitTypeDefnKind context), members, range, context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  abstract member VisitTypeDefnRepr_ObjectModel: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  default __.VisitTypeDefnRepr_ObjectModel(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Simple".</remarks>
  abstract member BeforeVisitTypeDefnRepr_Simple: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Simple".</remarks>
  default this.BeforeVisitTypeDefnRepr_Simple(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnRepr_Simple(item1 |> (this.VisitTypeDefnSimpleRepr context), range, context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  abstract member VisitTypeDefnRepr_Simple: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  default __.VisitTypeDefnRepr_Simple(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    this.VisitTypeDefnRepr_Exception(item |> (this.VisitExceptionDefnRepr context), context)

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  abstract member VisitTypeDefnRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  default __.VisitTypeDefnRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnRepr">SynTypeDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnRepr (context: 'TContext) (synTypeDefnRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    parents.Push(AstElement.TypeDefnRepr synTypeDefnRepr)
    try
      match synTypeDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
        this.BeforeVisitTypeDefnRepr_ObjectModel(item1, members, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnRepr_Simple(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
        this.BeforeVisitTypeDefnRepr_Exception(item, context)
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
  abstract member BeforeVisitTypeDefnSig_TypeDefnSig: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig_TypeDefnSig".</remarks>
  default this.BeforeVisitTypeDefnSig_TypeDefnSig(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSig_TypeDefnSig(item1 |> (this.VisitComponentInfo context), item2 |> (this.VisitTypeDefnSigRepr context), memberSigs, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  abstract member VisitTypeDefnSig_TypeDefnSig: item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo * item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  default __.VisitTypeDefnSig_TypeDefnSig(item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo, item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSig">SynTypeDefnSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSig (context: 'TContext) (synTypeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    parents.Push(AstElement.TypeDefnSig synTypeDefnSig)
    try
      match synTypeDefnSig with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
        this.BeforeVisitTypeDefnSig_TypeDefnSig(item1, item2, memberSigs, range, context)
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
  abstract member BeforeVisitTypeDefnSigRepr_ObjectModel: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_ObjectModel".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_ObjectModel(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSigRepr_ObjectModel(item1 |> (this.VisitTypeDefnKind context), memberSigs, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  abstract member VisitTypeDefnSigRepr_ObjectModel: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  default __.VisitTypeDefnSigRepr_ObjectModel(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Simple".</remarks>
  abstract member BeforeVisitTypeDefnSigRepr_Simple: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Simple".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_Simple(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSigRepr_Simple(item1 |> (this.VisitTypeDefnSimpleRepr context), range, context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  abstract member VisitTypeDefnSigRepr_Simple: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  default __.VisitTypeDefnSigRepr_Simple(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnSigRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnSigRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    this.VisitTypeDefnSigRepr_Exception(item |> (this.VisitExceptionDefnRepr context), context)

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  abstract member VisitTypeDefnSigRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  default __.VisitTypeDefnSigRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSigRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSigRepr">SynTypeDefnSigRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSigRepr (context: 'TContext) (synTypeDefnSigRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    parents.Push(AstElement.TypeDefnSigRepr synTypeDefnSigRepr)
    try
      match synTypeDefnSigRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
        this.BeforeVisitTypeDefnSigRepr_ObjectModel(item1, memberSigs, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnSigRepr_Simple(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSigRepr_Exception(item, context)
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
  abstract member BeforeVisitTypeDefnSimpleRepr_Union: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Union".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Union(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_Union(accessiblity |> (Option.map (this.VisitAccess context)), cases, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Union: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  default __.VisitTypeDefnSimpleRepr_Union(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Enum".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Enum: cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Enum".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Enum(cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_Enum(cases, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Enum: cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  default __.VisitTypeDefnSimpleRepr_Enum(cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Record".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Record: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * fields: Microsoft.FSharp.Compiler.Ast.SynField list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Record".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Record(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, fields: Microsoft.FSharp.Compiler.Ast.SynField list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_Record(accessiblity |> (Option.map (this.VisitAccess context)), fields, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Record: accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * fields: Microsoft.FSharp.Compiler.Ast.SynField list * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  default __.VisitTypeDefnSimpleRepr_Record(accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, fields: Microsoft.FSharp.Compiler.Ast.SynField list, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_General".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_General: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list * item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list * item4: Microsoft.FSharp.Compiler.Ast.SynField list * item5: bool * item6: bool * item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_General".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_General(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list, item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list, item4: Microsoft.FSharp.Compiler.Ast.SynField list, item5: bool, item6: bool, item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_General(item1 |> (this.VisitTypeDefnKind context), item2, item3, item4, item5, item6, item7, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  abstract member VisitTypeDefnSimpleRepr_General: item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind * item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list * item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list * item4: Microsoft.FSharp.Compiler.Ast.SynField list * item5: bool * item6: bool * item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  default __.VisitTypeDefnSimpleRepr_General(item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind, item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list, item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list, item4: Microsoft.FSharp.Compiler.Ast.SynField list, item5: bool, item6: bool, item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(item1, range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  abstract member VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  default __.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_TypeAbbrev".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_TypeAbbrev: item1: Microsoft.FSharp.Compiler.Ast.ParserDetail * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_TypeAbbrev".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev(item1: Microsoft.FSharp.Compiler.Ast.ParserDetail, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_TypeAbbrev(item1, item2 |> (this.VisitType context), range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  abstract member VisitTypeDefnSimpleRepr_TypeAbbrev: item1: Microsoft.FSharp.Compiler.Ast.ParserDetail * item2: Microsoft.FSharp.Compiler.Ast.SynType * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  default __.VisitTypeDefnSimpleRepr_TypeAbbrev(item1: Microsoft.FSharp.Compiler.Ast.ParserDetail, item2: Microsoft.FSharp.Compiler.Ast.SynType, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_None".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_None: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_None".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_None(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_None(range, context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  abstract member VisitTypeDefnSimpleRepr_None: range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  default __.VisitTypeDefnSimpleRepr_None(range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range)

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Exception".</remarks>
  abstract member BeforeVisitTypeDefnSimpleRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Exception".</remarks>
  default this.BeforeVisitTypeDefnSimpleRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    this.VisitTypeDefnSimpleRepr_Exception(item |> (this.VisitExceptionDefnRepr context), context)

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  abstract member VisitTypeDefnSimpleRepr_Exception: item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  default __.VisitTypeDefnSimpleRepr_Exception(item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item)


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSimpleRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSimpleRepr">SynTypeDefnSimpleRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSimpleRepr (context: 'TContext) (synTypeDefnSimpleRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    parents.Push(AstElement.TypeDefnSimpleRepr synTypeDefnSimpleRepr)
    try
      match synTypeDefnSimpleRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Union(accessiblity, cases, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Enum(cases, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Record(accessiblity, fields, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_General(item1, item2, item3, item4, item5, item6, item7, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(item1, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev(item1, item2, range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range) ->
        this.BeforeVisitTypeDefnSimpleRepr_None(range, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSimpleRepr_Exception(item, context)
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
  abstract member BeforeVisitUnionCase_UnionCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase_UnionCase".</remarks>
  default this.BeforeVisitUnionCase_UnionCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitUnionCase_UnionCase(attributes, id, caseType |> (this.VisitUnionCaseType context), xmlDoc, accessibility |> (Option.map (this.VisitAccess context)), range, context)

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  abstract member VisitUnionCase_UnionCase: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCase

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  default __.VisitUnionCase_UnionCase(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range)


  /// <summary>
  /// Visit and dispatch "SynUnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCase">SynUnionCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCase (context: 'TContext) (synUnionCase: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    parents.Push(AstElement.UnionCase synUnionCase)
    try
      match synUnionCase with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
        this.BeforeVisitUnionCase_UnionCase(attributes, id, caseType, xmlDoc, accessibility, range, context)
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
  abstract member BeforeVisitUnionCaseType_UnionCaseFields: cases: Microsoft.FSharp.Compiler.Ast.SynField list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFields".</remarks>
  default this.BeforeVisitUnionCaseType_UnionCaseFields(cases: Microsoft.FSharp.Compiler.Ast.SynField list, context: 'TContext) =
    this.VisitUnionCaseType_UnionCaseFields(cases, context)

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  abstract member VisitUnionCaseType_UnionCaseFields: cases: Microsoft.FSharp.Compiler.Ast.SynField list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  default __.VisitUnionCaseType_UnionCaseFields(cases: Microsoft.FSharp.Compiler.Ast.SynField list, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases)

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFullType".</remarks>
  abstract member BeforeVisitUnionCaseType_UnionCaseFullType: item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFullType".</remarks>
  default this.BeforeVisitUnionCaseType_UnionCaseFullType(item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo), context: 'TContext) =
    this.VisitUnionCaseType_UnionCaseFullType(item, context)

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  abstract member VisitUnionCaseType_UnionCaseFullType: item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo) * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  default __.VisitUnionCaseType_UnionCaseFullType(item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo), context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item)


  /// <summary>
  /// Visit and dispatch "SynUnionCaseType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCaseType">SynUnionCaseType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCaseType (context: 'TContext) (synUnionCaseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    parents.Push(AstElement.UnionCaseType synUnionCaseType)
    try
      match synUnionCaseType with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
        this.BeforeVisitUnionCaseType_UnionCaseFields(cases, context)
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
        this.BeforeVisitUnionCaseType_UnionCaseFullType(item, context)
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
  abstract member BeforeVisitValData_SynValData: item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option * item2: Microsoft.FSharp.Compiler.Ast.SynValInfo * item3: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValData_SynValData".</remarks>
  default this.BeforeVisitValData_SynValData(item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option, item2: Microsoft.FSharp.Compiler.Ast.SynValInfo, item3: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    this.VisitValData_SynValData(item1, item2 |> (this.VisitValInfo context), item3, context)

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  abstract member VisitValData_SynValData: item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option * item2: Microsoft.FSharp.Compiler.Ast.SynValInfo * item3: Microsoft.FSharp.Compiler.Ast.Ident option * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValData

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  default __.VisitValData_SynValData(item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option, item2: Microsoft.FSharp.Compiler.Ast.SynValInfo, item3: Microsoft.FSharp.Compiler.Ast.Ident option, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3)


  /// <summary>
  /// Visit and dispatch "SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValData">SynValData expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValData (context: 'TContext) (synValData: Microsoft.FSharp.Compiler.Ast.SynValData) =
    parents.Push(AstElement.ValData synValData)
    try
      match synValData with
      | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
        this.BeforeVisitValData_SynValData(item1, item2, item3, context)
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
  abstract member BeforeVisitValInfo_SynValInfo: item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list * item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValInfo_SynValInfo".</remarks>
  default this.BeforeVisitValInfo_SynValInfo(item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list, item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo, context: 'TContext) =
    this.VisitValInfo_SynValInfo(item1, item2 |> (this.VisitArgInfo context), context)

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  abstract member VisitValInfo_SynValInfo: item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list * item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValInfo

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  default __.VisitValInfo_SynValInfo(item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list, item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2)


  /// <summary>
  /// Visit and dispatch "SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValInfo">SynValInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValInfo (context: 'TContext) (synValInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    parents.Push(AstElement.ValInfo synValInfo)
    try
      match synValInfo with
      | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
        this.BeforeVisitValInfo_SynValInfo(item1, item2, context)
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
  abstract member BeforeVisitValSig_ValSpfn: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls * typeName: Microsoft.FSharp.Compiler.Ast.SynType * valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo * item6: bool * isMutable: bool * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSig_ValSpfn".</remarks>
  default this.BeforeVisitValSig_ValSpfn(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls, typeName: Microsoft.FSharp.Compiler.Ast.SynType, valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo, item6: bool, isMutable: bool, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    this.VisitValSig_ValSpfn(attributes, id, typeParams |> (this.VisitValTyparDecls context), typeName |> (this.VisitType context), valInfo |> (this.VisitValInfo context), item6, isMutable, xmlDoc, accessiblity |> (Option.map (this.VisitAccess context)), expr |> (Option.map (this.VisitExpr context)), range, context)

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  abstract member VisitValSig_ValSpfn: attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list * id: Microsoft.FSharp.Compiler.Ast.Ident * typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls * typeName: Microsoft.FSharp.Compiler.Ast.SynType * valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo * item6: bool * isMutable: bool * xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc * accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option * expr: Microsoft.FSharp.Compiler.Ast.SynExpr option * range: Microsoft.FSharp.Compiler.Range.range * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValSig

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  default __.VisitValSig_ValSpfn(attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list, id: Microsoft.FSharp.Compiler.Ast.Ident, typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls, typeName: Microsoft.FSharp.Compiler.Ast.SynType, valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo, item6: bool, isMutable: bool, xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc, accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option, expr: Microsoft.FSharp.Compiler.Ast.SynExpr option, range: Microsoft.FSharp.Compiler.Range.range, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)


  /// <summary>
  /// Visit and dispatch "SynValSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValSig">SynValSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValSig (context: 'TContext) (synValSig: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    parents.Push(AstElement.ValSig synValSig)
    try
      match synValSig with
      | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
        this.BeforeVisitValSig_ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range, context)
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
  abstract member BeforeVisitValTyparDecls_SynValTyparDecls: item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * item2: bool * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValTyparDecls_SynValTyparDecls".</remarks>
  default this.BeforeVisitValTyparDecls_SynValTyparDecls(item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, item2: bool, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, context: 'TContext) =
    this.VisitValTyparDecls_SynValTyparDecls(item1, item2, constraints, context)

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  abstract member VisitValTyparDecls_SynValTyparDecls: item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list * item2: bool * constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list * context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynValTyparDecls

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  default __.VisitValTyparDecls_SynValTyparDecls(item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list, item2: bool, constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list, context: 'TContext) =
    Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints)


  /// <summary>
  /// Visit and dispatch "SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValTyparDecls">SynValTyparDecls expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValTyparDecls (context: 'TContext) (synValTyparDecls: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    parents.Push(AstElement.ValTyparDecls synValTyparDecls)
    try
      match synValTyparDecls with
      | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
        this.BeforeVisitValTyparDecls_SynValTyparDecls(item1, item2, constraints, context)
    finally
      parents.Pop() |> ignore

