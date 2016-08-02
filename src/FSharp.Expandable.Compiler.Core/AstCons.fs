//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 02 Aug 2016 04:47:05 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast

//////////////////////////////////////////////

/// <summary>
/// LexerEndlineContinuation cons definitions.
/// </summary>
[<AutoOpen>]
module LexerEndlineContinuation =
  /// <summary>
  /// Construct "LexerEndlineContinuation.Skip".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSkip item1 item2 range =
    LexerEndlineContinuation.Skip(item1, item2, range)
  /// <summary>
  /// Construct "LexerEndlineContinuation.Token".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initToken item =
    LexerEndlineContinuation.Token(item)

//////////////////////////////////////////////

/// <summary>
/// LexerIfdefExpression cons definitions.
/// </summary>
[<AutoOpen>]
module LexerIfdefExpression =
  /// <summary>
  /// Construct "LexerIfdefExpression.IfdefAnd".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfdefAnd item1 item2 =
    LexerIfdefExpression.IfdefAnd(item1, item2)
  /// <summary>
  /// Construct "LexerIfdefExpression.IfdefId".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfdefId item =
    LexerIfdefExpression.IfdefId(item)
  /// <summary>
  /// Construct "LexerIfdefExpression.IfdefNot".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfdefNot item =
    LexerIfdefExpression.IfdefNot(item)
  /// <summary>
  /// Construct "LexerIfdefExpression.IfdefOr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfdefOr item1 item2 =
    LexerIfdefExpression.IfdefOr(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// LexerIfdefStackEntry cons definitions.
/// </summary>
[<AutoOpen>]
module LexerIfdefStackEntry =
  /// <summary>
  /// Construct "LexerIfdefStackEntry.IfDefElse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfDefElse () =
    LexerIfdefStackEntry.IfDefElse
  /// <summary>
  /// Construct "LexerIfdefStackEntry.IfDefIf".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfDefIf () =
    LexerIfdefStackEntry.IfDefIf

//////////////////////////////////////////////

/// <summary>
/// LexerWhitespaceContinuation cons definitions.
/// </summary>
[<AutoOpen>]
module LexerWhitespaceContinuation =
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.Comment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initComment item1 item2 range =
    LexerWhitespaceContinuation.Comment(item1, item2, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.EndLine".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initEndLine item =
    LexerWhitespaceContinuation.EndLine(item)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.IfDefSkip".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfDefSkip item1 item2 range =
    LexerWhitespaceContinuation.IfDefSkip(item1, item2, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.MLOnly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMLOnly item1 range =
    LexerWhitespaceContinuation.MLOnly(item1, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.SingleLineComment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSingleLineComment item1 item2 range =
    LexerWhitespaceContinuation.SingleLineComment(item1, item2, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.String".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initString item1 range =
    LexerWhitespaceContinuation.String(item1, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.StringInComment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initStringInComment item1 item2 range =
    LexerWhitespaceContinuation.StringInComment(item1, item2, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.Token".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initToken item =
    LexerWhitespaceContinuation.Token(item)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.TripleQuoteString".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTripleQuoteString item1 range =
    LexerWhitespaceContinuation.TripleQuoteString(item1, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.TripleQuoteStringInComment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTripleQuoteStringInComment item1 item2 range =
    LexerWhitespaceContinuation.TripleQuoteStringInComment(item1, item2, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.VerbatimString".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initVerbatimString item1 range =
    LexerWhitespaceContinuation.VerbatimString(item1, range)
  /// <summary>
  /// Construct "LexerWhitespaceContinuation.VerbatimStringInComment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initVerbatimStringInComment item1 item2 range =
    LexerWhitespaceContinuation.VerbatimStringInComment(item1, item2, range)

//////////////////////////////////////////////

/// <summary>
/// LongIdentWithDots cons definitions.
/// </summary>
[<AutoOpen>]
module LongIdentWithDots =
  /// <summary>
  /// Construct "LongIdentWithDots.LongIdentWithDots".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdentWithDots id dotms =
    LongIdentWithDots.LongIdentWithDots(id, dotms)

//////////////////////////////////////////////

/// <summary>
/// MemberKind cons definitions.
/// </summary>
[<AutoOpen>]
module MemberKind =
  /// <summary>
  /// Construct "MemberKind.ClassConstructor".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initClassConstructor () =
    MemberKind.ClassConstructor
  /// <summary>
  /// Construct "MemberKind.Constructor".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initConstructor () =
    MemberKind.Constructor
  /// <summary>
  /// Construct "MemberKind.Member".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMember () =
    MemberKind.Member
  /// <summary>
  /// Construct "MemberKind.PropertyGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPropertyGet () =
    MemberKind.PropertyGet
  /// <summary>
  /// Construct "MemberKind.PropertyGetSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPropertyGetSet () =
    MemberKind.PropertyGetSet
  /// <summary>
  /// Construct "MemberKind.PropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPropertySet () =
    MemberKind.PropertySet

//////////////////////////////////////////////

/// <summary>
/// ParsedFsiInteraction cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedFsiInteraction =
  /// <summary>
  /// Construct "ParsedFsiInteraction.IDefns".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIDefns item1 range =
    ParsedFsiInteraction.IDefns(item1, range)
  /// <summary>
  /// Construct "ParsedFsiInteraction.IHash".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIHash item1 range =
    ParsedFsiInteraction.IHash(item1, range)

//////////////////////////////////////////////

/// <summary>
/// ParsedHashDirective cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedHashDirective =
  /// <summary>
  /// Construct "ParsedHashDirective.ParsedHashDirective".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParsedHashDirective item1 item2 range =
    ParsedHashDirective.ParsedHashDirective(item1, item2, range)

//////////////////////////////////////////////

/// <summary>
/// ParsedImplFile cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedImplFile =
  /// <summary>
  /// Construct "ParsedImplFile.ParsedImplFile".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParsedImplFile hashDirectives item2 =
    ParsedImplFile.ParsedImplFile(hashDirectives, item2)

//////////////////////////////////////////////

/// <summary>
/// ParsedImplFileFragment cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedImplFileFragment =
  /// <summary>
  /// Construct "ParsedImplFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAnonModule moduleDecls range =
    ParsedImplFileFragment.AnonModule(moduleDecls, range)
  /// <summary>
  /// Construct "ParsedImplFileFragment.NamedModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamedModule item =
    ParsedImplFileFragment.NamedModule(item)
  /// <summary>
  /// Construct "ParsedImplFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamespaceFragment longId item2 item3 moduleDecls xmlDoc attributes range =
    ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range)

//////////////////////////////////////////////

/// <summary>
/// ParsedImplFileInput cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedImplFileInput =
  /// <summary>
  /// Construct "ParsedImplFileInput.ParsedImplFileInput".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParsedImplFileInput filename isScript item3 item4 item5 item6 item7 =
    ParsedImplFileInput.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7)

//////////////////////////////////////////////

/// <summary>
/// ParsedInput cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedInput =
  /// <summary>
  /// Construct "ParsedInput.ImplFile".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplFile item =
    ParsedInput.ImplFile(item)
  /// <summary>
  /// Construct "ParsedInput.SigFile".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSigFile item =
    ParsedInput.SigFile(item)

//////////////////////////////////////////////

/// <summary>
/// ParsedSigFile cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedSigFile =
  /// <summary>
  /// Construct "ParsedSigFile.ParsedSigFile".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParsedSigFile hashDirectives item2 =
    ParsedSigFile.ParsedSigFile(hashDirectives, item2)

//////////////////////////////////////////////

/// <summary>
/// ParsedSigFileFragment cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedSigFileFragment =
  /// <summary>
  /// Construct "ParsedSigFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAnonModule moduleSigDecl range =
    ParsedSigFileFragment.AnonModule(moduleSigDecl, range)
  /// <summary>
  /// Construct "ParsedSigFileFragment.NamedModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamedModule item =
    ParsedSigFileFragment.NamedModule(item)
  /// <summary>
  /// Construct "ParsedSigFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamespaceFragment longId item2 item3 moduleSigDecls xmlDoc attributes range =
    ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range)

//////////////////////////////////////////////

/// <summary>
/// ParsedSigFileInput cons definitions.
/// </summary>
[<AutoOpen>]
module ParsedSigFileInput =
  /// <summary>
  /// Construct "ParsedSigFileInput.ParsedSigFileInput".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParsedSigFileInput filename item2 item3 item4 item5 =
    ParsedSigFileInput.ParsedSigFileInput(filename, item2, item3, item4, item5)

//////////////////////////////////////////////

/// <summary>
/// ParserDetail cons definitions.
/// </summary>
[<AutoOpen>]
module ParserDetail =
  /// <summary>
  /// Construct "ParserDetail.Ok".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOk () =
    ParserDetail.Ok
  /// <summary>
  /// Construct "ParserDetail.ThereWereSignificantParseErrorsSoDoNotTypecheckThisNode".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initThereWereSignificantParseErrorsSoDoNotTypecheckThisNode () =
    ParserDetail.ThereWereSignificantParseErrorsSoDoNotTypecheckThisNode

//////////////////////////////////////////////

/// <summary>
/// PreXmlDoc cons definitions.
/// </summary>
[<AutoOpen>]
module PreXmlDoc =
  /// <summary>
  /// Construct "PreXmlDoc.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPreXmlDoc item1 item2 =
    PreXmlDoc.PreXmlDoc(item1, item2)
  /// <summary>
  /// Construct "PreXmlDoc.PreXmlDocEmpty".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPreXmlDocEmpty () =
    PreXmlDoc.PreXmlDocEmpty
  /// <summary>
  /// Construct "PreXmlDoc.PreXmlMerge".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPreXmlMerge item1 item2 =
    PreXmlDoc.PreXmlMerge(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// QualifiedNameOfFile cons definitions.
/// </summary>
[<AutoOpen>]
module QualifiedNameOfFile =
  /// <summary>
  /// Construct "QualifiedNameOfFile.QualifiedNameOfFile".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initQualifiedNameOfFile item =
    QualifiedNameOfFile.QualifiedNameOfFile(item)

//////////////////////////////////////////////

/// <summary>
/// ScopedPragma cons definitions.
/// </summary>
[<AutoOpen>]
module ScopedPragma =
  /// <summary>
  /// Construct "ScopedPragma.WarningOff".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWarningOff item1 item2 =
    ScopedPragma.WarningOff(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// SeqExprOnly cons definitions.
/// </summary>
[<AutoOpen>]
module SeqExprOnly =
  /// <summary>
  /// Construct "SeqExprOnly.SeqExprOnly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSeqExprOnly item =
    SeqExprOnly.SeqExprOnly(item)

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForBinding cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForBinding =
  /// <summary>
  /// Construct "SequencePointInfoForBinding.NoSequencePointAtDoBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtDoBinding () =
    SequencePointInfoForBinding.NoSequencePointAtDoBinding
  /// <summary>
  /// Construct "SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtInvisibleBinding () =
    SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding
  /// <summary>
  /// Construct "SequencePointInfoForBinding.NoSequencePointAtLetBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtLetBinding () =
    SequencePointInfoForBinding.NoSequencePointAtLetBinding
  /// <summary>
  /// Construct "SequencePointInfoForBinding.NoSequencePointAtStickyBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtStickyBinding () =
    SequencePointInfoForBinding.NoSequencePointAtStickyBinding
  /// <summary>
  /// Construct "SequencePointInfoForBinding.SequencePointAtBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtBinding item =
    SequencePointInfoForBinding.SequencePointAtBinding(item)

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForFinally cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForFinally =
  /// <summary>
  /// Construct "SequencePointInfoForFinally.NoSequencePointAtFinally".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtFinally () =
    SequencePointInfoForFinally.NoSequencePointAtFinally
  /// <summary>
  /// Construct "SequencePointInfoForFinally.SequencePointAtFinally".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtFinally item =
    SequencePointInfoForFinally.SequencePointAtFinally(item)

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForForLoop cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForForLoop =
  /// <summary>
  /// Construct "SequencePointInfoForForLoop.NoSequencePointAtForLoop".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtForLoop () =
    SequencePointInfoForForLoop.NoSequencePointAtForLoop
  /// <summary>
  /// Construct "SequencePointInfoForForLoop.SequencePointAtForLoop".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtForLoop item =
    SequencePointInfoForForLoop.SequencePointAtForLoop(item)

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForSeq cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForSeq =
  /// <summary>
  /// Construct "SequencePointInfoForSeq.SequencePointsAtSeq".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointsAtSeq () =
    SequencePointInfoForSeq.SequencePointsAtSeq
  /// <summary>
  /// Construct "SequencePointInfoForSeq.SuppressSequencePointOnExprOfSequential".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSuppressSequencePointOnExprOfSequential () =
    SequencePointInfoForSeq.SuppressSequencePointOnExprOfSequential
  /// <summary>
  /// Construct "SequencePointInfoForSeq.SuppressSequencePointOnStmtOfSequential".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSuppressSequencePointOnStmtOfSequential () =
    SequencePointInfoForSeq.SuppressSequencePointOnStmtOfSequential

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForTarget cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForTarget =
  /// <summary>
  /// Construct "SequencePointInfoForTarget.SequencePointAtTarget".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtTarget () =
    SequencePointInfoForTarget.SequencePointAtTarget
  /// <summary>
  /// Construct "SequencePointInfoForTarget.SuppressSequencePointAtTarget".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSuppressSequencePointAtTarget () =
    SequencePointInfoForTarget.SuppressSequencePointAtTarget

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForTry cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForTry =
  /// <summary>
  /// Construct "SequencePointInfoForTry.NoSequencePointAtTry".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtTry () =
    SequencePointInfoForTry.NoSequencePointAtTry
  /// <summary>
  /// Construct "SequencePointInfoForTry.SequencePointAtTry".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtTry item =
    SequencePointInfoForTry.SequencePointAtTry(item)
  /// <summary>
  /// Construct "SequencePointInfoForTry.SequencePointInBodyOfTry".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointInBodyOfTry () =
    SequencePointInfoForTry.SequencePointInBodyOfTry

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForWhileLoop cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForWhileLoop =
  /// <summary>
  /// Construct "SequencePointInfoForWhileLoop.NoSequencePointAtWhileLoop".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtWhileLoop () =
    SequencePointInfoForWhileLoop.NoSequencePointAtWhileLoop
  /// <summary>
  /// Construct "SequencePointInfoForWhileLoop.SequencePointAtWhileLoop".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtWhileLoop item =
    SequencePointInfoForWhileLoop.SequencePointAtWhileLoop(item)

//////////////////////////////////////////////

/// <summary>
/// SequencePointInfoForWith cons definitions.
/// </summary>
[<AutoOpen>]
module SequencePointInfoForWith =
  /// <summary>
  /// Construct "SequencePointInfoForWith.NoSequencePointAtWith".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoSequencePointAtWith () =
    SequencePointInfoForWith.NoSequencePointAtWith
  /// <summary>
  /// Construct "SequencePointInfoForWith.SequencePointAtWith".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequencePointAtWith item =
    SequencePointInfoForWith.SequencePointAtWith(item)

//////////////////////////////////////////////

/// <summary>
/// SynAccess cons definitions.
/// </summary>
[<AutoOpen>]
module SynAccess =
  /// <summary>
  /// Construct "SynAccess.Internal".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInternal () =
    SynAccess.Internal
  /// <summary>
  /// Construct "SynAccess.Private".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPrivate () =
    SynAccess.Private
  /// <summary>
  /// Construct "SynAccess.Public".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPublic () =
    SynAccess.Public

//////////////////////////////////////////////

/// <summary>
/// SynArgInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynArgInfo =
  /// <summary>
  /// Construct "SynArgInfo.SynArgInfo".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynArgInfo attributes optional id =
    SynArgInfo.SynArgInfo(attributes, optional, id)

//////////////////////////////////////////////

/// <summary>
/// SynBinding cons definitions.
/// </summary>
[<AutoOpen>]
module SynBinding =
  /// <summary>
  /// Construct "SynBinding.Binding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initBinding access bindingKind mustInline isMutable attributes xmlDoc item7 headPat item9 expr lhsRange spBind =
    SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)

//////////////////////////////////////////////

/// <summary>
/// SynBindingKind cons definitions.
/// </summary>
[<AutoOpen>]
module SynBindingKind =
  /// <summary>
  /// Construct "SynBindingKind.DoBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDoBinding () =
    SynBindingKind.DoBinding
  /// <summary>
  /// Construct "SynBindingKind.NormalBinding".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNormalBinding () =
    SynBindingKind.NormalBinding
  /// <summary>
  /// Construct "SynBindingKind.StandaloneExpression".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initStandaloneExpression () =
    SynBindingKind.StandaloneExpression

//////////////////////////////////////////////

/// <summary>
/// SynBindingReturnInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynBindingReturnInfo =
  /// <summary>
  /// Construct "SynBindingReturnInfo.SynBindingReturnInfo".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynBindingReturnInfo typeName range attributes =
    SynBindingReturnInfo.SynBindingReturnInfo(typeName, range, attributes)

//////////////////////////////////////////////

/// <summary>
/// SynComponentInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynComponentInfo =
  /// <summary>
  /// Construct "SynComponentInfo.ComponentInfo".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initComponentInfo attributes typeParams constraints item4 xmlDoc preferPostfix accessiblity range =
    SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)

//////////////////////////////////////////////

/// <summary>
/// SynConst cons definitions.
/// </summary>
[<AutoOpen>]
module SynConst =
  /// <summary>
  /// Construct "SynConst.Bool".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initBool item =
    SynConst.Bool(item)
  /// <summary>
  /// Construct "SynConst.Byte".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initByte item =
    SynConst.Byte(item)
  /// <summary>
  /// Construct "SynConst.Bytes".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initBytes bytes range =
    SynConst.Bytes(bytes, range)
  /// <summary>
  /// Construct "SynConst.Char".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initChar item =
    SynConst.Char(item)
  /// <summary>
  /// Construct "SynConst.Decimal".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDecimal item =
    SynConst.Decimal(item)
  /// <summary>
  /// Construct "SynConst.Double".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDouble item =
    SynConst.Double(item)
  /// <summary>
  /// Construct "SynConst.Int16".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInt16 item =
    SynConst.Int16(item)
  /// <summary>
  /// Construct "SynConst.Int32".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInt32 item =
    SynConst.Int32(item)
  /// <summary>
  /// Construct "SynConst.Int64".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInt64 item =
    SynConst.Int64(item)
  /// <summary>
  /// Construct "SynConst.IntPtr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIntPtr item =
    SynConst.IntPtr(item)
  /// <summary>
  /// Construct "SynConst.Measure".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMeasure constant item2 =
    SynConst.Measure(constant, item2)
  /// <summary>
  /// Construct "SynConst.SByte".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSByte item =
    SynConst.SByte(item)
  /// <summary>
  /// Construct "SynConst.Single".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSingle item =
    SynConst.Single(item)
  /// <summary>
  /// Construct "SynConst.String".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initString text range =
    SynConst.String(text, range)
  /// <summary>
  /// Construct "SynConst.UInt16".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUInt16 item =
    SynConst.UInt16(item)
  /// <summary>
  /// Construct "SynConst.UInt16s".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUInt16s item =
    SynConst.UInt16s(item)
  /// <summary>
  /// Construct "SynConst.UInt32".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUInt32 item =
    SynConst.UInt32(item)
  /// <summary>
  /// Construct "SynConst.UInt64".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUInt64 item =
    SynConst.UInt64(item)
  /// <summary>
  /// Construct "SynConst.UIntPtr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUIntPtr item =
    SynConst.UIntPtr(item)
  /// <summary>
  /// Construct "SynConst.Unit".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUnit () =
    SynConst.Unit
  /// <summary>
  /// Construct "SynConst.UserNum".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUserNum item =
    SynConst.UserNum(item)

//////////////////////////////////////////////

/// <summary>
/// SynConstructorArgs cons definitions.
/// </summary>
[<AutoOpen>]
module SynConstructorArgs =
  /// <summary>
  /// Construct "SynConstructorArgs.NamePatPairs".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamePatPairs item1 range =
    SynConstructorArgs.NamePatPairs(item1, range)
  /// <summary>
  /// Construct "SynConstructorArgs.Pats".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPats item =
    SynConstructorArgs.Pats(item)

//////////////////////////////////////////////

/// <summary>
/// SynEnumCase cons definitions.
/// </summary>
[<AutoOpen>]
module SynEnumCase =
  /// <summary>
  /// Construct "SynEnumCase.EnumCase".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initEnumCase attributes id item3 xmlDoc range =
    SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range)

//////////////////////////////////////////////

/// <summary>
/// SynExceptionDefn cons definitions.
/// </summary>
[<AutoOpen>]
module SynExceptionDefn =
  /// <summary>
  /// Construct "SynExceptionDefn.SynExceptionDefn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynExceptionDefn exnRepr members range =
    SynExceptionDefn.SynExceptionDefn(exnRepr, members, range)

//////////////////////////////////////////////

/// <summary>
/// SynExceptionDefnRepr cons definitions.
/// </summary>
[<AutoOpen>]
module SynExceptionDefnRepr =
  /// <summary>
  /// Construct "SynExceptionDefnRepr.SynExceptionDefnRepr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynExceptionDefnRepr item1 case longId xmlDoc accesibility range =
    SynExceptionDefnRepr.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range)

//////////////////////////////////////////////

/// <summary>
/// SynExceptionSig cons definitions.
/// </summary>
[<AutoOpen>]
module SynExceptionSig =
  /// <summary>
  /// Construct "SynExceptionSig.SynExceptionSig".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynExceptionSig exnRepr memberSigs range =
    SynExceptionSig.SynExceptionSig(exnRepr, memberSigs, range)

//////////////////////////////////////////////

/// <summary>
/// SynExpr cons definitions.
/// </summary>
[<AutoOpen>]
module SynExpr =
  /// <summary>
  /// Construct "SynExpr.AddressOf".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAddressOf item1 item2 item3 range =
    SynExpr.AddressOf(item1, item2, item3, range)
  /// <summary>
  /// Construct "SynExpr.App".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initApp exprAtomicFlag isInfix funcExpr argExpr range =
    SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)
  /// <summary>
  /// Construct "SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArbitraryAfterError debugStr range =
    SynExpr.ArbitraryAfterError(debugStr, range)
  /// <summary>
  /// Construct "SynExpr.ArrayOrList".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrList isList exprs range =
    SynExpr.ArrayOrList(isList, exprs, range)
  /// <summary>
  /// Construct "SynExpr.ArrayOrListOfSeqExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrListOfSeqExpr isList elements range =
    SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)
  /// <summary>
  /// Construct "SynExpr.Assert".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAssert expr range =
    SynExpr.Assert(expr, range)
  /// <summary>
  /// Construct "SynExpr.CompExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initCompExpr isArrayOrList isNotNakedRefCell expr range =
    SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)
  /// <summary>
  /// Construct "SynExpr.Const".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initConst constant range =
    SynExpr.Const(constant, range)
  /// <summary>
  /// Construct "SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDiscardAfterMissingQualificationAfterDot expr range =
    SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)
  /// <summary>
  /// Construct "SynExpr.Do".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDo expr range =
    SynExpr.Do(expr, range)
  /// <summary>
  /// Construct "SynExpr.DoBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDoBang expr range =
    SynExpr.DoBang(expr, range)
  /// <summary>
  /// Construct "SynExpr.DotGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotGet expr rangeOfDot dotId range =
    SynExpr.DotGet(expr, rangeOfDot, dotId, range)
  /// <summary>
  /// Construct "SynExpr.DotIndexedGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedGet expr indexExprs item3 range =
    SynExpr.DotIndexedGet(expr, indexExprs, item3, range)
  /// <summary>
  /// Construct "SynExpr.DotIndexedSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
    SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
  /// <summary>
  /// Construct "SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotNamedIndexedPropertySet item1 item2 item3 item4 range =
    SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)
  /// <summary>
  /// Construct "SynExpr.DotSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDotSet expr dotId exprValue range =
    SynExpr.DotSet(expr, dotId, exprValue, range)
  /// <summary>
  /// Construct "SynExpr.Downcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDowncast expr typeName range =
    SynExpr.Downcast(expr, typeName, range)
  /// <summary>
  /// Construct "SynExpr.Fixed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFixed item1 item2 =
    SynExpr.Fixed(item1, item2)
  /// <summary>
  /// Construct "SynExpr.For".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFor spFor id idBody item4 toBody doBody range =
    SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)
  /// <summary>
  /// Construct "SynExpr.ForEach".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
    SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)
  /// <summary>
  /// Construct "SynExpr.FromParseError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFromParseError expr range =
    SynExpr.FromParseError(expr, range)
  /// <summary>
  /// Construct "SynExpr.Ident".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIdent item =
    SynExpr.Ident(item)
  /// <summary>
  /// Construct "SynExpr.IfThenElse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)
  /// <summary>
  /// Construct "SynExpr.ImplicitZero".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplicitZero range =
    SynExpr.ImplicitZero(range)
  /// <summary>
  /// Construct "SynExpr.InferredDowncast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredDowncast expr range =
    SynExpr.InferredDowncast(expr, range)
  /// <summary>
  /// Construct "SynExpr.InferredUpcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInferredUpcast expr range =
    SynExpr.InferredUpcast(expr, range)
  /// <summary>
  /// Construct "SynExpr.JoinIn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initJoinIn item1 inPos item3 range =
    SynExpr.JoinIn(item1, inPos, item3, range)
  /// <summary>
  /// Construct "SynExpr.Lambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLambda fromMethod inLambdaSeq args body range =
    SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)
  /// <summary>
  /// Construct "SynExpr.Lazy".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLazy expr range =
    SynExpr.Lazy(expr, range)
  /// <summary>
  /// Construct "SynExpr.LetOrUse".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUse isRecursive isUse bindings exprBody range =
    SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)
  /// <summary>
  /// Construct "SynExpr.LetOrUseBang".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range =
    SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)
  /// <summary>
  /// Construct "SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyILAssembly item1 item2 item3 item4 range =
    SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)
  /// <summary>
  /// Construct "SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyStaticOptimization item1 item2 item3 range =
    SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)
  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldGet item1 longId item3 range =
    SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)
  /// <summary>
  /// Construct "SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range =
    SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)
  /// <summary>
  /// Construct "SynExpr.LongIdent".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdent isOptional longIdent altNameRefCell range =
    SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)
  /// <summary>
  /// Construct "SynExpr.LongIdentSet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdentSet dotId expr range =
    SynExpr.LongIdentSet(dotId, expr, range)
  /// <summary>
  /// Construct "SynExpr.Match".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatch spBind matchExpr clauses isCexprExceptionMatch range =
    SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)
  /// <summary>
  /// Construct "SynExpr.MatchLambda".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMatchLambda item1 item2 clauses spBind range =
    SynExpr.MatchLambda(item1, item2, clauses, spBind, range)
  /// <summary>
  /// Construct "SynExpr.NamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamedIndexedPropertySet item1 item2 item3 range =
    SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)
  /// <summary>
  /// Construct "SynExpr.New".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNew isProtected typeName expr range =
    SynExpr.New(isProtected, typeName, expr, range)
  /// <summary>
  /// Construct "SynExpr.Null".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNull range =
    SynExpr.Null(range)
  /// <summary>
  /// Construct "SynExpr.ObjExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initObjExpr objType argOpt bindings extraImpls newPos range =
    SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)
  /// <summary>
  /// Construct "SynExpr.Paren".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParen expr leftParenRange rightParenRange range =
    SynExpr.Paren(expr, leftParenRange, rightParenRange, range)
  /// <summary>
  /// Construct "SynExpr.Quote".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initQuote operator isRaw quotedSynExpr isFromQueryExpression range =
    SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)
  /// <summary>
  /// Construct "SynExpr.Record".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRecord baseInfo copyInfo recordFields range =
    SynExpr.Record(baseInfo, copyInfo, recordFields, range)
  /// <summary>
  /// Construct "SynExpr.Sequential".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSequential spSeq isTrueSeq expr1 expr2 range =
    SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)
  /// <summary>
  /// Construct "SynExpr.TraitCall".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTraitCall item1 item2 item3 range =
    SynExpr.TraitCall(item1, item2, item3, range)
  /// <summary>
  /// Construct "SynExpr.TryFinally".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryFinally tryExpr finallyExpr range spTry spFinally =
    SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)
  /// <summary>
  /// Construct "SynExpr.TryWith".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTryWith tryExpr item2 item3 item4 range spTry spWith =
    SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)
  /// <summary>
  /// Construct "SynExpr.Tuple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTuple exprs commaRanges range =
    SynExpr.Tuple(exprs, commaRanges, range)
  /// <summary>
  /// Construct "SynExpr.TypeApp".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
    SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
  /// <summary>
  /// Construct "SynExpr.TypeTest".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeTest expr typeName range =
    SynExpr.TypeTest(expr, typeName, range)
  /// <summary>
  /// Construct "SynExpr.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped expr typeSig range =
    SynExpr.Typed(expr, typeSig, range)
  /// <summary>
  /// Construct "SynExpr.Upcast".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUpcast expr typeSig range =
    SynExpr.Upcast(expr, typeSig, range)
  /// <summary>
  /// Construct "SynExpr.While".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhile spWhile whileBody doBody range =
    SynExpr.While(spWhile, whileBody, doBody, range)
  /// <summary>
  /// Construct "SynExpr.YieldOrReturn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturn item1 expr range =
    SynExpr.YieldOrReturn(item1, expr, range)
  /// <summary>
  /// Construct "SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initYieldOrReturnFrom item1 expr range =
    SynExpr.YieldOrReturnFrom(item1, expr, range)

