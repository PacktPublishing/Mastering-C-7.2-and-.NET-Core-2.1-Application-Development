using System;
using System.Diagnostics;

namespace StopwatchTiming
{
    class Program
    {
        static void Main(string[] args)
        {
            var sp = new Stopwatch();
            sp.Start();
            GenerateWithString();
            sp.Stop();
            Console.WriteLine(sp.Elapsed.TotalMilliseconds);
        }
        static string GenerateWithString()
        {
            var str = "";
            for (var i = 0; i < 100_000; i++)
            {
                str += i.ToString();
            }
            return str;
        }
    }
}
