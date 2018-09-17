using System;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 30);
            var result = numbers.AsParallel().AsOrdered().Where(x => x % 3 == 0).ToArray();
            Print(result);
        }
        static void Print(int[] numbers)
        {
            foreach (var number in numbers)
                Console.Write($"{number},");
            Console.WriteLine();
        }
    }
}