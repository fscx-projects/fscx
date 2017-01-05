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

open System
open System.IO
open FSharp.Expandable

module Program =

  let dump entry =
    Console.WriteLine(entry.ToString())

  /// <summary>
  /// Minimal manually compile sample code for fscx.
  /// </summary>
  /// <remarks>
  /// This code fragments are how to manually compile by using fscx for tests.
  /// We are usually not using it, because fscx uses by MSBuild infrastructure normally.
  /// (fscx load for assemblies from NuGet packages (in VS solution's packages folder.)
  /// </remarks>
  [<EntryPoint>]
  let main _ =

    // Step1: Construct CompilerArguments by internal function.
    //   --> CompilerArguments is public class, so we can use constructor instead this function.
    let args =
      CompilerHelper.UnsafeGetPreDefinedDefaultArguments
        TargetRuntimes.Loaded
        []  // Visitor paths is empty (not use): Apply visitors manually, see below.
        (["SampleAspectLogger.fs"; "SampleCode.fs"] |> List.map Path.GetFullPath)

    // Step2: Set fscx filter arguments.
    //   --> Usually, filter arguments receives from MSBuild (in fsproj's properties.)
    args.FilterArguments <-
      [("FSharp.Expandable.Compiler.Aspect",[|"SampleCode"|])]    // Regex'd assembly name
      |> Map.ofList

    // Step3: Construct visitor declaration.
    //   --> Usually, visitor declarates statically in filter assemblies (NuGet) and aggregates by fscx.
    let declAspectVisitor =
      DeclareFscxInjectAspectVisitor("SampleAspectLogger.SampleAspect")

    // Step4: Execute fscx compiler.
    CompilerHelper.RawCompileWithArguments
      (new Action<_>(dump))
      args
      ([declAspectVisitor] |> Seq.cast<_>)
