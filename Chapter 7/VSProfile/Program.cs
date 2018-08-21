using System;
using System.Text;
using System.Threading;

namespace VSProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateWithStringBuilder();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        static string GenerateWithStringBuilder()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < 1_000; i++)
            {
                sb.Append(i.ToString());
            }
            return sb.ToString();
        }
    }
}
