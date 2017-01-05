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

// This sample code are minimum illustrated code for how to implementation aspects using fscx.
// Aspects are very simple for both enter-leave logging implementations.

/////////////////////////////////////////////////

// Duck-typed attribute for fscx targetting.

namespace FSharp.Expandable.Compiler

open System

[<AttributeUsage(AttributeTargets.Method)>]
type internal AspectTargetAttribute() = 
    inherit Attribute()

/////////////////////////////////////////////////

namespace SampleAspects

open System

// Totally duck-typed aspect classes:
// (Attributes are optional)
// The context class (aspects holding after entered method)
[<Sealed; NoEquality; NoComparison; AutoSerializable(false)>]
type SampleAspectContext internal (body : string) = 
    
    // Finish aspect (trigger are leaved method with return value)
    member __.Leave(result : 'T) : 'T = 
        Console.WriteLine("Leave: " + body)
        result
    
    // Finish aspect (trigger are leaved method with exception)
    member __.Caught(ex : exn) : unit = Console.WriteLine("Caught: " + body + ": " + ex.ToString())

// The aspect class (mainly beginning aspect before entering method)
[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type SampleAspect() = 
    // Start aspect (trigger are entered method)
    static member Enter(methodName : string, fileName : string, line : int, column : int, args : obj []) = 
        let body = 
            String.Format
                ("Enter: {0}({1}, {2}): {3}({4})", fileName, line, column, methodName, 
                 String.Join(", ", args |> Seq.map (sprintf "%A")))
        Console.WriteLine("Enter: " + body)
        new SampleAspectContext(body)
