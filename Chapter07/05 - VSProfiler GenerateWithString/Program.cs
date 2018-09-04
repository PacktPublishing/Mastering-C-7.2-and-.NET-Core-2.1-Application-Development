using System;
using System.Threading;

namespace VSProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateWithString();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        static string GenerateWithString()
        {
            var str = "";
            for (var i = 0; i < 1_000; i++)
            {
                str += i.ToString();
            }
            return str;
        }
    }
}
