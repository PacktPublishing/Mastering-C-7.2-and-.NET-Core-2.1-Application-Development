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
            try
            {
                var items = "The quick brown fox jumped over the lazy dog".Split(" ");
                Parallel.ForEach(items, x =>
                {
                    Console.WriteLine($"Hash of {x} is {BCrypt.Net.BCrypt.HashPassword(x, 16)}");
                });
            }
            catch (AggregateException ex)
            {
                foreach (var exception in ex.Flatten().InnerExceptions)
                {
                    // Handle the exceptions here
                }
            }
        }
    }
}
