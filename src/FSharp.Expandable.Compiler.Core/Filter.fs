//////////////////////////////////////////////////////////////////////////////
// 
// fscx - Expandable F# compiler project (testing filter code)
//   Copyright (c) 2016: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift) all rights reserved.
//
// WARNING:
//  This filter code include only useful testing, and NOT CC0 license.
//  May be replace sample filter project.
//
//////////////////////////////////////////////////////////////////////////////

module Filter

open System.Reflection
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.Range
open Microsoft.FSharp.Compiler.SourceCodeServices

let zeroRange = range.Zero.MakeSynthetic()

module MethodInfo =
  open Microsoft.FSharp.Quotations
  open Microsoft.FSharp.Quotations.Patterns

  let extract (expr: Expr) =
    match expr with
    | Call(_, mi, _) -> mi
    | _ -> failwith "oops!"

  let toIdent (mi: MethodInfo) =
    assert mi.IsStatic
    // TODO : +とかジェネリックも考慮する
    let typFullName = mi.DeclaringType.FullName
    let elems = typFullName.Split('.') |> Array.toList
    let name = mi.Name
    let ids =
      List.concat [ elems; [name] ]
      |> List.map (fun x -> Ident(x, zeroRange))
    SynExpr.LongIdent(false, LongIdentWithDots(ids, List.replicate elems.Length zeroRange), None, zeroRange)

let genStringLit lit = SynExpr.Const(SynConst.String(lit, zeroRange), zeroRange)

let genIdent name = SynExpr.Ident(Ident(name, zeroRange))

let genParen x = SynExpr.Paren(x, zeroRange, None, zeroRange)

let genAppFun (name, arg) =
  SynExpr.App(ExprAtomicFlag.Atomic, false, genIdent name, arg, zeroRange)

let genOpChain (op, operands) =
  operands
  |> List.reduce (fun acc operand ->
       let func =
         SynExpr.App(ExprAtomicFlag.NonAtomic,true,genIdent op,acc,zeroRange)
       SynExpr.App(ExprAtomicFlag.NonAtomic,false,func,operand,zeroRange)
  )

let genCallStaticMethod (mi: MethodInfo, args: SynExpr list) =
  let argExpr =
    match args with
    | [] -> SynExpr.Const(SynConst.Unit, zeroRange)
    | [x] -> x
    | xs -> SynExpr.Tuple(xs, List.replicate (xs.Length - 1) zeroRange, zeroRange)
  SynExpr.App(
    ExprAtomicFlag.Atomic,
    false,
    MethodInfo.toIdent mi,
    genParen(argExpr),
    zeroRange)

let genLetExpr (name, value, expr) =
  let binding =
    SynBinding.Binding(
      None,
      SynBindingKind.NormalBinding,
      false,
      false,
      [],
      PreXmlDocEmpty,
      SynValData(None, SynValInfo([], SynArgInfo([], false, None)), None),
      SynPat.Named(SynPat.Wild(zeroRange), Ident(name, zeroRange), false, None, zeroRange),
      None,
      value,
      zeroRange,
      NoSequencePointAtInvisibleBinding
    )
  SynExpr.LetOrUse(false, false, [binding], expr, zeroRange)

let genTryExpr (tryExpr, clauses, range) =
  SynExpr.TryWith(
    tryExpr,
    zeroRange,
    clauses,
    zeroRange,
    zeroRange,
    SequencePointAtTry(range),  // Make break point data (pdb)
    NoSequencePointAtWith)

let genClause (identName, expr) =
  SynMatchClause.Clause(
                SynPat.Named(
                  SynPat.Wild(zeroRange),
                  Ident(identName, zeroRange),
                  false, None, zeroRange),
                None,
                expr,
                zeroRange,
                SuppressSequencePointAtTarget)

let genReraise () =
  SynExpr.App(
    ExprAtomicFlag.Atomic,
    false,
    genIdent "reraise",
    SynExpr.Paren(SynExpr.Const(SynConst.Unit, zeroRange), zeroRange, None, zeroRange),
    zeroRange)

let (+>) a b =
  SynExpr.Sequential(SuppressSequencePointOnStmtOfSequential, true, a, b, zeroRange)

let writeLineM = MethodInfo.extract <@ System.Console.WriteLine() @>

let logStartCallMethod name (ident: string) =
  genCallStaticMethod (writeLineM, [genStringLit ("calling " + name + ". args: {0}"); genIdent ident])

