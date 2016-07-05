using System;
using System.IO;
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
        /// Get tool name.
        /// </summary>
        public override string ToolName => "fscx.exe";
    }
}
