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
open System.Runtime.InteropServices

open Microsoft.FSharp.Compiler

type CompilerLogEntry = {
  Type: EventLogEntryType
  FileName: string
  Line: int
  Column: int
  Code: int
  Message: string
}

/// <summary>
/// Execute F# compiler.
/// </summary>
[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type Compiler =

  /// <summary>
  /// Extract compiler arguments from string sequence.
  /// </summary>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Compilation arguments</returns>
  static member ExtractCompilerArguments args =
    CompilerArguments.extract args

  static member private BridgedWriter
     (writer : Action<CompilerLogEntry>) : (WriteInfo -> unit) =
    function
    | WriteInfo.ParseFailed(error) ->
      let severity =
        match error.Severity with
        | FSharpErrorSeverity.Warning -> EventLogEntryType.Warning
        | FSharpErrorSeverity.Error -> EventLogEntryType.Error
      writer.Invoke({ Type = severity; FileName = error.FileName; Line = error.StartLineAlternate; Column = error.StartColumn; Code = error.ErrorNumber; Message = error.Message })
    | WriteInfo.CheckFailed(path) ->
      writer.Invoke({ Type = EventLogEntryType.Error; FileName = path; Line = 1; Column = 1; Code = 1; Message = "Type checking failed." })
    | WriteInfo.UnknownFailed(exn) ->
      writer.Invoke({ Type = EventLogEntryType.Error; FileName = "unknown"; Line = 1; Column = 1; Code = Marshal.GetHRForException(exn); Message = exn.ToString()})
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member AsyncCompileWithArguments writer arguments =
    let intWriter = Compiler.BridgedWriter writer
    CompilerImpl.asyncCompile intWriter arguments
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member CompileWithArguments writer arguments =
    Compiler.AsyncCompileWithArguments writer arguments |> Async.RunSynchronously
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member AsyncCompile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.AsyncCompileWithArguments writer arguments

  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member Compile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.CompileWithArguments writer arguments

////////////////////////////////////////////////

open System.Runtime.CompilerServices

[<assembly: InternalsVisibleTo("FSharp.Expandable.Compiler.Core.Tests")>]
do()
