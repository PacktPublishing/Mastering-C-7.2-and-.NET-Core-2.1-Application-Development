using System;
using System.Text;

namespace VSProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateWithStringBuilder();
            Console.ReadLine();
        }
        static string GenerateWithStringBuilder()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < 5_000; i++)
            {
                sb.Append(i.ToString());
            }
            return sb.ToString();
        }
    }
}
