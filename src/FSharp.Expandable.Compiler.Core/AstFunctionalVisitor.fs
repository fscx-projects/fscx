//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 13 Sep 2016 02:30:58 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open Microsoft.FSharp.Compiler.Ast

module AstFunctionalVisitor =

  let rec private visitDummy () = ()

  //////////////////////////////////////////////
  // Expression: ParsedFsiInteraction
  and visitFsiInteraction f context (target: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash((visitHashDirective f context item1), range)

  //////////////////////////////////////////////
  // Expression: ParsedHashDirective
  and visitHashDirective f context (target: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedHashDirective(item1, item2, range)

  //////////////////////////////////////////////
  // Expression: ParsedImplFile
  and visitImplFile f context (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective f context v)), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitImplFileFragment f context v)))

  //////////////////////////////////////////////
  // Expression: ParsedImplFileFragment
  and visitImplFileFragment f context (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule((visitModuleOrNamespace f context item))
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl f context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range)

  //////////////////////////////////////////////
  // Expression: ParsedImplFileInput
  and visitImplFileInput f context (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective f context v)), item6 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespace f context v)), item7)

  //////////////////////////////////////////////
  // Expression: ParsedInput
  and visitInput f context (target: Microsoft.FSharp.Compiler.Ast.ParsedInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile((visitImplFileInput f context item))
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile((visitSigFileInput f context item))

  //////////////////////////////////////////////
  // Expression: ParsedSigFile
  and visitSigFile f context (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective f context v)), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSigFileFragment f context v)))

  //////////////////////////////////////////////
  // Expression: ParsedSigFileFragment
  and visitSigFileFragment f context (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule((visitModuleOrNamespaceSig f context item))
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl f context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range)

  //////////////////////////////////////////////
  // Expression: ParsedSigFileInput
  and visitSigFileInput f context (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective f context v)), item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespaceSig f context v)))

  //////////////////////////////////////////////
  // Expression: SynAccess
  and visitAccess f context (target: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Public ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Public
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Internal
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Private ->
      Microsoft.FSharp.Compiler.Ast.SynAccess.Private

  //////////////////////////////////////////////
  // Expression: SynArgInfo
  and visitArgInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), optional, id)

  //////////////////////////////////////////////
  // Expression: SynBinding
  and visitBinding f context (target: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), (visitBindingKind f context bindingKind), mustInline, isMutable, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), xmlDoc, (visitValData f context item7), (visitPat f context headPat), item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitBindingReturnInfo f context v)), (visitExpr f context expr), lhsRange, spBind)

  //////////////////////////////////////////////
  // Expression: SynBindingKind
  and visitBindingKind f context (target: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding ->
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding

  //////////////////////////////////////////////
  // Expression: SynBindingReturnInfo
  and visitBindingReturnInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo((visitType f context typeName), range, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range))

  //////////////////////////////////////////////
  // Expression: SynComponentInfo
  and visitComponentInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl f context v)), constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint f context v)), item4, xmlDoc, preferPostfix, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynConst
  and visitConst f context (target: Microsoft.FSharp.Compiler.Ast.SynConst) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConst.Unit ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Unit
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Single(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Single(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Double(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Double(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Char(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Char(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range)
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item)
    | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Measure((visitConst f context constant), (visitMeasure f context item2))

  //////////////////////////////////////////////
  // Expression: SynConstructorArgs
  and visitConstructorArgs f context (target: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat f context v)))
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat f context v1))), range)

  //////////////////////////////////////////////
  // Expression: SynEnumCase
  and visitEnumCase f context (target: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (visitConst f context item3), xmlDoc, range)

  //////////////////////////////////////////////
  // Expression: SynExceptionDefn
  and visitExceptionDefn f context (target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn((visitExceptionDefnRepr f context exnRepr), members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynExceptionDefnRepr
  and visitExceptionDefnRepr f context (target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), (visitUnionCase f context case), longId, xmlDoc, accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynExceptionSig
  and visitExceptionSig f context (target: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig((visitExceptionDefnRepr f context exnRepr), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynExpr
  and visitExpr f context (target: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren((visitExpr f context expr), leftParenRange, rightParenRange, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote((visitExpr f context operator), isRaw, (visitExpr f context quotedSynExpr), isFromQueryExpression, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const((visitConst f context constant), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed((visitExpr f context expr), (visitType f context typeSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr f context v)), commaRanges, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitType f context v0), (visitExpr f context v1), v2, v3, v4)), copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr f context v0), v1)), recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr f context v)), v2)), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, (visitType f context typeName), (visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr((visitType f context objType), argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr f context v0), v1)), bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding f context v)), extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitInterfaceImpl f context v)), newPos, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, (visitExpr f context whileBody), (visitExpr f context doBody), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, (visitExpr f context idBody), item4, (visitExpr f context toBody), (visitExpr f context doBody), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, (visitPat f context pattern), (visitExpr f context enumExpr), (visitExpr f context bodyExpr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, (visitExpr f context elements), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, (visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, (visitSimplePats f context args), (visitExpr f context body), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause f context v)), spBind, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, (visitExpr f context matchExpr), clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause f context v)), isCexprExceptionMatch, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, (visitExpr f context funcExpr), (visitExpr f context argExpr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp((visitExpr f context expr), leftAngleRange, typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), commaRanges, rightAngleRange, typeArgs, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding f context v)), (visitExpr f context exprBody), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith((visitExpr f context tryExpr), item2, item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause f context v)), item4, range, spTry, spWith)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally((visitExpr f context tryExpr), (visitExpr f context finallyExpr), range, spTry, spFinally)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, (visitExpr f context expr1), (visitExpr f context expr2), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse((visitExpr f context exprGuard), (visitExpr f context exprThen), optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr f context v)), spIfToThen, isFromErrorRecovery, ifToThen, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo f context v.Value)), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, (visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet((visitExpr f context expr), rangeOfDot, dotId, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet((visitExpr f context expr), dotId, (visitExpr f context exprValue), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet((visitExpr f context expr), indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg f context v)), item3, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet((visitExpr f context objectExpr), indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg f context v)), (visitExpr f context valueExpr), rangeOfLeftOfSet, rangeOfDot, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, (visitExpr f context item2), (visitExpr f context item3), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet((visitExpr f context item1), item2, (visitExpr f context item3), (visitExpr f context item4), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest((visitExpr f context expr), (visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast((visitExpr f context expr), (visitType f context typeSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast((visitExpr f context expr), (visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, (visitExpr f context item2), item3, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar f context v)), (visitMemberSig f context item2), (visitExpr f context item3), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn((visitExpr f context item1), inPos, (visitExpr f context item3), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, (visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, (visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, (visitPat f context pattern), (visitExpr f context rhsExpr), (visitExpr f context bodyExpr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr f context v)), item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitStaticOptimizationConstraint f context v)), (visitExpr f context item2), (visitExpr f context item3), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet((visitExpr f context item1), longId, item3, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet((visitExpr f context item1), longId, item3, (visitExpr f context item4), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed((visitExpr f context item1), item2)

  //////////////////////////////////////////////
  // Expression: SynField
  and visitField f context (target: Microsoft.FSharp.Compiler.Ast.SynField) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), isStatic, id, (visitType f context typeName), item5, xmlDoc, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynIndexerArg
  and visitIndexerArg f context (target: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two((visitExpr f context item1), (visitExpr f context item2))
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One((visitExpr f context item))

  //////////////////////////////////////////////
  // Expression: SynInterfaceImpl
  and visitInterfaceImpl f context (target: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl((visitType f context item1), bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynMatchClause
  and visitMatchClause f context (target: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause((visitPat f context item1), item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr f context v)), (visitExpr f context item3), range, spTarget)

  //////////////////////////////////////////////
  // Expression: SynMeasure
  and visitMeasure f context (target: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product((visitMeasure f context item1), (visitMeasure f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMeasure f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide((visitMeasure f context item1), (visitMeasure f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power((visitMeasure f context item1), (visitRationalConst f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.One ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.One
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var((visitTypar f context item1), range)

  //////////////////////////////////////////////
  // Expression: SynMemberDefn
  and visitMemberDefn f context (target: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member((visitBinding f context memberDefn), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat f context v)), selfIdentifier, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit((visitType f context inheritType), (visitExpr f context inheritArgs), inheritAlias, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding f context v)), isStatic, isRecursive, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot((visitValSig f context valSig), memberFlags, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface((visitType f context typeName), interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn f context v))), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit((visitType f context typeName), id, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField((visitField f context field), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType((visitTypeDefn f context typeDefn), accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), isStatic, id, tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitType f context v)), propKind, memberFlags, xmlDoc, accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), (visitExpr f context expr), getSetPos, range)

  //////////////////////////////////////////////
  // Expression: SynMemberSig
  and visitMemberSig f context (target: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member((visitValSig f context item1), memberFlags, range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface((visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit((visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField((visitField f context field), range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType((visitTypeDefnSig f context typeDefnSig), range)

  //////////////////////////////////////////////
  // Expression: SynModuleDecl
  and visitModuleDecl f context (target: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule((visitComponentInfo f context item1), isRec, item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl f context v)), item4, item5)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding f context v)), item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, (visitExpr f context item2), item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefn f context v)), item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception((visitExceptionDefn f context item1), item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective((visitHashDirective f context item1), item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment((visitModuleOrNamespace f context item))

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespace
  and visitModuleOrNamespace f context (target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl f context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespaceSig
  and visitModuleOrNamespaceSig f context (target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl f context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynModuleSigDecl
  and visitModuleSigDecl f context (target: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule((visitComponentInfo f context item1), isRec, moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val((visitValSig f context valSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefnSig f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception((visitExceptionSig f context exnSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective((visitHashDirective f context hashDirective), range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment((visitModuleOrNamespaceSig f context item))

  //////////////////////////////////////////////
  // Expression: SynPat
  and visitPat f context (target: Microsoft.FSharp.Compiler.Ast.SynPat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const((visitConst f context constant), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named((visitPat f context item1), id, isThisVar, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed((visitPat f context item1), (visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib((visitPat f context item1), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or((visitPat f context item1), (visitPat f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitValTyparDecls f context v)), (visitConstructorArgs f context item4), item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren((visitPat f context item1), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat f context v1))), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Null(range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Null(range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst((visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError((visitPat f context item1), range)

  //////////////////////////////////////////////
  // Expression: SynRationalConst
  and visitRationalConst f context (target: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item)
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3)
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate((visitRationalConst f context item))

  //////////////////////////////////////////////
  // Expression: SynReturnInfo
  and visitReturnInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo((let v0, v1 = item1 in (visitType f context v0), (visitArgInfo f context v1)), range)

  //////////////////////////////////////////////
  // Expression: SynSimplePat
  and visitSimplePat f context (target: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo f context v.Value)), isCompilerGenerated, isThisVar, isOptArg, range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed((visitSimplePat f context item1), (visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib((visitSimplePat f context item1), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range)

  //////////////////////////////////////////////
  // Expression: SynSimplePatAlternativeIdInfo
  and visitSimplePatAlternativeIdInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item)

  //////////////////////////////////////////////
  // Expression: SynSimplePats
  and visitSimplePats f context (target: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed((visitSimplePats f context item1), (visitType f context item2), range)

  //////////////////////////////////////////////
  // Expression: SynStaticOptimizationConstraint
  and visitStaticOptimizationConstraint f context (target: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon((visitTypar f context item1), (visitType f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct((visitTypar f context item1), range)

  //////////////////////////////////////////////
  // Expression: SynTypar
  and visitTypar f context (target: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen) ->
      Microsoft.FSharp.Compiler.Ast.SynTypar.Typar(id, staticReq, isCompGen)

  //////////////////////////////////////////////
  // Expression: SynTyparDecl
  and visitTyparDecl f context (target: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), (visitTypar f context item2))

  //////////////////////////////////////////////
  // Expression: SynType
  and visitType f context (target: Microsoft.FSharp.Compiler.Ast.SynType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item)
    | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App((visitType f context typeName), leftAngleRange, typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), commaRanges, rightAngleRange, isPostfix, range)
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp((visitType f context typeName), dotId, leftAngleRange, genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), commaRanges, rightAngleRange, range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType f context v1))), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, (visitType f context elementType), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun((visitType f context argType), (visitType f context returnType), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var((visitTypar f context item1), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Anon(range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Anon(range)
    | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints((visitType f context typeName), constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint((visitType f context typeName), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide((visitType f context typeName), (visitType f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower((visitType f context typeName), (visitRationalConst f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant((visitConst f context constant), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr((visitExpr f context expr), range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed((visitType f context item1), (visitType f context item2), range)

  //////////////////////////////////////////////
  // Expression: SynTypeConstraint
  and visitTypeConstraint f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable((visitTypar f context genericName), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType((visitTypar f context genericName), (visitType f context typeSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType((visitTypar f context genericName), (visitType f context typeSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar f context v)), (visitMemberSig f context memberSig), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum((visitTypar f context genericName), enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate((visitTypar f context genericName), delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynTypeDefn
  and visitTypeDefn f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn((visitComponentInfo f context item1), (visitTypeDefnRepr f context item2), members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynTypeDefnKind
  and visitTypeDefnKind f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate((visitType f context item1), (visitValInfo f context item2))

  //////////////////////////////////////////////
  // Expression: SynTypeDefnRepr
  and visitTypeDefnRepr f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel((visitTypeDefnKind f context item1), members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple((visitTypeDefnSimpleRepr f context item1), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception((visitExceptionDefnRepr f context item))

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSig
  and visitTypeDefnSig f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig((visitComponentInfo f context item1), (visitTypeDefnSigRepr f context item2), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSigRepr
  and visitTypeDefnSigRepr f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel((visitTypeDefnKind f context item1), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple((visitTypeDefnSimpleRepr f context item1), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception((visitExceptionDefnRepr f context item))

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSimpleRepr
  and visitTypeDefnSimpleRepr f context (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitUnionCase f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitEnumCase f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), fields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField f context v)), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General((visitTypeDefnKind f context item1), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitType f context v0), v1, v2)), item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitValSig f context v0), v1)), item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField f context v)), item5, item6, item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat f context v))), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, (visitType f context item2), range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception((visitExceptionDefnRepr f context item))

  //////////////////////////////////////////////
  // Expression: SynUnionCase
  and visitUnionCase f context (target: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (visitUnionCaseType f context caseType), xmlDoc, accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynUnionCaseType
  and visitUnionCaseType f context (target: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField f context v)))
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType((let v0, v1 = item in (visitType f context v0), (visitValInfo f context v1)))

  //////////////////////////////////////////////
  // Expression: SynValData
  and visitValData f context (target: Microsoft.FSharp.Compiler.Ast.SynValData) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynValData(item1, (visitValInfo f context item2), item3)

  //////////////////////////////////////////////
  // Expression: SynValInfo
  and visitValInfo f context (target: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitArgInfo f context v))), (visitArgInfo f context item2))

  //////////////////////////////////////////////
  // Expression: SynValSig
  and visitValSig f context (target: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.initSynAttribute v.TypeName (visitExpr f context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (visitValTyparDecls f context typeParams), (visitType f context typeName), (visitValInfo f context valInfo), item6, isMutable, xmlDoc, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess f context v)), expr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr f context v)), range)

  //////////////////////////////////////////////
  // Expression: SynValTyparDecls
  and visitValTyparDecls f context (target: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl f context v)), item2, constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint f context v)))
