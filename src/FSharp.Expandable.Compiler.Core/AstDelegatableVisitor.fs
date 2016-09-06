//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 06 Sep 2016 10:35:07 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

#nowarn "1182"

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST delegatable visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type AstDelegatableVisitor<'TContext> private (parentParents: System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.AstElement>) =

  // TODO: du element
  let parents = parentParents

  /// <summary>
  /// Constructor.
  /// </summary>
  new() =
    AstDelegatableVisitor<'TContext>(new System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.AstElement>())

  /// <summary>
  /// Parent nodes
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  /// <summary>
  /// Create child visitor.
  /// </summary> 
  /// <returns>Child empty visitor.</returns>
  member __.CreateChild() =
    new AstDelegatableVisitor<'TContext>(parents)

  //////////////////////////////////////////////
  // Expression: SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Public".</remarks>
  member val BeforeVisitAccess_Public =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitAccess_Public(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Public".</remarks>
  member val VisitAccess_Public =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Public
    with get, set

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Internal".</remarks>
  member val BeforeVisitAccess_Internal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitAccess_Internal(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Internal".</remarks>
  member val VisitAccess_Internal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Internal
    with get, set

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAccess_Private".</remarks>
  member val BeforeVisitAccess_Private =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitAccess_Private(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynAccess.Private".</remarks>
  member val VisitAccess_Private =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Private
    with get, set


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
        this.BeforeVisitAccess_Public(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal ->
        this.BeforeVisitAccess_Internal(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Private ->
        this.BeforeVisitAccess_Private(this, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArgInfo_SynArgInfo".</remarks>
  member val BeforeVisitArgInfo_SynArgInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       optional: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option) ->
      visitor.VisitArgInfo_SynArgInfo(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       optional,
       id)
    with get, set

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynArgInfo.SynArgInfo".</remarks>
  member val VisitArgInfo_SynArgInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       optional: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id)
    with get, set


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
        this.BeforeVisitArgInfo_SynArgInfo(this, context, attributes, optional, id)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBinding_Binding".</remarks>
  member val BeforeVisitBinding_Binding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) ->
      visitor.VisitBinding_Binding(
       visitor,
       context,
       access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       (visitor.VisitBindingKind context bindingKind),
       mustInline,
       isMutable,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       xmlDoc,
       (visitor.VisitValData context item7),
       (visitor.VisitPat context headPat),
       item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitBindingReturnInfo context v)),
       (visitor.VisitExpr context expr),
       lhsRange,
       spBind)
    with get, set

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBinding.Binding".</remarks>
  member val VisitBinding_Binding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)
    with get, set


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
        this.BeforeVisitBinding_Binding(this, context, access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_StandaloneExpression".</remarks>
  member val BeforeVisitBindingKind_StandaloneExpression =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitBindingKind_StandaloneExpression(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.StandaloneExpression".</remarks>
  member val VisitBindingKind_StandaloneExpression =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression
    with get, set

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_NormalBinding".</remarks>
  member val BeforeVisitBindingKind_NormalBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitBindingKind_NormalBinding(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.NormalBinding".</remarks>
  member val VisitBindingKind_NormalBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding
    with get, set

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingKind_DoBinding".</remarks>
  member val BeforeVisitBindingKind_DoBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitBindingKind_DoBinding(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingKind.DoBinding".</remarks>
  member val VisitBindingKind_DoBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding
    with get, set


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
        this.BeforeVisitBindingKind_StandaloneExpression(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding ->
        this.BeforeVisitBindingKind_NormalBinding(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding ->
        this.BeforeVisitBindingKind_DoBinding(this, context)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitBindingReturnInfo_SynBindingReturnInfo".</remarks>
  member val BeforeVisitBindingReturnInfo_SynBindingReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) ->
      visitor.VisitBindingReturnInfo_SynBindingReturnInfo(
       visitor,
       context,
       (visitor.VisitType context typeName),
       range,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range))
    with get, set

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynBindingReturnInfo.SynBindingReturnInfo".</remarks>
  member val VisitBindingReturnInfo_SynBindingReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes)
    with get, set


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
        this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo(this, context, typeName, range, attributes)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitComponentInfo_ComponentInfo".</remarks>
  member val BeforeVisitComponentInfo_ComponentInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       item4: Microsoft.FSharp.Compiler.Ast.Ident list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       preferPostfix: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitComponentInfo_ComponentInfo(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTyparDecl context v)),
       constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypeConstraint context v)),
       item4,
       xmlDoc,
       preferPostfix,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynComponentInfo.ComponentInfo".</remarks>
  member val VisitComponentInfo_ComponentInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       item4: Microsoft.FSharp.Compiler.Ast.Ident list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       preferPostfix: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)
    with get, set


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
        this.BeforeVisitComponentInfo_ComponentInfo(this, context, attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Unit".</remarks>
  member val BeforeVisitConst_Unit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitConst_Unit(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Unit".</remarks>
  member val VisitConst_Unit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Unit
    with get, set

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bool".</remarks>
  member val BeforeVisitConst_Bool =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: bool) ->
      visitor.VisitConst_Bool(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bool".</remarks>
  member val VisitConst_Bool =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: bool) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_SByte".</remarks>
  member val BeforeVisitConst_SByte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.SByte) ->
      visitor.VisitConst_SByte(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.SByte".</remarks>
  member val VisitConst_SByte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.SByte) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Byte".</remarks>
  member val BeforeVisitConst_Byte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: byte) ->
      visitor.VisitConst_Byte(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Byte".</remarks>
  member val VisitConst_Byte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: byte) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int16".</remarks>
  member val BeforeVisitConst_Int16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int16) ->
      visitor.VisitConst_Int16(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int16".</remarks>
  member val VisitConst_Int16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int16) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16".</remarks>
  member val BeforeVisitConst_UInt16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16) ->
      visitor.VisitConst_UInt16(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16".</remarks>
  member val VisitConst_UInt16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int32".</remarks>
  member val BeforeVisitConst_Int32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) ->
      visitor.VisitConst_Int32(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int32".</remarks>
  member val VisitConst_Int32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt32".</remarks>
  member val BeforeVisitConst_UInt32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt32) ->
      visitor.VisitConst_UInt32(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt32".</remarks>
  member val VisitConst_UInt32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt32) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Int64".</remarks>
  member val BeforeVisitConst_Int64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) ->
      visitor.VisitConst_Int64(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Int64".</remarks>
  member val VisitConst_Int64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt64".</remarks>
  member val BeforeVisitConst_UInt64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) ->
      visitor.VisitConst_UInt64(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt64".</remarks>
  member val VisitConst_UInt64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_IntPtr".</remarks>
  member val BeforeVisitConst_IntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) ->
      visitor.VisitConst_IntPtr(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.IntPtr".</remarks>
  member val VisitConst_IntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UIntPtr".</remarks>
  member val BeforeVisitConst_UIntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) ->
      visitor.VisitConst_UIntPtr(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UIntPtr".</remarks>
  member val VisitConst_UIntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Single".</remarks>
  member val BeforeVisitConst_Single =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Single) ->
      visitor.VisitConst_Single(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Single".</remarks>
  member val VisitConst_Single =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Single) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Single(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Double".</remarks>
  member val BeforeVisitConst_Double =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Double) ->
      visitor.VisitConst_Double(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Double".</remarks>
  member val VisitConst_Double =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Double) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Double(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Char".</remarks>
  member val BeforeVisitConst_Char =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: char) ->
      visitor.VisitConst_Char(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Char".</remarks>
  member val VisitConst_Char =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: char) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Char(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Decimal".</remarks>
  member val BeforeVisitConst_Decimal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Decimal) ->
      visitor.VisitConst_Decimal(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Decimal".</remarks>
  member val VisitConst_Decimal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Decimal) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UserNum".</remarks>
  member val BeforeVisitConst_UserNum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (string * string)) ->
      visitor.VisitConst_UserNum(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UserNum".</remarks>
  member val VisitConst_UserNum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (string * string)) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_String".</remarks>
  member val BeforeVisitConst_String =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       text: string,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitConst_String(
       visitor,
       context,
       text,
       range)
    with get, set

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.String".</remarks>
  member val VisitConst_String =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       text: string,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Bytes".</remarks>
  member val BeforeVisitConst_Bytes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bytes: byte[],
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitConst_Bytes(
       visitor,
       context,
       bytes,
       range)
    with get, set

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Bytes".</remarks>
  member val VisitConst_Bytes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bytes: byte[],
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range)
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_UInt16s".</remarks>
  member val BeforeVisitConst_UInt16s =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16[]) ->
      visitor.VisitConst_UInt16s(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.UInt16s".</remarks>
  member val VisitConst_UInt16s =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16[]) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item)
    with get, set

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst_Measure".</remarks>
  member val BeforeVisitConst_Measure =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) ->
      visitor.VisitConst_Measure(
       visitor,
       context,
       (visitor.VisitConst context constant),
       (visitor.VisitMeasure context item2))
    with get, set

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConst.Measure".</remarks>
  member val VisitConst_Measure =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2)
    with get, set


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
        this.BeforeVisitConst_Unit(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item) ->
        this.BeforeVisitConst_Bool(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item) ->
        this.BeforeVisitConst_SByte(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item) ->
        this.BeforeVisitConst_Byte(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item) ->
        this.BeforeVisitConst_Int16(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item) ->
        this.BeforeVisitConst_UInt16(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item) ->
        this.BeforeVisitConst_Int32(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item) ->
        this.BeforeVisitConst_UInt32(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item) ->
        this.BeforeVisitConst_Int64(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item) ->
        this.BeforeVisitConst_UInt64(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item) ->
        this.BeforeVisitConst_IntPtr(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item) ->
        this.BeforeVisitConst_UIntPtr(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Single(item) ->
        this.BeforeVisitConst_Single(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Double(item) ->
        this.BeforeVisitConst_Double(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Char(item) ->
        this.BeforeVisitConst_Char(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item) ->
        this.BeforeVisitConst_Decimal(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item) ->
        this.BeforeVisitConst_UserNum(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range) ->
        this.BeforeVisitConst_String(this, context, text, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range) ->
        this.BeforeVisitConst_Bytes(this, context, bytes, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item) ->
        this.BeforeVisitConst_UInt16s(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
        this.BeforeVisitConst_Measure(this, context, constant, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_Pats".</remarks>
  member val BeforeVisitConstructorArgs_Pats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynPat list) ->
      visitor.VisitConstructorArgs_Pats(
       visitor,
       context,
       item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitPat context v)))
    with get, set

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.Pats".</remarks>
  member val VisitConstructorArgs_Pats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynPat list) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item)
    with get, set

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConstructorArgs_NamePatPairs".</remarks>
  member val BeforeVisitConstructorArgs_NamePatPairs =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitConstructorArgs_NamePatPairs(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitor.VisitPat context v1))),
       range)
    with get, set

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynConstructorArgs.NamePatPairs".</remarks>
  member val VisitConstructorArgs_NamePatPairs =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range)
    with get, set


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
        this.BeforeVisitConstructorArgs_Pats(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
        this.BeforeVisitConstructorArgs_NamePatPairs(this, context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitEnumCase_EnumCase".</remarks>
  member val BeforeVisitEnumCase_EnumCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.SynConst,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitEnumCase_EnumCase(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       id,
       (visitor.VisitConst context item3),
       xmlDoc,
       range)
    with get, set

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynEnumCase.EnumCase".</remarks>
  member val VisitEnumCase_EnumCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.SynConst,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range)
    with get, set


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
        this.BeforeVisitEnumCase_EnumCase(this, context, attributes, id, item3, xmlDoc, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefn_SynExceptionDefn".</remarks>
  member val BeforeVisitExceptionDefn_SynExceptionDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExceptionDefn_SynExceptionDefn(
       visitor,
       context,
       (visitor.VisitExceptionDefnRepr context exnRepr),
       members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberDefn context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefn.SynExceptionDefn".</remarks>
  member val VisitExceptionDefn_SynExceptionDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range)
    with get, set


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
        this.BeforeVisitExceptionDefn_SynExceptionDefn(this, context, exnRepr, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionDefnRepr_SynExceptionDefnRepr".</remarks>
  member val BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExceptionDefnRepr_SynExceptionDefnRepr(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       (visitor.VisitUnionCase context case),
       longId,
       xmlDoc,
       accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionDefnRepr.SynExceptionDefnRepr".</remarks>
  member val VisitExceptionDefnRepr_SynExceptionDefnRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range)
    with get, set


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
        this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr(this, context, item1, case, longId, xmlDoc, accesibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExceptionSig_SynExceptionSig".</remarks>
  member val BeforeVisitExceptionSig_SynExceptionSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExceptionSig_SynExceptionSig(
       visitor,
       context,
       (visitor.VisitExceptionDefnRepr context exnRepr),
       memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberSig context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExceptionSig.SynExceptionSig".</remarks>
  member val VisitExceptionSig_SynExceptionSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range)
    with get, set


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
        this.BeforeVisitExceptionSig_SynExceptionSig(this, context, exnRepr, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Paren".</remarks>
  member val BeforeVisitExpr_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftParenRange: Microsoft.FSharp.Compiler.Range.range,
       rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Paren(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       leftParenRange,
       rightParenRange,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Paren".</remarks>
  member val VisitExpr_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftParenRange: Microsoft.FSharp.Compiler.Range.range,
       rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Quote".</remarks>
  member val BeforeVisitExpr_Quote =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isRaw: bool,
       quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isFromQueryExpression: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Quote(
       visitor,
       context,
       (visitor.VisitExpr context operator),
       isRaw,
       (visitor.VisitExpr context quotedSynExpr),
       isFromQueryExpression,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Quote".</remarks>
  member val VisitExpr_Quote =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isRaw: bool,
       quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isFromQueryExpression: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Const".</remarks>
  member val BeforeVisitExpr_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Const(
       visitor,
       context,
       (visitor.VisitConst context constant),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Const".</remarks>
  member val VisitExpr_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Typed".</remarks>
  member val BeforeVisitExpr_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Typed(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       (visitor.VisitType context typeSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Typed".</remarks>
  member val VisitExpr_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Tuple".</remarks>
  member val BeforeVisitExpr_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Tuple(
       visitor,
       context,
       exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitExpr context v)),
       commaRanges,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Tuple".</remarks>
  member val VisitExpr_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrList".</remarks>
  member val BeforeVisitExpr_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ArrayOrList(
       visitor,
       context,
       isList,
       exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitExpr context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrList".</remarks>
  member val VisitExpr_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Record".</remarks>
  member val BeforeVisitExpr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
       copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
       recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Record(
       visitor,
       context,
       baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitor.VisitType context v0), (visitor.VisitExpr context v1), v2, v3, v4)),
       copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitor.VisitExpr context v0), v1)),
       recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitExpr context v)), v2)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Record".</remarks>
  member val VisitExpr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
       copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
       recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_New".</remarks>
  member val BeforeVisitExpr_New =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isProtected: bool,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_New(
       visitor,
       context,
       isProtected,
       (visitor.VisitType context typeName),
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.New".</remarks>
  member val VisitExpr_New =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isProtected: bool,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ObjExpr".</remarks>
  member val BeforeVisitExpr_ObjExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objType: Microsoft.FSharp.Compiler.Ast.SynType,
       argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
       newPos: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ObjExpr(
       visitor,
       context,
       (visitor.VisitType context objType),
       argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitor.VisitExpr context v0), v1)),
       bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitBinding context v)),
       extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitInterfaceImpl context v)),
       newPos,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ObjExpr".</remarks>
  member val VisitExpr_ObjExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objType: Microsoft.FSharp.Compiler.Ast.SynType,
       argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
       newPos: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_While".</remarks>
  member val BeforeVisitExpr_While =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
       whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_While(
       visitor,
       context,
       spWhile,
       (visitor.VisitExpr context whileBody),
       (visitor.VisitExpr context doBody),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.While".</remarks>
  member val VisitExpr_While =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
       whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_For".</remarks>
  member val BeforeVisitExpr_For =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: bool,
       toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_For(
       visitor,
       context,
       spFor,
       id,
       (visitor.VisitExpr context idBody),
       item4,
       (visitor.VisitExpr context toBody),
       (visitor.VisitExpr context doBody),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.For".</remarks>
  member val VisitExpr_For =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: bool,
       toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ForEach".</remarks>
  member val BeforeVisitExpr_ForEach =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ForEach(
       visitor,
       context,
       spFor,
       seqExprOnly,
       isFromSource,
       (visitor.VisitPat context pattern),
       (visitor.VisitExpr context enumExpr),
       (visitor.VisitExpr context bodyExpr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ForEach".</remarks>
  member val VisitExpr_ForEach =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArrayOrListOfSeqExpr".</remarks>
  member val BeforeVisitExpr_ArrayOrListOfSeqExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ArrayOrListOfSeqExpr(
       visitor,
       context,
       isList,
       (visitor.VisitExpr context elements),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArrayOrListOfSeqExpr".</remarks>
  member val VisitExpr_ArrayOrListOfSeqExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_CompExpr".</remarks>
  member val BeforeVisitExpr_CompExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isArrayOrList: bool,
       isNotNakedRefCell: bool ref,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_CompExpr(
       visitor,
       context,
       isArrayOrList,
       isNotNakedRefCell,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.CompExpr".</remarks>
  member val VisitExpr_CompExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isArrayOrList: bool,
       isNotNakedRefCell: bool ref,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lambda".</remarks>
  member val BeforeVisitExpr_Lambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fromMethod: bool,
       inLambdaSeq: bool,
       args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       body: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Lambda(
       visitor,
       context,
       fromMethod,
       inLambdaSeq,
       (visitor.VisitSimplePats context args),
       (visitor.VisitExpr context body),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lambda".</remarks>
  member val VisitExpr_Lambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fromMethod: bool,
       inLambdaSeq: bool,
       args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       body: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_MatchLambda".</remarks>
  member val BeforeVisitExpr_MatchLambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Range.range,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_MatchLambda(
       visitor,
       context,
       item1,
       item2,
       clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMatchClause context v)),
       spBind,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.MatchLambda".</remarks>
  member val VisitExpr_MatchLambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Range.range,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Match".</remarks>
  member val BeforeVisitExpr_Match =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       isCexprExceptionMatch: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Match(
       visitor,
       context,
       spBind,
       (visitor.VisitExpr context matchExpr),
       clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMatchClause context v)),
       isCexprExceptionMatch,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Match".</remarks>
  member val VisitExpr_Match =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       isCexprExceptionMatch: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Do".</remarks>
  member val BeforeVisitExpr_Do =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Do(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Do".</remarks>
  member val VisitExpr_Do =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Assert".</remarks>
  member val BeforeVisitExpr_Assert =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Assert(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Assert".</remarks>
  member val VisitExpr_Assert =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_App".</remarks>
  member val BeforeVisitExpr_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
       isInfix: bool,
       funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_App(
       visitor,
       context,
       exprAtomicFlag,
       isInfix,
       (visitor.VisitExpr context funcExpr),
       (visitor.VisitExpr context argExpr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.App".</remarks>
  member val VisitExpr_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
       isInfix: bool,
       funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeApp".</remarks>
  member val BeforeVisitExpr_TypeApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
       typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_TypeApp(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       leftAngleRange,
       typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       commaRanges,
       rightAngleRange,
       typeArgs,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeApp".</remarks>
  member val VisitExpr_TypeApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
       typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUse".</remarks>
  member val BeforeVisitExpr_LetOrUse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isRecursive: bool,
       isUse: bool,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LetOrUse(
       visitor,
       context,
       isRecursive,
       isUse,
       bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitBinding context v)),
       (visitor.VisitExpr context exprBody),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUse".</remarks>
  member val VisitExpr_LetOrUse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isRecursive: bool,
       isUse: bool,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryWith".</remarks>
  member val BeforeVisitExpr_TryWith =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       item4: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) ->
      visitor.VisitExpr_TryWith(
       visitor,
       context,
       (visitor.VisitExpr context tryExpr),
       item2,
       item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMatchClause context v)),
       item4,
       range,
       spTry,
       spWith)
    with get, set

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryWith".</remarks>
  member val VisitExpr_TryWith =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       item4: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TryFinally".</remarks>
  member val BeforeVisitExpr_TryFinally =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) ->
      visitor.VisitExpr_TryFinally(
       visitor,
       context,
       (visitor.VisitExpr context tryExpr),
       (visitor.VisitExpr context finallyExpr),
       range,
       spTry,
       spFinally)
    with get, set

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TryFinally".</remarks>
  member val VisitExpr_TryFinally =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Lazy".</remarks>
  member val BeforeVisitExpr_Lazy =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Lazy(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Lazy".</remarks>
  member val VisitExpr_Lazy =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Sequential".</remarks>
  member val BeforeVisitExpr_Sequential =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
       isTrueSeq: bool,
       expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Sequential(
       visitor,
       context,
       spSeq,
       isTrueSeq,
       (visitor.VisitExpr context expr1),
       (visitor.VisitExpr context expr2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Sequential".</remarks>
  member val VisitExpr_Sequential =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
       isTrueSeq: bool,
       expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_IfThenElse".</remarks>
  member val BeforeVisitExpr_IfThenElse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
       exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
       optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isFromErrorRecovery: bool,
       ifToThen: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_IfThenElse(
       visitor,
       context,
       (visitor.VisitExpr context exprGuard),
       (visitor.VisitExpr context exprThen),
       optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitExpr context v)),
       spIfToThen,
       isFromErrorRecovery,
       ifToThen,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.IfThenElse".</remarks>
  member val VisitExpr_IfThenElse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
       exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
       optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isFromErrorRecovery: bool,
       ifToThen: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Ident".</remarks>
  member val BeforeVisitExpr_Ident =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      visitor.VisitExpr_Ident(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Ident".</remarks>
  member val VisitExpr_Ident =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdent".</remarks>
  member val BeforeVisitExpr_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isOptional: bool,
       longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      use _rwh_ = new RefWrapperHolder()
      visitor.VisitExpr_LongIdent(
       visitor,
       context,
       isOptional,
       longIdent,
       altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitor.VisitSimplePatAlternativeIdInfo context v.Value)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdent".</remarks>
  member val VisitExpr_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isOptional: bool,
       longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LongIdentSet".</remarks>
  member val BeforeVisitExpr_LongIdentSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LongIdentSet(
       visitor,
       context,
       dotId,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LongIdentSet".</remarks>
  member val VisitExpr_LongIdentSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotGet".</remarks>
  member val BeforeVisitExpr_DotGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DotGet(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       rangeOfDot,
       dotId,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotGet".</remarks>
  member val VisitExpr_DotGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotSet".</remarks>
  member val BeforeVisitExpr_DotSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DotSet(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       dotId,
       (visitor.VisitExpr context exprValue),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotSet".</remarks>
  member val VisitExpr_DotSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedGet".</remarks>
  member val BeforeVisitExpr_DotIndexedGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DotIndexedGet(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitIndexerArg context v)),
       item3,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedGet".</remarks>
  member val VisitExpr_DotIndexedGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotIndexedSet".</remarks>
  member val BeforeVisitExpr_DotIndexedSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DotIndexedSet(
       visitor,
       context,
       (visitor.VisitExpr context objectExpr),
       indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitIndexerArg context v)),
       (visitor.VisitExpr context valueExpr),
       rangeOfLeftOfSet,
       rangeOfDot,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotIndexedSet".</remarks>
  member val VisitExpr_DotIndexedSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_NamedIndexedPropertySet".</remarks>
  member val BeforeVisitExpr_NamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_NamedIndexedPropertySet(
       visitor,
       context,
       item1,
       (visitor.VisitExpr context item2),
       (visitor.VisitExpr context item3),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.NamedIndexedPropertySet".</remarks>
  member val VisitExpr_NamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DotNamedIndexedPropertySet".</remarks>
  member val BeforeVisitExpr_DotNamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DotNamedIndexedPropertySet(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       item2,
       (visitor.VisitExpr context item3),
       (visitor.VisitExpr context item4),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DotNamedIndexedPropertySet".</remarks>
  member val VisitExpr_DotNamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TypeTest".</remarks>
  member val BeforeVisitExpr_TypeTest =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_TypeTest(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TypeTest".</remarks>
  member val VisitExpr_TypeTest =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Upcast".</remarks>
  member val BeforeVisitExpr_Upcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Upcast(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       (visitor.VisitType context typeSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Upcast".</remarks>
  member val VisitExpr_Upcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Downcast".</remarks>
  member val BeforeVisitExpr_Downcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Downcast(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Downcast".</remarks>
  member val VisitExpr_Downcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredUpcast".</remarks>
  member val BeforeVisitExpr_InferredUpcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_InferredUpcast(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredUpcast".</remarks>
  member val VisitExpr_InferredUpcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_InferredDowncast".</remarks>
  member val BeforeVisitExpr_InferredDowncast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_InferredDowncast(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.InferredDowncast".</remarks>
  member val VisitExpr_InferredDowncast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Null".</remarks>
  member val BeforeVisitExpr_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Null(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Null".</remarks>
  member val VisitExpr_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_AddressOf".</remarks>
  member val BeforeVisitExpr_AddressOf =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_AddressOf(
       visitor,
       context,
       item1,
       (visitor.VisitExpr context item2),
       item3,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.AddressOf".</remarks>
  member val VisitExpr_AddressOf =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_TraitCall".</remarks>
  member val BeforeVisitExpr_TraitCall =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_TraitCall(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypar context v)),
       (visitor.VisitMemberSig context item2),
       (visitor.VisitExpr context item3),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.TraitCall".</remarks>
  member val VisitExpr_TraitCall =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_JoinIn".</remarks>
  member val BeforeVisitExpr_JoinIn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inPos: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_JoinIn(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       inPos,
       (visitor.VisitExpr context item3),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.JoinIn".</remarks>
  member val VisitExpr_JoinIn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inPos: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ImplicitZero".</remarks>
  member val BeforeVisitExpr_ImplicitZero =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ImplicitZero(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ImplicitZero".</remarks>
  member val VisitExpr_ImplicitZero =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturn".</remarks>
  member val BeforeVisitExpr_YieldOrReturn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_YieldOrReturn(
       visitor,
       context,
       item1,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturn".</remarks>
  member val VisitExpr_YieldOrReturn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_YieldOrReturnFrom".</remarks>
  member val BeforeVisitExpr_YieldOrReturnFrom =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_YieldOrReturnFrom(
       visitor,
       context,
       item1,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.YieldOrReturnFrom".</remarks>
  member val VisitExpr_YieldOrReturnFrom =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LetOrUseBang".</remarks>
  member val BeforeVisitExpr_LetOrUseBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isUse: bool,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LetOrUseBang(
       visitor,
       context,
       spBind,
       isUse,
       isFromSource,
       (visitor.VisitPat context pattern),
       (visitor.VisitExpr context rhsExpr),
       (visitor.VisitExpr context bodyExpr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LetOrUseBang".</remarks>
  member val VisitExpr_LetOrUseBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isUse: bool,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DoBang".</remarks>
  member val BeforeVisitExpr_DoBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DoBang(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DoBang".</remarks>
  member val VisitExpr_DoBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyILAssembly".</remarks>
  member val BeforeVisitExpr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
       item2: Microsoft.FSharp.Compiler.Ast.SynType list,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       item4: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LibraryOnlyILAssembly(
       visitor,
       context,
       item1,
       item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitExpr context v)),
       item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyILAssembly".</remarks>
  member val VisitExpr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
       item2: Microsoft.FSharp.Compiler.Ast.SynType list,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       item4: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyStaticOptimization".</remarks>
  member val BeforeVisitExpr_LibraryOnlyStaticOptimization =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LibraryOnlyStaticOptimization(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitStaticOptimizationConstraint context v)),
       (visitor.VisitExpr context item2),
       (visitor.VisitExpr context item3),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyStaticOptimization".</remarks>
  member val VisitExpr_LibraryOnlyStaticOptimization =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldGet".</remarks>
  member val BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LibraryOnlyUnionCaseFieldGet(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       longId,
       item3,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldGet".</remarks>
  member val VisitExpr_LibraryOnlyUnionCaseFieldGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_LibraryOnlyUnionCaseFieldSet".</remarks>
  member val BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_LibraryOnlyUnionCaseFieldSet(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       longId,
       item3,
       (visitor.VisitExpr context item4),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.LibraryOnlyUnionCaseFieldSet".</remarks>
  member val VisitExpr_LibraryOnlyUnionCaseFieldSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_ArbitraryAfterError".</remarks>
  member val BeforeVisitExpr_ArbitraryAfterError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       debugStr: string,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_ArbitraryAfterError(
       visitor,
       context,
       debugStr,
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.ArbitraryAfterError".</remarks>
  member val VisitExpr_ArbitraryAfterError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       debugStr: string,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_FromParseError".</remarks>
  member val BeforeVisitExpr_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_FromParseError(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.FromParseError".</remarks>
  member val VisitExpr_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_DiscardAfterMissingQualificationAfterDot".</remarks>
  member val BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_DiscardAfterMissingQualificationAfterDot(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.DiscardAfterMissingQualificationAfterDot".</remarks>
  member val VisitExpr_DiscardAfterMissingQualificationAfterDot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitExpr_Fixed".</remarks>
  member val BeforeVisitExpr_Fixed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitExpr_Fixed(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       item2)
    with get, set

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.Fixed".</remarks>
  member val VisitExpr_Fixed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2)
    with get, set


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
        this.BeforeVisitExpr_Paren(this, context, expr, leftParenRange, rightParenRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        this.BeforeVisitExpr_Quote(this, context, operator, isRaw, quotedSynExpr, isFromQueryExpression, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
        this.BeforeVisitExpr_Const(this, context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
        this.BeforeVisitExpr_Typed(this, context, expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
        this.BeforeVisitExpr_Tuple(this, context, exprs, commaRanges, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
        this.BeforeVisitExpr_ArrayOrList(this, context, isList, exprs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        this.BeforeVisitExpr_Record(this, context, baseInfo, copyInfo, recordFields, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
        this.BeforeVisitExpr_New(this, context, isProtected, typeName, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        this.BeforeVisitExpr_ObjExpr(this, context, objType, argOpt, bindings, extraImpls, newPos, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
        this.BeforeVisitExpr_While(this, context, spWhile, whileBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        this.BeforeVisitExpr_For(this, context, spFor, id, idBody, item4, toBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_ForEach(this, context, spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        this.BeforeVisitExpr_ArrayOrListOfSeqExpr(this, context, isList, elements, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        this.BeforeVisitExpr_CompExpr(this, context, isArrayOrList, isNotNakedRefCell, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        this.BeforeVisitExpr_Lambda(this, context, fromMethod, inLambdaSeq, args, body, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        this.BeforeVisitExpr_MatchLambda(this, context, item1, item2, clauses, spBind, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        this.BeforeVisitExpr_Match(this, context, spBind, matchExpr, clauses, isCexprExceptionMatch, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
        this.BeforeVisitExpr_Do(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
        this.BeforeVisitExpr_Assert(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        this.BeforeVisitExpr_App(this, context, exprAtomicFlag, isInfix, funcExpr, argExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        this.BeforeVisitExpr_TypeApp(this, context, expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        this.BeforeVisitExpr_LetOrUse(this, context, isRecursive, isUse, bindings, exprBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        this.BeforeVisitExpr_TryWith(this, context, tryExpr, item2, item3, item4, range, spTry, spWith)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        this.BeforeVisitExpr_TryFinally(this, context, tryExpr, finallyExpr, range, spTry, spFinally)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
        this.BeforeVisitExpr_Lazy(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        this.BeforeVisitExpr_Sequential(this, context, spSeq, isTrueSeq, expr1, expr2, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        this.BeforeVisitExpr_IfThenElse(this, context, exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
        this.BeforeVisitExpr_Ident(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        this.BeforeVisitExpr_LongIdent(this, context, isOptional, longIdent, altNameRefCell, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
        this.BeforeVisitExpr_LongIdentSet(this, context, dotId, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        this.BeforeVisitExpr_DotGet(this, context, expr, rangeOfDot, dotId, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
        this.BeforeVisitExpr_DotSet(this, context, expr, dotId, exprValue, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        this.BeforeVisitExpr_DotIndexedGet(this, context, expr, indexExprs, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        this.BeforeVisitExpr_DotIndexedSet(this, context, objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        this.BeforeVisitExpr_NamedIndexedPropertySet(this, context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_DotNamedIndexedPropertySet(this, context, item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
        this.BeforeVisitExpr_TypeTest(this, context, expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
        this.BeforeVisitExpr_Upcast(this, context, expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
        this.BeforeVisitExpr_Downcast(this, context, expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
        this.BeforeVisitExpr_InferredUpcast(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
        this.BeforeVisitExpr_InferredDowncast(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
        this.BeforeVisitExpr_Null(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
        this.BeforeVisitExpr_AddressOf(this, context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
        this.BeforeVisitExpr_TraitCall(this, context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
        this.BeforeVisitExpr_JoinIn(this, context, item1, inPos, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
        this.BeforeVisitExpr_ImplicitZero(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturn(this, context, item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        this.BeforeVisitExpr_YieldOrReturnFrom(this, context, item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        this.BeforeVisitExpr_LetOrUseBang(this, context, spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
        this.BeforeVisitExpr_DoBang(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyILAssembly(this, context, item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyStaticOptimization(this, context, item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet(this, context, item1, longId, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet(this, context, item1, longId, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
        this.BeforeVisitExpr_ArbitraryAfterError(this, context, debugStr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
        this.BeforeVisitExpr_FromParseError(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
        this.BeforeVisitExpr_Fixed(this, context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitField_Field".</remarks>
  member val BeforeVisitField_Field =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item5: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitField_Field(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       isStatic,
       id,
       (visitor.VisitType context typeName),
       item5,
       xmlDoc,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynField.Field".</remarks>
  member val VisitField_Field =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item5: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)
    with get, set


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
        this.BeforeVisitField_Field(this, context, attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_Two".</remarks>
  member val BeforeVisitIndexerArg_Two =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr) ->
      visitor.VisitIndexerArg_Two(
       visitor,
       context,
       (visitor.VisitExpr context item1),
       (visitor.VisitExpr context item2))
    with get, set

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.Two".</remarks>
  member val VisitIndexerArg_Two =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIndexerArg_One".</remarks>
  member val BeforeVisitIndexerArg_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExpr) ->
      visitor.VisitIndexerArg_One(
       visitor,
       context,
       (visitor.VisitExpr context item))
    with get, set

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynIndexerArg.One".</remarks>
  member val VisitIndexerArg_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExpr) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item)
    with get, set


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
        this.BeforeVisitIndexerArg_Two(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
        this.BeforeVisitIndexerArg_One(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInterfaceImpl_InterfaceImpl".</remarks>
  member val BeforeVisitInterfaceImpl_InterfaceImpl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitInterfaceImpl_InterfaceImpl(
       visitor,
       context,
       (visitor.VisitType context item1),
       bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitBinding context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynInterfaceImpl.InterfaceImpl".</remarks>
  member val VisitInterfaceImpl_InterfaceImpl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range)
    with get, set


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
        this.BeforeVisitInterfaceImpl_InterfaceImpl(this, context, item1, bindings, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchClause_Clause".</remarks>
  member val BeforeVisitMatchClause_Clause =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) ->
      visitor.VisitMatchClause_Clause(
       visitor,
       context,
       (visitor.VisitPat context item1),
       item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitExpr context v)),
       (visitor.VisitExpr context item3),
       range,
       spTarget)
    with get, set

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMatchClause.Clause".</remarks>
  member val VisitMatchClause_Clause =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget)
    with get, set


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
        this.BeforeVisitMatchClause_Clause(this, context, item1, item2, item3, range, spTarget)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Named".</remarks>
  member val BeforeVisitMeasure_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Named(
       visitor,
       context,
       longId,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Named".</remarks>
  member val VisitMeasure_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Product".</remarks>
  member val BeforeVisitMeasure_Product =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Product(
       visitor,
       context,
       (visitor.VisitMeasure context item1),
       (visitor.VisitMeasure context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Product".</remarks>
  member val VisitMeasure_Product =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Seq".</remarks>
  member val BeforeVisitMeasure_Seq =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Seq(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMeasure context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Seq".</remarks>
  member val VisitMeasure_Seq =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Divide".</remarks>
  member val BeforeVisitMeasure_Divide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Divide(
       visitor,
       context,
       (visitor.VisitMeasure context item1),
       (visitor.VisitMeasure context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Divide".</remarks>
  member val VisitMeasure_Divide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Power".</remarks>
  member val BeforeVisitMeasure_Power =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Power(
       visitor,
       context,
       (visitor.VisitMeasure context item1),
       (visitor.VisitRationalConst context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Power".</remarks>
  member val VisitMeasure_Power =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_One".</remarks>
  member val BeforeVisitMeasure_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitMeasure_One(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.One".</remarks>
  member val VisitMeasure_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.One
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Anon".</remarks>
  member val BeforeVisitMeasure_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Anon(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Anon".</remarks>
  member val VisitMeasure_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item)
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMeasure_Var".</remarks>
  member val BeforeVisitMeasure_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMeasure_Var(
       visitor,
       context,
       (visitor.VisitTypar context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMeasure.Var".</remarks>
  member val VisitMeasure_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range)
    with get, set


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
        this.BeforeVisitMeasure_Named(this, context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
        this.BeforeVisitMeasure_Product(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
        this.BeforeVisitMeasure_Seq(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
        this.BeforeVisitMeasure_Divide(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
        this.BeforeVisitMeasure_Power(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.One ->
        this.BeforeVisitMeasure_One(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item) ->
        this.BeforeVisitMeasure_Anon(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
        this.BeforeVisitMeasure_Var(this, context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Open".</remarks>
  member val BeforeVisitMemberDefn_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_Open(
       visitor,
       context,
       longId,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Open".</remarks>
  member val VisitMemberDefn_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Member".</remarks>
  member val BeforeVisitMemberDefn_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_Member(
       visitor,
       context,
       (visitor.VisitBinding context memberDefn),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Member".</remarks>
  member val VisitMemberDefn_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitCtor".</remarks>
  member val BeforeVisitMemberDefn_ImplicitCtor =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_ImplicitCtor(
       visitor,
       context,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitSimplePat context v)),
       selfIdentifier,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitCtor".</remarks>
  member val VisitMemberDefn_ImplicitCtor =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ImplicitInherit".</remarks>
  member val BeforeVisitMemberDefn_ImplicitInherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
       inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_ImplicitInherit(
       visitor,
       context,
       (visitor.VisitType context inheritType),
       (visitor.VisitExpr context inheritArgs),
       inheritAlias,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ImplicitInherit".</remarks>
  member val VisitMemberDefn_ImplicitInherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
       inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_LetBindings".</remarks>
  member val BeforeVisitMemberDefn_LetBindings =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       isStatic: bool,
       isRecursive: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_LetBindings(
       visitor,
       context,
       bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitBinding context v)),
       isStatic,
       isRecursive,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.LetBindings".</remarks>
  member val VisitMemberDefn_LetBindings =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       isStatic: bool,
       isRecursive: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AbstractSlot".</remarks>
  member val BeforeVisitMemberDefn_AbstractSlot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_AbstractSlot(
       visitor,
       context,
       (visitor.VisitValSig context valSig),
       memberFlags,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AbstractSlot".</remarks>
  member val VisitMemberDefn_AbstractSlot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Interface".</remarks>
  member val BeforeVisitMemberDefn_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_Interface(
       visitor,
       context,
       (visitor.VisitType context typeName),
       interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberDefn context v))),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Interface".</remarks>
  member val VisitMemberDefn_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_Inherit".</remarks>
  member val BeforeVisitMemberDefn_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_Inherit(
       visitor,
       context,
       (visitor.VisitType context typeName),
       id,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.Inherit".</remarks>
  member val VisitMemberDefn_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_ValField".</remarks>
  member val BeforeVisitMemberDefn_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_ValField(
       visitor,
       context,
       (visitor.VisitField context field),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.ValField".</remarks>
  member val VisitMemberDefn_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_NestedType".</remarks>
  member val BeforeVisitMemberDefn_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_NestedType(
       visitor,
       context,
       (visitor.VisitTypeDefn context typeDefn),
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.NestedType".</remarks>
  member val VisitMemberDefn_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberDefn_AutoProperty".</remarks>
  member val BeforeVisitMemberDefn_AutoProperty =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberDefn_AutoProperty(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       isStatic,
       id,
       tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitType context v)),
       propKind,
       memberFlags,
       xmlDoc,
       accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       (visitor.VisitExpr context expr),
       getSetPos,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberDefn.AutoProperty".</remarks>
  member val VisitMemberDefn_AutoProperty =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)
    with get, set


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
        this.BeforeVisitMemberDefn_Open(this, context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
        this.BeforeVisitMemberDefn_Member(this, context, memberDefn, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
        this.BeforeVisitMemberDefn_ImplicitCtor(this, context, accessiblity, attributes, ctorArgs, selfIdentifier, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
        this.BeforeVisitMemberDefn_ImplicitInherit(this, context, inheritType, inheritArgs, inheritAlias, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
        this.BeforeVisitMemberDefn_LetBindings(this, context, bindings, isStatic, isRecursive, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
        this.BeforeVisitMemberDefn_AbstractSlot(this, context, valSig, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
        this.BeforeVisitMemberDefn_Interface(this, context, typeName, interfaceMembers, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
        this.BeforeVisitMemberDefn_Inherit(this, context, typeName, id, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
        this.BeforeVisitMemberDefn_ValField(this, context, field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
        this.BeforeVisitMemberDefn_NestedType(this, context, typeDefn, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
        this.BeforeVisitMemberDefn_AutoProperty(this, context, attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Member".</remarks>
  member val BeforeVisitMemberSig_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberSig_Member(
       visitor,
       context,
       (visitor.VisitValSig context item1),
       memberFlags,
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Member".</remarks>
  member val VisitMemberSig_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Interface".</remarks>
  member val BeforeVisitMemberSig_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberSig_Interface(
       visitor,
       context,
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Interface".</remarks>
  member val VisitMemberSig_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_Inherit".</remarks>
  member val BeforeVisitMemberSig_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberSig_Inherit(
       visitor,
       context,
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.Inherit".</remarks>
  member val VisitMemberSig_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_ValField".</remarks>
  member val BeforeVisitMemberSig_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberSig_ValField(
       visitor,
       context,
       (visitor.VisitField context field),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.ValField".</remarks>
  member val VisitMemberSig_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range)
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMemberSig_NestedType".</remarks>
  member val BeforeVisitMemberSig_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitMemberSig_NestedType(
       visitor,
       context,
       (visitor.VisitTypeDefnSig context typeDefnSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynMemberSig.NestedType".</remarks>
  member val VisitMemberSig_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range)
    with get, set


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
        this.BeforeVisitMemberSig_Member(this, context, item1, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
        this.BeforeVisitMemberSig_Interface(this, context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
        this.BeforeVisitMemberSig_Inherit(this, context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
        this.BeforeVisitMemberSig_ValField(this, context, field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
        this.BeforeVisitMemberSig_NestedType(this, context, typeDefnSig, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_ModuleAbbrev".</remarks>
  member val BeforeVisitModuleDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_ModuleAbbrev(
       visitor,
       context,
       item1,
       item2,
       item3)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.ModuleAbbrev".</remarks>
  member val VisitModuleDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NestedModule".</remarks>
  member val BeforeVisitModuleDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       item4: bool,
       item5: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_NestedModule(
       visitor,
       context,
       (visitor.VisitComponentInfo context item1),
       isRec,
       item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitModuleDecl context v)),
       item4,
       item5)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NestedModule".</remarks>
  member val VisitModuleDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       item4: bool,
       item5: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Let".</remarks>
  member val BeforeVisitModuleDecl_Let =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_Let(
       visitor,
       context,
       item1,
       item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitBinding context v)),
       item3)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Let".</remarks>
  member val VisitModuleDecl_Let =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_DoExpr".</remarks>
  member val BeforeVisitModuleDecl_DoExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_DoExpr(
       visitor,
       context,
       item1,
       (visitor.VisitExpr context item2),
       item3)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.DoExpr".</remarks>
  member val VisitModuleDecl_DoExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Types".</remarks>
  member val BeforeVisitModuleDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_Types(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypeDefn context v)),
       item2)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Types".</remarks>
  member val VisitModuleDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Exception".</remarks>
  member val BeforeVisitModuleDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_Exception(
       visitor,
       context,
       (visitor.VisitExceptionDefn context item1),
       item2)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Exception".</remarks>
  member val VisitModuleDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Open".</remarks>
  member val BeforeVisitModuleDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_Open(
       visitor,
       context,
       item1,
       item2)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Open".</remarks>
  member val VisitModuleDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_Attributes".</remarks>
  member val BeforeVisitModuleDecl_Attributes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_Attributes(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       item2)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.Attributes".</remarks>
  member val VisitModuleDecl_Attributes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_HashDirective".</remarks>
  member val BeforeVisitModuleDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleDecl_HashDirective(
       visitor,
       context,
       item1,
       item2)
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.HashDirective".</remarks>
  member val VisitModuleDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       item2: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2)
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleDecl_NamespaceFragment".</remarks>
  member val BeforeVisitModuleDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) ->
      visitor.VisitModuleDecl_NamespaceFragment(
       visitor,
       context,
       (visitor.VisitModuleOrNamespace context item))
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleDecl.NamespaceFragment".</remarks>
  member val VisitModuleDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item)
    with get, set


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
        this.BeforeVisitModuleDecl_ModuleAbbrev(this, context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
        this.BeforeVisitModuleDecl_NestedModule(this, context, item1, isRec, item3, item4, item5)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_Let(this, context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
        this.BeforeVisitModuleDecl_DoExpr(this, context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
        this.BeforeVisitModuleDecl_Types(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
        this.BeforeVisitModuleDecl_Exception(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2) ->
        this.BeforeVisitModuleDecl_Open(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
        this.BeforeVisitModuleDecl_Attributes(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
        this.BeforeVisitModuleDecl_HashDirective(this, context, item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleDecl_NamespaceFragment(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespace_SynModuleOrNamespace".</remarks>
  member val BeforeVisitModuleOrNamespace_SynModuleOrNamespace =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleOrNamespace_SynModuleOrNamespace(
       visitor,
       context,
       id,
       isRec,
       isModule,
       decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitModuleDecl context v)),
       xmlDoc,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespace.SynModuleOrNamespace".</remarks>
  member val VisitModuleOrNamespace_SynModuleOrNamespace =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range)
    with get, set


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
        this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace(this, context, id, isRec, isModule, decls, xmlDoc, attributes, access, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig".</remarks>
  member val BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(
       visitor,
       context,
       id,
       isRec,
       isModule,
       item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitModuleSigDecl context v)),
       xmlDoc,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".</remarks>
  member val VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range)
    with get, set


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
        this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(this, context, id, isRec, isModule, item4, xmlDoc, attributes, item7, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_ModuleAbbrev".</remarks>
  member val BeforeVisitModuleSigDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_ModuleAbbrev(
       visitor,
       context,
       id,
       longId,
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.ModuleAbbrev".</remarks>
  member val VisitModuleSigDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NestedModule".</remarks>
  member val BeforeVisitModuleSigDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_NestedModule(
       visitor,
       context,
       (visitor.VisitComponentInfo context item1),
       isRec,
       moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitModuleSigDecl context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NestedModule".</remarks>
  member val VisitModuleSigDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Val".</remarks>
  member val BeforeVisitModuleSigDecl_Val =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_Val(
       visitor,
       context,
       (visitor.VisitValSig context valSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Val".</remarks>
  member val VisitModuleSigDecl_Val =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Types".</remarks>
  member val BeforeVisitModuleSigDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_Types(
       visitor,
       context,
       typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypeDefnSig context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Types".</remarks>
  member val VisitModuleSigDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Exception".</remarks>
  member val BeforeVisitModuleSigDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_Exception(
       visitor,
       context,
       (visitor.VisitExceptionSig context exnSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Exception".</remarks>
  member val VisitModuleSigDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_Open".</remarks>
  member val BeforeVisitModuleSigDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_Open(
       visitor,
       context,
       longId,
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.Open".</remarks>
  member val VisitModuleSigDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_HashDirective".</remarks>
  member val BeforeVisitModuleSigDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitModuleSigDecl_HashDirective(
       visitor,
       context,
       hashDirective,
       range)
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.HashDirective".</remarks>
  member val VisitModuleSigDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range)
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitModuleSigDecl_NamespaceFragment".</remarks>
  member val BeforeVisitModuleSigDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) ->
      visitor.VisitModuleSigDecl_NamespaceFragment(
       visitor,
       context,
       (visitor.VisitModuleOrNamespaceSig context item))
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynModuleSigDecl.NamespaceFragment".</remarks>
  member val VisitModuleSigDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item)
    with get, set


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
        this.BeforeVisitModuleSigDecl_ModuleAbbrev(this, context, id, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
        this.BeforeVisitModuleSigDecl_NestedModule(this, context, item1, isRec, moduleSigDecls, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
        this.BeforeVisitModuleSigDecl_Val(this, context, valSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
        this.BeforeVisitModuleSigDecl_Types(this, context, typeDefSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
        this.BeforeVisitModuleSigDecl_Exception(this, context, exnSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range) ->
        this.BeforeVisitModuleSigDecl_Open(this, context, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
        this.BeforeVisitModuleSigDecl_HashDirective(this, context, hashDirective, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
        this.BeforeVisitModuleSigDecl_NamespaceFragment(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Const".</remarks>
  member val BeforeVisitPat_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Const(
       visitor,
       context,
       (visitor.VisitConst context constant),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Const".</remarks>
  member val VisitPat_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Wild".</remarks>
  member val BeforeVisitPat_Wild =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Wild(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Wild".</remarks>
  member val VisitPat_Wild =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Named".</remarks>
  member val BeforeVisitPat_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       isThisVar: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Named(
       visitor,
       context,
       (visitor.VisitPat context item1),
       id,
       isThisVar,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Named".</remarks>
  member val VisitPat_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       isThisVar: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Typed".</remarks>
  member val BeforeVisitPat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Typed(
       visitor,
       context,
       (visitor.VisitPat context item1),
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Typed".</remarks>
  member val VisitPat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Attrib".</remarks>
  member val BeforeVisitPat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Attrib(
       visitor,
       context,
       (visitor.VisitPat context item1),
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Attrib".</remarks>
  member val VisitPat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Or".</remarks>
  member val BeforeVisitPat_Or =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Or(
       visitor,
       context,
       (visitor.VisitPat context item1),
       (visitor.VisitPat context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Or".</remarks>
  member val VisitPat_Or =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Ands".</remarks>
  member val BeforeVisitPat_Ands =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Ands(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitPat context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Ands".</remarks>
  member val VisitPat_Ands =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_LongIdent".</remarks>
  member val BeforeVisitPat_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.Ident option,
       item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
       item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
       item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_LongIdent(
       visitor,
       context,
       dotId,
       item2,
       item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitValTyparDecls context v)),
       (visitor.VisitConstructorArgs context item4),
       item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.LongIdent".</remarks>
  member val VisitPat_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.Ident option,
       item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
       item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
       item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Tuple".</remarks>
  member val BeforeVisitPat_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Tuple(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitPat context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Tuple".</remarks>
  member val VisitPat_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Paren".</remarks>
  member val BeforeVisitPat_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Paren(
       visitor,
       context,
       (visitor.VisitPat context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Paren".</remarks>
  member val VisitPat_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_ArrayOrList".</remarks>
  member val BeforeVisitPat_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_ArrayOrList(
       visitor,
       context,
       item1,
       item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitPat context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.ArrayOrList".</remarks>
  member val VisitPat_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Record".</remarks>
  member val BeforeVisitPat_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Record(
       visitor,
       context,
       fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitor.VisitPat context v1))),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Record".</remarks>
  member val VisitPat_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_Null".</remarks>
  member val BeforeVisitPat_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_Null(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.Null".</remarks>
  member val VisitPat_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Null(range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_OptionalVal".</remarks>
  member val BeforeVisitPat_OptionalVal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_OptionalVal(
       visitor,
       context,
       item1,
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.OptionalVal".</remarks>
  member val VisitPat_OptionalVal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_IsInst".</remarks>
  member val BeforeVisitPat_IsInst =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_IsInst(
       visitor,
       context,
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.IsInst".</remarks>
  member val VisitPat_IsInst =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_QuoteExpr".</remarks>
  member val BeforeVisitPat_QuoteExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_QuoteExpr(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.QuoteExpr".</remarks>
  member val VisitPat_QuoteExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_DeprecatedCharRange".</remarks>
  member val BeforeVisitPat_DeprecatedCharRange =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: char,
       item2: char,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_DeprecatedCharRange(
       visitor,
       context,
       item1,
       item2,
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.DeprecatedCharRange".</remarks>
  member val VisitPat_DeprecatedCharRange =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: char,
       item2: char,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_InstanceMember".</remarks>
  member val BeforeVisitPat_InstanceMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option,
       accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_InstanceMember(
       visitor,
       context,
       item1,
       item2,
       item3,
       accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.InstanceMember".</remarks>
  member val VisitPat_InstanceMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option,
       accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range)
    with get, set

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitPat_FromParseError".</remarks>
  member val BeforeVisitPat_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitPat_FromParseError(
       visitor,
       context,
       (visitor.VisitPat context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynPat.FromParseError".</remarks>
  member val VisitPat_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range)
    with get, set


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
        this.BeforeVisitPat_Const(this, context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range) ->
        this.BeforeVisitPat_Wild(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
        this.BeforeVisitPat_Named(this, context, item1, id, isThisVar, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
        this.BeforeVisitPat_Typed(this, context, item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
        this.BeforeVisitPat_Attrib(this, context, item1, attributes, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
        this.BeforeVisitPat_Or(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
        this.BeforeVisitPat_Ands(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
        this.BeforeVisitPat_LongIdent(this, context, dotId, item2, item3, item4, item5, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
        this.BeforeVisitPat_Tuple(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
        this.BeforeVisitPat_Paren(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
        this.BeforeVisitPat_ArrayOrList(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
        this.BeforeVisitPat_Record(this, context, fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Null(range) ->
        this.BeforeVisitPat_Null(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range) ->
        this.BeforeVisitPat_OptionalVal(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
        this.BeforeVisitPat_IsInst(this, context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
        this.BeforeVisitPat_QuoteExpr(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range) ->
        this.BeforeVisitPat_DeprecatedCharRange(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
        this.BeforeVisitPat_InstanceMember(this, context, item1, item2, item3, accesiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
        this.BeforeVisitPat_FromParseError(this, context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Integer".</remarks>
  member val BeforeVisitRationalConst_Integer =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) ->
      visitor.VisitRationalConst_Integer(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Integer".</remarks>
  member val VisitRationalConst_Integer =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item)
    with get, set

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Rational".</remarks>
  member val BeforeVisitRationalConst_Rational =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       item2: int,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitRationalConst_Rational(
       visitor,
       context,
       item1,
       item2,
       item3)
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Rational".</remarks>
  member val VisitRationalConst_Rational =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       item2: int,
       item3: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3)
    with get, set

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRationalConst_Negate".</remarks>
  member val BeforeVisitRationalConst_Negate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) ->
      visitor.VisitRationalConst_Negate(
       visitor,
       context,
       (visitor.VisitRationalConst context item))
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynRationalConst.Negate".</remarks>
  member val VisitRationalConst_Negate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item)
    with get, set


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
        this.BeforeVisitRationalConst_Integer(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3) ->
        this.BeforeVisitRationalConst_Rational(this, context, item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
        this.BeforeVisitRationalConst_Negate(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitReturnInfo_SynReturnInfo".</remarks>
  member val BeforeVisitReturnInfo_SynReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitReturnInfo_SynReturnInfo(
       visitor,
       context,
       (let v0, v1 = item1 in (visitor.VisitType context v0), (visitor.VisitArgInfo context v1)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynReturnInfo.SynReturnInfo".</remarks>
  member val VisitReturnInfo_SynReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range)
    with get, set


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
        this.BeforeVisitReturnInfo_SynReturnInfo(this, context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Id".</remarks>
  member val BeforeVisitSimplePat_Id =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       ident: Microsoft.FSharp.Compiler.Ast.Ident,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       isCompilerGenerated: bool,
       isThisVar: bool,
       isOptArg: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      use _rwh_ = new RefWrapperHolder()
      visitor.VisitSimplePat_Id(
       visitor,
       context,
       ident,
       altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitor.VisitSimplePatAlternativeIdInfo context v.Value)),
       isCompilerGenerated,
       isThisVar,
       isOptArg,
       range)
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Id".</remarks>
  member val VisitSimplePat_Id =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       ident: Microsoft.FSharp.Compiler.Ast.Ident,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       isCompilerGenerated: bool,
       isThisVar: bool,
       isOptArg: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)
    with get, set

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Typed".</remarks>
  member val BeforeVisitSimplePat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitSimplePat_Typed(
       visitor,
       context,
       (visitor.VisitSimplePat context item1),
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Typed".</remarks>
  member val VisitSimplePat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePat_Attrib".</remarks>
  member val BeforeVisitSimplePat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitSimplePat_Attrib(
       visitor,
       context,
       (visitor.VisitSimplePat context item1),
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       range)
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePat.Attrib".</remarks>
  member val VisitSimplePat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range)
    with get, set


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
        this.BeforeVisitSimplePat_Id(this, context, ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
        this.BeforeVisitSimplePat_Typed(this, context, item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
        this.BeforeVisitSimplePat_Attrib(this, context, item1, attributes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Undecided".</remarks>
  member val BeforeVisitSimplePatAlternativeIdInfo_Undecided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      visitor.VisitSimplePatAlternativeIdInfo_Undecided(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Undecided".</remarks>
  member val VisitSimplePatAlternativeIdInfo_Undecided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item)
    with get, set

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePatAlternativeIdInfo_Decided".</remarks>
  member val BeforeVisitSimplePatAlternativeIdInfo_Decided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      visitor.VisitSimplePatAlternativeIdInfo_Decided(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePatAlternativeIdInfo.Decided".</remarks>
  member val VisitSimplePatAlternativeIdInfo_Decided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item)
    with get, set


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
        this.BeforeVisitSimplePatAlternativeIdInfo_Undecided(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item) ->
        this.BeforeVisitSimplePatAlternativeIdInfo_Decided(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_SimplePats".</remarks>
  member val BeforeVisitSimplePats_SimplePats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitSimplePats_SimplePats(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitSimplePat context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.SimplePats".</remarks>
  member val VisitSimplePats_SimplePats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSimplePats_Typed".</remarks>
  member val BeforeVisitSimplePats_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitSimplePats_Typed(
       visitor,
       context,
       (visitor.VisitSimplePats context item1),
       (visitor.VisitType context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynSimplePats.Typed".</remarks>
  member val VisitSimplePats_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range)
    with get, set


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
        this.BeforeVisitSimplePats_SimplePats(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
        this.BeforeVisitSimplePats_Typed(this, context, item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon".</remarks>
  member val BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(
       visitor,
       context,
       (visitor.VisitTypar context item1),
       (visitor.VisitType context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".</remarks>
  member val VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitStaticOptimizationConstraint_WhenTyparIsStruct".</remarks>
  member val BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitStaticOptimizationConstraint_WhenTyparIsStruct(
       visitor,
       context,
       (visitor.VisitTypar context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynStaticOptimizationConstraint.WhenTyparIsStruct".</remarks>
  member val VisitStaticOptimizationConstraint_WhenTyparIsStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range)
    with get, set


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
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
        this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct(this, context, item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypar_Typar".</remarks>
  member val BeforeVisitTypar_Typar =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
       isCompGen: bool) ->
      visitor.VisitTypar_Typar(
       visitor,
       context,
       id,
       staticReq,
       isCompGen)
    with get, set

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypar.Typar".</remarks>
  member val VisitTypar_Typar =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
       isCompGen: bool) ->
      Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen)
    with get, set


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
        this.BeforeVisitTypar_Typar(this, context, id, staticReq, isCompGen)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyparDecl_TyparDecl".</remarks>
  member val BeforeVisitTyparDecl_TyparDecl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypar) ->
      visitor.VisitTyparDecl_TyparDecl(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       (visitor.VisitTypar context item2))
    with get, set

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTyparDecl.TyparDecl".</remarks>
  member val VisitTyparDecl_TyparDecl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypar) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2)
    with get, set


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
        this.BeforeVisitTyparDecl_TyparDecl(this, context, attributes, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdent".</remarks>
  member val BeforeVisitType_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) ->
      visitor.VisitType_LongIdent(
       visitor,
       context,
       item)
    with get, set

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdent".</remarks>
  member val VisitType_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item)
    with get, set

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_App".</remarks>
  member val BeforeVisitType_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       isPostfix: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_App(
       visitor,
       context,
       (visitor.VisitType context typeName),
       leftAngleRange,
       typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       commaRanges,
       rightAngleRange,
       isPostfix,
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.App".</remarks>
  member val VisitType_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       isPostfix: bool,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_LongIdentApp".</remarks>
  member val BeforeVisitType_LongIdentApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_LongIdentApp(
       visitor,
       context,
       (visitor.VisitType context typeName),
       dotId,
       leftAngleRange,
       genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       commaRanges,
       rightAngleRange,
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.LongIdentApp".</remarks>
  member val VisitType_LongIdentApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Tuple".</remarks>
  member val BeforeVisitType_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_Tuple(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitor.VisitType context v1))),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Tuple".</remarks>
  member val VisitType_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Array".</remarks>
  member val BeforeVisitType_Array =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       elementType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_Array(
       visitor,
       context,
       item1,
       (visitor.VisitType context elementType),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Array".</remarks>
  member val VisitType_Array =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       elementType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Fun".</remarks>
  member val BeforeVisitType_Fun =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       argType: Microsoft.FSharp.Compiler.Ast.SynType,
       returnType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_Fun(
       visitor,
       context,
       (visitor.VisitType context argType),
       (visitor.VisitType context returnType),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Fun".</remarks>
  member val VisitType_Fun =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       argType: Microsoft.FSharp.Compiler.Ast.SynType,
       returnType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Var".</remarks>
  member val BeforeVisitType_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_Var(
       visitor,
       context,
       (visitor.VisitTypar context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Var".</remarks>
  member val VisitType_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_Anon".</remarks>
  member val BeforeVisitType_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_Anon(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.Anon".</remarks>
  member val VisitType_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Anon(range)
    with get, set

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_WithGlobalConstraints".</remarks>
  member val BeforeVisitType_WithGlobalConstraints =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_WithGlobalConstraints(
       visitor,
       context,
       (visitor.VisitType context typeName),
       constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypeConstraint context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.WithGlobalConstraints".</remarks>
  member val VisitType_WithGlobalConstraints =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_HashConstraint".</remarks>
  member val BeforeVisitType_HashConstraint =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_HashConstraint(
       visitor,
       context,
       (visitor.VisitType context typeName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.HashConstraint".</remarks>
  member val VisitType_HashConstraint =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasureDivide".</remarks>
  member val BeforeVisitType_MeasureDivide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_MeasureDivide(
       visitor,
       context,
       (visitor.VisitType context typeName),
       (visitor.VisitType context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasureDivide".</remarks>
  member val VisitType_MeasureDivide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_MeasurePower".</remarks>
  member val BeforeVisitType_MeasurePower =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_MeasurePower(
       visitor,
       context,
       (visitor.VisitType context typeName),
       (visitor.VisitRationalConst context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.MeasurePower".</remarks>
  member val VisitType_MeasurePower =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstant".</remarks>
  member val BeforeVisitType_StaticConstant =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_StaticConstant(
       visitor,
       context,
       (visitor.VisitConst context constant),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstant".</remarks>
  member val VisitType_StaticConstant =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantExpr".</remarks>
  member val BeforeVisitType_StaticConstantExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_StaticConstantExpr(
       visitor,
       context,
       (visitor.VisitExpr context expr),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantExpr".</remarks>
  member val VisitType_StaticConstantExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range)
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitType_StaticConstantNamed".</remarks>
  member val BeforeVisitType_StaticConstantNamed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitType_StaticConstantNamed(
       visitor,
       context,
       (visitor.VisitType context item1),
       (visitor.VisitType context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynType.StaticConstantNamed".</remarks>
  member val VisitType_StaticConstantNamed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range)
    with get, set


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
        this.BeforeVisitType_LongIdent(this, context, item)
      | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
        this.BeforeVisitType_App(this, context, typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
        this.BeforeVisitType_LongIdentApp(this, context, typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
        this.BeforeVisitType_Tuple(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
        this.BeforeVisitType_Array(this, context, item1, elementType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
        this.BeforeVisitType_Fun(this, context, argType, returnType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
        this.BeforeVisitType_Var(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Anon(range) ->
        this.BeforeVisitType_Anon(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
        this.BeforeVisitType_WithGlobalConstraints(this, context, typeName, constraints, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
        this.BeforeVisitType_HashConstraint(this, context, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
        this.BeforeVisitType_MeasureDivide(this, context, typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
        this.BeforeVisitType_MeasurePower(this, context, typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
        this.BeforeVisitType_StaticConstant(this, context, constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
        this.BeforeVisitType_StaticConstantExpr(this, context, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
        this.BeforeVisitType_StaticConstantNamed(this, context, item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsValueType".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsValueType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsValueType(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsValueType".</remarks>
  member val VisitTypeConstraint_WhereTyparIsValueType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsReferenceType".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsReferenceType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsReferenceType(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsReferenceType".</remarks>
  member val VisitTypeConstraint_WhereTyparIsReferenceType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsUnmanaged".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsUnmanaged =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsUnmanaged(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsUnmanaged".</remarks>
  member val VisitTypeConstraint_WhereTyparIsUnmanaged =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsNull".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparSupportsNull =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparSupportsNull(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsNull".</remarks>
  member val VisitTypeConstraint_WhereTyparSupportsNull =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsComparable".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsComparable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsComparable(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsComparable".</remarks>
  member val VisitTypeConstraint_WhereTyparIsComparable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEquatable".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsEquatable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsEquatable(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEquatable".</remarks>
  member val VisitTypeConstraint_WhereTyparIsEquatable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparDefaultsToType".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparDefaultsToType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparDefaultsToType(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       (visitor.VisitType context typeSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparDefaultsToType".</remarks>
  member val VisitTypeConstraint_WhereTyparDefaultsToType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSubtypeOfType".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparSubtypeOfType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparSubtypeOfType(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       (visitor.VisitType context typeSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSubtypeOfType".</remarks>
  member val VisitTypeConstraint_WhereTyparSubtypeOfType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparSupportsMember".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparSupportsMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparSupportsMember(
       visitor,
       context,
       genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypar context v)),
       (visitor.VisitMemberSig context memberSig),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparSupportsMember".</remarks>
  member val VisitTypeConstraint_WhereTyparSupportsMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsEnum".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsEnum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsEnum(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsEnum".</remarks>
  member val VisitTypeConstraint_WhereTyparIsEnum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeConstraint_WhereTyparIsDelegate".</remarks>
  member val BeforeVisitTypeConstraint_WhereTyparIsDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeConstraint_WhereTyparIsDelegate(
       visitor,
       context,
       (visitor.VisitTypar context genericName),
       delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitType context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeConstraint.WhereTyparIsDelegate".</remarks>
  member val VisitTypeConstraint_WhereTyparIsDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range)
    with get, set


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
        this.BeforeVisitTypeConstraint_WhereTyparIsValueType(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsNull(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsComparable(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEquatable(this, context, genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType(this, context, genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType(this, context, genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparSupportsMember(this, context, genericNames, memberSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsEnum(this, context, genericName, enumTypes, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
        this.BeforeVisitTypeConstraint_WhereTyparIsDelegate(this, context, genericName, delegateTypes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefn_TypeDefn".</remarks>
  member val BeforeVisitTypeDefn_TypeDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefn_TypeDefn(
       visitor,
       context,
       (visitor.VisitComponentInfo context item1),
       (visitor.VisitTypeDefnRepr context item2),
       members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberDefn context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefn.TypeDefn".</remarks>
  member val VisitTypeDefn_TypeDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range)
    with get, set


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
        this.BeforeVisitTypeDefn_TypeDefn(this, context, item1, item2, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnspecified".</remarks>
  member val BeforeVisitTypeDefnKind_TyconUnspecified =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconUnspecified(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnspecified".</remarks>
  member val VisitTypeDefnKind_TyconUnspecified =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconClass".</remarks>
  member val BeforeVisitTypeDefnKind_TyconClass =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconClass(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconClass".</remarks>
  member val VisitTypeDefnKind_TyconClass =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconInterface".</remarks>
  member val BeforeVisitTypeDefnKind_TyconInterface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconInterface(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconInterface".</remarks>
  member val VisitTypeDefnKind_TyconInterface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconStruct".</remarks>
  member val BeforeVisitTypeDefnKind_TyconStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconStruct(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconStruct".</remarks>
  member val VisitTypeDefnKind_TyconStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconRecord".</remarks>
  member val BeforeVisitTypeDefnKind_TyconRecord =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconRecord(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconRecord".</remarks>
  member val VisitTypeDefnKind_TyconRecord =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconUnion".</remarks>
  member val BeforeVisitTypeDefnKind_TyconUnion =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconUnion(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconUnion".</remarks>
  member val VisitTypeDefnKind_TyconUnion =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAbbrev".</remarks>
  member val BeforeVisitTypeDefnKind_TyconAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconAbbrev(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAbbrev".</remarks>
  member val VisitTypeDefnKind_TyconAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconHiddenRepr".</remarks>
  member val BeforeVisitTypeDefnKind_TyconHiddenRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconHiddenRepr(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconHiddenRepr".</remarks>
  member val VisitTypeDefnKind_TyconHiddenRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconAugmentation".</remarks>
  member val BeforeVisitTypeDefnKind_TyconAugmentation =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconAugmentation(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconAugmentation".</remarks>
  member val VisitTypeDefnKind_TyconAugmentation =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconILAssemblyCode".</remarks>
  member val BeforeVisitTypeDefnKind_TyconILAssemblyCode =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      visitor.VisitTypeDefnKind_TyconILAssemblyCode(
       visitor,
       context)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconILAssemblyCode".</remarks>
  member val VisitTypeDefnKind_TyconILAssemblyCode =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnKind_TyconDelegate".</remarks>
  member val BeforeVisitTypeDefnKind_TyconDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) ->
      visitor.VisitTypeDefnKind_TyconDelegate(
       visitor,
       context,
       (visitor.VisitType context item1),
       (visitor.VisitValInfo context item2))
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnKind.TyconDelegate".</remarks>
  member val VisitTypeDefnKind_TyconDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2)
    with get, set


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
        this.BeforeVisitTypeDefnKind_TyconUnspecified(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass ->
        this.BeforeVisitTypeDefnKind_TyconClass(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface ->
        this.BeforeVisitTypeDefnKind_TyconInterface(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct ->
        this.BeforeVisitTypeDefnKind_TyconStruct(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord ->
        this.BeforeVisitTypeDefnKind_TyconRecord(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion ->
        this.BeforeVisitTypeDefnKind_TyconUnion(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev ->
        this.BeforeVisitTypeDefnKind_TyconAbbrev(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr ->
        this.BeforeVisitTypeDefnKind_TyconHiddenRepr(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation ->
        this.BeforeVisitTypeDefnKind_TyconAugmentation(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode ->
        this.BeforeVisitTypeDefnKind_TyconILAssemblyCode(this, context)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
        this.BeforeVisitTypeDefnKind_TyconDelegate(this, context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_ObjectModel".</remarks>
  member val BeforeVisitTypeDefnRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnRepr_ObjectModel(
       visitor,
       context,
       (visitor.VisitTypeDefnKind context item1),
       members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberDefn context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.ObjectModel".</remarks>
  member val VisitTypeDefnRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Simple".</remarks>
  member val BeforeVisitTypeDefnRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnRepr_Simple(
       visitor,
       context,
       (visitor.VisitTypeDefnSimpleRepr context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Simple".</remarks>
  member val VisitTypeDefnRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnRepr_Exception".</remarks>
  member val BeforeVisitTypeDefnRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      visitor.VisitTypeDefnRepr_Exception(
       visitor,
       context,
       (visitor.VisitExceptionDefnRepr context item))
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnRepr.Exception".</remarks>
  member val VisitTypeDefnRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item)
    with get, set


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
        this.BeforeVisitTypeDefnRepr_ObjectModel(this, context, item1, members, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnRepr_Simple(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
        this.BeforeVisitTypeDefnRepr_Exception(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSig_TypeDefnSig".</remarks>
  member val BeforeVisitTypeDefnSig_TypeDefnSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSig_TypeDefnSig(
       visitor,
       context,
       (visitor.VisitComponentInfo context item1),
       (visitor.VisitTypeDefnSigRepr context item2),
       memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberSig context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSig.TypeDefnSig".</remarks>
  member val VisitTypeDefnSig_TypeDefnSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range)
    with get, set


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
        this.BeforeVisitTypeDefnSig_TypeDefnSig(this, context, item1, item2, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_ObjectModel".</remarks>
  member val BeforeVisitTypeDefnSigRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSigRepr_ObjectModel(
       visitor,
       context,
       (visitor.VisitTypeDefnKind context item1),
       memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitMemberSig context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.ObjectModel".</remarks>
  member val VisitTypeDefnSigRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Simple".</remarks>
  member val BeforeVisitTypeDefnSigRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSigRepr_Simple(
       visitor,
       context,
       (visitor.VisitTypeDefnSimpleRepr context item1),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Simple".</remarks>
  member val VisitTypeDefnSigRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSigRepr_Exception".</remarks>
  member val BeforeVisitTypeDefnSigRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      visitor.VisitTypeDefnSigRepr_Exception(
       visitor,
       context,
       (visitor.VisitExceptionDefnRepr context item))
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSigRepr.Exception".</remarks>
  member val VisitTypeDefnSigRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item)
    with get, set


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
        this.BeforeVisitTypeDefnSigRepr_ObjectModel(this, context, item1, memberSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
        this.BeforeVisitTypeDefnSigRepr_Simple(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSigRepr_Exception(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Union".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_Union =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_Union(
       visitor,
       context,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitUnionCase context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Union".</remarks>
  member val VisitTypeDefnSimpleRepr_Union =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Enum".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_Enum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_Enum(
       visitor,
       context,
       cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitEnumCase context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Enum".</remarks>
  member val VisitTypeDefnSimpleRepr_Enum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Record".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       fields: Microsoft.FSharp.Compiler.Ast.SynField list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_Record(
       visitor,
       context,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       fields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitField context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Record".</remarks>
  member val VisitTypeDefnSimpleRepr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       fields: Microsoft.FSharp.Compiler.Ast.SynField list,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_General".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_General =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
       item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
       item4: Microsoft.FSharp.Compiler.Ast.SynField list,
       item5: bool,
       item6: bool,
       item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_General(
       visitor,
       context,
       (visitor.VisitTypeDefnKind context item1),
       item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitor.VisitType context v0), v1, v2)),
       item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitor.VisitValSig context v0), v1)),
       item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitField context v)),
       item5,
       item6,
       item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitSimplePat context v))),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.General".</remarks>
  member val VisitTypeDefnSimpleRepr_General =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
       item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
       item4: Microsoft.FSharp.Compiler.Ast.SynField list,
       item5: bool,
       item6: bool,
       item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(
       visitor,
       context,
       item1,
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".</remarks>
  member val VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_TypeAbbrev".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_TypeAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_TypeAbbrev(
       visitor,
       context,
       item1,
       (visitor.VisitType context item2),
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.TypeAbbrev".</remarks>
  member val VisitTypeDefnSimpleRepr_TypeAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_None".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_None =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitTypeDefnSimpleRepr_None(
       visitor,
       context,
       range)
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.None".</remarks>
  member val VisitTypeDefnSimpleRepr_None =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range)
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeDefnSimpleRepr_Exception".</remarks>
  member val BeforeVisitTypeDefnSimpleRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      visitor.VisitTypeDefnSimpleRepr_Exception(
       visitor,
       context,
       (visitor.VisitExceptionDefnRepr context item))
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynTypeDefnSimpleRepr.Exception".</remarks>
  member val VisitTypeDefnSimpleRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item)
    with get, set


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
        this.BeforeVisitTypeDefnSimpleRepr_Union(this, context, accessiblity, cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Enum(this, context, cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_Record(this, context, accessiblity, fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_General(this, context, item1, item2, item3, item4, item5, item6, item7, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(this, context, item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
        this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev(this, context, item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range) ->
        this.BeforeVisitTypeDefnSimpleRepr_None(this, context, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
        this.BeforeVisitTypeDefnSimpleRepr_Exception(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCase_UnionCase".</remarks>
  member val BeforeVisitUnionCase_UnionCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitUnionCase_UnionCase(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       id,
       (visitor.VisitUnionCaseType context caseType),
       xmlDoc,
       accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCase.UnionCase".</remarks>
  member val VisitUnionCase_UnionCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range)
    with get, set


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
        this.BeforeVisitUnionCase_UnionCase(this, context, attributes, id, caseType, xmlDoc, accessibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFields".</remarks>
  member val BeforeVisitUnionCaseType_UnionCaseFields =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynField list) ->
      visitor.VisitUnionCaseType_UnionCaseFields(
       visitor,
       context,
       cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitField context v)))
    with get, set

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFields".</remarks>
  member val VisitUnionCaseType_UnionCaseFields =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynField list) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases)
    with get, set

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUnionCaseType_UnionCaseFullType".</remarks>
  member val BeforeVisitUnionCaseType_UnionCaseFullType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) ->
      visitor.VisitUnionCaseType_UnionCaseFullType(
       visitor,
       context,
       (let v0, v1 = item in (visitor.VisitType context v0), (visitor.VisitValInfo context v1)))
    with get, set

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynUnionCaseType.UnionCaseFullType".</remarks>
  member val VisitUnionCaseType_UnionCaseFullType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item)
    with get, set


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
        this.BeforeVisitUnionCaseType_UnionCaseFields(this, context, cases)
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
        this.BeforeVisitUnionCaseType_UnionCaseFullType(this, context, item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValData_SynValData".</remarks>
  member val BeforeVisitValData_SynValData =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option) ->
      visitor.VisitValData_SynValData(
       visitor,
       context,
       item1,
       (visitor.VisitValInfo context item2),
       item3)
    with get, set

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValData.SynValData".</remarks>
  member val VisitValData_SynValData =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option) ->
      Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3)
    with get, set


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
        this.BeforeVisitValData_SynValData(this, context, item1, item2, item3)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValInfo_SynValInfo".</remarks>
  member val BeforeVisitValInfo_SynValInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
       item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) ->
      visitor.VisitValInfo_SynValInfo(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitArgInfo context v))),
       (visitor.VisitArgInfo context item2))
    with get, set

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValInfo.SynValInfo".</remarks>
  member val VisitValInfo_SynValInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
       item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2)
    with get, set


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
        this.BeforeVisitValInfo_SynValInfo(this, context, item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValSig_ValSpfn".</remarks>
  member val BeforeVisitValSig_ValSpfn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       range: Microsoft.FSharp.Compiler.Range.range) ->
      visitor.VisitValSig_ValSpfn(
       visitor,
       context,
       attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitor.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range),
       id,
       (visitor.VisitValTyparDecls context typeParams),
       (visitor.VisitType context typeName),
       (visitor.VisitValInfo context valInfo),
       item6,
       isMutable,
       xmlDoc,
       accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitAccess context v)),
       expr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitor.VisitExpr context v)),
       range)
    with get, set

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValSig.ValSpfn".</remarks>
  member val VisitValSig_ValSpfn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
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
       range: Microsoft.FSharp.Compiler.Range.range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)
    with get, set


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
        this.BeforeVisitValSig_ValSpfn(this, context, attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitValTyparDecls_SynValTyparDecls".</remarks>
  member val BeforeVisitValTyparDecls_SynValTyparDecls =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       item2: bool,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) ->
      visitor.VisitValTyparDecls_SynValTyparDecls(
       visitor,
       context,
       item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTyparDecl context v)),
       item2,
       constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitor.VisitTypeConstraint context v)))
    with get, set

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynValTyparDecls.SynValTyparDecls".</remarks>
  member val VisitValTyparDecls_SynValTyparDecls =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       item2: bool,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints)
    with get, set


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
        this.BeforeVisitValTyparDecls_SynValTyparDecls(this, context, item1, item2, constraints)
    finally
      parents.Pop() |> ignore

