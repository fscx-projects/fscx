//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Thu, 15 Sep 2016 02:37:00 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

/// Construct discriminal union types arguments less.
[<AutoOpen>]
module AstUnionCons =
#if disabl
  let genStringLit lit =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const
      (Microsoft.FSharp.Compiler.Ast.SynConst.String(lit, zeroRange), zeroRange)

  let genIdent name =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident
      (Microsoft.FSharp.Compiler.Ast.Ident(name, zeroRange))

  let genParen x = Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(x, zeroRange, None, zeroRange)

  let genAppFun (name, arg) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic, false, genIdent name, arg, zeroRange)

  let genOpChain (op, operands) =
    operands
    |> List.reduce (fun acc operand ->
       let func =
         Microsoft.FSharp.Compiler.Ast.SynExpr.App
           (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.NonAtomic, true, genIdent op, acc, zeroRange)
       Microsoft.FSharp.Compiler.Ast.SynExpr.App
         (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.NonAtomic, false, func, operand, zeroRange))

  let genCallStaticMethod (mi: MethodInfo, args: SynExpr list) =
    let argExpr =
      match args with
      | [] ->
        Microsoft.FSharp.Compiler.Ast.SynExpr.Const
          (Microsoft.FSharp.Compiler.Ast.SynConst.Unit, zeroRange)
      | [x] -> x
      | xs ->
        Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
          (xs, (List.replicate (xs.Length - 1) zeroRange), zeroRange)
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic,
       false,
       MethodInfo.toIdent mi,
       genParen argExpr,
       zeroRange)

  let genLetExpr (name, value, expr) =
    let binding =
     Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(
      None,
      Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding,
      false,
      false,
      [],
      PreXmlDocEmpty,
      Microsoft.FSharp.Compiler.Ast.SynValData
        (None,
         Microsoft.FSharp.Compiler.Ast.SynValInfo
           ([], Microsoft.FSharp.Compiler.Ast.SynArgInfo([], false, None)),
         None),
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        (Microsoft.FSharp.Compiler.Ast.SynPat.Wild(zeroRange),
         Microsoft.FSharp.Compiler.Ast.Ident(name, zeroRange),
         false,
         None,
         zeroRange),
      None,
      value,
      zeroRange,
      NoSequencePointAtInvisibleBinding)
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(false, false, [binding], expr, zeroRange)

  let genTryExpr (tryExpr, clauses, range) =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(
      tryExpr,
      zeroRange,
      clauses,
      zeroRange,
      zeroRange,
      Microsoft.FSharp.Compiler.Ast.SequencePointAtTry range,  // Make break point data (pdb)
      NoSequencePointAtWith)

  let genClause (identName, expr) =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(
      Microsoft.FSharp.Compiler.Ast.SynPat.Named(
        Microsoft.FSharp.Compiler.Ast.SynPat.Wild(zeroRange),
        Microsoft.FSharp.Compiler.Ast.Ident(identName, zeroRange),
        false,
        None,
        zeroRange),
      None,
      expr,
      zeroRange,
      SuppressSequencePointAtTarget)

  let genReraise () =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App(
      Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag.Atomic,
      false,
      genIdent "reraise",
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        (Microsoft.FSharp.Compiler.Ast.SynExpr.Const
          (Microsoft.FSharp.Compiler.Ast.SynConst.Unit, zeroRange),
         zeroRange, None, zeroRange),
      zeroRange)
