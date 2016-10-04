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
open System.IO
open System.Reflection
open System.Runtime.CompilerServices

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast.Visitor
open Microsoft.FSharp.Compiler.SourceCodeServices

/// <summary>
/// Compiler logging information.
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
  static member ExtractCompilerArguments args =
    CompilerArguments.extract args

  /////////////////////////////////////////////////////////////////////////////////////

  /// <summary>
  /// Filter visitor class expression.
  /// </summary>
  /// <param name="paths">Assembly paths</param>
  /// <returns>Assembly paths of contains visitors</returns>
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

  /// WriteInfo ==> CompilerLogEntry bridge function.
  static member private WrappedBridgedWriter
     (writer : CompilerLogEntry -> unit) : (WriteInfo -> unit) =
    function
    | WriteInfo.Message(typ, path, message) ->
      writer
        { Type = typ;
          FileName = path;
          Line = 1;
          Column = 1;
          Code = "";
          Message = message;
          Description = "" }
    | WriteInfo.ParseFailed(error) ->
      let severity =
        match error.Severity with
        | FSharpErrorSeverity.Warning -> EventLogEntryType.Warning
        | FSharpErrorSeverity.Error -> EventLogEntryType.Error
      writer
        { Type = severity;
          FileName = error.FileName;
          Line = error.StartLineAlternate;
          Column = error.StartColumn;
          Code = String.Format("FS{0:D4}", error.ErrorNumber);
          Message = error.Message;
          Description = "" }
    | WriteInfo.CheckFailed(path) ->
      writer
        { Type = EventLogEntryType.Error;
          FileName = path;
          Line = 1;
          Column = 1;
          Code = "";
          Message = "Type checking failed.";
          Description = "" }
    | WriteInfo.UnknownFailed(path, exn) ->
      writer
        { Type = EventLogEntryType.Error;
          FileName = path;
          Line = 1;
          Column = 1;
          Code = exn.GetType().FullName;
          Message = exn.Message;
          Description = exn.StackTrace }

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
      |> Seq.map (fun t -> Activator.CreateInstance t :?> IAstVisitor)
      |> Seq.toArray
    let internalWriter = Compiler.WrappedBridgedWriter writer
    return! CompilerImpl.asyncCompile internalWriter arguments visitors
  }

  static member private fromAction (writer: Action<CompilerLogEntry>) =
    fun (logEntry: CompilerLogEntry) -> writer.Invoke(logEntry)

  /////////////////////////////////////////////////////////////////////////////////////
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member AsyncCompileWithArguments writer arguments =
    Compiler.asyncCompile (Compiler.fromAction writer) arguments
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="tw">Message sink</param>
  /// <param name="arguments">Compilation arguments</param>
  /// <returns>Result value</returns>
  static member CompileWithArguments writer arguments =
    Compiler.asyncCompile (Compiler.fromAction writer) arguments |> Async.RunSynchronously
 
  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member AsyncCompile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.asyncCompile (Compiler.fromAction writer) arguments

  /// <summary>
  /// Execute F# compiler with standard arguments.
  /// </summary>
  /// <param name="writer">Message sink</param>
  /// <param name="args">Compiration argument strings</param>
  /// <returns>Result value</returns>
  static member Compile writer args =
    let arguments = CompilerArguments.extract args
    Compiler.asyncCompile (Compiler.fromAction writer) arguments |> Async.RunSynchronously

  /////////////////////////////////////////////////////////////////////////////////////

  /// Default compiler driver.
  static member DefaultDriver (args: string[]) =

    // Extract arguments.
    let arguments = CompilerArguments.extract args

    // If not giving visitor paths:
    if Seq.isEmpty arguments.VisitorPaths then

      ///////////////////////////////////////////////////////////////////////
      // Crawl visitor assemblies

      // NuGet package structure:
      //   packages --+-- FSharp.Expandable.Compiler.Build --+-- build --+-- FSharp.Expandable.Compiler.Tasks.dll (1: from MSBuild)
      //              |                                                  +-- fscx.exe (2: invoke from FscTask)
      //              |                                                  +-- FSharp.Core.dll (3: implicitly load from assembly loader)
      //              |
      //              +-- FSharp.Expandable.Compiler.Core --+-- lib --+-- net45 --+-- FSharp.Expandable.Compiler.Core.dll (3: DefaultDriver() function)
      //              |
      //              +-- FSharp.Compiler.Service --+-- lib --+-- net45 --+-- FSharp.Compiler.Service.dll (3: implicitly load from assembly loader)
      //              |
      //              +-- HogeFilter-1.0 --+-- build --+-- HogeFilter.dll   (Filter must place into "build" folder)
      //              +-- HagaFilter-1.0 --+-- build --+-- HagaFilter.dll

      // (3)
      let assemblyLocation = (new Uri(typeof<Compiler>.Assembly.CodeBase)).LocalPath

      // the "packages" path.
      let packagesPath = Path.Combine(Path.GetDirectoryName(assemblyLocation), "..", "..", "..")

      let searchFolderBases =
        if Directory.Exists(packagesPath) then
          Directory.EnumerateDirectories(packagesPath, "*", SearchOption.TopDirectoryOnly)
          |> Seq.collect (fun packagePath -> Directory.EnumerateDirectories(packagePath, "build", SearchOption.TopDirectoryOnly))
          |> Seq.toArray
        else
          [| "." |]

      let visitorPaths =
        searchFolderBases
        |> Seq.collect (fun searchFolderBase -> Directory.EnumerateFiles(searchFolderBase ,"*.dll", SearchOption.AllDirectories))
        |> Compiler.FilterVisitors

#if DEBUG
      visitorPaths |> Seq.iter Debug.WriteLine
#endif

      // Set visitor paths.
      arguments.VisitorPaths <- visitorPaths

    // Compile
    let logWriter logEntry =
      Console.WriteLine(
        "{0}({1},{2}): {3}{4}: {5}",
        logEntry.FileName,
        logEntry.Line,
        logEntry.Column,
        logEntry.Type.ToString().ToLowerInvariant(),
        (if String.IsNullOrWhiteSpace(logEntry.Code) then "" else (" " + logEntry.Code)),
        logEntry.Message)
    Compiler.asyncCompile logWriter arguments |> Async.RunSynchronously

////////////////////////////////////////////////

open System.Runtime.CompilerServices

[<assembly: InternalsVisibleTo("FSharp.Expandable.Compiler.Core.Tests")>]
do()