let logFinishCallMethod name (ident: string) =
  genCallStaticMethod (writeLineM, [genStringLit ("called " + name + ". args: {0}"); genIdent ident])

let logExn name (ident: string) =
  genCallStaticMethod (writeLineM, [genStringLit ("raised exn from " + name + ". exn: {0}"); genIdent ident])

let rec addSep sep = function
| [] -> []
| [x] -> [x]
| x::xs -> x::sep::(addSep sep xs)

let isIdent = function
| SynExpr.Ident _
| SynExpr.LongIdent _ -> true
| _ -> false

type ConvVisitor() =
  inherit AstVisitor<FSharpCheckFileResults>()

  override __.VisitQuote parents context operator isRaw quoteSynExpr isFromQueryExpression range =
    // DEBUG
    printfn "%A" operator
    base.VisitQuote parents context operator isRaw quoteSynExpr isFromQueryExpression range 

  override this.VisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
      let visitedArgs = this.PreVisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range

      let funcNameElems, funcIdentRange =
        match funcExpr with
        | SynExpr.Ident ident -> [ident.idText], ident.idRange
        | SynExpr.LongIdent (_, longIdent, _, range) ->
            let elems = longIdent.Lid |> List.map (fun i -> i.idText)
            elems, range
      let opt = context.GetSymbolUseAtLocation(funcIdentRange.Start.Line, funcIdentRange.End.Column, "", funcNameElems) |> Async.RunSynchronously
      // TODO : asmが対象外だったら変換せずにorigを返す
      let asm =
        match opt with
        | Some symbolUse ->
            let symbol = symbolUse.Symbol
            let asm = symbol.Assembly
            asm.SimpleName
        | None -> "unknown"

      let funcName = (funcNameElems |> String.concat ".") + (sprintf " [%d行,%d列目]" funcIdentRange.Start.Line funcIdentRange.Start.Column)

      // from
      //   f(expr1, expr2, ..., exprN)
      // to
      //   try
      //     let arg1 = expr1
      //     let arg2 = expr2
      //     ...
      //     let argN = exprN
      //     let args = string arg1 + ", " + string arg2 + ", " + ... + string argN
      //     log1 ("f(" + args + ")")
      //     let res = f(arg1, arg2, ..., argN)
      //     log2 ("f(" + args + ")")
      //     res
      //   with
      //   | e ->
      //       log3 ("f", e)
      //       reraise ()

      match argExpr with
      // f () の考慮   => Const(Unit)
      // f (()) の考慮 => Paren(Const(Unit))
      | SynExpr.Const(SynConst.Unit, x)
      | SynExpr.Paren(SynExpr.Const(SynConst.Unit, x), _, _, _) ->
          let tryExpr =
            genLetExpr(
              "args",
              genStringLit "()",
              logStartCallMethod funcName "args"
              +> (genLetExpr (
                    "res",
                    SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, argExpr, zeroRange),
                    logFinishCallMethod funcName "res"
                    +> genIdent "res")))
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)

      // f (x, y, ...) の考慮 => Paren(Tuple(exprs))
      | SynExpr.Paren(SynExpr.Tuple(exprs, commaRange, trange), x, y, z) ->
          let tryExpr =
            let exprs = exprs |> List.mapi (fun i x -> (i + 1, x))
            let args = exprs |> List.map (fun (n, _) -> SynExpr.Ident(Ident("arg" + string n, zeroRange)))
            let seed =
              genLetExpr(
                "args",
                genOpChain ("op_Addition", args |> List.map (fun arg -> genAppFun ("string", arg)) |> addSep (genStringLit ", ")),
                logStartCallMethod funcName "args"
                +> (genLetExpr (
                      "res",
                      SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, SynExpr.Paren(SynExpr.Tuple(args, commaRange, trange), x, y, z), zeroRange),
                      logFinishCallMethod funcName "res"
                      +> genIdent "res")))
            let x =
              (exprs, seed)
              ||> List.foldBack (fun (n, expr) acc ->
                    let name = "arg" + string n
                    genLetExpr (name, convExpr c expr, acc))
            x
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)

      // f (x) の考慮 => Paren(expr)
      // f x の考慮 =>  expr
      | SynExpr.Paren(expr, _, _, _)
      | expr ->
          let tryExpr =
            let seed =
              genLetExpr(
                "args",
                expr,
                logStartCallMethod funcName "args"
                +> (genLetExpr (
                      "res",
                      SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, SynExpr.Paren(expr, zeroRange, None, zeroRange), zeroRange),
                      logFinishCallMethod funcName "res"
                      +> genIdent "res")))
            convExpr c seed
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)
    

