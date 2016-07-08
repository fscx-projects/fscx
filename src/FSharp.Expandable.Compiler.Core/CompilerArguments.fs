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

/// <summary>
/// Compiler arguments.
/// </summary>
type CompilerArguments = {
  ProjectPath : string
  OutputPath : string
  AssemblyName : string
  PdbPath : string
  Dependencies : string seq
  SourcePaths : string seq
  OptionArguments : string seq
}

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module internal CompilerArguments =

  let private extractOptionValues switch (args: string seq) =
    args
    |> Seq.filter (fun arg -> arg.StartsWith switch)
    |> Seq.map (fun arg -> arg.Substring (switch.Length))

  let private extractOptionValue switch args =
    args
    |> extractOptionValues switch
    |> Seq.head

  let private extractOptionPath switch args =
    args
    |> extractOptionValue switch
    |> Path.GetFullPath

  /// <summary>
  /// Extract compiler arguments.
  /// </summary>
  /// <param name="args">Arguments</param>
  /// <returns>CompilerArguments</returns>
  let extract (args: string seq) =
    let sanitized =
      args
      |> Seq.map (fun arg -> arg.Trim())
      |> Seq.toArray

    let sourcePaths =
      sanitized
      |> Seq.map (fun arg -> arg.Trim())
      |> Seq.filter (fun arg -> not (arg.StartsWith "-"))
      |> Seq.map (fun arg -> Path.GetFullPath arg)
      |> Seq.toArray
    let optionArguments =
      sanitized
      |> Seq.map (fun arg -> arg.Trim())
      |> Seq.filter (fun arg -> (arg.StartsWith "-") && not (arg.StartsWith "--projectPath:"))
      |> Seq.toArray

    let projectPath =
      extractOptionPath "--projectPath:" sanitized
    let outputPath =
      extractOptionPath "-o:" sanitized
    let assemblyName =
      Path.GetFileNameWithoutExtension outputPath
    let pdbPath =
      Path.Combine(Path.GetDirectoryName outputPath, assemblyName + ".pdb")
    let dependencies =
      extractOptionValues "-r:" sanitized
      |> Seq.toArray

    {
      ProjectPath = projectPath
      OutputPath = outputPath
      AssemblyName = assemblyName
      PdbPath = pdbPath
      Dependencies = dependencies
      SourcePaths = sourcePaths
      OptionArguments = optionArguments
    }
