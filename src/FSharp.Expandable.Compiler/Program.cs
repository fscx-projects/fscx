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
using System.Runtime.InteropServices;

using Microsoft.Win32;

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

        private sealed class RunResult
        {
            public readonly int Value;

            public RunResult(int value)
            {
                this.Value = value;
            }
        }

        private static RunResult TryLoadAndRun(string corePath, string[] args)
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

            return new RunResult((int)mi.Invoke(null, new object[] {args}));
        }

        private static string[] GetCandidateBaseFolderPath(
            string packagesPath,
            string targetAssemblyName,
            string platformName)
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
                  Directory.EnumerateDirectories(libPath, platformName, SearchOption.TopDirectoryOnly)
                // Sorted by moniker, ex: ["net45", "net40", "net35", "net20" ... ]
                orderby monikerPath descending
                select monikerPath).
                ToArray()
              : new[] { "." };
        }

        private static TResult LoadAssembly<TResult>(
            string packagesPath,
            string targetFileName,
            string assemblyName,
            string moniker,
            Func<string, TResult> tryLoad)
            where TResult : class
        {
            var baseFolderPaths =
                GetCandidateBaseFolderPath(
                    packagesPath,
                    assemblyName,
                    moniker);
            var dllPaths =
                from baseFolderPath in baseFolderPaths
                from dllPath in Directory.EnumerateFiles(
                    baseFolderPath,
                    targetFileName,
                    SearchOption.AllDirectories)
                select dllPath;
            foreach (var dllPath in dllPaths)
            {
                var result = tryLoad(dllPath);
                if (result != null)
                {
                    return result;
                }
            }

            throw new FileNotFoundException($"{assemblyName}, {moniker}");
        }

        [DllImport("user32", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int MessageBoxW(IntPtr hWnd, string text, string caption, int options);

        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <param name="args">Command line arguments (From FSharp.Expandable.Compiler.Tasks)</param>
        /// <returns>Return value</returns>
        public static int Main(string[] args)
        {
            try
            {
                using (var subKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\VisualStudio", false))
                {
                    bool fscxLoaderDebug;
                    bool.TryParse((string)subKey.GetValue("fscxLoaderDebug", "false"), out fscxLoaderDebug);
                    if (fscxLoaderDebug == true)
                    {
                        MessageBoxW(
                            IntPtr.Zero,
                            "Fscx loader: Waiting for attach debugger...",
                            $"Fscx loader: {Process.GetCurrentProcess().Id}",
                            0x30);
                    }
                }
            }
            catch
            {
            }

            try
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

                var exeLocation = new Uri(typeof(Program).Assembly.CodeBase).LocalPath;
                var packagesPath =
                    Path.GetFullPath(Path.Combine(Path.GetDirectoryName(exeLocation), "..", ".."));

                // Manually preload FSharp.Core.
                LoadAssembly(
                    packagesPath,
                    "FSharp.Core.dll",
                    "FSharp.Core",
                    "net*",
                    TryLoad);

                // Manually preload FCS.
                LoadAssembly(
                    packagesPath,
                    "FSharp.Compiler.Service.dll",
                    "FSharp.Compiler.Service",
                    "net*",
                    TryLoad);

                // Manually preload visitor.
                LoadAssembly(
                    packagesPath,
                    "FSharp.Compiler.Service.Visitors.dll",
                    "FSharp.Compiler.Service.Visitors",
                    "net*",
                    TryLoad);

                // Load and execute fscx core.
                var result = LoadAssembly(
                    packagesPath,
                    "*.dll",
                    "FSharp.Expandable.Compiler.Core",
                    "net*",
                    path => TryLoadAndRun(path, args));

                return result.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.ToString());
                return Marshal.GetHRForException(ex);
            }
        }
    }
}
