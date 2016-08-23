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
open System.Linq
open System.IO

open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

open Persimmon
open Persimmon.Assertions
open UseTestNameByReflection

open FSharp.Expandable

module CompilerImplTests =
  open System.Reflection

  ////////////////////////////////////////////////////////

  let ``can read using asyncReadTextFile`` = test {
    let expected =
      System.String.Join("", Enumerable.Range(0, 100) |> Seq.map (fun _ -> Guid.NewGuid().ToString("N")))

    let asyncTest = async {
      let tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"))
      try
        File.WriteAllText(tempFilePath, expected)

        // Execute target function
        return! CompilerImpl.asyncReadTextFile tempFilePath

      finally
        File.Delete tempFilePath
    }

    let! actual = asyncRun { it asyncTest }
    do! assertEquals expected actual
  }

  ////////////////////////////////////////////////////////

  let ``create valid source code descriptions`` = test {
    let tempFilePaths =
      Enumerable.Range(0, 10)
      |> Seq.map (fun _ -> Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N")))
      |> Seq.toArray

    // Execute target function
    let actual = CompilerImpl.createSourceCodeDescriptions tempFilePaths

    // assert path equality
    let actualPaths = actual |> Seq.map (fun desc -> desc.Path) |> Seq.toArray
    do! assertEquals tempFilePaths actualPaths

    // assert valid reader
    let createContent() =
      System.String.Join("", Enumerable.Range(0, 100) |> Seq.map (fun _ -> Guid.NewGuid().ToString("N")))
    let entries =
      tempFilePaths
      |> Seq.map (fun path -> (path, createContent()))
      |> Seq.toArray

    do entries
      |> Seq.iter (fun (path, content) -> File.WriteAllText(path, content))
    try
      let readBodies =
        actual
        |> Seq.map (fun desc -> desc.AsyncReadBody() |> Async.RunSynchronously)
        |> Seq.toArray
      do! assertEquals (entries |> Seq.map (fun (_, content) -> content) |> Seq.toArray) readBodies

    finally
      do tempFilePaths
        |> Seq.iter (fun path -> File.Delete path)
  }

  ////////////////////////////////////////////////////////

  let private createOptionArgs outputPath = 
    let outputArg = "-o:" + outputPath
    [| outputArg;
      "-g";
      "--debug:full";
      "--noframework";
      "--define:DEBUG";
      "--define:TRACE";
      "--optimize-";
      "--tailcalls-";
      "--platform:anycpu32bitpreferred";
      @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll";
      @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll";
      @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll";
      @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll";
      @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll";
      "--target:library";
      "--warn:3";
      "--warnaserror:76";
      "--vserrors";
      "--LCID:1041";
      "--utf8output";
      "--fullpaths";
      "--flaterrors";
      "--subsystemversion:6.00";
      "--highentropyva+" |]

  let ``create valid options`` = test {

    let projectPath = "C:\\PROJECT\\Test\\Test.fsproj"
    let sourcePaths =
      [| "C:\\PROJECT\\Test\\Test1.fs";
         "C:\\PROJECT\\Test\\Test2.fs" |]
    let optionArgs = createOptionArgs "output.dll"

    // Execute target function
    let actual = 
      CompilerImpl.createOptions projectPath optionArgs sourcePaths
        
    do! assertEquals projectPath actual.ProjectFileName
    do! assertEquals (Seq.append optionArgs sourcePaths |> Seq.toArray) actual.OtherOptions
  }

  ////////////////////////////////////////////////////////

  let private invokeParseAndApply projectPath outputPath sourceCodeBody filter = async {

    let projectFolderPath = Path.GetDirectoryName projectPath
    let sourcePath = Path.Combine(projectFolderPath, Guid.NewGuid().ToString("N") + ".fs")
    let optionArgs = createOptionArgs outputPath

    File.WriteAllText(sourcePath, sourceCodeBody)
    try
      let sourceCode = CompilerImpl.createSourceCodeDescriptions [sourcePath] |> Seq.head
      let options = CompilerImpl.createOptions projectPath optionArgs [sourcePath]

      // setup ast verifier
      let inputAstHolder = new ResizeArray<_>()
      let filter (results: FSharpCheckFileResults) (inputAst: ParsedInput) : ParsedInput =
        inputAstHolder.Add(inputAst)
        filter inputAst results

      // Execute target function
      let! result = CompilerImpl.parseSourceCodeAndApplyByAsync options filter sourceCode
      return result, inputAstHolder.ToArray()

    finally
      do File.Delete sourcePath
  }

  let astToString ast =
    let t = ast.GetType()
    let mi = t.GetMethod("__DebugDisplay", BindingFlags.NonPublic ||| BindingFlags.Instance)
    match mi with
    | null -> ast.ToString()
    | _ ->
      if mi.GetParameters().Length >= 1 then ast.ToString()
      else mi.Invoke(ast, [||]) :?> string

  let ``parse and apply single source code`` = test {
  
    let projectPath = Path.GetTempPath() + "test.fsproj"
    let outputPath = "output.dll"
    let sourceCodeBody =
      "module FscxOutputSample1\r\n" +
      "  let f1 (a: int, b: string, c: int) =\r\n" +
      "    System.Console.WriteLine(\"Sample1: {0}:{1}\", a, b)\r\n"

    let filter inputAst results =
      inputAst  // TODO: verify ast

    // Execute target function
    let result, asts =
      invokeParseAndApply
        projectPath
        outputPath
        sourceCodeBody
        filter
      |> Async.RunSynchronously

    match result, asts with
    | CompilerImpl.ParseAndApplyResult.Succeeded(_, ast), [|inputAst|] ->
      let inputAstString = astToString inputAst
      let astString = astToString ast
      do! assertEquals inputAstString astString
    | _ ->
      do! fail "actual or inputAst is not valid"
  }
