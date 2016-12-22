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

namespace FSharp.Expandable.Compiler

[<System.AttributeUsage(System.AttributeTargets.Method)>]
type AspectTargetAttribute() =
  inherit System.Attribute()

namespace SampleCode

open FSharp.Expandable.Compiler

module TestFunctions =

//  let test () =
//    System.Console.WriteLine("output0: [||]", [||])

  let output1 (a: int, b: string, c: double) =
    System.Console.WriteLine("output1: {0}:{1}:{2}", a, b, c)

  let output2 (a: int) (b: string) (c: double) =
    System.Console.WriteLine("output2: {0}:{1}:{2}", a, b, c)

  let output3 a b c =
    System.Console.WriteLine("output3: {0}:{1}:{2}", a, b, c)

  let output4 () =
    System.Console.WriteLine("output4: ()")

  //////////////

module AspectTargets1 =

  [<AspectTarget>]
  let f11 (a: int, b: string, c: int) =
    TestFunctions.output1(a + c, b, 123.456)

  [<AspectTarget>]
  let f12 (a: int, b: string, c: int) =
    TestFunctions.output2 (a + c) b 123.456

  [<AspectTarget>]
  let f13 (a: int, b: string, c: int) =
    TestFunctions.output3 (a + c) b 123.456

  [<AspectTarget>]
  let f14 () =
    TestFunctions.output4 ()

  //////////////

module AspectTargets2 =

  [<AspectTarget>]
  let f21 (a: int) (b: string) (c: int) =
    TestFunctions.output1(a + c, b, 123.456)

  [<AspectTarget>]
  let f22 (a: int) (b: string) (c: int) =
    TestFunctions.output2 (a + c) b 123.456

  [<AspectTarget>]
  let f23 (a: int) (b: string) (c: int) =
    TestFunctions.output3 (a + c) b 123.456

  //////////////

module AspectTargets3 =

  [<AspectTarget>]
  let f31 a b c =
    TestFunctions.output1(a + c, b, 123.456)

  [<AspectTarget>]
  let f32 a b c =
    TestFunctions.output2 (a + c) b 123.456

  [<AspectTarget>]
  let f33 a b c =
    TestFunctions.output3 (a + c) b 123.456
