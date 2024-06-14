using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFor
{
    public class Loops
    {
        [Params(100, 1_000, 10_000)]
        public int limit;

        [Benchmark]
        public void NormalLoop()
        {
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Zwykla petla {i}");
            }
        }

        [Benchmark]
        public void ParallelLoop()
        {
            Parallel.For(0, limit, i =>
            {
                Console.WriteLine($"Rownolegla petla {i}");
            });
        }
    }
}