//////////////////////////////////////////////

/// <summary>
/// SynField cons definitions.
/// </summary>
[<AutoOpen>]
module SynField =
  /// <summary>
  /// Construct "SynField.Field".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initField attributes isStatic id typeName item5 xmlDoc accessiblity range =
    SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)

//////////////////////////////////////////////

/// <summary>
/// SynIndexerArg cons definitions.
/// </summary>
[<AutoOpen>]
module SynIndexerArg =
  /// <summary>
  /// Construct "SynIndexerArg.One".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOne item =
    SynIndexerArg.One(item)
  /// <summary>
  /// Construct "SynIndexerArg.Two".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTwo item1 item2 =
    SynIndexerArg.Two(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// SynInterfaceImpl cons definitions.
/// </summary>
[<AutoOpen>]
module SynInterfaceImpl =
  /// <summary>
  /// Construct "SynInterfaceImpl.InterfaceImpl".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInterfaceImpl item1 bindings range =
    SynInterfaceImpl.InterfaceImpl(item1, bindings, range)

//////////////////////////////////////////////

/// <summary>
/// SynMatchClause cons definitions.
/// </summary>
[<AutoOpen>]
module SynMatchClause =
  /// <summary>
  /// Construct "SynMatchClause.Clause".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initClause item1 item2 item3 range spTarget =
    SynMatchClause.Clause(item1, item2, item3, range, spTarget)

//////////////////////////////////////////////

/// <summary>
/// SynMeasure cons definitions.
/// </summary>
[<AutoOpen>]
module SynMeasure =
  /// <summary>
  /// Construct "SynMeasure.Anon".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAnon item =
    SynMeasure.Anon(item)
  /// <summary>
  /// Construct "SynMeasure.Divide".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDivide item1 item2 range =
    SynMeasure.Divide(item1, item2, range)
  /// <summary>
  /// Construct "SynMeasure.Named".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamed longId range =
    SynMeasure.Named(longId, range)
  /// <summary>
  /// Construct "SynMeasure.One".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOne () =
    SynMeasure.One
  /// <summary>
  /// Construct "SynMeasure.Power".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initPower item1 item2 range =
    SynMeasure.Power(item1, item2, range)
  /// <summary>
  /// Construct "SynMeasure.Product".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initProduct item1 item2 range =
    SynMeasure.Product(item1, item2, range)
  /// <summary>
  /// Construct "SynMeasure.Seq".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSeq item1 range =
    SynMeasure.Seq(item1, range)
  /// <summary>
  /// Construct "SynMeasure.Var".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initVar item1 range =
    SynMeasure.Var(item1, range)

//////////////////////////////////////////////

/// <summary>
/// SynMemberDefn cons definitions.
/// </summary>
[<AutoOpen>]
module SynMemberDefn =
  /// <summary>
  /// Construct "SynMemberDefn.AbstractSlot".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAbstractSlot valSig memberFlags range =
    SynMemberDefn.AbstractSlot(valSig, memberFlags, range)
  /// <summary>
  /// Construct "SynMemberDefn.AutoProperty".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAutoProperty attributes isStatic id tyOpt propKind memberFlags xmlDoc accessibility expr getSetPos range =
    SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)
  /// <summary>
  /// Construct "SynMemberDefn.ImplicitCtor".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplicitCtor accessiblity attributes ctorArgs selfIdentifier range =
    SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range)
  /// <summary>
  /// Construct "SynMemberDefn.ImplicitInherit".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initImplicitInherit inheritType inheritArgs inheritAlias range =
    SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range)
  /// <summary>
  /// Construct "SynMemberDefn.Inherit".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInherit typeName id range =
    SynMemberDefn.Inherit(typeName, id, range)
  /// <summary>
  /// Construct "SynMemberDefn.Interface".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInterface typeName interfaceMembers range =
    SynMemberDefn.Interface(typeName, interfaceMembers, range)
  /// <summary>
  /// Construct "SynMemberDefn.LetBindings".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLetBindings bindings isStatic isRecursive range =
    SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range)
  /// <summary>
  /// Construct "SynMemberDefn.Member".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMember memberDefn range =
    SynMemberDefn.Member(memberDefn, range)
  /// <summary>
  /// Construct "SynMemberDefn.NestedType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNestedType typeDefn accessiblity range =
    SynMemberDefn.NestedType(typeDefn, accessiblity, range)
  /// <summary>
  /// Construct "SynMemberDefn.Open".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOpen longId range =
    SynMemberDefn.Open(longId, range)
  /// <summary>
  /// Construct "SynMemberDefn.ValField".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initValField field range =
    SynMemberDefn.ValField(field, range)

