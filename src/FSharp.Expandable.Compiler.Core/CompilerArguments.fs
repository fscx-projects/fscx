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
