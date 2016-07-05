namespace FSharp.Expandable

open Microsoft.FSharp.Compiler.SimpleSourceCodeServices
open Microsoft.FSharp.Compiler.SourceCodeServices

// TODO: extract from argv
//let dependencies =
//  [ @"C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll"
//    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll"
//    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll"
//    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll"
//    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll" ]

module Compiler =

  let public asyncCompile argv = async {
    let checker = FSharpChecker.Create()
    let simpleService = SimpleSourceCodeServices()

    let sessionId = System.Guid.NewGuid().ToString("N")

    let fixFilter (arg: string) =
      if not (arg.StartsWith "-") then
        System.IO.Path.GetFullPath arg
      else
        arg

    let fixedArgv = argv |> Seq.map fixFilter |> Seq.toArray

    // TODO:Multiple sources
    let rawSourcePath = argv |> Seq.filter (fun arg -> (not (arg.StartsWith "-")) && (arg.EndsWith ".fs")) |> Seq.head
    let sourcePath = System.IO.Path.GetFullPath rawSourcePath
    //let sourcePath = System.IO.Path.GetFullPath(fixedArgv.[0])
    let text = System.IO.File.ReadAllText(sourcePath, System.Text.Encoding.UTF8)

    let projectFolderPath = System.IO.Path.GetDirectoryName sourcePath
    let projectPath = System.IO.Path.Combine(projectFolderPath, sessionId + ".proj")
    let outputPath = System.IO.Path.GetFullPath(fixedArgv |> Seq.filter (fun arg -> arg.StartsWith "-o:") |> Seq.map (fun arg -> arg.Substring 3) |> Seq.head)
    let assemblyName = System.IO.Path.GetFileNameWithoutExtension outputPath
    let pdbPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName outputPath, assemblyName + ".pdb")

    let dependencies = fixedArgv |> Seq.filter (fun arg -> arg.StartsWith "-r:") |> Seq.map (fun arg -> arg.Substring 3) |> Seq.toList
    let optionArgs = fixedArgv |> Seq.filter (fun arg -> arg.StartsWith "-") |> Seq.toArray

    printfn "fcs.exe ---------------------------"
    fixedArgv |> Seq.iter (fun arg -> printfn "Argument: %A" arg)

    let options =
      let optionWithSource = seq {
        yield! optionArgs
        yield sourcePath
      }

      checker.GetProjectOptionsFromCommandLineArgs(
        projectPath,
        optionWithSource |> Seq.toArray)
  //      [| "-o:output.dll"
  //         "-g"
  //         "--debug:full"
  //         "--noframework"
  //         "--define:DEBUG"
  //         "--define:TRACE"
  //         "--optimize-"
  //         "--tailcalls-"
  //         "--platform:anycpu32bitpreferred"
  //         @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll"
  //         @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll"
  //         @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll"
  //         @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll"
  //         @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll"
  //         "--target:library"
  //         "--warn:3"
  //         "--warnaserror:76"
  //         "--vserrors"
  //         "--LCID:1041"
  //         "--utf8output"
  //         "--fullpaths"
  //         "--flaterrors"
  //         "--subsystemversion:6.00"
  //         "--highentropyva+"
  //         src |])

    let! parseResult = checker.ParseFileInProject(sourcePath, text, options)

    match parseResult.ParseTree with
    | Some ast ->
      let! checkAnswer = checker.CheckFileInProject(parseResult, sourcePath, 1, text, options)
      match checkAnswer with
      | FSharpCheckFileAnswer.Succeeded(checkAnswer) ->
        let converted = Filter.apply (ast, checkAnswer)
        //let converted = ast
        let errs, res =
          simpleService.Compile(
            [converted],
            assemblyName,
            outputPath,
            dependencies,
            pdbPath,
            false,
            true)
        for e in errs do
          if e.Severity = Microsoft.FSharp.Compiler.FSharpErrorSeverity.Error then
            printfn "%s" (e.ToString())
        return res
      | FSharpCheckFileAnswer.Aborted ->
        return 1
    | _ ->
      for e in parseResult.Errors do
        printfn "%s" (e.ToString())
      return 1
  }

  let public compile argv =
    let result = asyncCompile argv |> Async.Catch |> Async.RunSynchronously
    match result with
    | Choice1Of2 returnValue -> returnValue
    | Choice2Of2 ex ->
      printf "%A" ex
      System.Runtime.InteropServices.Marshal.GetHRForException ex