//////////////////////////////////////////////

/// <summary>
/// SynMemberSig cons definitions.
/// </summary>
[<AutoOpen>]
module SynMemberSig =
  /// <summary>
  /// Construct "SynMemberSig.Inherit".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInherit typeName range =
    SynMemberSig.Inherit(typeName, range)
  /// <summary>
  /// Construct "SynMemberSig.Interface".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInterface typeName range =
    SynMemberSig.Interface(typeName, range)
  /// <summary>
  /// Construct "SynMemberSig.Member".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMember item1 memberFlags range =
    SynMemberSig.Member(item1, memberFlags, range)
  /// <summary>
  /// Construct "SynMemberSig.NestedType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNestedType typeDefnSig range =
    SynMemberSig.NestedType(typeDefnSig, range)
  /// <summary>
  /// Construct "SynMemberSig.ValField".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initValField field range =
    SynMemberSig.ValField(field, range)

//////////////////////////////////////////////

/// <summary>
/// SynModuleDecl cons definitions.
/// </summary>
[<AutoOpen>]
module SynModuleDecl =
  /// <summary>
  /// Construct "SynModuleDecl.Attributes".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAttributes item1 item2 =
    SynModuleDecl.Attributes(item1, item2)
  /// <summary>
  /// Construct "SynModuleDecl.DoExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDoExpr item1 item2 item3 =
    SynModuleDecl.DoExpr(item1, item2, item3)
  /// <summary>
  /// Construct "SynModuleDecl.Exception".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initException item1 item2 =
    SynModuleDecl.Exception(item1, item2)
  /// <summary>
  /// Construct "SynModuleDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initHashDirective item1 item2 =
    SynModuleDecl.HashDirective(item1, item2)
  /// <summary>
  /// Construct "SynModuleDecl.Let".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLet item1 item2 item3 =
    SynModuleDecl.Let(item1, item2, item3)
  /// <summary>
  /// Construct "SynModuleDecl.ModuleAbbrev".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initModuleAbbrev item1 item2 item3 =
    SynModuleDecl.ModuleAbbrev(item1, item2, item3)
  /// <summary>
  /// Construct "SynModuleDecl.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamespaceFragment item =
    SynModuleDecl.NamespaceFragment(item)
  /// <summary>
  /// Construct "SynModuleDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNestedModule item1 isRec item3 item4 item5 =
    SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5)
  /// <summary>
  /// Construct "SynModuleDecl.Open".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOpen item1 item2 =
    SynModuleDecl.Open(item1, item2)
  /// <summary>
  /// Construct "SynModuleDecl.Types".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypes item1 item2 =
    SynModuleDecl.Types(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// SynModuleOrNamespace cons definitions.
/// </summary>
[<AutoOpen>]
module SynModuleOrNamespace =
  /// <summary>
  /// Construct "SynModuleOrNamespace.SynModuleOrNamespace".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynModuleOrNamespace id isRec isModule decls xmlDoc attributes access range =
    SynModuleOrNamespace.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range)

