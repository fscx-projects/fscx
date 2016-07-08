namespace System
open System.Reflection

[<assembly: AssemblyProductAttribute("Expandable F# compiler")>]
[<assembly: AssemblyCopyrightAttribute("Author: Kouji Matsui, bleis-tift")>]
[<assembly: AssemblyCompanyAttribute("https://github.com/fscx-projects")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "LocalBuild"
    let [<Literal>] InformationalVersion = "LocalBuild"
