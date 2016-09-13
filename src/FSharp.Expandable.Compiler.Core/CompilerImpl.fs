//////////////////////////////////////////////////////////////////////////////
// 
// fscx - Expandable F# compiler project
//   Author: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift)
//   GutHub: https://github.com/fscx-projects/
//
// Creative Commons Legal Code
// 
// CC0 1.0 Universal
// 
//   CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
//   LEGAL SERVICES.DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
//   ATTORNEY-CLIENT RELATIONSHIP.CREATIVE COMMONS PROVIDES THIS
//   INFORMATION ON AN "AS-IS" BASIS.CREATIVE COMMONS MAKES NO WARRANTIES
//   REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
//   PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
//   THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
//   HEREUNDER.
//
//////////////////////////////////////////////////////////////////////////////

namespace FSharp.Expandable

open System
open System.Diagnostics
open System.IO
open System.Runtime.InteropServices
      
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SimpleSourceCodeServices
open Microsoft.FSharp.Compiler.SourceCodeServices
open Microsoft.FSharp.Compiler.Ast.Visitor

type internal WriteInfo =
| Message of typ: EventLogEntryType * path: string * message: string
| ParseFailed of error: FSharpErrorInfo
| CheckFailed of path: string
| UnknownFailed of path: string * exn: exn

