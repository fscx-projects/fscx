//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 04 Oct 2016 08:05:56 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open Microsoft.FSharp.Compiler.Ast

#nowarn "1182"

[<AutoOpen>]
module AstFunctionalVisitor =

  let rec private visitDummy () = ()

  /// <summary>
  /// Expression visitor function: ParsedFsiInteraction
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitFsiInteraction
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
        ((visitHashDirective(symbolInformation, context, item1, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedHashDirective
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitHashDirective
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective _ -> target

  /// <summary>
  /// Expression visitor function: ParsedImplFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFile
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFile,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(symbolInformation, context, v, dlgVisitor))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitImplFileFragment(symbolInformation, context, v, dlgVisitor))))

  /// <summary>
  /// Expression visitor function: ParsedImplFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileFragment
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
        (moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
        ((visitModuleOrNamespace(symbolInformation, context, item, dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(symbolInformation, context, v, dlgVisitor))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedImplFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileInput
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
        (filename,
         isScript,
         item3,
         item4,
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(symbolInformation, context, v, dlgVisitor))),
         item6 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespace(symbolInformation, context, v, dlgVisitor))),
         item7)

  /// <summary>
  /// Expression visitor function: ParsedInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitInput
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedInput,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile
        ((visitImplFileInput(symbolInformation, context, item, dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile
        ((visitSigFileInput(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: ParsedSigFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFile
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFile,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(symbolInformation, context, v, dlgVisitor))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSigFileFragment(symbolInformation, context, v, dlgVisitor))))

  /// <summary>
  /// Expression visitor function: ParsedSigFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileFragment
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
        (moduleSigDecl |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
        ((visitModuleOrNamespaceSig(symbolInformation, context, item, dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(symbolInformation, context, v, dlgVisitor))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedSigFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileInput
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
        (filename,
         item2,
         item3,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(symbolInformation, context, v, dlgVisitor))),
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespaceSig(symbolInformation, context, v, dlgVisitor))))

  /// <summary>
  /// Expression visitor function: SynAccess
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitAccess
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynAccess,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Public _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Private _ -> target

  /// <summary>
  /// Expression visitor function: SynArgInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitArgInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynArgInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         optional,
         id)

  /// <summary>
  /// Expression visitor function: SynBinding
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBinding
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBinding,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding.Binding
        (access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         (visitBindingKind(symbolInformation, context, bindingKind, dlgVisitor)),
         mustInline,
         isMutable,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         xmlDoc,
         (visitValData(symbolInformation, context, item7, dlgVisitor)),
         (visitPat(symbolInformation, context, headPat, dlgVisitor)),
         item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitBindingReturnInfo(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         lhsRange,
         spBind)

  /// <summary>
  /// Expression visitor function: SynBindingKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBindingKind
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingKind,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding _ -> target

  /// <summary>
  /// Expression visitor function: SynBindingReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBindingReturnInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         range,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)))

  /// <summary>
  /// Expression visitor function: SynComponentInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitComponentInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(symbolInformation, context, v, dlgVisitor))),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(symbolInformation, context, v, dlgVisitor))),
         item4,
         xmlDoc,
         preferPostfix,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitConst
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConst,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConst.Unit _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bool _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.SByte _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Byte _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int16 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int32 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Int64 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64 _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Single _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Double _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Char _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.String _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynConst.Measure
        ((visitConst(symbolInformation, context, constant, dlgVisitor)),
         (visitMeasure(symbolInformation, context, item2, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynConstructorArgs
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitConstructorArgs
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
        (item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(symbolInformation, context, v, dlgVisitor))))
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(symbolInformation, context, v1, dlgVisitor)))),
         range)

  /// <summary>
  /// Expression visitor function: SynEnumCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitEnumCase
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynEnumCase,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitConst(symbolInformation, context, item3, dlgVisitor)),
         xmlDoc,
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefn
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
        ((visitExceptionDefnRepr(symbolInformation, context, exnRepr, dlgVisitor)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefnRepr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitUnionCase(symbolInformation, context, case, dlgVisitor)),
         longId,
         xmlDoc,
         accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionSig
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig
        ((visitExceptionDefnRepr(symbolInformation, context, exnRepr, dlgVisitor)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and private __visitExpr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExpr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         leftParenRange,
         rightParenRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
        ((visitExpr(symbolInformation, context, operator, dlgVisitor)),
         isRaw,
         (visitExpr(symbolInformation, context, quotedSynExpr, dlgVisitor)),
         isFromQueryExpression,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const
        ((visitConst(symbolInformation, context, constant, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         (visitType(symbolInformation, context, typeSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
        (exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         commaRanges,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
        (isList,
         exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record
        (baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitType(symbolInformation, context, v0, dlgVisitor)), (visitExpr(symbolInformation, context, v1, dlgVisitor)), v2, v3, v4)),
         copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(symbolInformation, context, v0, dlgVisitor)), v1)),
         recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))), v2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New
        (isProtected,
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
        ((visitType(symbolInformation, context, objType, dlgVisitor)),
         argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(symbolInformation, context, v0, dlgVisitor)), v1)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(symbolInformation, context, v, dlgVisitor))),
         extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitInterfaceImpl(symbolInformation, context, v, dlgVisitor))),
         newPos,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While
        (spWhile,
         (visitExpr(symbolInformation, context, whileBody, dlgVisitor)),
         (visitExpr(symbolInformation, context, doBody, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For
        (spFor,
         id,
         (visitExpr(symbolInformation, context, idBody, dlgVisitor)),
         item4,
         (visitExpr(symbolInformation, context, toBody, dlgVisitor)),
         (visitExpr(symbolInformation, context, doBody, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
        (spFor,
         seqExprOnly,
         isFromSource,
         (visitPat(symbolInformation, context, pattern, dlgVisitor)),
         (visitExpr(symbolInformation, context, enumExpr, dlgVisitor)),
         (visitExpr(symbolInformation, context, bodyExpr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
        (isList,
         (visitExpr(symbolInformation, context, elements, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
        (isArrayOrList,
         isNotNakedRefCell,
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
        (fromMethod,
         inLambdaSeq,
         (visitSimplePats(symbolInformation, context, args, dlgVisitor)),
         (visitExpr(symbolInformation, context, body, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
        (item1,
         item2,
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(symbolInformation, context, v, dlgVisitor))),
         spBind,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match
        (spBind,
         (visitExpr(symbolInformation, context, matchExpr, dlgVisitor)),
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(symbolInformation, context, v, dlgVisitor))),
         isCexprExceptionMatch,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App
        (exprAtomicFlag,
         isInfix,
         (visitExpr(symbolInformation, context, funcExpr, dlgVisitor)),
         (visitExpr(symbolInformation, context, argExpr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         leftAngleRange,
         typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         commaRanges,
         rightAngleRange,
         typeArgs,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
        (isRecursive,
         isUse,
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, exprBody, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
        ((visitExpr(symbolInformation, context, tryExpr, dlgVisitor)),
         item2,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(symbolInformation, context, v, dlgVisitor))),
         item4,
         range,
         spTry,
         spWith)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
        ((visitExpr(symbolInformation, context, tryExpr, dlgVisitor)),
         (visitExpr(symbolInformation, context, finallyExpr, dlgVisitor)),
         range,
         spTry,
         spFinally)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
        (spSeq,
         isTrueSeq,
         (visitExpr(symbolInformation, context, expr1, dlgVisitor)),
         (visitExpr(symbolInformation, context, expr2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
        ((visitExpr(symbolInformation, context, exprGuard, dlgVisitor)),
         (visitExpr(symbolInformation, context, exprThen, dlgVisitor)),
         optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         spIfToThen,
         isFromErrorRecovery,
         ifToThen,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent
        (isOptional,
         longIdent,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(symbolInformation, context, v.Value, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
        (dotId,
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         rangeOfDot,
         dotId,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         dotId,
         (visitExpr(symbolInformation, context, exprValue, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(symbolInformation, context, v, dlgVisitor))),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
        ((visitExpr(symbolInformation, context, objectExpr, dlgVisitor)),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, valueExpr, dlgVisitor)),
         rangeOfLeftOfSet,
         rangeOfDot,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
        (item1,
         (visitExpr(symbolInformation, context, item2, dlgVisitor)),
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         item2,
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         (visitExpr(symbolInformation, context, item4, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         (visitType(symbolInformation, context, typeSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
        (item1,
         (visitExpr(symbolInformation, context, item2, dlgVisitor)),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar(symbolInformation, context, v, dlgVisitor))),
         (visitMemberSig(symbolInformation, context, item2, dlgVisitor)),
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         inPos,
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
        (item1,
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
        (item1,
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
        (spBind,
         isUse,
         isFromSource,
         (visitPat(symbolInformation, context, pattern, dlgVisitor)),
         (visitExpr(symbolInformation, context, rhsExpr, dlgVisitor)),
         (visitExpr(symbolInformation, context, bodyExpr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitStaticOptimizationConstraint(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, item2, dlgVisitor)),
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         longId,
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         longId,
         item3,
         (visitExpr(symbolInformation, context, item4, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         item2)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExpr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: SynExpr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match dlgVisitor(symbolInformation, context, target) with
    | Some expr -> expr
    | None -> __visitExpr(symbolInformation, context, target, dlgVisitor)

  /// <summary>
  /// Expression visitor function: SynField
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitField
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynField,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynField.Field
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         id,
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         item5,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynIndexerArg
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitIndexerArg
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynIndexerArg,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
        ((visitExpr(symbolInformation, context, item1, dlgVisitor)),
         (visitExpr(symbolInformation, context, item2, dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
        ((visitExpr(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynInterfaceImpl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitInterfaceImpl
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
        ((visitType(symbolInformation, context, item1, dlgVisitor)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynMatchClause
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMatchClause
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMatchClause,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, item3, dlgVisitor)),
         range,
         spTarget)

  /// <summary>
  /// Expression visitor function: SynMeasure
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMeasure
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMeasure,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
        ((visitMeasure(symbolInformation, context, item1, dlgVisitor)),
         (visitMeasure(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMeasure(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
        ((visitMeasure(symbolInformation, context, item1, dlgVisitor)),
         (visitMeasure(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
        ((visitMeasure(symbolInformation, context, item1, dlgVisitor)),
         (visitRationalConst(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.One _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
        ((visitTypar(symbolInformation, context, item1, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynMemberDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMemberDefn
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberDefn,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
        ((visitBinding(symbolInformation, context, memberDefn, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(symbolInformation, context, v, dlgVisitor))),
         selfIdentifier,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
        ((visitType(symbolInformation, context, inheritType, dlgVisitor)),
         (visitExpr(symbolInformation, context, inheritArgs, dlgVisitor)),
         inheritAlias,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
        (bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(symbolInformation, context, v, dlgVisitor))),
         isStatic,
         isRecursive,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
        ((visitValSig(symbolInformation, context, valSig, dlgVisitor)),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(symbolInformation, context, v, dlgVisitor)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         id,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
        ((visitField(symbolInformation, context, field, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
        ((visitTypeDefn(symbolInformation, context, typeDefn, dlgVisitor)),
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         id,
         tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         propKind,
         memberFlags,
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         (visitExpr(symbolInformation, context, expr, dlgVisitor)),
         getSetPos,
         range)

  /// <summary>
  /// Expression visitor function: SynMemberSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMemberSig
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
        ((visitValSig(symbolInformation, context, item1, dlgVisitor)),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
        ((visitField(symbolInformation, context, field, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
        ((visitTypeDefnSig(symbolInformation, context, typeDefnSig, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleDecl
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleDecl,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
        ((visitComponentInfo(symbolInformation, context, item1, dlgVisitor)),
         isRec,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(symbolInformation, context, v, dlgVisitor))),
         item4,
         item5)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(symbolInformation, context, v, dlgVisitor))),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
        (item1,
         (visitExpr(symbolInformation, context, item2, dlgVisitor)),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefn(symbolInformation, context, v, dlgVisitor))),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
        ((visitExceptionDefn(symbolInformation, context, item1, dlgVisitor)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
        ((visitHashDirective(symbolInformation, context, item1, dlgVisitor)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
        ((visitModuleOrNamespace(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespace
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespace
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
        (id,
         isRec,
         isModule,
         decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(symbolInformation, context, v, dlgVisitor))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespaceSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespaceSig
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
        (id,
         isRec,
         isModule,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(symbolInformation, context, v, dlgVisitor))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleSigDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleSigDecl
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
        ((visitComponentInfo(symbolInformation, context, item1, dlgVisitor)),
         isRec,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
        ((visitValSig(symbolInformation, context, valSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
        (typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefnSig(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
        ((visitExceptionSig(symbolInformation, context, exnSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
        ((visitHashDirective(symbolInformation, context, hashDirective, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
        ((visitModuleOrNamespaceSig(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynPat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitPat
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynPat,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const
        ((visitConst(symbolInformation, context, constant, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Wild _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         id,
         isThisVar,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         (visitPat(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
        (dotId,
         item2,
         item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitValTyparDecls(symbolInformation, context, v, dlgVisitor))),
         (visitConstructorArgs(symbolInformation, context, item4, dlgVisitor)),
         item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record
        (fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(symbolInformation, context, v1, dlgVisitor)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
        (item1,
         item2,
         item3,
         accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
        ((visitPat(symbolInformation, context, item1, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynRationalConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitRationalConst
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
        ((visitRationalConst(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitReturnInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynReturnInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo
        ((let v0, v1 = item1 in (visitType(symbolInformation, context, v0, dlgVisitor)), (visitArgInfo(symbolInformation, context, v1, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePat
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
        (ident,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(symbolInformation, context, v.Value, dlgVisitor))),
         isCompilerGenerated,
         isThisVar,
         isOptArg,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
        ((visitSimplePat(symbolInformation, context, item1, dlgVisitor)),
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
        ((visitSimplePat(symbolInformation, context, item1, dlgVisitor)),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePatAlternativeIdInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePatAlternativeIdInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided _ -> target

  /// <summary>
  /// Expression visitor function: SynSimplePats
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePats
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
        ((visitSimplePats(symbolInformation, context, item1, dlgVisitor)),
         (visitType(symbolInformation, context, item2, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynStaticOptimizationConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitStaticOptimizationConstraint
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
        ((visitTypar(symbolInformation, context, item1, dlgVisitor)),
         (visitType(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
        ((visitTypar(symbolInformation, context, item1, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypar
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypar
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypar,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar _ -> target

  /// <summary>
  /// Expression visitor function: SynTyparDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTyparDecl
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTyparDecl,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitTypar(symbolInformation, context, item2, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitType
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynType,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         leftAngleRange,
         typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         commaRanges,
         rightAngleRange,
         isPostfix,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         dotId,
         leftAngleRange,
         genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         commaRanges,
         rightAngleRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType(symbolInformation, context, v1, dlgVisitor)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array
        (item1,
         (visitType(symbolInformation, context, elementType, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun
        ((visitType(symbolInformation, context, argType, dlgVisitor)),
         (visitType(symbolInformation, context, returnType, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var
        ((visitTypar(symbolInformation, context, item1, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         (visitType(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
        ((visitType(symbolInformation, context, typeName, dlgVisitor)),
         (visitRationalConst(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
        ((visitConst(symbolInformation, context, constant, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
        ((visitExpr(symbolInformation, context, expr, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
        ((visitType(symbolInformation, context, item1, dlgVisitor)),
         (visitType(symbolInformation, context, item2, dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeConstraint
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         (visitType(symbolInformation, context, typeSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         (visitType(symbolInformation, context, typeSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
        (genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar(symbolInformation, context, v, dlgVisitor))),
         (visitMemberSig(symbolInformation, context, memberSig, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
        ((visitTypar(symbolInformation, context, genericName, dlgVisitor)),
         delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefn
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
        ((visitComponentInfo(symbolInformation, context, item1, dlgVisitor)),
         (visitTypeDefnRepr(symbolInformation, context, item2, dlgVisitor)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnKind
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate
        ((visitType(symbolInformation, context, item1, dlgVisitor)),
         (visitValInfo(symbolInformation, context, item2, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnRepr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
        ((visitTypeDefnKind(symbolInformation, context, item1, dlgVisitor)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
        ((visitTypeDefnSimpleRepr(symbolInformation, context, item1, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
        ((visitExceptionDefnRepr(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSig
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig
        ((visitComponentInfo(symbolInformation, context, item1, dlgVisitor)),
         (visitTypeDefnSigRepr(symbolInformation, context, item2, dlgVisitor)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnSigRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSigRepr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
        ((visitTypeDefnKind(symbolInformation, context, item1, dlgVisitor)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
        ((visitTypeDefnSimpleRepr(symbolInformation, context, item1, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
        ((visitExceptionDefnRepr(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSimpleRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSimpleRepr
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitUnionCase(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitEnumCase(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         fields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(symbolInformation, context, v, dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
        ((visitTypeDefnKind(symbolInformation, context, item1, dlgVisitor)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitType(symbolInformation, context, v0, dlgVisitor)), v1, v2)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitValSig(symbolInformation, context, v0, dlgVisitor)), v1)),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(symbolInformation, context, v, dlgVisitor))),
         item5,
         item6,
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(symbolInformation, context, v, dlgVisitor)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
        (item1,
         (visitType(symbolInformation, context, item2, dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
        ((visitExceptionDefnRepr(symbolInformation, context, item, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynUnionCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCase
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitUnionCaseType(symbolInformation, context, caseType, dlgVisitor)),
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynUnionCaseType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCaseType
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(symbolInformation, context, v, dlgVisitor))))
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType
        ((let v0, v1 = item in (visitType(symbolInformation, context, v0, dlgVisitor)), (visitValInfo(symbolInformation, context, v1, dlgVisitor))))

  /// <summary>
  /// Expression visitor function: SynValData
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValData
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValData,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynValData
        (item1,
         (visitValInfo(symbolInformation, context, item2, dlgVisitor)),
         item3)

  /// <summary>
  /// Expression visitor function: SynValInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValInfo
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValInfo,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitArgInfo(symbolInformation, context, v, dlgVisitor)))),
         (visitArgInfo(symbolInformation, context, item2, dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynValSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValSig
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValSig,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(symbolInformation, context, v.ArgExpr, dlgVisitor)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitValTyparDecls(symbolInformation, context, typeParams, dlgVisitor)),
         (visitType(symbolInformation, context, typeName, dlgVisitor)),
         (visitValInfo(symbolInformation, context, valInfo, dlgVisitor)),
         item6,
         isMutable,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(symbolInformation, context, v, dlgVisitor))),
         expr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(symbolInformation, context, v, dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynValTyparDecls
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function (FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValTyparDecls
     (symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls,
      dlgVisitor: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(symbolInformation, context, v, dlgVisitor))),
         item2,
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(symbolInformation, context, v, dlgVisitor))))
