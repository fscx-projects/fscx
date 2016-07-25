//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Mon, 25 Jul 2016 09:01:30 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System

/// <summary>
/// FSharp.Compiler.Service's untyped AST visitor.
/// </summary>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstVisitor() =

  /// <summary>
  /// Pre visit "Paren" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitParen parents context expr leftParenRange rightParenRange range =
    expr |> (this.VisitSynExpr parents context), leftParenRange |>, rightParenRange |>, range |>

  abstract member VisitParen: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftParenRange: Microsoft.FSharp.Compiler.Range.range -> rightParenRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Paren" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitParen parents context expr leftParenRange rightParenRange range =
    let args = this.PreVisitParen parents context expr leftParenRange rightParenRange range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren args

  /// <summary>
  /// Pre visit "Quote" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    operator |> (this.VisitSynExpr parents context), isRaw |>, quotedSynExpr |> (this.VisitSynExpr parents context), isFromQueryExpression |>, range |>

  abstract member VisitQuote: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> operator: Microsoft.FSharp.Compiler.Ast.SynExpr -> isRaw: System.Boolean -> quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> isFromQueryExpression: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Quote" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range =
    let args = this.PreVisitQuote parents context operator isRaw quotedSynExpr isFromQueryExpression range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote args

  /// <summary>
  /// Pre visit "Const" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitConst parents context constant range =
    constant |>, range |>

  abstract member VisitConst: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> constant: Microsoft.FSharp.Compiler.Ast.SynConst -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Const" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitConst parents context constant range =
    let args = this.PreVisitConst parents context constant range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const args

  /// <summary>
  /// Pre visit "Typed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTyped parents context expr typeSig range =
    expr |> (this.VisitSynExpr parents context), typeSig |>, range |>

  abstract member VisitTyped: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Typed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTyped parents context expr typeSig range =
    let args = this.PreVisitTyped parents context expr typeSig range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed args

  /// <summary>
  /// Pre visit "Tuple" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTuple parents context exprs commaRanges range =
    exprs |> List.map (this.VisitSynExpr parents context), commaRanges |> List.map, range |>

  abstract member VisitTuple: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Tuple" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTuple parents context exprs commaRanges range =
    let args = this.PreVisitTuple parents context exprs commaRanges range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple args

  /// <summary>
  /// Pre visit "ArrayOrList" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitArrayOrList parents context isList exprs range =
    isList |>, exprs |> List.map (this.VisitSynExpr parents context), range |>

  abstract member VisitArrayOrList: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> exprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrList" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitArrayOrList parents context isList exprs range =
    let args = this.PreVisitArrayOrList parents context isList exprs range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList args

  /// <summary>
  /// Pre visit "Record" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitRecord parents context baseInfo copyInfo recordFields range =
    baseInfo |>, copyInfo |>, recordFields |> List.map, range |>

  abstract member VisitRecord: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> baseInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)> * Microsoft.FSharp.Compiler.Range.range)> -> copyInfo: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>))> -> recordFields: Microsoft.FSharp.Collections.List<((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * System.Boolean) * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> * Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.pos>)>)> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Record" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitRecord parents context baseInfo copyInfo recordFields range =
    let args = this.PreVisitRecord parents context baseInfo copyInfo recordFields range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record args

  /// <summary>
  /// Pre visit "New" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitNew parents context isProtected typeName expr range =
    isProtected |>, typeName |>, expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitNew: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isProtected: System.Boolean -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "New" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitNew parents context isProtected typeName expr range =
    let args = this.PreVisitNew parents context isProtected typeName expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.New args

  /// <summary>
  /// Pre visit "ObjExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    objType |>, argOpt |>, bindings |> List.map, extraImpls |> List.map, newPos |>, range |>

  abstract member VisitObjExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objType: Microsoft.FSharp.Compiler.Ast.SynType -> argOpt: Microsoft.FSharp.Core.Option<(Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.Ident>)> -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> extraImpls: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl> -> newPos: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ObjExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitObjExpr parents context objType argOpt bindings extraImpls newPos range =
    let args = this.PreVisitObjExpr parents context objType argOpt bindings extraImpls newPos range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr args

  /// <summary>
  /// Pre visit "While" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitWhile parents context spWhile whileBody doBody range =
    spWhile |>, whileBody |> (this.VisitSynExpr parents context), doBody |> (this.VisitSynExpr parents context), range |>

  abstract member VisitWhile: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop -> whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "While" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitWhile parents context spWhile whileBody doBody range =
    let args = this.PreVisitWhile parents context spWhile whileBody doBody range
    Microsoft.FSharp.Compiler.Ast.SynExpr.While args

  /// <summary>
  /// Pre visit "For" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitFor parents context spFor id idBody item4 toBody doBody range =
    spFor |>, id |>, idBody |> (this.VisitSynExpr parents context), item4 |>, toBody |> (this.VisitSynExpr parents context), doBody |> (this.VisitSynExpr parents context), range |>

  abstract member VisitFor: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> id: Microsoft.FSharp.Compiler.Ast.Ident -> idBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: System.Boolean -> toBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> doBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "For" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitFor parents context spFor id idBody item4 toBody doBody range =
    let args = this.PreVisitFor parents context spFor id idBody item4 toBody doBody range
    Microsoft.FSharp.Compiler.Ast.SynExpr.For args

  /// <summary>
  /// Pre visit "ForEach" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    spFor |>, seqExprOnly |>, isFromSource |>, pattern |>, enumExpr |> (this.VisitSynExpr parents context), bodyExpr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitForEach: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop -> seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ForEach" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    let args = this.PreVisitForEach parents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach args

  /// <summary>
  /// Pre visit "ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitArrayOrListOfSeqExpr parents context isList elements range =
    isList |>, elements |> (this.VisitSynExpr parents context), range |>

  abstract member VisitArrayOrListOfSeqExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isList: System.Boolean -> elements: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitArrayOrListOfSeqExpr parents context isList elements range =
    let args = this.PreVisitArrayOrListOfSeqExpr parents context isList elements range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr args

  /// <summary>
  /// Pre visit "CompExpr" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    isArrayOrList |>, isNotNakedRefCell |>, expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitCompExpr: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isArrayOrList: System.Boolean -> isNotNakedRefCell: Microsoft.FSharp.Core.Ref<System.Boolean> -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "CompExpr" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range =
    let args = this.PreVisitCompExpr parents context isArrayOrList isNotNakedRefCell expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr args

  /// <summary>
  /// Pre visit "Lambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLambda parents context fromMethod inLambdaSeq args body range =
    fromMethod |>, inLambdaSeq |>, args |>, body |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> fromMethod: System.Boolean -> inLambdaSeq: System.Boolean -> args: Microsoft.FSharp.Compiler.Ast.SynSimplePats -> body: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLambda parents context fromMethod inLambdaSeq args body range =
    let args = this.PreVisitLambda parents context fromMethod inLambdaSeq args body range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda args

  /// <summary>
  /// Pre visit "MatchLambda" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitMatchLambda parents context item1 item2 clauses spBind range =
    item1 |>, item2 |>, clauses |> List.map, spBind |>, range |>

  abstract member VisitMatchLambda: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Range.range -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "MatchLambda" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitMatchLambda parents context item1 item2 clauses spBind range =
    let args = this.PreVisitMatchLambda parents context item1 item2 clauses spBind range
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda args

  /// <summary>
  /// Pre visit "Match" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    spBind |>, matchExpr |> (this.VisitSynExpr parents context), clauses |> List.map, isCexprExceptionMatch |>, range |>

  abstract member VisitMatch: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> clauses: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> isCexprExceptionMatch: System.Boolean -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Match" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range =
    let args = this.PreVisitMatch parents context spBind matchExpr clauses isCexprExceptionMatch range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match args

  /// <summary>
  /// Pre visit "Do" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDo parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitDo: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Do" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDo parents context expr range =
    let args = this.PreVisitDo parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do args

  /// <summary>
  /// Pre visit "Assert" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitAssert parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitAssert: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Assert" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitAssert parents context expr range =
    let args = this.PreVisitAssert parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert args

  /// <summary>
  /// Pre visit "App" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    exprAtomicFlag |>, isInfix |>, funcExpr |> (this.VisitSynExpr parents context), argExpr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag -> isInfix: System.Boolean -> funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "App" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range =
    let args = this.PreVisitApp parents context exprAtomicFlag isInfix funcExpr argExpr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.App args

  /// <summary>
  /// Pre visit "TypeApp" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    expr |> (this.VisitSynExpr parents context), leftAngleRange |>, typeNames |> List.map, commaRanges |> List.map, rightAngleRange |>, typeArgs |>, range |>

  abstract member VisitTypeApp: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> leftAngleRange: Microsoft.FSharp.Compiler.Range.range -> typeNames: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> commaRanges: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Range.range> -> rightAngleRange: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Range.range> -> typeArgs: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeApp" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    let args = this.PreVisitTypeApp parents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp args

  /// <summary>
  /// Pre visit "LetOrUse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    isRecursive |>, isUse |>, bindings |> List.map, exprBody |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLetOrUse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isRecursive: System.Boolean -> isUse: System.Boolean -> bindings: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynBinding> -> exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLetOrUse parents context isRecursive isUse bindings exprBody range =
    let args = this.PreVisitLetOrUse parents context isRecursive isUse bindings exprBody range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse args

  /// <summary>
  /// Pre visit "TryWith" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    tryExpr |> (this.VisitSynExpr parents context), item2 |>, item3 |> List.map, item4 |>, range |>, spTry |>, spWith |>

  abstract member VisitTryWith: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynMatchClause> -> item4: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryWith" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith =
    let args = this.PreVisitTryWith parents context tryExpr item2 item3 item4 range spTry spWith
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith args

  /// <summary>
  /// Pre visit "TryFinally" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    tryExpr |> (this.VisitSynExpr parents context), finallyExpr |> (this.VisitSynExpr parents context), range |>, spTry |>, spFinally |>

  abstract member VisitTryFinally: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry -> spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TryFinally" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTryFinally parents context tryExpr finallyExpr range spTry spFinally =
    let args = this.PreVisitTryFinally parents context tryExpr finallyExpr range spTry spFinally
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally args

  /// <summary>
  /// Pre visit "Lazy" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLazy parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLazy: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Lazy" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLazy parents context expr range =
    let args = this.PreVisitLazy parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy args

  /// <summary>
  /// Pre visit "Sequential" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    spSeq |>, isTrueSeq |>, expr1 |> (this.VisitSynExpr parents context), expr2 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitSequential: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq -> isTrueSeq: System.Boolean -> expr1: Microsoft.FSharp.Compiler.Ast.SynExpr -> expr2: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Sequential" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitSequential parents context spSeq isTrueSeq expr1 expr2 range =
    let args = this.PreVisitSequential parents context spSeq isTrueSeq expr1 expr2 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential args

  /// <summary>
  /// Pre visit "IfThenElse" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    exprGuard |> (this.VisitSynExpr parents context), exprThen |> (this.VisitSynExpr parents context), optionalExprElse |>, spIfToThen |>, isFromErrorRecovery |>, ifToThen |>, range |>

  abstract member VisitIfThenElse: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr -> exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr -> optionalExprElse: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Compiler.Ast.SynExpr> -> spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isFromErrorRecovery: System.Boolean -> ifToThen: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "IfThenElse" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    let args = this.PreVisitIfThenElse parents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse args

  /// <summary>
  /// Pre visit "Ident" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitIdent parents context item =
    item |>

  abstract member VisitIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item: Microsoft.FSharp.Compiler.Ast.Ident -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Ident" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitIdent parents context item =
    let args = this.PreVisitIdent parents context item
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident args

  /// <summary>
  /// Pre visit "LongIdent" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLongIdent parents context isOptional longIdent altNameRefCell range =
    isOptional |>, longIdent |>, altNameRefCell |>, range |>

  abstract member VisitLongIdent: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> isOptional: System.Boolean -> longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> altNameRefCell: Microsoft.FSharp.Core.Option<Microsoft.FSharp.Core.Ref<Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo>> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdent" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLongIdent parents context isOptional longIdent altNameRefCell range =
    let args = this.PreVisitLongIdent parents context isOptional longIdent altNameRefCell range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent args

  /// <summary>
  /// Pre visit "LongIdentSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLongIdentSet parents context dotId expr range =
    dotId |>, expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLongIdentSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LongIdentSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLongIdentSet parents context dotId expr range =
    let args = this.PreVisitLongIdentSet parents context dotId expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet args

  /// <summary>
  /// Pre visit "DotGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDotGet parents context expr rangeOfDot dotId range =
    expr |> (this.VisitSynExpr parents context), rangeOfDot |>, dotId |>, range |>

  abstract member VisitDotGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDotGet parents context expr rangeOfDot dotId range =
    let args = this.PreVisitDotGet parents context expr rangeOfDot dotId range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet args

  /// <summary>
  /// Pre visit "DotSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDotSet parents context expr dotId exprValue range =
    expr |> (this.VisitSynExpr parents context), dotId |>, exprValue |> (this.VisitSynExpr parents context), range |>

  abstract member VisitDotSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDotSet parents context expr dotId exprValue range =
    let args = this.PreVisitDotSet parents context expr dotId exprValue range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet args

  /// <summary>
  /// Pre visit "DotIndexedGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDotIndexedGet parents context expr indexExprs item3 range =
    expr |> (this.VisitSynExpr parents context), indexExprs |> List.map, item3 |>, range |>

  abstract member VisitDotIndexedGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDotIndexedGet parents context expr indexExprs item3 range =
    let args = this.PreVisitDotIndexedGet parents context expr indexExprs item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet args

  /// <summary>
  /// Pre visit "DotIndexedSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    objectExpr |> (this.VisitSynExpr parents context), indexExprs |> List.map, valueExpr |> (this.VisitSynExpr parents context), rangeOfLeftOfSet |>, rangeOfDot |>, range |>

  abstract member VisitDotIndexedSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> indexExprs: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynIndexerArg> -> valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range -> rangeOfDot: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotIndexedSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    let args = this.PreVisitDotIndexedSet parents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet args

  /// <summary>
  /// Pre visit "NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    item1 |>, item2 |> (this.VisitSynExpr parents context), item3 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitNamedIndexedPropertySet parents context item1 item2 item3 range =
    let args = this.PreVisitNamedIndexedPropertySet parents context item1 item2 item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet args

  /// <summary>
  /// Pre visit "DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    item1 |> (this.VisitSynExpr parents context), item2 |>, item3 |> (this.VisitSynExpr parents context), item4 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitDotNamedIndexedPropertySet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range =
    let args = this.PreVisitDotNamedIndexedPropertySet parents context item1 item2 item3 item4 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet args

  /// <summary>
  /// Pre visit "TypeTest" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTypeTest parents context expr typeName range =
    expr |> (this.VisitSynExpr parents context), typeName |>, range |>

  abstract member VisitTypeTest: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TypeTest" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTypeTest parents context expr typeName range =
    let args = this.PreVisitTypeTest parents context expr typeName range
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest args

  /// <summary>
  /// Pre visit "Upcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitUpcast parents context expr typeSig range =
    expr |> (this.VisitSynExpr parents context), typeSig |>, range |>

  abstract member VisitUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeSig: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Upcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitUpcast parents context expr typeSig range =
    let args = this.PreVisitUpcast parents context expr typeSig range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast args

  /// <summary>
  /// Pre visit "Downcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDowncast parents context expr typeName range =
    expr |> (this.VisitSynExpr parents context), typeName |>, range |>

  abstract member VisitDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> typeName: Microsoft.FSharp.Compiler.Ast.SynType -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Downcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDowncast parents context expr typeName range =
    let args = this.PreVisitDowncast parents context expr typeName range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast args

  /// <summary>
  /// Pre visit "InferredUpcast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitInferredUpcast parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitInferredUpcast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredUpcast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitInferredUpcast parents context expr range =
    let args = this.PreVisitInferredUpcast parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast args

  /// <summary>
  /// Pre visit "InferredDowncast" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitInferredDowncast parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitInferredDowncast: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "InferredDowncast" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitInferredDowncast parents context expr range =
    let args = this.PreVisitInferredDowncast parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast args

  /// <summary>
  /// Pre visit "Null" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitNull parents context range =
    range |>

  abstract member VisitNull: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Null" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitNull parents context range =
    let args = this.PreVisitNull parents context range
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null args

  /// <summary>
  /// Pre visit "AddressOf" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitAddressOf parents context item1 item2 item3 range =
    item1 |>, item2 |> (this.VisitSynExpr parents context), item3 |>, range |>

  abstract member VisitAddressOf: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: System.Boolean -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Range.range -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "AddressOf" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitAddressOf parents context item1 item2 item3 range =
    let args = this.PreVisitAddressOf parents context item1 item2 item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf args

  /// <summary>
  /// Pre visit "TraitCall" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitTraitCall parents context item1 item2 item3 range =
    item1 |> List.map, item2 |>, item3 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitTraitCall: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynTypar> -> item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "TraitCall" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitTraitCall parents context item1 item2 item3 range =
    let args = this.PreVisitTraitCall parents context item1 item2 item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall args

  /// <summary>
  /// Pre visit "JoinIn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitJoinIn parents context item1 inPos item3 range =
    item1 |> (this.VisitSynExpr parents context), inPos |>, item3 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitJoinIn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> inPos: Microsoft.FSharp.Compiler.Range.range -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "JoinIn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitJoinIn parents context item1 inPos item3 range =
    let args = this.PreVisitJoinIn parents context item1 inPos item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn args

  /// <summary>
  /// Pre visit "ImplicitZero" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitImplicitZero parents context range =
    range |>

  abstract member VisitImplicitZero: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ImplicitZero" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitImplicitZero parents context range =
    let args = this.PreVisitImplicitZero parents context range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero args

  /// <summary>
  /// Pre visit "YieldOrReturn" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitYieldOrReturn parents context item1 expr range =
    item1 |>, expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitYieldOrReturn: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturn" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitYieldOrReturn parents context item1 expr range =
    let args = this.PreVisitYieldOrReturn parents context item1 expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn args

  /// <summary>
  /// Pre visit "YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitYieldOrReturnFrom parents context item1 expr range =
    item1 |>, expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitYieldOrReturnFrom: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: (System.Boolean * System.Boolean) -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitYieldOrReturnFrom parents context item1 expr range =
    let args = this.PreVisitYieldOrReturnFrom parents context item1 expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom args

  /// <summary>
  /// Pre visit "LetOrUseBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    spBind |>, isUse |>, isFromSource |>, pattern |>, rhsExpr |> (this.VisitSynExpr parents context), bodyExpr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLetOrUseBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding -> isUse: System.Boolean -> isFromSource: System.Boolean -> pattern: Microsoft.FSharp.Compiler.Ast.SynPat -> rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LetOrUseBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    let args = this.PreVisitLetOrUseBang parents context spBind isUse isFromSource pattern rhsExpr bodyExpr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang args

  /// <summary>
  /// Pre visit "DoBang" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDoBang parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitDoBang: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DoBang" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDoBang parents context expr range =
    let args = this.PreVisitDoBang parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang args

  /// <summary>
  /// Pre visit "LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    item1 |>, item2 |> List.map, item3 |> List.map (this.VisitSynExpr parents context), item4 |> List.map, range |>

  abstract member VisitLibraryOnlyILAssembly: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[] -> item2: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> item3: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynExpr> -> item4: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynType> -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range =
    let args = this.PreVisitLibraryOnlyILAssembly parents context item1 item2 item3 item4 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly args

  /// <summary>
  /// Pre visit "LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    item1 |> List.map, item2 |> (this.VisitSynExpr parents context), item3 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLibraryOnlyStaticOptimization: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint> -> item2: Microsoft.FSharp.Compiler.Ast.SynExpr -> item3: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range =
    let args = this.PreVisitLibraryOnlyStaticOptimization parents context item1 item2 item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization args

  /// <summary>
  /// Pre visit "LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    item1 |> (this.VisitSynExpr parents context), longId |> List.map, item3 |>, range |>

  abstract member VisitLibraryOnlyUnionCaseFieldGet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range =
    let args = this.PreVisitLibraryOnlyUnionCaseFieldGet parents context item1 longId item3 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet args

  /// <summary>
  /// Pre visit "LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    item1 |> (this.VisitSynExpr parents context), longId |> List.map, item3 |>, item4 |> (this.VisitSynExpr parents context), range |>

  abstract member VisitLibraryOnlyUnionCaseFieldSet: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> longId: Microsoft.FSharp.Collections.List<Microsoft.FSharp.Compiler.Ast.Ident> -> item3: System.Int32 -> item4: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range =
    let args = this.PreVisitLibraryOnlyUnionCaseFieldSet parents context item1 longId item3 item4 range
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet args

  /// <summary>
  /// Pre visit "ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitArbitraryAfterError parents context debugStr range =
    debugStr |>, range |>

  abstract member VisitArbitraryAfterError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> debugStr: System.String -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitArbitraryAfterError parents context debugStr range =
    let args = this.PreVisitArbitraryAfterError parents context debugStr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError args

  /// <summary>
  /// Pre visit "FromParseError" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitFromParseError parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitFromParseError: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "FromParseError" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitFromParseError parents context expr range =
    let args = this.PreVisitFromParseError parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError args

  /// <summary>
  /// Pre visit "DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    expr |> (this.VisitSynExpr parents context), range |>

  abstract member VisitDiscardAfterMissingQualificationAfterDot: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> expr: Microsoft.FSharp.Compiler.Ast.SynExpr -> range: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitDiscardAfterMissingQualificationAfterDot parents context expr range =
    let args = this.PreVisitDiscardAfterMissingQualificationAfterDot parents context expr range
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot args

  /// <summary>
  /// Pre visit "Fixed" arguments.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Pre visited arguments.</returns>
  member this.PreVisitFixed parents context item1 item2 =
    item1 |> (this.VisitSynExpr parents context), item2 |>

  abstract member VisitFixed: parents: Microsoft.FSharp.Compiler.Ast.SynExpr list -> context: 'TContext -> item1: Microsoft.FSharp.Compiler.Ast.SynExpr -> item2: Microsoft.FSharp.Compiler.Range.range -> Microsoft.FSharp.Compiler.Ast.SynExpr

  /// <summary>
  /// Visit "Fixed" expression.
  /// </summary>
  /// <param name="parents">Parent expression list.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed (or target) expression.</returns>
  default this.VisitFixed parents context item1 item2 =
    let args = this.PreVisitFixed parents context item1 item2
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed args


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
      this.VisitParen currentParents context expr leftParenRange rightParenRange range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      this.VisitQuote currentParents context operator isRaw quotedSynExpr isFromQueryExpression range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      this.VisitConst currentParents context constant range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      this.VisitTyped currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      this.VisitTuple currentParents context exprs commaRanges range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      this.VisitArrayOrList currentParents context isList exprs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      this.VisitRecord currentParents context baseInfo copyInfo recordFields range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      this.VisitNew currentParents context isProtected typeName expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      this.VisitObjExpr currentParents context objType argOpt bindings extraImpls newPos range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      this.VisitWhile currentParents context spWhile whileBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      this.VisitFor currentParents context spFor id idBody item4 toBody doBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      this.VisitForEach currentParents context spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      this.VisitArrayOrListOfSeqExpr currentParents context isList elements range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      this.VisitCompExpr currentParents context isArrayOrList isNotNakedRefCell expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      this.VisitLambda currentParents context fromMethod inLambdaSeq args body range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      this.VisitMatchLambda currentParents context item1 item2 clauses spBind range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      this.VisitMatch currentParents context spBind matchExpr clauses isCexprExceptionMatch range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      this.VisitDo currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      this.VisitAssert currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      this.VisitApp currentParents context exprAtomicFlag isInfix funcExpr argExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      this.VisitTypeApp currentParents context expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      this.VisitLetOrUse currentParents context isRecursive isUse bindings exprBody range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      this.VisitTryWith currentParents context tryExpr item2 item3 item4 range spTry spWith
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      this.VisitTryFinally currentParents context tryExpr finallyExpr range spTry spFinally
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      this.VisitLazy currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      this.VisitSequential currentParents context spSeq isTrueSeq expr1 expr2 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      this.VisitIfThenElse currentParents context exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
      this.VisitIdent currentParents context item
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      this.VisitLongIdent currentParents context isOptional longIdent altNameRefCell range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      this.VisitLongIdentSet currentParents context dotId expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      this.VisitDotGet currentParents context expr rangeOfDot dotId range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      this.VisitDotSet currentParents context expr dotId exprValue range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      this.VisitDotIndexedGet currentParents context expr indexExprs item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      this.VisitDotIndexedSet currentParents context objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      this.VisitNamedIndexedPropertySet currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      this.VisitDotNamedIndexedPropertySet currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      this.VisitTypeTest currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      this.VisitUpcast currentParents context expr typeSig range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      this.VisitDowncast currentParents context expr typeName range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      this.VisitInferredUpcast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      this.VisitInferredDowncast currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
      this.VisitNull currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      this.VisitAddressOf currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      this.VisitTraitCall currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      this.VisitJoinIn currentParents context item1 inPos item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
      this.VisitImplicitZero currentParents context range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      this.VisitYieldOrReturn currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      this.VisitYieldOrReturnFrom currentParents context item1 expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      this.VisitLetOrUseBang currentParents context spBind isUse isFromSource pattern rhsExpr bodyExpr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      this.VisitDoBang currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      this.VisitLibraryOnlyILAssembly currentParents context item1 item2 item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      this.VisitLibraryOnlyStaticOptimization currentParents context item1 item2 item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      this.VisitLibraryOnlyUnionCaseFieldGet currentParents context item1 longId item3 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      this.VisitLibraryOnlyUnionCaseFieldSet currentParents context item1 longId item3 item4 range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
      this.VisitArbitraryAfterError currentParents context debugStr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      this.VisitFromParseError currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      this.VisitDiscardAfterMissingQualificationAfterDot currentParents context expr range
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      this.VisitFixed currentParents context item1 item2

