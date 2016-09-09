//////////////////////////////////////////////////////////////////////////////////////
// TODO: will be replacing auto generated codes...
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open Microsoft.FSharp.Compiler.Ast

#nowarn "40"

[<AutoOpen>]
module FunctionalVisitor =

  type SelfF<'a> =
    private SelfF of obj
  with
    member this.Invoke(arg: 'a) : 'a =
      let (SelfF self) = this
      (self :?> ('a -> 'a)) arg

  let private call f self expr g =
    match f self expr with
    | Some res -> res
    | None -> g ()

  let rec private self f : SelfF<SynExpr> = (SelfF (visitExpr f))

  and private visitPat f (target: SynPat) : SynPat =
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

  and visitExpr (f: SelfF<SynExpr> -> SynExpr -> SynExpr option) (target: SynExpr) : SynExpr =
    let g =
      match target with
      | SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
          fun () -> SynExpr.Paren((visitExpr f expr), leftParenRange, rightParenRange, range)
      | SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
          fun () -> SynExpr.Quote((visitExpr f operator), isRaw, (visitExpr f quotedSynExpr), isFromQueryExpression, range)
      | SynExpr.Typed(expr, typeSig, range) ->
          fun () -> SynExpr.Typed((visitExpr f expr), typeSig, range)
      | SynExpr.Tuple(exprs, commaRanges, range) ->
          fun () -> SynExpr.Tuple(exprs |> List.map (visitExpr f), commaRanges, range)
      | SynExpr.ArrayOrList(isList, exprs, range) ->
          fun () -> SynExpr.ArrayOrList(isList, exprs |> List.map (visitExpr f), range)
      | SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
          let newBaseInfo =
            match baseInfo with
            | Some (baseType, baseCtorArgs, mBaseCtor, sepAfterBase, mInherits) ->
                Some (baseType, (visitExpr f baseCtorArgs), mBaseCtor, sepAfterBase, mInherits)
            | None -> baseInfo
          let newCopyInfo =
            match copyInfo with
            | Some (copyExpr, sepAfterCopyExpr) -> Some ((visitExpr f copyExpr), sepAfterCopyExpr)
            | None -> copyInfo
          let newRecordFields =
            recordFields |> List.map (function (name, Some expr, sep) -> (name, Some (visitExpr f expr), sep) | (name, None, sep) -> (name, None, sep))
          fun () -> SynExpr.Record(newBaseInfo, newCopyInfo, newRecordFields, range)
      | SynExpr.New(isProtected, typeName, expr, range) ->
          fun () -> SynExpr.New(isProtected, typeName, (visitExpr f expr), range)
      | SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
          let newArgOpt =
            match argOpt with
            | Some (expr, identOpt) -> Some ((visitExpr f expr), identOpt)
            | None -> argOpt
          let newBindings =
            bindings |> List.map (visitBinding f)
          let newExtraImpls =
            extraImpls
            |> List.map (fun (SynInterfaceImpl.InterfaceImpl (t, bindings, range)) ->
                SynInterfaceImpl.InterfaceImpl (t, bindings |> List.map (visitBinding f), range))
          fun () -> SynExpr.ObjExpr(objType, newArgOpt, newBindings, newExtraImpls, newPos, range)
      | SynExpr.While(spWhile, whileBody, doBody, range) ->
          fun () -> SynExpr.While(spWhile, (visitExpr f whileBody), (visitExpr f doBody), range)
      | SynExpr.For(spFor, id, idBody, b, toBody, doBody, range) ->
          fun () -> SynExpr.For(spFor, id, (visitExpr f idBody), b, (visitExpr f toBody), (visitExpr f doBody), range)
      | SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
          fun () -> SynExpr.ForEach(spFor, seqExprOnly, isFromSource, visitPat f pattern, (visitExpr f enumExpr), (visitExpr f bodyExpr), range)
      | SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
          fun () -> SynExpr.ArrayOrListOfSeqExpr(isList, (visitExpr f elements), range)
      | SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
          fun () -> SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, (visitExpr f expr), range)
      | SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
          fun () -> SynExpr.Lambda(fromMethod, inLambdaSeq, args, (visitExpr f body), range)
      | SynExpr.MatchLambda(b, r, clauses, spBind, range) ->
          fun () -> SynExpr.MatchLambda(b, r, clauses |> List.map (visitMatchClause f), spBind, range)
      | SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
          fun () -> SynExpr.Match(spBind, (visitExpr f matchExpr), clauses |> List.map (visitMatchClause f), isCexprExceptionMatch, range)
      | SynExpr.Do(expr, range) ->
          fun () -> SynExpr.Do(visitExpr f expr, range)
      | SynExpr.Assert(expr, range) ->
          fun () -> SynExpr.Assert(visitExpr f expr, range)
      | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
          fun () -> SynExpr.App(exprAtomicFlag, isInfix, visitExpr f funcExpr, visitExpr f argExpr, range)
      | SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
          fun () -> SynExpr.TypeApp(visitExpr f expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
      | SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
          fun () -> SynExpr.LetOrUse(isRecursive, isUse, bindings |> List.map (visitBinding f), visitExpr f exprBody, range)
      | SynExpr.TryWith(tryExpr, r1, clauses, r2, range, spTry, spWith) ->
          fun () -> SynExpr.TryWith(visitExpr f tryExpr, r1, clauses |> List.map (visitMatchClause f), r2, range, spTry, spWith)
      | SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
          fun () -> SynExpr.TryFinally(visitExpr f tryExpr, visitExpr f finallyExpr, range, spTry, spFinally)
      | SynExpr.Lazy(expr, range) ->
          fun () -> SynExpr.Lazy(visitExpr f expr, range)
      | SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
          fun () -> SynExpr.Sequential(spSeq, isTrueSeq, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
          fun () -> SynExpr.IfThenElse(visitExpr f exprGuard, visitExpr f exprThen, optionalExprElse |> Option.map (visitExpr f), spIfToThen, isFromErrorRecovery, ifToThen, range)
      | SynExpr.LongIdentSet(dotId, expr, range) ->
          fun () -> SynExpr.LongIdentSet(dotId, visitExpr f expr, range)
      | SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
          fun () -> SynExpr.DotGet(visitExpr f expr, rangeOfDot, dotId, range)
      | SynExpr.DotSet(expr, dotId, exprValue, range) ->
          fun () -> SynExpr.DotSet(visitExpr f expr, dotId, visitExpr f exprValue, range)
      | SynExpr.DotIndexedGet(expr, indexExprs, r, range) ->
          fun () -> SynExpr.DotIndexedGet(visitExpr f expr, indexExprs |> List.map (visitIndexerArg f), r, range)
      | SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
          fun () -> SynExpr.DotIndexedSet(visitExpr f objectExpr, indexExprs |> List.map (visitIndexerArg f), visitExpr f valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
      | SynExpr.NamedIndexedPropertySet(id, expr1, expr2, range) ->
          fun () -> SynExpr.NamedIndexedPropertySet(id, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.DotNamedIndexedPropertySet(expr1, id, expr2, expr3, range) ->
          fun () -> SynExpr.DotNamedIndexedPropertySet(visitExpr f expr1, id, visitExpr f expr2, visitExpr f expr3, range)
      | SynExpr.TypeTest(expr, typeName, range) ->
          fun () -> SynExpr.TypeTest(visitExpr f expr, typeName, range)
      | SynExpr.Upcast(expr, typeSig, range) ->
          fun () -> SynExpr.Upcast(visitExpr f expr, typeSig, range)
      | SynExpr.Downcast(expr, typeName, range) ->
          fun () -> SynExpr.Downcast(visitExpr f expr, typeName, range)
      | SynExpr.InferredUpcast(expr, range) ->
          fun () -> SynExpr.InferredUpcast(visitExpr f expr, range)
      | SynExpr.InferredDowncast(expr, range) ->
          fun () -> SynExpr.InferredDowncast(visitExpr f expr, range)
      | SynExpr.AddressOf(b, expr, r, range) ->
          fun () -> SynExpr.AddressOf(b, visitExpr f expr, r, range)
      | SynExpr.TraitCall(typars, memberSig, expr, range) ->
          fun () -> SynExpr.TraitCall(typars, memberSig, visitExpr f expr, range)
      | SynExpr.JoinIn(expr1, inPos, expr2, range) ->
          fun () -> SynExpr.JoinIn(visitExpr f expr1, inPos, visitExpr f expr2, range)
      | SynExpr.YieldOrReturn(bb, expr, range) ->
          fun () -> SynExpr.YieldOrReturn(bb, visitExpr f expr, range)
      | SynExpr.YieldOrReturnFrom(bb, expr, range) ->
          fun () -> SynExpr.YieldOrReturnFrom(bb, visitExpr f expr, range)
      | SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
          fun () -> SynExpr.LetOrUseBang(spBind, isUse, isFromSource, visitPat f pattern, visitExpr f rhsExpr, visitExpr f bodyExpr, range)
      | SynExpr.DoBang(expr, range) ->
          fun () -> SynExpr.DoBang(visitExpr f expr, range)
      | SynExpr.LibraryOnlyILAssembly(ils, types1, exprs, types2, range) ->
          fun () -> SynExpr.LibraryOnlyILAssembly(ils, types1, exprs |> List.map (visitExpr f), types2, range)
      | SynExpr.LibraryOnlyStaticOptimization(constraints, expr1, expr2, range) ->
          fun () -> SynExpr.LibraryOnlyStaticOptimization(constraints, visitExpr f expr1, visitExpr f expr2, range)
      | SynExpr.LibraryOnlyUnionCaseFieldGet(expr, longId, i, range) ->
          fun () -> SynExpr.LibraryOnlyUnionCaseFieldGet(visitExpr f expr, longId, i, range)
      | SynExpr.LibraryOnlyUnionCaseFieldSet(expr1, longId, i, expr2, range) ->
          fun () -> SynExpr.LibraryOnlyUnionCaseFieldSet(visitExpr f expr1, longId, i, visitExpr f expr2, range)
      | SynExpr.FromParseError(expr, range) ->
          fun () -> SynExpr.FromParseError(visitExpr f expr, range)
      | SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
          fun () -> SynExpr.DiscardAfterMissingQualificationAfterDot(visitExpr f expr, range)
      | SynExpr.Fixed(expr, range) ->
          fun () -> SynExpr.Fixed(visitExpr f expr, range)
      | SynExpr.Const _
      | SynExpr.Ident _
      | SynExpr.LongIdent _
      | SynExpr.Null _
      | SynExpr.ImplicitZero _
      | SynExpr.ArbitraryAfterError _ ->
          fun () -> target
    call f (self f) target g
