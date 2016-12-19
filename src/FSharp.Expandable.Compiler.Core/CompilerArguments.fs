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
type CompilerArguments
  (projectPath,
   outputPath,
   assemblyName,
   pdbPath,
   dependencies,
   sourcePaths,
   optionArguments,
   visitorPaths,
   fscxDebug,
   filterArguments) =
  member val ProjectPath : string = projectPath with get, set
  member val OutputPath : string = outputPath with get, set
  member val AssemblyName : string = assemblyName with get, set
  member val PdbPath : string = pdbPath with get, set
  member val Dependencies : string seq = dependencies with get, set
  member val SourcePaths : string seq = sourcePaths with get, set
  member val OptionArguments : string seq = optionArguments with get, set
  member val VisitorPaths : string seq = visitorPaths with get, set
  member val FscxDebug : bool = fscxDebug with get, set
  member val FilterArguments : Map<string, string> = filterArguments with get, set

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module internal CompilerArguments =

  let private extractOptionValues switch (args: string seq) =
    args
    |> Seq.filter (fun arg -> arg.StartsWith switch)
    |> Seq.map (fun arg -> arg.Substring (switch.Length))

  let private extractOptionValue switch args =
    args
    |> extractOptionValues switch
    |> Seq.tryHead

  let private extractOptionPath switch args =
    args
    |> extractOptionValue switch
    |> Option.map Path.GetFullPath

  let private splitOption (arg: string) =
    let index = arg.IndexOf('=')
    if index >= 0 then
      arg.Substring(0, index).Trim(), arg.Substring(index + 1).Trim()
    else
      arg.Trim(), ""

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
      |> Seq.filter (fun arg ->
        (arg.StartsWith "-") &&
         not (arg.StartsWith "--projectPath:") &&
         not (arg.StartsWith "--visitorPath:") &&
         not (arg.StartsWith "--fscxDebug:") &&
         not (arg.StartsWith "--filterArgument:"))
      |> Seq.toArray

    let projectPath =
      match extractOptionPath "--projectPath:" sanitized with
      | Some path -> path
      | None ->
        let firstSourcePath = sourcePaths |> Seq.head
        Path.Combine(Path.GetDirectoryName firstSourcePath, Path.GetFileNameWithoutExtension firstSourcePath) + ".fsproj"
    let outputPath =
      match extractOptionPath "-o:" sanitized with
      | Some path -> path
      | None -> failwith "Require output path."
    let assemblyName =
      Path.GetFileNameWithoutExtension outputPath
    let pdbPath =
      Path.Combine(Path.GetDirectoryName outputPath, assemblyName + ".pdb")
    let dependencies =
      extractOptionValues "-r:" sanitized
      |> Seq.toArray
    let visitorPaths =
      extractOptionValues "--visitorPath:" sanitized
      |> Seq.map Path.GetFullPath
      |> Seq.toArray
    let _, fscxDebug =
      match extractOptionValue "--fscxDebug:" sanitized with
      | Some path -> bool.TryParse path
      | None -> false, false
      
    let filterArguments =
      extractOptionValues "--filterArgument:" sanitized
      |> Seq.map splitOption
      |> Map.ofSeq

    new CompilerArguments
      (projectPath,
       outputPath,
       assemblyName,
       pdbPath,
       dependencies,
       sourcePaths,
       optionArguments,
       visitorPaths,
       fscxDebug,
       filterArguments)
