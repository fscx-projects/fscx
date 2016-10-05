//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Wed, 05 Oct 2016 01:38:49 GMT
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
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitFsiInteraction
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
        ((visitHashDirective(dlgVisitor, symbolInformation, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedHashDirective
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitHashDirective
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective _ -> target

  /// <summary>
  /// Expression visitor function: ParsedImplFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFile
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, symbolInformation, context, v))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitImplFileFragment(dlgVisitor, symbolInformation, context, v))))

  /// <summary>
  /// Expression visitor function: ParsedImplFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileFragment
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
        (moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
        ((visitModuleOrNamespace(dlgVisitor, symbolInformation, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, symbolInformation, context, v))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedImplFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileInput
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
        (filename,
         isScript,
         item3,
         item4,
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, symbolInformation, context, v))),
         item6 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespace(dlgVisitor, symbolInformation, context, v))),
         item7)

  /// <summary>
  /// Expression visitor function: ParsedInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitInput
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile
        ((visitImplFileInput(dlgVisitor, symbolInformation, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile
        ((visitSigFileInput(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: ParsedSigFile
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFile
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFile) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, symbolInformation, context, v))),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSigFileFragment(dlgVisitor, symbolInformation, context, v))))

  /// <summary>
  /// Expression visitor function: ParsedSigFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileFragment
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
        (moduleSigDecl |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
        ((visitModuleOrNamespaceSig(dlgVisitor, symbolInformation, context, item)))
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, symbolInformation, context, v))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: ParsedSigFileInput
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileInput
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
        (filename,
         item2,
         item3,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective(dlgVisitor, symbolInformation, context, v))),
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespaceSig(dlgVisitor, symbolInformation, context, v))))

  /// <summary>
  /// Expression visitor function: SynAccess
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitAccess
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Public _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Private _ -> target

  /// <summary>
  /// Expression visitor function: SynArgInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitArgInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         optional,
         id)

  /// <summary>
  /// Expression visitor function: SynBinding
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBinding
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBinding.Binding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding.Binding
        (access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         (visitBindingKind(dlgVisitor, symbolInformation, context, bindingKind)),
         mustInline,
         isMutable,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         xmlDoc,
         (visitValData(dlgVisitor, symbolInformation, context, item7)),
         (visitPat(dlgVisitor, symbolInformation, context, headPat)),
         item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitBindingReturnInfo(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         lhsRange,
         spBind)

  /// <summary>
  /// Expression visitor function: SynBindingKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBindingKind
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding _ -> target

  /// <summary>
  /// Expression visitor function: SynBindingReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitBindingReturnInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         range,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)))

  /// <summary>
  /// Expression visitor function: SynComponentInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitComponentInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo.ComponentInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(dlgVisitor, symbolInformation, context, v))),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, symbolInformation, context, v))),
         item4,
         xmlDoc,
         preferPostfix,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitConst
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConst) =
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
        ((visitConst(dlgVisitor, symbolInformation, context, constant)),
         (visitMeasure(dlgVisitor, symbolInformation, context, item2)))

  /// <summary>
  /// Expression visitor function: SynConstructorArgs
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitConstructorArgs
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
        (item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, symbolInformation, context, v))))
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(dlgVisitor, symbolInformation, context, v1)))),
         range)

  /// <summary>
  /// Expression visitor function: SynEnumCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitEnumCase
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase(attributes, id, item3, xmlDoc, range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase.EnumCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitConst(dlgVisitor, symbolInformation, context, item3)),
         xmlDoc,
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefn
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
        ((visitExceptionDefnRepr(dlgVisitor, symbolInformation, context, exnRepr)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefnRepr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitUnionCase(dlgVisitor, symbolInformation, context, case)),
         longId,
         xmlDoc,
         accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionSig
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig
        ((visitExceptionDefnRepr(dlgVisitor, symbolInformation, context, exnRepr)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and private __visitExpr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         leftParenRange,
         rightParenRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
        ((visitExpr(dlgVisitor, symbolInformation, context, operator)),
         isRaw,
         (visitExpr(dlgVisitor, symbolInformation, context, quotedSynExpr)),
         isFromQueryExpression,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const
        ((visitConst(dlgVisitor, symbolInformation, context, constant)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         (visitType(dlgVisitor, symbolInformation, context, typeSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
        (exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
         commaRanges,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
        (isList,
         exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record
        (baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitType(dlgVisitor, symbolInformation, context, v0)), (visitExpr(dlgVisitor, symbolInformation, context, v1)), v2, v3, v4)),
         copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(dlgVisitor, symbolInformation, context, v0)), v1)),
         recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))), v2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New
        (isProtected,
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
        ((visitType(dlgVisitor, symbolInformation, context, objType)),
         argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr(dlgVisitor, symbolInformation, context, v0)), v1)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, symbolInformation, context, v))),
         extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitInterfaceImpl(dlgVisitor, symbolInformation, context, v))),
         newPos,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While
        (spWhile,
         (visitExpr(dlgVisitor, symbolInformation, context, whileBody)),
         (visitExpr(dlgVisitor, symbolInformation, context, doBody)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For
        (spFor,
         id,
         (visitExpr(dlgVisitor, symbolInformation, context, idBody)),
         item4,
         (visitExpr(dlgVisitor, symbolInformation, context, toBody)),
         (visitExpr(dlgVisitor, symbolInformation, context, doBody)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
        (spFor,
         seqExprOnly,
         isFromSource,
         (visitPat(dlgVisitor, symbolInformation, context, pattern)),
         (visitExpr(dlgVisitor, symbolInformation, context, enumExpr)),
         (visitExpr(dlgVisitor, symbolInformation, context, bodyExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
        (isList,
         (visitExpr(dlgVisitor, symbolInformation, context, elements)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
        (isArrayOrList,
         isNotNakedRefCell,
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
        (fromMethod,
         inLambdaSeq,
         (visitSimplePats(dlgVisitor, symbolInformation, context, args)),
         (visitExpr(dlgVisitor, symbolInformation, context, body)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
        (item1,
         item2,
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, symbolInformation, context, v))),
         spBind,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match
        (spBind,
         (visitExpr(dlgVisitor, symbolInformation, context, matchExpr)),
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, symbolInformation, context, v))),
         isCexprExceptionMatch,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App
        (exprAtomicFlag,
         isInfix,
         (visitExpr(dlgVisitor, symbolInformation, context, funcExpr)),
         (visitExpr(dlgVisitor, symbolInformation, context, argExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         leftAngleRange,
         typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         commaRanges,
         rightAngleRange,
         typeArgs,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
        (isRecursive,
         isUse,
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, exprBody)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
        ((visitExpr(dlgVisitor, symbolInformation, context, tryExpr)),
         item2,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause(dlgVisitor, symbolInformation, context, v))),
         item4,
         range,
         spTry,
         spWith)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
        ((visitExpr(dlgVisitor, symbolInformation, context, tryExpr)),
         (visitExpr(dlgVisitor, symbolInformation, context, finallyExpr)),
         range,
         spTry,
         spFinally)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
        (spSeq,
         isTrueSeq,
         (visitExpr(dlgVisitor, symbolInformation, context, expr1)),
         (visitExpr(dlgVisitor, symbolInformation, context, expr2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
        ((visitExpr(dlgVisitor, symbolInformation, context, exprGuard)),
         (visitExpr(dlgVisitor, symbolInformation, context, exprThen)),
         optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
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
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(dlgVisitor, symbolInformation, context, v.Value))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
        (dotId,
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         rangeOfDot,
         dotId,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         dotId,
         (visitExpr(dlgVisitor, symbolInformation, context, exprValue)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(dlgVisitor, symbolInformation, context, v))),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
        ((visitExpr(dlgVisitor, symbolInformation, context, objectExpr)),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, valueExpr)),
         rangeOfLeftOfSet,
         rangeOfDot,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
        (item1,
         (visitExpr(dlgVisitor, symbolInformation, context, item2)),
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         item2,
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         (visitExpr(dlgVisitor, symbolInformation, context, item4)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         (visitType(dlgVisitor, symbolInformation, context, typeSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
        (item1,
         (visitExpr(dlgVisitor, symbolInformation, context, item2)),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar(dlgVisitor, symbolInformation, context, v))),
         (visitMemberSig(dlgVisitor, symbolInformation, context, item2)),
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         inPos,
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
        (item1,
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
        (item1,
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
        (spBind,
         isUse,
         isFromSource,
         (visitPat(dlgVisitor, symbolInformation, context, pattern)),
         (visitExpr(dlgVisitor, symbolInformation, context, rhsExpr)),
         (visitExpr(dlgVisitor, symbolInformation, context, bodyExpr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitStaticOptimizationConstraint(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, item2)),
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         longId,
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         longId,
         item3,
         (visitExpr(dlgVisitor, symbolInformation, context, item4)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         item2)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitExpr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    match dlgVisitor((fun (si, c, t) -> visitExpr(dlgVisitor, si, c, t)), symbolInformation, context, target) with
    | Some expr -> expr
    | None -> __visitExpr(dlgVisitor, symbolInformation, context, target)

  /// <summary>
  /// Expression visitor function: SynField
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitField
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynField) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynField.Field(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynField.Field
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         id,
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         item5,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynIndexerArg
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitIndexerArg
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
        ((visitExpr(dlgVisitor, symbolInformation, context, item1)),
         (visitExpr(dlgVisitor, symbolInformation, context, item2)))
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
        ((visitExpr(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynInterfaceImpl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitInterfaceImpl
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl(item1, bindings, range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl.InterfaceImpl
        ((visitType(dlgVisitor, symbolInformation, context, item1)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynMatchClause
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMatchClause
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, item3)),
         range,
         spTarget)

  /// <summary>
  /// Expression visitor function: SynMeasure
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMeasure
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
        ((visitMeasure(dlgVisitor, symbolInformation, context, item1)),
         (visitMeasure(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMeasure(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
        ((visitMeasure(dlgVisitor, symbolInformation, context, item1)),
         (visitMeasure(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
        ((visitMeasure(dlgVisitor, symbolInformation, context, item1)),
         (visitRationalConst(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.One _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
        ((visitTypar(dlgVisitor, symbolInformation, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynMemberDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMemberDefn
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
        ((visitBinding(dlgVisitor, symbolInformation, context, memberDefn)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, symbolInformation, context, v))),
         selfIdentifier,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
        ((visitType(dlgVisitor, symbolInformation, context, inheritType)),
         (visitExpr(dlgVisitor, symbolInformation, context, inheritArgs)),
         inheritAlias,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
        (bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, symbolInformation, context, v))),
         isStatic,
         isRecursive,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
        ((visitValSig(dlgVisitor, symbolInformation, context, valSig)),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, symbolInformation, context, v)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         id,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
        ((visitField(dlgVisitor, symbolInformation, context, field)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
        ((visitTypeDefn(dlgVisitor, symbolInformation, context, typeDefn)),
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         isStatic,
         id,
         tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         propKind,
         memberFlags,
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         (visitExpr(dlgVisitor, symbolInformation, context, expr)),
         getSetPos,
         range)

  /// <summary>
  /// Expression visitor function: SynMemberSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitMemberSig
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
        ((visitValSig(dlgVisitor, symbolInformation, context, item1)),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
        ((visitField(dlgVisitor, symbolInformation, context, field)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
        ((visitTypeDefnSig(dlgVisitor, symbolInformation, context, typeDefnSig)),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleDecl
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
        ((visitComponentInfo(dlgVisitor, symbolInformation, context, item1)),
         isRec,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, symbolInformation, context, v))),
         item4,
         item5)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding(dlgVisitor, symbolInformation, context, v))),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
        (item1,
         (visitExpr(dlgVisitor, symbolInformation, context, item2)),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefn(dlgVisitor, symbolInformation, context, v))),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
        ((visitExceptionDefn(dlgVisitor, symbolInformation, context, item1)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
        ((visitHashDirective(dlgVisitor, symbolInformation, context, item1)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
        ((visitModuleOrNamespace(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespace
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespace
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
        (id,
         isRec,
         isModule,
         decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl(dlgVisitor, symbolInformation, context, v))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespaceSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespaceSig
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
        (id,
         isRec,
         isModule,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, symbolInformation, context, v))),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleSigDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitModuleSigDecl
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
        ((visitComponentInfo(dlgVisitor, symbolInformation, context, item1)),
         isRec,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
        ((visitValSig(dlgVisitor, symbolInformation, context, valSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
        (typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefnSig(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
        ((visitExceptionSig(dlgVisitor, symbolInformation, context, exnSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
        ((visitHashDirective(dlgVisitor, symbolInformation, context, hashDirective)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
        ((visitModuleOrNamespaceSig(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynPat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitPat
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynPat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const
        ((visitConst(dlgVisitor, symbolInformation, context, constant)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Wild _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         id,
         isThisVar,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         (visitPat(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
        (dotId,
         item2,
         item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitValTyparDecls(dlgVisitor, symbolInformation, context, v))),
         (visitConstructorArgs(dlgVisitor, symbolInformation, context, item4)),
         item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record
        (fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat(dlgVisitor, symbolInformation, context, v1)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
        (item1,
         item2,
         item3,
         accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
        ((visitPat(dlgVisitor, symbolInformation, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynRationalConst
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitRationalConst
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
        ((visitRationalConst(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitReturnInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo
        ((let v0, v1 = item1 in (visitType(dlgVisitor, symbolInformation, context, v0)), (visitArgInfo(dlgVisitor, symbolInformation, context, v1))),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePat
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePat
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
        (ident,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo(dlgVisitor, symbolInformation, context, v.Value))),
         isCompilerGenerated,
         isThisVar,
         isOptArg,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
        ((visitSimplePat(dlgVisitor, symbolInformation, context, item1)),
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
        ((visitSimplePat(dlgVisitor, symbolInformation, context, item1)),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePatAlternativeIdInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePatAlternativeIdInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided _ -> target

  /// <summary>
  /// Expression visitor function: SynSimplePats
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePats
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.SimplePats
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats.Typed
        ((visitSimplePats(dlgVisitor, symbolInformation, context, item1)),
         (visitType(dlgVisitor, symbolInformation, context, item2)),
         range)

  /// <summary>
  /// Expression visitor function: SynStaticOptimizationConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitStaticOptimizationConstraint
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
        ((visitTypar(dlgVisitor, symbolInformation, context, item1)),
         (visitType(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
        ((visitTypar(dlgVisitor, symbolInformation, context, item1)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypar
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypar
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypar.Typar _ -> target

  /// <summary>
  /// Expression visitor function: SynTyparDecl
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTyparDecl
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl(attributes, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl.TyparDecl
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         (visitTypar(dlgVisitor, symbolInformation, context, item2)))

  /// <summary>
  /// Expression visitor function: SynType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitType
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         leftAngleRange,
         typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         commaRanges,
         rightAngleRange,
         isPostfix,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         dotId,
         leftAngleRange,
         genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         commaRanges,
         rightAngleRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType(dlgVisitor, symbolInformation, context, v1)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array
        (item1,
         (visitType(dlgVisitor, symbolInformation, context, elementType)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun
        ((visitType(dlgVisitor, symbolInformation, context, argType)),
         (visitType(dlgVisitor, symbolInformation, context, returnType)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var
        ((visitTypar(dlgVisitor, symbolInformation, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         (visitType(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
        ((visitType(dlgVisitor, symbolInformation, context, typeName)),
         (visitRationalConst(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
        ((visitConst(dlgVisitor, symbolInformation, context, constant)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
        ((visitExpr(dlgVisitor, symbolInformation, context, expr)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
        ((visitType(dlgVisitor, symbolInformation, context, item1)),
         (visitType(dlgVisitor, symbolInformation, context, item2)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeConstraint
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeConstraint
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         (visitType(dlgVisitor, symbolInformation, context, typeSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         (visitType(dlgVisitor, symbolInformation, context, typeSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
        (genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar(dlgVisitor, symbolInformation, context, v))),
         (visitMemberSig(dlgVisitor, symbolInformation, context, memberSig)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
        ((visitTypar(dlgVisitor, symbolInformation, context, genericName)),
         delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefn
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefn
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn(item1, item2, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn.TypeDefn
        ((visitComponentInfo(dlgVisitor, symbolInformation, context, item1)),
         (visitTypeDefnRepr(dlgVisitor, symbolInformation, context, item2)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnKind
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnKind
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
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
        ((visitType(dlgVisitor, symbolInformation, context, item1)),
         (visitValInfo(dlgVisitor, symbolInformation, context, item2)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnRepr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
        ((visitTypeDefnKind(dlgVisitor, symbolInformation, context, item1)),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
        ((visitTypeDefnSimpleRepr(dlgVisitor, symbolInformation, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSig
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig(item1, item2, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig.TypeDefnSig
        ((visitComponentInfo(dlgVisitor, symbolInformation, context, item1)),
         (visitTypeDefnSigRepr(dlgVisitor, symbolInformation, context, item2)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnSigRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSigRepr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
        ((visitTypeDefnKind(dlgVisitor, symbolInformation, context, item1)),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
        ((visitTypeDefnSimpleRepr(dlgVisitor, symbolInformation, context, item1)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSimpleRepr
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSimpleRepr
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitUnionCase(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitEnumCase(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         fields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, symbolInformation, context, v))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
        ((visitTypeDefnKind(dlgVisitor, symbolInformation, context, item1)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitType(dlgVisitor, symbolInformation, context, v0)), v1, v2)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitValSig(dlgVisitor, symbolInformation, context, v0)), v1)),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, symbolInformation, context, v))),
         item5,
         item6,
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat(dlgVisitor, symbolInformation, context, v)))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
        (item1,
         (visitType(dlgVisitor, symbolInformation, context, item2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
        ((visitExceptionDefnRepr(dlgVisitor, symbolInformation, context, item)))

  /// <summary>
  /// Expression visitor function: SynUnionCase
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCase
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase.UnionCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitUnionCaseType(dlgVisitor, symbolInformation, context, caseType)),
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynUnionCaseType
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCaseType
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField(dlgVisitor, symbolInformation, context, v))))
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType
        ((let v0, v1 = item in (visitType(dlgVisitor, symbolInformation, context, v0)), (visitValInfo(dlgVisitor, symbolInformation, context, v1))))

  /// <summary>
  /// Expression visitor function: SynValData
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValData
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValData) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynValData
        (item1,
         (visitValInfo(dlgVisitor, symbolInformation, context, item2)),
         item3)

  /// <summary>
  /// Expression visitor function: SynValInfo
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValInfo
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitArgInfo(dlgVisitor, symbolInformation, context, v)))),
         (visitArgInfo(dlgVisitor, symbolInformation, context, item2)))

  /// <summary>
  /// Expression visitor function: SynValSig
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValSig
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute(v.TypeName, (visitExpr(dlgVisitor, symbolInformation, context, v.ArgExpr)), v.Target, v.AppliesToGetterAndSetter, v.Range)),
         id,
         (visitValTyparDecls(dlgVisitor, symbolInformation, context, typeParams)),
         (visitType(dlgVisitor, symbolInformation, context, typeName)),
         (visitValInfo(dlgVisitor, symbolInformation, context, valInfo)),
         item6,
         isMutable,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess(dlgVisitor, symbolInformation, context, v))),
         expr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr(dlgVisitor, symbolInformation, context, v))),
         range)

  /// <summary>
  /// Expression visitor function: SynValTyparDecls
  /// </summary>
  /// <typeparam name="'TContext">Custom context type.</typeparam>
  /// <param name="dlgVisitor">Visitor delegated function ((FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr) * FSharpCheckFileResults * 'TContext * SynExpr -> SynExpr option).</param>
  /// <param name="symbolInformation">Symbol information.</param>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <returns>Visited expression.</returns>
  and visitValTyparDecls
     (dlgVisitor: (Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr) * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults * 'TContext * Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option,
      symbolInformation: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults,
      context: 'TContext,
      target: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl(dlgVisitor, symbolInformation, context, v))),
         item2,
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint(dlgVisitor, symbolInformation, context, v))))
