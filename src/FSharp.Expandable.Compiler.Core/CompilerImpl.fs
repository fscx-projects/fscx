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

type WriteInfo =
| ParseFailed of FSharpErrorInfo
| CheckFailed of string
| UnknownFailed of exn

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
        let filteredAst = filter ast checkAnswer
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
  
  /// <summary>
  /// Execute compiler.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="arguments">Compiler arguments</param>
  /// <returns>Compile result value</returns>
  let asyncCompile (writer: WriteInfo -> unit) (arguments: CompilerArguments) = async {
    try
      // Debugger hook point
      if arguments.FscxDebug then
        Trace.Assert(false, "Fscx: Waiting for attach debugger...")
  
      // Create compilation options
      let options = createOptions arguments.ProjectPath arguments.OptionArguments arguments.SourcePaths 

      // Create source code descriptions
      let sourceCodes = createSourceCodeDescriptions arguments.SourcePaths

      // Parse source codes and apply (Async)
      let! appliedResults =
        sourceCodes
        |> Seq.map (parseSourceCodeAndApplyByAsync options Filter.apply)
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
      writer (WriteInfo.UnknownFailed ex)
      return Marshal.GetHRForException ex
  }
