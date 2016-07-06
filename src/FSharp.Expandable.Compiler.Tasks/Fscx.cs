using System;
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
        public override string ToolName => "fscx.exe";

        public override string GenerateCommandLineCommands()
        {
            var commands = base.GenerateCommandLineCommands();

            var builder = new CommandLineBuilder();
            builder.AppendSwitchIfNotNull("--projectPath:", this.ProjectPath);
            var projectPathOption = builder.ToString();

            return projectPathOption + " " + commands;
        }
    }
}
