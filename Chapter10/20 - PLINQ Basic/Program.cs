using System;
using System.Threading;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SimpleThread
{
    public class Program
    {
        public static void Main(string[] args) => BenchmarkRunner.Run<Program>();
        [Benchmark]
        public double[] Sequential()
        {
            var numbers = Enumerable.Range(0, 10_000);
            return numbers.Select(x => Math.Sqrt(x)).ToArray();
        }
        [Benchmark]
        public double[] Parallel()
        {
            var numbers = Enumerable.Range(0, 10_000);
            return numbers.Select(x => Math.Sqrt(x)).AsParallel().ToArray();
        }

    }
}
