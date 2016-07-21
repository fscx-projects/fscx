//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Thu, 21 Jul 2016 09:58:16 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<NoEquality; NoComparison; AutoSerializable(false)>]
type SynExprVisitor() =

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  abstract member VisitParen: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitParen expr leftParenRange rightParenRange range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren (expr, leftParenRange, rightParenRange, range)

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  abstract member VisitQuote: Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote (operator, isRaw, quotedSynExpr, isFromQueryExpression, range)

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
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed (expr, typeSig, range)

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  abstract member VisitTuple: Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTuple exprs commaRanges range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple (exprs, commaRanges, range)

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  abstract member VisitArrayOrList: System.Boolean -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitArrayOrList isList exprs range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList (isList, exprs, range)

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  abstract member VisitRecord: Microsoft.FSharp.Core.FSharpOption<System.Tuple<Microsoft.FSharp.Compiler.Ast.SynType, Microsoft.FSharp.Compiler.Ast.SynExpr, Microsoft.FSharp.Compiler.Range.range, Microsoft.FSharp.Core.FSharpOption<System.Tuple<Microsoft.FSharp.Compiler.Range.range, Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Range.pos>>>, Microsoft.FSharp.Compiler.Range.range>> -> Microsoft.FSharp.Core.FSharpOption<System.Tuple<Microsoft.FSharp.Compiler.Ast.SynExpr, System.Tuple<Microsoft.FSharp.Compiler.Range.range, Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Range.pos>>>> -> Microsoft.FSharp.Collections.FSharpList<System.Tuple<System.Tuple<Microsoft.FSharp.Compiler.Ast.LongIdentWithDots, System.Boolean>, Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Ast.SynExpr>, Microsoft.FSharp.Core.FSharpOption<System.Tuple<Microsoft.FSharp.Compiler.Range.range, Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Range.pos>>>>> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitRecord baseInfo copyInfo recordFields range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record (baseInfo, copyInfo, recordFields, range)

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  abstract member VisitNew: System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitNew isProtected typeName expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New (isProtected, typeName, expr, range)

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  abstract member VisitObjExpr: Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Core.FSharpOption<System.Tuple<Microsoft.FSharp.Compiler.Ast.SynExpr, Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Ast.Ident>>> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynBinding> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitObjExpr objType argOpt bindings extraImpls newPos range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr (objType, argOpt, bindings, extraImpls, newPos, range)

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  abstract member VisitWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitWhile spWhile whileBody doBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While (spWhile, whileBody, doBody, range)

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  abstract member VisitFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitFor spFor id idBody item4 toBody doBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For (spFor, id, idBody, item4, toBody, doBody, range)

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  abstract member VisitForEach: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynPat -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach (spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  abstract member VisitArrayOrListOfSeqExpr: System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitArrayOrListOfSeqExpr isList elements range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr (isList, elements, range)

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  abstract member VisitCompExpr: System.Boolean -> Microsoft.FSharp.Core.FSharpRef<System.Boolean> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitCompExpr isArrayOrList isNotNakedRefCell expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr (isArrayOrList, isNotNakedRefCell, expr, range)

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  abstract member VisitLambda: System.Boolean -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynSimplePats -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLambda fromMethod inLambdaSeq args body range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda (fromMethod, inLambdaSeq, args, body, range)

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  abstract member VisitMatchLambda: System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitMatchLambda item1 item2 clauses spBind range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda (item1, item2, clauses, spBind, range)

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  abstract member VisitMatch: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match (spBind, matchExpr, clauses, isCexprExceptionMatch, range)

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  abstract member VisitDo: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDo expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do (expr, range)

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  abstract member VisitAssert: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitAssert expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert (expr, range)

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  abstract member VisitApp: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitApp exprAtomicFlag isInfix funcExpr argExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App (exprAtomicFlag, isInfix, funcExpr, argExpr, range)

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  abstract member VisitTypeApp: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Range.range> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp (expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  abstract member VisitLetOrUse: System.Boolean -> System.Boolean -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynBinding> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLetOrUse isRecursive isUse bindings exprBody range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse (isRecursive, isUse, bindings, exprBody, range)

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  abstract member VisitTryWith: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTryWith tryExpr item2 item3 item4 range spTry spWith context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith (tryExpr, item2, item3, item4, range, spTry, spWith)

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  abstract member VisitTryFinally: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTryFinally tryExpr finallyExpr range spTry spFinally context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally (tryExpr, finallyExpr, range, spTry, spFinally)

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  abstract member VisitLazy: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLazy expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy (expr, range)

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  abstract member VisitSequential: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitSequential spSeq isTrueSeq expr1 expr2 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential (spSeq, isTrueSeq, expr1, expr2, range)

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  abstract member VisitIfThenElse: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> System.Boolean -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse (exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  abstract member VisitIdent: Microsoft.FSharp.Compiler.Ast.Ident -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitIdent item context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident (item)

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  abstract member VisitLongIdent: System.Boolean -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Core.FSharpOption<Microsoft.FSharp.Core.FSharpRef<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLongIdent isOptional longIdent altNameRefCell range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent (isOptional, longIdent, altNameRefCell, range)

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  abstract member VisitLongIdentSet: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLongIdentSet dotId expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet (dotId, expr, range)

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  abstract member VisitDotGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotGet expr rangeOfDot dotId range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet (expr, rangeOfDot, dotId, range)

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  abstract member VisitDotSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotSet expr dotId exprValue range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet (expr, dotId, exprValue, range)

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  abstract member VisitDotIndexedGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotIndexedGet expr indexExprs item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet (expr, indexExprs, item3, range)

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  abstract member VisitDotIndexedSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet (objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  abstract member VisitNamedIndexedPropertySet: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitNamedIndexedPropertySet item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet (item1, item2, item3, range)

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  abstract member VisitDotNamedIndexedPropertySet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet (item1, item2, item3, item4, range)

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  abstract member VisitTypeTest: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTypeTest expr typeName range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest (expr, typeName, range)

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  abstract member VisitUpcast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitUpcast expr typeSig range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast (expr, typeSig, range)

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  abstract member VisitDowncast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynType -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDowncast expr typeName range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast (expr, typeName, range)

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  abstract member VisitInferredUpcast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitInferredUpcast expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast (expr, range)

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  abstract member VisitInferredDowncast: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitInferredDowncast expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast (expr, range)

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
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf (item1, item2, item3, range)

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  abstract member VisitTraitCall: Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynTypar> -> Microsoft.FSharp.Compiler.Ast.SynMemberSig -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitTraitCall item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall (item1, item2, item3, range)

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  abstract member VisitJoinIn: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitJoinIn item1 inPos item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn (item1, inPos, item3, range)

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  abstract member VisitImplicitZero: Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitImplicitZero range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero (range)

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  abstract member VisitYieldOrReturn: System.Tuple<System.Boolean, System.Boolean> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitYieldOrReturn item1 expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn (item1, expr, range)

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  abstract member VisitYieldOrReturnFrom: System.Tuple<System.Boolean, System.Boolean> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitYieldOrReturnFrom item1 expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom (item1, expr, range)

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  abstract member VisitLetOrUseBang: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> System.Boolean -> System.Boolean -> Microsoft.FSharp.Compiler.Ast.SynPat -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang (spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  abstract member VisitDoBang: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDoBang expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang (expr, range)

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  abstract member VisitLibraryOnlyILAssembly: Microsoft.FSharp.Compiler.AbstractIL.ILInstr[] -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynExpr> -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynType> -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly (item1, item2, item3, item4, range)

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  abstract member VisitLibraryOnlyStaticOptimization: Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyStaticOptimization item1 item2 item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization (item1, item2, item3, range)

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  abstract member VisitLibraryOnlyUnionCaseFieldGet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.Ident> -> System.Int32 -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet (item1, longId, item3, range)

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  abstract member VisitLibraryOnlyUnionCaseFieldSet: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Collections.FSharpList<Microsoft.FSharp.Compiler.Ast.Ident> -> System.Int32 -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet (item1, longId, item3, item4, range)

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
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError (expr, range)

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  abstract member VisitDiscardAfterMissingQualificationAfterDot: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitDiscardAfterMissingQualificationAfterDot expr range context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot (expr, range)

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  abstract member VisitFixed: Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Range.range -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.VisitFixed item1 item2 context =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed (item1, item2)


  /// <summary>
  /// Visitor entry function.
  /// </summary>
  abstract member Visit: Microsoft.FSharp.Compiler.Ast.SynExpr -> 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr
  default this.Visit expr context =
    match expr with
    | Microsoft.FSharp.Compiler.Ast.SynParen(expr, leftParenRange, rightParenRange, range) ->
      this.VisitParen expr leftParenRange rightParenRange range context
    | Microsoft.FSharp.Compiler.Ast.SynQuote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.VisitQuote operator isRaw quotedSynExpr isFromQueryExpression range context
    | Microsoft.FSharp.Compiler.Ast.SynConst(constant, range) ->
      this.VisitConst constant range context
    | Microsoft.FSharp.Compiler.Ast.SynTyped(expr, typeSig, range) ->
      this.VisitTyped expr typeSig range context
    | Microsoft.FSharp.Compiler.Ast.SynTuple(exprs, commaRanges, range) ->
      this.VisitTuple exprs commaRanges range context
    | Microsoft.FSharp.Compiler.Ast.SynArrayOrList(isList, exprs, range) ->
      this.VisitArrayOrList isList exprs range context
    | Microsoft.FSharp.Compiler.Ast.SynRecord(baseInfo, copyInfo, recordFields, range) ->
      this.VisitRecord baseInfo copyInfo recordFields range context
    | Microsoft.FSharp.Compiler.Ast.SynNew(isProtected, typeName, expr, range) ->
      this.VisitNew isProtected typeName expr range context
    | Microsoft.FSharp.Compiler.Ast.SynObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.VisitObjExpr objType argOpt bindings extraImpls newPos range context
    | Microsoft.FSharp.Compiler.Ast.SynWhile(spWhile, whileBody, doBody, range) ->
      this.VisitWhile spWhile whileBody doBody range context
    | Microsoft.FSharp.Compiler.Ast.SynFor(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.VisitFor spFor id idBody item4 toBody doBody range context
    | Microsoft.FSharp.Compiler.Ast.SynForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.VisitForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynArrayOrListOfSeqExpr(isList, elements, range) ->
      this.VisitArrayOrListOfSeqExpr isList elements range context
    | Microsoft.FSharp.Compiler.Ast.SynCompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.VisitCompExpr isArrayOrList isNotNakedRefCell expr range context
    | Microsoft.FSharp.Compiler.Ast.SynLambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.VisitLambda fromMethod inLambdaSeq args body range context
    | Microsoft.FSharp.Compiler.Ast.SynMatchLambda(item1, item2, clauses, spBind, range) ->
      this.VisitMatchLambda item1 item2 clauses spBind range context
    | Microsoft.FSharp.Compiler.Ast.SynMatch(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.VisitMatch spBind matchExpr clauses isCexprExceptionMatch range context
    | Microsoft.FSharp.Compiler.Ast.SynDo(expr, range) ->
      this.VisitDo expr range context
    | Microsoft.FSharp.Compiler.Ast.SynAssert(expr, range) ->
      this.VisitAssert expr range context
    | Microsoft.FSharp.Compiler.Ast.SynApp(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.VisitApp exprAtomicFlag isInfix funcExpr argExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynTypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.VisitTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range context
    | Microsoft.FSharp.Compiler.Ast.SynLetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.VisitLetOrUse isRecursive isUse bindings exprBody range context
    | Microsoft.FSharp.Compiler.Ast.SynTryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.VisitTryWith tryExpr item2 item3 item4 range spTry spWith context
    | Microsoft.FSharp.Compiler.Ast.SynTryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.VisitTryFinally tryExpr finallyExpr range spTry spFinally context
    | Microsoft.FSharp.Compiler.Ast.SynLazy(expr, range) ->
      this.VisitLazy expr range context
    | Microsoft.FSharp.Compiler.Ast.SynSequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.VisitSequential spSeq isTrueSeq expr1 expr2 range context
    | Microsoft.FSharp.Compiler.Ast.SynIfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.VisitIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range context
    | Microsoft.FSharp.Compiler.Ast.SynIdent(item) ->
      this.VisitIdent item context
    | Microsoft.FSharp.Compiler.Ast.SynLongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.VisitLongIdent isOptional longIdent altNameRefCell range context
    | Microsoft.FSharp.Compiler.Ast.SynLongIdentSet(dotId, expr, range) ->
      this.VisitLongIdentSet dotId expr range context
    | Microsoft.FSharp.Compiler.Ast.SynDotGet(expr, rangeOfDot, dotId, range) ->
      this.VisitDotGet expr rangeOfDot dotId range context
    | Microsoft.FSharp.Compiler.Ast.SynDotSet(expr, dotId, exprValue, range) ->
      this.VisitDotSet expr dotId exprValue range context
    | Microsoft.FSharp.Compiler.Ast.SynDotIndexedGet(expr, indexExprs, item3, range) ->
      this.VisitDotIndexedGet expr indexExprs item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynDotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.VisitDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range context
    | Microsoft.FSharp.Compiler.Ast.SynNamedIndexedPropertySet(item1, item2, item3, range) ->
      this.VisitNamedIndexedPropertySet item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynDotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.VisitDotNamedIndexedPropertySet item1 item2 item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynTypeTest(expr, typeName, range) ->
      this.VisitTypeTest expr typeName range context
    | Microsoft.FSharp.Compiler.Ast.SynUpcast(expr, typeSig, range) ->
      this.VisitUpcast expr typeSig range context
    | Microsoft.FSharp.Compiler.Ast.SynDowncast(expr, typeName, range) ->
      this.VisitDowncast expr typeName range context
    | Microsoft.FSharp.Compiler.Ast.SynInferredUpcast(expr, range) ->
      this.VisitInferredUpcast expr range context
    | Microsoft.FSharp.Compiler.Ast.SynInferredDowncast(expr, range) ->
      this.VisitInferredDowncast expr range context
    | Microsoft.FSharp.Compiler.Ast.SynNull(range) ->
      this.VisitNull range context
    | Microsoft.FSharp.Compiler.Ast.SynAddressOf(item1, item2, item3, range) ->
      this.VisitAddressOf item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynTraitCall(item1, item2, item3, range) ->
      this.VisitTraitCall item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynJoinIn(item1, inPos, item3, range) ->
      this.VisitJoinIn item1 inPos item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynImplicitZero(range) ->
      this.VisitImplicitZero range context
    | Microsoft.FSharp.Compiler.Ast.SynYieldOrReturn(item1, expr, range) ->
      this.VisitYieldOrReturn item1 expr range context
    | Microsoft.FSharp.Compiler.Ast.SynYieldOrReturnFrom(item1, expr, range) ->
      this.VisitYieldOrReturnFrom item1 expr range context
    | Microsoft.FSharp.Compiler.Ast.SynLetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.VisitLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range context
    | Microsoft.FSharp.Compiler.Ast.SynDoBang(expr, range) ->
      this.VisitDoBang expr range context
    | Microsoft.FSharp.Compiler.Ast.SynLibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.VisitLibraryOnlyILAssembly item1 item2 item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynLibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.VisitLibraryOnlyStaticOptimization item1 item2 item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynLibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.VisitLibraryOnlyUnionCaseFieldGet item1 longId item3 range context
    | Microsoft.FSharp.Compiler.Ast.SynLibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.VisitLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range context
    | Microsoft.FSharp.Compiler.Ast.SynArbitraryAfterError(debugStr, range) ->
      this.VisitArbitraryAfterError debugStr range context
    | Microsoft.FSharp.Compiler.Ast.SynFromParseError(expr, range) ->
      this.VisitFromParseError expr range context
    | Microsoft.FSharp.Compiler.Ast.SynDiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.VisitDiscardAfterMissingQualificationAfterDot expr range context
    | Microsoft.FSharp.Compiler.Ast.SynFixed(item1, item2) ->
      this.VisitFixed item1 item2 context