module internal CompilerImpl =

  ///////////////////////////////////////////////////////

  /// Read entire text file
  let asyncReadTextFile sourcePath = async {
    use fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, true)
    let sr = new StreamReader(fs, true)
    return! sr.ReadToEndAsync() |> Async.AwaitTask
  }

  /// Source code description
  type SourceCodeDescription = {
    /// Source code location
    Path: string
    /// Source code reader
    AsyncReadBody: unit -> Async<string>
  }

  /// Create SourceCodeDescriptions
  let createSourceCodeDescriptions sourcePaths =
    sourcePaths
    |> Seq.map (fun path -> { Path = path; AsyncReadBody = (fun _ -> asyncReadTextFile path) })
    
  ///////////////////////////////////////////////////////

  /// Create compilation options
  let createOptions projectPath optionArgs sourcePaths =
    let optionWithSource = seq {
      yield! optionArgs
      yield! sourcePaths
    }

    let checker = FSharpChecker.Create()
    checker.GetProjectOptionsFromCommandLineArgs(
      projectPath,
      optionWithSource |> Seq.toArray)

  ///////////////////////////////////////////////////////

  /// Result for parse and apply
  type ParseAndApplyResult =
    /// Success
    | Succeeded of path: string * ast: ParsedInput
    /// Parse failed
    | ParseFailed of path: string * errors: FSharpErrorInfo[]
    /// Type check failed
    | CheckFailed of path: string
    
  /// Parse source code and apply filter
  // TODO: Multiple filter support
  let parseSourceCodeAndApplyByAsync options filter sourceCode = async {
    // Read source code body
    let! body = sourceCode.AsyncReadBody()
    // Parse
    let checker = FSharpChecker.Create()
    let! parseResult = checker.ParseFileInProject(sourceCode.Path, body, options)
    match parseResult.ParseTree with
    | Some ast ->
      // Type check
      let! checkAnswer = checker.CheckFileInProject(parseResult, sourceCode.Path, 1, body, options)
      match checkAnswer with
      | FSharpCheckFileAnswer.Succeeded(checkAnswer) ->
        // Apply filter
        let filteredAst = filter checkAnswer ast
        return Succeeded (sourceCode.Path, filteredAst)
      | FSharpCheckFileAnswer.Aborted ->
        return CheckFailed sourceCode.Path
    | None ->
      return ParseFailed (sourceCode.Path, parseResult.Errors)
  }

  ///////////////////////////////////////////////////////
 
  /// Compile by FSharp.Compiler.Service
  let compileByFcs assemblyName outputPath dependencies pdbPath appliedAsts =
    let simpleService = SimpleSourceCodeServices()
    simpleService.Compile(
      appliedAsts |> Seq.toList,
      assemblyName,
      outputPath,
      dependencies |> Seq.toList,
      pdbPath,
      false,
      true)

  ///////////////////////////////////////////////////////
 
  /// Apply filter with visitors
  let astFilter
     (visitors: IAstVisitor<FSharpCheckFileResults> seq)
     (context: FSharpCheckFileResults)
     (ast: ParsedInput) =
    visitors |> Seq.fold (fun partialAst visitor -> visitor.VisitInput context partialAst) ast
 
  ///////////////////////////////////////////////////////

  let private simpleTypeName (visitor: IAstVisitor<FSharpCheckFileResults>) =
    let t = visitor.GetType()
    let name = t.FullName
    let index = name.IndexOf '`'
    System.String.Format
      ("{0} [{1}]",
       (if index >= 0 then name.Substring(0, index) else name),
       t.Assembly.GetName().Name)

  let private printVisitor (visitor: IAstVisitor<FSharpCheckFileResults>) =
    System.String.Format("Apply visitor: {0}", simpleTypeName visitor)

  /// Read text file and iterate.
  let private readText path = seq {
    use tr = File.OpenText path
    let mutable line:string = ""
    while line <> null do
      line <- tr.ReadLine()
      if line <> null then
        yield line
  }

  /// Target file contains "TargetFrameworkAttribute" definition.
  let private isTargetFrameworkDefinedFile (path: string) =
    if path.EndsWith ".AssemblyAttributes.fs" then
      readText path
      |> Seq.exists (fun line -> line.Contains "TargetFrameworkAttribute(")
    else
      false

  [<DllImport("user32.dll", SetLastError=true, CharSet=CharSet.Unicode)>]
  extern int private MessageBoxW(IntPtr, System.String, System.String, int)

  /// <summary>
  /// Execute compiler.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="arguments">Compiler arguments</param>
  /// <param name="visitors">AST visitors</param>
  /// <returns>Compile result value</returns>
  let asyncCompile
     (writer: WriteInfo -> unit)
     (arguments: CompilerArguments)
     (visitors: IAstVisitor<FSharpCheckFileResults> seq) = async {
    try
      // Debugger hook point
      if arguments.FscxDebug then
        MessageBoxW
          (IntPtr.Zero,
           "Fscx: Waiting for attach debugger...",
           System.String.Format("Fscx: {0}", Process.GetCurrentProcess().Id),
           0x30) |> ignore

      // TODO: HACK
      //  If source code contains definition "TargetFrameworkAttribute", FCS failed compile.
      //  May be auto-generated framework versions by MSBuild targets (GenerateTargetFrameworkMonikerAttribute),
      //  so exclude source file from SourcePaths.
      let sourcePaths =
        arguments.SourcePaths
        |> Seq.filter (fun path -> not (isTargetFrameworkDefinedFile path))
        |> Seq.toArray

      // Create compilation options
      let options = createOptions arguments.ProjectPath arguments.OptionArguments sourcePaths 

      // Create source code descriptions
      let sourceCodes = createSourceCodeDescriptions sourcePaths

      // Print visitors
      if Seq.isEmpty visitors then
        writer (WriteInfo.Message(EventLogEntryType.Warning, arguments.ProjectPath, "No applicable visitors."))
      else
        visitors
        |> Seq.map printVisitor
        |> Seq.iter (fun message -> writer (WriteInfo.Message(EventLogEntryType.Information, arguments.ProjectPath, message)))

      // Parse source codes and apply (Async)
      let! appliedResults =
        sourceCodes
        |> Seq.map (parseSourceCodeAndApplyByAsync options (astFilter visitors))
        |> Async.Parallel

      // Aggregate aborted results
      let abortedResults =
        appliedResults
        |> Seq.filter (function
          | Succeeded _ -> false
          | _ -> true)
        |> Seq.toArray

      // If successful all source codes
      if Seq.isEmpty abortedResults then
        // Aggregate all ASTs
        let appliedAsts =
          appliedResults
          |> Seq.choose (function
            | Succeeded(_, appliedAst) -> Some appliedAst
            | _ -> None)

        // Compile
        let errors, returnValue =
          compileByFcs
            arguments.AssemblyName
            arguments.OutputPath
            arguments.Dependencies
            arguments.PdbPath
            appliedAsts

        // Try output errors
        errors |> Seq.iter (fun error -> writer (WriteInfo.ParseFailed error))
        return returnValue

      // Contained failed
      else
        for result in abortedResults do
          match result with
          | ParseAndApplyResult.ParseFailed(_, errors) ->
            errors |> Seq.iter (fun error -> writer (WriteInfo.ParseFailed error))
          | ParseAndApplyResult.CheckFailed(path) ->
            writer (WriteInfo.CheckFailed path)
          | _ -> new NotImplementedException() |> raise
        return 1
    with
    | _ as ex ->
      writer (WriteInfo.UnknownFailed(arguments.ProjectPath, ex))
      return Marshal.GetHRForException ex
  }
