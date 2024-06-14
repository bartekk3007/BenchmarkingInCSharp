using BenchmarkDotNet.Running;
using System.Reflection;

namespace ParallelFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 1_000_000;
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);
        }
    }
}
