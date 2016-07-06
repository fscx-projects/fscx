namespace FSharp.Expandable

open System.Runtime.InteropServices
      
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
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member AsyncCompile tw arguments =
    CompilerImpl.asyncCompile tw arguments
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member Compile tw arguments =
    let result = CompilerImpl.asyncCompile tw arguments |> Async.Catch |> Async.RunSynchronously
    match result with
    | Choice1Of2 returnValue -> returnValue
    | Choice2Of2 ex ->
      Marshal.GetHRForException ex
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member AsyncCompileWithArguments tw args =
    let arguments = CompilerArguments.extract args
    Compiler.AsyncCompile tw arguments

  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member CompileWithArguments tw args =
    let arguments = CompilerArguments.extract args
    Compiler.Compile tw arguments

////////////////////////////////////////////////

open System.Runtime.CompilerServices

[<assembly: InternalsVisibleTo("FSharp.Expandable.Compiler.Core.Tests")>]
do()
