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
open System.Diagnostics
open System.Runtime.CompilerServices

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

/// <summary>
/// Compiler logger information.
/// </summary>
type CompilerLogEntry = {
  Type: EventLogEntryType
  FileName: string
  Line: int
  Column: int
  Code: string
  Message: string
  Description: string
}

/// <summary>
/// Execute F# compiler.
/// </summary>
[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false); Extension>]
type Compiler =

  /////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Extract compiler arguments from string sequence.
  /// </summary>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Compilation arguments</returns>
  [<Extension>]
  static member ExtractCompilerArguments args =
    CompilerArguments.extract args

  /////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Filter visitor class expression.
  /// </summary>
  /// <param name="paths">Assembly paths</param>
  /// <returns>Assembly paths of contains visitors</returns>
  [<Extension>]
  static member FilterVisitors (paths: string seq) =
    use r = new SafeResolver()
    paths
    |> Seq.filter AssemblyLoader.isTargetAssemblyName
    |> Seq.choose AssemblyLoader.reflectionOnlyLoadFrom
    |> Seq.filter AssemblyLoader.isTargetAssembly
    |> Seq.choose (fun roa -> AssemblyLoader.loadFrom (AssemblyLoader.rawLocation roa))
    |> Seq.filter (fun a -> a.GetTypes() |> Seq.exists AssemblyLoader.isVisitorType)
    |> Seq.map AssemblyLoader.rawLocation
    |> Seq.toArray

  /////////////////////////////////////////////////////////////////////////////////////

  static member private BridgedWriter
     (writer : Action<CompilerLogEntry>) : (WriteInfo -> unit) =
    function
    | WriteInfo.ParseFailed(error) ->
      let severity =
        match error.Severity with
        | FSharpErrorSeverity.Warning -> EventLogEntryType.Warning
        | FSharpErrorSeverity.Error -> EventLogEntryType.Error
      writer.Invoke(
        { Type = severity;
          FileName = error.FileName;
          Line = error.StartLineAlternate;
          Column = error.StartColumn;
          Code = String.Format("FS{0:D4}", error.ErrorNumber);
          Message = error.Message;
          Description = "" })
    | WriteInfo.CheckFailed(path) ->
      writer.Invoke(
        { Type = EventLogEntryType.Error;
          FileName = path;
          Line = 1;
          Column = 1;
          Code = "";
          Message = "Type checking failed.";
          Description = "" })
    | WriteInfo.UnknownFailed(exn) ->
      writer.Invoke(
        { Type = EventLogEntryType.Error;
          FileName = "unknown";
          Line = 1;
          Column = 1;
          Code = exn.GetType().FullName;
          Message = exn.Message;
          Description = exn.StackTrace })

  /// Compile with filter assemblies.
  static member private asyncCompile writer (arguments: CompilerArguments) = async {
    use _ = new SafeResolver()
    let visitors =
      arguments.VisitorPaths
      |> Seq.filter AssemblyLoader.isTargetAssemblyName
      |> Seq.choose AssemblyLoader.reflectionOnlyLoadFrom
      |> Seq.filter AssemblyLoader.isTargetAssembly
      |> Seq.choose (fun roa -> AssemblyLoader.loadFrom (AssemblyLoader.rawLocation roa))
      |> Seq.collect (fun a -> a.GetTypes())
      |> Seq.filter AssemblyLoader.isVisitorType
      |> Seq.map (fun t -> Activator.CreateInstance t :?> AstVisitor<FSharpCheckFileResults>)
      |> Seq.toArray
    let internalWriter = Compiler.BridgedWriter writer
    return! CompilerImpl.asyncCompile internalWriter arguments visitors
  }

  /////////////////////////////////////////////////////////////////////////////////////
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member AsyncCompileWithArguments writer arguments =
    Compiler.asyncCompile writer arguments
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member CompileWithArguments writer arguments =
    Compiler.asyncCompile writer arguments |> Async.RunSynchronously
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member AsyncCompile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.asyncCompile writer arguments

  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member Compile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.asyncCompile writer arguments |> Async.RunSynchronously

////////////////////////////////////////////////

open System.Runtime.CompilerServices

[<assembly: InternalsVisibleTo("FSharp.Expandable.Compiler.Core.Tests")>]
do()
