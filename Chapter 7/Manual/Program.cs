using System;
using System.Text;

namespace Manual
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            GenerateWithString();
            var stop = DateTime.Now;
            Console.WriteLine((stop - start).TotalSeconds);
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
