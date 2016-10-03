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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FSharp.Expandable
{
    /// <summary>
    /// Compiler driver for fscx (fscx.exe).
    /// </summary>
    internal static class Program
    {
        private static double ParseVersion(string version)
        {
            double value;
            if (double.TryParse(version, out value))
            {
                return value;
            }
            else
            {
                return -1;
            }
        }

        private static Assembly TryLoad(string path)
        {
            try
            {
                return Assembly.LoadFrom(path);
            }
            catch
            {
                return null;
            }
        }

        private static int? TryLoadAndRun(string corePath, string[] args)
        {
            MethodInfo mi = null;

            try
            {
                var assembly = Assembly.LoadFrom(corePath);
                var type = assembly.GetType("FSharp.Expandable.Compiler");
                mi = type.GetMethod("DefaultDriver");
            }
            catch
            {
                return null;
            }

            if (mi == null)
            {
                return null;
            }

            return (int)mi.Invoke(null, new object[] {args});
        }

        private static string[] GetCandidateBaseFolderPath(
            string packagesPath, string targetAssemblyName, string platformName)
        {
            // Search base folders by assembly name.
            return
              Directory.Exists(packagesPath)
              ? (from packagePath in
                  Directory.EnumerateDirectories(packagesPath, "*", SearchOption.TopDirectoryOnly)
                let packageName = Path.GetFileName(packagePath)
                where packageName.StartsWith(targetAssemblyName + ".")
                let version = ParseVersion(packageName.Substring(targetAssemblyName.Length + 1))
                orderby version descending
                from libPath in
                  Directory.EnumerateDirectories(packagePath, "lib", SearchOption.TopDirectoryOnly)
                from monikerPath in
                  Directory.EnumerateDirectories(packagePath, platformName, SearchOption.TopDirectoryOnly)
                orderby monikerPath descending
                select monikerPath).
                ToArray()
              : new[] { "." };
        }

        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <param name="args">Command line arguments (From FSharp.Expandable.Compiler.Tasks)</param>
        /// <returns>Return value</returns>
        public static int Main(string[] args)
        {
            // STRATEGY:
            //   Completely late bound for another package placed FSharp.Expandable.Compiler.Core.dll.
            //   Because Visual Studio loaded and locked FSharp.Expandable.Compiler.Tasks.dll,
            //   fscx infrastructure and filters FRUSTRATED debugging many recycled and recycled VS process...

            ///////////////////////////////////////////////////////////////////////
            // Search FSharp.Expandable.Compiler.Core.dll

            // NuGet package structure:
            //   packages --+-- FSharp.Expandable.Compiler.Build --+-- build --+-- FSharp.Expandable.Compiler.Tasks.dll (1: from MSBuild)
            //              |                                                  +-- fscx.exe (2: invoke from FscTask)
            //              |                                                  +-- FSharp.Core.dll (3: implicitly load from assembly loader)
            //              |
            //              +-- FSharp.Expandable.Compiler.Core --+-- lib --+-- net45 --+-- FSharp.Expandable.Compiler.Core.dll (3: DefaultDriver() function)
            //              |
            //              +-- FSharp.Compiler.Service --+-- lib --+-- net45 --+-- FSharp.Compiler.Service.dll (3: implicitly load from assembly loader)

            // TEST:
            Trace.Assert(false);

            var exeLocation = new Uri(typeof(Program).Assembly.CodeBase).LocalPath;
            var packagesPath =
                Path.GetFullPath(Path.Combine(Path.GetDirectoryName(exeLocation), "..", "..", ".."));

            // Load FCS.
            var fcsSearchFolderBases =
                GetCandidateBaseFolderPath(packagesPath, "FSharp.Compiler.Service", "net*");
            var fcsPaths =
                from searchFolderBase in fcsSearchFolderBases
                from dllPath in Directory.EnumerateFiles(searchFolderBase, "*.dll", SearchOption.AllDirectories)
                select dllPath;
            foreach (var fcsPath in fcsPaths)
            {
                var assembly = TryLoad(fcsPath);
                if (assembly != null)
                {
                    break;
                }
            }

            // Load and execute fscx core.
            var coreSearchFolderBases =
                GetCandidateBaseFolderPath(packagesPath, "FSharp.Expandable.Compiler.Core", "net*");
            var corePaths =
                from searchFolderBase in coreSearchFolderBases
                from dllPath in Directory.EnumerateFiles(searchFolderBase, "*.dll", SearchOption.AllDirectories)
                select dllPath;
            foreach (var corePath in corePaths)
            {
                var result = TryLoadAndRun(corePath, args);
                if (result.HasValue)
                {
                    return result.Value;
                }
            }

            throw new FileNotFoundException("Cannot found FSharp.Expandable.Compiler.Core.dll");
        }
    }
}