//////////////////////////////////////////////

/// <summary>
/// SynModuleOrNamespaceSig cons definitions.
/// </summary>
[<AutoOpen>]
module SynModuleOrNamespaceSig =
  /// <summary>
  /// Construct "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynModuleOrNamespaceSig id isRec isModule item4 xmlDoc attributes item7 range =
    SynModuleOrNamespaceSig.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range)

//////////////////////////////////////////////

/// <summary>
/// SynModuleSigDecl cons definitions.
/// </summary>
[<AutoOpen>]
module SynModuleSigDecl =
  /// <summary>
  /// Construct "SynModuleSigDecl.Exception".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initException exnSig range =
    SynModuleSigDecl.Exception(exnSig, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initHashDirective hashDirective range =
    SynModuleSigDecl.HashDirective(hashDirective, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.ModuleAbbrev".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initModuleAbbrev id longId range =
    SynModuleSigDecl.ModuleAbbrev(id, longId, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamespaceFragment item =
    SynModuleSigDecl.NamespaceFragment(item)
  /// <summary>
  /// Construct "SynModuleSigDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNestedModule item1 isRec moduleSigDecls range =
    SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.Open".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOpen longId range =
    SynModuleSigDecl.Open(longId, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.Types".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypes typeDefSigs range =
    SynModuleSigDecl.Types(typeDefSigs, range)
  /// <summary>
  /// Construct "SynModuleSigDecl.Val".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initVal valSig range =
    SynModuleSigDecl.Val(valSig, range)

//////////////////////////////////////////////

/// <summary>
/// SynPat cons definitions.
/// </summary>
[<AutoOpen>]
module SynPat =
  /// <summary>
  /// Construct "SynPat.Ands".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAnds item1 range =
    SynPat.Ands(item1, range)
  /// <summary>
  /// Construct "SynPat.ArrayOrList".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArrayOrList item1 item2 range =
    SynPat.ArrayOrList(item1, item2, range)
  /// <summary>
  /// Construct "SynPat.Attrib".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAttrib item1 attributes range =
    SynPat.Attrib(item1, attributes, range)
  /// <summary>
  /// Construct "SynPat.Const".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initConst constant range =
    SynPat.Const(constant, range)
  /// <summary>
  /// Construct "SynPat.DeprecatedCharRange".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDeprecatedCharRange item1 item2 range =
    SynPat.DeprecatedCharRange(item1, item2, range)
  /// <summary>
  /// Construct "SynPat.FromParseError".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFromParseError item1 range =
    SynPat.FromParseError(item1, range)
  /// <summary>
  /// Construct "SynPat.InstanceMember".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInstanceMember item1 item2 item3 accesiblity range =
    SynPat.InstanceMember(item1, item2, item3, accesiblity, range)
  /// <summary>
  /// Construct "SynPat.IsInst".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initIsInst typeName range =
    SynPat.IsInst(typeName, range)
  /// <summary>
  /// Construct "SynPat.LongIdent".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdent dotId item2 item3 item4 item5 range =
    SynPat.LongIdent(dotId, item2, item3, item4, item5, range)
  /// <summary>
  /// Construct "SynPat.Named".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNamed item1 id isThisVar accessiblity range =
    SynPat.Named(item1, id, isThisVar, accessiblity, range)
  /// <summary>
  /// Construct "SynPat.Null".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNull range =
    SynPat.Null(range)
  /// <summary>
  /// Construct "SynPat.OptionalVal".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOptionalVal item1 range =
    SynPat.OptionalVal(item1, range)
  /// <summary>
  /// Construct "SynPat.Or".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initOr item1 item2 range =
    SynPat.Or(item1, item2, range)
  /// <summary>
  /// Construct "SynPat.Paren".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initParen item1 range =
    SynPat.Paren(item1, range)
  /// <summary>
  /// Construct "SynPat.QuoteExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initQuoteExpr expr range =
    SynPat.QuoteExpr(expr, range)
  /// <summary>
  /// Construct "SynPat.Record".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRecord fields range =
    SynPat.Record(fields, range)
  /// <summary>
  /// Construct "SynPat.Tuple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTuple item1 range =
    SynPat.Tuple(item1, range)
  /// <summary>
  /// Construct "SynPat.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped item1 typeName range =
    SynPat.Typed(item1, typeName, range)
  /// <summary>
  /// Construct "SynPat.Wild".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWild range =
    SynPat.Wild(range)

//////////////////////////////////////////////

/// <summary>
/// SynRationalConst cons definitions.
/// </summary>
[<AutoOpen>]
module SynRationalConst =
  /// <summary>
  /// Construct "SynRationalConst.Integer".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initInteger item =
    SynRationalConst.Integer(item)
  /// <summary>
  /// Construct "SynRationalConst.Negate".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNegate item =
    SynRationalConst.Negate(item)
  /// <summary>
  /// Construct "SynRationalConst.Rational".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRational item1 item2 item3 =
    SynRationalConst.Rational(item1, item2, item3)

//////////////////////////////////////////////

/// <summary>
/// SynReturnInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynReturnInfo =
  /// <summary>
  /// Construct "SynReturnInfo.SynReturnInfo".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynReturnInfo item1 range =
    SynReturnInfo.SynReturnInfo(item1, range)

//////////////////////////////////////////////

/// <summary>
/// SynSimplePat cons definitions.
/// </summary>
[<AutoOpen>]
module SynSimplePat =
  /// <summary>
  /// Construct "SynSimplePat.Attrib".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAttrib item1 attributes range =
    SynSimplePat.Attrib(item1, attributes, range)
  /// <summary>
  /// Construct "SynSimplePat.Id".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initId ident altNameRefCell isCompilerGenerated isThisVar isOptArg range =
    SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)
  /// <summary>
  /// Construct "SynSimplePat.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped item1 typeName range =
    SynSimplePat.Typed(item1, typeName, range)

//////////////////////////////////////////////

/// <summary>
/// SynSimplePatAlternativeIdInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynSimplePatAlternativeIdInfo =
  /// <summary>
  /// Construct "SynSimplePatAlternativeIdInfo.Decided".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initDecided item =
    SynSimplePatAlternativeIdInfo.Decided(item)
  /// <summary>
  /// Construct "SynSimplePatAlternativeIdInfo.Undecided".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUndecided item =
    SynSimplePatAlternativeIdInfo.Undecided(item)

//////////////////////////////////////////////

/// <summary>
/// SynSimplePats cons definitions.
/// </summary>
[<AutoOpen>]
module SynSimplePats =
  /// <summary>
  /// Construct "SynSimplePats.SimplePats".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSimplePats item1 range =
    SynSimplePats.SimplePats(item1, range)
  /// <summary>
  /// Construct "SynSimplePats.Typed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyped item1 item2 range =
    SynSimplePats.Typed(item1, item2, range)

//////////////////////////////////////////////

/// <summary>
/// SynStaticOptimizationConstraint cons definitions.
/// </summary>
[<AutoOpen>]
module SynStaticOptimizationConstraint =
  /// <summary>
  /// Construct "SynStaticOptimizationConstraint.WhenTyparIsStruct".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhenTyparIsStruct item1 range =
    SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range)
  /// <summary>
  /// Construct "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhenTyparTyconEqualsTycon item1 item2 range =
    SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypar cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypar =
  /// <summary>
  /// Construct "SynTypar.Typar".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypar id staticReq isCompGen =
    SynTypar.Typar(id, staticReq, isCompGen)

//////////////////////////////////////////////

/// <summary>
/// SynTyparDecl cons definitions.
/// </summary>
[<AutoOpen>]
module SynTyparDecl =
  /// <summary>
  /// Construct "SynTyparDecl.TyparDecl".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyparDecl attributes item2 =
    SynTyparDecl.TyparDecl(attributes, item2)

//////////////////////////////////////////////

/// <summary>
/// SynType cons definitions.
/// </summary>
[<AutoOpen>]
module SynType =
  /// <summary>
  /// Construct "SynType.Anon".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initAnon range =
    SynType.Anon(range)
  /// <summary>
  /// Construct "SynType.App".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initApp typeName leftAngleRange typeArgs commaRanges rightAngleRange isPostfix range =
    SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)
  /// <summary>
  /// Construct "SynType.Array".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initArray item1 elementType range =
    SynType.Array(item1, elementType, range)
  /// <summary>
  /// Construct "SynType.Fun".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initFun argType returnType range =
    SynType.Fun(argType, returnType, range)
  /// <summary>
  /// Construct "SynType.HashConstraint".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initHashConstraint typeName range =
    SynType.HashConstraint(typeName, range)
  /// <summary>
  /// Construct "SynType.LongIdent".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdent item =
    SynType.LongIdent(item)
  /// <summary>
  /// Construct "SynType.LongIdentApp".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLongIdentApp typeName dotId leftAngleRange genericNames commaRanges rightAngleRange range =
    SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)
  /// <summary>
  /// Construct "SynType.MeasureDivide".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMeasureDivide typeName item2 range =
    SynType.MeasureDivide(typeName, item2, range)
  /// <summary>
  /// Construct "SynType.MeasurePower".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initMeasurePower typeName item2 range =
    SynType.MeasurePower(typeName, item2, range)
  /// <summary>
  /// Construct "SynType.StaticConstant".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initStaticConstant constant range =
    SynType.StaticConstant(constant, range)
  /// <summary>
  /// Construct "SynType.StaticConstantExpr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initStaticConstantExpr expr range =
    SynType.StaticConstantExpr(expr, range)
  /// <summary>
  /// Construct "SynType.StaticConstantNamed".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initStaticConstantNamed item1 item2 range =
    SynType.StaticConstantNamed(item1, item2, range)
  /// <summary>
  /// Construct "SynType.Tuple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTuple item1 range =
    SynType.Tuple(item1, range)
  /// <summary>
  /// Construct "SynType.Var".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initVar item1 range =
    SynType.Var(item1, range)
  /// <summary>
  /// Construct "SynType.WithGlobalConstraints".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWithGlobalConstraints typeName constraints range =
    SynType.WithGlobalConstraints(typeName, constraints, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeConstraint cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeConstraint =
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparDefaultsToType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparDefaultsToType genericName typeSig range =
    SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsComparable".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsComparable genericName range =
    SynTypeConstraint.WhereTyparIsComparable(genericName, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsDelegate".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsDelegate genericName delegateTypes range =
    SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsEnum".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsEnum genericName enumTypes range =
    SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsEquatable".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsEquatable genericName range =
    SynTypeConstraint.WhereTyparIsEquatable(genericName, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsReferenceType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsReferenceType genericName range =
    SynTypeConstraint.WhereTyparIsReferenceType(genericName, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsUnmanaged".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsUnmanaged genericName range =
    SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparIsValueType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparIsValueType genericName range =
    SynTypeConstraint.WhereTyparIsValueType(genericName, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparSubtypeOfType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparSubtypeOfType genericName typeSig range =
    SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparSupportsMember".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparSupportsMember genericNames memberSig range =
    SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range)
  /// <summary>
  /// Construct "SynTypeConstraint.WhereTyparSupportsNull".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initWhereTyparSupportsNull genericName range =
    SynTypeConstraint.WhereTyparSupportsNull(genericName, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefn cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefn =
  /// <summary>
  /// Construct "SynTypeDefn.TypeDefn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeDefn item1 item2 members range =
    SynTypeDefn.TypeDefn(item1, item2, members, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefnKind cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefnKind =
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconAbbrev".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconAbbrev () =
    SynTypeDefnKind.TyconAbbrev
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconAugmentation".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconAugmentation () =
    SynTypeDefnKind.TyconAugmentation
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconClass".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconClass () =
    SynTypeDefnKind.TyconClass
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconDelegate".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconDelegate item1 item2 =
    SynTypeDefnKind.TyconDelegate(item1, item2)
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconHiddenRepr".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconHiddenRepr () =
    SynTypeDefnKind.TyconHiddenRepr
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconILAssemblyCode".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconILAssemblyCode () =
    SynTypeDefnKind.TyconILAssemblyCode
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconInterface".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconInterface () =
    SynTypeDefnKind.TyconInterface
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconRecord".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconRecord () =
    SynTypeDefnKind.TyconRecord
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconStruct".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconStruct () =
    SynTypeDefnKind.TyconStruct
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconUnion".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconUnion () =
    SynTypeDefnKind.TyconUnion
  /// <summary>
  /// Construct "SynTypeDefnKind.TyconUnspecified".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTyconUnspecified () =
    SynTypeDefnKind.TyconUnspecified

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefnRepr cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefnRepr =
  /// <summary>
  /// Construct "SynTypeDefnRepr.Exception".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initException item =
    SynTypeDefnRepr.Exception(item)
  /// <summary>
  /// Construct "SynTypeDefnRepr.ObjectModel".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initObjectModel item1 members range =
    SynTypeDefnRepr.ObjectModel(item1, members, range)
  /// <summary>
  /// Construct "SynTypeDefnRepr.Simple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSimple item1 range =
    SynTypeDefnRepr.Simple(item1, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefnSig cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefnSig =
  /// <summary>
  /// Construct "SynTypeDefnSig.TypeDefnSig".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeDefnSig item1 item2 memberSigs range =
    SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefnSigRepr cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefnSigRepr =
  /// <summary>
  /// Construct "SynTypeDefnSigRepr.Exception".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initException item =
    SynTypeDefnSigRepr.Exception(item)
  /// <summary>
  /// Construct "SynTypeDefnSigRepr.ObjectModel".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initObjectModel item1 memberSigs range =
    SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range)
  /// <summary>
  /// Construct "SynTypeDefnSigRepr.Simple".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSimple item1 range =
    SynTypeDefnSigRepr.Simple(item1, range)

//////////////////////////////////////////////

/// <summary>
/// SynTypeDefnSimpleRepr cons definitions.
/// </summary>
[<AutoOpen>]
module SynTypeDefnSimpleRepr =
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.Enum".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initEnum cases range =
    SynTypeDefnSimpleRepr.Enum(cases, range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.Exception".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initException item =
    SynTypeDefnSimpleRepr.Exception(item)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.General".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initGeneral item1 item2 item3 item4 item5 item6 item7 range =
    SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initLibraryOnlyILAssembly item1 range =
    SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.None".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNone range =
    SynTypeDefnSimpleRepr.None(range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.Record".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initRecord accessiblity fields range =
    SynTypeDefnSimpleRepr.Record(accessiblity, fields, range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.TypeAbbrev".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initTypeAbbrev item1 item2 range =
    SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range)
  /// <summary>
  /// Construct "SynTypeDefnSimpleRepr.Union".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUnion accessiblity cases range =
    SynTypeDefnSimpleRepr.Union(accessiblity, cases, range)

//////////////////////////////////////////////

/// <summary>
/// SynUnionCase cons definitions.
/// </summary>
[<AutoOpen>]
module SynUnionCase =
  /// <summary>
  /// Construct "SynUnionCase.UnionCase".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUnionCase attributes id caseType xmlDoc accessibility range =
    SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range)

//////////////////////////////////////////////

/// <summary>
/// SynUnionCaseType cons definitions.
/// </summary>
[<AutoOpen>]
module SynUnionCaseType =
  /// <summary>
  /// Construct "SynUnionCaseType.UnionCaseFields".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUnionCaseFields cases =
    SynUnionCaseType.UnionCaseFields(cases)
  /// <summary>
  /// Construct "SynUnionCaseType.UnionCaseFullType".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initUnionCaseFullType item =
    SynUnionCaseType.UnionCaseFullType(item)

//////////////////////////////////////////////

/// <summary>
/// SynValData cons definitions.
/// </summary>
[<AutoOpen>]
module SynValData =
  /// <summary>
  /// Construct "SynValData.SynValData".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynValData item1 item2 item3 =
    SynValData.SynValData(item1, item2, item3)

//////////////////////////////////////////////

/// <summary>
/// SynValInfo cons definitions.
/// </summary>
[<AutoOpen>]
module SynValInfo =
  /// <summary>
  /// Construct "SynValInfo.SynValInfo".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynValInfo item1 item2 =
    SynValInfo.SynValInfo(item1, item2)

//////////////////////////////////////////////

/// <summary>
/// SynValSig cons definitions.
/// </summary>
[<AutoOpen>]
module SynValSig =
  /// <summary>
  /// Construct "SynValSig.ValSpfn".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initValSpfn attributes id typeParams typeName valInfo item6 isMutable xmlDoc accessiblity expr range =
    SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)

//////////////////////////////////////////////

/// <summary>
/// SynValTyparDecls cons definitions.
/// </summary>
[<AutoOpen>]
module SynValTyparDecls =
  /// <summary>
  /// Construct "SynValTyparDecls.SynValTyparDecls".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initSynValTyparDecls item1 item2 constraints =
    SynValTyparDecls.SynValTyparDecls(item1, item2, constraints)

//////////////////////////////////////////////

/// <summary>
/// TyparStaticReq cons definitions.
/// </summary>
[<AutoOpen>]
module TyparStaticReq =
  /// <summary>
  /// Construct "TyparStaticReq.HeadTypeStaticReq".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initHeadTypeStaticReq () =
    TyparStaticReq.HeadTypeStaticReq
  /// <summary>
  /// Construct "TyparStaticReq.NoStaticReq".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initNoStaticReq () =
    TyparStaticReq.NoStaticReq

//////////////////////////////////////////////

/// <summary>
/// XmlDoc cons definitions.
/// </summary>
[<AutoOpen>]
module XmlDoc =
  /// <summary>
  /// Construct "XmlDoc.XmlDoc".
  /// </summary>
  /// <returns>Constructed expression.</returns>
  let initXmlDoc item =
    XmlDoc.XmlDoc(item)

