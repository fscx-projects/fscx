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
open System.Runtime.InteropServices

module private UtilitiesImpl =
    [<DllImport("user32.dll", SetLastError=true, CharSet=CharSet.Unicode)>]
    extern int MessageBoxW(IntPtr, System.String, System.String, int)

type internal MessageBoxType =
    | Informational
    | Warning
    | Error

[<Sealed; AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type internal Utilities =

    static member showMessageBox (typ: MessageBoxType, title: string, format: string, [<ParamArray>] args: obj[]) =
        UtilitiesImpl.MessageBoxW
            (IntPtr.Zero,
             String.Format(format, args),
             title,
             match typ with
             | Informational -> 0x40
             | Warning -> 0x30
             | Error -> 0x10) |> ignore

    static member debugMessageBox (typ: MessageBoxType, title: string, format: string, [<ParamArray>] args: obj[]) =
#if DEBUG
        Utilities.showMessageBox(typ, title, format, args)
#else
        ()
#endif
