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

module FscxOutputSample1

  let f1 (a: int, b: string, c: int) =
    System.Console.WriteLine("Sample1: {0}:{1}", a, b)
//
//  let f2 (a: int, b: string, c: int) =
//    let __arg_0 = a
//    let __arg_1 = b
//    let __arg_2 = c
//    let __context = SampleAspectLogger.SampleAspect.Enter("FscxOutputSample1.f2", "SampleCode.fs", 27, 2, [|__arg_0;__arg_1;__arg_2|])
//    try
//      __context.Leave(System.Console.WriteLine("Sample1: {0}:{1}", __arg_0, __arg_1))
//    with
//    | ex ->
//        __context.Caught(ex)
//        reraise()
