namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("fscx")>]
[<assembly: AssemblyProductAttribute("fscx")>]
[<assembly: AssemblyDescriptionAttribute("Expandable F# compiler")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
    let [<Literal>] InformationalVersion = "0.0.1"
