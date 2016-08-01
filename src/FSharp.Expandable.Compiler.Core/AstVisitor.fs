//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Mon, 01 Aug 2016 09:43:39 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST expression auguments.
/// </summary>
[<AutoOpen>]
module SynExpr =

  /// <summary>
  /// Construct "SynExpr.Paren".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParen expr leftParenRange rightParenRange range =
    SynExpr.Paren(expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Construct "SynExpr.Quote".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initQuote operator isRaw quotedSynExpr isFromQueryExpression range =
    SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

  /// <summary>
  /// Construct "SynExpr.Const".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initConst constant range =
    SynExpr.Const(constant, range)

  /// <summary>
  /// Construct "SynExpr.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped expr typeSig range =
    SynExpr.Typed(expr, typeSig, range)

  /// <summary>
  /// Construct "SynExpr.Tuple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTuple exprs commaRanges range =
    SynExpr.Tuple(exprs, commaRanges, range)

  /// <summary>
  /// Construct "SynExpr.ArrayOrList".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrList isList exprs range =
    SynExpr.ArrayOrList(isList, exprs, range)

  /// <summary>
  /// Construct "SynExpr.Record".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRecord baseInfo copyInfo recordFields range =
    SynExpr.Record(baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Construct "SynExpr.New".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNew isProtected typeName expr range =
    SynExpr.New(isProtected, typeName, expr, range)

  /// <summary>
  /// Construct "SynExpr.ObjExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initObjExpr objType argOpt bindings extraImpls newPos range =
    SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Construct "SynExpr.While".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhile spWhile whileBody doBody range =
    SynExpr.While(spWhile, whileBody, doBody, range)

  /// <summary>
  /// Construct "SynExpr.For".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFor spFor id idBody item4 toBody doBody range =
    SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Construct "SynExpr.ForEach".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Construct "SynExpr.ArrayOrListOfSeqExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrListOfSeqExpr isList elements range =
    SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)

  /// <summary>
  /// Construct "SynExpr.CompExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initCompExpr isArrayOrList isNotNakedRefCell expr range =
    SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Construct "SynExpr.Lambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLambda fromMethod inLambdaSeq args body range =
    SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Construct "SynExpr.MatchLambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatchLambda item1 item2 clauses spBind range =
    SynExpr.MatchLambda(item1, item2, clauses, spBind, range)

  /// <summary>
  /// Construct "SynExpr.Match".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatch spBind matchExpr clauses isCexprExceptionMatch range =
    SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Construct "SynExpr.Do".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDo expr range =
    SynExpr.Do(expr, range)

  /// <summary>
  /// Construct "SynExpr.Assert".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAssert expr range =
    SynExpr.Assert(expr, range)

  /// <summary>
  /// Construct "SynExpr.App".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initApp exprAtomicFlag isInfix funcExpr argExpr range =
    SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Construct "SynExpr.TypeApp".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Construct "SynExpr.LetOrUse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUse isRecursive isUse bindings exprBody range =
    SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Construct "SynExpr.TryWith".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryWith tryExpr item2 item3 item4 range spTry spWith =
    SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Construct "SynExpr.TryFinally".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryFinally tryExpr finallyExpr range spTry spFinally =
    SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Construct "SynExpr.Lazy".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLazy expr range =
    SynExpr.Lazy(expr, range)

  /// <summary>
  /// Construct "SynExpr.Sequential".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequential spSeq isTrueSeq expr1 expr2 range =
    SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Construct "SynExpr.IfThenElse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Construct "SynExpr.Ident".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIdent item =
    SynExpr.Ident(item)

  /// <summary>
  /// Construct "SynExpr.LongIdent".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdent isOptional longIdent altNameRefCell range =
    SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Construct "SynExpr.LongIdentSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdentSet dotId expr range =
    SynExpr.LongIdentSet(dotId, expr, range)

  /// <summary>
  /// Construct "SynExpr.DotGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotGet expr rangeOfDot dotId range =
    SynExpr.DotGet(expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Construct "SynExpr.DotSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotSet expr dotId exprValue range =
    SynExpr.DotSet(expr, dotId, exprValue, range)

  /// <summary>
  /// Construct "SynExpr.DotIndexedGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedGet expr indexExprs item3 range =
    SynExpr.DotIndexedGet(expr, indexExprs, item3, range)

  /// <summary>
  /// Construct "SynExpr.DotIndexedSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Construct "SynExpr.NamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamedIndexedPropertySet item1 item2 item3 range =
    SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotNamedIndexedPropertySet item1 item2 item3 item4 range =
    SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.TypeTest".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeTest expr typeName range =
    SynExpr.TypeTest(expr, typeName, range)

  /// <summary>
  /// Construct "SynExpr.Upcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUpcast expr typeSig range =
    SynExpr.Upcast(expr, typeSig, range)

  /// <summary>
  /// Construct "SynExpr.Downcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDowncast expr typeName range =
    SynExpr.Downcast(expr, typeName, range)

  /// <summary>
  /// Construct "SynExpr.InferredUpcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredUpcast expr range =
    SynExpr.InferredUpcast(expr, range)

  /// <summary>
  /// Construct "SynExpr.InferredDowncast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredDowncast expr range =
    SynExpr.InferredDowncast(expr, range)

  /// <summary>
  /// Construct "SynExpr.Null".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNull range =
    SynExpr.Null(range)

  /// <summary>
  /// Construct "SynExpr.AddressOf".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAddressOf item1 item2 item3 range =
    SynExpr.AddressOf(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.TraitCall".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTraitCall item1 item2 item3 range =
    SynExpr.TraitCall(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.JoinIn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initJoinIn item1 inPos item3 range =
    SynExpr.JoinIn(item1, inPos, item3, range)

  /// <summary>
  /// Construct "SynExpr.ImplicitZero".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplicitZero range =
    SynExpr.ImplicitZero(range)

  /// <summary>
  /// Construct "SynExpr.YieldOrReturn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturn item1 expr range =
    SynExpr.YieldOrReturn(item1, expr, range)

  /// <summary>
  /// Construct "SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturnFrom item1 expr range =
    SynExpr.YieldOrReturnFrom(item1, expr, range)

  /// <summary>
  /// Construct "SynExpr.LetOrUseBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Construct "SynExpr.DoBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDoBang expr range =
    SynExpr.DoBang(expr, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyILAssembly item1 item2 item3 item4 range =
    SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyStaticOptimization item1 item2 item3 range =
    SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldGet item1 longId item3 range =
    SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range =
    SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArbitraryAfterError debugStr range =
    SynExpr.ArbitraryAfterError(debugStr, range)

  /// <summary>
  /// Construct "SynExpr.FromParseError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFromParseError expr range =
    SynExpr.FromParseError(expr, range)

  /// <summary>
  /// Construct "SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDiscardAfterMissingQualificationAfterDot expr range =
    SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)

  /// <summary>
  /// Construct "SynExpr.Fixed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFixed item1 item2 =
    SynExpr.Fixed(item1, item2)


////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

  let parents = new System.Collections.Generic.Stack<SynExpr>()

  /// <summary>
  /// Parent ASTs
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  abstract member BeforeVisitParen: expr: SynExpr -> leftParenRange: Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Range.range> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitParen expr leftParenRange rightParenRange range context =
    this.VisitParen (expr |> (fun expr -> this.VisitSynExpr expr context)) leftParenRange rightParenRange range context

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  abstract member VisitParen: expr: SynExpr -> leftParenRange: Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Range.range> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  default __.VisitParen expr leftParenRange rightParenRange range context =
    SynExpr.initParen expr leftParenRange rightParenRange range

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitQuote: operator: SynExpr -> isRaw: bool -> quotedSynExpr: SynExpr -> isFromQueryExpression: bool -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context =
    this.VisitQuote (operator |> (fun expr -> this.VisitSynExpr expr context)) isRaw (quotedSynExpr |> (fun expr -> this.VisitSynExpr expr context)) isFromQueryExpression range context

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  abstract member VisitQuote: operator: SynExpr -> isRaw: bool -> quotedSynExpr: SynExpr -> isFromQueryExpression: bool -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  default __.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context =
    SynExpr.initQuote operator isRaw quotedSynExpr isFromQueryExpression range

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitConst constant range context =
    this.VisitConst constant range context

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  abstract member VisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  default __.VisitConst constant range context =
    SynExpr.initConst constant range

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitTyped: expr: SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitTyped expr typeSig range context =
    this.VisitTyped (expr |> (fun expr -> this.VisitSynExpr expr context)) typeSig range context

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  abstract member VisitTyped: expr: SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  default __.VisitTyped expr typeSig range context =
    SynExpr.initTyped expr typeSig range

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitTuple: exprs: Microsoft.FSharp.Collections.List<SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Range.range> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitTuple exprs commaRanges range context =
    this.VisitTuple (exprs |> (List.map (fun expr -> this.VisitSynExpr expr context))) commaRanges range context

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  abstract member VisitTuple: exprs: Microsoft.FSharp.Collections.List<SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Range.range> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  default __.VisitTuple exprs commaRanges range context =
    SynExpr.initTuple exprs commaRanges range

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitArrayOrList: isList: bool -> exprs: Microsoft.FSharp.Collections.List<SynExpr> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitArrayOrList isList exprs range context =
    this.VisitArrayOrList isList (exprs |> (List.map (fun expr -> this.VisitSynExpr expr context))) range context

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  abstract member VisitArrayOrList: isList: bool -> exprs: Microsoft.FSharp.Collections.List<SynExpr> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  default __.VisitArrayOrList isList exprs range context =
    SynExpr.initArrayOrList isList exprs range

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * SynExpr * Range.range * Microsoft.FSharp.Core.Option<(Range.range * Microsoft.FSharp.Core.Option<Range.pos>)> * Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(SynExpr * (Range.range * Microsoft.FSharp.Core.Option<Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Core.Option<SynExpr> * Microsoft.FSharp.Core.Option<(Range.range * Microsoft.FSharp.Core.Option<Range.pos>)>)> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitRecord baseInfo copyInfo recordFields range context =
    this.VisitRecord baseInfo copyInfo recordFields range context

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  abstract member VisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * SynExpr * Range.range * Microsoft.FSharp.Core.Option<(Range.range * Microsoft.FSharp.Core.Option<Range.pos>)> * Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(SynExpr * (Range.range * Microsoft.FSharp.Core.Option<Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Core.Option<SynExpr> * Microsoft.FSharp.Core.Option<(Range.range * Microsoft.FSharp.Core.Option<Range.pos>)>)> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  default __.VisitRecord baseInfo copyInfo recordFields range context =
    SynExpr.initRecord baseInfo copyInfo recordFields range

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitNew: isProtected: bool -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitNew isProtected typeName expr range context =
    this.VisitNew isProtected typeName (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  abstract member VisitNew: isProtected: bool -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  default __.VisitNew isProtected typeName expr range context =
    SynExpr.initNew isProtected typeName expr range

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range context =
    this.VisitObjExpr objType argOpt bindings extraImpls newPos range context

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  abstract member VisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  default __.VisitObjExpr objType argOpt bindings extraImpls newPos range context =
    SynExpr.initObjExpr objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: SynExpr -> doBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitWhile spWhile whileBody doBody range context =
    this.VisitWhile spWhile (whileBody |> (fun expr -> this.VisitSynExpr expr context)) (doBody |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  abstract member VisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: SynExpr -> doBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  default __.VisitWhile spWhile whileBody doBody range context =
    SynExpr.initWhile spWhile whileBody doBody range

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: SynExpr -> item4: bool -> toBody: SynExpr -> doBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitFor spFor id idBody item4 toBody doBody range context =
    this.VisitFor spFor id (idBody |> (fun expr -> this.VisitSynExpr expr context)) item4 (toBody |> (fun expr -> this.VisitSynExpr expr context)) (doBody |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  abstract member VisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: SynExpr -> item4: bool -> toBody: SynExpr -> doBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  default __.VisitFor spFor id idBody item4 toBody doBody range context =
    SynExpr.initFor spFor id idBody item4 toBody doBody range

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: bool -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: SynExpr -> bodyExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context =
    this.VisitForEach spFor seqExprOnly isFromSource pattern (enumExpr |> (fun expr -> this.VisitSynExpr expr context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  abstract member VisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: bool -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: SynExpr -> bodyExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  default __.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context =
    SynExpr.initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitArrayOrListOfSeqExpr: isList: bool -> elements: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitArrayOrListOfSeqExpr isList elements range context =
    this.VisitArrayOrListOfSeqExpr isList (elements |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  abstract member VisitArrayOrListOfSeqExpr: isList: bool -> elements: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  default __.VisitArrayOrListOfSeqExpr isList elements range context =
    SynExpr.initArrayOrListOfSeqExpr isList elements range

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitCompExpr: isArrayOrList: bool -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range context =
    this.VisitCompExpr isArrayOrList isNotNakedRefCell (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  abstract member VisitCompExpr: isArrayOrList: bool -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<bool> -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  default __.VisitCompExpr isArrayOrList isNotNakedRefCell expr range context =
    SynExpr.initCompExpr isArrayOrList isNotNakedRefCell expr range

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitLambda: fromMethod: bool -> inLambdaSeq: bool -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitLambda fromMethod inLambdaSeq args body range context =
    this.VisitLambda fromMethod inLambdaSeq args (body |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  abstract member VisitLambda: fromMethod: bool -> inLambdaSeq: bool -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  default __.VisitLambda fromMethod inLambdaSeq args body range context =
    SynExpr.initLambda fromMethod inLambdaSeq args body range

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitMatchLambda: item1: bool -> item2: Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitMatchLambda item1 item2 clauses spBind range context =
    this.VisitMatchLambda item1 item2 clauses spBind range context

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  abstract member VisitMatchLambda: item1: bool -> item2: Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  default __.VisitMatchLambda item1 item2 clauses spBind range context =
    SynExpr.initMatchLambda item1 item2 clauses spBind range

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: bool -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range context =
    this.VisitMatch spBind (matchExpr |> (fun expr -> this.VisitSynExpr expr context)) clauses isCexprExceptionMatch range context

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  abstract member VisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: bool -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  default __.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range context =
    SynExpr.initMatch spBind matchExpr clauses isCexprExceptionMatch range

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitDo: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitDo expr range context =
    this.VisitDo (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  abstract member VisitDo: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  default __.VisitDo expr range context =
    SynExpr.initDo expr range

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitAssert: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitAssert expr range context =
    this.VisitAssert (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  abstract member VisitAssert: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  default __.VisitAssert expr range context =
    SynExpr.initAssert expr range

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: bool -> funcExpr: SynExpr -> argExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range context =
    this.VisitApp exprAtomicFlag isInfix (funcExpr |> (fun expr -> this.VisitSynExpr expr context)) (argExpr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  abstract member VisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: bool -> funcExpr: SynExpr -> argExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  default __.VisitApp exprAtomicFlag isInfix funcExpr argExpr range context =
    SynExpr.initApp exprAtomicFlag isInfix funcExpr argExpr range

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitTypeApp: expr: SynExpr -> leftAngleRange: Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Range.range> -> typeArgs: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context =
    this.VisitTypeApp (expr |> (fun expr -> this.VisitSynExpr expr context)) leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  abstract member VisitTypeApp: expr: SynExpr -> leftAngleRange: Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Range.range> -> typeArgs: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  default __.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context =
    SynExpr.initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitLetOrUse: isRecursive: bool -> isUse: bool -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range context =
    this.VisitLetOrUse isRecursive isUse bindings (exprBody |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  abstract member VisitLetOrUse: isRecursive: bool -> isUse: bool -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  default __.VisitLetOrUse isRecursive isUse bindings exprBody range context =
    SynExpr.initLetOrUse isRecursive isUse bindings exprBody range

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitTryWith: tryExpr: SynExpr -> item2: Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Range.range -> range: Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith context =
    this.VisitTryWith (tryExpr |> (fun expr -> this.VisitSynExpr expr context)) item2 item3 item4 range spTry spWith context

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  abstract member VisitTryWith: tryExpr: SynExpr -> item2: Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Range.range -> range: Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  default __.VisitTryWith tryExpr item2 item3 item4 range spTry spWith context =
    SynExpr.initTryWith tryExpr item2 item3 item4 range spTry spWith

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitTryFinally: tryExpr: SynExpr -> finallyExpr: SynExpr -> range: Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally context =
    this.VisitTryFinally (tryExpr |> (fun expr -> this.VisitSynExpr expr context)) (finallyExpr |> (fun expr -> this.VisitSynExpr expr context)) range spTry spFinally context

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  abstract member VisitTryFinally: tryExpr: SynExpr -> finallyExpr: SynExpr -> range: Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  default __.VisitTryFinally tryExpr finallyExpr range spTry spFinally context =
    SynExpr.initTryFinally tryExpr finallyExpr range spTry spFinally

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitLazy: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitLazy expr range context =
    this.VisitLazy (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  abstract member VisitLazy: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  default __.VisitLazy expr range context =
    SynExpr.initLazy expr range

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: bool -> expr1: SynExpr -> expr2: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range context =
    this.VisitSequential spSeq isTrueSeq (expr1 |> (fun expr -> this.VisitSynExpr expr context)) (expr2 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  abstract member VisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: bool -> expr1: SynExpr -> expr2: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  default __.VisitSequential spSeq isTrueSeq expr1 expr2 range context =
    SynExpr.initSequential spSeq isTrueSeq expr1 expr2 range

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitIfThenElse: exprGuard: SynExpr -> exprThen: SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: bool -> ifToThen: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context =
    this.VisitIfThenElse (exprGuard |> (fun expr -> this.VisitSynExpr expr context)) (exprThen |> (fun expr -> this.VisitSynExpr expr context)) (optionalExprElse |> (Option.map (fun expr -> this.VisitSynExpr expr context))) spIfToThen isFromErrorRecovery ifToThen range context

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  abstract member VisitIfThenElse: exprGuard: SynExpr -> exprThen: SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: bool -> ifToThen: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  default __.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context =
    SynExpr.initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitIdent item context =
    this.VisitIdent item context

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  abstract member VisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  default __.VisitIdent item context =
    SynExpr.initIdent item

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitLongIdent: isOptional: bool -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range context =
    this.VisitLongIdent isOptional longIdent altNameRefCell range context

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  abstract member VisitLongIdent: isOptional: bool -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  default __.VisitLongIdent isOptional longIdent altNameRefCell range context =
    SynExpr.initLongIdent isOptional longIdent altNameRefCell range

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitLongIdentSet dotId expr range context =
    this.VisitLongIdentSet dotId (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  abstract member VisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  default __.VisitLongIdentSet dotId expr range context =
    SynExpr.initLongIdentSet dotId expr range

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitDotGet: expr: SynExpr -> rangeOfDot: Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitDotGet expr rangeOfDot dotId range context =
    this.VisitDotGet (expr |> (fun expr -> this.VisitSynExpr expr context)) rangeOfDot dotId range context

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  abstract member VisitDotGet: expr: SynExpr -> rangeOfDot: Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  default __.VisitDotGet expr rangeOfDot dotId range context =
    SynExpr.initDotGet expr rangeOfDot dotId range

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitDotSet: expr: SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitDotSet expr dotId exprValue range context =
    this.VisitDotSet (expr |> (fun expr -> this.VisitSynExpr expr context)) dotId (exprValue |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  abstract member VisitDotSet: expr: SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  default __.VisitDotSet expr dotId exprValue range context =
    SynExpr.initDotSet expr dotId exprValue range

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitDotIndexedGet: expr: SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitDotIndexedGet expr indexExprs item3 range context =
    this.VisitDotIndexedGet (expr |> (fun expr -> this.VisitSynExpr expr context)) indexExprs item3 range context

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  abstract member VisitDotIndexedGet: expr: SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  default __.VisitDotIndexedGet expr indexExprs item3 range context =
    SynExpr.initDotIndexedGet expr indexExprs item3 range

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitDotIndexedSet: objectExpr: SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: SynExpr -> rangeOfLeftOfSet: Range.range -> rangeOfDot: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context =
    this.VisitDotIndexedSet (objectExpr |> (fun expr -> this.VisitSynExpr expr context)) indexExprs (valueExpr |> (fun expr -> this.VisitSynExpr expr context)) rangeOfLeftOfSet rangeOfDot range context

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  abstract member VisitDotIndexedSet: objectExpr: SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: SynExpr -> rangeOfLeftOfSet: Range.range -> rangeOfDot: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  default __.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context =
    SynExpr.initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: SynExpr -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range context =
    this.VisitNamedIndexedPropertySet item1 (item2 |> (fun expr -> this.VisitSynExpr expr context)) (item3 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  abstract member VisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: SynExpr -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  default __.VisitNamedIndexedPropertySet item1 item2 item3 range context =
    SynExpr.initNamedIndexedPropertySet item1 item2 item3 range

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitDotNamedIndexedPropertySet: item1: SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: SynExpr -> item4: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context =
    this.VisitDotNamedIndexedPropertySet (item1 |> (fun expr -> this.VisitSynExpr expr context)) item2 (item3 |> (fun expr -> this.VisitSynExpr expr context)) (item4 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  abstract member VisitDotNamedIndexedPropertySet: item1: SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: SynExpr -> item4: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  default __.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context =
    SynExpr.initDotNamedIndexedPropertySet item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitTypeTest: expr: SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitTypeTest expr typeName range context =
    this.VisitTypeTest (expr |> (fun expr -> this.VisitSynExpr expr context)) typeName range context

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  abstract member VisitTypeTest: expr: SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  default __.VisitTypeTest expr typeName range context =
    SynExpr.initTypeTest expr typeName range

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitUpcast: expr: SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitUpcast expr typeSig range context =
    this.VisitUpcast (expr |> (fun expr -> this.VisitSynExpr expr context)) typeSig range context

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  abstract member VisitUpcast: expr: SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  default __.VisitUpcast expr typeSig range context =
    SynExpr.initUpcast expr typeSig range

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitDowncast: expr: SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitDowncast expr typeName range context =
    this.VisitDowncast (expr |> (fun expr -> this.VisitSynExpr expr context)) typeName range context

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  abstract member VisitDowncast: expr: SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  default __.VisitDowncast expr typeName range context =
    SynExpr.initDowncast expr typeName range

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitInferredUpcast: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitInferredUpcast expr range context =
    this.VisitInferredUpcast (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  abstract member VisitInferredUpcast: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  default __.VisitInferredUpcast expr range context =
    SynExpr.initInferredUpcast expr range

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitInferredDowncast: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitInferredDowncast expr range context =
    this.VisitInferredDowncast (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  abstract member VisitInferredDowncast: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  default __.VisitInferredDowncast expr range context =
    SynExpr.initInferredDowncast expr range

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitNull: range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitNull range context =
    this.VisitNull range context

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  abstract member VisitNull: range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  default __.VisitNull range context =
    SynExpr.initNull range

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitAddressOf: item1: bool -> item2: SynExpr -> item3: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitAddressOf item1 item2 item3 range context =
    this.VisitAddressOf item1 (item2 |> (fun expr -> this.VisitSynExpr expr context)) item3 range context

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  abstract member VisitAddressOf: item1: bool -> item2: SynExpr -> item3: Range.range -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  default __.VisitAddressOf item1 item2 item3 range context =
    SynExpr.initAddressOf item1 item2 item3 range

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitTraitCall item1 item2 item3 range context =
    this.VisitTraitCall item1 item2 (item3 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  abstract member VisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  default __.VisitTraitCall item1 item2 item3 range context =
    SynExpr.initTraitCall item1 item2 item3 range

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitJoinIn: item1: SynExpr -> inPos: Range.range -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitJoinIn item1 inPos item3 range context =
    this.VisitJoinIn (item1 |> (fun expr -> this.VisitSynExpr expr context)) inPos (item3 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  abstract member VisitJoinIn: item1: SynExpr -> inPos: Range.range -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  default __.VisitJoinIn item1 inPos item3 range context =
    SynExpr.initJoinIn item1 inPos item3 range

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitImplicitZero: range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitImplicitZero range context =
    this.VisitImplicitZero range context

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  abstract member VisitImplicitZero: range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  default __.VisitImplicitZero range context =
    SynExpr.initImplicitZero range

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitYieldOrReturn: item1: (bool * bool) -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitYieldOrReturn item1 expr range context =
    this.VisitYieldOrReturn item1 (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  abstract member VisitYieldOrReturn: item1: (bool * bool) -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  default __.VisitYieldOrReturn item1 expr range context =
    SynExpr.initYieldOrReturn item1 expr range

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitYieldOrReturnFrom: item1: (bool * bool) -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitYieldOrReturnFrom item1 expr range context =
    this.VisitYieldOrReturnFrom item1 (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  abstract member VisitYieldOrReturnFrom: item1: (bool * bool) -> expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  default __.VisitYieldOrReturnFrom item1 expr range context =
    SynExpr.initYieldOrReturnFrom item1 expr range

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: bool -> isFromSource: bool -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: SynExpr -> bodyExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context =
    this.VisitLetOrUseBang spBind isUse isFromSource pattern (rhsExpr |> (fun expr -> this.VisitSynExpr expr context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  abstract member VisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: bool -> isFromSource: bool -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: SynExpr -> bodyExpr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  default __.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context =
    SynExpr.initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitDoBang: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitDoBang expr range context =
    this.VisitDoBang (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  abstract member VisitDoBang: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  default __.VisitDoBang expr range context =
    SynExpr.initDoBang expr range

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range context =
    this.VisitLibraryOnlyILAssembly item1 item2 (item3 |> (List.map (fun expr -> this.VisitSynExpr expr context))) item4 range context

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  abstract member VisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  default __.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range context =
    SynExpr.initLibraryOnlyILAssembly item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: SynExpr -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range context =
    this.VisitLibraryOnlyStaticOptimization item1 (item2 |> (fun expr -> this.VisitSynExpr expr context)) (item3 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  abstract member VisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: SynExpr -> item3: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  default __.VisitLibraryOnlyStaticOptimization item1 item2 item3 range context =
    SynExpr.initLibraryOnlyStaticOptimization item1 item2 item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldGet: item1: SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: int -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context =
    this.VisitLibraryOnlyUnionCaseFieldGet (item1 |> (fun expr -> this.VisitSynExpr expr context)) longId item3 range context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: item1: SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: int -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context =
    SynExpr.initLibraryOnlyUnionCaseFieldGet item1 longId item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldSet: item1: SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: int -> item4: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context =
    this.VisitLibraryOnlyUnionCaseFieldSet (item1 |> (fun expr -> this.VisitSynExpr expr context)) longId item3 (item4 |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: item1: SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: int -> item4: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context =
    SynExpr.initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitArbitraryAfterError: debugStr: string -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitArbitraryAfterError debugStr range context =
    this.VisitArbitraryAfterError debugStr range context

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  abstract member VisitArbitraryAfterError: debugStr: string -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  default __.VisitArbitraryAfterError debugStr range context =
    SynExpr.initArbitraryAfterError debugStr range

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitFromParseError: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitFromParseError expr range context =
    this.VisitFromParseError (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  abstract member VisitFromParseError: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  default __.VisitFromParseError expr range context =
    SynExpr.initFromParseError expr range

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitDiscardAfterMissingQualificationAfterDot: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range context =
    this.VisitDiscardAfterMissingQualificationAfterDot (expr |> (fun expr -> this.VisitSynExpr expr context)) range context

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: expr: SynExpr -> range: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitDiscardAfterMissingQualificationAfterDot expr range context =
    SynExpr.initDiscardAfterMissingQualificationAfterDot expr range

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitFixed: item1: SynExpr -> item2: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitFixed item1 item2 context =
    this.VisitFixed (item1 |> (fun expr -> this.VisitSynExpr expr context)) item2 context

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  abstract member VisitFixed: item1: SynExpr -> item2: Range.range -> context: 'TContext -> SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  default __.VisitFixed item1 item2 context =
    SynExpr.initFixed item1 item2


  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr (context: 'TContext) =
    parents.Push(expr)
    try
      match expr with
      | SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
        this.BeforeVisitParen expr leftParenRange rightParenRange range context
      | SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context
      | SynExpr.Const(constant, range) ->
        this.BeforeVisitConst constant range context
      | SynExpr.Typed(expr, typeSig, range) ->
        this.BeforeVisitTyped expr typeSig range context
      | SynExpr.Tuple(exprs, commaRanges, range) ->
        this.BeforeVisitTuple exprs commaRanges range context
      | SynExpr.ArrayOrList(isList, exprs, range) ->
        this.BeforeVisitArrayOrList isList exprs range context
      | SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        this.BeforeVisitRecord baseInfo copyInfo recordFields range context
      | SynExpr.New(isProtected, typeName, expr, range) ->
        this.BeforeVisitNew isProtected typeName expr range context
      | SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range context
      | SynExpr.While(spWhile, whileBody, doBody, range) ->
        this.BeforeVisitWhile spWhile whileBody doBody range context
      | SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        this.BeforeVisitFor spFor id idBody item4 toBody doBody range context
      | SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context
      | SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        this.BeforeVisitArrayOrListOfSeqExpr isList elements range context
      | SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range context
      | SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        this.BeforeVisitLambda fromMethod inLambdaSeq args body range context
      | SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        this.BeforeVisitMatchLambda item1 item2 clauses spBind range context
      | SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range context
      | SynExpr.Do(expr, range) ->
        this.BeforeVisitDo expr range context
      | SynExpr.Assert(expr, range) ->
        this.BeforeVisitAssert expr range context
      | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range context
      | SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context
      | SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range context
      | SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith context
      | SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally context
      | SynExpr.Lazy(expr, range) ->
        this.BeforeVisitLazy expr range context
      | SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range context
      | SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context
      | SynExpr.Ident(item) ->
        this.BeforeVisitIdent item context
      | SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range context
      | SynExpr.LongIdentSet(dotId, expr, range) ->
        this.BeforeVisitLongIdentSet dotId expr range context
      | SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        this.BeforeVisitDotGet expr rangeOfDot dotId range context
      | SynExpr.DotSet(expr, dotId, exprValue, range) ->
        this.BeforeVisitDotSet expr dotId exprValue range context
      | SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        this.BeforeVisitDotIndexedGet expr indexExprs item3 range context
      | SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context
      | SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range context
      | SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context
      | SynExpr.TypeTest(expr, typeName, range) ->
        this.BeforeVisitTypeTest expr typeName range context
      | SynExpr.Upcast(expr, typeSig, range) ->
        this.BeforeVisitUpcast expr typeSig range context
      | SynExpr.Downcast(expr, typeName, range) ->
        this.BeforeVisitDowncast expr typeName range context
      | SynExpr.InferredUpcast(expr, range) ->
        this.BeforeVisitInferredUpcast expr range context
      | SynExpr.InferredDowncast(expr, range) ->
        this.BeforeVisitInferredDowncast expr range context
      | SynExpr.Null(range) ->
        this.BeforeVisitNull range context
      | SynExpr.AddressOf(item1, item2, item3, range) ->
        this.BeforeVisitAddressOf item1 item2 item3 range context
      | SynExpr.TraitCall(item1, item2, item3, range) ->
        this.BeforeVisitTraitCall item1 item2 item3 range context
      | SynExpr.JoinIn(item1, inPos, item3, range) ->
        this.BeforeVisitJoinIn item1 inPos item3 range context
      | SynExpr.ImplicitZero(range) ->
        this.BeforeVisitImplicitZero range context
      | SynExpr.YieldOrReturn(item1, expr, range) ->
        this.BeforeVisitYieldOrReturn item1 expr range context
      | SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        this.BeforeVisitYieldOrReturnFrom item1 expr range context
      | SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context
      | SynExpr.DoBang(expr, range) ->
        this.BeforeVisitDoBang expr range context
      | SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range context
      | SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range context
      | SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context
      | SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context
      | SynExpr.ArbitraryAfterError(debugStr, range) ->
        this.BeforeVisitArbitraryAfterError debugStr range context
      | SynExpr.FromParseError(expr, range) ->
        this.BeforeVisitFromParseError expr range context
      | SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range context
      | SynExpr.Fixed(item1, item2) ->
        this.BeforeVisitFixed item1 item2 context

    finally
      parents.Pop() |> ignore
