//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Wed, 14 Sep 2016 09:27:59 GMT
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
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitFsiInteraction
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash
        ((visitHashDirective context item1 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: ParsedHashDirective
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitHashDirective
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective _ -> target

  /// <summary>
  /// Expression visitor function: ParsedImplFile
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFile
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFile)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective context v dlgVisitor)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitImplFileFragment context v dlgVisitor)))

  /// <summary>
  /// Expression visitor function: ParsedImplFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileFragment
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule
        (moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule
        ((visitModuleOrNamespace context item dlgVisitor))
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl context v dlgVisitor)),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         range)

  /// <summary>
  /// Expression visitor function: ParsedImplFileInput
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitImplFileInput
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7) ->
      Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
        (filename,
         isScript,
         item3,
         item4,
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective context v dlgVisitor)),
         item6 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespace context v dlgVisitor)),
         item7)

  /// <summary>
  /// Expression visitor function: ParsedInput
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitInput
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedInput)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile
        ((visitImplFileInput context item dlgVisitor))
    | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile
        ((visitSigFileInput context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: ParsedSigFile
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFile
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFile)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFile
        (hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective context v dlgVisitor)),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSigFileFragment context v dlgVisitor)))

  /// <summary>
  /// Expression visitor function: ParsedSigFileFragment
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileFragment
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule
        (moduleSigDecl |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule
        ((visitModuleOrNamespaceSig context item dlgVisitor))
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment
        (longId,
         item2,
         item3,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl context v dlgVisitor)),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         range)

  /// <summary>
  /// Expression visitor function: ParsedSigFileInput
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSigFileInput
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
        (filename,
         item2,
         item3,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitHashDirective context v dlgVisitor)),
         item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleOrNamespaceSig context v dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynAccess
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitAccess
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynAccess)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Public _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynAccess.Private _ -> target

  /// <summary>
  /// Expression visitor function: SynArgInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitArgInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynArgInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
      Microsoft.FSharp.Compiler.Ast.SynArgInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         optional,
         id)

  /// <summary>
  /// Expression visitor function: SynBinding
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBinding
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynBinding)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBinding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
      Microsoft.FSharp.Compiler.Ast.SynBinding
        (access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         (visitBindingKind context bindingKind dlgVisitor),
         mustInline,
         isMutable,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         xmlDoc,
         (visitValData context item7 dlgVisitor),
         (visitPat context headPat dlgVisitor),
         item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitBindingReturnInfo context v dlgVisitor)),
         (visitExpr context expr dlgVisitor),
         lhsRange,
         spBind)

  /// <summary>
  /// Expression visitor function: SynBindingKind
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBindingKind
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynBindingKind)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding _ -> target

  /// <summary>
  /// Expression visitor function: SynBindingReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitBindingReturnInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
      Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
        ((visitType context typeName dlgVisitor),
         range,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range))

  /// <summary>
  /// Expression visitor function: SynComponentInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitComponentInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynComponentInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynComponentInfo
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl context v dlgVisitor)),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint context v dlgVisitor)),
         item4,
         xmlDoc,
         preferPostfix,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynConst
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitConst
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynConst)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
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
        ((visitConst context constant dlgVisitor),
         (visitMeasure context item2 dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynConstructorArgs
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitConstructorArgs
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats
        (item |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat context v dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat context v1 dlgVisitor))),
         range)

  /// <summary>
  /// Expression visitor function: SynEnumCase
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitEnumCase
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynEnumCase)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynEnumCase(attributes, id, item3, xmlDoc, range) ->
      Microsoft.FSharp.Compiler.Ast.SynEnumCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         id,
         (visitConst context item3 dlgVisitor),
         xmlDoc,
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefn
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefn
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
        ((visitExceptionDefnRepr context exnRepr dlgVisitor),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionDefnRepr
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         (visitUnionCase context case dlgVisitor),
         longId,
         xmlDoc,
         accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynExceptionSig
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExceptionSig
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynExceptionSig)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExceptionSig
        ((visitExceptionDefnRepr context exnRepr dlgVisitor),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and private __visitExpr
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynExpr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Paren
        ((visitExpr context expr dlgVisitor),
         leftParenRange,
         rightParenRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Quote
        ((visitExpr context operator dlgVisitor),
         isRaw,
         (visitExpr context quotedSynExpr dlgVisitor),
         isFromQueryExpression,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Const
        ((visitConst context constant dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Typed
        ((visitExpr context expr dlgVisitor),
         (visitType context typeSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple
        (exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr context v dlgVisitor)),
         commaRanges,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList
        (isList,
         exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Record
        (baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (visitType context v0 dlgVisitor), (visitExpr context v1 dlgVisitor), v2, v3, v4)),
         copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr context v0 dlgVisitor), v1)),
         recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr context v dlgVisitor)), v2)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.New
        (isProtected,
         (visitType context typeName dlgVisitor),
         (visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr
        ((visitType context objType dlgVisitor),
         argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (visitExpr context v0 dlgVisitor), v1)),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding context v dlgVisitor)),
         extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitInterfaceImpl context v dlgVisitor)),
         newPos,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.While
        (spWhile,
         (visitExpr context whileBody dlgVisitor),
         (visitExpr context doBody dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.For
        (spFor,
         id,
         (visitExpr context idBody dlgVisitor),
         item4,
         (visitExpr context toBody dlgVisitor),
         (visitExpr context doBody dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach
        (spFor,
         seqExprOnly,
         isFromSource,
         (visitPat context pattern dlgVisitor),
         (visitExpr context enumExpr dlgVisitor),
         (visitExpr context bodyExpr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr
        (isList,
         (visitExpr context elements dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr
        (isArrayOrList,
         isNotNakedRefCell,
         (visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda
        (fromMethod,
         inLambdaSeq,
         (visitSimplePats context args dlgVisitor),
         (visitExpr context body dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda
        (item1,
         item2,
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause context v dlgVisitor)),
         spBind,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Match
        (spBind,
         (visitExpr context matchExpr dlgVisitor),
         clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause context v dlgVisitor)),
         isCexprExceptionMatch,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Do
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Assert
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.App
        (exprAtomicFlag,
         isInfix,
         (visitExpr context funcExpr dlgVisitor),
         (visitExpr context argExpr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp
        ((visitExpr context expr dlgVisitor),
         leftAngleRange,
         typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         commaRanges,
         rightAngleRange,
         typeArgs,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse
        (isRecursive,
         isUse,
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding context v dlgVisitor)),
         (visitExpr context exprBody dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith
        ((visitExpr context tryExpr dlgVisitor),
         item2,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMatchClause context v dlgVisitor)),
         item4,
         range,
         spTry,
         spWith)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally
        ((visitExpr context tryExpr dlgVisitor),
         (visitExpr context finallyExpr dlgVisitor),
         range,
         spTry,
         spFinally)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential
        (spSeq,
         isTrueSeq,
         (visitExpr context expr1 dlgVisitor),
         (visitExpr context expr2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse
        ((visitExpr context exprGuard dlgVisitor),
         (visitExpr context exprThen dlgVisitor),
         optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr context v dlgVisitor)),
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
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo context v.Value dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet
        (dotId,
         (visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet
        ((visitExpr context expr dlgVisitor),
         rangeOfDot,
         dotId,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet
        ((visitExpr context expr dlgVisitor),
         dotId,
         (visitExpr context exprValue dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet
        ((visitExpr context expr dlgVisitor),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg context v dlgVisitor)),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet
        ((visitExpr context objectExpr dlgVisitor),
         indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitIndexerArg context v dlgVisitor)),
         (visitExpr context valueExpr dlgVisitor),
         rangeOfLeftOfSet,
         rangeOfDot,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet
        (item1,
         (visitExpr context item2 dlgVisitor),
         (visitExpr context item3 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet
        ((visitExpr context item1 dlgVisitor),
         item2,
         (visitExpr context item3 dlgVisitor),
         (visitExpr context item4 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest
        ((visitExpr context expr dlgVisitor),
         (visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast
        ((visitExpr context expr dlgVisitor),
         (visitType context typeSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast
        ((visitExpr context expr dlgVisitor),
         (visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf
        (item1,
         (visitExpr context item2 dlgVisitor),
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar context v dlgVisitor)),
         (visitMemberSig context item2 dlgVisitor),
         (visitExpr context item3 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn
        ((visitExpr context item1 dlgVisitor),
         inPos,
         (visitExpr context item3 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn
        (item1,
         (visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom
        (item1,
         (visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang
        (spBind,
         isUse,
         isFromSource,
         (visitPat context pattern dlgVisitor),
         (visitExpr context rhsExpr dlgVisitor),
         (visitExpr context bodyExpr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitExpr context v dlgVisitor)),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitStaticOptimizationConstraint context v dlgVisitor)),
         (visitExpr context item2 dlgVisitor),
         (visitExpr context item3 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet
        ((visitExpr context item1 dlgVisitor),
         longId,
         item3,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet
        ((visitExpr context item1 dlgVisitor),
         longId,
         item3,
         (visitExpr context item4 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed
        ((visitExpr context item1 dlgVisitor),
         item2)

  /// <summary>
  /// Expression visitor function: SynExpr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitExpr
     (context: 'TContext)
     (target: SynExpr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match dlgVisitor context target with
    | Some expr -> expr
    | None -> __visitExpr context target dlgVisitor

  /// <summary>
  /// Expression visitor function: SynField
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitField
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynField)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynField(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynField
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         isStatic,
         id,
         (visitType context typeName dlgVisitor),
         item5,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynIndexerArg
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitIndexerArg
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynIndexerArg)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two
        ((visitExpr context item1 dlgVisitor),
         (visitExpr context item2 dlgVisitor))
    | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
      Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One
        ((visitExpr context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynInterfaceImpl
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitInterfaceImpl
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl(item1, bindings, range) ->
      Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl
        ((visitType context item1 dlgVisitor),
         bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynMatchClause
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMatchClause
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynMatchClause)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
      Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause
        ((visitPat context item1 dlgVisitor),
         item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr context v dlgVisitor)),
         (visitExpr context item3 dlgVisitor),
         range,
         spTarget)

  /// <summary>
  /// Expression visitor function: SynMeasure
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMeasure
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynMeasure)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Product
        ((visitMeasure context item1 dlgVisitor),
         (visitMeasure context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMeasure context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide
        ((visitMeasure context item1 dlgVisitor),
         (visitMeasure context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Power
        ((visitMeasure context item1 dlgVisitor),
         (visitRationalConst context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.One _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMeasure.Var
        ((visitTypar context item1 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynMemberDefn
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMemberDefn
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynMemberDefn)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member
        ((visitBinding context memberDefn dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat context v dlgVisitor)),
         selfIdentifier,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit
        ((visitType context inheritType dlgVisitor),
         (visitExpr context inheritArgs dlgVisitor),
         inheritAlias,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings
        (bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding context v dlgVisitor)),
         isStatic,
         isRecursive,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot
        ((visitValSig context valSig dlgVisitor),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface
        ((visitType context typeName dlgVisitor),
         interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn context v dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit
        ((visitType context typeName dlgVisitor),
         id,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField
        ((visitField context field dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType
        ((visitTypeDefn context typeDefn dlgVisitor),
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         isStatic,
         id,
         tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (visitType context v dlgVisitor)),
         propKind,
         memberFlags,
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         (visitExpr context expr dlgVisitor),
         getSetPos,
         range)

  /// <summary>
  /// Expression visitor function: SynMemberSig
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitMemberSig
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynMemberSig)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member
        ((visitValSig context item1 dlgVisitor),
         memberFlags,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface
        ((visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit
        ((visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField
        ((visitField context field dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType
        ((visitTypeDefnSig context typeDefnSig dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleDecl
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleDecl
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynModuleDecl)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule
        ((visitComponentInfo context item1 dlgVisitor),
         isRec,
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl context v dlgVisitor)),
         item4,
         item5)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitBinding context v dlgVisitor)),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr
        (item1,
         (visitExpr context item2 dlgVisitor),
         item3)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefn context v dlgVisitor)),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception
        ((visitExceptionDefn context item1 dlgVisitor),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective
        ((visitHashDirective context item1 dlgVisitor),
         item2)
    | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment
        ((visitModuleOrNamespace context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespace
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespace
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
        (id,
         isRec,
         isModule,
         decls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleDecl context v dlgVisitor)),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         access |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleOrNamespaceSig
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleOrNamespaceSig
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
        (id,
         isRec,
         isModule,
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl context v dlgVisitor)),
         xmlDoc,
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynModuleSigDecl
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitModuleSigDecl
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule
        ((visitComponentInfo context item1 dlgVisitor),
         isRec,
         moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (visitModuleSigDecl context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val
        ((visitValSig context valSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types
        (typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeDefnSig context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception
        ((visitExceptionSig context exnSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective
        ((visitHashDirective context hashDirective dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
      Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment
        ((visitModuleOrNamespaceSig context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynPat
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitPat
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynPat)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Const
        ((visitConst context constant dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Wild _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Named
        ((visitPat context item1 dlgVisitor),
         id,
         isThisVar,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Typed
        ((visitPat context item1 dlgVisitor),
         (visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Attrib
        ((visitPat context item1 dlgVisitor),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Or
        ((visitPat context item1 dlgVisitor),
         (visitPat context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Ands
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent
        (dotId,
         item2,
         item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitValTyparDecls context v dlgVisitor)),
         (visitConstructorArgs context item4 dlgVisitor),
         item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Paren
        ((visitPat context item1 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList
        (item1,
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitPat context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.Record
        (fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitPat context v1 dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.Null _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.IsInst
        ((visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember
        (item1,
         item2,
         item3,
         accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError
        ((visitPat context item1 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynRationalConst
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitRationalConst
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynRationalConst)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
      Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate
        ((visitRationalConst context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynReturnInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitReturnInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynReturnInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynReturnInfo
        ((let v0, v1 = item1 in (visitType context v0 dlgVisitor), (visitArgInfo context v1 dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePat
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePat
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynSimplePat)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
      use _rwh_ = new RefWrapperHolder()
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id
        (ident,
         altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (visitSimplePatAlternativeIdInfo context v.Value dlgVisitor)),
         isCompilerGenerated,
         isThisVar,
         isOptArg,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed
        ((visitSimplePat context item1 dlgVisitor),
         (visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib
        ((visitSimplePat context item1 dlgVisitor),
         attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         range)

  /// <summary>
  /// Expression visitor function: SynSimplePatAlternativeIdInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePatAlternativeIdInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided _ -> target

  /// <summary>
  /// Expression visitor function: SynSimplePats
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitSimplePats
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynSimplePats)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynSimplePats
        ((visitSimplePats context item1 dlgVisitor),
         (visitType context item2 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynStaticOptimizationConstraint
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitStaticOptimizationConstraint
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon
        ((visitTypar context item1 dlgVisitor),
         (visitType context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct
        ((visitTypar context item1 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynTypar
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypar
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypar)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypar _ -> target

  /// <summary>
  /// Expression visitor function: SynTyparDecl
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTyparDecl
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTyparDecl)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTyparDecl(attributes, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynTyparDecl
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         (visitTypar context item2 dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynType
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitType
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynType)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.App
        ((visitType context typeName dlgVisitor),
         leftAngleRange,
         typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         commaRanges,
         rightAngleRange,
         isPostfix,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp
        ((visitType context typeName dlgVisitor),
         dotId,
         leftAngleRange,
         genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         commaRanges,
         rightAngleRange,
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Tuple
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (visitType context v1 dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Array
        (item1,
         (visitType context elementType dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Fun
        ((visitType context argType dlgVisitor),
         (visitType context returnType dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.Var
        ((visitTypar context item1 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.Anon _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints
        ((visitType context typeName dlgVisitor),
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint
        ((visitType context typeName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide
        ((visitType context typeName dlgVisitor),
         (visitType context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower
        ((visitType context typeName dlgVisitor),
         (visitRationalConst context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant
        ((visitConst context constant dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr
        ((visitExpr context expr dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed
        ((visitType context item1 dlgVisitor),
         (visitType context item2 dlgVisitor),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeConstraint
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeConstraint
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable
        ((visitTypar context genericName dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType
        ((visitTypar context genericName dlgVisitor),
         (visitType context typeSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType
        ((visitTypar context genericName dlgVisitor),
         (visitType context typeSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember
        (genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypar context v dlgVisitor)),
         (visitMemberSig context memberSig dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum
        ((visitTypar context genericName dlgVisitor),
         enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate
        ((visitTypar context genericName dlgVisitor),
         delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (visitType context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefn
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefn
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefn)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefn(item1, item2, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefn
        ((visitComponentInfo context item1 dlgVisitor),
         (visitTypeDefnRepr context item2 dlgVisitor),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnKind
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnKind
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
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
        ((visitType context item1 dlgVisitor),
         (visitValInfo context item2 dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynTypeDefnRepr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnRepr
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel
        ((visitTypeDefnKind context item1 dlgVisitor),
         members |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberDefn context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple
        ((visitTypeDefnSimpleRepr context item1 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception
        ((visitExceptionDefnRepr context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSig
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSig
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig(item1, item2, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig
        ((visitComponentInfo context item1 dlgVisitor),
         (visitTypeDefnSigRepr context item2 dlgVisitor),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynTypeDefnSigRepr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSigRepr
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel
        ((visitTypeDefnKind context item1 dlgVisitor),
         memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (visitMemberSig context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple
        ((visitTypeDefnSimpleRepr context item1 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception
        ((visitExceptionDefnRepr context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynTypeDefnSimpleRepr
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitTypeDefnSimpleRepr
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitUnionCase context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitEnumCase context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record
        (accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         fields |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField context v dlgVisitor)),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General
        ((visitTypeDefnKind context item1 dlgVisitor),
         item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (visitType context v0 dlgVisitor), v1, v2)),
         item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (visitValSig context v0 dlgVisitor), v1)),
         item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField context v dlgVisitor)),
         item5,
         item6,
         item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitSimplePat context v dlgVisitor))),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev
        (item1,
         (visitType context item2 dlgVisitor),
         range)
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None _ -> target
    | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
      Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception
        ((visitExceptionDefnRepr context item dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynUnionCase
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCase
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynUnionCase)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCase
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         id,
         (visitUnionCaseType context caseType dlgVisitor),
         xmlDoc,
         accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynUnionCaseType
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitUnionCaseType
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields
        (cases |> Microsoft.FSharp.Collections.List.map (fun v -> (visitField context v dlgVisitor)))
    | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
      Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType
        ((let v0, v1 = item in (visitType context v0 dlgVisitor), (visitValInfo context v1 dlgVisitor)))

  /// <summary>
  /// Expression visitor function: SynValData
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValData
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynValData)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
      Microsoft.FSharp.Compiler.Ast.SynValData
        (item1,
         (visitValInfo context item2 dlgVisitor),
         item3)

  /// <summary>
  /// Expression visitor function: SynValInfo
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValInfo
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynValInfo)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
      Microsoft.FSharp.Compiler.Ast.SynValInfo
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (visitArgInfo context v dlgVisitor))),
         (visitArgInfo context item2 dlgVisitor))

  /// <summary>
  /// Expression visitor function: SynValSig
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValSig
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynValSig)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
      Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn
        (attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (visitExpr context v.ArgExpr dlgVisitor) v.Target v.AppliesToGetterAndSetter v.Range),
         id,
         (visitValTyparDecls context typeParams dlgVisitor),
         (visitType context typeName dlgVisitor),
         (visitValInfo context valInfo dlgVisitor),
         item6,
         isMutable,
         xmlDoc,
         accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (visitAccess context v dlgVisitor)),
         expr |> Microsoft.FSharp.Core.Option.map (fun v -> (visitExpr context v dlgVisitor)),
         range)

  /// <summary>
  /// Expression visitor function: SynValTyparDecls
  /// </summary>
  /// <typeparam name="'TContext">Context instance type.</typeparam>
  /// <param name="context">Context instance.</param>
  /// <param name="target">Visit target expression.</param>
  /// <param name="dlgVisitor">Visitor delegated function ('TContext -> SynExpr -> SynExpr option).</param>
  /// <returns>Visited expression.</returns>
  and visitValTyparDecls
     (context: 'TContext)
     (target: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls)
     (dlgVisitor: 'TContext -> Microsoft.FSharp.Compiler.Ast.SynExpr -> Microsoft.FSharp.Compiler.Ast.SynExpr option) =
    match target with
    | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
      Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
        (item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTyparDecl context v dlgVisitor)),
         item2,
         constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (visitTypeConstraint context v dlgVisitor)))