#endif

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo.APInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genActivePatternInfo_APInfo item1 item2 item3 =
    Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo.APInfo
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genFSharpImplementationFileDeclaration_Entity item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genFSharpImplementationFileDeclaration_MemberOrFunctionOrValue item1 item2 item3 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Single".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_Single item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Single
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.SingleParameter".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genFSharpToolTipElement_SingleParameter item1 item2 item3 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.SingleParameter
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genFSharpXmlDoc_XmlDocFileSignature item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILAttribElem_Array item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILCallingConv_Callconv item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_FilterCatch item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILExceptionClause_TypeCatch item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_AI_ldc item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldind item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stind item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_brcmp item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_call item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_callvirt item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_callconstraint item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_calli item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_newobj item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldsfld item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldfld item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stsfld item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stfld item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldobj item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stobj item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldelema item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_ldelem_any item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_stelem_any item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_newarr item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_cpblk item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_I_initblk item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILInstr_EI_ldlen_multi item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Custom item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_Array item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILNativeType_SafeArray item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILOverridesSpec_OverridesSpec item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILPermission_PermissionSet item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genILResourceLocation_File item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerEndlineContinuation_Skip item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefAnd item1 item2 =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerIfdefExpression_IfdefOr item1 item2 =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_IfDefSkip item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_String item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_VerbatimString item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_TripleQuoteString item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_Comment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_SingleLineComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_StringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_VerbatimStringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_TripleQuoteStringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.MLOnly".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLexerWhitespaceContinuation_MLOnly item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.MLOnly
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LongIdentWithDots".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LongIdentWithDots".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genLongIdentWithDots id dotms =
    Microsoft.FSharp.Compiler.Ast.LongIdentWithDots
      (id,
       dotms)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genNameArityPair item1 item2 =
    Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.OkResult".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genOperationResult_OkResult item1 item2 =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.OkResult
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.ErrorResult".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genOperationResult_ErrorResult item1 item2 =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.ErrorResult
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedFsiInteraction_IDefns item1 range =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedFsiInteraction_IHash item1 range =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedHashDirective".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedHashDirective".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedHashDirective item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.ParsedHashDirective
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFile".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFile".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFile hashDirectives item2 =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileFragment_AnonModule moduleDecls range =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
      (moduleDecls,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileFragment_NamespaceFragment longId item2 item3 moduleDecls xmlDoc attributes range =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
      (longId,
       item2,
       item3,
       moduleDecls,
       xmlDoc,
       attributes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedImplFileInput filename isScript item3 item4 item5 item6 item7 =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
      (filename,
       isScript,
       item3,
       item4,
       item5,
       item6,
       item7)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFile".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFile".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFile hashDirectives item2 =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileFragment_AnonModule moduleSigDecl range =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
      (moduleSigDecl,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileFragment_NamespaceFragment longId item2 item3 moduleSigDecls xmlDoc attributes range =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
      (longId,
       item2,
       item3,
       moduleSigDecls,
       xmlDoc,
       attributes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genParsedSigFileInput filename item2 item3 item4 item5 =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
      (filename,
       item2,
       item3,
       item4,
       item5)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genPreXmlMerge item1 item2 =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genPreXmlDoc item1 item2 =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ScopedPragma".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genScopedPragma_WarningOff item1 item2 =
    Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynArgInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynArgInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynArgInfo attributes optional id =
    Microsoft.FSharp.Compiler.Ast.SynArgInfo
      (attributes,
       optional,
       id)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBinding".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBinding.Binding".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynBinding_Binding access bindingKind mustInline isMutable attributes xmlDoc item7 headPat item9 expr lhsRange spBind =
    Microsoft.FSharp.Compiler.Ast.SynBinding.Binding
      (access,
       bindingKind,
       mustInline,
       isMutable,
       attributes,
       xmlDoc,
       item7,
       headPat,
       item9,
       expr,
       lhsRange,
       spBind)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynBindingReturnInfo typeName range attributes =
    Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
      (typeName,
       range,
       attributes)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynComponentInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynComponentInfo_ComponentInfo attributes typeParams constraints item4 xmlDoc preferPostfix accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo
      (attributes,
       typeParams,
       constraints,
       item4,
       xmlDoc,
       preferPostfix,
       accessiblity,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.String".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynConst_String text range =
    Microsoft.FSharp.Compiler.Ast.SynConst.String
      (text,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Bytes".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Bytes bytes range =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bytes
      (bytes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Measure".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynConst_Measure constant item2 =
    Microsoft.FSharp.Compiler.Ast.SynConst.Measure
      (constant,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynConstructorArgs_NamePatPairs item1 range =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynEnumCase".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynEnumCase_EnumCase attributes id item3 xmlDoc range =
    Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase
      (attributes,
       id,
       item3,
       xmlDoc,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefn".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefn".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionDefn exnRepr members range =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
      (exnRepr,
       members,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionDefnRepr item1 case longId xmlDoc accesibility range =
    Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
      (item1,
       case,
       longId,
       xmlDoc,
       accesibility,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExceptionSig".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExceptionSig exnRepr memberSigs range =
    Microsoft.FSharp.Compiler.Ast.SynExceptionSig
      (exnRepr,
       memberSigs,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Paren".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Paren expr leftParenRange rightParenRange range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
      (expr,
       leftParenRange,
       rightParenRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Quote".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Quote operator isRaw quotedSynExpr isFromQueryExpression range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
      (operator,
       isRaw,
       quotedSynExpr,
       isFromQueryExpression,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Const".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Const constant range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Typed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Typed expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
      (expr,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Tuple exprs commaRanges range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
      (exprs,
       commaRanges,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArrayOrList isList exprs range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
      (isList,
       exprs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Record".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Record baseInfo copyInfo recordFields range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record
      (baseInfo,
       copyInfo,
       recordFields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.New".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_New isProtected typeName expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New
      (isProtected,
       typeName,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ObjExpr objType argOpt bindings extraImpls newPos range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
      (objType,
       argOpt,
       bindings,
       extraImpls,
       newPos,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.While".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_While spWhile whileBody doBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While
      (spWhile,
       whileBody,
       doBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.For".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_For spFor id idBody item4 toBody doBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.For
      (spFor,
       id,
       idBody,
       item4,
       toBody,
       doBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
      (spFor,
       seqExprOnly,
       isFromSource,
       pattern,
       enumExpr,
       bodyExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArrayOrListOfSeqExpr isList elements range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
      (isList,
       elements,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_CompExpr isArrayOrList isNotNakedRefCell expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
      (isArrayOrList,
       isNotNakedRefCell,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Lambda fromMethod inLambdaSeq args body range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
      (fromMethod,
       inLambdaSeq,
       args,
       body,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_MatchLambda item1 item2 clauses spBind range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
      (item1,
       item2,
       clauses,
       spBind,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Match".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Match spBind matchExpr clauses isCexprExceptionMatch range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match
      (spBind,
       matchExpr,
       clauses,
       isCexprExceptionMatch,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Do".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Do expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Assert".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Assert expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.App".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_App exprAtomicFlag isInfix funcExpr argExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (exprAtomicFlag,
       isInfix,
       funcExpr,
       argExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
      (expr,
       leftAngleRange,
       typeNames,
       commaRanges,
       rightAngleRange,
       typeArgs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LetOrUse isRecursive isUse bindings exprBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
      (isRecursive,
       isUse,
       bindings,
       exprBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TryWith tryExpr item2 item3 item4 range spTry spWith =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
      (tryExpr,
       item2,
       item3,
       item4,
       range,
       spTry,
       spWith)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TryFinally tryExpr finallyExpr range spTry spFinally =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
      (tryExpr,
       finallyExpr,
       range,
       spTry,
       spFinally)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Lazy expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Sequential spSeq isTrueSeq expr1 expr2 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
      (spSeq,
       isTrueSeq,
       expr1,
       expr2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_IfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
      (exprGuard,
       exprThen,
       optionalExprElse,
       spIfToThen,
       isFromErrorRecovery,
       ifToThen,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LongIdent isOptional longIdent altNameRefCell range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent
      (isOptional,
       longIdent,
       altNameRefCell,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LongIdentSet dotId expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
      (dotId,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotGet expr rangeOfDot dotId range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
      (expr,
       rangeOfDot,
       dotId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotSet expr dotId exprValue range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
      (expr,
       dotId,
       exprValue,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotIndexedGet expr indexExprs item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
      (expr,
       indexExprs,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
      (objectExpr,
       indexExprs,
       valueExpr,
       rangeOfLeftOfSet,
       rangeOfDot,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_NamedIndexedPropertySet item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DotNamedIndexedPropertySet item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
      (item1,
       item2,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TypeTest expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Upcast expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
      (expr,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Downcast expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_InferredUpcast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_InferredDowncast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_AddressOf item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_TraitCall item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_JoinIn item1 inPos item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
      (item1,
       inPos,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_YieldOrReturn item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_YieldOrReturnFrom item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
      (spBind,
       isUse,
       isFromSource,
       pattern,
       rhsExpr,
       bodyExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DoBang expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyILAssembly item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
      (item1,
       item2,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyStaticOptimization item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyUnionCaseFieldGet item1 longId item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
      (item1,
       longId,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_LibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
      (item1,
       longId,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_ArbitraryAfterError debugStr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError
      (debugStr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_FromParseError expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_DiscardAfterMissingQualificationAfterDot expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynExpr_Fixed item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynField".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynField.Field".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynField_Field attributes isStatic id typeName item5 xmlDoc accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynField.Field
      (attributes,
       isStatic,
       id,
       typeName,
       item5,
       xmlDoc,
       accessiblity,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynIndexerArg".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynIndexerArg_Two item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynInterfaceImpl_InterfaceImpl item1 bindings range =
    Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
      (item1,
       bindings,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMatchClause".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMatchClause_Clause item1 item2 item3 range spTarget =
    Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
      (item1,
       item2,
       item3,
       range,
       spTarget)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Named".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Named longId range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Named
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Product".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Product item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Seq item1 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Divide item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Power".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Power item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Var".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMeasure_Var item1 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Open longId range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Member memberDefn range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
      (memberDefn,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ImplicitCtor accessiblity attributes ctorArgs selfIdentifier range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
      (accessiblity,
       attributes,
       ctorArgs,
       selfIdentifier,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ImplicitInherit inheritType inheritArgs inheritAlias range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
      (inheritType,
       inheritArgs,
       inheritAlias,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_LetBindings bindings isStatic isRecursive range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
      (bindings,
       isStatic,
       isRecursive,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_AbstractSlot valSig memberFlags range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
      (valSig,
       memberFlags,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Interface typeName interfaceMembers range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
      (typeName,
       interfaceMembers,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_Inherit typeName id range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
      (typeName,
       id,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_ValField field range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
      (field,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_NestedType typeDefn accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
      (typeDefn,
       accessiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberDefn_AutoProperty attributes isStatic id tyOpt propKind memberFlags xmlDoc accessibility expr getSetPos range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
      (attributes,
       isStatic,
       id,
       tyOpt,
       propKind,
       memberFlags,
       xmlDoc,
       accessibility,
       expr,
       getSetPos,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Member item1 memberFlags range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
      (item1,
       memberFlags,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Interface typeName range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_Inherit typeName range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_ValField field range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
      (field,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynMemberSig_NestedType typeDefnSig range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
      (typeDefnSig,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_ModuleAbbrev item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_NestedModule item1 isRec item3 item4 item5 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
      (item1,
       isRec,
       item3,
       item4,
       item5)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Let item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_DoExpr item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Types item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Exception item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Open item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_Attributes item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleDecl_HashDirective item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleOrNamespace id isRec isModule decls xmlDoc attributes access range =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
      (id,
       isRec,
       isModule,
       decls,
       xmlDoc,
       attributes,
       access,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleOrNamespaceSig id isRec isModule item4 xmlDoc attributes item7 range =
    Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
      (id,
       isRec,
       isModule,
       item4,
       xmlDoc,
       attributes,
       item7,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_ModuleAbbrev id longId range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev
      (id,
       longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_NestedModule item1 isRec moduleSigDecls range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
      (item1,
       isRec,
       moduleSigDecls,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Val valSig range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
      (valSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Types typeDefSigs range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
      (typeDefSigs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Exception exnSig range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
      (exnSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_Open longId range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynModuleSigDecl_HashDirective hashDirective range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
      (hashDirective,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Const".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Const constant range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Const
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Named".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Named item1 id isThisVar accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Named
      (item1,
       id,
       isThisVar,
       accessiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Typed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Typed item1 typeName range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Typed
      (item1,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Attrib".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Attrib item1 attributes range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
      (item1,
       attributes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Or".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Or item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Or
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Ands".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Ands item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Ands
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_LongIdent dotId item2 item3 item4 item5 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
      (dotId,
       item2,
       item3,
       item4,
       item5,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Tuple".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Tuple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Paren".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Paren item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Paren
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_ArrayOrList item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Record".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_Record fields range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Record
      (fields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_OptionalVal item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.IsInst".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_IsInst typeName range =
    Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_QuoteExpr expr range =
    Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_DeprecatedCharRange item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_InstanceMember item1 item2 item3 accesiblity range =
    Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
      (item1,
       item2,
       item3,
       accesiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynPat_FromParseError item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynRationalConst_Rational item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynReturnInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynReturnInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynReturnInfo item1 range =
    Microsoft.FSharp.Compiler.Ast.SynReturnInfo
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Id ident altNameRefCell isCompilerGenerated isThisVar isOptArg range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
      (ident,
       altNameRefCell,
       isCompilerGenerated,
       isThisVar,
       isOptArg,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Typed item1 typeName range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
      (item1,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePat_Attrib item1 attributes range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
      (item1,
       attributes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePats_SimplePats item1 range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynSimplePats_Typed item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynStaticOptimizationConstraint_WhenTyparTyconEqualsTycon item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynStaticOptimizationConstraint_WhenTyparIsStruct item1 range =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypar".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypar.Typar".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypar_Typar id staticReq isCompGen =
    Microsoft.FSharp.Compiler.Ast.SynTypar.Typar
      (id,
       staticReq,
       isCompGen)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTyparDecl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTyparDecl_TyparDecl attributes item2 =
    Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
      (attributes,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.App".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_App typeName leftAngleRange typeArgs commaRanges rightAngleRange isPostfix range =
    Microsoft.FSharp.Compiler.Ast.SynType.App
      (typeName,
       leftAngleRange,
       typeArgs,
       commaRanges,
       rightAngleRange,
       isPostfix,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_LongIdentApp typeName dotId leftAngleRange genericNames commaRanges rightAngleRange range =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
      (typeName,
       dotId,
       leftAngleRange,
       genericNames,
       commaRanges,
       rightAngleRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Tuple".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_Tuple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynType.Tuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Array".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_Array item1 elementType range =
    Microsoft.FSharp.Compiler.Ast.SynType.Array
      (item1,
       elementType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Fun".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_Fun argType returnType range =
    Microsoft.FSharp.Compiler.Ast.SynType.Fun
      (argType,
       returnType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Var".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_Var item1 range =
    Microsoft.FSharp.Compiler.Ast.SynType.Var
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_WithGlobalConstraints typeName constraints range =
    Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
      (typeName,
       constraints,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_HashConstraint typeName range =
    Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_MeasureDivide typeName item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
      (typeName,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_MeasurePower typeName item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
      (typeName,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstant constant range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstantExpr expr range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynType_StaticConstantNamed item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsValueType genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsReferenceType genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsUnmanaged genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSupportsNull genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsComparable genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsEquatable genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparDefaultsToType genericName typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
      (genericName,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSubtypeOfType genericName typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
      (genericName,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparSupportsMember genericNames memberSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
      (genericNames,
       memberSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsEnum genericName enumTypes range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
      (genericName,
       enumTypes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeConstraint_WhereTyparIsDelegate genericName delegateTypes range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
      (genericName,
       delegateTypes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefn".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefn_TypeDefn item1 item2 members range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
      (item1,
       item2,
       members,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnKind_TyconDelegate item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnRepr_ObjectModel item1 members range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
      (item1,
       members,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnRepr_Simple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSig_TypeDefnSig item1 item2 memberSigs range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig
      (item1,
       item2,
       memberSigs,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSigRepr_ObjectModel item1 memberSigs range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
      (item1,
       memberSigs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSigRepr_Simple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Union accessiblity cases range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
      (accessiblity,
       cases,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Enum cases range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
      (cases,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_Record accessiblity fields range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
      (accessiblity,
       fields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_General item1 item2 item3 item4 item5 item6 item7 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
      (item1,
       item2,
       item3,
       item4,
       item5,
       item6,
       item7,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_LibraryOnlyILAssembly item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynTypeDefnSimpleRepr_TypeAbbrev item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCase".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynUnionCase_UnionCase attributes id caseType xmlDoc accessibility range =
    Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
      (attributes,
       id,
       caseType,
       xmlDoc,
       accessibility,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValData".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValData".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynValData item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynValData
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValInfo".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynValInfo item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynValInfo
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynValSig_ValSpfn attributes id typeParams typeName valInfo item6 isMutable xmlDoc accessiblity expr range =
    Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
      (attributes,
       id,
       typeParams,
       typeName,
       valInfo,
       item6,
       isMutable,
       xmlDoc,
       accessiblity,
       expr,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValTyparDecls".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValTyparDecls".
  /// </summary>
  /// <returns>Constructed instance.</returns>
  let genSynValTyparDecls item1 item2 constraints =
    Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
      (item1,
       item2,
       constraints)

