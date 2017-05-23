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
open System.Linq
open System.Reflection

/////////////////////////////////////////////////////////////////////////////////////

type TargetRuntimes = 
| FS4NET461 = 4461
| Loaded = 0

[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type CompilerHelper = 
    
    // "writer" is Action<T> because reduce all implicitly F#'s references publicity (ex: FSharpFunc<'T>).
    static member RawCompileWithArguments(writer, arguments, visitors) = 
        let internalWriter = Compiler.WrappedBridgedWriter(Compiler.fromAction writer)
        CompilerImpl.asyncCompile internalWriter arguments visitors |> Async.RunSynchronously
    
    /// <summary>
    /// Default compiler driver.
    /// </summary>
    /// <param name="packagesBasePath">NuGet packages folder base path. If value is None (null), path extracts become "--packageBasePath" argument.</param>
    /// <param name="args">Command line arguments.</param>
    /// <remarks>Easy way for using fscx.
    /// This method using for meaning nearly execution fscx.exe with command line arguments.
    /// Output messages are writing on console.
    /// Visitor assembly auto crawling by NuGet package folder structures from the packagesBasePath argument.</remarks>
    static member RunDefaultDriver(packagesBasePath, [<ParamArray>] args : string []) = 

        // Extract arguments.
        let arguments = CompilerArguments.extract args

        // Override package base path.
        if String.IsNullOrWhiteSpace(packagesBasePath) = false then
            arguments.PackageBasePath <- packagesBasePath

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
            let searchFolderBases = 
                if Directory.Exists(packagesBasePath) then 
                    Directory.EnumerateDirectories(packagesBasePath, "*", SearchOption.TopDirectoryOnly)
                    |> Seq.collect 
                        (fun packagePath -> 
                        Directory.EnumerateDirectories(packagePath, "build", SearchOption.TopDirectoryOnly))
                    |> Seq.toArray
                else [| "." |]
            
            let visitorPaths = 
                searchFolderBases
                |> Seq.collect 
                       (fun searchFolderBase -> 
                       Directory.EnumerateFiles(searchFolderBase, "*.dll", SearchOption.AllDirectories))
                |> Compiler.FilterVisitors packagesBasePath

#if DEBUG
            visitorPaths |> Seq.iter Debug.WriteLine
#endif
            
            // Set visitor paths.
            arguments.VisitorPaths <- visitorPaths

        // Compile
        let logWriter logEntry = 
            Console.WriteLine
                ("{0}({1},{2}): {3}{4}: {5}",
                 logEntry.FileName, logEntry.Line, logEntry.Column, 
                 logEntry.Type.ToString().ToLowerInvariant(), 
                 (if String.IsNullOrWhiteSpace(logEntry.Code) then ""
                  else (" " + logEntry.Code)),
                 logEntry.Message.Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " "))

        Compiler.asyncCompile logWriter arguments |> Async.RunSynchronously
    
    /////////////////////////////////////////////////////////////////////////////////////
    static member private optionArgs = 
        [| "-g"; "--debug:full"; "--noframework"; "--define:DEBUG"; "--define:TRACE"; "--optimize-"; "--tailcalls-"; 
           "--platform:anycpu32bitpreferred"; "--target:library"; "--warn:3"; "--warnaserror:76"; "--vserrors"; 
           "--LCID:1033"; "--utf8output"; "--fullpaths"; "--flaterrors"; "--subsystemversion:6.00"; "--highentropyva+" |]

    static member private fs4net461Refs = 
        [| @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll"; 
           @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll"; 
           @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll"; 
           @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll"; 
           @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll" |]

    /// For use testing only.
    static member UnsafeGetPreDefinedDefaultArguments(targetRuntime, visitorPaths, sourceCodePaths, packagesBasePath) = 

        let sourceCodePath = sourceCodePaths |> Enumerable.Last
        let fileName = Path.GetFileNameWithoutExtension sourceCodePath
        let filePath = Path.Combine(Path.GetDirectoryName sourceCodePath, fileName)

        match targetRuntime with
        | TargetRuntimes.FS4NET461 -> 
            new CompilerArguments
                (filePath + ".fsproj",
                 filePath + ".dll", 
                 fileName, 
                 filePath + ".pdb", 
                 CompilerHelper.fs4net461Refs, 
                 sourceCodePaths, 
                 CompilerHelper.optionArgs,
                 packagesBasePath, 
                 visitorPaths, 
                 false, 
                 [] |> Map.ofSeq)
        | TargetRuntimes.Loaded -> 
            new CompilerArguments
                (filePath + ".fsproj", filePath + ".dll", fileName, filePath + ".pdb", 
                 AppDomain.CurrentDomain.GetAssemblies()
                 |> Array.choose (fun assembly ->
                    let codeBase = 
                        (new Uri(assembly.CodeBase)).LocalPath
                    let name = assembly.GetName()
                    match assembly.EntryPoint with
                    | null -> 
                        if assembly.GlobalAssemblyCache then 
                            let entryAssembly = 
                                Assembly.GetEntryAssembly()
                            let basePath = 
                                Path.GetDirectoryName (new Uri(entryAssembly.CodeBase)).LocalPath
                            let tryPath = 
                                Path.Combine(basePath, name.Name + ".dll")
                            if File.Exists tryPath then Some tryPath
                            else Some codeBase
                        else Some codeBase
                    | _ -> None),
                    sourceCodePaths,
                    CompilerHelper.optionArgs,
                    packagesBasePath,
                    visitorPaths,
                    false,
                    [] |> Map.ofSeq)
        | _ -> failwith "Unknown targetRuntime"

////////////////////////////////////////////////

open System.Runtime.CompilerServices

[<assembly:InternalsVisibleTo("FSharp.Expandable.Compiler.Core.Tests")>]
do ()
