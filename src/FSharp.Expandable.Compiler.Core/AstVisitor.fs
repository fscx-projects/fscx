//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Mon, 01 Aug 2016 06:07:22 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

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
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Construct "SynExpr.Quote".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initQuote operator isRaw quotedSynExpr isFromQueryExpression range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

  /// <summary>
  /// Construct "SynExpr.Const".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initConst constant range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range)

  /// <summary>
  /// Construct "SynExpr.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range)

  /// <summary>
  /// Construct "SynExpr.Tuple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTuple exprs commaRanges range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range)

  /// <summary>
  /// Construct "SynExpr.ArrayOrList".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrList isList exprs range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range)

  /// <summary>
  /// Construct "SynExpr.Record".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRecord baseInfo copyInfo recordFields range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Construct "SynExpr.New".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNew isProtected typeName expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range)

  /// <summary>
  /// Construct "SynExpr.ObjExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initObjExpr objType argOpt bindings extraImpls newPos range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Construct "SynExpr.While".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhile spWhile whileBody doBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range)

  /// <summary>
  /// Construct "SynExpr.For".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFor spFor id idBody item4 toBody doBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Construct "SynExpr.ForEach".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Construct "SynExpr.ArrayOrListOfSeqExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrListOfSeqExpr isList elements range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)

  /// <summary>
  /// Construct "SynExpr.CompExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initCompExpr isArrayOrList isNotNakedRefCell expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Construct "SynExpr.Lambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLambda fromMethod inLambdaSeq args body range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Construct "SynExpr.MatchLambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatchLambda item1 item2 clauses spBind range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range)

  /// <summary>
  /// Construct "SynExpr.Match".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatch spBind matchExpr clauses isCexprExceptionMatch range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Construct "SynExpr.Do".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDo expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range)

  /// <summary>
  /// Construct "SynExpr.Assert".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAssert expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range)

  /// <summary>
  /// Construct "SynExpr.App".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initApp exprAtomicFlag isInfix funcExpr argExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Construct "SynExpr.TypeApp".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Construct "SynExpr.LetOrUse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUse isRecursive isUse bindings exprBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Construct "SynExpr.TryWith".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryWith tryExpr item2 item3 item4 range spTry spWith =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Construct "SynExpr.TryFinally".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryFinally tryExpr finallyExpr range spTry spFinally =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Construct "SynExpr.Lazy".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLazy expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range)

  /// <summary>
  /// Construct "SynExpr.Sequential".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequential spSeq isTrueSeq expr1 expr2 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Construct "SynExpr.IfThenElse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Construct "SynExpr.Ident".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIdent item =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)

  /// <summary>
  /// Construct "SynExpr.LongIdent".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdent isOptional longIdent altNameRefCell range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Construct "SynExpr.LongIdentSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdentSet dotId expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range)

  /// <summary>
  /// Construct "SynExpr.DotGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotGet expr rangeOfDot dotId range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Construct "SynExpr.DotSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotSet expr dotId exprValue range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range)

  /// <summary>
  /// Construct "SynExpr.DotIndexedGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedGet expr indexExprs item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range)

  /// <summary>
  /// Construct "SynExpr.DotIndexedSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Construct "SynExpr.NamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamedIndexedPropertySet item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotNamedIndexedPropertySet item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.TypeTest".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeTest expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range)

  /// <summary>
  /// Construct "SynExpr.Upcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUpcast expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range)

  /// <summary>
  /// Construct "SynExpr.Downcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDowncast expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range)

  /// <summary>
  /// Construct "SynExpr.InferredUpcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredUpcast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range)

  /// <summary>
  /// Construct "SynExpr.InferredDowncast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredDowncast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range)

  /// <summary>
  /// Construct "SynExpr.Null".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNull range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)

  /// <summary>
  /// Construct "SynExpr.AddressOf".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAddressOf item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.TraitCall".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTraitCall item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.JoinIn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initJoinIn item1 inPos item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range)

  /// <summary>
  /// Construct "SynExpr.ImplicitZero".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplicitZero range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)

  /// <summary>
  /// Construct "SynExpr.YieldOrReturn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturn item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range)

  /// <summary>
  /// Construct "SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturnFrom item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range)

  /// <summary>
  /// Construct "SynExpr.LetOrUseBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Construct "SynExpr.DoBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDoBang expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyILAssembly item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyStaticOptimization item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldGet item1 longId item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)

  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)

  /// <summary>
  /// Construct "SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArbitraryAfterError debugStr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)

  /// <summary>
  /// Construct "SynExpr.FromParseError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFromParseError expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range)

  /// <summary>
  /// Construct "SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDiscardAfterMissingQualificationAfterDot expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)

  /// <summary>
  /// Construct "SynExpr.Fixed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFixed item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2)


