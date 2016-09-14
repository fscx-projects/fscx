//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Wed, 14 Sep 2016 08:36:13 GMT
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
  /// <returns>Constructed record.</returns>
  let genAPInfo item1 item2 item3 =
    Microsoft.FSharp.Compiler.PrettyNaming.ActivePatternInfo.APInfo
      (item1,
       item2,
       item3)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.DefaultPhase".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDefaultPhase () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.DefaultPhase

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Compile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCompile () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Compile

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Parameter".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genParameter () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Parameter

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Parse".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genParse () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Parse

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.TypeCheck".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeCheck () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.TypeCheck

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.CodeGen".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCodeGen () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.CodeGen

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Optimize".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOptimize () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Optimize

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.IlxGen".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIlxGen () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.IlxGen

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.IlGen".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIlGen () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.IlGen

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Output".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOutput () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Output

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Interactive".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInteractive () =
    Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase.Interactive

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.Eventually<_>".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.Eventually<_>.Done".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDone item =
    Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.Eventually<_>.Done
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.Eventually<_>.NotYetDone".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNotYetDone item =
    Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.Eventually<_>.NotYetDone
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileAnswer".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileAnswer.Aborted".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAborted () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileAnswer.Aborted

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileAnswer.Succeeded".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSucceeded item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileAnswer.Succeeded
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.FSharpErrorSeverity".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.FSharpErrorSeverity.Warning".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWarning () =
    Microsoft.FSharp.Compiler.FSharpErrorSeverity.Warning

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.FSharpErrorSeverity.Error".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genError () =
    Microsoft.FSharp.Compiler.FSharpErrorSeverity.Error

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.Unknown".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnknown () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.Unknown

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.NoSourceCode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSourceCode () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.NoSourceCode

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.ProvidedType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genProvidedType item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.ProvidedType
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.ProvidedMember".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genProvidedMember item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclFailureReason.ProvidedMember
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclResult".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclResult.DeclNotFound".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDeclNotFound item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclResult.DeclNotFound
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclResult.DeclFound".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDeclFound item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpFindDeclResult.DeclFound
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEntity item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.Entity
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMemberOrFunctionOrValue item1 item2 item3 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.MemberOrFunctionOrValue
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.InitAction".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInitAction item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpImplementationFileDeclaration.InitAction
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.PseudoValue".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPseudoValue () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.PseudoValue

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.AlwaysInline".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAlwaysInline () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.AlwaysInline

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.OptionalInline".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOptionalInline () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.OptionalInline

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.NeverInline".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNeverInline () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpInlineAnnotation.NeverInline

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.NamespaceDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamespaceDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.NamespaceDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ModuleFileDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModuleFileDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ModuleFileDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ExnDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genExnDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ExnDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ModuleDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModuleDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.ModuleDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.TypeDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.TypeDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.MethodDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMethodDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.MethodDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.PropertyDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPropertyDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.PropertyDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.FieldDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFieldDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.FieldDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.OtherDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOtherDecl () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItemKind.OtherDecl

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.None".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNone () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Single
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.SingleParameter".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingleParameter item1 item2 item3 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.SingleParameter
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Group".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genGroup item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.Group
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.CompositionError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCompositionError item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipElement.CompositionError
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipText".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipText".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFSharpToolTipText item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpToolTipText
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.None".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNone () =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.Text".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genText item =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.Text
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genXmlDocFileSignature item1 item2 =
    Microsoft.FSharp.Compiler.SourceCodeServices.FSharpXmlDoc.XmlDocFileSignature
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Aligned".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAligned () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Aligned

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned1".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnaligned1 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned1

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned2".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnaligned2 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned2

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnaligned4 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAlignment.Unaligned4

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.Default".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDefault () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.Default

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.CDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCDecl () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.CDecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.StdCall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStdCall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.StdCall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.ThisCall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genThisCall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.ThisCall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.FastCall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFastCall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.FastCall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.VarArg".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVarArg () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArgConvention.VarArg

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILArrayShape item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILArrayShape
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.Unspecified".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnspecified () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.Unspecified

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.Library".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLibrary () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.Library

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformAppDomain".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPlatformAppDomain () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformAppDomain

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformProcess".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPlatformProcess () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformProcess

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformSystem".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPlatformSystem () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity.PlatformSystem

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.String".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genString item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.String
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Bool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBool item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Bool
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Char".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genChar item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Char
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.SByte".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSByte item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.SByte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt16 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt32 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt64 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Int64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Byte".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genByte item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Byte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt32 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt64 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.UInt64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Single
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Double".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDouble item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Double
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Null".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNull () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Null

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Type".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genType item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Type
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.TypeRef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeRef item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.TypeRef
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArray item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribElem.Array
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_R () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I1".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_I1 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I1

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U1".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_U1 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U1

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I2".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_I2 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I2

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U2".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_U2 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U2

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_I4 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I4

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_U4 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U4

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_I8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_U8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_R4 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R4

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_R8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_R8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_I () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_I

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_U () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_U

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_REF".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDT_REF () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBasicType.DT_REF

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBoxity".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBoxity.AsObject".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAsObject () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBoxity.AsObject

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILBoxity.AsValue".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAsValue () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILBoxity.AsValue

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCallconv item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv.Callconv
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_beq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_beq () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_beq

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bge".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_bge () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bge

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bge_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_bge_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bge_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bgt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_bgt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bgt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bgt_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_bgt_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bgt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_ble".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_ble () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_ble

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_ble_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_ble_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_ble_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_blt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_blt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_blt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_blt_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_blt_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_blt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bne_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_bne_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_bne_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_brfalse".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_brfalse () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_brfalse

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_brtrue".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBI_brtrue () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILComparisonInstr.BI_brtrue

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.I4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI4 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.I4
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.I8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI8 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.I8
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.R4".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genR4 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.R4
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.R8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genR8 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILConst.R8
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Ansi".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnsi () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Ansi

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Auto".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAuto () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Auto

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Unicode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnicode () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding.Unicode

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Finally".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFinally item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Finally
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Fault".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFault item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.Fault
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFilterCatch item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.FilterCatch
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeCatch item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause.TypeCatch
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.String".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genString item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.String
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Bool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBool item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Bool
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Char".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genChar item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Char
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt8 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int8
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt16 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt32 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt64 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Int64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt8 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt8
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt32 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt64 item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.UInt64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Single
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Double".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDouble item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Double
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Null".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNull () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit.Null

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.NonVariant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonVariant () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.NonVariant

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.CoVariant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCoVariant () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.CoVariant

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.ContraVariant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genContraVariant () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance.ContraVariant

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_add () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_add_ovf () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_add_ovf_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_add_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_and".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_and () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_and

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_div () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_div_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_div_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ceq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_ceq () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ceq

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_cgt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_cgt_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_cgt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_clt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_clt_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_clt_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_conv item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_conv_ovf item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_conv_ovf_un item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_conv_ovf_un
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_mul () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_mul_ovf () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_mul_ovf_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_mul_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_rem () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_rem_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_rem_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_shl () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_shr () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_shr_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_shr_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_sub () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_sub_ovf () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf_un".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_sub_ovf_un () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_sub_ovf_un

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_xor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_xor () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_xor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_or".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_or () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_or

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_neg".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_neg () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_neg

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_not".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_not () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_not

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldnull".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_ldnull () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldnull

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_dup".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_dup () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_dup

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_pop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_pop () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_pop

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ckfinite".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_ckfinite () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ckfinite

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_nop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_nop () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_nop

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAI_ldc item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.AI_ldc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarg".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldarg item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarg
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarga".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldarga item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldarga
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldind item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldloc item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloc
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloca".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldloca item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldloca
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_starg".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_starg item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_starg
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stind item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stind
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stloc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stloc item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stloc
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_br".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_br item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_br
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_jmp".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_jmp item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_jmp
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_brcmp item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_brcmp
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_switch".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_switch item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_switch
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ret".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ret () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ret

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_call item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_call
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_callvirt item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callvirt
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_callconstraint item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_callconstraint
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_calli item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_calli
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldftn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldftn item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldftn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_newobj item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newobj
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_throw".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_throw () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_throw

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfinally".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_endfinally () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfinally

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfilter".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_endfilter () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_endfilter

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_leave".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_leave item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_leave
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_rethrow".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_rethrow () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_rethrow

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldsfld item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldfld item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsflda".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldsflda item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldsflda
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldflda".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldflda item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldflda
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stsfld item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stsfld
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stfld item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stfld
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldstr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldstr item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldstr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_isinst".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_isinst item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_isinst
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_castclass".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_castclass item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_castclass
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldtoken".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldtoken item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldtoken
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldvirtftn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldvirtftn item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldvirtftn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpobj".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_cpobj item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpobj
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initobj".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_initobj item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initobj
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldobj item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stobj item1 item2 item3 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stobj
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_box".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_box item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_box
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_unbox item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox_any".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_unbox_any item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_unbox_any
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_sizeof".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_sizeof item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_sizeof
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldelem item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stelem item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldelema item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelema
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldelem_any item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_stelem_any item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_stelem_any
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_newarr item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_newarr
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldlen".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_ldlen () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_ldlen

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_mkrefany".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_mkrefany item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_mkrefany
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanytype".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_refanytype () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanytype

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanyval".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_refanyval item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_refanyval
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_break".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_break () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_break

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_seqpoint".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_seqpoint item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_seqpoint
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_arglist".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_arglist () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_arglist

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_localloc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_localloc () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_localloc

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_cpblk item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_cpblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genI_initblk item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.I_initblk
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ilzero".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEI_ilzero item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ilzero
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEI_ldlen_multi item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr.EI_ldlen_multi
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Assembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAssembly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Assembly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.CompilerControlled".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCompilerControlled () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.CompilerControlled

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.FamilyAndAssembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFamilyAndAssembly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.FamilyAndAssembly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.FamilyOrAssembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFamilyOrAssembly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.FamilyOrAssembly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Family".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFamily () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Family

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Private".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPrivate () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Private

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Public".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublic () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess.Public

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Empty".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEmpty () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Empty

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCustom item1 item2 item3 item4 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Custom
      (item1,
       item2,
       item3,
       item4)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedSysString".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFixedSysString item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedSysString
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedArray".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFixedArray item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.FixedArray
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Currency".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCurrency () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Currency

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPWSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPWSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPWSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPTSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPTSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPTSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ByValStr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genByValStr () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ByValStr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.TBSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTBSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.TBSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTRUCT".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPSTRUCT () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.LPSTRUCT

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Struct".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStruct () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Struct

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Void".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVoid () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Void

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Bool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBool () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Bool

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt16 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt32 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Single

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Double".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDouble () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Double

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Byte".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genByte () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Byte

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt32 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArray item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Array
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Int

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.UInt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Method".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMethod () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Method

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.AsAny".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAsAny () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.AsAny

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.BSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.BSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IUnknown".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIUnknown () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IUnknown

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IDispatch".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIDispatch () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.IDispatch

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Interface".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInterface () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Interface

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Error".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genError () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.Error

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSafeArray item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.SafeArray
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ANSIBSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genANSIBSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.ANSIBSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.VariantBool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVariantBool () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType.VariantBool

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Empty".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEmpty () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Empty

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Null".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNull () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Null

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Variant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVariant () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Variant

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Currency".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCurrency () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Currency

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Decimal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDecimal () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Decimal

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Date".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDate () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Date

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.BSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.BSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.LPSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.LPSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.LPWSTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLPWSTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.LPWSTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.IUnknown".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIUnknown () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.IUnknown

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.IDispatch".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIDispatch () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.IDispatch

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.SafeArray".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSafeArray () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.SafeArray

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Error".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genError () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Error

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.HRESULT".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genHRESULT () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.HRESULT

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CArray".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCArray () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CArray

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UserDefined".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUserDefined () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UserDefined

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Record".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRecord () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Record

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.FileTime".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFileTime () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.FileTime

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Blob".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBlob () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Blob

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Stream".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStream () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Stream

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Storage".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStorage () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Storage

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.StreamedObject".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStreamedObject () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.StreamedObject

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.StoredObject".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStoredObject () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.StoredObject

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.BlobObject".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBlobObject () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.BlobObject

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CF".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCF () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CF

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CLSID".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCLSID () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.CLSID

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Void".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVoid () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Void

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Bool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBool () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Bool

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt16 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt32 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Single

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Double".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDouble () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Double

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt8".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt8 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt8

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt16

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt32 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt32

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.PTR".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPTR () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.PTR

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Array".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArray item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Array
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Vector".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVector item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Vector
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Byref".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genByref item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Byref
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.Int

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeVariant.UInt

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOverridesSpec item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec.OverridesSpec
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPermissionSet item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermission.PermissionSet
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.X86".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genX86 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.X86

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.AMD64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAMD64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.AMD64

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.IA64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIA64 () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform.IA64

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly.ReadonlyAddress".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genReadonlyAddress () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly.ReadonlyAddress

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly.NormalAddress".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNormalAddress () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILReadonly.NormalAddress

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess.Public".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublic () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess.Public

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess.Private".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPrivate () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess.Private

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Local".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLocal item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Local
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFile item1 item2 =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.File
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Assembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAssembly item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation.Assembly
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Local".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLocal () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Local

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Module".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModule item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Module
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Assembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAssembly item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef.Assembly
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Request".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRequest () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Request

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Demand".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDemand () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Demand

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Assert".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAssert () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Assert

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Deny".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDeny () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.Deny

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PermitOnly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPermitOnly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PermitOnly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.LinkCheck".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLinkCheck () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.LinkCheck

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.InheritCheck".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInheritCheck () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.InheritCheck

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqMin".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genReqMin () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqMin

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqOpt".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genReqOpt () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqOpt

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqRefuse".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genReqRefuse () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.ReqRefuse

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PreJitGrant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPreJitGrant () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PreJitGrant

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PreJitDeny".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPreJitDeny () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.PreJitDeny

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasDemand".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonCasDemand () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasDemand

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasLinkDemand".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonCasLinkDemand () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasLinkDemand

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasInheritance".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonCasInheritance () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.NonCasInheritance

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.LinkDemandChoice".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLinkDemandChoice () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.LinkDemandChoice

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.InheritanceDemandChoice".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInheritanceDemandChoice () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.InheritanceDemandChoice

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.DemandChoice".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDemandChoice () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILSecurityAction.DemandChoice

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall.Tailcall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTailcall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall.Tailcall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall.Normalcall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNormalcall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTailcall.Normalcall

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.Instance".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInstance () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.Instance

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.InstanceExplicit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInstanceExplicit () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.InstanceExplicit

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.Static".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStatic () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention.Static

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILType item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILType
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILMethod".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILMethod item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILMethod
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILField".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILField item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILToken.ILField
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Public".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublic () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Public

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Private".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPrivate () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Private

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Nested".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNested item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess.Nested
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Class".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genClass () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Class

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.ValueType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genValueType () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.ValueType

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Interface".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInterface () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Interface

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Enum".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEnum () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Enum

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Delegate".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDelegate () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind.Delegate

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Auto".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAuto () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Auto

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Sequential".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequential item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Sequential
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Explicit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genExplicit item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout.Explicit
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit.BeforeField".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBeforeField () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit.BeforeField

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit.OnAny".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOnAny () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit.OnAny

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility.Volatile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVolatile () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility.Volatile

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility.Nonvolatile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonvolatile () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.ILVolatility.Nonvolatile

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.IsResultObsolete".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.IsResultObsolete".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIsResultObsolete item =
    Microsoft.FSharp.Compiler.SourceCodeServices.IsResultObsolete
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Token".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genToken item =
    Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Token
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSkip item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerEndlineContinuation.Skip
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfdefAnd item1 item2 =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefAnd
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfdefOr item1 item2 =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefOr
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefNot".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfdefNot item =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefNot
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefId".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfdefId item =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefExpression.IfdefId
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry.IfDefIf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfDefIf () =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry.IfDefIf

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry.IfDefElse".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfDefElse () =
    Microsoft.FSharp.Compiler.Ast.LexerIfdefStackEntry.IfDefElse

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Token".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genToken item =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Token
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfDefSkip item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.IfDefSkip
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genString item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.String
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVerbatimString item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimString
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTripleQuoteString item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteString
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.Comment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingleLineComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.SingleLineComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.StringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVerbatimStringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.VerbatimStringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTripleQuoteStringInComment item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.TripleQuoteStringInComment
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.MLOnly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMLOnly item1 range =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.MLOnly
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.EndLine".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEndLine item =
    Microsoft.FSharp.Compiler.Ast.LexerWhitespaceContinuation.EndLine
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.LongIdentWithDots".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.LongIdentWithDots".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLongIdentWithDots id dotms =
    Microsoft.FSharp.Compiler.Ast.LongIdentWithDots
      (id,
       dotms)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.ClassConstructor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genClassConstructor () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.ClassConstructor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.Constructor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genConstructor () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.Constructor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.Member".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMember () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.Member

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.PropertyGet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPropertyGet () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.PropertyGet

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.PropertySet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPropertySet () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.PropertySet

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberKind.PropertyGetSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPropertyGetSet () =
    Microsoft.FSharp.Compiler.Ast.MemberKind.PropertyGetSet

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.IL".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIL item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.IL
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.PInvoke".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPInvoke item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.PInvoke
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.Abstract".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAbstract () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.Abstract

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.Native".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNative () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodBody.Native

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.IL".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIL () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.IL

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.Native".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNative () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.Native

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.Runtime".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRuntime () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind.Runtime

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Static".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStatic () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Static

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Cctor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCctor () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Cctor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Ctor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCtor () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Ctor

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.NonVirtual".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNonVirtual () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.NonVirtual

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Virtual".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVirtual item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind.Virtual
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNameArityPair item1 item2 =
    Microsoft.FSharp.Compiler.PrettyNaming.NameArityPair
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.OkResult".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOkResult item1 item2 =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.OkResult
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.ErrorResult".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genErrorResult item1 item2 =
    Microsoft.FSharp.Compiler.ErrorLogger.OperationResult<_>.ErrorResult
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.None".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNone () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Cdecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCdecl () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Cdecl

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Stdcall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStdcall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Stdcall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Thiscall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genThiscall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Thiscall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Fastcall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFastcall () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.Fastcall

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.WinApi".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWinApi () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention.WinApi

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.UseAssembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUseAssembly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.UseAssembly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.Enabled".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEnabled () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.Enabled

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.Disabled".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDisabled () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit.Disabled

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.None".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNone () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.None

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Ansi".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnsi () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Ansi

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Unicode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnicode () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Unicode

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Auto".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAuto () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding.Auto

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.UseAssembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUseAssembly () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.UseAssembly

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.Enabled".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEnabled () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.Enabled

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.Disabled".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDisabled () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar.Disabled

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIDefns item1 range =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIHash item1 range =
    Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedHashDirective".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedHashDirective".
  /// </summary>
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genParsedImplFile hashDirectives item2 =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnonModule moduleDecls range =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
      (moduleDecls,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamedModule item =
    Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamespaceFragment longId item2 item3 moduleDecls xmlDoc attributes range =
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
  /// <returns>Constructed record.</returns>
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
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedInput".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genImplFile item =
    Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSigFile item =
    Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFile".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genParsedSigFile hashDirectives item2 =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFile
      (hashDirectives,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnonModule moduleSigDecl range =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
      (moduleSigDecl,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamedModule item =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamespaceFragment longId item2 item3 moduleSigDecls xmlDoc attributes range =
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
  /// <returns>Constructed record.</returns>
  let genParsedSigFileInput filename item2 item3 item4 item5 =
    Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
      (filename,
       item2,
       item3,
       item4,
       item5)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParserDetail".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParserDetail.Ok".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOk () =
    Microsoft.FSharp.Compiler.Ast.ParserDetail.Ok

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ParserDetail.ThereWereSignificantParseErrorsSoDoNotTypecheckThisNode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genThereWereSignificantParseErrorsSoDoNotTypecheckThisNode () =
    Microsoft.FSharp.Compiler.Ast.ParserDetail.ThereWereSignificantParseErrorsSoDoNotTypecheckThisNode

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPreXmlMerge item1 item2 =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPreXmlDoc item1 item2 =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.PreXmlDoc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPreXmlDocEmpty () =
    Microsoft.FSharp.Compiler.Ast.PreXmlDoc

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PrimaryAssembly".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PrimaryAssembly.Mscorlib".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMscorlib () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PrimaryAssembly.Mscorlib

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PrimaryAssembly.DotNetCore".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotNetCore () =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PrimaryAssembly.DotNetCore

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PublicKey".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PublicKey".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublicKey item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PublicKey
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PublicKey".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublicKeyToken item =
    Microsoft.FSharp.Compiler.AbstractIL.IL.PublicKey
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genQualifiedNameOfFile item =
    Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.ResultOrException<_>".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.ResultOrException<_>.Result".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genResult item =
    Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.ResultOrException<_>.Result
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.ResultOrException<_>.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException item =
    Microsoft.FSharp.Compiler.AbstractIL.Internal.Library.ResultOrException<_>.Exception
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.ScopedPragma".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWarningOff item1 item2 =
    Microsoft.FSharp.Compiler.Ast.ScopedPragma.WarningOff
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SeqExprOnly".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SeqExprOnly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSeqExprOnly item =
    Microsoft.FSharp.Compiler.Ast.SeqExprOnly
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.SequencePointAtBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtBinding item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.SequencePointAtBinding
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtDoBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtDoBinding () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtDoBinding

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtLetBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtLetBinding () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtLetBinding

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtStickyBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtStickyBinding () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtStickyBinding

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtInvisibleBinding () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally.SequencePointAtFinally".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtFinally item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally.SequencePointAtFinally
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally.NoSequencePointAtFinally".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtFinally () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally.NoSequencePointAtFinally

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop.SequencePointAtForLoop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtForLoop item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop.SequencePointAtForLoop
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop.NoSequencePointAtForLoop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtForLoop () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop.NoSequencePointAtForLoop

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SequencePointsAtSeq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointsAtSeq () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SequencePointsAtSeq

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SuppressSequencePointOnExprOfSequential".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSuppressSequencePointOnExprOfSequential () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SuppressSequencePointOnExprOfSequential

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SuppressSequencePointOnStmtOfSequential".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSuppressSequencePointOnStmtOfSequential () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq.SuppressSequencePointOnStmtOfSequential

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget.SequencePointAtTarget".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtTarget () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget.SequencePointAtTarget

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget.SuppressSequencePointAtTarget".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSuppressSequencePointAtTarget () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget.SuppressSequencePointAtTarget

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.SequencePointAtTry".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtTry item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.SequencePointAtTry
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.SequencePointInBodyOfTry".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointInBodyOfTry () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.SequencePointInBodyOfTry

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.NoSequencePointAtTry".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtTry () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry.NoSequencePointAtTry

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop.SequencePointAtWhileLoop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtWhileLoop item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop.SequencePointAtWhileLoop
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop.NoSequencePointAtWhileLoop".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtWhileLoop () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop.NoSequencePointAtWhileLoop

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith.SequencePointAtWith".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequencePointAtWith item =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith.SequencePointAtWith
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith.NoSequencePointAtWith".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoSequencePointAtWith () =
    Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith.NoSequencePointAtWith

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAccess".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAccess.Public".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPublic () =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Public

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAccess.Internal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInternal () =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Internal

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAccess.Private".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPrivate () =
    Microsoft.FSharp.Compiler.Ast.SynAccess.Private

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynArgInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynArgInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genBinding access bindingKind mustInline isMutable attributes xmlDoc item7 headPat item9 expr lhsRange spBind =
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
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStandaloneExpression () =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNormalBinding () =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDoBinding () =
    Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genComponentInfo attributes typeParams constraints item4 xmlDoc preferPostfix accessiblity range =
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
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Unit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnit () =
    Microsoft.FSharp.Compiler.Ast.SynConst.Unit

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Bool".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBool item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bool
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.SByte".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSByte item =
    Microsoft.FSharp.Compiler.Ast.SynConst.SByte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Byte".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genByte item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Byte
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt16 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt16".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt32 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt32".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt32 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt32
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Int64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInt64 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Int64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt64".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt64 item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt64
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIntPtr item =
    Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUIntPtr item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Single".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSingle item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Single
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Double".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDouble item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Double
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Char".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genChar item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Char
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Decimal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDecimal item =
    Microsoft.FSharp.Compiler.Ast.SynConst.Decimal
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UserNum".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUserNum item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UserNum
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.String".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genString text range =
    Microsoft.FSharp.Compiler.Ast.SynConst.String
      (text,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Bytes".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBytes bytes range =
    Microsoft.FSharp.Compiler.Ast.SynConst.Bytes
      (bytes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUInt16s item =
    Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConst.Measure".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMeasure constant item2 =
    Microsoft.FSharp.Compiler.Ast.SynConst.Measure
      (constant,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPats item =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamePatPairs item1 range =
    Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynEnumCase".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEnumCase attributes id item3 xmlDoc range =
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
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genParen expr leftParenRange rightParenRange range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
      (expr,
       leftParenRange,
       rightParenRange,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Quote".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genQuote operator isRaw quotedSynExpr isFromQueryExpression range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
      (operator,
       isRaw,
       quotedSynExpr,
       isFromQueryExpression,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Const".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genConst constant range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Const
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Typed".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyped expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
      (expr,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTuple exprs commaRanges range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
      (exprs,
       commaRanges,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArrayOrList isList exprs range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
      (isList,
       exprs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Record".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRecord baseInfo copyInfo recordFields range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Record
      (baseInfo,
       copyInfo,
       recordFields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.New".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNew isProtected typeName expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.New
      (isProtected,
       typeName,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genObjExpr objType argOpt bindings extraImpls newPos range =
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
  /// <returns>Constructed record.</returns>
  let genWhile spWhile whileBody doBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.While
      (spWhile,
       whileBody,
       doBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.For".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFor spFor id idBody item4 toBody doBody range =
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
  /// <returns>Constructed record.</returns>
  let genForEach spFor seqExprOnly isFromSource pattern enumExpr bodyExpr range =
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
  /// <returns>Constructed record.</returns>
  let genArrayOrListOfSeqExpr isList elements range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
      (isList,
       elements,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genCompExpr isArrayOrList isNotNakedRefCell expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
      (isArrayOrList,
       isNotNakedRefCell,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLambda fromMethod inLambdaSeq args body range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
      (fromMethod,
       inLambdaSeq,
       args,
       body,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMatchLambda item1 item2 clauses spBind range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
      (item1,
       item2,
       clauses,
       spBind,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Match".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMatch spBind matchExpr clauses isCexprExceptionMatch range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Match
      (spBind,
       matchExpr,
       clauses,
       isCexprExceptionMatch,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Do".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDo expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Do
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Assert".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAssert expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.App".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genApp exprAtomicFlag isInfix funcExpr argExpr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.App
      (exprAtomicFlag,
       isInfix,
       funcExpr,
       argExpr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeApp expr leftAngleRange typeNames commaRanges rightAngleRange typeArgs range =
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
  /// <returns>Constructed record.</returns>
  let genLetOrUse isRecursive isUse bindings exprBody range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
      (isRecursive,
       isUse,
       bindings,
       exprBody,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTryWith tryExpr item2 item3 item4 range spTry spWith =
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
  /// <returns>Constructed record.</returns>
  let genTryFinally tryExpr finallyExpr range spTry spFinally =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
      (tryExpr,
       finallyExpr,
       range,
       spTry,
       spFinally)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLazy expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSequential spSeq isTrueSeq expr1 expr2 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
      (spSeq,
       isTrueSeq,
       expr1,
       expr2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIfThenElse exprGuard exprThen optionalExprElse spIfToThen isFromErrorRecovery ifToThen range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
      (exprGuard,
       exprThen,
       optionalExprElse,
       spIfToThen,
       isFromErrorRecovery,
       ifToThen,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Ident".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIdent item =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Ident
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLongIdent isOptional longIdent altNameRefCell range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent
      (isOptional,
       longIdent,
       altNameRefCell,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLongIdentSet dotId expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
      (dotId,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotGet expr rangeOfDot dotId range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
      (expr,
       rangeOfDot,
       dotId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotSet expr dotId exprValue range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
      (expr,
       dotId,
       exprValue,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotIndexedGet expr indexExprs item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
      (expr,
       indexExprs,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotIndexedSet objectExpr indexExprs valueExpr rangeOfLeftOfSet rangeOfDot range =
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
  /// <returns>Constructed record.</returns>
  let genNamedIndexedPropertySet item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDotNamedIndexedPropertySet item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
      (item1,
       item2,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeTest expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUpcast expr typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
      (expr,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDowncast expr typeName range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
      (expr,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInferredUpcast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInferredDowncast expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Null".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNull range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Null
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAddressOf item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTraitCall item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genJoinIn item1 inPos item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
      (item1,
       inPos,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genImplicitZero range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genYieldOrReturn item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genYieldOrReturnFrom item1 expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
      (item1,
       expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLetOrUseBang spBind isUse isFromSource pattern rhsExpr bodyExpr range =
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
  /// <returns>Constructed record.</returns>
  let genDoBang expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLibraryOnlyILAssembly item1 item2 item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
      (item1,
       item2,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLibraryOnlyStaticOptimization item1 item2 item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
      (item1,
       item2,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLibraryOnlyUnionCaseFieldGet item1 longId item3 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
      (item1,
       longId,
       item3,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLibraryOnlyUnionCaseFieldSet item1 longId item3 item4 range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
      (item1,
       longId,
       item3,
       item4,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArbitraryAfterError debugStr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError
      (debugStr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFromParseError expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDiscardAfterMissingQualificationAfterDot expr range =
    Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFixed item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynField".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynField.Field".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genField attributes isStatic id typeName item5 xmlDoc accessiblity range =
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
  /// <returns>Constructed record.</returns>
  let genTwo item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOne item =
    Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInterfaceImpl item1 bindings range =
    Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
      (item1,
       bindings,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMatchClause".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genClause item1 item2 item3 range spTarget =
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
  /// <returns>Constructed record.</returns>
  let genNamed longId range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Named
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Product".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genProduct item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSeq item1 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDivide item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Power".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPower item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.One".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOne () =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.One

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnon item =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMeasure.Var".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVar item1 range =
    Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOpen longId range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMember memberDefn range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
      (memberDefn,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genImplicitCtor accessiblity attributes ctorArgs selfIdentifier range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
      (accessiblity,
       attributes,
       ctorArgs,
       selfIdentifier,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genImplicitInherit inheritType inheritArgs inheritAlias range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
      (inheritType,
       inheritArgs,
       inheritAlias,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLetBindings bindings isStatic isRecursive range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
      (bindings,
       isStatic,
       isRecursive,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAbstractSlot valSig memberFlags range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
      (valSig,
       memberFlags,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInterface typeName interfaceMembers range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
      (typeName,
       interfaceMembers,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInherit typeName id range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
      (typeName,
       id,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genValField field range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
      (field,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNestedType typeDefn accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
      (typeDefn,
       accessiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAutoProperty attributes isStatic id tyOpt propKind memberFlags xmlDoc accessibility expr getSetPos range =
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
  /// <returns>Constructed record.</returns>
  let genMember item1 memberFlags range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
      (item1,
       memberFlags,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInterface typeName range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInherit typeName range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genValField field range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
      (field,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNestedType typeDefnSig range =
    Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
      (typeDefnSig,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModuleAbbrev item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNestedModule item1 isRec item3 item4 item5 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
      (item1,
       isRec,
       item3,
       item4,
       item5)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLet item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDoExpr item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypes item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOpen item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAttributes item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genHashDirective item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
      (item1,
       item2)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamespaceFragment item =
    Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace".
  /// </summary>
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genModuleAbbrev id longId range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev
      (id,
       longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNestedModule item1 isRec moduleSigDecls range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
      (item1,
       isRec,
       moduleSigDecls,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVal valSig range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
      (valSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypes typeDefSigs range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
      (typeDefSigs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException exnSig range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
      (exnSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOpen longId range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open
      (longId,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genHashDirective hashDirective range =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
      (hashDirective,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamespaceFragment item =
    Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Const".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genConst constant range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Const
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Wild".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWild range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Wild
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Named".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNamed item1 id isThisVar accessiblity range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Named
      (item1,
       id,
       isThisVar,
       accessiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Typed".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyped item1 typeName range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Typed
      (item1,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Attrib".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAttrib item1 attributes range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
      (item1,
       attributes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Or".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOr item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Or
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Ands".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnds item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Ands
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLongIdent dotId item2 item3 item4 item5 range =
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
  /// <returns>Constructed record.</returns>
  let genTuple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Paren".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genParen item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Paren
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArrayOrList item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Record".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRecord fields range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Record
      (fields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.Null".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNull range =
    Microsoft.FSharp.Compiler.Ast.SynPat.Null
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genOptionalVal item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.IsInst".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genIsInst typeName range =
    Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genQuoteExpr expr range =
    Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDeprecatedCharRange item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInstanceMember item1 item2 item3 accesiblity range =
    Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
      (item1,
       item2,
       item3,
       accesiblity,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFromParseError item1 range =
    Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genInteger item =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRational item1 item2 item3 =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational
      (item1,
       item2,
       item3)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNegate item =
    Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynReturnInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynReturnInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSynReturnInfo item1 range =
    Microsoft.FSharp.Compiler.Ast.SynReturnInfo
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genId ident altNameRefCell isCompilerGenerated isThisVar isOptArg range =
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
  /// <returns>Constructed record.</returns>
  let genTyped item1 typeName range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
      (item1,
       typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAttrib item1 attributes range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
      (item1,
       attributes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUndecided item =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genDecided item =
    Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSimplePats item1 range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyped item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhenTyparTyconEqualsTycon item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhenTyparIsStruct item1 range =
    Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
      (item1,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypar".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypar.Typar".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypar id staticReq isCompGen =
    Microsoft.FSharp.Compiler.Ast.SynTypar.Typar
      (id,
       staticReq,
       isCompGen)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTyparDecl".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyparDecl attributes item2 =
    Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
      (attributes,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.LongIdent".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genLongIdent item =
    Microsoft.FSharp.Compiler.Ast.SynType.LongIdent
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.App".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genApp typeName leftAngleRange typeArgs commaRanges rightAngleRange isPostfix range =
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
  /// <returns>Constructed record.</returns>
  let genLongIdentApp typeName dotId leftAngleRange genericNames commaRanges rightAngleRange range =
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
  /// <returns>Constructed record.</returns>
  let genTuple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynType.Tuple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Array".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genArray item1 elementType range =
    Microsoft.FSharp.Compiler.Ast.SynType.Array
      (item1,
       elementType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Fun".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFun argType returnType range =
    Microsoft.FSharp.Compiler.Ast.SynType.Fun
      (argType,
       returnType,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Var".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genVar item1 range =
    Microsoft.FSharp.Compiler.Ast.SynType.Var
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.Anon".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genAnon range =
    Microsoft.FSharp.Compiler.Ast.SynType.Anon
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWithGlobalConstraints typeName constraints range =
    Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
      (typeName,
       constraints,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genHashConstraint typeName range =
    Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
      (typeName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMeasureDivide typeName item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
      (typeName,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMeasurePower typeName item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
      (typeName,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStaticConstant constant range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
      (constant,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStaticConstantExpr expr range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
      (expr,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genStaticConstantNamed item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
      (item1,
       item2,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsValueType genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsReferenceType genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsUnmanaged genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparSupportsNull genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsComparable genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsEquatable genericName range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
      (genericName,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparDefaultsToType genericName typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
      (genericName,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparSubtypeOfType genericName typeSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
      (genericName,
       typeSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparSupportsMember genericNames memberSig range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
      (genericNames,
       memberSig,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsEnum genericName enumTypes range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
      (genericName,
       enumTypes,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genWhereTyparIsDelegate genericName delegateTypes range =
    Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
      (genericName,
       delegateTypes,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefn".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeDefn item1 item2 members range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
      (item1,
       item2,
       members,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconUnspecified () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconClass () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconInterface () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconStruct () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconRecord () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconUnion () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconAbbrev () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconHiddenRepr () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconAugmentation () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconILAssemblyCode () =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTyconDelegate item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genObjectModel item1 members range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
      (item1,
       members,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSimple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException item =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeDefnSig item1 item2 memberSigs range =
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
  /// <returns>Constructed record.</returns>
  let genObjectModel item1 memberSigs range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
      (item1,
       memberSigs,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSimple item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException item =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnion accessiblity cases range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
      (accessiblity,
       cases,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genEnum cases range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
      (cases,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genRecord accessiblity fields range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
      (accessiblity,
       fields,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genGeneral item1 item2 item3 item4 item5 item6 item7 range =
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
  /// <returns>Constructed record.</returns>
  let genLibraryOnlyILAssembly item1 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly
      (item1,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeAbbrev item1 item2 range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
      (item1,
       item2,
       range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNone range =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None
      (range)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genException item =
    Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCase".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnionCase attributes id caseType xmlDoc accessibility range =
    Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
      (attributes,
       id,
       caseType,
       xmlDoc,
       accessibility,
       range)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCaseType".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnionCaseFields cases =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields
      (cases)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genUnionCaseFullType item =
    Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValData".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValData".
  /// </summary>
  /// <returns>Constructed record.</returns>
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
  /// <returns>Constructed record.</returns>
  let genSynValInfo item1 item2 =
    Microsoft.FSharp.Compiler.Ast.SynValInfo
      (item1,
       item2)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValSig".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genValSpfn attributes id typeParams typeName valInfo item6 isMutable xmlDoc accessiblity expr range =
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
  /// <returns>Constructed record.</returns>
  let genSynValTyparDecls item1 item2 constraints =
    Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
      (item1,
       item2,
       constraints)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Expr".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genExpr item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Expr
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Module".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModule item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Module
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.ModuleOrNamespace".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genModuleOrNamespace item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.ModuleOrNamespace
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.TypeDefn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genTypeDefn item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.TypeDefn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.MemberDefn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMemberDefn item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.MemberDefn
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.MatchClause".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMatchClause item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.MatchClause
      (item)

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Binding".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genBinding item =
    Microsoft.FSharp.Compiler.SourceCodeServices.AstTraversal.TraverseStep.Binding
      (item)

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.TyparStaticReq".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.TyparStaticReq.NoStaticReq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genNoStaticReq () =
    Microsoft.FSharp.Compiler.Ast.TyparStaticReq.NoStaticReq

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.TyparStaticReq.HeadTypeStaticReq".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genHeadTypeStaticReq () =
    Microsoft.FSharp.Compiler.Ast.TyparStaticReq.HeadTypeStaticReq

  ////////////////////////////////////////////////////
  /// Construct "Microsoft.FSharp.Compiler.Ast.XmlDoc".

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.XmlDoc".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genXmlDoc item =
    Microsoft.FSharp.Compiler.Ast.XmlDoc
      (item)

