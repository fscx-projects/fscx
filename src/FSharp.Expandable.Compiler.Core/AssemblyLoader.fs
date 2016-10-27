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
open System.IO
open System.Reflection

open Microsoft.FSharp.Compiler.SourceCodeServices
open Microsoft.FSharp.Compiler.Ast.Visitors

module internal AssemblyLoader =

  /// Include only referenced fscx.
  let isTargetAssembly (assembly: Assembly) =
    assembly.GetReferencedAssemblies()
    |> Seq.exists (fun a -> a.FullName.StartsWith "FSharp.Expandable.Compiler.Core")

  /// Include only visitor type.
  let private declType = typeof<IDeclareFscxVisitor>
  let isVisitorType (t: Type) =
    (not t.IsAbstract) && declType.IsAssignableFrom t && (t.GetConstructor(Type.EmptyTypes) <> null)

  /// Get local path from assembly.
  let rawLocation (assembly: Assembly) =
    let uri = new Uri(assembly.CodeBase)
    uri.LocalPath

  /// Exclude known standard assemblies (speed up)
  let isTargetAssemblyName (path: string) =
    let fileName = Path.GetFileNameWithoutExtension path
    if fileName = "mscorlib" then
      false
    else if fileName = "System" then
      false
    else if fileName = "System.Core" then
      false
    else if fileName = "FSharp.Core" then
      false
    else if fileName.StartsWith "FSharp.Compiler.Service" then
      false
    else if fileName.StartsWith "FSharp.Expandable.Compiler" then
      false
    else
      true

  /// Safe load assembly into reflection only context.
  let reflectionOnlyLoadFrom (path: string) =
    try
      Some (Assembly.ReflectionOnlyLoadFrom path)
    with
    | _ -> None

  /// Safe load assembly into default context.
  let loadFrom (path: string) =
    try
      Some (Assembly.LoadFrom path)
    with
    | _ -> None

