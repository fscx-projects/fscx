using System;
using System.Diagnostics;

namespace FSharp.Expandable
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            Debug.Assert(false);
            return Compiler.CompileWithArguments(Console.Out, args);
        }
    }
}
