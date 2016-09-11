//////////////////////////////////////////////////////////////////////////////////////
// TODO: will be replacing auto generated codes...
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open Microsoft.FSharp.Compiler.Ast

[<AutoOpen>]
module FunctionalVisitor =

  let rec private visitPat f (target: SynPat) : SynPat =
    match target with
    | SynPat.QuoteExpr(expr, range) -> SynPat.QuoteExpr(visitExpr f expr, range)
    | SynPat.Named(pat, id, isThisVar, accessiblity, range) -> SynPat.Named(visitPat f pat, id, isThisVar, accessiblity, range)
    | SynPat.Typed(pat, typeName, range) -> SynPat.Typed(visitPat f pat, typeName, range)
    | SynPat.Attrib(pat, attributes, range) -> SynPat.Attrib(visitPat f pat, attributes, range)
    | SynPat.Or(pat1, pat2, range) -> SynPat.Or(visitPat f pat1, visitPat f pat2, range)
    | SynPat.Ands(pats, range) -> SynPat.Ands(pats |> List.map (visitPat f), range)
    | SynPat.Tuple(pats, range) -> SynPat.Tuple(pats |> List.map (visitPat f), range)
    | SynPat.Paren(pat, range) -> SynPat.Paren(visitPat f pat, range)
    | SynPat.ArrayOrList(isList, pats, range) -> SynPat.ArrayOrList(isList, pats |> List.map (visitPat f), range)
    | SynPat.Record(fields, range) -> SynPat.Record(fields |> List.map (fun (ident, pat) -> (ident, visitPat f pat)), range)
    | SynPat.FromParseError(pat, range) -> SynPat.FromParseError(visitPat f pat, range)
    | SynPat.Const _
    | SynPat.Wild _
    | SynPat.LongIdent _
    | SynPat.Null _
    | SynPat.OptionalVal _
    | SynPat.IsInst _
    | SynPat.DeprecatedCharRange _
    | SynPat.InstanceMember _ -> target

  and private visitBinding f (SynBinding.Binding (access, bindingKind, mustInline, isMutable, attributes, xmlDoc, valData, headPat, bindingReturnInfoOpt, expr, lhsRange, spBind)) =
    SynBinding.Binding (access, bindingKind, mustInline, isMutable, attributes, xmlDoc, valData, visitPat f headPat, bindingReturnInfoOpt, (visitExpr f expr), lhsRange, spBind)

  and private visitMatchClause f (SynMatchClause.Clause (pat, eo, e, range, spTarget)) =
    SynMatchClause.Clause (visitPat f pat, eo |> Option.map (visitExpr f), visitExpr f e, range, spTarget)

  and private visitIndexerArg f arg =
    match arg with
    | SynIndexerArg.One expr -> SynIndexerArg.One(visitExpr f expr)
    | SynIndexerArg.Two (expr1, expr2) -> SynIndexerArg.Two(visitExpr f expr1, visitExpr f expr2)

  and private visitBaseInfo f baseInfo =
    match baseInfo with
    | Some (baseType, baseCtorArgs, mBaseCtor, sepAfterBase, mInherits) ->
        Some (baseType, (visitExpr f baseCtorArgs), mBaseCtor, sepAfterBase, mInherits)
    | None -> baseInfo

  and private visitCopyInfo f copyInfo =
    match copyInfo with
    | Some (copyExpr, sepAfterCopyExpr) -> Some ((visitExpr f copyExpr), sepAfterCopyExpr)
    | None -> copyInfo

  and private visitRecordFields f recordFields =
    recordFields
    |> List.map (function
        | (name, Some expr, sep) -> (name, Some (visitExpr f expr), sep)
        | (name, None, sep) -> (name, None, sep))

  and private visitArgOpt f argOpt =
    match argOpt with
    | Some (expr, identOpt) -> Some ((visitExpr f expr), identOpt)
    | None -> argOpt

  and visitInterfaceImpls f impls =
    impls
    |> List.map (fun (SynInterfaceImpl.InterfaceImpl (t, bindings, range)) ->
        SynInterfaceImpl.InterfaceImpl (t, bindings |> List.map (visitBinding f), range))

  and visitExpr (f: (SynExpr -> SynExpr) -> SynExpr -> SynExpr option) (target: SynExpr) : SynExpr =
    let g () =
      match target with
      | SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
          SynExpr.Paren((visitExpr f expr), leftParenRange, rightParenRange, range)
      | SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
          SynExpr.Quote((visitExpr f operator), isRaw, (visitExpr f quotedSynExpr), isFromQueryExpression, range)
      | SynExpr.Typed(expr, typeSig, range) ->
          SynExpr.Typed((visitExpr f expr), typeSig, range)
      | SynExpr.Tuple(exprs, commaRanges, range) ->
          SynExpr.Tuple(exprs |> List.map (visitExpr f), commaRanges, range)
      | SynExpr.ArrayOrList(isList, exprs, range) ->
          SynExpr.ArrayOrList(isList, exprs |> List.map (visitExpr f), range)
      | SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
          SynExpr.Record(visitBaseInfo f baseInfo, visitCopyInfo f copyInfo, visitRecordFields f recordFields, range)
      | SynExpr.New(isProtected, typeName, expr, range) ->
          SynExpr.New(isProtected, typeName, (visitExpr f expr), range)
      | SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
          SynExpr.ObjExpr(objType, visitArgOpt f argOpt, bindings |> List.map (visitBinding f), extraImpls |> visitInterfaceImpls f, newPos, range)
      | SynExpr.While(spWhile, whileBody, doBody, range) ->
          SynExpr.While(spWhile, (visitExpr f whileBody), (visitExpr f doBody), range)
      | SynExpr.For(spFor, id, idBody, b, toBody, doBody, range) ->
          SynExpr.For(spFor, id, (visitExpr f idBody), b, (visitExpr f toBody), (visitExpr f doBody), range)
      | SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
          SynExpr.ForEach(spFor, seqExprOnly, isFromSource, visitPat f pattern, (visitExpr f enumExpr), (visitExpr f bodyExpr), range)
      | SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
          SynExpr.ArrayOrListOfSeqExpr(isList, (visitExpr f elements), range)
      | SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
          SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, (visitExpr f expr), range)
      | SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
          SynExpr.Lambda(fromMethod, inLambdaSeq, args, (visitExpr f body), range)
      | SynExpr.MatchLambda(b, r, clauses, spBind, range) ->
          SynExpr.MatchLambda(b, r, clauses |> List.map (visitMatchClause f), spBind, range)
      | SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
          SynExpr.Match(spBind, (visitExpr f matchExpr), clauses |> List.map (visitMatchClause f), isCexprExceptionMatch, range)
      | SynExpr.Do(expr, range) ->
          SynExpr.Do(visitExpr f expr, range)
      | SynExpr.Assert(expr, range) ->
          SynExpr.Assert(visitExpr f expr, range)
      | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
          SynExpr.App(exprAtomicFlag, isInfix, visitExpr f funcExpr, visitExpr f argExpr, range)
      | SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
          SynExpr.TypeApp(visitExpr f expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
      | SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
          SynExpr.LetOrUse(isRecursive, isUse, bindings |> List.map (visitBinding f), visitExpr f exprBody, range)
      | SynExpr.TryWith(tryExpr, r1, clauses, r2, range, spTry, spWith) ->
          SynExpr.TryWith(visitExpr f tryExpr, r1, clauses |> List.map (visitMatchClause f), r2, range, spTry, spWith)
      | SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
          SynExpr.TryFinally(visitExpr f tryExpr, visitExpr f finallyExpr, range, spTry, spFinally)
      | SynExpr.Lazy(expr, range) ->
          SynExpr.Lazy(visitExpr f expr, range)
      | SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
          SynExpr.Sequential(spSeq, isTrueSeq, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
          SynExpr.IfThenElse(visitExpr f exprGuard, visitExpr f exprThen, optionalExprElse |> Option.map (visitExpr f), spIfToThen, isFromErrorRecovery, ifToThen, range)
      | SynExpr.LongIdentSet(dotId, expr, range) ->
          SynExpr.LongIdentSet(dotId, visitExpr f expr, range)
      | SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
          SynExpr.DotGet(visitExpr f expr, rangeOfDot, dotId, range)
      | SynExpr.DotSet(expr, dotId, exprValue, range) ->
          SynExpr.DotSet(visitExpr f expr, dotId, visitExpr f exprValue, range)
      | SynExpr.DotIndexedGet(expr, indexExprs, r, range) ->
          SynExpr.DotIndexedGet(visitExpr f expr, indexExprs |> List.map (visitIndexerArg f), r, range)
      | SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
          SynExpr.DotIndexedSet(visitExpr f objectExpr, indexExprs |> List.map (visitIndexerArg f), visitExpr f valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
      | SynExpr.NamedIndexedPropertySet(id, expr1, expr2, range) ->
          SynExpr.NamedIndexedPropertySet(id, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.DotNamedIndexedPropertySet(expr1, id, expr2, expr3, range) ->
          SynExpr.DotNamedIndexedPropertySet(visitExpr f expr1, id, visitExpr f expr2, visitExpr f expr3, range)
      | SynExpr.TypeTest(expr, typeName, range) ->
          SynExpr.TypeTest(visitExpr f expr, typeName, range)
      | SynExpr.Upcast(expr, typeSig, range) ->
          SynExpr.Upcast(visitExpr f expr, typeSig, range)
      | SynExpr.Downcast(expr, typeName, range) ->
          SynExpr.Downcast(visitExpr f expr, typeName, range)
      | SynExpr.InferredUpcast(expr, range) ->
          SynExpr.InferredUpcast(visitExpr f expr, range)
      | SynExpr.InferredDowncast(expr, range) ->
          SynExpr.InferredDowncast(visitExpr f expr, range)
      | SynExpr.AddressOf(b, expr, r, range) ->
          SynExpr.AddressOf(b, visitExpr f expr, r, range)
      | SynExpr.TraitCall(typars, memberSig, expr, range) ->
          SynExpr.TraitCall(typars, memberSig, visitExpr f expr, range)
      | SynExpr.JoinIn(expr1, inPos, expr2, range) ->
          SynExpr.JoinIn(visitExpr f expr1, inPos, visitExpr f expr2, range)
      | SynExpr.YieldOrReturn(bb, expr, range) ->
          SynExpr.YieldOrReturn(bb, visitExpr f expr, range)
      | SynExpr.YieldOrReturnFrom(bb, expr, range) ->
          SynExpr.YieldOrReturnFrom(bb, visitExpr f expr, range)
      | SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
          SynExpr.LetOrUseBang(spBind, isUse, isFromSource, visitPat f pattern, visitExpr f rhsExpr, visitExpr f bodyExpr, range)
      | SynExpr.DoBang(expr, range) ->
          SynExpr.DoBang(visitExpr f expr, range)
      | SynExpr.LibraryOnlyILAssembly(ils, types1, exprs, types2, range) ->
          SynExpr.LibraryOnlyILAssembly(ils, types1, exprs |> List.map (visitExpr f), types2, range)
      | SynExpr.LibraryOnlyStaticOptimization(constraints, expr1, expr2, range) ->
          SynExpr.LibraryOnlyStaticOptimization(constraints, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.LibraryOnlyUnionCaseFieldGet(expr, longId, i, range) ->
          SynExpr.LibraryOnlyUnionCaseFieldGet(visitExpr f expr, longId, i, range)
      | SynExpr.LibraryOnlyUnionCaseFieldSet(expr1, longId, i, expr2, range) ->
          SynExpr.LibraryOnlyUnionCaseFieldSet(visitExpr f expr1, longId, i, visitExpr f expr2, range)
      | SynExpr.FromParseError(expr, range) ->
          SynExpr.FromParseError(visitExpr f expr, range)
      | SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
          SynExpr.DiscardAfterMissingQualificationAfterDot(visitExpr f expr, range)
      | SynExpr.Fixed(expr, range) ->
          SynExpr.Fixed(visitExpr f expr, range)
      | SynExpr.Const _
      | SynExpr.Ident _
      | SynExpr.LongIdent _
      | SynExpr.Null _
      | SynExpr.ImplicitZero _
      | SynExpr.ArbitraryAfterError _ -> target

    match f (visitExpr f) target with
    | Some res -> res
    | None -> g ()
