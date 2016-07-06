namespace FSharp.Expandable

open System
open System.Diagnostics
open System.IO

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SimpleSourceCodeServices
open Microsoft.FSharp.Compiler.SourceCodeServices

module private CompilerImpl =
  open Microsoft.FSharp.Compiler

  let extractOptionValues switch (argv: string seq) =
    argv
    |> Seq.filter (fun arg -> arg.StartsWith switch)
    |> Seq.map (fun arg -> arg.Substring (switch.Length))

  let extractOptionValue switch argv =
    argv
    |> extractOptionValues switch
    |> Seq.head

  let extractOptionPath switch argv =
    argv
    |> extractOptionValue switch
    |> Path.GetFullPath

  let createOptions projectPath optionArgs sourcePaths =
    let optionWithSource = seq {
      yield! optionArgs
      yield! sourcePaths
    }

    let checker = FSharpChecker.Create()
    checker.GetProjectOptionsFromCommandLineArgs(
      projectPath,
      optionWithSource |> Seq.toArray)

  type SourceCodeDescription = {
    Path: string
    AsyncReadBody: unit -> Async<string>
  }

  let createSourceCodes sourcePaths =
    sourcePaths
    |> Seq.map (fun path -> { Path = path; AsyncReadBody = (fun _ -> async {
      // TODO: Asynchronously
      return File.ReadAllText path
    })})

  type ParseAndApplyResult =
  | Succeeded of path: string * ast: ParsedInput
  | ParseFailed of path: string * errors: FSharpErrorInfo seq
  | CheckFailed of path: string

  /// Parse source codes and apply filter.
  let parseSourceCodesAndApplyByAsync options filter sourceCodes =
    sourceCodes
    |> Seq.map (fun code -> async {
      let! body = code.AsyncReadBody()
      let checker = FSharpChecker.Create()
      let! parseResult = checker.ParseFileInProject(code.Path, body, options)
      match parseResult.ParseTree with
      | Some ast ->
        let! checkAnswer = checker.CheckFileInProject(parseResult, code.Path, 1, body, options)
        match checkAnswer with
        | FSharpCheckFileAnswer.Succeeded(checkAnswer) ->
          let filteredAst = filter ast checkAnswer
          return Succeeded (code.Path, filteredAst)
        | FSharpCheckFileAnswer.Aborted ->
          return CheckFailed code.Path
      | None ->
        return ParseFailed (code.Path, parseResult.Errors)
    })

module Compiler =

  let public asyncCompile (argv: string seq) = async {

    let sourcePaths =
      argv
      |> Seq.filter (fun arg -> not (arg.StartsWith "-"))
      |> Seq.map (fun arg -> Path.GetFullPath arg)
      |> Seq.toArray
    let optionArgs =
      argv
      |> Seq.filter (fun arg -> (arg.StartsWith "-") && not (arg.StartsWith "--projectPath:"))
      |> Seq.toArray

    let projectPath =
      CompilerImpl.extractOptionPath "--projectPath:" argv
    let outputPath =
      CompilerImpl.extractOptionPath "-o:" argv
    let assemblyName =
      Path.GetFileNameWithoutExtension outputPath
    let pdbPath =
      Path.Combine(Path.GetDirectoryName outputPath, assemblyName + ".pdb")
    let dependencies =
      CompilerImpl.extractOptionValues "-r:" argv
      |> Seq.toList

    let options =
      CompilerImpl.createOptions projectPath optionArgs sourcePaths

    //////////////////////////////////////

    Debug.WriteLine("FSharp.Expandable.Compiler ----------------------")
    argv |> Seq.iter (fun arg -> Debug.WriteLine(sprintf "Argument: %A" arg))

    // Create source code descriptions
    let sourceCodes =
      CompilerImpl.createSourceCodes sourcePaths

    // Parse source codes and apply
    let! appliedResults =
      CompilerImpl.parseSourceCodesAndApplyByAsync options Filter.apply sourceCodes
      |> Async.Parallel

    let abortedResults =
      appliedResults
      |> Seq.filter (function
        | CompilerImpl.ParseAndApplyResult.Succeeded _ -> false
        | _ -> true)
      |> Seq.toArray

    if Seq.isEmpty abortedResults then
      let appliedList =
        appliedResults
        |> Seq.choose (function
          | CompilerImpl.ParseAndApplyResult.Succeeded(_, appliedAst) -> Some appliedAst
          | _ -> None)
        |> Seq.toList

      let simpleService = SimpleSourceCodeServices()
      let errors, returnValue =
        simpleService.Compile(
          appliedList,
          assemblyName,
          outputPath,
          dependencies,
          pdbPath,
          false,
          true)

      for error in errors do
        match error.Severity with
        | FSharpErrorSeverity.Warning -> 
          printfn "%s" (error.ToString())
        | FSharpErrorSeverity.Error -> 
          printfn "%s" (error.ToString())

      return returnValue

    else
      for result in abortedResults do
        match result with
        | CompilerImpl.ParseAndApplyResult.ParseFailed(_, errors) ->
          printfn "%s" (System.String.Join(",", errors |> Seq.map (fun ei -> ei)))
        | CompilerImpl.ParseAndApplyResult.CheckFailed(_) ->
          printfn "%s" (result.ToString())
        | _ -> new NotImplementedException() |> raise
      return 1
  }

  let public compile argv =
    let result = asyncCompile argv |> Async.Catch |> Async.RunSynchronously
    match result with
    | Choice1Of2 returnValue -> returnValue
    | Choice2Of2 ex ->
      printf "%A" ex
      System.Runtime.InteropServices.Marshal.GetHRForException ex
