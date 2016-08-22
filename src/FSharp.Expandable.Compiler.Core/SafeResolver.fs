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
open System.Reflection

[<Sealed; AutoSerializable(false); NoEquality; NoComparison>]
type internal SafeResolver =
  
  new() as this =
    { }
    then
      let appDomain = AppDomain.CurrentDomain
      appDomain.add_AssemblyResolve(new ResolveEventHandler(this.Resolve))

  /// Resolve partially-loaded assembly.
  member private __.Resolve _ (e: ResolveEventArgs) =
    let appDomain = AppDomain.CurrentDomain
    let isTargetAssembly (assembly: Assembly) =
      let name = assembly.GetName().Name
      e.Name.StartsWith name
    let target =
      appDomain.GetAssemblies()
      |> Seq.tryFind isTargetAssembly
    match target with
    | Some assembly ->
      Debug.WriteLine("SafeResolver: {0} --> {1}", e.Name, assembly.FullName)
      assembly
    | None ->
      Debug.WriteLine("SafeResolver: {0} --> (Unknown)", e.Name)
      null

  member this.Dispose() =
    let appDomain = AppDomain.CurrentDomain
    appDomain.remove_AssemblyResolve(new ResolveEventHandler(this.Resolve))

  interface IDisposable with
    member this.Dispose() = this.Dispose()
