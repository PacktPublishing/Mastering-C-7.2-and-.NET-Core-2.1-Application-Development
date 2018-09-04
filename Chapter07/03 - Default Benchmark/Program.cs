using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public class Program
    {
        public class GeneratorTests
        {
            public GeneratorTests()
            {
                GenerateWithString();
                GenerateWithStringBuilder();
            }
            [Benchmark]
            public string GenerateWithString()
            {
                var str = "";
                for (var i = 0; i < 1_000; i++)
                {
                    str += i.ToString();
                }
                return str;
            }
            [Benchmark]
            public string GenerateWithStringBuilder()
            {
                var sb = new StringBuilder();
                for (var i = 0; i < 1_000; i++)
                {
                    sb.Append(i.ToString());
                }
                return sb.ToString();
            }
        }
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<GeneratorTests>();
        }

    }
}
