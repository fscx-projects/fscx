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

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.FSharp.Build;

namespace FSharp.Expandable.Compiler.Tasks
{
    /// <summary>
    /// FSharp.Expandable.Compiler MSBuild task.
    /// </summary>
    public sealed class Fscx : Fsc
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Fscx()
        {
            var assembly = this.GetType().Assembly;
            var codeBase = new Uri(assembly.CodeBase);
            var rawLocation = codeBase.LocalPath;
            this.ToolPath = Path.GetDirectoryName(rawLocation);
        }

        /// <summary>
        /// FSharp Project path (*.fsproj)
        /// </summary>
        [Required]
        public ITaskItem ProjectPath
        {
            get;
            set;
        }

        /// <summary>
        /// Get tool name.
        /// </summary>
        /// <returns>Tool name.</returns>
        public override string ToolName => "fscx.exe";

        /// <summary>
        /// Generate command line arguments.
        /// </summary>
        /// <returns>Command line arguments.</returns>
        public override string GenerateCommandLineCommands()
        {
            // Hmm.. ProjectPath cannot take from BuildEngine.
            // http://simoncropp.com/getprojectpathanmsbuildtask

            var commands = base.GenerateCommandLineCommands();

            var builder = new CommandLineBuilder();
            builder.AppendSwitchIfNotNull("--projectPath:", this.ProjectPath);
            var arguments = builder.ToString() + " " + commands;

            Debug.WriteLine($"Fscx: arguments: {arguments}");

            return arguments;
        }
    }
}
