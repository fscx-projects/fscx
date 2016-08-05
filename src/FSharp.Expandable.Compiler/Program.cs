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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FSharp.Expandable
{
    /// <summary>
    /// Compiler driver for fscx (fscx.exe)
    /// </summary>
    internal static class Program
    {
        private static readonly HashSet<string> knownFileName =
            new HashSet<string>(
                new[] { "FSharp.Core.dll", "FSharp.Compiler.Service.dll", "FSharp.Expandable.Compiler.Core.dll" },
                StringComparer.InvariantCultureIgnoreCase);

        private static string GetAssemblyLocation(Assembly assembly)
        {
            return new Uri(assembly.CodeBase).LocalPath;
        }

        private static bool IsKnownAssembly(string path)
        {
            var fileName = Path.GetFileName(path);

            // .NET Standard library
            if (fileName.StartsWith("System."))
            {
                return true;
            }

            // F#, fscx assembly
            return knownFileName.Contains(fileName);
        }

        private static Assembly PreLoadAssembly(string path)
        {
            try
            {
                return Assembly.ReflectionOnlyLoadFrom(path);
            }
            catch
            {
                return null;
            }
        }

        private static bool IsFilterAssembly(Assembly assembly)
        {
            return
                (assembly != null) &&
                assembly.GetReferencedAssemblies().
                    Any(name => name.Name.StartsWith("FSharp.Expandable.Compiler.Core"));
        }

        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <param name="args">Command line arguments (From FSharp.Expandable.Compiler.Tasks)</param>
        /// <returns>Return value</returns>
        public static int Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////
            // Assembly resolver (Helper for dynamic loaded assembly, fscx/FCS)

            var appDomain = AppDomain.CurrentDomain;
            appDomain.AssemblyResolve += (s, e) =>
            {
                var index = e.Name.IndexOf(",");
                var partialName = (index >= 0) ? e.Name.Substring(index) : e.Name;

                var targetAssembly =
                    appDomain.GetAssemblies().
                    FirstOrDefault(assembly => assembly.FullName.StartsWith(partialName));

                Debug.WriteLine("Resolve: {0} --> {1}", e.Name, targetAssembly?.FullName??"(Unknown)");

                return targetAssembly;
            };

            ///////////////////////////////////////////////////////////////////////
            // Crawl filters

            // TODO: improve detection (idea: parse nuspec?)
            //  Current:
            //   packages --+-- fscx-0.1.*     --+-- build --+-- fscx.exe
            //              +-- HogeFilter-1.0 --+-- lib   --+-- net45 --+-- HogeFilter.dll
            //              +-- HagaFilter-1.0 --+-- lib   --+-- net45 --+-- HagaFilter.dll

            var exeLocation = GetAssemblyLocation(Assembly.GetExecutingAssembly());
            var packagesPath = Path.Combine(Path.GetDirectoryName(exeLocation), "..", "..");
            var assemblies =
                Directory.EnumerateDirectories(packagesPath, "*.dll", SearchOption.AllDirectories).
                Where(path => !IsKnownAssembly(path)).
                Select(PreLoadAssembly).
                Where(IsFilterAssembly).
                Select(assembly => Assembly.LoadFrom(GetAssemblyLocation(assembly))).
                ToArray();

            ///////////////////////////////////////////////////////////////////////
            // Compile

            return Compiler.Compile(logEntry =>
               Console.WriteLine(
                   "{0}({1},{2}): {3}{4}: {5}",
                   logEntry.FileName,
                   logEntry.Line,
                   logEntry.Column,
                   logEntry.Type.ToString().ToLowerInvariant(),
                   string.IsNullOrWhiteSpace(logEntry.Code) ? "" : logEntry.Code,
                   logEntry.Message),
               args);
        }
    }
}
