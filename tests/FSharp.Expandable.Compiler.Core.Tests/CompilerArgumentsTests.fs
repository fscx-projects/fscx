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

open Persimmon
open Persimmon.Assertions
open UseTestNameByReflection

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

  let ``parse argument strings`` = test {
    let result = CompilerArguments.extract args
    do! assertEquals (Path.GetFullPath "Sample.fsproj") result.ProjectPath
    do! assertEquals (Path.GetFullPath "output.dll") result.OutputPath
    do! assertEquals (Path.GetFullPath "output.pdb") result.PdbPath
    do! assertEquals "output" result.AssemblyName
    do! assertEquals dependencies (result.Dependencies |> Seq.toArray)
    do! assertEquals false result.FscxDebug
    do! assertEquals [||] (result.VisitorPaths |> Seq.toArray)

    let expectedSourcePaths =
      [|Path.GetFullPath "TestFSharpSampleCode1.fs"; Path.GetFullPath "TestFSharpSampleCode2.fs"|]
    do! assertEquals expectedSourcePaths (result.SourcePaths |> Seq.toArray)
  }

  let ``parse fscxDebug true argument`` = test {
    let result = CompilerArguments.extract (Seq.append args [| "--fscxDebug:true" |])
    do! assertEquals true result.FscxDebug
  }

  let ``parse fscxDebug false argument`` = test {
    let result = CompilerArguments.extract (Seq.append args [| "--fscxDebug:false" |])
    do! assertEquals false result.FscxDebug
  }

  let ``parse visitorPath arguments`` = test {
    let visitorPathArgs = [| "--visitorPath:visitor1.dll"; "--visitorPath:visitor2.dll" |]
    let visitorPaths = [| Path.GetFullPath "visitor1.dll"; Path.GetFullPath "visitor2.dll" |]
    let result =
      CompilerArguments.extract (Seq.append args visitorPathArgs)
    do! assertEquals visitorPaths (result.VisitorPaths |> Seq.toArray)
  }
