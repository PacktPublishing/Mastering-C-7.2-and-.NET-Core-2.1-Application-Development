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
            for (var i = 65; i < 91; i++)
                Print((char)i);
            Console.WriteLine();
            Parallel.For(65, 91, x => Print((char)x));
        }
        static void Print(char s)
        {
            Console.Write(s);
        }
    }
}
