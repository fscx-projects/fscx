//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Wed, 14 Sep 2016 09:27:59 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

#nowarn "44"
#nowarn "1182"

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST delegatable visitor.
/// </summary>
/// <typeparam name="TContext">Context type</typeparam>
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
[<Obsolete>]
type AstDelegatableVisitor<'TContext> private (parentParents: System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.Visitor.AstElement>) =

  // TODO: du element
  let parents = parentParents

  /// <summary>
  /// Constructor.
  /// </summary>
  new() =
    AstDelegatableVisitor<'TContext>(new System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.Visitor.AstElement>())

  /// <summary>
  /// Parent nodes
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  /// <summary>
  /// Create child visitor.
  /// </summary> 
  /// <returns>Child empty visitor.</returns>
  member __.CreateChild() =
    new AstDelegatableVisitor<'TContext>(parents)

  //////////////////////////////////////////////
  // Expression: ParsedFsiInteraction

  /// <summary>
  /// Before visit "ParsedFsiInteraction.IDefns" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitFsiInteraction_IDefns =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedFsiInteraction.IDefns" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitFsiInteraction_IDefns =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedFsiInteraction.IHash" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitFsiInteraction_IHash =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedFsiInteraction.IHash" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitFsiInteraction_IHash =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedFsiInteraction" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedFsiInteraction">ParsedFsiInteraction expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitFsiInteraction
      (context: 'TContext)
      (parsedFsiInteraction: Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.FsiInteraction parsedFsiInteraction)
    try
      match parsedFsiInteraction with
      | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range) ->
        match this.BeforeVisitFsiInteraction_IDefns(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleDecl context v)), range
          match this.VisitFsiInteraction_IDefns(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IDefns(item1, range)
      | Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range) ->
        match this.BeforeVisitFsiInteraction_IHash(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitHashDirective context item1), range
          match this.VisitFsiInteraction_IHash(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction.IHash(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedHashDirective

  /// <summary>
  /// Before visit "ParsedHashDirective.ParsedHashDirective" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitHashDirective_ParsedHashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: string,
       item2: string list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedHashDirective.ParsedHashDirective" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitHashDirective_ParsedHashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: string,
       item2: string list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedHashDirective" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedHashDirective">ParsedHashDirective expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitHashDirective
      (context: 'TContext)
      (parsedHashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.HashDirective parsedHashDirective)
    try
      match parsedHashDirective with
      | Microsoft.FSharp.Compiler.Ast.ParsedHashDirective(item1, item2, range) ->
        match this.BeforeVisitHashDirective_ParsedHashDirective(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = item1, item2, range
          match this.VisitHashDirective_ParsedHashDirective(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedHashDirective(item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedImplFile

  /// <summary>
  /// Before visit "ParsedImplFile.ParsedImplFile" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitImplFile_ParsedImplFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirectives: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item2: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment list) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedImplFile.ParsedImplFile" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitImplFile_ParsedImplFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirectives: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item2: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment list) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedImplFile" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedImplFile">ParsedImplFile expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitImplFile
      (context: 'TContext)
      (parsedImplFile: Microsoft.FSharp.Compiler.Ast.ParsedImplFile) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ImplFile parsedImplFile)
    try
      match parsedImplFile with
      | Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2) ->
        match this.BeforeVisitImplFile_ParsedImplFile(this, context, hashDirectives, item2) with
        | Some result -> result
        | None ->
          let hashDirectives, item2 = hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitHashDirective context v)), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitImplFileFragment context v))
          match this.VisitImplFile_ParsedImplFile(this, context, hashDirectives, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedImplFile(hashDirectives, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedImplFileFragment

  /// <summary>
  /// Before visit "ParsedImplFileFragment.AnonModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitImplFileFragment_AnonModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       moduleDecls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedImplFileFragment.AnonModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitImplFileFragment_AnonModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       moduleDecls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedImplFileFragment.NamedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitImplFileFragment_NamedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedImplFileFragment.NamedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitImplFileFragment_NamedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedImplFileFragment.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitImplFileFragment_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item2: bool,
       item3: bool,
       moduleDecls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedImplFileFragment.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitImplFileFragment_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item2: bool,
       item3: bool,
       moduleDecls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedImplFileFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedImplFileFragment">ParsedImplFileFragment expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitImplFileFragment
      (context: 'TContext)
      (parsedImplFileFragment: Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ImplFileFragment parsedImplFileFragment)
    try
      match parsedImplFileFragment with
      | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range) ->
        match this.BeforeVisitImplFileFragment_AnonModule(this, context, moduleDecls, range) with
        | Some result -> result
        | None ->
          let moduleDecls, range = moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleDecl context v)), range
          match this.VisitImplFileFragment_AnonModule(this, context, moduleDecls, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.AnonModule(moduleDecls, range)
      | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item) ->
        match this.BeforeVisitImplFileFragment_NamedModule(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitModuleOrNamespace context item)
          match this.VisitImplFileFragment_NamedModule(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamedModule(item)
      | Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range) ->
        match this.BeforeVisitImplFileFragment_NamespaceFragment(this, context, longId, item2, item3, moduleDecls, xmlDoc, attributes, range) with
        | Some result -> result
        | None ->
          let longId, item2, item3, moduleDecls, xmlDoc, attributes, range = longId, item2, item3, moduleDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleDecl context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range
          match this.VisitImplFileFragment_NamespaceFragment(this, context, longId, item2, item3, moduleDecls, xmlDoc, attributes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment.NamespaceFragment(longId, item2, item3, moduleDecls, xmlDoc, attributes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedImplFileInput

  /// <summary>
  /// Before visit "ParsedImplFileInput.ParsedImplFileInput" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitImplFileInput_ParsedImplFileInput =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       filename: string,
       isScript: bool,
       item3: Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile,
       item4: Microsoft.FSharp.Compiler.Ast.ScopedPragma list,
       item5: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item6: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace list,
       item7: (bool * bool)) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedImplFileInput.ParsedImplFileInput" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitImplFileInput_ParsedImplFileInput =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       filename: string,
       isScript: bool,
       item3: Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile,
       item4: Microsoft.FSharp.Compiler.Ast.ScopedPragma list,
       item5: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item6: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace list,
       item7: (bool * bool)) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedImplFileInput" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedImplFileInput">ParsedImplFileInput expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitImplFileInput
      (context: 'TContext)
      (parsedImplFileInput: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ImplFileInput parsedImplFileInput)
    try
      match parsedImplFileInput with
      | Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7) ->
        match this.BeforeVisitImplFileInput_ParsedImplFileInput(this, context, filename, isScript, item3, item4, item5, item6, item7) with
        | Some result -> result
        | None ->
          let filename, isScript, item3, item4, item5, item6, item7 = filename, isScript, item3, item4, item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitHashDirective context v)), item6 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleOrNamespace context v)), item7
          match this.VisitImplFileInput_ParsedImplFileInput(this, context, filename, isScript, item3, item4, item5, item6, item7) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput(filename, isScript, item3, item4, item5, item6, item7)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedInput

  /// <summary>
  /// Before visit "ParsedInput.ImplFile" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitInput_ImplFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedInput.ImplFile" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitInput_ImplFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedInput.SigFile" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitInput_SigFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedInput.SigFile" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitInput_SigFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedInput" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedInput">ParsedInput expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitInput
      (context: 'TContext)
      (parsedInput: Microsoft.FSharp.Compiler.Ast.ParsedInput) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Input parsedInput)
    try
      match parsedInput with
      | Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item) ->
        match this.BeforeVisitInput_ImplFile(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitImplFileInput context item)
          match this.VisitInput_ImplFile(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedInput.ImplFile(item)
      | Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item) ->
        match this.BeforeVisitInput_SigFile(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitSigFileInput context item)
          match this.VisitInput_SigFile(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedInput.SigFile(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedSigFile

  /// <summary>
  /// Before visit "ParsedSigFile.ParsedSigFile" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSigFile_ParsedSigFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirectives: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item2: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment list) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedSigFile.ParsedSigFile" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSigFile_ParsedSigFile =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirectives: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item2: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment list) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedSigFile" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedSigFile">ParsedSigFile expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSigFile
      (context: 'TContext)
      (parsedSigFile: Microsoft.FSharp.Compiler.Ast.ParsedSigFile) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SigFile parsedSigFile)
    try
      match parsedSigFile with
      | Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2) ->
        match this.BeforeVisitSigFile_ParsedSigFile(this, context, hashDirectives, item2) with
        | Some result -> result
        | None ->
          let hashDirectives, item2 = hashDirectives |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitHashDirective context v)), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitSigFileFragment context v))
          match this.VisitSigFile_ParsedSigFile(this, context, hashDirectives, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedSigFile(hashDirectives, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedSigFileFragment

  /// <summary>
  /// Before visit "ParsedSigFileFragment.AnonModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSigFileFragment_AnonModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       moduleSigDecl: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedSigFileFragment.AnonModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSigFileFragment_AnonModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       moduleSigDecl: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedSigFileFragment.NamedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSigFileFragment_NamedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedSigFileFragment.NamedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSigFileFragment_NamedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) -> None
    with get, set

  /// <summary>
  /// Before visit "ParsedSigFileFragment.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSigFileFragment_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item2: bool,
       item3: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedSigFileFragment.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSigFileFragment_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item2: bool,
       item3: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedSigFileFragment" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedSigFileFragment">ParsedSigFileFragment expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSigFileFragment
      (context: 'TContext)
      (parsedSigFileFragment: Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SigFileFragment parsedSigFileFragment)
    try
      match parsedSigFileFragment with
      | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range) ->
        match this.BeforeVisitSigFileFragment_AnonModule(this, context, moduleSigDecl, range) with
        | Some result -> result
        | None ->
          let moduleSigDecl, range = moduleSigDecl |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleSigDecl context v)), range
          match this.VisitSigFileFragment_AnonModule(this, context, moduleSigDecl, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.AnonModule(moduleSigDecl, range)
      | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item) ->
        match this.BeforeVisitSigFileFragment_NamedModule(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitModuleOrNamespaceSig context item)
          match this.VisitSigFileFragment_NamedModule(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamedModule(item)
      | Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) ->
        match this.BeforeVisitSigFileFragment_NamespaceFragment(this, context, longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) with
        | Some result -> result
        | None ->
          let longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range = longId, item2, item3, moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleSigDecl context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range
          match this.VisitSigFileFragment_NamespaceFragment(this, context, longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment.NamespaceFragment(longId, item2, item3, moduleSigDecls, xmlDoc, attributes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: ParsedSigFileInput

  /// <summary>
  /// Before visit "ParsedSigFileInput.ParsedSigFileInput" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSigFileInput_ParsedSigFileInput =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       filename: string,
       item2: Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile,
       item3: Microsoft.FSharp.Compiler.Ast.ScopedPragma list,
       item4: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item5: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig list) -> None
    with get, set

  /// <summary>
  /// Visit "ParsedSigFileInput.ParsedSigFileInput" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSigFileInput_ParsedSigFileInput =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       filename: string,
       item2: Microsoft.FSharp.Compiler.Ast.QualifiedNameOfFile,
       item3: Microsoft.FSharp.Compiler.Ast.ScopedPragma list,
       item4: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective list,
       item5: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig list) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "ParsedSigFileInput" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="parsedSigFileInput">ParsedSigFileInput expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSigFileInput
      (context: 'TContext)
      (parsedSigFileInput: Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SigFileInput parsedSigFileInput)
    try
      match parsedSigFileInput with
      | Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5) ->
        match this.BeforeVisitSigFileInput_ParsedSigFileInput(this, context, filename, item2, item3, item4, item5) with
        | Some result -> result
        | None ->
          let filename, item2, item3, item4, item5 = filename, item2, item3, item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitHashDirective context v)), item5 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleOrNamespaceSig context v))
          match this.VisitSigFileInput_ParsedSigFileInput(this, context, filename, item2, item3, item4, item5) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput(filename, item2, item3, item4, item5)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynAccess

  /// <summary>
  /// Before visit "SynAccess.Public" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitAccess_Public =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynAccess.Public" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitAccess_Public =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynAccess.Internal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitAccess_Internal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynAccess.Internal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitAccess_Internal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynAccess.Private" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitAccess_Private =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynAccess.Private" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitAccess_Private =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynAccess" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synAccess">SynAccess expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitAccess
      (context: 'TContext)
      (synAccess: Microsoft.FSharp.Compiler.Ast.SynAccess) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Access synAccess)
    try
      match synAccess with
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Public ->
        match this.BeforeVisitAccess_Public(this, context) with
        | Some result -> result
        | None ->
          match this.VisitAccess_Public(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynAccess.Public
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Internal ->
        match this.BeforeVisitAccess_Internal(this, context) with
        | Some result -> result
        | None ->
          match this.VisitAccess_Internal(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynAccess.Internal
      | Microsoft.FSharp.Compiler.Ast.SynAccess.Private ->
        match this.BeforeVisitAccess_Private(this, context) with
        | Some result -> result
        | None ->
          match this.VisitAccess_Private(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynAccess.Private
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynArgInfo

  /// <summary>
  /// Before visit "SynArgInfo.SynArgInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitArgInfo_SynArgInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       optional: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option) -> None
    with get, set

  /// <summary>
  /// Visit "SynArgInfo.SynArgInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitArgInfo_SynArgInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       optional: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynArgInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synArgInfo">SynArgInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitArgInfo
      (context: 'TContext)
      (synArgInfo: Microsoft.FSharp.Compiler.Ast.SynArgInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ArgInfo synArgInfo)
    try
      match synArgInfo with
      | Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id) ->
        match this.BeforeVisitArgInfo_SynArgInfo(this, context, attributes, optional, id) with
        | Some result -> result
        | None ->
          let attributes, optional, id = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), optional, id
          match this.VisitArgInfo_SynArgInfo(this, context, attributes, optional, id) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynArgInfo(attributes, optional, id)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBinding

  /// <summary>
  /// Before visit "SynBinding.Binding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitBinding_Binding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind,
       mustInline: bool,
       isMutable: bool,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       item7: Microsoft.FSharp.Compiler.Ast.SynValData,
       headPat: Microsoft.FSharp.Compiler.Ast.SynPat,
       item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       lhsRange: Microsoft.FSharp.Compiler.Range.range,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) -> None
    with get, set

  /// <summary>
  /// Visit "SynBinding.Binding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitBinding_Binding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       bindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind,
       mustInline: bool,
       isMutable: bool,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       item7: Microsoft.FSharp.Compiler.Ast.SynValData,
       headPat: Microsoft.FSharp.Compiler.Ast.SynPat,
       item9: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       lhsRange: Microsoft.FSharp.Compiler.Range.range,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynBinding" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBinding">SynBinding expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBinding
      (context: 'TContext)
      (synBinding: Microsoft.FSharp.Compiler.Ast.SynBinding) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Binding synBinding)
    try
      match synBinding with
      | Microsoft.FSharp.Compiler.Ast.SynBinding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) ->
        match this.BeforeVisitBinding_Binding(this, context, access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) with
        | Some result -> result
        | None ->
          let access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind = access |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), (this.VisitBindingKind context bindingKind), mustInline, isMutable, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), xmlDoc, (this.VisitValData context item7), (this.VisitPat context headPat), item9 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitBindingReturnInfo context v)), (this.VisitExpr context expr), lhsRange, spBind
          match this.VisitBinding_Binding(this, context, access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynBinding(access, bindingKind, mustInline, isMutable, attributes, xmlDoc, item7, headPat, item9, expr, lhsRange, spBind)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingKind

  /// <summary>
  /// Before visit "SynBindingKind.StandaloneExpression" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitBindingKind_StandaloneExpression =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.StandaloneExpression" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitBindingKind_StandaloneExpression =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynBindingKind.NormalBinding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitBindingKind_NormalBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.NormalBinding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitBindingKind_NormalBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynBindingKind.DoBinding" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitBindingKind_DoBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynBindingKind.DoBinding" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitBindingKind_DoBinding =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynBindingKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingKind">SynBindingKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingKind
      (context: 'TContext)
      (synBindingKind: Microsoft.FSharp.Compiler.Ast.SynBindingKind) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.BindingKind synBindingKind)
    try
      match synBindingKind with
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression ->
        match this.BeforeVisitBindingKind_StandaloneExpression(this, context) with
        | Some result -> result
        | None ->
          match this.VisitBindingKind_StandaloneExpression(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynBindingKind.StandaloneExpression
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding ->
        match this.BeforeVisitBindingKind_NormalBinding(this, context) with
        | Some result -> result
        | None ->
          match this.VisitBindingKind_NormalBinding(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynBindingKind.NormalBinding
      | Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding ->
        match this.BeforeVisitBindingKind_DoBinding(this, context) with
        | Some result -> result
        | None ->
          match this.VisitBindingKind_DoBinding(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynBindingKind.DoBinding
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynBindingReturnInfo

  /// <summary>
  /// Before visit "SynBindingReturnInfo.SynBindingReturnInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitBindingReturnInfo_SynBindingReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) -> None
    with get, set

  /// <summary>
  /// Visit "SynBindingReturnInfo.SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitBindingReturnInfo_SynBindingReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynBindingReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synBindingReturnInfo">SynBindingReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitBindingReturnInfo
      (context: 'TContext)
      (synBindingReturnInfo: Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.BindingReturnInfo synBindingReturnInfo)
    try
      match synBindingReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes) ->
        match this.BeforeVisitBindingReturnInfo_SynBindingReturnInfo(this, context, typeName, range, attributes) with
        | Some result -> result
        | None ->
          let typeName, range, attributes = (this.VisitType context typeName), range, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range)
          match this.VisitBindingReturnInfo_SynBindingReturnInfo(this, context, typeName, range, attributes) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo(typeName, range, attributes)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynComponentInfo

  /// <summary>
  /// Before visit "SynComponentInfo.ComponentInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitComponentInfo_ComponentInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       item4: Microsoft.FSharp.Compiler.Ast.Ident list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       preferPostfix: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynComponentInfo.ComponentInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitComponentInfo_ComponentInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       item4: Microsoft.FSharp.Compiler.Ast.Ident list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       preferPostfix: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynComponentInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synComponentInfo">SynComponentInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitComponentInfo
      (context: 'TContext)
      (synComponentInfo: Microsoft.FSharp.Compiler.Ast.SynComponentInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ComponentInfo synComponentInfo)
    try
      match synComponentInfo with
      | Microsoft.FSharp.Compiler.Ast.SynComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) ->
        match this.BeforeVisitComponentInfo_ComponentInfo(this, context, attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) with
        | Some result -> result
        | None ->
          let attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), typeParams |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTyparDecl context v)), constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypeConstraint context v)), item4, xmlDoc, preferPostfix, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitComponentInfo_ComponentInfo(this, context, attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynComponentInfo(attributes, typeParams, constraints, item4, xmlDoc, preferPostfix, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConst

  /// <summary>
  /// Before visit "SynConst.Unit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Unit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Unit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Unit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Bool" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Bool =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: bool) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Bool" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Bool =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: bool) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.SByte" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_SByte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.SByte) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.SByte" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_SByte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.SByte) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Byte" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Byte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: byte) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Byte" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Byte =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: byte) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int16" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Int16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int16) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Int16" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Int16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int16) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt16" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UInt16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt16" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UInt16 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int32" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Int32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Int32" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Int32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt32" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UInt32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt32) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt32" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UInt32 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt32) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Int64" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Int64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Int64" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Int64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt64" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UInt64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt64" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UInt64 =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.IntPtr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_IntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.IntPtr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_IntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int64) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UIntPtr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UIntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UIntPtr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UIntPtr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt64) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Single" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Single =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Single) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Single" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Single =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Single) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Double" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Double =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Double) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Double" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Double =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Double) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Char" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Char =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: char) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Char" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Char =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: char) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Decimal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Decimal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Decimal) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Decimal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Decimal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.Decimal) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UserNum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UserNum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (string * string)) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UserNum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UserNum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (string * string)) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.String" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_String =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       text: string,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.String" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_String =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       text: string,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Bytes" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Bytes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bytes: byte[],
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Bytes" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Bytes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bytes: byte[],
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.UInt16s" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_UInt16s =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16[]) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.UInt16s" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_UInt16s =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: System.UInt16[]) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConst.Measure" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConst_Measure =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) -> None
    with get, set

  /// <summary>
  /// Visit "SynConst.Measure" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConst_Measure =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConst">SynConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConst
      (context: 'TContext)
      (synConst: Microsoft.FSharp.Compiler.Ast.SynConst) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Const synConst)
    try
      match synConst with
      | Microsoft.FSharp.Compiler.Ast.SynConst.Unit ->
        match this.BeforeVisitConst_Unit(this, context) with
        | Some result -> result
        | None ->
          match this.VisitConst_Unit(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Unit
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item) ->
        match this.BeforeVisitConst_Bool(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Bool(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Bool(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item) ->
        match this.BeforeVisitConst_SByte(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_SByte(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.SByte(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item) ->
        match this.BeforeVisitConst_Byte(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Byte(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Byte(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item) ->
        match this.BeforeVisitConst_Int16(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Int16(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Int16(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item) ->
        match this.BeforeVisitConst_UInt16(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UInt16(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UInt16(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item) ->
        match this.BeforeVisitConst_Int32(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Int32(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Int32(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item) ->
        match this.BeforeVisitConst_UInt32(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UInt32(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UInt32(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item) ->
        match this.BeforeVisitConst_Int64(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Int64(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Int64(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item) ->
        match this.BeforeVisitConst_UInt64(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UInt64(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UInt64(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item) ->
        match this.BeforeVisitConst_IntPtr(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_IntPtr(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.IntPtr(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item) ->
        match this.BeforeVisitConst_UIntPtr(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UIntPtr(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UIntPtr(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Single(item) ->
        match this.BeforeVisitConst_Single(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Single(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Single(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Double(item) ->
        match this.BeforeVisitConst_Double(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Double(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Double(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Char(item) ->
        match this.BeforeVisitConst_Char(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Char(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Char(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item) ->
        match this.BeforeVisitConst_Decimal(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_Decimal(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Decimal(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item) ->
        match this.BeforeVisitConst_UserNum(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UserNum(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UserNum(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range) ->
        match this.BeforeVisitConst_String(this, context, text, range) with
        | Some result -> result
        | None ->
          let text, range = text, range
          match this.VisitConst_String(this, context, text, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.String(text, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range) ->
        match this.BeforeVisitConst_Bytes(this, context, bytes, range) with
        | Some result -> result
        | None ->
          let bytes, range = bytes, range
          match this.VisitConst_Bytes(this, context, bytes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Bytes(bytes, range)
      | Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item) ->
        match this.BeforeVisitConst_UInt16s(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitConst_UInt16s(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.UInt16s(item)
      | Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2) ->
        match this.BeforeVisitConst_Measure(this, context, constant, item2) with
        | Some result -> result
        | None ->
          let constant, item2 = (this.VisitConst context constant), (this.VisitMeasure context item2)
          match this.VisitConst_Measure(this, context, constant, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConst.Measure(constant, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynConstructorArgs

  /// <summary>
  /// Before visit "SynConstructorArgs.Pats" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConstructorArgs_Pats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynPat list) -> None
    with get, set

  /// <summary>
  /// Visit "SynConstructorArgs.Pats" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConstructorArgs_Pats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynPat list) -> None
    with get, set

  /// <summary>
  /// Before visit "SynConstructorArgs.NamePatPairs" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitConstructorArgs_NamePatPairs =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynConstructorArgs.NamePatPairs" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitConstructorArgs_NamePatPairs =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.Ident * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynConstructorArgs" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synConstructorArgs">SynConstructorArgs expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitConstructorArgs
      (context: 'TContext)
      (synConstructorArgs: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ConstructorArgs synConstructorArgs)
    try
      match synConstructorArgs with
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item) ->
        match this.BeforeVisitConstructorArgs_Pats(this, context, item) with
        | Some result -> result
        | None ->
          let item = item |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitPat context v))
          match this.VisitConstructorArgs_Pats(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.Pats(item)
      | Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range) ->
        match this.BeforeVisitConstructorArgs_NamePatPairs(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (this.VisitPat context v1))), range
          match this.VisitConstructorArgs_NamePatPairs(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynConstructorArgs.NamePatPairs(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynEnumCase

  /// <summary>
  /// Before visit "SynEnumCase.EnumCase" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitEnumCase_EnumCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.SynConst,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynEnumCase.EnumCase" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitEnumCase_EnumCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.SynConst,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynEnumCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synEnumCase">SynEnumCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitEnumCase
      (context: 'TContext)
      (synEnumCase: Microsoft.FSharp.Compiler.Ast.SynEnumCase) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.EnumCase synEnumCase)
    try
      match synEnumCase with
      | Microsoft.FSharp.Compiler.Ast.SynEnumCase(attributes, id, item3, xmlDoc, range) ->
        match this.BeforeVisitEnumCase_EnumCase(this, context, attributes, id, item3, xmlDoc, range) with
        | Some result -> result
        | None ->
          let attributes, id, item3, xmlDoc, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (this.VisitConst context item3), xmlDoc, range
          match this.VisitEnumCase_EnumCase(this, context, attributes, id, item3, xmlDoc, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynEnumCase(attributes, id, item3, xmlDoc, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefn

  /// <summary>
  /// Before visit "SynExceptionDefn.SynExceptionDefn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExceptionDefn_SynExceptionDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExceptionDefn.SynExceptionDefn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExceptionDefn_SynExceptionDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynExceptionDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefn">SynExceptionDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefn
      (context: 'TContext)
      (synExceptionDefn: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ExceptionDefn synExceptionDefn)
    try
      match synExceptionDefn with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range) ->
        match this.BeforeVisitExceptionDefn_SynExceptionDefn(this, context, exnRepr, members, range) with
        | Some result -> result
        | None ->
          let exnRepr, members, range = (this.VisitExceptionDefnRepr context exnRepr), members |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberDefn context v)), range
          match this.VisitExceptionDefn_SynExceptionDefn(this, context, exnRepr, members, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefn(exnRepr, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionDefnRepr

  /// <summary>
  /// Before visit "SynExceptionDefnRepr.SynExceptionDefnRepr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExceptionDefnRepr.SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExceptionDefnRepr_SynExceptionDefnRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       case: Microsoft.FSharp.Compiler.Ast.SynUnionCase,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list option,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accesibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynExceptionDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionDefnRepr">SynExceptionDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionDefnRepr
      (context: 'TContext)
      (synExceptionDefnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ExceptionDefnRepr synExceptionDefnRepr)
    try
      match synExceptionDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range) ->
        match this.BeforeVisitExceptionDefnRepr_SynExceptionDefnRepr(this, context, item1, case, longId, xmlDoc, accesibility, range) with
        | Some result -> result
        | None ->
          let item1, case, longId, xmlDoc, accesibility, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), (this.VisitUnionCase context case), longId, xmlDoc, accesibility |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitExceptionDefnRepr_SynExceptionDefnRepr(this, context, item1, case, longId, xmlDoc, accesibility, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr(item1, case, longId, xmlDoc, accesibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExceptionSig

  /// <summary>
  /// Before visit "SynExceptionSig.SynExceptionSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExceptionSig_SynExceptionSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExceptionSig.SynExceptionSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExceptionSig_SynExceptionSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnRepr: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynExceptionSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExceptionSig">SynExceptionSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExceptionSig
      (context: 'TContext)
      (synExceptionSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ExceptionSig synExceptionSig)
    try
      match synExceptionSig with
      | Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range) ->
        match this.BeforeVisitExceptionSig_SynExceptionSig(this, context, exnRepr, memberSigs, range) with
        | Some result -> result
        | None ->
          let exnRepr, memberSigs, range = (this.VisitExceptionDefnRepr context exnRepr), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberSig context v)), range
          match this.VisitExceptionSig_SynExceptionSig(this, context, exnRepr, memberSigs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExceptionSig(exnRepr, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynExpr

  /// <summary>
  /// Before visit "SynExpr.Paren" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftParenRange: Microsoft.FSharp.Compiler.Range.range,
       rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Paren" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftParenRange: Microsoft.FSharp.Compiler.Range.range,
       rightParenRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Quote" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Quote =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isRaw: bool,
       quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isFromQueryExpression: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Quote" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Quote =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       operator: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isRaw: bool,
       quotedSynExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       isFromQueryExpression: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Const" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Const" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArrayOrList" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArrayOrList" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       exprs: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
       copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
       recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       baseInfo: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Range.range * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option * Microsoft.FSharp.Compiler.Range.range) option,
       copyInfo: (Microsoft.FSharp.Compiler.Ast.SynExpr * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option)) option,
       recordFields: ((Microsoft.FSharp.Compiler.Ast.LongIdentWithDots * bool) * Microsoft.FSharp.Compiler.Ast.SynExpr option * (Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Range.pos option) option) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.New" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_New =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isProtected: bool,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.New" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_New =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isProtected: bool,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ObjExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ObjExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objType: Microsoft.FSharp.Compiler.Ast.SynType,
       argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
       newPos: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ObjExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ObjExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objType: Microsoft.FSharp.Compiler.Ast.SynType,
       argOpt: (Microsoft.FSharp.Compiler.Ast.SynExpr * Microsoft.FSharp.Compiler.Ast.Ident option) option,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       extraImpls: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl list,
       newPos: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.While" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_While =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
       whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.While" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_While =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spWhile: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWhileLoop,
       whileBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.For" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_For =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: bool,
       toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.For" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_For =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       idBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: bool,
       toBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       doBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ForEach" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ForEach =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ForEach" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ForEach =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spFor: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForForLoop,
       seqExprOnly: Microsoft.FSharp.Compiler.Ast.SeqExprOnly,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       enumExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArrayOrListOfSeqExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ArrayOrListOfSeqExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArrayOrListOfSeqExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ArrayOrListOfSeqExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isList: bool,
       elements: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.CompExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_CompExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isArrayOrList: bool,
       isNotNakedRefCell: bool ref,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.CompExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_CompExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isArrayOrList: bool,
       isNotNakedRefCell: bool ref,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Lambda" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Lambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fromMethod: bool,
       inLambdaSeq: bool,
       args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       body: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Lambda" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Lambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fromMethod: bool,
       inLambdaSeq: bool,
       args: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       body: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.MatchLambda" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_MatchLambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Range.range,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.MatchLambda" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_MatchLambda =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Range.range,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Match" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Match =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       isCexprExceptionMatch: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Match" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Match =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       matchExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       clauses: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       isCexprExceptionMatch: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Do" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Do =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Do" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Do =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Assert" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Assert =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Assert" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Assert =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.App" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
       isInfix: bool,
       funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.App" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprAtomicFlag: Microsoft.FSharp.Compiler.Ast.ExprAtomicFlag,
       isInfix: bool,
       funcExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TypeApp" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_TypeApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
       typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.TypeApp" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_TypeApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range,
       typeNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LetOrUse" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LetOrUse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isRecursive: bool,
       isUse: bool,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LetOrUse" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LetOrUse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isRecursive: bool,
       isUse: bool,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       exprBody: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TryWith" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_TryWith =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       item4: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.TryWith" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_TryWith =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynMatchClause list,
       item4: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spWith: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForWith) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TryFinally" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_TryFinally =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.TryFinally" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_TryFinally =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       tryExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       finallyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTry: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTry,
       spFinally: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForFinally) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Lazy" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Lazy =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Lazy" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Lazy =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Sequential" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Sequential =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
       isTrueSeq: bool,
       expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Sequential" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Sequential =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spSeq: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForSeq,
       isTrueSeq: bool,
       expr1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       expr2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.IfThenElse" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_IfThenElse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
       exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
       optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isFromErrorRecovery: bool,
       ifToThen: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.IfThenElse" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_IfThenElse =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exprGuard: Microsoft.FSharp.Compiler.Ast.SynExpr,
       exprThen: Microsoft.FSharp.Compiler.Ast.SynExpr,
       optionalExprElse: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       spIfToThen: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isFromErrorRecovery: bool,
       ifToThen: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Ident" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Ident =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Ident" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Ident =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isOptional: bool,
       longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       isOptional: bool,
       longIdent: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LongIdentSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LongIdentSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LongIdentSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LongIdentSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DotGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DotGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DotSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DotSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       exprValue: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotIndexedGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DotIndexedGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotIndexedGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DotIndexedGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotIndexedSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DotIndexedSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotIndexedSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DotIndexedSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       objectExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       indexExprs: Microsoft.FSharp.Compiler.Ast.SynIndexerArg list,
       valueExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       rangeOfLeftOfSet: Microsoft.FSharp.Compiler.Range.range,
       rangeOfDot: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.NamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_NamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.NamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_NamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DotNamedIndexedPropertySet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DotNamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DotNamedIndexedPropertySet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DotNamedIndexedPropertySet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TypeTest" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_TypeTest =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.TypeTest" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_TypeTest =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Upcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Upcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Upcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Upcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Downcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Downcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Downcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Downcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.InferredUpcast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_InferredUpcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.InferredUpcast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_InferredUpcast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.InferredDowncast" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_InferredDowncast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.InferredDowncast" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_InferredDowncast =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Null" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Null" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.AddressOf" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_AddressOf =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.AddressOf" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_AddressOf =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.TraitCall" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_TraitCall =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.TraitCall" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_TraitCall =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       item2: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.JoinIn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_JoinIn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inPos: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.JoinIn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_JoinIn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inPos: Microsoft.FSharp.Compiler.Range.range,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ImplicitZero" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ImplicitZero =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ImplicitZero" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ImplicitZero =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_YieldOrReturn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.YieldOrReturn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_YieldOrReturn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.YieldOrReturnFrom" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_YieldOrReturnFrom =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.YieldOrReturnFrom" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_YieldOrReturnFrom =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * bool),
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LetOrUseBang" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LetOrUseBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isUse: bool,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LetOrUseBang" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LetOrUseBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       spBind: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       isUse: bool,
       isFromSource: bool,
       pattern: Microsoft.FSharp.Compiler.Ast.SynPat,
       rhsExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       bodyExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DoBang" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DoBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DoBang" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DoBang =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
       item2: Microsoft.FSharp.Compiler.Ast.SynType list,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       item4: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
       item2: Microsoft.FSharp.Compiler.Ast.SynType list,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr list,
       item4: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyStaticOptimization" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LibraryOnlyStaticOptimization =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyStaticOptimization" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LibraryOnlyStaticOptimization =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint list,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldGet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldGet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LibraryOnlyUnionCaseFieldGet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.LibraryOnlyUnionCaseFieldSet" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.LibraryOnlyUnionCaseFieldSet" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_LibraryOnlyUnionCaseFieldSet =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: int,
       item4: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.ArbitraryAfterError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_ArbitraryAfterError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       debugStr: string,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.ArbitraryAfterError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_ArbitraryAfterError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       debugStr: string,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.FromParseError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.FromParseError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.DiscardAfterMissingQualificationAfterDot" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.DiscardAfterMissingQualificationAfterDot" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_DiscardAfterMissingQualificationAfterDot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynExpr.Fixed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitExpr_Fixed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynExpr.Fixed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitExpr_Fixed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynExpr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synExpr">SynExpr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitExpr
      (context: 'TContext)
      (synExpr: Microsoft.FSharp.Compiler.Ast.SynExpr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Expr synExpr)
    try
      match synExpr with
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range) ->
        match this.BeforeVisitExpr_Paren(this, context, expr, leftParenRange, rightParenRange, range) with
        | Some result -> result
        | None ->
          let expr, leftParenRange, rightParenRange, range = (this.VisitExpr context expr), leftParenRange, rightParenRange, range
          match this.VisitExpr_Paren(this, context, expr, leftParenRange, rightParenRange, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Paren(expr, leftParenRange, rightParenRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range) ->
        match this.BeforeVisitExpr_Quote(this, context, operator, isRaw, quotedSynExpr, isFromQueryExpression, range) with
        | Some result -> result
        | None ->
          let operator, isRaw, quotedSynExpr, isFromQueryExpression, range = (this.VisitExpr context operator), isRaw, (this.VisitExpr context quotedSynExpr), isFromQueryExpression, range
          match this.VisitExpr_Quote(this, context, operator, isRaw, quotedSynExpr, isFromQueryExpression, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Quote(operator, isRaw, quotedSynExpr, isFromQueryExpression, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range) ->
        match this.BeforeVisitExpr_Const(this, context, constant, range) with
        | Some result -> result
        | None ->
          let constant, range = (this.VisitConst context constant), range
          match this.VisitExpr_Const(this, context, constant, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Const(constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range) ->
        match this.BeforeVisitExpr_Typed(this, context, expr, typeSig, range) with
        | Some result -> result
        | None ->
          let expr, typeSig, range = (this.VisitExpr context expr), (this.VisitType context typeSig), range
          match this.VisitExpr_Typed(this, context, expr, typeSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Typed(expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range) ->
        match this.BeforeVisitExpr_Tuple(this, context, exprs, commaRanges, range) with
        | Some result -> result
        | None ->
          let exprs, commaRanges, range = exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitExpr context v)), commaRanges, range
          match this.VisitExpr_Tuple(this, context, exprs, commaRanges, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Tuple(exprs, commaRanges, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range) ->
        match this.BeforeVisitExpr_ArrayOrList(this, context, isList, exprs, range) with
        | Some result -> result
        | None ->
          let isList, exprs, range = isList, exprs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitExpr context v)), range
          match this.VisitExpr_ArrayOrList(this, context, isList, exprs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrList(isList, exprs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range) ->
        match this.BeforeVisitExpr_Record(this, context, baseInfo, copyInfo, recordFields, range) with
        | Some result -> result
        | None ->
          let baseInfo, copyInfo, recordFields, range = baseInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1, v2, v3, v4 = v in (this.VisitType context v0), (this.VisitExpr context v1), v2, v3, v4)), copyInfo |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (this.VisitExpr context v0), v1)), recordFields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in v0, v1 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitExpr context v)), v2)), range
          match this.VisitExpr_Record(this, context, baseInfo, copyInfo, recordFields, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Record(baseInfo, copyInfo, recordFields, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range) ->
        match this.BeforeVisitExpr_New(this, context, isProtected, typeName, expr, range) with
        | Some result -> result
        | None ->
          let isProtected, typeName, expr, range = isProtected, (this.VisitType context typeName), (this.VisitExpr context expr), range
          match this.VisitExpr_New(this, context, isProtected, typeName, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.New(isProtected, typeName, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range) ->
        match this.BeforeVisitExpr_ObjExpr(this, context, objType, argOpt, bindings, extraImpls, newPos, range) with
        | Some result -> result
        | None ->
          let objType, argOpt, bindings, extraImpls, newPos, range = (this.VisitType context objType), argOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (let v0, v1 = v in (this.VisitExpr context v0), v1)), bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitBinding context v)), extraImpls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitInterfaceImpl context v)), newPos, range
          match this.VisitExpr_ObjExpr(this, context, objType, argOpt, bindings, extraImpls, newPos, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ObjExpr(objType, argOpt, bindings, extraImpls, newPos, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range) ->
        match this.BeforeVisitExpr_While(this, context, spWhile, whileBody, doBody, range) with
        | Some result -> result
        | None ->
          let spWhile, whileBody, doBody, range = spWhile, (this.VisitExpr context whileBody), (this.VisitExpr context doBody), range
          match this.VisitExpr_While(this, context, spWhile, whileBody, doBody, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.While(spWhile, whileBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range) ->
        match this.BeforeVisitExpr_For(this, context, spFor, id, idBody, item4, toBody, doBody, range) with
        | Some result -> result
        | None ->
          let spFor, id, idBody, item4, toBody, doBody, range = spFor, id, (this.VisitExpr context idBody), item4, (this.VisitExpr context toBody), (this.VisitExpr context doBody), range
          match this.VisitExpr_For(this, context, spFor, id, idBody, item4, toBody, doBody, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.For(spFor, id, idBody, item4, toBody, doBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) ->
        match this.BeforeVisitExpr_ForEach(this, context, spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) with
        | Some result -> result
        | None ->
          let spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range = spFor, seqExprOnly, isFromSource, (this.VisitPat context pattern), (this.VisitExpr context enumExpr), (this.VisitExpr context bodyExpr), range
          match this.VisitExpr_ForEach(this, context, spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ForEach(spFor, seqExprOnly, isFromSource, pattern, enumExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range) ->
        match this.BeforeVisitExpr_ArrayOrListOfSeqExpr(this, context, isList, elements, range) with
        | Some result -> result
        | None ->
          let isList, elements, range = isList, (this.VisitExpr context elements), range
          match this.VisitExpr_ArrayOrListOfSeqExpr(this, context, isList, elements, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ArrayOrListOfSeqExpr(isList, elements, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range) ->
        match this.BeforeVisitExpr_CompExpr(this, context, isArrayOrList, isNotNakedRefCell, expr, range) with
        | Some result -> result
        | None ->
          let isArrayOrList, isNotNakedRefCell, expr, range = isArrayOrList, isNotNakedRefCell, (this.VisitExpr context expr), range
          match this.VisitExpr_CompExpr(this, context, isArrayOrList, isNotNakedRefCell, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.CompExpr(isArrayOrList, isNotNakedRefCell, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range) ->
        match this.BeforeVisitExpr_Lambda(this, context, fromMethod, inLambdaSeq, args, body, range) with
        | Some result -> result
        | None ->
          let fromMethod, inLambdaSeq, args, body, range = fromMethod, inLambdaSeq, (this.VisitSimplePats context args), (this.VisitExpr context body), range
          match this.VisitExpr_Lambda(this, context, fromMethod, inLambdaSeq, args, body, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Lambda(fromMethod, inLambdaSeq, args, body, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range) ->
        match this.BeforeVisitExpr_MatchLambda(this, context, item1, item2, clauses, spBind, range) with
        | Some result -> result
        | None ->
          let item1, item2, clauses, spBind, range = item1, item2, clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMatchClause context v)), spBind, range
          match this.VisitExpr_MatchLambda(this, context, item1, item2, clauses, spBind, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.MatchLambda(item1, item2, clauses, spBind, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range) ->
        match this.BeforeVisitExpr_Match(this, context, spBind, matchExpr, clauses, isCexprExceptionMatch, range) with
        | Some result -> result
        | None ->
          let spBind, matchExpr, clauses, isCexprExceptionMatch, range = spBind, (this.VisitExpr context matchExpr), clauses |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMatchClause context v)), isCexprExceptionMatch, range
          match this.VisitExpr_Match(this, context, spBind, matchExpr, clauses, isCexprExceptionMatch, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Match(spBind, matchExpr, clauses, isCexprExceptionMatch, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range) ->
        match this.BeforeVisitExpr_Do(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_Do(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Do(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range) ->
        match this.BeforeVisitExpr_Assert(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_Assert(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Assert(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range) ->
        match this.BeforeVisitExpr_App(this, context, exprAtomicFlag, isInfix, funcExpr, argExpr, range) with
        | Some result -> result
        | None ->
          let exprAtomicFlag, isInfix, funcExpr, argExpr, range = exprAtomicFlag, isInfix, (this.VisitExpr context funcExpr), (this.VisitExpr context argExpr), range
          match this.VisitExpr_App(this, context, exprAtomicFlag, isInfix, funcExpr, argExpr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.App(exprAtomicFlag, isInfix, funcExpr, argExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) ->
        match this.BeforeVisitExpr_TypeApp(this, context, expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) with
        | Some result -> result
        | None ->
          let expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range = (this.VisitExpr context expr), leftAngleRange, typeNames |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), commaRanges, rightAngleRange, typeArgs, range
          match this.VisitExpr_TypeApp(this, context, expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.TypeApp(expr, leftAngleRange, typeNames, commaRanges, rightAngleRange, typeArgs, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range) ->
        match this.BeforeVisitExpr_LetOrUse(this, context, isRecursive, isUse, bindings, exprBody, range) with
        | Some result -> result
        | None ->
          let isRecursive, isUse, bindings, exprBody, range = isRecursive, isUse, bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitBinding context v)), (this.VisitExpr context exprBody), range
          match this.VisitExpr_LetOrUse(this, context, isRecursive, isUse, bindings, exprBody, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUse(isRecursive, isUse, bindings, exprBody, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith) ->
        match this.BeforeVisitExpr_TryWith(this, context, tryExpr, item2, item3, item4, range, spTry, spWith) with
        | Some result -> result
        | None ->
          let tryExpr, item2, item3, item4, range, spTry, spWith = (this.VisitExpr context tryExpr), item2, item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMatchClause context v)), item4, range, spTry, spWith
          match this.VisitExpr_TryWith(this, context, tryExpr, item2, item3, item4, range, spTry, spWith) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.TryWith(tryExpr, item2, item3, item4, range, spTry, spWith)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally) ->
        match this.BeforeVisitExpr_TryFinally(this, context, tryExpr, finallyExpr, range, spTry, spFinally) with
        | Some result -> result
        | None ->
          let tryExpr, finallyExpr, range, spTry, spFinally = (this.VisitExpr context tryExpr), (this.VisitExpr context finallyExpr), range, spTry, spFinally
          match this.VisitExpr_TryFinally(this, context, tryExpr, finallyExpr, range, spTry, spFinally) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.TryFinally(tryExpr, finallyExpr, range, spTry, spFinally)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range) ->
        match this.BeforeVisitExpr_Lazy(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_Lazy(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Lazy(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range) ->
        match this.BeforeVisitExpr_Sequential(this, context, spSeq, isTrueSeq, expr1, expr2, range) with
        | Some result -> result
        | None ->
          let spSeq, isTrueSeq, expr1, expr2, range = spSeq, isTrueSeq, (this.VisitExpr context expr1), (this.VisitExpr context expr2), range
          match this.VisitExpr_Sequential(this, context, spSeq, isTrueSeq, expr1, expr2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Sequential(spSeq, isTrueSeq, expr1, expr2, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) ->
        match this.BeforeVisitExpr_IfThenElse(this, context, exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) with
        | Some result -> result
        | None ->
          let exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range = (this.VisitExpr context exprGuard), (this.VisitExpr context exprThen), optionalExprElse |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitExpr context v)), spIfToThen, isFromErrorRecovery, ifToThen, range
          match this.VisitExpr_IfThenElse(this, context, exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.IfThenElse(exprGuard, exprThen, optionalExprElse, spIfToThen, isFromErrorRecovery, ifToThen, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item) ->
        match this.BeforeVisitExpr_Ident(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitExpr_Ident(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Ident(item)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range) ->
        match this.BeforeVisitExpr_LongIdent(this, context, isOptional, longIdent, altNameRefCell, range) with
        | Some result -> result
        | None ->
          use _rwh_ = new RefWrapperHolder()
          let isOptional, longIdent, altNameRefCell, range = isOptional, longIdent, altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (this.VisitSimplePatAlternativeIdInfo context v.Value)), range
          match this.VisitExpr_LongIdent(this, context, isOptional, longIdent, altNameRefCell, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdent(isOptional, longIdent, altNameRefCell, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range) ->
        match this.BeforeVisitExpr_LongIdentSet(this, context, dotId, expr, range) with
        | Some result -> result
        | None ->
          let dotId, expr, range = dotId, (this.VisitExpr context expr), range
          match this.VisitExpr_LongIdentSet(this, context, dotId, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LongIdentSet(dotId, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range) ->
        match this.BeforeVisitExpr_DotGet(this, context, expr, rangeOfDot, dotId, range) with
        | Some result -> result
        | None ->
          let expr, rangeOfDot, dotId, range = (this.VisitExpr context expr), rangeOfDot, dotId, range
          match this.VisitExpr_DotGet(this, context, expr, rangeOfDot, dotId, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DotGet(expr, rangeOfDot, dotId, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range) ->
        match this.BeforeVisitExpr_DotSet(this, context, expr, dotId, exprValue, range) with
        | Some result -> result
        | None ->
          let expr, dotId, exprValue, range = (this.VisitExpr context expr), dotId, (this.VisitExpr context exprValue), range
          match this.VisitExpr_DotSet(this, context, expr, dotId, exprValue, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DotSet(expr, dotId, exprValue, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range) ->
        match this.BeforeVisitExpr_DotIndexedGet(this, context, expr, indexExprs, item3, range) with
        | Some result -> result
        | None ->
          let expr, indexExprs, item3, range = (this.VisitExpr context expr), indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitIndexerArg context v)), item3, range
          match this.VisitExpr_DotIndexedGet(this, context, expr, indexExprs, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedGet(expr, indexExprs, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) ->
        match this.BeforeVisitExpr_DotIndexedSet(this, context, objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) with
        | Some result -> result
        | None ->
          let objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range = (this.VisitExpr context objectExpr), indexExprs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitIndexerArg context v)), (this.VisitExpr context valueExpr), rangeOfLeftOfSet, rangeOfDot, range
          match this.VisitExpr_DotIndexedSet(this, context, objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DotIndexedSet(objectExpr, indexExprs, valueExpr, rangeOfLeftOfSet, rangeOfDot, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range) ->
        match this.BeforeVisitExpr_NamedIndexedPropertySet(this, context, item1, item2, item3, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, range = item1, (this.VisitExpr context item2), (this.VisitExpr context item3), range
          match this.VisitExpr_NamedIndexedPropertySet(this, context, item1, item2, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.NamedIndexedPropertySet(item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range) ->
        match this.BeforeVisitExpr_DotNamedIndexedPropertySet(this, context, item1, item2, item3, item4, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, item4, range = (this.VisitExpr context item1), item2, (this.VisitExpr context item3), (this.VisitExpr context item4), range
          match this.VisitExpr_DotNamedIndexedPropertySet(this, context, item1, item2, item3, item4, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DotNamedIndexedPropertySet(item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range) ->
        match this.BeforeVisitExpr_TypeTest(this, context, expr, typeName, range) with
        | Some result -> result
        | None ->
          let expr, typeName, range = (this.VisitExpr context expr), (this.VisitType context typeName), range
          match this.VisitExpr_TypeTest(this, context, expr, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.TypeTest(expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range) ->
        match this.BeforeVisitExpr_Upcast(this, context, expr, typeSig, range) with
        | Some result -> result
        | None ->
          let expr, typeSig, range = (this.VisitExpr context expr), (this.VisitType context typeSig), range
          match this.VisitExpr_Upcast(this, context, expr, typeSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Upcast(expr, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range) ->
        match this.BeforeVisitExpr_Downcast(this, context, expr, typeName, range) with
        | Some result -> result
        | None ->
          let expr, typeName, range = (this.VisitExpr context expr), (this.VisitType context typeName), range
          match this.VisitExpr_Downcast(this, context, expr, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Downcast(expr, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range) ->
        match this.BeforeVisitExpr_InferredUpcast(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_InferredUpcast(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.InferredUpcast(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range) ->
        match this.BeforeVisitExpr_InferredDowncast(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_InferredDowncast(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.InferredDowncast(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range) ->
        match this.BeforeVisitExpr_Null(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitExpr_Null(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Null(range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range) ->
        match this.BeforeVisitExpr_AddressOf(this, context, item1, item2, item3, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, range = item1, (this.VisitExpr context item2), item3, range
          match this.VisitExpr_AddressOf(this, context, item1, item2, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.AddressOf(item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range) ->
        match this.BeforeVisitExpr_TraitCall(this, context, item1, item2, item3, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypar context v)), (this.VisitMemberSig context item2), (this.VisitExpr context item3), range
          match this.VisitExpr_TraitCall(this, context, item1, item2, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.TraitCall(item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range) ->
        match this.BeforeVisitExpr_JoinIn(this, context, item1, inPos, item3, range) with
        | Some result -> result
        | None ->
          let item1, inPos, item3, range = (this.VisitExpr context item1), inPos, (this.VisitExpr context item3), range
          match this.VisitExpr_JoinIn(this, context, item1, inPos, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.JoinIn(item1, inPos, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range) ->
        match this.BeforeVisitExpr_ImplicitZero(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitExpr_ImplicitZero(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ImplicitZero(range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range) ->
        match this.BeforeVisitExpr_YieldOrReturn(this, context, item1, expr, range) with
        | Some result -> result
        | None ->
          let item1, expr, range = item1, (this.VisitExpr context expr), range
          match this.VisitExpr_YieldOrReturn(this, context, item1, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturn(item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range) ->
        match this.BeforeVisitExpr_YieldOrReturnFrom(this, context, item1, expr, range) with
        | Some result -> result
        | None ->
          let item1, expr, range = item1, (this.VisitExpr context expr), range
          match this.VisitExpr_YieldOrReturnFrom(this, context, item1, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.YieldOrReturnFrom(item1, expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) ->
        match this.BeforeVisitExpr_LetOrUseBang(this, context, spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) with
        | Some result -> result
        | None ->
          let spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range = spBind, isUse, isFromSource, (this.VisitPat context pattern), (this.VisitExpr context rhsExpr), (this.VisitExpr context bodyExpr), range
          match this.VisitExpr_LetOrUseBang(this, context, spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LetOrUseBang(spBind, isUse, isFromSource, pattern, rhsExpr, bodyExpr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range) ->
        match this.BeforeVisitExpr_DoBang(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_DoBang(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DoBang(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range) ->
        match this.BeforeVisitExpr_LibraryOnlyILAssembly(this, context, item1, item2, item3, item4, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, item4, range = item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitExpr context v)), item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), range
          match this.VisitExpr_LibraryOnlyILAssembly(this, context, item1, item2, item3, item4, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyILAssembly(item1, item2, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range) ->
        match this.BeforeVisitExpr_LibraryOnlyStaticOptimization(this, context, item1, item2, item3, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitStaticOptimizationConstraint context v)), (this.VisitExpr context item2), (this.VisitExpr context item3), range
          match this.VisitExpr_LibraryOnlyStaticOptimization(this, context, item1, item2, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyStaticOptimization(item1, item2, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range) ->
        match this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldGet(this, context, item1, longId, item3, range) with
        | Some result -> result
        | None ->
          let item1, longId, item3, range = (this.VisitExpr context item1), longId, item3, range
          match this.VisitExpr_LibraryOnlyUnionCaseFieldGet(this, context, item1, longId, item3, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldGet(item1, longId, item3, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range) ->
        match this.BeforeVisitExpr_LibraryOnlyUnionCaseFieldSet(this, context, item1, longId, item3, item4, range) with
        | Some result -> result
        | None ->
          let item1, longId, item3, item4, range = (this.VisitExpr context item1), longId, item3, (this.VisitExpr context item4), range
          match this.VisitExpr_LibraryOnlyUnionCaseFieldSet(this, context, item1, longId, item3, item4, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.LibraryOnlyUnionCaseFieldSet(item1, longId, item3, item4, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range) ->
        match this.BeforeVisitExpr_ArbitraryAfterError(this, context, debugStr, range) with
        | Some result -> result
        | None ->
          let debugStr, range = debugStr, range
          match this.VisitExpr_ArbitraryAfterError(this, context, debugStr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.ArbitraryAfterError(debugStr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range) ->
        match this.BeforeVisitExpr_FromParseError(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_FromParseError(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.FromParseError(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range) ->
        match this.BeforeVisitExpr_DiscardAfterMissingQualificationAfterDot(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitExpr_DiscardAfterMissingQualificationAfterDot(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.DiscardAfterMissingQualificationAfterDot(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2) ->
        match this.BeforeVisitExpr_Fixed(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = (this.VisitExpr context item1), item2
          match this.VisitExpr_Fixed(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynExpr.Fixed(item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynField

  /// <summary>
  /// Before visit "SynField.Field" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitField_Field =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item5: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynField.Field" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitField_Field =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item5: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynField" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synField">SynField expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitField
      (context: 'TContext)
      (synField: Microsoft.FSharp.Compiler.Ast.SynField) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Field synField)
    try
      match synField with
      | Microsoft.FSharp.Compiler.Ast.SynField(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) ->
        match this.BeforeVisitField_Field(this, context, attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) with
        | Some result -> result
        | None ->
          let attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), isStatic, id, (this.VisitType context typeName), item5, xmlDoc, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitField_Field(this, context, attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynField(attributes, isStatic, id, typeName, item5, xmlDoc, accessiblity, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynIndexerArg

  /// <summary>
  /// Before visit "SynIndexerArg.Two" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitIndexerArg_Two =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr) -> None
    with get, set

  /// <summary>
  /// Visit "SynIndexerArg.Two" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitIndexerArg_Two =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr) -> None
    with get, set

  /// <summary>
  /// Before visit "SynIndexerArg.One" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitIndexerArg_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExpr) -> None
    with get, set

  /// <summary>
  /// Visit "SynIndexerArg.One" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitIndexerArg_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExpr) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynIndexerArg" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synIndexerArg">SynIndexerArg expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitIndexerArg
      (context: 'TContext)
      (synIndexerArg: Microsoft.FSharp.Compiler.Ast.SynIndexerArg) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.IndexerArg synIndexerArg)
    try
      match synIndexerArg with
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2) ->
        match this.BeforeVisitIndexerArg_Two(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = (this.VisitExpr context item1), (this.VisitExpr context item2)
          match this.VisitIndexerArg_Two(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg.Two(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item) ->
        match this.BeforeVisitIndexerArg_One(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitExpr context item)
          match this.VisitIndexerArg_One(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynIndexerArg.One(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynInterfaceImpl

  /// <summary>
  /// Before visit "SynInterfaceImpl.InterfaceImpl" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitInterfaceImpl_InterfaceImpl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynInterfaceImpl.InterfaceImpl" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitInterfaceImpl_InterfaceImpl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynInterfaceImpl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synInterfaceImpl">SynInterfaceImpl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitInterfaceImpl
      (context: 'TContext)
      (synInterfaceImpl: Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.InterfaceImpl synInterfaceImpl)
    try
      match synInterfaceImpl with
      | Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl(item1, bindings, range) ->
        match this.BeforeVisitInterfaceImpl_InterfaceImpl(this, context, item1, bindings, range) with
        | Some result -> result
        | None ->
          let item1, bindings, range = (this.VisitType context item1), bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitBinding context v)), range
          match this.VisitInterfaceImpl_InterfaceImpl(this, context, item1, bindings, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl(item1, bindings, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMatchClause

  /// <summary>
  /// Before visit "SynMatchClause.Clause" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMatchClause_Clause =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) -> None
    with get, set

  /// <summary>
  /// Visit "SynMatchClause.Clause" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMatchClause_Clause =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       item3: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range,
       spTarget: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForTarget) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynMatchClause" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMatchClause">SynMatchClause expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMatchClause
      (context: 'TContext)
      (synMatchClause: Microsoft.FSharp.Compiler.Ast.SynMatchClause) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.MatchClause synMatchClause)
    try
      match synMatchClause with
      | Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget) ->
        match this.BeforeVisitMatchClause_Clause(this, context, item1, item2, item3, range, spTarget) with
        | Some result -> result
        | None ->
          let item1, item2, item3, range, spTarget = (this.VisitPat context item1), item2 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitExpr context v)), (this.VisitExpr context item3), range, spTarget
          match this.VisitMatchClause_Clause(this, context, item1, item2, item3, range, spTarget) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMatchClause.Clause(item1, item2, item3, range, spTarget)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMeasure

  /// <summary>
  /// Before visit "SynMeasure.Named" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Named" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Product" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Product =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Product" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Product =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Seq" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Seq =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Seq" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Seq =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Divide" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Divide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Divide" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Divide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Power" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Power =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Power" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Power =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynMeasure,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.One" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.One" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_One =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Anon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Anon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMeasure.Var" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMeasure_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMeasure.Var" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMeasure_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynMeasure" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMeasure">SynMeasure expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMeasure
      (context: 'TContext)
      (synMeasure: Microsoft.FSharp.Compiler.Ast.SynMeasure) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Measure synMeasure)
    try
      match synMeasure with
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range) ->
        match this.BeforeVisitMeasure_Named(this, context, longId, range) with
        | Some result -> result
        | None ->
          let longId, range = longId, range
          match this.VisitMeasure_Named(this, context, longId, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Named(longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range) ->
        match this.BeforeVisitMeasure_Product(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitMeasure context item1), (this.VisitMeasure context item2), range
          match this.VisitMeasure_Product(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Product(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range) ->
        match this.BeforeVisitMeasure_Seq(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMeasure context v)), range
          match this.VisitMeasure_Seq(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Seq(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range) ->
        match this.BeforeVisitMeasure_Divide(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitMeasure context item1), (this.VisitMeasure context item2), range
          match this.VisitMeasure_Divide(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Divide(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range) ->
        match this.BeforeVisitMeasure_Power(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitMeasure context item1), (this.VisitRationalConst context item2), range
          match this.VisitMeasure_Power(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Power(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.One ->
        match this.BeforeVisitMeasure_One(this, context) with
        | Some result -> result
        | None ->
          match this.VisitMeasure_One(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.One
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item) ->
        match this.BeforeVisitMeasure_Anon(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitMeasure_Anon(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Anon(item)
      | Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range) ->
        match this.BeforeVisitMeasure_Var(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitTypar context item1), range
          match this.VisitMeasure_Var(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMeasure.Var(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberDefn

  /// <summary>
  /// Before visit "SynMemberDefn.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Member" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Member" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       memberDefn: Microsoft.FSharp.Compiler.Ast.SynBinding,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitCtor" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_ImplicitCtor =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitCtor" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_ImplicitCtor =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       ctorArgs: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       selfIdentifier: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ImplicitInherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_ImplicitInherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
       inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ImplicitInherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_ImplicitInherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       inheritType: Microsoft.FSharp.Compiler.Ast.SynType,
       inheritArgs: Microsoft.FSharp.Compiler.Ast.SynExpr,
       inheritAlias: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.LetBindings" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_LetBindings =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       isStatic: bool,
       isRecursive: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.LetBindings" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_LetBindings =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       bindings: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       isStatic: bool,
       isRecursive: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.AbstractSlot" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_AbstractSlot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.AbstractSlot" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_AbstractSlot =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Interface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Interface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       interfaceMembers: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.Inherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.Inherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       id: Microsoft.FSharp.Compiler.Ast.Ident option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.ValField" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.ValField" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.NestedType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.NestedType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberDefn.AutoProperty" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberDefn_AutoProperty =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option,
       propKind: Microsoft.FSharp.Compiler.Ast.MemberKind,
       memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags),
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       getSetPos: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberDefn.AutoProperty" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberDefn_AutoProperty =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       isStatic: bool,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       tyOpt: Microsoft.FSharp.Compiler.Ast.SynType option,
       propKind: Microsoft.FSharp.Compiler.Ast.MemberKind,
       memberFlags: (Microsoft.FSharp.Compiler.Ast.MemberKind -> Microsoft.FSharp.Compiler.Ast.MemberFlags),
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       getSetPos: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynMemberDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberDefn">SynMemberDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberDefn
      (context: 'TContext)
      (synMemberDefn: Microsoft.FSharp.Compiler.Ast.SynMemberDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.MemberDefn synMemberDefn)
    try
      match synMemberDefn with
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range) ->
        match this.BeforeVisitMemberDefn_Open(this, context, longId, range) with
        | Some result -> result
        | None ->
          let longId, range = longId, range
          match this.VisitMemberDefn_Open(this, context, longId, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Open(longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range) ->
        match this.BeforeVisitMemberDefn_Member(this, context, memberDefn, range) with
        | Some result -> result
        | None ->
          let memberDefn, range = (this.VisitBinding context memberDefn), range
          match this.VisitMemberDefn_Member(this, context, memberDefn, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Member(memberDefn, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range) ->
        match this.BeforeVisitMemberDefn_ImplicitCtor(this, context, accessiblity, attributes, ctorArgs, selfIdentifier, range) with
        | Some result -> result
        | None ->
          let accessiblity, attributes, ctorArgs, selfIdentifier, range = accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), ctorArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitSimplePat context v)), selfIdentifier, range
          match this.VisitMemberDefn_ImplicitCtor(this, context, accessiblity, attributes, ctorArgs, selfIdentifier, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitCtor(accessiblity, attributes, ctorArgs, selfIdentifier, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range) ->
        match this.BeforeVisitMemberDefn_ImplicitInherit(this, context, inheritType, inheritArgs, inheritAlias, range) with
        | Some result -> result
        | None ->
          let inheritType, inheritArgs, inheritAlias, range = (this.VisitType context inheritType), (this.VisitExpr context inheritArgs), inheritAlias, range
          match this.VisitMemberDefn_ImplicitInherit(this, context, inheritType, inheritArgs, inheritAlias, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ImplicitInherit(inheritType, inheritArgs, inheritAlias, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range) ->
        match this.BeforeVisitMemberDefn_LetBindings(this, context, bindings, isStatic, isRecursive, range) with
        | Some result -> result
        | None ->
          let bindings, isStatic, isRecursive, range = bindings |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitBinding context v)), isStatic, isRecursive, range
          match this.VisitMemberDefn_LetBindings(this, context, bindings, isStatic, isRecursive, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.LetBindings(bindings, isStatic, isRecursive, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range) ->
        match this.BeforeVisitMemberDefn_AbstractSlot(this, context, valSig, memberFlags, range) with
        | Some result -> result
        | None ->
          let valSig, memberFlags, range = (this.VisitValSig context valSig), memberFlags, range
          match this.VisitMemberDefn_AbstractSlot(this, context, valSig, memberFlags, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AbstractSlot(valSig, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range) ->
        match this.BeforeVisitMemberDefn_Interface(this, context, typeName, interfaceMembers, range) with
        | Some result -> result
        | None ->
          let typeName, interfaceMembers, range = (this.VisitType context typeName), interfaceMembers |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberDefn context v))), range
          match this.VisitMemberDefn_Interface(this, context, typeName, interfaceMembers, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Interface(typeName, interfaceMembers, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range) ->
        match this.BeforeVisitMemberDefn_Inherit(this, context, typeName, id, range) with
        | Some result -> result
        | None ->
          let typeName, id, range = (this.VisitType context typeName), id, range
          match this.VisitMemberDefn_Inherit(this, context, typeName, id, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.Inherit(typeName, id, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range) ->
        match this.BeforeVisitMemberDefn_ValField(this, context, field, range) with
        | Some result -> result
        | None ->
          let field, range = (this.VisitField context field), range
          match this.VisitMemberDefn_ValField(this, context, field, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.ValField(field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range) ->
        match this.BeforeVisitMemberDefn_NestedType(this, context, typeDefn, accessiblity, range) with
        | Some result -> result
        | None ->
          let typeDefn, accessiblity, range = (this.VisitTypeDefn context typeDefn), accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitMemberDefn_NestedType(this, context, typeDefn, accessiblity, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.NestedType(typeDefn, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) ->
        match this.BeforeVisitMemberDefn_AutoProperty(this, context, attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) with
        | Some result -> result
        | None ->
          let attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), isStatic, id, tyOpt |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitType context v)), propKind, memberFlags, xmlDoc, accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), (this.VisitExpr context expr), getSetPos, range
          match this.VisitMemberDefn_AutoProperty(this, context, attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberDefn.AutoProperty(attributes, isStatic, id, tyOpt, propKind, memberFlags, xmlDoc, accessibility, expr, getSetPos, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynMemberSig

  /// <summary>
  /// Before visit "SynMemberSig.Member" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberSig_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Member" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberSig_Member =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynValSig,
       memberFlags: Microsoft.FSharp.Compiler.Ast.MemberFlags,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.Interface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberSig_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Interface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberSig_Interface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.Inherit" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberSig_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.Inherit" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberSig_Inherit =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.ValField" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberSig_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.ValField" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberSig_ValField =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       field: Microsoft.FSharp.Compiler.Ast.SynField,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynMemberSig.NestedType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitMemberSig_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynMemberSig.NestedType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitMemberSig_NestedType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynMemberSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synMemberSig">SynMemberSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitMemberSig
      (context: 'TContext)
      (synMemberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.MemberSig synMemberSig)
    try
      match synMemberSig with
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range) ->
        match this.BeforeVisitMemberSig_Member(this, context, item1, memberFlags, range) with
        | Some result -> result
        | None ->
          let item1, memberFlags, range = (this.VisitValSig context item1), memberFlags, range
          match this.VisitMemberSig_Member(this, context, item1, memberFlags, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberSig.Member(item1, memberFlags, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range) ->
        match this.BeforeVisitMemberSig_Interface(this, context, typeName, range) with
        | Some result -> result
        | None ->
          let typeName, range = (this.VisitType context typeName), range
          match this.VisitMemberSig_Interface(this, context, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberSig.Interface(typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range) ->
        match this.BeforeVisitMemberSig_Inherit(this, context, typeName, range) with
        | Some result -> result
        | None ->
          let typeName, range = (this.VisitType context typeName), range
          match this.VisitMemberSig_Inherit(this, context, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberSig.Inherit(typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range) ->
        match this.BeforeVisitMemberSig_ValField(this, context, field, range) with
        | Some result -> result
        | None ->
          let field, range = (this.VisitField context field), range
          match this.VisitMemberSig_ValField(this, context, field, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberSig.ValField(field, range)
      | Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range) ->
        match this.BeforeVisitMemberSig_NestedType(this, context, typeDefnSig, range) with
        | Some result -> result
        | None ->
          let typeDefnSig, range = (this.VisitTypeDefnSig context typeDefnSig), range
          match this.VisitMemberSig_NestedType(this, context, typeDefnSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynMemberSig.NestedType(typeDefnSig, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleDecl

  /// <summary>
  /// Before visit "SynModuleDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident list,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       item4: bool,
       item5: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.NestedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       item3: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       item4: bool,
       item5: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Let" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_Let =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Let" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_Let =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynBinding list,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.DoExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_DoExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.DoExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_DoExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SequencePointInfoForBinding,
       item2: Microsoft.FSharp.Compiler.Ast.SynExpr,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Types" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Types" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefn list,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynExceptionDefn,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.Attributes" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_Attributes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.Attributes" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_Attributes =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.HashDirective" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       item2: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynModuleDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleDecl">SynModuleDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleDecl
      (context: 'TContext)
      (synModuleDecl: Microsoft.FSharp.Compiler.Ast.SynModuleDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ModuleDecl synModuleDecl)
    try
      match synModuleDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3) ->
        match this.BeforeVisitModuleDecl_ModuleAbbrev(this, context, item1, item2, item3) with
        | Some result -> result
        | None ->
          let item1, item2, item3 = item1, item2, item3
          match this.VisitModuleDecl_ModuleAbbrev(this, context, item1, item2, item3) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.ModuleAbbrev(item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5) ->
        match this.BeforeVisitModuleDecl_NestedModule(this, context, item1, isRec, item3, item4, item5) with
        | Some result -> result
        | None ->
          let item1, isRec, item3, item4, item5 = (this.VisitComponentInfo context item1), isRec, item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleDecl context v)), item4, item5
          match this.VisitModuleDecl_NestedModule(this, context, item1, isRec, item3, item4, item5) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NestedModule(item1, isRec, item3, item4, item5)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3) ->
        match this.BeforeVisitModuleDecl_Let(this, context, item1, item2, item3) with
        | Some result -> result
        | None ->
          let item1, item2, item3 = item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitBinding context v)), item3
          match this.VisitModuleDecl_Let(this, context, item1, item2, item3) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Let(item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3) ->
        match this.BeforeVisitModuleDecl_DoExpr(this, context, item1, item2, item3) with
        | Some result -> result
        | None ->
          let item1, item2, item3 = item1, (this.VisitExpr context item2), item3
          match this.VisitModuleDecl_DoExpr(this, context, item1, item2, item3) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.DoExpr(item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2) ->
        match this.BeforeVisitModuleDecl_Types(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypeDefn context v)), item2
          match this.VisitModuleDecl_Types(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Types(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2) ->
        match this.BeforeVisitModuleDecl_Exception(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = (this.VisitExceptionDefn context item1), item2
          match this.VisitModuleDecl_Exception(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Exception(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2) ->
        match this.BeforeVisitModuleDecl_Open(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = item1, item2
          match this.VisitModuleDecl_Open(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Open(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2) ->
        match this.BeforeVisitModuleDecl_Attributes(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), item2
          match this.VisitModuleDecl_Attributes(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.Attributes(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2) ->
        match this.BeforeVisitModuleDecl_HashDirective(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = (this.VisitHashDirective context item1), item2
          match this.VisitModuleDecl_HashDirective(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.HashDirective(item1, item2)
      | Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item) ->
        match this.BeforeVisitModuleDecl_NamespaceFragment(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitModuleOrNamespace context item)
          match this.VisitModuleDecl_NamespaceFragment(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleDecl.NamespaceFragment(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespace

  /// <summary>
  /// Before visit "SynModuleOrNamespace.SynModuleOrNamespace" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleOrNamespace_SynModuleOrNamespace =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleOrNamespace.SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleOrNamespace_SynModuleOrNamespace =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       decls: Microsoft.FSharp.Compiler.Ast.SynModuleDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       access: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespace" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespace">SynModuleOrNamespace expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespace
      (context: 'TContext)
      (synModuleOrNamespace: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ModuleOrNamespace synModuleOrNamespace)
    try
      match synModuleOrNamespace with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range) ->
        match this.BeforeVisitModuleOrNamespace_SynModuleOrNamespace(this, context, id, isRec, isModule, decls, xmlDoc, attributes, access, range) with
        | Some result -> result
        | None ->
          let id, isRec, isModule, decls, xmlDoc, attributes, access, range = id, isRec, isModule, decls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleDecl context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), access |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitModuleOrNamespace_SynModuleOrNamespace(this, context, id, isRec, isModule, decls, xmlDoc, attributes, access, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace(id, isRec, isModule, decls, xmlDoc, attributes, access, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleOrNamespaceSig

  /// <summary>
  /// Before visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleOrNamespaceSig.SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident list,
       isRec: bool,
       isModule: bool,
       item4: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item7: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynModuleOrNamespaceSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleOrNamespaceSig">SynModuleOrNamespaceSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleOrNamespaceSig
      (context: 'TContext)
      (synModuleOrNamespaceSig: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ModuleOrNamespaceSig synModuleOrNamespaceSig)
    try
      match synModuleOrNamespaceSig with
      | Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range) ->
        match this.BeforeVisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(this, context, id, isRec, isModule, item4, xmlDoc, attributes, item7, range) with
        | Some result -> result
        | None ->
          let id, isRec, isModule, item4, xmlDoc, attributes, item7, range = id, isRec, isModule, item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleSigDecl context v)), xmlDoc, attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), item7 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitModuleOrNamespaceSig_SynModuleOrNamespaceSig(this, context, id, isRec, isModule, item4, xmlDoc, attributes, item7, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig(id, isRec, isModule, item4, xmlDoc, attributes, item7, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynModuleSigDecl

  /// <summary>
  /// Before visit "SynModuleSigDecl.ModuleAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.ModuleAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_ModuleAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.NestedModule" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.NestedModule" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_NestedModule =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       isRec: bool,
       moduleSigDecls: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Val" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_Val =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Val" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_Val =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       valSig: Microsoft.FSharp.Compiler.Ast.SynValSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Types" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Types" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_Types =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeDefSigs: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       exnSig: Microsoft.FSharp.Compiler.Ast.SynExceptionSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.Open" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.Open" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_Open =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       longId: Microsoft.FSharp.Compiler.Ast.Ident list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.HashDirective" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.HashDirective" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_HashDirective =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       hashDirective: Microsoft.FSharp.Compiler.Ast.ParsedHashDirective,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynModuleSigDecl.NamespaceFragment" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitModuleSigDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) -> None
    with get, set

  /// <summary>
  /// Visit "SynModuleSigDecl.NamespaceFragment" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitModuleSigDecl_NamespaceFragment =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynModuleSigDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synModuleSigDecl">SynModuleSigDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitModuleSigDecl
      (context: 'TContext)
      (synModuleSigDecl: Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ModuleSigDecl synModuleSigDecl)
    try
      match synModuleSigDecl with
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range) ->
        match this.BeforeVisitModuleSigDecl_ModuleAbbrev(this, context, id, longId, range) with
        | Some result -> result
        | None ->
          let id, longId, range = id, longId, range
          match this.VisitModuleSigDecl_ModuleAbbrev(this, context, id, longId, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.ModuleAbbrev(id, longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range) ->
        match this.BeforeVisitModuleSigDecl_NestedModule(this, context, item1, isRec, moduleSigDecls, range) with
        | Some result -> result
        | None ->
          let item1, isRec, moduleSigDecls, range = (this.VisitComponentInfo context item1), isRec, moduleSigDecls |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitModuleSigDecl context v)), range
          match this.VisitModuleSigDecl_NestedModule(this, context, item1, isRec, moduleSigDecls, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NestedModule(item1, isRec, moduleSigDecls, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range) ->
        match this.BeforeVisitModuleSigDecl_Val(this, context, valSig, range) with
        | Some result -> result
        | None ->
          let valSig, range = (this.VisitValSig context valSig), range
          match this.VisitModuleSigDecl_Val(this, context, valSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Val(valSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range) ->
        match this.BeforeVisitModuleSigDecl_Types(this, context, typeDefSigs, range) with
        | Some result -> result
        | None ->
          let typeDefSigs, range = typeDefSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypeDefnSig context v)), range
          match this.VisitModuleSigDecl_Types(this, context, typeDefSigs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Types(typeDefSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range) ->
        match this.BeforeVisitModuleSigDecl_Exception(this, context, exnSig, range) with
        | Some result -> result
        | None ->
          let exnSig, range = (this.VisitExceptionSig context exnSig), range
          match this.VisitModuleSigDecl_Exception(this, context, exnSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Exception(exnSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range) ->
        match this.BeforeVisitModuleSigDecl_Open(this, context, longId, range) with
        | Some result -> result
        | None ->
          let longId, range = longId, range
          match this.VisitModuleSigDecl_Open(this, context, longId, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.Open(longId, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range) ->
        match this.BeforeVisitModuleSigDecl_HashDirective(this, context, hashDirective, range) with
        | Some result -> result
        | None ->
          let hashDirective, range = (this.VisitHashDirective context hashDirective), range
          match this.VisitModuleSigDecl_HashDirective(this, context, hashDirective, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.HashDirective(hashDirective, range)
      | Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item) ->
        match this.BeforeVisitModuleSigDecl_NamespaceFragment(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitModuleOrNamespaceSig context item)
          match this.VisitModuleSigDecl_NamespaceFragment(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl.NamespaceFragment(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynPat

  /// <summary>
  /// Before visit "SynPat.Const" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Const" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Const =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Wild" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Wild =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Wild" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Wild =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Named" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       isThisVar: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Named" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Named =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       isThisVar: bool,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Attrib" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Attrib" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Or" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Or =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Or" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Or =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Ands" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Ands =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Ands" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Ands =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.Ident option,
       item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
       item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
       item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       item2: Microsoft.FSharp.Compiler.Ast.Ident option,
       item3: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls option,
       item4: Microsoft.FSharp.Compiler.Ast.SynConstructorArgs,
       item5: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Paren" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Paren" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Paren =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.ArrayOrList" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.ArrayOrList" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_ArrayOrList =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: bool,
       item2: Microsoft.FSharp.Compiler.Ast.SynPat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       fields: ((Microsoft.FSharp.Compiler.Ast.Ident list * Microsoft.FSharp.Compiler.Ast.Ident) * Microsoft.FSharp.Compiler.Ast.SynPat) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.Null" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.Null" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_Null =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.OptionalVal" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_OptionalVal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.OptionalVal" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_OptionalVal =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.IsInst" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_IsInst =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.IsInst" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_IsInst =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.QuoteExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_QuoteExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.QuoteExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_QuoteExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.DeprecatedCharRange" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_DeprecatedCharRange =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: char,
       item2: char,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.DeprecatedCharRange" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_DeprecatedCharRange =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: char,
       item2: char,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.InstanceMember" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_InstanceMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option,
       accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.InstanceMember" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_InstanceMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.Ident,
       item2: Microsoft.FSharp.Compiler.Ast.Ident,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option,
       accesiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynPat.FromParseError" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitPat_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynPat.FromParseError" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitPat_FromParseError =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynPat,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynPat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synPat">SynPat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitPat
      (context: 'TContext)
      (synPat: Microsoft.FSharp.Compiler.Ast.SynPat) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Pat synPat)
    try
      match synPat with
      | Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range) ->
        match this.BeforeVisitPat_Const(this, context, constant, range) with
        | Some result -> result
        | None ->
          let constant, range = (this.VisitConst context constant), range
          match this.VisitPat_Const(this, context, constant, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Const(constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range) ->
        match this.BeforeVisitPat_Wild(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitPat_Wild(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Wild(range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range) ->
        match this.BeforeVisitPat_Named(this, context, item1, id, isThisVar, accessiblity, range) with
        | Some result -> result
        | None ->
          let item1, id, isThisVar, accessiblity, range = (this.VisitPat context item1), id, isThisVar, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitPat_Named(this, context, item1, id, isThisVar, accessiblity, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Named(item1, id, isThisVar, accessiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range) ->
        match this.BeforeVisitPat_Typed(this, context, item1, typeName, range) with
        | Some result -> result
        | None ->
          let item1, typeName, range = (this.VisitPat context item1), (this.VisitType context typeName), range
          match this.VisitPat_Typed(this, context, item1, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Typed(item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range) ->
        match this.BeforeVisitPat_Attrib(this, context, item1, attributes, range) with
        | Some result -> result
        | None ->
          let item1, attributes, range = (this.VisitPat context item1), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range
          match this.VisitPat_Attrib(this, context, item1, attributes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Attrib(item1, attributes, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range) ->
        match this.BeforeVisitPat_Or(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitPat context item1), (this.VisitPat context item2), range
          match this.VisitPat_Or(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Or(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range) ->
        match this.BeforeVisitPat_Ands(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitPat context v)), range
          match this.VisitPat_Ands(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Ands(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range) ->
        match this.BeforeVisitPat_LongIdent(this, context, dotId, item2, item3, item4, item5, range) with
        | Some result -> result
        | None ->
          let dotId, item2, item3, item4, item5, range = dotId, item2, item3 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitValTyparDecls context v)), (this.VisitConstructorArgs context item4), item5 |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitPat_LongIdent(this, context, dotId, item2, item3, item4, item5, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.LongIdent(dotId, item2, item3, item4, item5, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range) ->
        match this.BeforeVisitPat_Tuple(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitPat context v)), range
          match this.VisitPat_Tuple(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Tuple(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range) ->
        match this.BeforeVisitPat_Paren(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitPat context item1), range
          match this.VisitPat_Paren(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Paren(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range) ->
        match this.BeforeVisitPat_ArrayOrList(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = item1, item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitPat context v)), range
          match this.VisitPat_ArrayOrList(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.ArrayOrList(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range) ->
        match this.BeforeVisitPat_Record(this, context, fields, range) with
        | Some result -> result
        | None ->
          let fields, range = fields |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (this.VisitPat context v1))), range
          match this.VisitPat_Record(this, context, fields, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Record(fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.Null(range) ->
        match this.BeforeVisitPat_Null(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitPat_Null(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.Null(range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range) ->
        match this.BeforeVisitPat_OptionalVal(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1, range
          match this.VisitPat_OptionalVal(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.OptionalVal(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range) ->
        match this.BeforeVisitPat_IsInst(this, context, typeName, range) with
        | Some result -> result
        | None ->
          let typeName, range = (this.VisitType context typeName), range
          match this.VisitPat_IsInst(this, context, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.IsInst(typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range) ->
        match this.BeforeVisitPat_QuoteExpr(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitPat_QuoteExpr(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.QuoteExpr(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range) ->
        match this.BeforeVisitPat_DeprecatedCharRange(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = item1, item2, range
          match this.VisitPat_DeprecatedCharRange(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.DeprecatedCharRange(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range) ->
        match this.BeforeVisitPat_InstanceMember(this, context, item1, item2, item3, accesiblity, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, accesiblity, range = item1, item2, item3, accesiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitPat_InstanceMember(this, context, item1, item2, item3, accesiblity, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.InstanceMember(item1, item2, item3, accesiblity, range)
      | Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range) ->
        match this.BeforeVisitPat_FromParseError(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitPat context item1), range
          match this.VisitPat_FromParseError(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynPat.FromParseError(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynRationalConst

  /// <summary>
  /// Before visit "SynRationalConst.Integer" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitRationalConst_Integer =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) -> None
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Integer" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitRationalConst_Integer =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: int) -> None
    with get, set

  /// <summary>
  /// Before visit "SynRationalConst.Rational" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitRationalConst_Rational =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       item2: int,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Rational" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitRationalConst_Rational =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       item2: int,
       item3: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynRationalConst.Negate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitRationalConst_Negate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) -> None
    with get, set

  /// <summary>
  /// Visit "SynRationalConst.Negate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitRationalConst_Negate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynRationalConst) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynRationalConst" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synRationalConst">SynRationalConst expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitRationalConst
      (context: 'TContext)
      (synRationalConst: Microsoft.FSharp.Compiler.Ast.SynRationalConst) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.RationalConst synRationalConst)
    try
      match synRationalConst with
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item) ->
        match this.BeforeVisitRationalConst_Integer(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitRationalConst_Integer(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynRationalConst.Integer(item)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3) ->
        match this.BeforeVisitRationalConst_Rational(this, context, item1, item2, item3) with
        | Some result -> result
        | None ->
          let item1, item2, item3 = item1, item2, item3
          match this.VisitRationalConst_Rational(this, context, item1, item2, item3) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynRationalConst.Rational(item1, item2, item3)
      | Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item) ->
        match this.BeforeVisitRationalConst_Negate(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitRationalConst context item)
          match this.VisitRationalConst_Negate(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynRationalConst.Negate(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynReturnInfo

  /// <summary>
  /// Before visit "SynReturnInfo.SynReturnInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitReturnInfo_SynReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynReturnInfo.SynReturnInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitReturnInfo_SynReturnInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynArgInfo),
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynReturnInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synReturnInfo">SynReturnInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitReturnInfo
      (context: 'TContext)
      (synReturnInfo: Microsoft.FSharp.Compiler.Ast.SynReturnInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ReturnInfo synReturnInfo)
    try
      match synReturnInfo with
      | Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range) ->
        match this.BeforeVisitReturnInfo_SynReturnInfo(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (let v0, v1 = item1 in (this.VisitType context v0), (this.VisitArgInfo context v1)), range
          match this.VisitReturnInfo_SynReturnInfo(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynReturnInfo(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePat

  /// <summary>
  /// Before visit "SynSimplePat.Id" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePat_Id =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       ident: Microsoft.FSharp.Compiler.Ast.Ident,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       isCompilerGenerated: bool,
       isThisVar: bool,
       isOptArg: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Id" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePat_Id =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       ident: Microsoft.FSharp.Compiler.Ast.Ident,
       altNameRefCell: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo ref option,
       isCompilerGenerated: bool,
       isThisVar: bool,
       isOptArg: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynSimplePat.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePat_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynSimplePat.Attrib" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePat.Attrib" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePat_Attrib =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynSimplePat" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePat">SynSimplePat expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePat
      (context: 'TContext)
      (synSimplePat: Microsoft.FSharp.Compiler.Ast.SynSimplePat) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SimplePat synSimplePat)
    try
      match synSimplePat with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) ->
        match this.BeforeVisitSimplePat_Id(this, context, ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) with
        | Some result -> result
        | None ->
          use _rwh_ = new RefWrapperHolder()
          let ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range = ident, altNameRefCell |> Microsoft.FSharp.Core.Option.map (fun v -> _rwh_.Wrap v (this.VisitSimplePatAlternativeIdInfo context v.Value)), isCompilerGenerated, isThisVar, isOptArg, range
          match this.VisitSimplePat_Id(this, context, ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePat.Id(ident, altNameRefCell, isCompilerGenerated, isThisVar, isOptArg, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range) ->
        match this.BeforeVisitSimplePat_Typed(this, context, item1, typeName, range) with
        | Some result -> result
        | None ->
          let item1, typeName, range = (this.VisitSimplePat context item1), (this.VisitType context typeName), range
          match this.VisitSimplePat_Typed(this, context, item1, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePat.Typed(item1, typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range) ->
        match this.BeforeVisitSimplePat_Attrib(this, context, item1, attributes, range) with
        | Some result -> result
        | None ->
          let item1, attributes, range = (this.VisitSimplePat context item1), attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), range
          match this.VisitSimplePat_Attrib(this, context, item1, attributes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePat.Attrib(item1, attributes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePatAlternativeIdInfo

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Undecided" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePatAlternativeIdInfo_Undecided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Undecided" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePatAlternativeIdInfo_Undecided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set

  /// <summary>
  /// Before visit "SynSimplePatAlternativeIdInfo.Decided" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePatAlternativeIdInfo_Decided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePatAlternativeIdInfo.Decided" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePatAlternativeIdInfo_Decided =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.Ident) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynSimplePatAlternativeIdInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePatAlternativeIdInfo">SynSimplePatAlternativeIdInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePatAlternativeIdInfo
      (context: 'TContext)
      (synSimplePatAlternativeIdInfo: Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SimplePatAlternativeIdInfo synSimplePatAlternativeIdInfo)
    try
      match synSimplePatAlternativeIdInfo with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item) ->
        match this.BeforeVisitSimplePatAlternativeIdInfo_Undecided(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitSimplePatAlternativeIdInfo_Undecided(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Undecided(item)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item) ->
        match this.BeforeVisitSimplePatAlternativeIdInfo_Decided(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitSimplePatAlternativeIdInfo_Decided(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo.Decided(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynSimplePats

  /// <summary>
  /// Before visit "SynSimplePats.SimplePats" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePats_SimplePats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePats.SimplePats" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePats_SimplePats =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePat list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynSimplePats.Typed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitSimplePats_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynSimplePats.Typed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitSimplePats_Typed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynSimplePats,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynSimplePats" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synSimplePats">SynSimplePats expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitSimplePats
      (context: 'TContext)
      (synSimplePats: Microsoft.FSharp.Compiler.Ast.SynSimplePats) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.SimplePats synSimplePats)
    try
      match synSimplePats with
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, range) ->
        match this.BeforeVisitSimplePats_SimplePats(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitSimplePat context v)), range
          match this.VisitSimplePats_SimplePats(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, item2, range) ->
        match this.BeforeVisitSimplePats_Typed(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitSimplePats context item1), (this.VisitType context item2), range
          match this.VisitSimplePats_Typed(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynSimplePats(item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynStaticOptimizationConstraint

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynStaticOptimizationConstraint.WhenTyparIsStruct" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitStaticOptimizationConstraint_WhenTyparIsStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynStaticOptimizationConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synStaticOptimizationConstraint">SynStaticOptimizationConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitStaticOptimizationConstraint
      (context: 'TContext)
      (synStaticOptimizationConstraint: Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.StaticOptimizationConstraint synStaticOptimizationConstraint)
    try
      match synStaticOptimizationConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range) ->
        match this.BeforeVisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitTypar context item1), (this.VisitType context item2), range
          match this.VisitStaticOptimizationConstraint_WhenTyparTyconEqualsTycon(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparTyconEqualsTycon(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range) ->
        match this.BeforeVisitStaticOptimizationConstraint_WhenTyparIsStruct(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitTypar context item1), range
          match this.VisitStaticOptimizationConstraint_WhenTyparIsStruct(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint.WhenTyparIsStruct(item1, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypar

  /// <summary>
  /// Before visit "SynTypar.Typar" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypar_Typar =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
       isCompGen: bool) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypar.Typar" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypar_Typar =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       staticReq: Microsoft.FSharp.Compiler.Ast.TyparStaticReq,
       isCompGen: bool) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypar" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypar">SynTypar expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypar
      (context: 'TContext)
      (synTypar: Microsoft.FSharp.Compiler.Ast.SynTypar) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Typar synTypar)
    try
      match synTypar with
      | Microsoft.FSharp.Compiler.Ast.SynTypar(id, staticReq, isCompGen) ->
        match this.BeforeVisitTypar_Typar(this, context, id, staticReq, isCompGen) with
        | Some result -> result
        | None ->
          let id, staticReq, isCompGen = id, staticReq, isCompGen
          match this.VisitTypar_Typar(this, context, id, staticReq, isCompGen) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypar(id, staticReq, isCompGen)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTyparDecl

  /// <summary>
  /// Before visit "SynTyparDecl.TyparDecl" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTyparDecl_TyparDecl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypar) -> None
    with get, set

  /// <summary>
  /// Visit "SynTyparDecl.TyparDecl" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTyparDecl_TyparDecl =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypar) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTyparDecl" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTyparDecl">SynTyparDecl expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTyparDecl
      (context: 'TContext)
      (synTyparDecl: Microsoft.FSharp.Compiler.Ast.SynTyparDecl) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TyparDecl synTyparDecl)
    try
      match synTyparDecl with
      | Microsoft.FSharp.Compiler.Ast.SynTyparDecl(attributes, item2) ->
        match this.BeforeVisitTyparDecl_TyparDecl(this, context, attributes, item2) with
        | Some result -> result
        | None ->
          let attributes, item2 = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), (this.VisitTypar context item2)
          match this.VisitTyparDecl_TyparDecl(this, context, attributes, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTyparDecl(attributes, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynType

  /// <summary>
  /// Before visit "SynType.LongIdent" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.LongIdent" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_LongIdent =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.App" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       isPostfix: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.App" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_App =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       typeArgs: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       isPostfix: bool,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.LongIdentApp" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_LongIdentApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.LongIdentApp" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_LongIdentApp =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       dotId: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
       leftAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynType list,
       commaRanges: Microsoft.FSharp.Compiler.Range.range list,
       rightAngleRange: Microsoft.FSharp.Compiler.Range.range option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.Tuple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.Tuple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_Tuple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: (bool * Microsoft.FSharp.Compiler.Ast.SynType) list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.Array" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_Array =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       elementType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.Array" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_Array =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: int,
       elementType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.Fun" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_Fun =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       argType: Microsoft.FSharp.Compiler.Ast.SynType,
       returnType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.Fun" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_Fun =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       argType: Microsoft.FSharp.Compiler.Ast.SynType,
       returnType: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.Var" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.Var" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_Var =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.Anon" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.Anon" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_Anon =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.WithGlobalConstraints" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_WithGlobalConstraints =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.WithGlobalConstraints" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_WithGlobalConstraints =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.HashConstraint" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_HashConstraint =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.HashConstraint" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_HashConstraint =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.MeasureDivide" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_MeasureDivide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.MeasureDivide" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_MeasureDivide =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.MeasurePower" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_MeasurePower =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.MeasurePower" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_MeasurePower =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynRationalConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstant" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_StaticConstant =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstant" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_StaticConstant =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       constant: Microsoft.FSharp.Compiler.Ast.SynConst,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstantExpr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_StaticConstantExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstantExpr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_StaticConstantExpr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynType.StaticConstantNamed" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitType_StaticConstantNamed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynType.StaticConstantNamed" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitType_StaticConstantNamed =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synType">SynType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitType
      (context: 'TContext)
      (synType: Microsoft.FSharp.Compiler.Ast.SynType) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.Type synType)
    try
      match synType with
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item) ->
        match this.BeforeVisitType_LongIdent(this, context, item) with
        | Some result -> result
        | None ->
          let item = item
          match this.VisitType_LongIdent(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.LongIdent(item)
      | Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) ->
        match this.BeforeVisitType_App(this, context, typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) with
        | Some result -> result
        | None ->
          let typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range = (this.VisitType context typeName), leftAngleRange, typeArgs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), commaRanges, rightAngleRange, isPostfix, range
          match this.VisitType_App(this, context, typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.App(typeName, leftAngleRange, typeArgs, commaRanges, rightAngleRange, isPostfix, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) ->
        match this.BeforeVisitType_LongIdentApp(this, context, typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) with
        | Some result -> result
        | None ->
          let typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range = (this.VisitType context typeName), dotId, leftAngleRange, genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), commaRanges, rightAngleRange, range
          match this.VisitType_LongIdentApp(this, context, typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.LongIdentApp(typeName, dotId, leftAngleRange, genericNames, commaRanges, rightAngleRange, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range) ->
        match this.BeforeVisitType_Tuple(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in v0, (this.VisitType context v1))), range
          match this.VisitType_Tuple(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.Tuple(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range) ->
        match this.BeforeVisitType_Array(this, context, item1, elementType, range) with
        | Some result -> result
        | None ->
          let item1, elementType, range = item1, (this.VisitType context elementType), range
          match this.VisitType_Array(this, context, item1, elementType, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.Array(item1, elementType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range) ->
        match this.BeforeVisitType_Fun(this, context, argType, returnType, range) with
        | Some result -> result
        | None ->
          let argType, returnType, range = (this.VisitType context argType), (this.VisitType context returnType), range
          match this.VisitType_Fun(this, context, argType, returnType, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.Fun(argType, returnType, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range) ->
        match this.BeforeVisitType_Var(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitTypar context item1), range
          match this.VisitType_Var(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.Var(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.Anon(range) ->
        match this.BeforeVisitType_Anon(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitType_Anon(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.Anon(range)
      | Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range) ->
        match this.BeforeVisitType_WithGlobalConstraints(this, context, typeName, constraints, range) with
        | Some result -> result
        | None ->
          let typeName, constraints, range = (this.VisitType context typeName), constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypeConstraint context v)), range
          match this.VisitType_WithGlobalConstraints(this, context, typeName, constraints, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.WithGlobalConstraints(typeName, constraints, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range) ->
        match this.BeforeVisitType_HashConstraint(this, context, typeName, range) with
        | Some result -> result
        | None ->
          let typeName, range = (this.VisitType context typeName), range
          match this.VisitType_HashConstraint(this, context, typeName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.HashConstraint(typeName, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range) ->
        match this.BeforeVisitType_MeasureDivide(this, context, typeName, item2, range) with
        | Some result -> result
        | None ->
          let typeName, item2, range = (this.VisitType context typeName), (this.VisitType context item2), range
          match this.VisitType_MeasureDivide(this, context, typeName, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.MeasureDivide(typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range) ->
        match this.BeforeVisitType_MeasurePower(this, context, typeName, item2, range) with
        | Some result -> result
        | None ->
          let typeName, item2, range = (this.VisitType context typeName), (this.VisitRationalConst context item2), range
          match this.VisitType_MeasurePower(this, context, typeName, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.MeasurePower(typeName, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range) ->
        match this.BeforeVisitType_StaticConstant(this, context, constant, range) with
        | Some result -> result
        | None ->
          let constant, range = (this.VisitConst context constant), range
          match this.VisitType_StaticConstant(this, context, constant, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.StaticConstant(constant, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range) ->
        match this.BeforeVisitType_StaticConstantExpr(this, context, expr, range) with
        | Some result -> result
        | None ->
          let expr, range = (this.VisitExpr context expr), range
          match this.VisitType_StaticConstantExpr(this, context, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantExpr(expr, range)
      | Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range) ->
        match this.BeforeVisitType_StaticConstantNamed(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = (this.VisitType context item1), (this.VisitType context item2), range
          match this.VisitType_StaticConstantNamed(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynType.StaticConstantNamed(item1, item2, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeConstraint

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsValueType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsValueType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsValueType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsValueType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsReferenceType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsReferenceType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsReferenceType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsReferenceType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsUnmanaged" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsUnmanaged =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsUnmanaged" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsUnmanaged =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsNull" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparSupportsNull =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsNull" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparSupportsNull =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsComparable" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsComparable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsComparable" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsComparable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEquatable" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsEquatable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEquatable" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsEquatable =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparDefaultsToType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparDefaultsToType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparDefaultsToType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparDefaultsToType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSubtypeOfType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparSubtypeOfType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSubtypeOfType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparSubtypeOfType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       typeSig: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparSupportsMember" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparSupportsMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparSupportsMember" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparSupportsMember =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericNames: Microsoft.FSharp.Compiler.Ast.SynTypar list,
       memberSig: Microsoft.FSharp.Compiler.Ast.SynMemberSig,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsEnum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsEnum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsEnum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsEnum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       enumTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeConstraint.WhereTyparIsDelegate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeConstraint_WhereTyparIsDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeConstraint.WhereTyparIsDelegate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeConstraint_WhereTyparIsDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       genericName: Microsoft.FSharp.Compiler.Ast.SynTypar,
       delegateTypes: Microsoft.FSharp.Compiler.Ast.SynType list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeConstraint" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeConstraint">SynTypeConstraint expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeConstraint
      (context: 'TContext)
      (synTypeConstraint: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeConstraint synTypeConstraint)
    try
      match synTypeConstraint with
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsValueType(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparIsValueType(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsValueType(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsReferenceType(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparIsReferenceType(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsReferenceType(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsUnmanaged(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparIsUnmanaged(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsUnmanaged(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparSupportsNull(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparSupportsNull(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsNull(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsComparable(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparIsComparable(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsComparable(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsEquatable(this, context, genericName, range) with
        | Some result -> result
        | None ->
          let genericName, range = (this.VisitTypar context genericName), range
          match this.VisitTypeConstraint_WhereTyparIsEquatable(this, context, genericName, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEquatable(genericName, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparDefaultsToType(this, context, genericName, typeSig, range) with
        | Some result -> result
        | None ->
          let genericName, typeSig, range = (this.VisitTypar context genericName), (this.VisitType context typeSig), range
          match this.VisitTypeConstraint_WhereTyparDefaultsToType(this, context, genericName, typeSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparDefaultsToType(genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparSubtypeOfType(this, context, genericName, typeSig, range) with
        | Some result -> result
        | None ->
          let genericName, typeSig, range = (this.VisitTypar context genericName), (this.VisitType context typeSig), range
          match this.VisitTypeConstraint_WhereTyparSubtypeOfType(this, context, genericName, typeSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSubtypeOfType(genericName, typeSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparSupportsMember(this, context, genericNames, memberSig, range) with
        | Some result -> result
        | None ->
          let genericNames, memberSig, range = genericNames |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypar context v)), (this.VisitMemberSig context memberSig), range
          match this.VisitTypeConstraint_WhereTyparSupportsMember(this, context, genericNames, memberSig, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparSupportsMember(genericNames, memberSig, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsEnum(this, context, genericName, enumTypes, range) with
        | Some result -> result
        | None ->
          let genericName, enumTypes, range = (this.VisitTypar context genericName), enumTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), range
          match this.VisitTypeConstraint_WhereTyparIsEnum(this, context, genericName, enumTypes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsEnum(genericName, enumTypes, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range) ->
        match this.BeforeVisitTypeConstraint_WhereTyparIsDelegate(this, context, genericName, delegateTypes, range) with
        | Some result -> result
        | None ->
          let genericName, delegateTypes, range = (this.VisitTypar context genericName), delegateTypes |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitType context v)), range
          match this.VisitTypeConstraint_WhereTyparIsDelegate(this, context, genericName, delegateTypes, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeConstraint.WhereTyparIsDelegate(genericName, delegateTypes, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefn

  /// <summary>
  /// Before visit "SynTypeDefn.TypeDefn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefn_TypeDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefn.TypeDefn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefn_TypeDefn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefn" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefn">SynTypeDefn expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefn
      (context: 'TContext)
      (synTypeDefn: Microsoft.FSharp.Compiler.Ast.SynTypeDefn) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefn synTypeDefn)
    try
      match synTypeDefn with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefn(item1, item2, members, range) ->
        match this.BeforeVisitTypeDefn_TypeDefn(this, context, item1, item2, members, range) with
        | Some result -> result
        | None ->
          let item1, item2, members, range = (this.VisitComponentInfo context item1), (this.VisitTypeDefnRepr context item2), members |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberDefn context v)), range
          match this.VisitTypeDefn_TypeDefn(this, context, item1, item2, members, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefn(item1, item2, members, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnKind

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnspecified" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconUnspecified =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnspecified" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconUnspecified =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconClass" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconClass =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconClass" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconClass =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconInterface" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconInterface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconInterface" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconInterface =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconStruct" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconStruct" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconStruct =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconRecord" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconRecord =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconRecord" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconRecord =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconUnion" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconUnion =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconUnion" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconUnion =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconHiddenRepr" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconHiddenRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconHiddenRepr" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconHiddenRepr =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconAugmentation" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconAugmentation =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconAugmentation" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconAugmentation =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconILAssemblyCode" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconILAssemblyCode =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconILAssemblyCode" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconILAssemblyCode =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnKind.TyconDelegate" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnKind_TyconDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnKind.TyconDelegate" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnKind_TyconDelegate =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynType,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefnKind" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnKind">SynTypeDefnKind expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnKind
      (context: 'TContext)
      (synTypeDefnKind: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefnKind synTypeDefnKind)
    try
      match synTypeDefnKind with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified ->
        match this.BeforeVisitTypeDefnKind_TyconUnspecified(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconUnspecified(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnspecified
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass ->
        match this.BeforeVisitTypeDefnKind_TyconClass(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconClass(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconClass
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface ->
        match this.BeforeVisitTypeDefnKind_TyconInterface(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconInterface(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconInterface
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct ->
        match this.BeforeVisitTypeDefnKind_TyconStruct(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconStruct(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconStruct
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord ->
        match this.BeforeVisitTypeDefnKind_TyconRecord(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconRecord(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconRecord
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion ->
        match this.BeforeVisitTypeDefnKind_TyconUnion(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconUnion(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconUnion
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev ->
        match this.BeforeVisitTypeDefnKind_TyconAbbrev(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconAbbrev(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAbbrev
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr ->
        match this.BeforeVisitTypeDefnKind_TyconHiddenRepr(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconHiddenRepr(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconHiddenRepr
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation ->
        match this.BeforeVisitTypeDefnKind_TyconAugmentation(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconAugmentation(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconAugmentation
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode ->
        match this.BeforeVisitTypeDefnKind_TyconILAssemblyCode(this, context) with
        | Some result -> result
        | None ->
          match this.VisitTypeDefnKind_TyconILAssemblyCode(this, context) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconILAssemblyCode
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2) ->
        match this.BeforeVisitTypeDefnKind_TyconDelegate(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = (this.VisitType context item1), (this.VisitValInfo context item2)
          match this.VisitTypeDefnKind_TyconDelegate(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind.TyconDelegate(item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnRepr

  /// <summary>
  /// Before visit "SynTypeDefnRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       members: Microsoft.FSharp.Compiler.Ast.SynMemberDefn list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Simple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.Simple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefnRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnRepr">SynTypeDefnRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnRepr
      (context: 'TContext)
      (synTypeDefnRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefnRepr synTypeDefnRepr)
    try
      match synTypeDefnRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range) ->
        match this.BeforeVisitTypeDefnRepr_ObjectModel(this, context, item1, members, range) with
        | Some result -> result
        | None ->
          let item1, members, range = (this.VisitTypeDefnKind context item1), members |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberDefn context v)), range
          match this.VisitTypeDefnRepr_ObjectModel(this, context, item1, members, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.ObjectModel(item1, members, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range) ->
        match this.BeforeVisitTypeDefnRepr_Simple(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitTypeDefnSimpleRepr context item1), range
          match this.VisitTypeDefnRepr_Simple(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Simple(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item) ->
        match this.BeforeVisitTypeDefnRepr_Exception(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitExceptionDefnRepr context item)
          match this.VisitTypeDefnRepr_Exception(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr.Exception(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSig

  /// <summary>
  /// Before visit "SynTypeDefnSig.TypeDefnSig" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSig_TypeDefnSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSig.TypeDefnSig" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSig_TypeDefnSig =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynComponentInfo,
       item2: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSig">SynTypeDefnSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSig
      (context: 'TContext)
      (synTypeDefnSig: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefnSig synTypeDefnSig)
    try
      match synTypeDefnSig with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig(item1, item2, memberSigs, range) ->
        match this.BeforeVisitTypeDefnSig_TypeDefnSig(this, context, item1, item2, memberSigs, range) with
        | Some result -> result
        | None ->
          let item1, item2, memberSigs, range = (this.VisitComponentInfo context item1), (this.VisitTypeDefnSigRepr context item2), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberSig context v)), range
          match this.VisitTypeDefnSig_TypeDefnSig(this, context, item1, item2, memberSigs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig(item1, item2, memberSigs, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSigRepr

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.ObjectModel" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSigRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.ObjectModel" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSigRepr_ObjectModel =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       memberSigs: Microsoft.FSharp.Compiler.Ast.SynMemberSig list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Simple" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSigRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Simple" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSigRepr_Simple =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSigRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSigRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSigRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSigRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSigRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSigRepr">SynTypeDefnSigRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSigRepr
      (context: 'TContext)
      (synTypeDefnSigRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefnSigRepr synTypeDefnSigRepr)
    try
      match synTypeDefnSigRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range) ->
        match this.BeforeVisitTypeDefnSigRepr_ObjectModel(this, context, item1, memberSigs, range) with
        | Some result -> result
        | None ->
          let item1, memberSigs, range = (this.VisitTypeDefnKind context item1), memberSigs |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitMemberSig context v)), range
          match this.VisitTypeDefnSigRepr_ObjectModel(this, context, item1, memberSigs, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.ObjectModel(item1, memberSigs, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range) ->
        match this.BeforeVisitTypeDefnSigRepr_Simple(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = (this.VisitTypeDefnSimpleRepr context item1), range
          match this.VisitTypeDefnSigRepr_Simple(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Simple(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item) ->
        match this.BeforeVisitTypeDefnSigRepr_Exception(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitExceptionDefnRepr context item)
          match this.VisitTypeDefnSigRepr_Exception(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr.Exception(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynTypeDefnSimpleRepr

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Union" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_Union =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Union" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_Union =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       cases: Microsoft.FSharp.Compiler.Ast.SynUnionCase list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Enum" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_Enum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Enum" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_Enum =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynEnumCase list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Record" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       fields: Microsoft.FSharp.Compiler.Ast.SynField list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Record" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_Record =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       fields: Microsoft.FSharp.Compiler.Ast.SynField list,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.General" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_General =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
       item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
       item4: Microsoft.FSharp.Compiler.Ast.SynField list,
       item5: bool,
       item6: bool,
       item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.General" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_General =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind,
       item2: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Range.range * Microsoft.FSharp.Compiler.Ast.Ident option) list,
       item3: (Microsoft.FSharp.Compiler.Ast.SynValSig * Microsoft.FSharp.Compiler.Ast.MemberFlags) list,
       item4: Microsoft.FSharp.Compiler.Ast.SynField list,
       item5: bool,
       item6: bool,
       item7: Microsoft.FSharp.Compiler.Ast.SynSimplePat list option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.LibraryOnlyILAssembly" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.TypeAbbrev" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_TypeAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.TypeAbbrev" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_TypeAbbrev =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.ParserDetail,
       item2: Microsoft.FSharp.Compiler.Ast.SynType,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.None" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_None =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.None" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_None =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Before visit "SynTypeDefnSimpleRepr.Exception" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitTypeDefnSimpleRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set

  /// <summary>
  /// Visit "SynTypeDefnSimpleRepr.Exception" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitTypeDefnSimpleRepr_Exception =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynTypeDefnSimpleRepr" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synTypeDefnSimpleRepr">SynTypeDefnSimpleRepr expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitTypeDefnSimpleRepr
      (context: 'TContext)
      (synTypeDefnSimpleRepr: Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.TypeDefnSimpleRepr synTypeDefnSimpleRepr)
    try
      match synTypeDefnSimpleRepr with
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_Union(this, context, accessiblity, cases, range) with
        | Some result -> result
        | None ->
          let accessiblity, cases, range = accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), cases |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitUnionCase context v)), range
          match this.VisitTypeDefnSimpleRepr_Union(this, context, accessiblity, cases, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Union(accessiblity, cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_Enum(this, context, cases, range) with
        | Some result -> result
        | None ->
          let cases, range = cases |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitEnumCase context v)), range
          match this.VisitTypeDefnSimpleRepr_Enum(this, context, cases, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Enum(cases, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_Record(this, context, accessiblity, fields, range) with
        | Some result -> result
        | None ->
          let accessiblity, fields, range = accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), fields |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitField context v)), range
          match this.VisitTypeDefnSimpleRepr_Record(this, context, accessiblity, fields, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Record(accessiblity, fields, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_General(this, context, item1, item2, item3, item4, item5, item6, item7, range) with
        | Some result -> result
        | None ->
          let item1, item2, item3, item4, item5, item6, item7, range = (this.VisitTypeDefnKind context item1), item2 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1, v2 = v in (this.VisitType context v0), v1, v2)), item3 |> Microsoft.FSharp.Collections.List.map (fun v -> (let v0, v1 = v in (this.VisitValSig context v0), v1)), item4 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitField context v)), item5, item6, item7 |> Microsoft.FSharp.Core.Option.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitSimplePat context v))), range
          match this.VisitTypeDefnSimpleRepr_General(this, context, item1, item2, item3, item4, item5, item6, item7, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.General(item1, item2, item3, item4, item5, item6, item7, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(this, context, item1, range) with
        | Some result -> result
        | None ->
          let item1, range = item1, range
          match this.VisitTypeDefnSimpleRepr_LibraryOnlyILAssembly(this, context, item1, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.LibraryOnlyILAssembly(item1, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_TypeAbbrev(this, context, item1, item2, range) with
        | Some result -> result
        | None ->
          let item1, item2, range = item1, (this.VisitType context item2), range
          match this.VisitTypeDefnSimpleRepr_TypeAbbrev(this, context, item1, item2, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.TypeAbbrev(item1, item2, range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range) ->
        match this.BeforeVisitTypeDefnSimpleRepr_None(this, context, range) with
        | Some result -> result
        | None ->
          let range = range
          match this.VisitTypeDefnSimpleRepr_None(this, context, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.None(range)
      | Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item) ->
        match this.BeforeVisitTypeDefnSimpleRepr_Exception(this, context, item) with
        | Some result -> result
        | None ->
          let item = (this.VisitExceptionDefnRepr context item)
          match this.VisitTypeDefnSimpleRepr_Exception(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr.Exception(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCase

  /// <summary>
  /// Before visit "SynUnionCase.UnionCase" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitUnionCase_UnionCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynUnionCase.UnionCase" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitUnionCase_UnionCase =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       caseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessibility: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynUnionCase" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCase">SynUnionCase expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCase
      (context: 'TContext)
      (synUnionCase: Microsoft.FSharp.Compiler.Ast.SynUnionCase) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.UnionCase synUnionCase)
    try
      match synUnionCase with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCase(attributes, id, caseType, xmlDoc, accessibility, range) ->
        match this.BeforeVisitUnionCase_UnionCase(this, context, attributes, id, caseType, xmlDoc, accessibility, range) with
        | Some result -> result
        | None ->
          let attributes, id, caseType, xmlDoc, accessibility, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (this.VisitUnionCaseType context caseType), xmlDoc, accessibility |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), range
          match this.VisitUnionCase_UnionCase(this, context, attributes, id, caseType, xmlDoc, accessibility, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynUnionCase(attributes, id, caseType, xmlDoc, accessibility, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynUnionCaseType

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFields" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitUnionCaseType_UnionCaseFields =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynField list) -> None
    with get, set

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFields" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitUnionCaseType_UnionCaseFields =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       cases: Microsoft.FSharp.Compiler.Ast.SynField list) -> None
    with get, set

  /// <summary>
  /// Before visit "SynUnionCaseType.UnionCaseFullType" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitUnionCaseType_UnionCaseFullType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) -> None
    with get, set

  /// <summary>
  /// Visit "SynUnionCaseType.UnionCaseFullType" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitUnionCaseType_UnionCaseFullType =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item: (Microsoft.FSharp.Compiler.Ast.SynType * Microsoft.FSharp.Compiler.Ast.SynValInfo)) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynUnionCaseType" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synUnionCaseType">SynUnionCaseType expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitUnionCaseType
      (context: 'TContext)
      (synUnionCaseType: Microsoft.FSharp.Compiler.Ast.SynUnionCaseType) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.UnionCaseType synUnionCaseType)
    try
      match synUnionCaseType with
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases) ->
        match this.BeforeVisitUnionCaseType_UnionCaseFields(this, context, cases) with
        | Some result -> result
        | None ->
          let cases = cases |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitField context v))
          match this.VisitUnionCaseType_UnionCaseFields(this, context, cases) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFields(cases)
      | Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item) ->
        match this.BeforeVisitUnionCaseType_UnionCaseFullType(this, context, item) with
        | Some result -> result
        | None ->
          let item = (let v0, v1 = item in (this.VisitType context v0), (this.VisitValInfo context v1))
          match this.VisitUnionCaseType_UnionCaseFullType(this, context, item) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynUnionCaseType.UnionCaseFullType(item)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValData

  /// <summary>
  /// Before visit "SynValData.SynValData" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitValData_SynValData =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option) -> None
    with get, set

  /// <summary>
  /// Visit "SynValData.SynValData" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitValData_SynValData =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.MemberFlags option,
       item2: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item3: Microsoft.FSharp.Compiler.Ast.Ident option) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynValData" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValData">SynValData expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValData
      (context: 'TContext)
      (synValData: Microsoft.FSharp.Compiler.Ast.SynValData) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ValData synValData)
    try
      match synValData with
      | Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3) ->
        match this.BeforeVisitValData_SynValData(this, context, item1, item2, item3) with
        | Some result -> result
        | None ->
          let item1, item2, item3 = item1, (this.VisitValInfo context item2), item3
          match this.VisitValData_SynValData(this, context, item1, item2, item3) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynValData(item1, item2, item3)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValInfo

  /// <summary>
  /// Before visit "SynValInfo.SynValInfo" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitValInfo_SynValInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
       item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) -> None
    with get, set

  /// <summary>
  /// Visit "SynValInfo.SynValInfo" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitValInfo_SynValInfo =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynArgInfo list list,
       item2: Microsoft.FSharp.Compiler.Ast.SynArgInfo) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynValInfo" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValInfo">SynValInfo expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValInfo
      (context: 'TContext)
      (synValInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ValInfo synValInfo)
    try
      match synValInfo with
      | Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2) ->
        match this.BeforeVisitValInfo_SynValInfo(this, context, item1, item2) with
        | Some result -> result
        | None ->
          let item1, item2 = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> v |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitArgInfo context v))), (this.VisitArgInfo context item2)
          match this.VisitValInfo_SynValInfo(this, context, item1, item2) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynValInfo(item1, item2)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValSig

  /// <summary>
  /// Before visit "SynValSig.ValSpfn" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitValSig_ValSpfn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item6: bool,
       isMutable: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set

  /// <summary>
  /// Visit "SynValSig.ValSpfn" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitValSig_ValSpfn =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       attributes: Microsoft.FSharp.Compiler.Ast.SynAttribute list,
       id: Microsoft.FSharp.Compiler.Ast.Ident,
       typeParams: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls,
       typeName: Microsoft.FSharp.Compiler.Ast.SynType,
       valInfo: Microsoft.FSharp.Compiler.Ast.SynValInfo,
       item6: bool,
       isMutable: bool,
       xmlDoc: Microsoft.FSharp.Compiler.Ast.PreXmlDoc,
       accessiblity: Microsoft.FSharp.Compiler.Ast.SynAccess option,
       expr: Microsoft.FSharp.Compiler.Ast.SynExpr option,
       range: Microsoft.FSharp.Compiler.Range.range) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynValSig" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValSig">SynValSig expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValSig
      (context: 'TContext)
      (synValSig: Microsoft.FSharp.Compiler.Ast.SynValSig) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ValSig synValSig)
    try
      match synValSig with
      | Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) ->
        match this.BeforeVisitValSig_ValSpfn(this, context, attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) with
        | Some result -> result
        | None ->
          let attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range = attributes |> Microsoft.FSharp.Collections.List.map (fun v -> AstRecordCons.genSynAttribute v.TypeName (this.VisitExpr context v.ArgExpr) v.Target v.AppliesToGetterAndSetter v.Range), id, (this.VisitValTyparDecls context typeParams), (this.VisitType context typeName), (this.VisitValInfo context valInfo), item6, isMutable, xmlDoc, accessiblity |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitAccess context v)), expr |> Microsoft.FSharp.Core.Option.map (fun v -> (this.VisitExpr context v)), range
          match this.VisitValSig_ValSpfn(this, context, attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynValSig.ValSpfn(attributes, id, typeParams, typeName, valInfo, item6, isMutable, xmlDoc, accessiblity, expr, range)
    finally
      parents.Pop() |> ignore

  //////////////////////////////////////////////
  // Expression: SynValTyparDecls

  /// <summary>
  /// Before visit "SynValTyparDecls.SynValTyparDecls" arguments.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val BeforeVisitValTyparDecls_SynValTyparDecls =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       item2: bool,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) -> None
    with get, set

  /// <summary>
  /// Visit "SynValTyparDecls.SynValTyparDecls" expression.
  /// </summary>
  /// <param name="visitor">Visitor instance.</param>
  /// <param name="context">Context object.</param>
  /// <returns>Constructed expression or None if defaulted.</returns>
  member val VisitValTyparDecls_SynValTyparDecls =
    fun
      (visitor: AstDelegatableVisitor<'TContext>,
       context: 'TContext,
       item1: Microsoft.FSharp.Compiler.Ast.SynTyparDecl list,
       item2: bool,
       constraints: Microsoft.FSharp.Compiler.Ast.SynTypeConstraint list) -> None
    with get, set


  /// <summary>
  /// Visit and dispatch "SynValTyparDecls" expression.
  /// </summary>
  /// <param name="context">Context object.</param>
  /// <param name="synValTyparDecls">SynValTyparDecls expression.</param>
  /// <returns>Constructed (or target) expression.</returns>
  member this.VisitValTyparDecls
      (context: 'TContext)
      (synValTyparDecls: Microsoft.FSharp.Compiler.Ast.SynValTyparDecls) =
    parents.Push(Microsoft.FSharp.Compiler.Ast.Visitor.AstElement.ValTyparDecls synValTyparDecls)
    try
      match synValTyparDecls with
      | Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints) ->
        match this.BeforeVisitValTyparDecls_SynValTyparDecls(this, context, item1, item2, constraints) with
        | Some result -> result
        | None ->
          let item1, item2, constraints = item1 |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTyparDecl context v)), item2, constraints |> Microsoft.FSharp.Collections.List.map (fun v -> (this.VisitTypeConstraint context v))
          match this.VisitValTyparDecls_SynValTyparDecls(this, context, item1, item2, constraints) with
          | Some result -> result
          | None -> Microsoft.FSharp.Compiler.Ast.SynValTyparDecls(item1, item2, constraints)
    finally
      parents.Pop() |> ignore

