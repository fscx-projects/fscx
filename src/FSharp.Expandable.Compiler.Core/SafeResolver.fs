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

[<Sealed; AutoSerializable(false); NoEquality; NoComparison>]
type internal SafeResolver =
  
  new() as this =
    { }
    then
      let appDomain = AppDomain.CurrentDomain
      appDomain.add_AssemblyResolve(new ResolveEventHandler(this.Resolve))

  member private __.resolve isTargetAssembly =
    let appDomain = AppDomain.CurrentDomain
    appDomain.GetAssemblies() |> Seq.filter isTargetAssembly

  member private __.loadBySide (baseAssembly: Assembly) partialName =
    let basePath = Path.GetDirectoryName((new Uri(baseAssembly.CodeBase)).LocalPath)
    let path = Path.Combine(basePath, partialName + ".dll")
    if File.Exists path then
      try
        let assembly = Assembly.LoadFrom path
        Debug.WriteLine(System.String.Format("SafeResolver: cannot resolved, load from base : {0} [{1}]", partialName, assembly.Location))
        Some assembly
      with
      | exn ->
        Debug.WriteLine(System.String.Format("SafeResolver: cannot load : {0} [{1}] [{2}]", partialName, path, exn.Message))
        None
    else
      Debug.WriteLine(System.String.Format("SafeResolver: assembly not found : {0} [{1}]", partialName, path))
      None

  member private this.safeLoadBySide (baseAssembly: Assembly) partialName =
    match this.loadBySide baseAssembly partialName with
    | Some assembly -> assembly
    | None ->
      match this.loadBySide (Assembly.GetEntryAssembly()) partialName with
      | Some assembly -> assembly
      | None -> null

  /// Resolve partially-loaded assembly.
  member private this.Resolve _ (e: ResolveEventArgs) =
    let isFullAssembly (assembly: Assembly) =
      assembly.FullName = e.Name
    let partialName = e.Name.Substring (0, e.Name.IndexOf ',')
    let isPartialAssembly (assembly: Assembly) =
      let name = assembly.GetName().Name
      name = partialName
    let result =
      Seq.append (this.resolve isFullAssembly) (this.resolve isPartialAssembly)
      |> Seq.tryHead
    match result, e.RequestingAssembly with
    | Some assembly, _ ->
      Debug.WriteLine(System.String.Format("SafeResolver: resolved: {0} --> {1}", e.Name, assembly.FullName))
      assembly
    | None, baseAssembly ->
      this.safeLoadBySide baseAssembly partialName

  member this.Dispose() =
    let appDomain = AppDomain.CurrentDomain
    appDomain.remove_AssemblyResolve(new ResolveEventHandler(this.Resolve))

  interface IDisposable with
    member this.Dispose() = this.Dispose()
