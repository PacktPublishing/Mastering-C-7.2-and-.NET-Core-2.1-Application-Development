using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Parallel.For(65, 91, (x, state) =>
            {
                // Exit when we get to 75
                if (x == 75)
                    state.Break();
                Print((char)x);
            });
            Console.WriteLine();
            Console.WriteLine($"Did we complete? {result.IsCompleted}. We broke at {result.LowestBreakIteration}");
        }
        static void Print(char c) => Console.Write(c);
    }

}
