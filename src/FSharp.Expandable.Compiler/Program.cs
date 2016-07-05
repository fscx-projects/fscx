namespace FSharp.Expandable
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            return Compiler.compile(args);
        }
    }
}
