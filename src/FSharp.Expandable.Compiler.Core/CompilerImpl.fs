namespace FSharp.Expandable

open System
open System.Diagnostics
open System.IO

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SimpleSourceCodeServices
open Microsoft.FSharp.Compiler.SourceCodeServices

module internal CompilerImpl =

  ///////////////////////////////////////////////////////

  /// Read entire text file
  let asyncReadTextFile sourcePath = async {
    use fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, true)
    let sr = new StreamReader(fs, true)
    return! sr.ReadToEndAsync() |> Async.AwaitTask
  }

  /// Source code description
  type private SourceCodeDescription = {
    /// Source code location
    Path: string
    /// Source code reader
    AsyncReadBody: unit -> Async<string>
  }

  /// Create SourceCodeDescriptions
  let private createSourceCodeDescriptions sourcePaths =
    sourcePaths
    |> Seq.map (fun path -> { Path = path; AsyncReadBody = (fun _ -> asyncReadTextFile path) })

  /// Result for parse and apply
  type private ParseAndApplyResult =
    /// Success
    | Succeeded of path: string * ast: ParsedInput
    /// Parse failed
    | ParseFailed of path: string * errors: FSharpErrorInfo seq
    /// Type check failed
    | CheckFailed of path: string

  /// Parse source codes and apply filter
  // TODO: Multiple filter support
  let private parseSourceCodesAndApplyByAsync options filter sourceCodes =
    sourceCodes
    |> Seq.map (fun code -> async {
      // Read source code body
      let! body = code.AsyncReadBody()
      // Parse
      let checker = FSharpChecker.Create()
      let! parseResult = checker.ParseFileInProject(code.Path, body, options)
      match parseResult.ParseTree with
      | Some ast ->
        // Type check
        let! checkAnswer = checker.CheckFileInProject(parseResult, code.Path, 1, body, options)
        match checkAnswer with
        | FSharpCheckFileAnswer.Succeeded(checkAnswer) ->
          // Apply filter
          let filteredAst = filter ast checkAnswer
          return Succeeded (code.Path, filteredAst)
        | FSharpCheckFileAnswer.Aborted ->
          return CheckFailed code.Path
      | None ->
        return ParseFailed (code.Path, parseResult.Errors)
    })

  ///////////////////////////////////////////////////////

  /// Create compilation options
  let private createOptions projectPath optionArgs sourcePaths =
    let optionWithSource = seq {
      yield! optionArgs
      yield! sourcePaths
    }

    let checker = FSharpChecker.Create()
    checker.GetProjectOptionsFromCommandLineArgs(
      projectPath,
      optionWithSource |> Seq.toArray)

  ///////////////////////////////////////////////////////

  /// <summary>
  /// Execute compiler.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compiler arguments</param>
  /// <returns>Compile result value</returns>
  let asyncCompile (tw: TextWriter) arguments = async {
  
    // Create compilation options
    let options = createOptions arguments.ProjectPath arguments.OptionArguments arguments.SourcePaths 

    // Create source code descriptions
    let sourceCodes = createSourceCodeDescriptions arguments.SourcePaths

    // Parse source codes and apply (Async)
    let! appliedResults =
      parseSourceCodesAndApplyByAsync options Filter.apply sourceCodes
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
      // Aggregate all AST
      let appliedList =
        appliedResults
        |> Seq.choose (function
          | Succeeded(_, appliedAst) -> Some appliedAst
          | _ -> None)
        |> Seq.toList

      // Compile
      let simpleService = SimpleSourceCodeServices()
      let errors, returnValue =
        simpleService.Compile(
          appliedList,
          arguments.AssemblyName,
          arguments.OutputPath,
          arguments.Dependencies |> Seq.toList,
          arguments.PdbPath,
          false,
          true)

      // Try output errors
      for error in errors do
        tw.WriteLine("{0}", error)

      return returnValue

    // Contained failed
    else
      for result in abortedResults do
        match result with
        | ParseAndApplyResult.ParseFailed(_, errors) ->
          tw.WriteLine("{0}", (System.String.Join(",", errors)))
        | ParseAndApplyResult.CheckFailed(_) ->
          tw.WriteLine("{0}", (result.ToString()))
        | _ -> new NotImplementedException() |> raise

      return 1
  }
