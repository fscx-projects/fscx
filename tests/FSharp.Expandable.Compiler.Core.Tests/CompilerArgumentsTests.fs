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

open System.IO
open NUnit.Framework
open FSharp.Expandable

module CompilerArgumentsTests =

  ////////////////////////////////////////////////////////

  let dependencies =
      [| @"C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll";
        @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll";
        @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll";
        @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll";
        @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll" |]

  let options =
      [| "-o:output.dll";
        "-g";
        "--debug:full";
        "--noframework";
        "--define:DEBUG";
        "--define:TRACE";
        "--optimize-";
        "--tailcalls-";
        "--platform:anycpu32bitpreferred";
        "--target:library";
        "--warn:3";
        "--warnaserror:76";
        "--vserrors";
        "--LCID:1041";
        "--utf8output";
        "--fullpaths";
        "--flaterrors";
        "--subsystemversion:6.00";
        "--highentropyva+"; |]

  let args =
      (dependencies |> Seq.map (fun d -> "-r:" + d))
      |> Seq.append options
      |> Seq.append [| "--projectPath:Sample.fsproj" |]
      |> Seq.append [| "TestFSharpSampleCode1.fs"; "TestFSharpSampleCode2.fs" |]
      |> Seq.toArray

  [<Test>]
  let ``parse argument strings``() =
    let result = CompilerArguments.extract args
    Assert.AreEqual(Path.GetFullPath("Sample.fsproj"), result.ProjectPath)
    Assert.AreEqual(Path.GetFullPath("output.dll"), result.OutputPath)
    Assert.AreEqual(Path.GetFullPath("output.pdb"), result.PdbPath)
    Assert.AreEqual("output", result.AssemblyName)
    Assert.AreEqual(dependencies, result.Dependencies |> Seq.toArray)
    Assert.IsFalse(result.FscxDebug)
    Assert.IsEmpty(result.VisitorPaths)

    let expectedSourcePaths =
      [|Path.GetFullPath "TestFSharpSampleCode1.fs"; Path.GetFullPath "TestFSharpSampleCode2.fs"|]
    Assert.AreEqual(expectedSourcePaths, result.SourcePaths |> Seq.toArray)

  [<Test>]
  let ``parse fscxDebug true argument``() =
    let result = CompilerArguments.extract (Seq.append args [| "--fscxDebug:true" |])
    Assert.IsTrue(result.FscxDebug)

  [<Test>]
  let ``parse fscxDebug false argument``() =
    let result = CompilerArguments.extract (Seq.append args [| "--fscxDebug:false" |])
    Assert.IsFalse(result.FscxDebug)

  [<Test>]
  let ``parse visitorPath arguments``() =
    let visitorPathArgs = [| "--visitorPath:visitor1.dll"; "--visitorPath:visitor2.dll" |]
    let visitorPaths = [| Path.GetFullPath "visitor1.dll"; Path.GetFullPath "visitor2.dll" |]
    let result =
      CompilerArguments.extract (Seq.append args visitorPathArgs)
    Assert.AreEqual(visitorPaths, result.VisitorPaths |> Seq.toArray)