////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  abstract member BeforeVisitParen: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitParen parents context expr leftParenRange rightParenRange range =
    this.VisitParen parents context (expr |> (this.VisitSynExpr parents context)) leftParenRange rightParenRange range

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  abstract member VisitParen: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  default __.VisitParen parents context expr leftParenRange rightParenRange range =
    SynExpr.initParen expr leftParenRange rightParenRange range

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitQuote: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    this.VisitQuote parents context (operator |> (this.VisitSynExpr parents context)) isRaw (quotedSynExpr |> (this.VisitSynExpr parents context)) isFromQueryExpression range

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  abstract member VisitQuote: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  default __.VisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    SynExpr.initQuote operator isRaw quotedSynExpr isFromQueryExpression range

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitConst: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitConst parents context constant range =
    this.VisitConst parents context constant range

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  abstract member VisitConst: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  default __.VisitConst parents context constant range =
    SynExpr.initConst constant range

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitTyped: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitTyped parents context expr typeSig range =
    this.VisitTyped parents context (expr |> (this.VisitSynExpr parents context)) typeSig range

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  abstract member VisitTyped: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  default __.VisitTyped parents context expr typeSig range =
    SynExpr.initTyped expr typeSig range

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitTuple: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitTuple parents context exprs commaRanges range =
    this.VisitTuple parents context (exprs |> (List.map (this.VisitSynExpr parents context))) commaRanges range

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  abstract member VisitTuple: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  default __.VisitTuple parents context exprs commaRanges range =
    SynExpr.initTuple exprs commaRanges range

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitArrayOrList: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitArrayOrList parents context isList exprs range =
    this.VisitArrayOrList parents context isList (exprs |> (List.map (this.VisitSynExpr parents context))) range

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  abstract member VisitArrayOrList: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  default __.VisitArrayOrList parents context isList exprs range =
    SynExpr.initArrayOrList isList exprs range

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitRecord: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitRecord parents context baseInfo copyInfo recordFields range =
    this.VisitRecord parents context baseInfo copyInfo recordFields range

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  abstract member VisitRecord: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  default __.VisitRecord parents context baseInfo copyInfo recordFields range =
    SynExpr.initRecord baseInfo copyInfo recordFields range

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitNew: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitNew parents context isProtected typeName expr range =
    this.VisitNew parents context isProtected typeName (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  abstract member VisitNew: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  default __.VisitNew parents context isProtected typeName expr range =
    SynExpr.initNew isProtected typeName expr range

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitObjExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    this.VisitObjExpr parents context objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  abstract member VisitObjExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  default __.VisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    SynExpr.initObjExpr objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitWhile: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitWhile parents context spWhile whileBody doBody range =
    this.VisitWhile parents context spWhile (whileBody |> (this.VisitSynExpr parents context)) (doBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  abstract member VisitWhile: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  default __.VisitWhile parents context spWhile whileBody doBody range =
    SynExpr.initWhile spWhile whileBody doBody range

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitFor: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitFor parents context spFor id idBody item4 toBody doBody range =
    this.VisitFor parents context spFor id (idBody |> (this.VisitSynExpr parents context)) item4 (toBody |> (this.VisitSynExpr parents context)) (doBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  abstract member VisitFor: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  default __.VisitFor parents context spFor id idBody item4 toBody doBody range =
    SynExpr.initFor spFor id idBody item4 toBody doBody range

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitForEach: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    this.VisitForEach parents context spFor seqExprOnly isFromSource pattern (enumExpr |> (this.VisitSynExpr parents context)) (bodyExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  abstract member VisitForEach: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  default __.VisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    SynExpr.initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitArrayOrListOfSeqExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitArrayOrListOfSeqExpr parents context isList elements range =
    this.VisitArrayOrListOfSeqExpr parents context isList (elements |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  abstract member VisitArrayOrListOfSeqExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  default __.VisitArrayOrListOfSeqExpr parents context isList elements range =
    SynExpr.initArrayOrListOfSeqExpr isList elements range

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitCompExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    this.VisitCompExpr parents context isArrayOrList isNotNakedRefCell (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  abstract member VisitCompExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  default __.VisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    SynExpr.initCompExpr isArrayOrList isNotNakedRefCell expr range

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitLambda parents context fromMethod inLambdaSeq args body range =
    this.VisitLambda parents context fromMethod inLambdaSeq args (body |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  abstract member VisitLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  default __.VisitLambda parents context fromMethod inLambdaSeq args body range =
    SynExpr.initLambda fromMethod inLambdaSeq args body range

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitMatchLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitMatchLambda parents context item1 item2 clauses spBind range =
    this.VisitMatchLambda parents context item1 item2 clauses spBind range

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  abstract member VisitMatchLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  default __.VisitMatchLambda parents context item1 item2 clauses spBind range =
    SynExpr.initMatchLambda item1 item2 clauses spBind range

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitMatch: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    this.VisitMatch parents context spBind (matchExpr |> (this.VisitSynExpr parents context)) clauses isCexprExceptionMatch range

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  abstract member VisitMatch: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  default __.VisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    SynExpr.initMatch spBind matchExpr clauses isCexprExceptionMatch range

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitDo: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitDo parents context expr range =
    this.VisitDo parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  abstract member VisitDo: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  default __.VisitDo parents context expr range =
    SynExpr.initDo expr range

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitAssert: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitAssert parents context expr range =
    this.VisitAssert parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  abstract member VisitAssert: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  default __.VisitAssert parents context expr range =
    SynExpr.initAssert expr range

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    this.VisitApp parents context exprAtomicFlag isInfix (funcExpr |> (this.VisitSynExpr parents context)) (argExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  abstract member VisitApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  default __.VisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    SynExpr.initApp exprAtomicFlag isInfix funcExpr argExpr range

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitTypeApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    this.VisitTypeApp parents context (expr |> (this.VisitSynExpr parents context)) leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  abstract member VisitTypeApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  default __.VisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    SynExpr.initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitLetOrUse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    this.VisitLetOrUse parents context isRecursive isUse bindings (exprBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  abstract member VisitLetOrUse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  default __.VisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    SynExpr.initLetOrUse isRecursive isUse bindings exprBody range

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitTryWith: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    this.VisitTryWith parents context (tryExpr |> (this.VisitSynExpr parents context)) item2 item3 item4 range spTry spWith

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  abstract member VisitTryWith: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  default __.VisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    SynExpr.initTryWith tryExpr item2 item3 item4 range spTry spWith

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitTryFinally: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    this.VisitTryFinally parents context (tryExpr |> (this.VisitSynExpr parents context)) (finallyExpr |> (this.VisitSynExpr parents context)) range spTry spFinally

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  abstract member VisitTryFinally: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  default __.VisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    SynExpr.initTryFinally tryExpr finallyExpr range spTry spFinally

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitLazy: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitLazy parents context expr range =
    this.VisitLazy parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  abstract member VisitLazy: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  default __.VisitLazy parents context expr range =
    SynExpr.initLazy expr range

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSequential: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    this.VisitSequential parents context spSeq isTrueSeq (expr1 |> (this.VisitSynExpr parents context)) (expr2 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  abstract member VisitSequential: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  default __.VisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    SynExpr.initSequential spSeq isTrueSeq expr1 expr2 range

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitIfThenElse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    this.VisitIfThenElse parents context (exprGuard |> (this.VisitSynExpr parents context)) (exprThen |> (this.VisitSynExpr parents context)) (optionalExprElse |> (Option.map (this.VisitSynExpr parents context))) spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  abstract member VisitIfThenElse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  default __.VisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    SynExpr.initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitIdent parents context item =
    this.VisitIdent parents context item

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  abstract member VisitIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  default __.VisitIdent parents context item =
    SynExpr.initIdent item

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitLongIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitLongIdent parents context isOptional longIdent altNameRefCell range =
    this.VisitLongIdent parents context isOptional longIdent altNameRefCell range

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  abstract member VisitLongIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  default __.VisitLongIdent parents context isOptional longIdent altNameRefCell range =
    SynExpr.initLongIdent isOptional longIdent altNameRefCell range

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitLongIdentSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitLongIdentSet parents context dotId expr range =
    this.VisitLongIdentSet parents context dotId (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  abstract member VisitLongIdentSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  default __.VisitLongIdentSet parents context dotId expr range =
    SynExpr.initLongIdentSet dotId expr range

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitDotGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitDotGet parents context expr rangeOfDot dotId range =
    this.VisitDotGet parents context (expr |> (this.VisitSynExpr parents context)) rangeOfDot dotId range

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  abstract member VisitDotGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  default __.VisitDotGet parents context expr rangeOfDot dotId range =
    SynExpr.initDotGet expr rangeOfDot dotId range

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitDotSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitDotSet parents context expr dotId exprValue range =
    this.VisitDotSet parents context (expr |> (this.VisitSynExpr parents context)) dotId (exprValue |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  abstract member VisitDotSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  default __.VisitDotSet parents context expr dotId exprValue range =
    SynExpr.initDotSet expr dotId exprValue range

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitDotIndexedGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitDotIndexedGet parents context expr indexExprs item3 range =
    this.VisitDotIndexedGet parents context (expr |> (this.VisitSynExpr parents context)) indexExprs item3 range

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  abstract member VisitDotIndexedGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  default __.VisitDotIndexedGet parents context expr indexExprs item3 range =
    SynExpr.initDotIndexedGet expr indexExprs item3 range

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitDotIndexedSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    this.VisitDotIndexedSet parents context (objectExpr |> (this.VisitSynExpr parents context)) indexExprs (valueExpr |> (this.VisitSynExpr parents context)) rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  abstract member VisitDotIndexedSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  default __.VisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    SynExpr.initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    this.VisitNamedIndexedPropertySet parents context item1 (item2 |> (this.VisitSynExpr parents context)) (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  abstract member VisitNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  default __.VisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    SynExpr.initNamedIndexedPropertySet item1 item2 item3 range

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitDotNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    this.VisitDotNamedIndexedPropertySet parents context (item1 |> (this.VisitSynExpr parents context)) item2 (item3 |> (this.VisitSynExpr parents context)) (item4 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  abstract member VisitDotNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  default __.VisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    SynExpr.initDotNamedIndexedPropertySet item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitTypeTest: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitTypeTest parents context expr typeName range =
    this.VisitTypeTest parents context (expr |> (this.VisitSynExpr parents context)) typeName range

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  abstract member VisitTypeTest: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  default __.VisitTypeTest parents context expr typeName range =
    SynExpr.initTypeTest expr typeName range

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitUpcast parents context expr typeSig range =
    this.VisitUpcast parents context (expr |> (this.VisitSynExpr parents context)) typeSig range

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  abstract member VisitUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  default __.VisitUpcast parents context expr typeSig range =
    SynExpr.initUpcast expr typeSig range

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitDowncast parents context expr typeName range =
    this.VisitDowncast parents context (expr |> (this.VisitSynExpr parents context)) typeName range

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  abstract member VisitDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  default __.VisitDowncast parents context expr typeName range =
    SynExpr.initDowncast expr typeName range

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitInferredUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitInferredUpcast parents context expr range =
    this.VisitInferredUpcast parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  abstract member VisitInferredUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  default __.VisitInferredUpcast parents context expr range =
    SynExpr.initInferredUpcast expr range

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitInferredDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitInferredDowncast parents context expr range =
    this.VisitInferredDowncast parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  abstract member VisitInferredDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  default __.VisitInferredDowncast parents context expr range =
    SynExpr.initInferredDowncast expr range

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitNull: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitNull parents context range =
    this.VisitNull parents context range

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  abstract member VisitNull: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  default __.VisitNull parents context range =
    SynExpr.initNull range

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitAddressOf: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitAddressOf parents context item1 item2 item3 range =
    this.VisitAddressOf parents context item1 (item2 |> (this.VisitSynExpr parents context)) item3 range

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  abstract member VisitAddressOf: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  default __.VisitAddressOf parents context item1 item2 item3 range =
    SynExpr.initAddressOf item1 item2 item3 range

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitTraitCall: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitTraitCall parents context item1 item2 item3 range =
    this.VisitTraitCall parents context item1 item2 (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  abstract member VisitTraitCall: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  default __.VisitTraitCall parents context item1 item2 item3 range =
    SynExpr.initTraitCall item1 item2 item3 range

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitJoinIn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitJoinIn parents context item1 inPos item3 range =
    this.VisitJoinIn parents context (item1 |> (this.VisitSynExpr parents context)) inPos (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  abstract member VisitJoinIn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  default __.VisitJoinIn parents context item1 inPos item3 range =
    SynExpr.initJoinIn item1 inPos item3 range

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitImplicitZero: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitImplicitZero parents context range =
    this.VisitImplicitZero parents context range

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  abstract member VisitImplicitZero: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  default __.VisitImplicitZero parents context range =
    SynExpr.initImplicitZero range

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitYieldOrReturn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitYieldOrReturn parents context item1 expr range =
    this.VisitYieldOrReturn parents context item1 (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  abstract member VisitYieldOrReturn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  default __.VisitYieldOrReturn parents context item1 expr range =
    SynExpr.initYieldOrReturn item1 expr range

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitYieldOrReturnFrom: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitYieldOrReturnFrom parents context item1 expr range =
    this.VisitYieldOrReturnFrom parents context item1 (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  abstract member VisitYieldOrReturnFrom: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  default __.VisitYieldOrReturnFrom parents context item1 expr range =
    SynExpr.initYieldOrReturnFrom item1 expr range

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitLetOrUseBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    this.VisitLetOrUseBang parents context spBind isUse isFromSource pattern (rhsExpr |> (this.VisitSynExpr parents context)) (bodyExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  abstract member VisitLetOrUseBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  default __.VisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    SynExpr.initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitDoBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitDoBang parents context expr range =
    this.VisitDoBang parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  abstract member VisitDoBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  default __.VisitDoBang parents context expr range =
    SynExpr.initDoBang expr range

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitLibraryOnlyILAssembly: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    this.VisitLibraryOnlyILAssembly parents context item1 item2 (item3 |> (List.map (this.VisitSynExpr parents context))) item4 range

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  abstract member VisitLibraryOnlyILAssembly: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  default __.VisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    SynExpr.initLibraryOnlyILAssembly item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitLibraryOnlyStaticOptimization: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    this.VisitLibraryOnlyStaticOptimization parents context item1 (item2 |> (this.VisitSynExpr parents context)) (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  abstract member VisitLibraryOnlyStaticOptimization: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  default __.VisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    SynExpr.initLibraryOnlyStaticOptimization item1 item2 item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    this.VisitLibraryOnlyUnionCaseFieldGet parents context (item1 |> (this.VisitSynExpr parents context)) longId item3 range

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    SynExpr.initLibraryOnlyUnionCaseFieldGet item1 longId item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    this.VisitLibraryOnlyUnionCaseFieldSet parents context (item1 |> (this.VisitSynExpr parents context)) longId item3 (item4 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    SynExpr.initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitArbitraryAfterError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitArbitraryAfterError parents context debugStr range =
    this.VisitArbitraryAfterError parents context debugStr range

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  abstract member VisitArbitraryAfterError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  default __.VisitArbitraryAfterError parents context debugStr range =
    SynExpr.initArbitraryAfterError debugStr range

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitFromParseError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitFromParseError parents context expr range =
    this.VisitFromParseError parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  abstract member VisitFromParseError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  default __.VisitFromParseError parents context expr range =
    SynExpr.initFromParseError expr range

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitDiscardAfterMissingQualificationAfterDot: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    this.VisitDiscardAfterMissingQualificationAfterDot parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    SynExpr.initDiscardAfterMissingQualificationAfterDot expr range

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitFixed: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitFixed parents context item1 item2 =
    this.VisitFixed parents context (item1 |> (this.VisitSynExpr parents context)) item2

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  abstract member VisitFixed: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  default __.VisitFixed parents context item1 item2 =
    SynExpr.initFixed item1 item2


  abstract member VisitSynExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <param name="expr">Target expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitSynExpr parents context expr =
    let currentParents = expr :: parents
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      this.BeforeVisitParen currentParents context expr leftParenRange rightParenRange range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.BeforeVisitQuote currentParents context operator isRaw quotedSynExpr isFromQueryExpression range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.BeforeVisitConst currentParents context constant range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.BeforeVisitTyped currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.BeforeVisitTuple currentParents context exprs commaRanges range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.BeforeVisitArrayOrList currentParents context isList exprs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.BeforeVisitRecord currentParents context baseInfo copyInfo recordFields range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.BeforeVisitNew currentParents context isProtected typeName expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.BeforeVisitObjExpr currentParents context objType argOpt bindings extraImpls newPos range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.BeforeVisitWhile currentParents context spWhile whileBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.BeforeVisitFor currentParents context spFor id idBody item4 toBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.BeforeVisitForEach currentParents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.BeforeVisitArrayOrListOfSeqExpr currentParents context isList elements range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.BeforeVisitCompExpr currentParents context isArrayOrList isNotNakedRefCell expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.BeforeVisitLambda currentParents context fromMethod inLambdaSeq args body range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.BeforeVisitMatchLambda currentParents context item1 item2 clauses spBind range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.BeforeVisitMatch currentParents context spBind matchExpr clauses isCexprExceptionMatch range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.BeforeVisitDo currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.BeforeVisitAssert currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.BeforeVisitApp currentParents context exprAtomicFlag isInfix funcExpr argExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.BeforeVisitTypeApp currentParents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.BeforeVisitLetOrUse currentParents context isRecursive isUse bindings exprBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.BeforeVisitTryWith currentParents context tryExpr item2 item3 item4 range spTry spWith
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.BeforeVisitTryFinally currentParents context tryExpr finallyExpr range spTry spFinally
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.BeforeVisitLazy currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.BeforeVisitSequential currentParents context spSeq isTrueSeq expr1 expr2 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.BeforeVisitIfThenElse currentParents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.BeforeVisitIdent currentParents context item
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.BeforeVisitLongIdent currentParents context isOptional longIdent altNameRefCell range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.BeforeVisitLongIdentSet currentParents context dotId expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.BeforeVisitDotGet currentParents context expr rangeOfDot dotId range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.BeforeVisitDotSet currentParents context expr dotId exprValue range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.BeforeVisitDotIndexedGet currentParents context expr indexExprs item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.BeforeVisitDotIndexedSet currentParents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.BeforeVisitNamedIndexedPropertySet currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.BeforeVisitDotNamedIndexedPropertySet currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.BeforeVisitTypeTest currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.BeforeVisitUpcast currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.BeforeVisitDowncast currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.BeforeVisitInferredUpcast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.BeforeVisitInferredDowncast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.BeforeVisitNull currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.BeforeVisitAddressOf currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.BeforeVisitTraitCall currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.BeforeVisitJoinIn currentParents context item1 inPos item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.BeforeVisitImplicitZero currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.BeforeVisitYieldOrReturn currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.BeforeVisitYieldOrReturnFrom currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.BeforeVisitLetOrUseBang currentParents context spBind isUse isFromSource pattern rhsExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.BeforeVisitDoBang currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyILAssembly currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.BeforeVisitLibraryOnlyStaticOptimization currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldGet currentParents context item1 longId item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldSet currentParents context item1 longId item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.BeforeVisitArbitraryAfterError currentParents context debugStr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.BeforeVisitFromParseError currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.BeforeVisitDiscardAfterMissingQualificationAfterDot currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.BeforeVisitFixed currentParents context item1 item2


////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor<'TContext>() =

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  abstract member BeforeVisitParen: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitParen parents context expr leftParenRange rightParenRange range =
    this.VisitParen parents context (expr |> (this.VisitSynExpr parents context)) leftParenRange rightParenRange range

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  abstract member VisitParen: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  default __.VisitParen parents context expr leftParenRange rightParenRange range =
    SynExpr.initParen expr leftParenRange rightParenRange range

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitQuote: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    this.VisitQuote parents context (operator |> (this.VisitSynExpr parents context)) isRaw (quotedSynExpr |> (this.VisitSynExpr parents context)) isFromQueryExpression range

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  abstract member VisitQuote: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  default __.VisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    SynExpr.initQuote operator isRaw quotedSynExpr isFromQueryExpression range

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitConst: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitConst parents context constant range =
    this.VisitConst parents context constant range

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  abstract member VisitConst: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  default __.VisitConst parents context constant range =
    SynExpr.initConst constant range

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitTyped: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitTyped parents context expr typeSig range =
    this.VisitTyped parents context (expr |> (this.VisitSynExpr parents context)) typeSig range

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  abstract member VisitTyped: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  default __.VisitTyped parents context expr typeSig range =
    SynExpr.initTyped expr typeSig range

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitTuple: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitTuple parents context exprs commaRanges range =
    this.VisitTuple parents context (exprs |> (List.map (this.VisitSynExpr parents context))) commaRanges range

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  abstract member VisitTuple: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  default __.VisitTuple parents context exprs commaRanges range =
    SynExpr.initTuple exprs commaRanges range

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitArrayOrList: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitArrayOrList parents context isList exprs range =
    this.VisitArrayOrList parents context isList (exprs |> (List.map (this.VisitSynExpr parents context))) range

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  abstract member VisitArrayOrList: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  default __.VisitArrayOrList parents context isList exprs range =
    SynExpr.initArrayOrList isList exprs range

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitRecord: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitRecord parents context baseInfo copyInfo recordFields range =
    this.VisitRecord parents context baseInfo copyInfo recordFields range

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  abstract member VisitRecord: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  default __.VisitRecord parents context baseInfo copyInfo recordFields range =
    SynExpr.initRecord baseInfo copyInfo recordFields range

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitNew: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitNew parents context isProtected typeName expr range =
    this.VisitNew parents context isProtected typeName (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  abstract member VisitNew: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  default __.VisitNew parents context isProtected typeName expr range =
    SynExpr.initNew isProtected typeName expr range

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitObjExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    this.VisitObjExpr parents context objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  abstract member VisitObjExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  default __.VisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    SynExpr.initObjExpr objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitWhile: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitWhile parents context spWhile whileBody doBody range =
    this.VisitWhile parents context spWhile (whileBody |> (this.VisitSynExpr parents context)) (doBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  abstract member VisitWhile: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  default __.VisitWhile parents context spWhile whileBody doBody range =
    SynExpr.initWhile spWhile whileBody doBody range

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitFor: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitFor parents context spFor id idBody item4 toBody doBody range =
    this.VisitFor parents context spFor id (idBody |> (this.VisitSynExpr parents context)) item4 (toBody |> (this.VisitSynExpr parents context)) (doBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  abstract member VisitFor: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  default __.VisitFor parents context spFor id idBody item4 toBody doBody range =
    SynExpr.initFor spFor id idBody item4 toBody doBody range

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitForEach: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    this.VisitForEach parents context spFor seqExprOnly isFromSource pattern (enumExpr |> (this.VisitSynExpr parents context)) (bodyExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  abstract member VisitForEach: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  default __.VisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    SynExpr.initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitArrayOrListOfSeqExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitArrayOrListOfSeqExpr parents context isList elements range =
    this.VisitArrayOrListOfSeqExpr parents context isList (elements |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  abstract member VisitArrayOrListOfSeqExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  default __.VisitArrayOrListOfSeqExpr parents context isList elements range =
    SynExpr.initArrayOrListOfSeqExpr isList elements range

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitCompExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    this.VisitCompExpr parents context isArrayOrList isNotNakedRefCell (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  abstract member VisitCompExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  default __.VisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    SynExpr.initCompExpr isArrayOrList isNotNakedRefCell expr range

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitLambda parents context fromMethod inLambdaSeq args body range =
    this.VisitLambda parents context fromMethod inLambdaSeq args (body |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  abstract member VisitLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  default __.VisitLambda parents context fromMethod inLambdaSeq args body range =
    SynExpr.initLambda fromMethod inLambdaSeq args body range

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitMatchLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitMatchLambda parents context item1 item2 clauses spBind range =
    this.VisitMatchLambda parents context item1 item2 clauses spBind range

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  abstract member VisitMatchLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  default __.VisitMatchLambda parents context item1 item2 clauses spBind range =
    SynExpr.initMatchLambda item1 item2 clauses spBind range

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitMatch: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    this.VisitMatch parents context spBind (matchExpr |> (this.VisitSynExpr parents context)) clauses isCexprExceptionMatch range

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  abstract member VisitMatch: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  default __.VisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    SynExpr.initMatch spBind matchExpr clauses isCexprExceptionMatch range

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitDo: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitDo parents context expr range =
    this.VisitDo parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  abstract member VisitDo: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  default __.VisitDo parents context expr range =
    SynExpr.initDo expr range

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitAssert: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitAssert parents context expr range =
    this.VisitAssert parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  abstract member VisitAssert: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  default __.VisitAssert parents context expr range =
    SynExpr.initAssert expr range

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    this.VisitApp parents context exprAtomicFlag isInfix (funcExpr |> (this.VisitSynExpr parents context)) (argExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  abstract member VisitApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  default __.VisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    SynExpr.initApp exprAtomicFlag isInfix funcExpr argExpr range

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitTypeApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    this.VisitTypeApp parents context (expr |> (this.VisitSynExpr parents context)) leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  abstract member VisitTypeApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  default __.VisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    SynExpr.initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitLetOrUse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    this.VisitLetOrUse parents context isRecursive isUse bindings (exprBody |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  abstract member VisitLetOrUse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  default __.VisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    SynExpr.initLetOrUse isRecursive isUse bindings exprBody range

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitTryWith: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    this.VisitTryWith parents context (tryExpr |> (this.VisitSynExpr parents context)) item2 item3 item4 range spTry spWith

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  abstract member VisitTryWith: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  default __.VisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    SynExpr.initTryWith tryExpr item2 item3 item4 range spTry spWith

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitTryFinally: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    this.VisitTryFinally parents context (tryExpr |> (this.VisitSynExpr parents context)) (finallyExpr |> (this.VisitSynExpr parents context)) range spTry spFinally

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  abstract member VisitTryFinally: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  default __.VisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    SynExpr.initTryFinally tryExpr finallyExpr range spTry spFinally

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitLazy: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitLazy parents context expr range =
    this.VisitLazy parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  abstract member VisitLazy: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  default __.VisitLazy parents context expr range =
    SynExpr.initLazy expr range

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSequential: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    this.VisitSequential parents context spSeq isTrueSeq (expr1 |> (this.VisitSynExpr parents context)) (expr2 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  abstract member VisitSequential: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  default __.VisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    SynExpr.initSequential spSeq isTrueSeq expr1 expr2 range

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitIfThenElse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    this.VisitIfThenElse parents context (exprGuard |> (this.VisitSynExpr parents context)) (exprThen |> (this.VisitSynExpr parents context)) (optionalExprElse |> (Option.map (this.VisitSynExpr parents context))) spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  abstract member VisitIfThenElse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  default __.VisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    SynExpr.initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitIdent parents context item =
    this.VisitIdent parents context item

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  abstract member VisitIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  default __.VisitIdent parents context item =
    SynExpr.initIdent item

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitLongIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitLongIdent parents context isOptional longIdent altNameRefCell range =
    this.VisitLongIdent parents context isOptional longIdent altNameRefCell range

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  abstract member VisitLongIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  default __.VisitLongIdent parents context isOptional longIdent altNameRefCell range =
    SynExpr.initLongIdent isOptional longIdent altNameRefCell range

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitLongIdentSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitLongIdentSet parents context dotId expr range =
    this.VisitLongIdentSet parents context dotId (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  abstract member VisitLongIdentSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  default __.VisitLongIdentSet parents context dotId expr range =
    SynExpr.initLongIdentSet dotId expr range

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitDotGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitDotGet parents context expr rangeOfDot dotId range =
    this.VisitDotGet parents context (expr |> (this.VisitSynExpr parents context)) rangeOfDot dotId range

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  abstract member VisitDotGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  default __.VisitDotGet parents context expr rangeOfDot dotId range =
    SynExpr.initDotGet expr rangeOfDot dotId range

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitDotSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitDotSet parents context expr dotId exprValue range =
    this.VisitDotSet parents context (expr |> (this.VisitSynExpr parents context)) dotId (exprValue |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  abstract member VisitDotSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  default __.VisitDotSet parents context expr dotId exprValue range =
    SynExpr.initDotSet expr dotId exprValue range

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitDotIndexedGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitDotIndexedGet parents context expr indexExprs item3 range =
    this.VisitDotIndexedGet parents context (expr |> (this.VisitSynExpr parents context)) indexExprs item3 range

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  abstract member VisitDotIndexedGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  default __.VisitDotIndexedGet parents context expr indexExprs item3 range =
    SynExpr.initDotIndexedGet expr indexExprs item3 range

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitDotIndexedSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    this.VisitDotIndexedSet parents context (objectExpr |> (this.VisitSynExpr parents context)) indexExprs (valueExpr |> (this.VisitSynExpr parents context)) rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  abstract member VisitDotIndexedSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  default __.VisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    SynExpr.initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    this.VisitNamedIndexedPropertySet parents context item1 (item2 |> (this.VisitSynExpr parents context)) (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  abstract member VisitNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  default __.VisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    SynExpr.initNamedIndexedPropertySet item1 item2 item3 range

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitDotNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    this.VisitDotNamedIndexedPropertySet parents context (item1 |> (this.VisitSynExpr parents context)) item2 (item3 |> (this.VisitSynExpr parents context)) (item4 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  abstract member VisitDotNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  default __.VisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    SynExpr.initDotNamedIndexedPropertySet item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitTypeTest: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitTypeTest parents context expr typeName range =
    this.VisitTypeTest parents context (expr |> (this.VisitSynExpr parents context)) typeName range

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  abstract member VisitTypeTest: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  default __.VisitTypeTest parents context expr typeName range =
    SynExpr.initTypeTest expr typeName range

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitUpcast parents context expr typeSig range =
    this.VisitUpcast parents context (expr |> (this.VisitSynExpr parents context)) typeSig range

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  abstract member VisitUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  default __.VisitUpcast parents context expr typeSig range =
    SynExpr.initUpcast expr typeSig range

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitDowncast parents context expr typeName range =
    this.VisitDowncast parents context (expr |> (this.VisitSynExpr parents context)) typeName range

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  abstract member VisitDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  default __.VisitDowncast parents context expr typeName range =
    SynExpr.initDowncast expr typeName range

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitInferredUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitInferredUpcast parents context expr range =
    this.VisitInferredUpcast parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  abstract member VisitInferredUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  default __.VisitInferredUpcast parents context expr range =
    SynExpr.initInferredUpcast expr range

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitInferredDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitInferredDowncast parents context expr range =
    this.VisitInferredDowncast parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  abstract member VisitInferredDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  default __.VisitInferredDowncast parents context expr range =
    SynExpr.initInferredDowncast expr range

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitNull: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitNull parents context range =
    this.VisitNull parents context range

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  abstract member VisitNull: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  default __.VisitNull parents context range =
    SynExpr.initNull range

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitAddressOf: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitAddressOf parents context item1 item2 item3 range =
    this.VisitAddressOf parents context item1 (item2 |> (this.VisitSynExpr parents context)) item3 range

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  abstract member VisitAddressOf: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  default __.VisitAddressOf parents context item1 item2 item3 range =
    SynExpr.initAddressOf item1 item2 item3 range

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitTraitCall: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitTraitCall parents context item1 item2 item3 range =
    this.VisitTraitCall parents context item1 item2 (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  abstract member VisitTraitCall: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  default __.VisitTraitCall parents context item1 item2 item3 range =
    SynExpr.initTraitCall item1 item2 item3 range

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitJoinIn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitJoinIn parents context item1 inPos item3 range =
    this.VisitJoinIn parents context (item1 |> (this.VisitSynExpr parents context)) inPos (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  abstract member VisitJoinIn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  default __.VisitJoinIn parents context item1 inPos item3 range =
    SynExpr.initJoinIn item1 inPos item3 range

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitImplicitZero: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitImplicitZero parents context range =
    this.VisitImplicitZero parents context range

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  abstract member VisitImplicitZero: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  default __.VisitImplicitZero parents context range =
    SynExpr.initImplicitZero range

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitYieldOrReturn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitYieldOrReturn parents context item1 expr range =
    this.VisitYieldOrReturn parents context item1 (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  abstract member VisitYieldOrReturn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  default __.VisitYieldOrReturn parents context item1 expr range =
    SynExpr.initYieldOrReturn item1 expr range

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitYieldOrReturnFrom: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitYieldOrReturnFrom parents context item1 expr range =
    this.VisitYieldOrReturnFrom parents context item1 (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  abstract member VisitYieldOrReturnFrom: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  default __.VisitYieldOrReturnFrom parents context item1 expr range =
    SynExpr.initYieldOrReturnFrom item1 expr range

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitLetOrUseBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    this.VisitLetOrUseBang parents context spBind isUse isFromSource pattern (rhsExpr |> (this.VisitSynExpr parents context)) (bodyExpr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  abstract member VisitLetOrUseBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  default __.VisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    SynExpr.initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitDoBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitDoBang parents context expr range =
    this.VisitDoBang parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  abstract member VisitDoBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  default __.VisitDoBang parents context expr range =
    SynExpr.initDoBang expr range

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitLibraryOnlyILAssembly: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    this.VisitLibraryOnlyILAssembly parents context item1 item2 (item3 |> (List.map (this.VisitSynExpr parents context))) item4 range

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  abstract member VisitLibraryOnlyILAssembly: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  default __.VisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    SynExpr.initLibraryOnlyILAssembly item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitLibraryOnlyStaticOptimization: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    this.VisitLibraryOnlyStaticOptimization parents context item1 (item2 |> (this.VisitSynExpr parents context)) (item3 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  abstract member VisitLibraryOnlyStaticOptimization: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  default __.VisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    SynExpr.initLibraryOnlyStaticOptimization item1 item2 item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    this.VisitLibraryOnlyUnionCaseFieldGet parents context (item1 |> (this.VisitSynExpr parents context)) longId item3 range

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    SynExpr.initLibraryOnlyUnionCaseFieldGet item1 longId item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    this.VisitLibraryOnlyUnionCaseFieldSet parents context (item1 |> (this.VisitSynExpr parents context)) longId item3 (item4 |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    SynExpr.initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitArbitraryAfterError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitArbitraryAfterError parents context debugStr range =
    this.VisitArbitraryAfterError parents context debugStr range

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  abstract member VisitArbitraryAfterError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  default __.VisitArbitraryAfterError parents context debugStr range =
    SynExpr.initArbitraryAfterError debugStr range

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitFromParseError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitFromParseError parents context expr range =
    this.VisitFromParseError parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  abstract member VisitFromParseError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  default __.VisitFromParseError parents context expr range =
    SynExpr.initFromParseError expr range

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitDiscardAfterMissingQualificationAfterDot: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    this.VisitDiscardAfterMissingQualificationAfterDot parents context (expr |> (this.VisitSynExpr parents context)) range

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    SynExpr.initDiscardAfterMissingQualificationAfterDot expr range

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitFixed: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitFixed parents context item1 item2 =
    this.VisitFixed parents context (item1 |> (this.VisitSynExpr parents context)) item2

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  abstract member VisitFixed: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  default __.VisitFixed parents context item1 item2 =
    SynExpr.initFixed item1 item2


  abstract member VisitSynExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <param name="expr">Target expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitSynExpr parents context expr =
    let currentParents = expr :: parents
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      this.BeforeVisitParen currentParents context expr leftParenRange rightParenRange range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.BeforeVisitQuote currentParents context operator isRaw quotedSynExpr isFromQueryExpression range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.BeforeVisitConst currentParents context constant range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.BeforeVisitTyped currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.BeforeVisitTuple currentParents context exprs commaRanges range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.BeforeVisitArrayOrList currentParents context isList exprs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.BeforeVisitRecord currentParents context baseInfo copyInfo recordFields range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.BeforeVisitNew currentParents context isProtected typeName expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.BeforeVisitObjExpr currentParents context objType argOpt bindings extraImpls newPos range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.BeforeVisitWhile currentParents context spWhile whileBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.BeforeVisitFor currentParents context spFor id idBody item4 toBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.BeforeVisitForEach currentParents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.BeforeVisitArrayOrListOfSeqExpr currentParents context isList elements range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.BeforeVisitCompExpr currentParents context isArrayOrList isNotNakedRefCell expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.BeforeVisitLambda currentParents context fromMethod inLambdaSeq args body range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.BeforeVisitMatchLambda currentParents context item1 item2 clauses spBind range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.BeforeVisitMatch currentParents context spBind matchExpr clauses isCexprExceptionMatch range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.BeforeVisitDo currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.BeforeVisitAssert currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.BeforeVisitApp currentParents context exprAtomicFlag isInfix funcExpr argExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.BeforeVisitTypeApp currentParents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.BeforeVisitLetOrUse currentParents context isRecursive isUse bindings exprBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.BeforeVisitTryWith currentParents context tryExpr item2 item3 item4 range spTry spWith
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.BeforeVisitTryFinally currentParents context tryExpr finallyExpr range spTry spFinally
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.BeforeVisitLazy currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.BeforeVisitSequential currentParents context spSeq isTrueSeq expr1 expr2 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.BeforeVisitIfThenElse currentParents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.BeforeVisitIdent currentParents context item
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.BeforeVisitLongIdent currentParents context isOptional longIdent altNameRefCell range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.BeforeVisitLongIdentSet currentParents context dotId expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.BeforeVisitDotGet currentParents context expr rangeOfDot dotId range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.BeforeVisitDotSet currentParents context expr dotId exprValue range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.BeforeVisitDotIndexedGet currentParents context expr indexExprs item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.BeforeVisitDotIndexedSet currentParents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.BeforeVisitNamedIndexedPropertySet currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.BeforeVisitDotNamedIndexedPropertySet currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.BeforeVisitTypeTest currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.BeforeVisitUpcast currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.BeforeVisitDowncast currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.BeforeVisitInferredUpcast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.BeforeVisitInferredDowncast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.BeforeVisitNull currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.BeforeVisitAddressOf currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.BeforeVisitTraitCall currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.BeforeVisitJoinIn currentParents context item1 inPos item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.BeforeVisitImplicitZero currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.BeforeVisitYieldOrReturn currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.BeforeVisitYieldOrReturnFrom currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.BeforeVisitLetOrUseBang currentParents context spBind isUse isFromSource pattern rhsExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.BeforeVisitDoBang currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyILAssembly currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.BeforeVisitLibraryOnlyStaticOptimization currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldGet currentParents context item1 longId item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldSet currentParents context item1 longId item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.BeforeVisitArbitraryAfterError currentParents context debugStr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.BeforeVisitFromParseError currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.BeforeVisitDiscardAfterMissingQualificationAfterDot currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.BeforeVisitFixed currentParents context item1 item2