(*
let rec convExpr (c: FSharpCheckFileResults) (expr: SynExpr) =
  match expr with
  | SynExpr.Const _
  | SynExpr.Assert _
  | SynExpr.Ident _
  | SynExpr.LongIdent _
  | SynExpr.Null _
  | SynExpr.ImplicitZero _
  | SynExpr.LibraryOnlyILAssembly _
  | SynExpr.LibraryOnlyStaticOptimization _
  | SynExpr.LibraryOnlyUnionCaseFieldGet _
  | SynExpr.LibraryOnlyUnionCaseFieldSet _
  | SynExpr.ArbitraryAfterError _
  | SynExpr.FromParseError _
  | SynExpr.DiscardAfterMissingQualificationAfterDot _ -> expr
  | SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      SynExpr.Paren(convExpr c expr, leftParenRange, rightParenRange, range)
  | SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      printfn "%A" operator
      SynExpr.Quote(operator, isRaw, convExpr c quotedSynExpr, isFromQueryExpression, range)
  | SynExpr.Typed(expr, typeSig, range) -> SynExpr.Typed(convExpr c expr, typeSig, range)
  | SynExpr.Tuple(exprs, commaRanges, range) -> SynExpr.Tuple(exprs |> List.map (convExpr c), commaRanges, range)
  | SynExpr.ArrayOrList(isList, exprs, range) -> SynExpr.ArrayOrList(isList, exprs |> List.map (convExpr c), range)
  | SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      let baseInfo =
        baseInfo
        |> Option.map (fun (synTyp, expr, range1, sep, range2) -> (synTyp, convExpr c expr, range1, sep, range2)) // really need to conv?
      let copyInfo =
        copyInfo
        |> Option.map (fun (expr, sep) -> (convExpr c expr, sep))
      let recordFields =
        recordFields
        |> List.map (function (name, Some expr, sep) -> (name, Some (convExpr c expr), sep) | (name, _, sep) -> (name, None, sep))
      SynExpr.Record(baseInfo, copyInfo, recordFields, range)
  | SynExpr.New(isProtected, typeName, expr, range) -> SynExpr.New(isProtected, typeName, convExpr c expr, range)
  | SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      SynExpr.ObjExpr(objType, argOpt |> Option.map (fun (x, y) -> (convExpr c x, y)), bindings |> List.map (convBinding c), extraImpls, newPos, range)
  | SynExpr.While(spWhile, whileBody, doBody, range) -> SynExpr.While(spWhile, convExpr c whileBody, convExpr c doBody, range)
  | SynExpr.For(spFor, id, idBody, x, toBody, doBody, range) -> SynExpr.For(spFor, id, convExpr c idBody, x, convExpr c toBody, convExpr c doBody, range)
  | SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, convExpr c enumExpr, convExpr c bodyExpr, range)
  | SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) -> SynExpr.ArrayOrListOfSeqExpr(isList, convExpr c elements, range)
  | SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) -> SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, convExpr c expr, range)
  | SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) -> SynExpr.Lambda(fromMethod, inLambdaSeq, args, convExpr c body, range)
  | SynExpr.MatchLambda(x, y, clauses, spBind, range) ->
      SynExpr.MatchLambda(x, y, clauses |> List.map (convClause c), spBind, range)
  | SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      SynExpr.Match(spBind, convExpr c matchExpr, clauses |> List.map (convClause c), isCexprExceptionMatch, range)
  | SynExpr.Do(expr, range) -> SynExpr.Do(convExpr c expr, range)
  | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) as orig when isIdent funcExpr ->
      let funcNameElems, funcIdentRange =
        match funcExpr with
        | SynExpr.Ident ident -> [ident.idText], ident.idRange
        | SynExpr.LongIdent (_, longIdent, _, range) ->
            let elems = longIdent.Lid |> List.map (fun i -> i.idText)
            elems, range
      let opt = c.GetSymbolUseAtLocation(funcIdentRange.Start.Line, funcIdentRange.End.Column, "", funcNameElems) |> Async.RunSynchronously
      // TODO : asmが対象外だったら変換せずにorigを返す
      let asm =
        match opt with
        | Some symbolUse ->
            let symbol = symbolUse.Symbol
            let asm = symbol.Assembly
            asm.SimpleName
        | None -> "unknown"

      let funcName = (funcNameElems |> String.concat ".") + (sprintf " [%d行,%d列目]" funcIdentRange.Start.Line funcIdentRange.Start.Column)

      // from
      //   f(expr1, expr2, ..., exprN)
      // to
      //   try
      //     let arg1 = expr1
      //     let arg2 = expr2
      //     ...
      //     let argN = exprN
      //     let args = string arg1 + ", " + string arg2 + ", " + ... + string argN
      //     log1 ("f(" + args + ")")
      //     let res = f(arg1, arg2, ..., argN)
      //     log2 ("f(" + args + ")")
      //     res
      //   with
      //   | e ->
      //       log3 ("f", e)
      //       reraise ()

      match argExpr with
      // f () の考慮   => Const(Unit)
      // f (()) の考慮 => Paren(Const(Unit))
      | SynExpr.Const(SynConst.Unit, x)
      | SynExpr.Paren(SynExpr.Const(SynConst.Unit, x), _, _, _) ->
          let tryExpr =
            genLetExpr(
              "args",
              genStringLit "()",
              logStartCallMethod funcName "args"
              +> (genLetExpr (
                    "res",
                    SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, argExpr, zeroRange),
                    logFinishCallMethod funcName "res"
                    +> genIdent "res")))
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)

      // f (x, y, ...) の考慮 => Paren(Tuple(exprs))
      | SynExpr.Paren(SynExpr.Tuple(exprs, commaRange, trange), x, y, z) ->
          let tryExpr =
            let exprs = exprs |> List.mapi (fun i x -> (i + 1, x))
            let args = exprs |> List.map (fun (n, _) -> SynExpr.Ident(Ident("arg" + string n, zeroRange)))
            let seed =
              genLetExpr(
                "args",
                genOpChain ("op_Addition", args |> List.map (fun arg -> genAppFun ("string", arg)) |> addSep (genStringLit ", ")),
                logStartCallMethod funcName "args"
                +> (genLetExpr (
                      "res",
                      SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, SynExpr.Paren(SynExpr.Tuple(args, commaRange, trange), x, y, z), zeroRange),
                      logFinishCallMethod funcName "res"
                      +> genIdent "res")))
            let x =
              (exprs, seed)
              ||> List.foldBack (fun (n, expr) acc ->
                    let name = "arg" + string n
                    genLetExpr (name, convExpr c expr, acc))
            x
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)

      // f (x) の考慮 => Paren(expr)
      // f x の考慮 =>  expr
      | SynExpr.Paren(expr, _, _, _)
      | expr ->
          let tryExpr =
            let seed =
              genLetExpr(
                "args",
                expr,
                logStartCallMethod funcName "args"
                +> (genLetExpr (
                      "res",
                      SynExpr.App(exprAtomicFlag, isInfix, convExpr c funcExpr, SynExpr.Paren(expr, zeroRange, None, zeroRange), zeroRange),
                      logFinishCallMethod funcName "res"
                      +> genIdent "res")))
            convExpr c seed
          genTryExpr (
            tryExpr,
            [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
            range)
  | SynExpr.App _ -> expr
  | SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      SynExpr.TypeApp(convExpr c expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
  | SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      SynExpr.LetOrUse(isRecursive, isUse, bindings, convExpr c exprBody, range)
  | SynExpr.TryWith(tryExpr, x, clauses, y, range, spTry, spWith) ->
      SynExpr.TryWith(convExpr c tryExpr, x, clauses |> List.map (convClause c), y, range, spTry, spWith)
  | SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      SynExpr.TryFinally(convExpr c tryExpr, convExpr c finallyExpr, range, spTry, spFinally)
  | SynExpr.Lazy(expr, range) -> SynExpr.Lazy(convExpr c expr, range)
  | SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) -> SynExpr.Sequential(spSeq, isTrueSeq, convExpr c expr1, convExpr c expr2, range)
  | SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      SynExpr.IfThenElse(convExpr c exprGuard, convExpr c exprThen, optionalExprElse |> Option.map (convExpr c), spIfToThen, isFromErrorRecovery, ifToThen, range)
  | SynExpr.LongIdentSet (dotId, expr, range) -> SynExpr.LongIdentSet(dotId, convExpr c expr, range)
  | SynExpr.DotGet(expr, rangeOfDot, dotId, range) -> SynExpr.DotGet(convExpr c expr, rangeOfDot, dotId, range)
  | SynExpr.DotSet(expr, dotId, exprValue, range) -> SynExpr.DotSet(convExpr c expr, dotId, convExpr c exprValue, range)
  | SynExpr.DotIndexedGet(expr, indexExprs, range1, range2) ->
      SynExpr.DotIndexedGet(convExpr c expr, indexExprs |> List.map (convIndexerArg c), range1, range2)
  | SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      SynExpr.DotIndexedSet(convExpr c objectExpr, indexExprs |> List.map (convIndexerArg c), convExpr c valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
  | SynExpr.NamedIndexedPropertySet(ident, expr1, expr2, range) ->
      SynExpr.NamedIndexedPropertySet(ident, convExpr c expr1, convExpr c expr2, range)
  | SynExpr.DotNamedIndexedPropertySet(expr1, ident, expr2, expr3, range) ->
      SynExpr.DotNamedIndexedPropertySet(convExpr c expr1, ident, convExpr c expr2, convExpr c expr3, range)
  | SynExpr.TypeTest(expr, typeName, range) -> SynExpr.TypeTest(convExpr c expr, typeName, range)
  | SynExpr.Upcast(expr, typeSig, range) -> SynExpr.Upcast(convExpr c expr, typeSig, range)
  | SynExpr.Downcast(expr, typeName, range) -> SynExpr.Downcast(convExpr c expr, typeName, range)
  | SynExpr.InferredUpcast(expr, range) -> SynExpr.InferredUpcast(convExpr c expr, range)
  | SynExpr.InferredDowncast(expr, range) -> SynExpr.InferredDowncast(convExpr c expr, range)
  | SynExpr.AddressOf(b, expr, range1, range2) -> SynExpr.AddressOf(b, convExpr c expr, range1, range2)
  | SynExpr.TraitCall(typars, memSig, expr, range) -> SynExpr.TraitCall(typars, memSig, convExpr c expr, range)
  | SynExpr.JoinIn(expr1, inPos, expr2, range) -> SynExpr.JoinIn(convExpr c expr1, inPos, convExpr c expr2, range)
  | SynExpr.YieldOrReturn(x, expr, range) -> SynExpr.YieldOrReturn(x, convExpr c expr, range)
  | SynExpr.YieldOrReturnFrom(x, expr, range) -> SynExpr.YieldOrReturnFrom(x, convExpr c expr, range)
  | SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, convExpr c rhsExpr, convExpr c bodyExpr, range)
  | SynExpr.DoBang(expr, range) -> SynExpr.DoBang(convExpr c expr, range)
and convClause c (SynMatchClause.Clause (pat, exprOpt, expr, range, spTarget)) =
  SynMatchClause.Clause(pat, exprOpt |> Option.map (convExpr c), convExpr c expr, range, spTarget)
and convBinding c (Binding(access, kind, inlin, mutabl, attrs, xmlDoc, data, pat, retInfo, body, m, sp)) =
  Binding(access, kind, inlin, mutabl, attrs, xmlDoc, data, pat, retInfo, convExpr c body, m, sp)
and convIndexerArg c (indexerArg: SynIndexerArg) =
  match indexerArg with
  | SynIndexerArg.One expr -> SynIndexerArg.One (convExpr c expr)
  | SynIndexerArg.Two (expr1, expr2) -> SynIndexerArg.Two (convExpr c expr1, convExpr c expr2)
*)

let convDecls c xs =
  [ for decl in xs do
      match decl with
      | SynModuleDecl.Let(isRec, bindings, range) ->
          yield SynModuleDecl.Let(isRec, bindings |> List.map (convBinding c), range)
      | _ -> yield decl ]

let convModulesOrNamespaces c xs =
  [ for SynModuleOrNamespace(id, isRec, isMod, decls, xml, attrs, access, r) in xs do
      yield SynModuleOrNamespace(id, isRec, isMod, convDecls c decls, xml, attrs, access, r) ]

let apply (ast: ParsedInput) (c: FSharpCheckFileResults) =
  match ast with
  | ParsedInput.ImplFile(ParsedImplFileInput(filename, isScript, qualifiedNameOfFile, scopedPragmas, parsedHashDirectives, synModOrNss, x)) ->
      ParsedInput.ImplFile(ParsedImplFileInput(filename, isScript, qualifiedNameOfFile, scopedPragmas, parsedHashDirectives, convModulesOrNamespaces c synModOrNss, x))
  | other -> other
