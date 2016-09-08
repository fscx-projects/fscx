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

namespace FSharp.Expandable.Compiler.Generator

open System
open System.IO
open System.Text

/// Base type of Generator.
[<AbstractClass>]
type internal GeneratorBase () =

  /// <summary>
  /// Generate body lines.
  /// </summary>
  /// <returns>Generated lines.</returns>
  abstract GenerateBodies: unit -> string seq

  /// <summary>
  /// Generate with template source codes (from embedded resource).
  /// </summary>
  /// <param name="basePath">Store to the path of generated source code files.</param>
  /// <param name="time">Commonly generated timestamp.</param>
  member this.Generate (basePath: string) (time: DateTime) =
    let name = this.GetType().Name.Replace("Generator", "")
    let template = Utilities.readTemplate (name + "Template.fs")

    let path = Path.Combine(basePath, name + ".fs")
    use fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None)
    let tw = new StreamWriter(fs, Encoding.UTF8)

    tw.WriteLine(template, time)
    this.GenerateBodies() |> Seq.iter tw.Write
    tw.Flush()
    fs.Flush()
