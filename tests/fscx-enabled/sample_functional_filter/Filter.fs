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
open Microsoft.FSharp.Compiler.Ast.Visitor
open Microsoft.FSharp.Compiler.Range
open Microsoft.FSharp.Compiler.SourceCodeServices

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

////////////////////////////////////////////////

let outerVisitor
   (defaultVisitor: (FSharpCheckFileResults * NoContext * SynExpr -> SynExpr),
    symbolInformation: FSharpCheckFileResults,
    context: NoContext,
    expr: SynExpr) : SynExpr option =

  match expr with
  | SynExpr.Quote(operator, _, _, _, _) ->
    // DEBUG
    printfn "%A" operator
    None

  | SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
    match funcExpr with
      | SynExpr.Ident _
      | SynExpr.LongIdent _ -> 
        let results =
          match funcExpr with
          | SynExpr.Ident ident -> [ident.idText], ident.idRange
          | SynExpr.LongIdent (_, longIdent, _, range) ->
              let elems = longIdent.Lid |> List.map (fun i -> i.idText)
              elems, range
          | _ -> failwith "Unknown"
        let funcNameElems, funcIdentRange = results
        let opt =
          symbolInformation.GetSymbolUseAtLocation(
            funcIdentRange.Start.Line,
            funcIdentRange.End.Column,
            "",
            funcNameElems)
          |> Async.RunSynchronously

        // TODO : asmが対象外だったら変換せずにorigを返す
        let asm =
          match opt with
          | Some symbolUse ->
              let symbol = symbolUse.Symbol
              let asm = symbol.Assembly
              asm.SimpleName
          | None -> "unknown"

        let funcName =
          (funcNameElems |> String.concat ".") +
          (sprintf " [%d行,%d列目]" funcIdentRange.Start.Line funcIdentRange.Start.Column)

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
                    SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, zeroRange),
                    logFinishCallMethod funcName "res"
                    +> genIdent "res")))
          Some (genTryExpr
            (tryExpr,
             [ genClause ("e", logExn funcName "e" +> (genReraise ())) ],
             range))

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
                +> genLetExpr (
                      "res",
                      SynExpr.App(
                        exprAtomicFlag,
                        isInfix,
                        funcExpr,
                        SynExpr.Paren(SynExpr.Tuple(args, commaRange, trange), x, y, z),
                        zeroRange),
                      logFinishCallMethod funcName "res"
                      +> (genIdent "res")))
            let x =
              (exprs, seed)
              ||> List.foldBack (fun (n, expr) acc ->
                    let name = "arg" + string n
                    genLetExpr (name, expr, acc))
            x

          Some (genTryExpr
            (tryExpr,
             [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
             range))

        // f (x) の考慮 => Paren(expr)
        // f x の考慮   => expr
        | SynExpr.Paren(expr, _, _, _)
        | expr ->
          let tryExpr =
            genLetExpr(
                "args",
                expr,
                logStartCallMethod funcName "args"
                +> (genLetExpr (
                      "res",
                      SynExpr.App(
                        exprAtomicFlag,
                        isInfix,
                        funcExpr,
                        SynExpr.Paren(expr, zeroRange, None, zeroRange),
                        zeroRange),
                      logFinishCallMethod funcName "res"
                      +> genIdent "res")))
          Some (genTryExpr
            (tryExpr,
             [ genClause ("e", logExn funcName "e" +> genReraise ()) ],
             range))

      // その他のSynExpr --> Noneを返す (デフォルトvisit処理）
      | _ ->
        None

  // その他のSynExpr --> Noneを返す (デフォルトvisit処理)
  | _ ->
    None

type InsertLoggingVisitor() =
  inherit DeclareAstFunctionalVisitor(outerVisitor)
