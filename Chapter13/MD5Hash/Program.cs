using System;
using System.Security.Cryptography;
using System.Text;
using Serilog;
using System.Linq;
namespace MD5Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var md5 = MD5.Create())
            {
                Log.Information($"The hash for {12345} is {Hash(md5, "12345")}");
                Log.Information($"The hash for {12345} is {Hash(md5, "12345")}");
                Log.Information($"The hash for {12346} is {Hash(md5, "12346")}");
            }
        }
        static string Hash(MD5 md5, string input)
        {
            return string.Join("", md5.ComputeHash(Encoding.Default.GetBytes(input)).SelectMany(x => x.ToString("x2")));
        }
    }
}
