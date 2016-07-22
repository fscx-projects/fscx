//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Fri, 22 Jul 2016 05:05:14 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  abstract member VisitParen: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitParen expr leftParenRange rightParenRange range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren (this.VisitSynExpr expr context, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  abstract member VisitQuote: Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote (this.VisitSynExpr operator context, isRaw, this.VisitSynExpr quotedSynExpr context, isFromQueryExpression, range)

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  abstract member VisitConst: Microsoft.FSharp.Compiler.Ast.SynConst -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitConst constant range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const (constant, range)

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  abstract member VisitTyped: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTyped expr typeSig range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed (this.VisitSynExpr expr context, typeSig, range)

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  abstract member VisitTuple: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTuple exprs commaRanges range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple (exprs, commaRanges, range)

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  abstract member VisitArrayOrList: System.Boolean -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitArrayOrList isList exprs range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList (isList, exprs, range)

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  abstract member VisitRecord: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitRecord baseInfo copyInfo recordFields range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record (baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  abstract member VisitNew: System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitNew isProtected typeName expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New (isProtected, typeName, this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  abstract member VisitObjExpr: Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitObjExpr objType argOpt bindings extraImpls newPos range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr (objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  abstract member VisitWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitWhile spWhile whileBody doBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While (spWhile, this.VisitSynExpr whileBody context, this.VisitSynExpr doBody context, range)

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  abstract member VisitFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitFor spFor id idBody item4 toBody doBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For (spFor, id, this.VisitSynExpr idBody context, item4, this.VisitSynExpr toBody context, this.VisitSynExpr doBody context, range)

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  abstract member VisitForEach: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynPat -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach (spFor, seqExprOnly, isFromSource, pattern, this.VisitSynExpr enumExpr context, this.VisitSynExpr bodyExpr context, range)

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  abstract member VisitArrayOrListOfSeqExpr: System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitArrayOrListOfSeqExpr isList elements range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr (isList, this.VisitSynExpr elements context, range)

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  abstract member VisitCompExpr: System.Boolean -> Microsoft.FSharp.Core.Ref<System.Boolean> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitCompExpr isArrayOrList isNotNakedRefCell expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr (isArrayOrList, isNotNakedRefCell, this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  abstract member VisitLambda: System.Boolean -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynSimplePats -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLambda fromMethod inLambdaSeq args body range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda (fromMethod, inLambdaSeq, args, this.VisitSynExpr body context, range)

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  abstract member VisitMatchLambda: System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitMatchLambda item1 item2 clauses spBind range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda (item1, item2, clauses, spBind, range)

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  abstract member VisitMatch: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match (spBind, this.VisitSynExpr matchExpr context, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  abstract member VisitDo: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDo expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  abstract member VisitAssert: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitAssert expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  abstract member VisitApp: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitApp exprAtomicFlag isInfix funcExpr argExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App (exprAtomicFlag, isInfix, this.VisitSynExpr funcExpr context, this.VisitSynExpr argExpr context, range)

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  abstract member VisitTypeApp: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp (this.VisitSynExpr expr context, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  abstract member VisitLetOrUse: System.Boolean -> System.Boolean -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLetOrUse isRecursive isUse bindings exprBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse (isRecursive, isUse, bindings, this.VisitSynExpr exprBody context, range)

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  abstract member VisitTryWith: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTryWith tryExpr item2 item3 item4 range spTry spWith context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith (this.VisitSynExpr tryExpr context, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  abstract member VisitTryFinally: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTryFinally tryExpr finallyExpr range spTry spFinally context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally (this.VisitSynExpr tryExpr context, this.VisitSynExpr finallyExpr context, range, spTry, spFinally)

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  abstract member VisitLazy: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLazy expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  abstract member VisitSequential: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitSequential spSeq isTrueSeq expr1 expr2 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential (spSeq, isTrueSeq, this.VisitSynExpr expr1 context, this.VisitSynExpr expr2 context, range)

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  abstract member VisitIfThenElse: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse (this.VisitSynExpr exprGuard context, this.VisitSynExpr exprThen context, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  abstract member VisitIdent: Microsoft.FSharp.Compiler.Ast.Ident -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitIdent item context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident (item)

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  abstract member VisitLongIdent: System.Boolean -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLongIdent isOptional longIdent altNameRefCell range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent (isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  abstract member VisitLongIdentSet: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLongIdentSet dotId expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet (dotId, this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  abstract member VisitDotGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotGet expr rangeOfDot dotId range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet (this.VisitSynExpr expr context, rangeOfDot, dotId, range)

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  abstract member VisitDotSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotSet expr dotId exprValue range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet (this.VisitSynExpr expr context, dotId, this.VisitSynExpr exprValue context, range)

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  abstract member VisitDotIndexedGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotIndexedGet expr indexExprs item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet (this.VisitSynExpr expr context, indexExprs, item3, range)

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  abstract member VisitDotIndexedSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet (this.VisitSynExpr objectExpr context, indexExprs, this.VisitSynExpr valueExpr context, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  abstract member VisitNamedIndexedPropertySet: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitNamedIndexedPropertySet item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet (item1, this.VisitSynExpr item2 context, this.VisitSynExpr item3 context, range)

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  abstract member VisitDotNamedIndexedPropertySet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet (this.VisitSynExpr item1 context, item2, this.VisitSynExpr item3 context, this.VisitSynExpr item4 context, range)

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  abstract member VisitTypeTest: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTypeTest expr typeName range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest (this.VisitSynExpr expr context, typeName, range)

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  abstract member VisitUpcast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitUpcast expr typeSig range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast (this.VisitSynExpr expr context, typeSig, range)

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  abstract member VisitDowncast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDowncast expr typeName range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast (this.VisitSynExpr expr context, typeName, range)

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  abstract member VisitInferredUpcast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitInferredUpcast expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  abstract member VisitInferredDowncast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitInferredDowncast expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  abstract member VisitNull: Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitNull range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null (range)

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  abstract member VisitAddressOf: System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitAddressOf item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf (item1, this.VisitSynExpr item2 context, item3, range)

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  abstract member VisitTraitCall: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> Microsoft.FSharp.Compiler.Ast.SynMemberSig -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTraitCall item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall (item1, item2, this.VisitSynExpr item3 context, range)

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  abstract member VisitJoinIn: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitJoinIn item1 inPos item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn (this.VisitSynExpr item1 context, inPos, this.VisitSynExpr item3 context, range)

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  abstract member VisitImplicitZero: Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitImplicitZero range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero (range)

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  abstract member VisitYieldOrReturn: (System.Boolean * System.Boolean) -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitYieldOrReturn item1 expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn (item1, this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  abstract member VisitYieldOrReturnFrom: (System.Boolean * System.Boolean) -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitYieldOrReturnFrom item1 expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom (item1, this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  abstract member VisitLetOrUseBang: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> System.Boolean -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynPat -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang (spBind, isUse, isFromSource, pattern, this.VisitSynExpr rhsExpr context, this.VisitSynExpr bodyExpr context, range)

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  abstract member VisitDoBang: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDoBang expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  abstract member VisitLibraryOnlyILAssembly: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly (item1, item2, item3, item4, range)

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  abstract member VisitLibraryOnlyStaticOptimization: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyStaticOptimization item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization (item1, this.VisitSynExpr item2 context, this.VisitSynExpr item3 context, range)

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> System.Int32 -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet (this.VisitSynExpr item1 context, longId, item3, range)

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> System.Int32 -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet (this.VisitSynExpr item1 context, longId, item3, this.VisitSynExpr item4 context, range)

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  abstract member VisitArbitraryAfterError: System.String -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitArbitraryAfterError debugStr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError (debugStr, range)

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  abstract member VisitFromParseError: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitFromParseError expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDiscardAfterMissingQualificationAfterDot expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot (this.VisitSynExpr expr context, range)

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  abstract member VisitFixed: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitFixed item1 item2 context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed (this.VisitSynExpr item1 context, item2)


  /// <summary>
  /// SynExpr Visitor entry function.
  /// </summary>
  abstract member VisitSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitSynExpr expr context =
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      this.VisitParen expr leftParenRange rightParenRange range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.VisitConst constant range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.VisitTyped expr typeSig range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.VisitTuple exprs commaRanges range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.VisitArrayOrList isList exprs range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.VisitRecord baseInfo copyInfo recordFields range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.VisitNew isProtected typeName expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.VisitObjExpr objType argOpt bindings extraImpls newPos range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.VisitWhile spWhile whileBody doBody range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.VisitFor spFor id idBody item4 toBody doBody range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.VisitArrayOrListOfSeqExpr isList elements range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.VisitCompExpr isArrayOrList isNotNakedRefCell expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.VisitLambda fromMethod inLambdaSeq args body range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.VisitMatchLambda item1 item2 clauses spBind range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.VisitDo expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.VisitAssert expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.VisitApp exprAtomicFlag isInfix funcExpr argExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.VisitLetOrUse isRecursive isUse bindings exprBody range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.VisitTryWith tryExpr item2 item3 item4 range spTry spWith context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.VisitTryFinally tryExpr finallyExpr range spTry spFinally context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.VisitLazy expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.VisitSequential spSeq isTrueSeq expr1 expr2 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.VisitIdent item context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.VisitLongIdent isOptional longIdent altNameRefCell range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.VisitLongIdentSet dotId expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.VisitDotGet expr rangeOfDot dotId range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.VisitDotSet expr dotId exprValue range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.VisitDotIndexedGet expr indexExprs item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.VisitNamedIndexedPropertySet item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.VisitTypeTest expr typeName range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.VisitUpcast expr typeSig range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.VisitDowncast expr typeName range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.VisitInferredUpcast expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.VisitInferredDowncast expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.VisitNull range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.VisitAddressOf item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.VisitTraitCall item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.VisitJoinIn item1 inPos item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.VisitImplicitZero range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.VisitYieldOrReturn item1 expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.VisitYieldOrReturnFrom item1 expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.VisitDoBang expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.VisitLibraryOnlyStaticOptimization item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.VisitArbitraryAfterError debugStr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.VisitFromParseError expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.VisitDiscardAfterMissingQualificationAfterDot expr range context
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.VisitFixed item1 item2 context

