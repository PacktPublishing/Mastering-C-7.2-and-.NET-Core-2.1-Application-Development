using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Running;
using System;

namespace CSharp72
{
    public class Program
    {
        [RankColumn]
        public class StringTests
        {
            string sample = "The quick brown fox jumped over the lazy dog";
            [Benchmark]
            public int SubStringOld()
            {
                var first = sample.Substring(0, 10);
                var second = sample.Substring(11, 5);
                var third = sample.Substring(17, 5);
                return first.Length + second.Length + third.Length;
            }
            [Benchmark]
            public int SubsStringNew()
            {
                var first = sample.AsSpan().Slice(0, 10);
                var second = sample.AsSpan().Slice(11, 5);
                var third = sample.AsSpan().Slice(17, 5);
                return first.Length + second.Length + third.Length;
            }
        }
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<StringTests>();
            Console.Read();
        }
    }
}
