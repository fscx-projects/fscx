//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Mon, 01 Aug 2016 07:45:50 GMT
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
  abstract member BeforeVisitParen: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitParen expr leftParenRange rightParenRange range parents context =
    this.VisitParen (expr |> (fun expr -> this.VisitSynExpr expr parents context)) leftParenRange rightParenRange range parents context

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  abstract member VisitParen: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  default __.VisitParen expr leftParenRange rightParenRange range parents context =
    SynExpr.initParen expr leftParenRange rightParenRange range

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitQuote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range parents context =
    this.VisitQuote (operator |> (fun expr -> this.VisitSynExpr expr parents context)) isRaw (quotedSynExpr |> (fun expr -> this.VisitSynExpr expr parents context)) isFromQueryExpression range parents context

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  abstract member VisitQuote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  default __.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range parents context =
    SynExpr.initQuote operator isRaw quotedSynExpr isFromQueryExpression range

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitConst constant range parents context =
    this.VisitConst constant range parents context

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  abstract member VisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  default __.VisitConst constant range parents context =
    SynExpr.initConst constant range

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitTyped: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitTyped expr typeSig range parents context =
    this.VisitTyped (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeSig range parents context

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  abstract member VisitTyped: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  default __.VisitTyped expr typeSig range parents context =
    SynExpr.initTyped expr typeSig range

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitTuple: exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitTuple exprs commaRanges range parents context =
    this.VisitTuple (exprs |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) commaRanges range parents context

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  abstract member VisitTuple: exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  default __.VisitTuple exprs commaRanges range parents context =
    SynExpr.initTuple exprs commaRanges range

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitArrayOrList: isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitArrayOrList isList exprs range parents context =
    this.VisitArrayOrList isList (exprs |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) range parents context

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  abstract member VisitArrayOrList: isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  default __.VisitArrayOrList isList exprs range parents context =
    SynExpr.initArrayOrList isList exprs range

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitRecord baseInfo copyInfo recordFields range parents context =
    this.VisitRecord baseInfo copyInfo recordFields range parents context

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  abstract member VisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  default __.VisitRecord baseInfo copyInfo recordFields range parents context =
    SynExpr.initRecord baseInfo copyInfo recordFields range

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitNew: isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitNew isProtected typeName expr range parents context =
    this.VisitNew isProtected typeName (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  abstract member VisitNew: isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  default __.VisitNew isProtected typeName expr range parents context =
    SynExpr.initNew isProtected typeName expr range

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range parents context =
    this.VisitObjExpr objType argOpt bindings extraImpls newPos range parents context

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  abstract member VisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  default __.VisitObjExpr objType argOpt bindings extraImpls newPos range parents context =
    SynExpr.initObjExpr objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitWhile spWhile whileBody doBody range parents context =
    this.VisitWhile spWhile (whileBody |> (fun expr -> this.VisitSynExpr expr parents context)) (doBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  abstract member VisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  default __.VisitWhile spWhile whileBody doBody range parents context =
    SynExpr.initWhile spWhile whileBody doBody range

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitFor spFor id idBody item4 toBody doBody range parents context =
    this.VisitFor spFor id (idBody |> (fun expr -> this.VisitSynExpr expr parents context)) item4 (toBody |> (fun expr -> this.VisitSynExpr expr parents context)) (doBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  abstract member VisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  default __.VisitFor spFor id idBody item4 toBody doBody range parents context =
    SynExpr.initFor spFor id idBody item4 toBody doBody range

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range parents context =
    this.VisitForEach spFor seqExprOnly isFromSource pattern (enumExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  abstract member VisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  default __.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range parents context =
    SynExpr.initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitArrayOrListOfSeqExpr: isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitArrayOrListOfSeqExpr isList elements range parents context =
    this.VisitArrayOrListOfSeqExpr isList (elements |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  abstract member VisitArrayOrListOfSeqExpr: isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  default __.VisitArrayOrListOfSeqExpr isList elements range parents context =
    SynExpr.initArrayOrListOfSeqExpr isList elements range

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitCompExpr: isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range parents context =
    this.VisitCompExpr isArrayOrList isNotNakedRefCell (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  abstract member VisitCompExpr: isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  default __.VisitCompExpr isArrayOrList isNotNakedRefCell expr range parents context =
    SynExpr.initCompExpr isArrayOrList isNotNakedRefCell expr range

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitLambda: fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitLambda fromMethod inLambdaSeq args body range parents context =
    this.VisitLambda fromMethod inLambdaSeq args (body |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  abstract member VisitLambda: fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  default __.VisitLambda fromMethod inLambdaSeq args body range parents context =
    SynExpr.initLambda fromMethod inLambdaSeq args body range

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitMatchLambda: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitMatchLambda item1 item2 clauses spBind range parents context =
    this.VisitMatchLambda item1 item2 clauses spBind range parents context

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  abstract member VisitMatchLambda: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  default __.VisitMatchLambda item1 item2 clauses spBind range parents context =
    SynExpr.initMatchLambda item1 item2 clauses spBind range

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range parents context =
    this.VisitMatch spBind (matchExpr |> (fun expr -> this.VisitSynExpr expr parents context)) clauses isCexprExceptionMatch range parents context

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  abstract member VisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  default __.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range parents context =
    SynExpr.initMatch spBind matchExpr clauses isCexprExceptionMatch range

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitDo: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitDo expr range parents context =
    this.VisitDo (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  abstract member VisitDo: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  default __.VisitDo expr range parents context =
    SynExpr.initDo expr range

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitAssert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitAssert expr range parents context =
    this.VisitAssert (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  abstract member VisitAssert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  default __.VisitAssert expr range parents context =
    SynExpr.initAssert expr range

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range parents context =
    this.VisitApp exprAtomicFlag isInfix (funcExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (argExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  abstract member VisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  default __.VisitApp exprAtomicFlag isInfix funcExpr argExpr range parents context =
    SynExpr.initApp exprAtomicFlag isInfix funcExpr argExpr range

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitTypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context =
    this.VisitTypeApp (expr |> (fun expr -> this.VisitSynExpr expr parents context)) leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  abstract member VisitTypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  default __.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context =
    SynExpr.initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitLetOrUse: isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range parents context =
    this.VisitLetOrUse isRecursive isUse bindings (exprBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  abstract member VisitLetOrUse: isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  default __.VisitLetOrUse isRecursive isUse bindings exprBody range parents context =
    SynExpr.initLetOrUse isRecursive isUse bindings exprBody range

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitTryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith parents context =
    this.VisitTryWith (tryExpr |> (fun expr -> this.VisitSynExpr expr parents context)) item2 item3 item4 range spTry spWith parents context

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  abstract member VisitTryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  default __.VisitTryWith tryExpr item2 item3 item4 range spTry spWith parents context =
    SynExpr.initTryWith tryExpr item2 item3 item4 range spTry spWith

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitTryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally parents context =
    this.VisitTryFinally (tryExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (finallyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range spTry spFinally parents context

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  abstract member VisitTryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  default __.VisitTryFinally tryExpr finallyExpr range spTry spFinally parents context =
    SynExpr.initTryFinally tryExpr finallyExpr range spTry spFinally

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitLazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitLazy expr range parents context =
    this.VisitLazy (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  abstract member VisitLazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  default __.VisitLazy expr range parents context =
    SynExpr.initLazy expr range

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range parents context =
    this.VisitSequential spSeq isTrueSeq (expr1 |> (fun expr -> this.VisitSynExpr expr parents context)) (expr2 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  abstract member VisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  default __.VisitSequential spSeq isTrueSeq expr1 expr2 range parents context =
    SynExpr.initSequential spSeq isTrueSeq expr1 expr2 range

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitIfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range parents context =
    this.VisitIfThenElse (exprGuard |> (fun expr -> this.VisitSynExpr expr parents context)) (exprThen |> (fun expr -> this.VisitSynExpr expr parents context)) (optionalExprElse |> (Option.map (fun expr -> this.VisitSynExpr expr parents context))) spIfToThen isFromErrorRecovery ifToThen range parents context

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  abstract member VisitIfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  default __.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range parents context =
    SynExpr.initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitIdent item parents context =
    this.VisitIdent item parents context

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  abstract member VisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  default __.VisitIdent item parents context =
    SynExpr.initIdent item

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitLongIdent: isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range parents context =
    this.VisitLongIdent isOptional longIdent altNameRefCell range parents context

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  abstract member VisitLongIdent: isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  default __.VisitLongIdent isOptional longIdent altNameRefCell range parents context =
    SynExpr.initLongIdent isOptional longIdent altNameRefCell range

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitLongIdentSet dotId expr range parents context =
    this.VisitLongIdentSet dotId (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  abstract member VisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  default __.VisitLongIdentSet dotId expr range parents context =
    SynExpr.initLongIdentSet dotId expr range

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitDotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitDotGet expr rangeOfDot dotId range parents context =
    this.VisitDotGet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) rangeOfDot dotId range parents context

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  abstract member VisitDotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  default __.VisitDotGet expr rangeOfDot dotId range parents context =
    SynExpr.initDotGet expr rangeOfDot dotId range

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitDotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitDotSet expr dotId exprValue range parents context =
    this.VisitDotSet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) dotId (exprValue |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  abstract member VisitDotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  default __.VisitDotSet expr dotId exprValue range parents context =
    SynExpr.initDotSet expr dotId exprValue range

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitDotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitDotIndexedGet expr indexExprs item3 range parents context =
    this.VisitDotIndexedGet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) indexExprs item3 range parents context

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  abstract member VisitDotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  default __.VisitDotIndexedGet expr indexExprs item3 range parents context =
    SynExpr.initDotIndexedGet expr indexExprs item3 range

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitDotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range parents context =
    this.VisitDotIndexedSet (objectExpr |> (fun expr -> this.VisitSynExpr expr parents context)) indexExprs (valueExpr |> (fun expr -> this.VisitSynExpr expr parents context)) rangeOfLeftOfSet rangeOfDot range parents context

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  abstract member VisitDotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  default __.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range parents context =
    SynExpr.initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range parents context =
    this.VisitNamedIndexedPropertySet item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  abstract member VisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  default __.VisitNamedIndexedPropertySet item1 item2 item3 range parents context =
    SynExpr.initNamedIndexedPropertySet item1 item2 item3 range

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitDotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range parents context =
    this.VisitDotNamedIndexedPropertySet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) item2 (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) (item4 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  abstract member VisitDotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  default __.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range parents context =
    SynExpr.initDotNamedIndexedPropertySet item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitTypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitTypeTest expr typeName range parents context =
    this.VisitTypeTest (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeName range parents context

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  abstract member VisitTypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  default __.VisitTypeTest expr typeName range parents context =
    SynExpr.initTypeTest expr typeName range

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitUpcast expr typeSig range parents context =
    this.VisitUpcast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeSig range parents context

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  abstract member VisitUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  default __.VisitUpcast expr typeSig range parents context =
    SynExpr.initUpcast expr typeSig range

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitDowncast expr typeName range parents context =
    this.VisitDowncast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeName range parents context

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  abstract member VisitDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  default __.VisitDowncast expr typeName range parents context =
    SynExpr.initDowncast expr typeName range

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitInferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitInferredUpcast expr range parents context =
    this.VisitInferredUpcast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  abstract member VisitInferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  default __.VisitInferredUpcast expr range parents context =
    SynExpr.initInferredUpcast expr range

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitInferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitInferredDowncast expr range parents context =
    this.VisitInferredDowncast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  abstract member VisitInferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  default __.VisitInferredDowncast expr range parents context =
    SynExpr.initInferredDowncast expr range

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitNull: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitNull range parents context =
    this.VisitNull range parents context

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  abstract member VisitNull: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  default __.VisitNull range parents context =
    SynExpr.initNull range

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitAddressOf: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitAddressOf item1 item2 item3 range parents context =
    this.VisitAddressOf item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) item3 range parents context

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  abstract member VisitAddressOf: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  default __.VisitAddressOf item1 item2 item3 range parents context =
    SynExpr.initAddressOf item1 item2 item3 range

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitTraitCall item1 item2 item3 range parents context =
    this.VisitTraitCall item1 item2 (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  abstract member VisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  default __.VisitTraitCall item1 item2 item3 range parents context =
    SynExpr.initTraitCall item1 item2 item3 range

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitJoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitJoinIn item1 inPos item3 range parents context =
    this.VisitJoinIn (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) inPos (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  abstract member VisitJoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  default __.VisitJoinIn item1 inPos item3 range parents context =
    SynExpr.initJoinIn item1 inPos item3 range

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitImplicitZero: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitImplicitZero range parents context =
    this.VisitImplicitZero range parents context

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  abstract member VisitImplicitZero: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  default __.VisitImplicitZero range parents context =
    SynExpr.initImplicitZero range

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitYieldOrReturn: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitYieldOrReturn item1 expr range parents context =
    this.VisitYieldOrReturn item1 (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  abstract member VisitYieldOrReturn: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  default __.VisitYieldOrReturn item1 expr range parents context =
    SynExpr.initYieldOrReturn item1 expr range

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitYieldOrReturnFrom: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitYieldOrReturnFrom item1 expr range parents context =
    this.VisitYieldOrReturnFrom item1 (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  abstract member VisitYieldOrReturnFrom: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  default __.VisitYieldOrReturnFrom item1 expr range parents context =
    SynExpr.initYieldOrReturnFrom item1 expr range

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range parents context =
    this.VisitLetOrUseBang spBind isUse isFromSource pattern (rhsExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  abstract member VisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  default __.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range parents context =
    SynExpr.initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitDoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitDoBang expr range parents context =
    this.VisitDoBang (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  abstract member VisitDoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  default __.VisitDoBang expr range parents context =
    SynExpr.initDoBang expr range

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range parents context =
    this.VisitLibraryOnlyILAssembly item1 item2 (item3 |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) item4 range parents context

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  abstract member VisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  default __.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range parents context =
    SynExpr.initLibraryOnlyILAssembly item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range parents context =
    this.VisitLibraryOnlyStaticOptimization item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  abstract member VisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  default __.VisitLibraryOnlyStaticOptimization item1 item2 item3 range parents context =
    SynExpr.initLibraryOnlyStaticOptimization item1 item2 item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range parents context =
    this.VisitLibraryOnlyUnionCaseFieldGet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) longId item3 range parents context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range parents context =
    SynExpr.initLibraryOnlyUnionCaseFieldGet item1 longId item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range parents context =
    this.VisitLibraryOnlyUnionCaseFieldSet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) longId item3 (item4 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range parents context =
    SynExpr.initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitArbitraryAfterError: debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitArbitraryAfterError debugStr range parents context =
    this.VisitArbitraryAfterError debugStr range parents context

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  abstract member VisitArbitraryAfterError: debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  default __.VisitArbitraryAfterError debugStr range parents context =
    SynExpr.initArbitraryAfterError debugStr range

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitFromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitFromParseError expr range parents context =
    this.VisitFromParseError (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  abstract member VisitFromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  default __.VisitFromParseError expr range parents context =
    SynExpr.initFromParseError expr range

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitDiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range parents context =
    this.VisitDiscardAfterMissingQualificationAfterDot (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitDiscardAfterMissingQualificationAfterDot expr range parents context =
    SynExpr.initDiscardAfterMissingQualificationAfterDot expr range

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitFixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitFixed item1 item2 parents context =
    this.VisitFixed (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) item2 parents context

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  abstract member VisitFixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  default __.VisitFixed item1 item2 parents context =
    SynExpr.initFixed item1 item2


  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr parents context =
    let currentParents = expr :: parents
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      this.BeforeVisitParen expr leftParenRange rightParenRange range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.BeforeVisitConst constant range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.BeforeVisitTyped expr typeSig range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.BeforeVisitTuple exprs commaRanges range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.BeforeVisitArrayOrList isList exprs range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.BeforeVisitRecord baseInfo copyInfo recordFields range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.BeforeVisitNew isProtected typeName expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.BeforeVisitWhile spWhile whileBody doBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.BeforeVisitFor spFor id idBody item4 toBody doBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.BeforeVisitArrayOrListOfSeqExpr isList elements range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.BeforeVisitLambda fromMethod inLambdaSeq args body range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.BeforeVisitMatchLambda item1 item2 clauses spBind range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.BeforeVisitDo expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.BeforeVisitAssert expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.BeforeVisitLazy expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.BeforeVisitIdent item currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.BeforeVisitLongIdentSet dotId expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.BeforeVisitDotGet expr rangeOfDot dotId range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.BeforeVisitDotSet expr dotId exprValue range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.BeforeVisitDotIndexedGet expr indexExprs item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.BeforeVisitTypeTest expr typeName range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.BeforeVisitUpcast expr typeSig range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.BeforeVisitDowncast expr typeName range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.BeforeVisitInferredUpcast expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.BeforeVisitInferredDowncast expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.BeforeVisitNull range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.BeforeVisitAddressOf item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.BeforeVisitTraitCall item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.BeforeVisitJoinIn item1 inPos item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.BeforeVisitImplicitZero range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.BeforeVisitYieldOrReturn item1 expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.BeforeVisitYieldOrReturnFrom item1 expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.BeforeVisitDoBang expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.BeforeVisitArbitraryAfterError debugStr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.BeforeVisitFromParseError expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.BeforeVisitFixed item1 item2 currentParents context


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
  abstract member BeforeVisitParen: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitParen".</remarks>
  default this.BeforeVisitParen expr leftParenRange rightParenRange range parents context =
    this.VisitParen (expr |> (fun expr -> this.VisitSynExpr expr parents context)) leftParenRange rightParenRange range parents context

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  abstract member VisitParen: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initParen".</remarks>
  default __.VisitParen expr leftParenRange rightParenRange range parents context =
    SynExpr.initParen expr leftParenRange rightParenRange range

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  abstract member BeforeVisitQuote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitQuote".</remarks>
  default this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range parents context =
    this.VisitQuote (operator |> (fun expr -> this.VisitSynExpr expr parents context)) isRaw (quotedSynExpr |> (fun expr -> this.VisitSynExpr expr parents context)) isFromQueryExpression range parents context

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  abstract member VisitQuote: operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initQuote".</remarks>
  default __.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range parents context =
    SynExpr.initQuote operator isRaw quotedSynExpr isFromQueryExpression range

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  abstract member BeforeVisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitConst".</remarks>
  default this.BeforeVisitConst constant range parents context =
    this.VisitConst constant range parents context

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  abstract member VisitConst: constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initConst".</remarks>
  default __.VisitConst constant range parents context =
    SynExpr.initConst constant range

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  abstract member BeforeVisitTyped: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTyped".</remarks>
  default this.BeforeVisitTyped expr typeSig range parents context =
    this.VisitTyped (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeSig range parents context

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  abstract member VisitTyped: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTyped".</remarks>
  default __.VisitTyped expr typeSig range parents context =
    SynExpr.initTyped expr typeSig range

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  abstract member BeforeVisitTuple: exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTuple".</remarks>
  default this.BeforeVisitTuple exprs commaRanges range parents context =
    this.VisitTuple (exprs |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) commaRanges range parents context

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  abstract member VisitTuple: exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTuple".</remarks>
  default __.VisitTuple exprs commaRanges range parents context =
    SynExpr.initTuple exprs commaRanges range

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  abstract member BeforeVisitArrayOrList: isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrList".</remarks>
  default this.BeforeVisitArrayOrList isList exprs range parents context =
    this.VisitArrayOrList isList (exprs |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) range parents context

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  abstract member VisitArrayOrList: isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrList".</remarks>
  default __.VisitArrayOrList isList exprs range parents context =
    SynExpr.initArrayOrList isList exprs range

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  abstract member BeforeVisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitRecord".</remarks>
  default this.BeforeVisitRecord baseInfo copyInfo recordFields range parents context =
    this.VisitRecord baseInfo copyInfo recordFields range parents context

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  abstract member VisitRecord: baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initRecord".</remarks>
  default __.VisitRecord baseInfo copyInfo recordFields range parents context =
    SynExpr.initRecord baseInfo copyInfo recordFields range

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  abstract member BeforeVisitNew: isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNew".</remarks>
  default this.BeforeVisitNew isProtected typeName expr range parents context =
    this.VisitNew isProtected typeName (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  abstract member VisitNew: isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNew".</remarks>
  default __.VisitNew isProtected typeName expr range parents context =
    SynExpr.initNew isProtected typeName expr range

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  abstract member BeforeVisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitObjExpr".</remarks>
  default this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range parents context =
    this.VisitObjExpr objType argOpt bindings extraImpls newPos range parents context

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  abstract member VisitObjExpr: objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initObjExpr".</remarks>
  default __.VisitObjExpr objType argOpt bindings extraImpls newPos range parents context =
    SynExpr.initObjExpr objType argOpt bindings extraImpls newPos range

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  abstract member BeforeVisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitWhile".</remarks>
  default this.BeforeVisitWhile spWhile whileBody doBody range parents context =
    this.VisitWhile spWhile (whileBody |> (fun expr -> this.VisitSynExpr expr parents context)) (doBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  abstract member VisitWhile: spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initWhile".</remarks>
  default __.VisitWhile spWhile whileBody doBody range parents context =
    SynExpr.initWhile spWhile whileBody doBody range

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  abstract member BeforeVisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFor".</remarks>
  default this.BeforeVisitFor spFor id idBody item4 toBody doBody range parents context =
    this.VisitFor spFor id (idBody |> (fun expr -> this.VisitSynExpr expr parents context)) item4 (toBody |> (fun expr -> this.VisitSynExpr expr parents context)) (doBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  abstract member VisitFor: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFor".</remarks>
  default __.VisitFor spFor id idBody item4 toBody doBody range parents context =
    SynExpr.initFor spFor id idBody item4 toBody doBody range

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  abstract member BeforeVisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitForEach".</remarks>
  default this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range parents context =
    this.VisitForEach spFor seqExprOnly isFromSource pattern (enumExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  abstract member VisitForEach: spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initForEach".</remarks>
  default __.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range parents context =
    SynExpr.initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  abstract member BeforeVisitArrayOrListOfSeqExpr: isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArrayOrListOfSeqExpr".</remarks>
  default this.BeforeVisitArrayOrListOfSeqExpr isList elements range parents context =
    this.VisitArrayOrListOfSeqExpr isList (elements |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  abstract member VisitArrayOrListOfSeqExpr: isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArrayOrListOfSeqExpr".</remarks>
  default __.VisitArrayOrListOfSeqExpr isList elements range parents context =
    SynExpr.initArrayOrListOfSeqExpr isList elements range

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  abstract member BeforeVisitCompExpr: isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitCompExpr".</remarks>
  default this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range parents context =
    this.VisitCompExpr isArrayOrList isNotNakedRefCell (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  abstract member VisitCompExpr: isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initCompExpr".</remarks>
  default __.VisitCompExpr isArrayOrList isNotNakedRefCell expr range parents context =
    SynExpr.initCompExpr isArrayOrList isNotNakedRefCell expr range

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  abstract member BeforeVisitLambda: fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLambda".</remarks>
  default this.BeforeVisitLambda fromMethod inLambdaSeq args body range parents context =
    this.VisitLambda fromMethod inLambdaSeq args (body |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  abstract member VisitLambda: fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLambda".</remarks>
  default __.VisitLambda fromMethod inLambdaSeq args body range parents context =
    SynExpr.initLambda fromMethod inLambdaSeq args body range

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  abstract member BeforeVisitMatchLambda: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatchLambda".</remarks>
  default this.BeforeVisitMatchLambda item1 item2 clauses spBind range parents context =
    this.VisitMatchLambda item1 item2 clauses spBind range parents context

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  abstract member VisitMatchLambda: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatchLambda".</remarks>
  default __.VisitMatchLambda item1 item2 clauses spBind range parents context =
    SynExpr.initMatchLambda item1 item2 clauses spBind range

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  abstract member BeforeVisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitMatch".</remarks>
  default this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range parents context =
    this.VisitMatch spBind (matchExpr |> (fun expr -> this.VisitSynExpr expr parents context)) clauses isCexprExceptionMatch range parents context

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  abstract member VisitMatch: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initMatch".</remarks>
  default __.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range parents context =
    SynExpr.initMatch spBind matchExpr clauses isCexprExceptionMatch range

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  abstract member BeforeVisitDo: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDo".</remarks>
  default this.BeforeVisitDo expr range parents context =
    this.VisitDo (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  abstract member VisitDo: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDo".</remarks>
  default __.VisitDo expr range parents context =
    SynExpr.initDo expr range

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  abstract member BeforeVisitAssert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAssert".</remarks>
  default this.BeforeVisitAssert expr range parents context =
    this.VisitAssert (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  abstract member VisitAssert: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAssert".</remarks>
  default __.VisitAssert expr range parents context =
    SynExpr.initAssert expr range

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  abstract member BeforeVisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitApp".</remarks>
  default this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range parents context =
    this.VisitApp exprAtomicFlag isInfix (funcExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (argExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  abstract member VisitApp: exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initApp".</remarks>
  default __.VisitApp exprAtomicFlag isInfix funcExpr argExpr range parents context =
    SynExpr.initApp exprAtomicFlag isInfix funcExpr argExpr range

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  abstract member BeforeVisitTypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeApp".</remarks>
  default this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context =
    this.VisitTypeApp (expr |> (fun expr -> this.VisitSynExpr expr parents context)) leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  abstract member VisitTypeApp: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeApp".</remarks>
  default __.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range parents context =
    SynExpr.initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  abstract member BeforeVisitLetOrUse: isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUse".</remarks>
  default this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range parents context =
    this.VisitLetOrUse isRecursive isUse bindings (exprBody |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  abstract member VisitLetOrUse: isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUse".</remarks>
  default __.VisitLetOrUse isRecursive isUse bindings exprBody range parents context =
    SynExpr.initLetOrUse isRecursive isUse bindings exprBody range

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  abstract member BeforeVisitTryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryWith".</remarks>
  default this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith parents context =
    this.VisitTryWith (tryExpr |> (fun expr -> this.VisitSynExpr expr parents context)) item2 item3 item4 range spTry spWith parents context

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  abstract member VisitTryWith: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryWith".</remarks>
  default __.VisitTryWith tryExpr item2 item3 item4 range spTry spWith parents context =
    SynExpr.initTryWith tryExpr item2 item3 item4 range spTry spWith

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  abstract member BeforeVisitTryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTryFinally".</remarks>
  default this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally parents context =
    this.VisitTryFinally (tryExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (finallyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range spTry spFinally parents context

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  abstract member VisitTryFinally: tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTryFinally".</remarks>
  default __.VisitTryFinally tryExpr finallyExpr range spTry spFinally parents context =
    SynExpr.initTryFinally tryExpr finallyExpr range spTry spFinally

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  abstract member BeforeVisitLazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLazy".</remarks>
  default this.BeforeVisitLazy expr range parents context =
    this.VisitLazy (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  abstract member VisitLazy: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLazy".</remarks>
  default __.VisitLazy expr range parents context =
    SynExpr.initLazy expr range

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  abstract member BeforeVisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitSequential".</remarks>
  default this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range parents context =
    this.VisitSequential spSeq isTrueSeq (expr1 |> (fun expr -> this.VisitSynExpr expr parents context)) (expr2 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  abstract member VisitSequential: spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initSequential".</remarks>
  default __.VisitSequential spSeq isTrueSeq expr1 expr2 range parents context =
    SynExpr.initSequential spSeq isTrueSeq expr1 expr2 range

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  abstract member BeforeVisitIfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIfThenElse".</remarks>
  default this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range parents context =
    this.VisitIfThenElse (exprGuard |> (fun expr -> this.VisitSynExpr expr parents context)) (exprThen |> (fun expr -> this.VisitSynExpr expr parents context)) (optionalExprElse |> (Option.map (fun expr -> this.VisitSynExpr expr parents context))) spIfToThen isFromErrorRecovery ifToThen range parents context

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  abstract member VisitIfThenElse: exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIfThenElse".</remarks>
  default __.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range parents context =
    SynExpr.initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  abstract member BeforeVisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitIdent".</remarks>
  default this.BeforeVisitIdent item parents context =
    this.VisitIdent item parents context

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  abstract member VisitIdent: item: Microsoft.FSharp.Compiler.Ast.Ident -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initIdent".</remarks>
  default __.VisitIdent item parents context =
    SynExpr.initIdent item

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  abstract member BeforeVisitLongIdent: isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdent".</remarks>
  default this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range parents context =
    this.VisitLongIdent isOptional longIdent altNameRefCell range parents context

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  abstract member VisitLongIdent: isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdent".</remarks>
  default __.VisitLongIdent isOptional longIdent altNameRefCell range parents context =
    SynExpr.initLongIdent isOptional longIdent altNameRefCell range

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  abstract member BeforeVisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLongIdentSet".</remarks>
  default this.BeforeVisitLongIdentSet dotId expr range parents context =
    this.VisitLongIdentSet dotId (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  abstract member VisitLongIdentSet: dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLongIdentSet".</remarks>
  default __.VisitLongIdentSet dotId expr range parents context =
    SynExpr.initLongIdentSet dotId expr range

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  abstract member BeforeVisitDotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotGet".</remarks>
  default this.BeforeVisitDotGet expr rangeOfDot dotId range parents context =
    this.VisitDotGet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) rangeOfDot dotId range parents context

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  abstract member VisitDotGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotGet".</remarks>
  default __.VisitDotGet expr rangeOfDot dotId range parents context =
    SynExpr.initDotGet expr rangeOfDot dotId range

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  abstract member BeforeVisitDotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotSet".</remarks>
  default this.BeforeVisitDotSet expr dotId exprValue range parents context =
    this.VisitDotSet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) dotId (exprValue |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  abstract member VisitDotSet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotSet".</remarks>
  default __.VisitDotSet expr dotId exprValue range parents context =
    SynExpr.initDotSet expr dotId exprValue range

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  abstract member BeforeVisitDotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedGet".</remarks>
  default this.BeforeVisitDotIndexedGet expr indexExprs item3 range parents context =
    this.VisitDotIndexedGet (expr |> (fun expr -> this.VisitSynExpr expr parents context)) indexExprs item3 range parents context

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  abstract member VisitDotIndexedGet: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedGet".</remarks>
  default __.VisitDotIndexedGet expr indexExprs item3 range parents context =
    SynExpr.initDotIndexedGet expr indexExprs item3 range

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  abstract member BeforeVisitDotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotIndexedSet".</remarks>
  default this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range parents context =
    this.VisitDotIndexedSet (objectExpr |> (fun expr -> this.VisitSynExpr expr parents context)) indexExprs (valueExpr |> (fun expr -> this.VisitSynExpr expr parents context)) rangeOfLeftOfSet rangeOfDot range parents context

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  abstract member VisitDotIndexedSet: objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotIndexedSet".</remarks>
  default __.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range parents context =
    SynExpr.initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range parents context =
    this.VisitNamedIndexedPropertySet item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  abstract member VisitNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNamedIndexedPropertySet".</remarks>
  default __.VisitNamedIndexedPropertySet item1 item2 item3 range parents context =
    SynExpr.initNamedIndexedPropertySet item1 item2 item3 range

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  abstract member BeforeVisitDotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDotNamedIndexedPropertySet".</remarks>
  default this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range parents context =
    this.VisitDotNamedIndexedPropertySet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) item2 (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) (item4 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  abstract member VisitDotNamedIndexedPropertySet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDotNamedIndexedPropertySet".</remarks>
  default __.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range parents context =
    SynExpr.initDotNamedIndexedPropertySet item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  abstract member BeforeVisitTypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTypeTest".</remarks>
  default this.BeforeVisitTypeTest expr typeName range parents context =
    this.VisitTypeTest (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeName range parents context

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  abstract member VisitTypeTest: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTypeTest".</remarks>
  default __.VisitTypeTest expr typeName range parents context =
    SynExpr.initTypeTest expr typeName range

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  abstract member BeforeVisitUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitUpcast".</remarks>
  default this.BeforeVisitUpcast expr typeSig range parents context =
    this.VisitUpcast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeSig range parents context

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  abstract member VisitUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initUpcast".</remarks>
  default __.VisitUpcast expr typeSig range parents context =
    SynExpr.initUpcast expr typeSig range

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  abstract member BeforeVisitDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDowncast".</remarks>
  default this.BeforeVisitDowncast expr typeName range parents context =
    this.VisitDowncast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) typeName range parents context

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  abstract member VisitDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDowncast".</remarks>
  default __.VisitDowncast expr typeName range parents context =
    SynExpr.initDowncast expr typeName range

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  abstract member BeforeVisitInferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredUpcast".</remarks>
  default this.BeforeVisitInferredUpcast expr range parents context =
    this.VisitInferredUpcast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  abstract member VisitInferredUpcast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredUpcast".</remarks>
  default __.VisitInferredUpcast expr range parents context =
    SynExpr.initInferredUpcast expr range

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  abstract member BeforeVisitInferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitInferredDowncast".</remarks>
  default this.BeforeVisitInferredDowncast expr range parents context =
    this.VisitInferredDowncast (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  abstract member VisitInferredDowncast: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initInferredDowncast".</remarks>
  default __.VisitInferredDowncast expr range parents context =
    SynExpr.initInferredDowncast expr range

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  abstract member BeforeVisitNull: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitNull".</remarks>
  default this.BeforeVisitNull range parents context =
    this.VisitNull range parents context

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  abstract member VisitNull: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initNull".</remarks>
  default __.VisitNull range parents context =
    SynExpr.initNull range

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  abstract member BeforeVisitAddressOf: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitAddressOf".</remarks>
  default this.BeforeVisitAddressOf item1 item2 item3 range parents context =
    this.VisitAddressOf item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) item3 range parents context

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  abstract member VisitAddressOf: item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initAddressOf".</remarks>
  default __.VisitAddressOf item1 item2 item3 range parents context =
    SynExpr.initAddressOf item1 item2 item3 range

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  abstract member BeforeVisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitTraitCall".</remarks>
  default this.BeforeVisitTraitCall item1 item2 item3 range parents context =
    this.VisitTraitCall item1 item2 (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  abstract member VisitTraitCall: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initTraitCall".</remarks>
  default __.VisitTraitCall item1 item2 item3 range parents context =
    SynExpr.initTraitCall item1 item2 item3 range

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  abstract member BeforeVisitJoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitJoinIn".</remarks>
  default this.BeforeVisitJoinIn item1 inPos item3 range parents context =
    this.VisitJoinIn (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) inPos (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  abstract member VisitJoinIn: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initJoinIn".</remarks>
  default __.VisitJoinIn item1 inPos item3 range parents context =
    SynExpr.initJoinIn item1 inPos item3 range

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  abstract member BeforeVisitImplicitZero: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitImplicitZero".</remarks>
  default this.BeforeVisitImplicitZero range parents context =
    this.VisitImplicitZero range parents context

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  abstract member VisitImplicitZero: range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initImplicitZero".</remarks>
  default __.VisitImplicitZero range parents context =
    SynExpr.initImplicitZero range

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  abstract member BeforeVisitYieldOrReturn: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturn".</remarks>
  default this.BeforeVisitYieldOrReturn item1 expr range parents context =
    this.VisitYieldOrReturn item1 (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  abstract member VisitYieldOrReturn: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturn".</remarks>
  default __.VisitYieldOrReturn item1 expr range parents context =
    SynExpr.initYieldOrReturn item1 expr range

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  abstract member BeforeVisitYieldOrReturnFrom: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitYieldOrReturnFrom".</remarks>
  default this.BeforeVisitYieldOrReturnFrom item1 expr range parents context =
    this.VisitYieldOrReturnFrom item1 (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  abstract member VisitYieldOrReturnFrom: item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initYieldOrReturnFrom".</remarks>
  default __.VisitYieldOrReturnFrom item1 expr range parents context =
    SynExpr.initYieldOrReturnFrom item1 expr range

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  abstract member BeforeVisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLetOrUseBang".</remarks>
  default this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range parents context =
    this.VisitLetOrUseBang spBind isUse isFromSource pattern (rhsExpr |> (fun expr -> this.VisitSynExpr expr parents context)) (bodyExpr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  abstract member VisitLetOrUseBang: spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLetOrUseBang".</remarks>
  default __.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range parents context =
    SynExpr.initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  abstract member BeforeVisitDoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDoBang".</remarks>
  default this.BeforeVisitDoBang expr range parents context =
    this.VisitDoBang (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  abstract member VisitDoBang: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDoBang".</remarks>
  default __.VisitDoBang expr range parents context =
    SynExpr.initDoBang expr range

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  abstract member BeforeVisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyILAssembly".</remarks>
  default this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range parents context =
    this.VisitLibraryOnlyILAssembly item1 item2 (item3 |> (List.map (fun expr -> this.VisitSynExpr expr parents context))) item4 range parents context

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  abstract member VisitLibraryOnlyILAssembly: item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyILAssembly".</remarks>
  default __.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range parents context =
    SynExpr.initLibraryOnlyILAssembly item1 item2 item3 item4 range

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  abstract member BeforeVisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyStaticOptimization".</remarks>
  default this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range parents context =
    this.VisitLibraryOnlyStaticOptimization item1 (item2 |> (fun expr -> this.VisitSynExpr expr parents context)) (item3 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  abstract member VisitLibraryOnlyStaticOptimization: item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyStaticOptimization".</remarks>
  default __.VisitLibraryOnlyStaticOptimization item1 item2 item3 range parents context =
    SynExpr.initLibraryOnlyStaticOptimization item1 item2 item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldGet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range parents context =
    this.VisitLibraryOnlyUnionCaseFieldGet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) longId item3 range parents context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldGet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range parents context =
    SynExpr.initLibraryOnlyUnionCaseFieldGet item1 longId item3 range

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member BeforeVisitLibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitLibraryOnlyUnionCaseFieldSet".</remarks>
  default this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range parents context =
    this.VisitLibraryOnlyUnionCaseFieldSet (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) longId item3 (item4 |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initLibraryOnlyUnionCaseFieldSet".</remarks>
  default __.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range parents context =
    SynExpr.initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  abstract member BeforeVisitArbitraryAfterError: debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitArbitraryAfterError".</remarks>
  default this.BeforeVisitArbitraryAfterError debugStr range parents context =
    this.VisitArbitraryAfterError debugStr range parents context

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  abstract member VisitArbitraryAfterError: debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initArbitraryAfterError".</remarks>
  default __.VisitArbitraryAfterError debugStr range parents context =
    SynExpr.initArbitraryAfterError debugStr range

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  abstract member BeforeVisitFromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFromParseError".</remarks>
  default this.BeforeVisitFromParseError expr range parents context =
    this.VisitFromParseError (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  abstract member VisitFromParseError: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFromParseError".</remarks>
  default __.VisitFromParseError expr range parents context =
    SynExpr.initFromParseError expr range

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member BeforeVisitDiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitDiscardAfterMissingQualificationAfterDot".</remarks>
  default this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range parents context =
    this.VisitDiscardAfterMissingQualificationAfterDot (expr |> (fun expr -> this.VisitSynExpr expr parents context)) range parents context

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initDiscardAfterMissingQualificationAfterDot".</remarks>
  default __.VisitDiscardAfterMissingQualificationAfterDot expr range parents context =
    SynExpr.initDiscardAfterMissingQualificationAfterDot expr range

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  abstract member BeforeVisitFixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Before visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "VisitFixed".</remarks>
  default this.BeforeVisitFixed item1 item2 parents context =
    this.VisitFixed (item1 |> (fun expr -> this.VisitSynExpr expr parents context)) item2 parents context

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  abstract member VisitFixed: item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  /// <remarks>Default implementation invoked "SynExpr.initFixed".</remarks>
  default __.VisitFixed item1 item2 parents context =
    SynExpr.initFixed item1 item2


  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  /// <param name="expr">Target expression.</param>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSynExpr expr parents context =
    let currentParents = expr :: parents
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      this.BeforeVisitParen expr leftParenRange rightParenRange range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.BeforeVisitQuote operator isRaw quotedSynExpr isFromQueryExpression range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.BeforeVisitConst constant range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.BeforeVisitTyped expr typeSig range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.BeforeVisitTuple exprs commaRanges range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.BeforeVisitArrayOrList isList exprs range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.BeforeVisitRecord baseInfo copyInfo recordFields range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.BeforeVisitNew isProtected typeName expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.BeforeVisitObjExpr objType argOpt bindings extraImpls newPos range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.BeforeVisitWhile spWhile whileBody doBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.BeforeVisitFor spFor id idBody item4 toBody doBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.BeforeVisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.BeforeVisitArrayOrListOfSeqExpr isList elements range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.BeforeVisitCompExpr isArrayOrList isNotNakedRefCell expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.BeforeVisitLambda fromMethod inLambdaSeq args body range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.BeforeVisitMatchLambda item1 item2 clauses spBind range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.BeforeVisitMatch spBind matchExpr clauses isCexprExceptionMatch range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.BeforeVisitDo expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.BeforeVisitAssert expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.BeforeVisitApp exprAtomicFlag isInfix funcExpr argExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.BeforeVisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.BeforeVisitLetOrUse isRecursive isUse bindings exprBody range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.BeforeVisitTryWith tryExpr item2 item3 item4 range spTry spWith currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.BeforeVisitTryFinally tryExpr finallyExpr range spTry spFinally currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.BeforeVisitLazy expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.BeforeVisitSequential spSeq isTrueSeq expr1 expr2 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.BeforeVisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.BeforeVisitIdent item currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.BeforeVisitLongIdent isOptional longIdent altNameRefCell range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.BeforeVisitLongIdentSet dotId expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.BeforeVisitDotGet expr rangeOfDot dotId range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.BeforeVisitDotSet expr dotId exprValue range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.BeforeVisitDotIndexedGet expr indexExprs item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.BeforeVisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.BeforeVisitNamedIndexedPropertySet item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.BeforeVisitDotNamedIndexedPropertySet item1 item2 item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.BeforeVisitTypeTest expr typeName range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.BeforeVisitUpcast expr typeSig range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.BeforeVisitDowncast expr typeName range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.BeforeVisitInferredUpcast expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.BeforeVisitInferredDowncast expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.BeforeVisitNull range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.BeforeVisitAddressOf item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.BeforeVisitTraitCall item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.BeforeVisitJoinIn item1 inPos item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.BeforeVisitImplicitZero range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.BeforeVisitYieldOrReturn item1 expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.BeforeVisitYieldOrReturnFrom item1 expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.BeforeVisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.BeforeVisitDoBang expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyILAssembly item1 item2 item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.BeforeVisitLibraryOnlyStaticOptimization item1 item2 item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.BeforeVisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.BeforeVisitArbitraryAfterError debugStr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.BeforeVisitFromParseError expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.BeforeVisitDiscardAfterMissingQualificationAfterDot expr range currentParents context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.BeforeVisitFixed item1 item2 currentParents context


