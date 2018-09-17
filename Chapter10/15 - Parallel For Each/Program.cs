using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using BCrypt.Net;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = "The quick brown fox jumped over the lazy dog".Split(" ");
            Parallel.ForEach(items, x =>
            {
                Console.WriteLine($"Hash of {x} is {BCrypt.Net.BCrypt.HashPassword(x, 16)}");
            });
        }

    }
}
