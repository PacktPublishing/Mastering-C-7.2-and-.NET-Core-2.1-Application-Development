using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace SHA256HashLengths
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var sha = SHA256.Create())
            {
                Log.Information("The hash for {input1} is {hash}", "A", Hash(sha, "A"));
                Log.Information("The hash for {input2} is {hash}", "The Quick Brown Fox Jumped",
                    Hash(sha, "The Quick Brown Fox Jumped"));
            }
        }
        static string Hash(SHA256 sha, string input)
        {
            var hash = string.Join("", sha.ComputeHash(Encoding.Default.GetBytes(input)).Select(x => x.ToString("x2")));
            return $"{hash} ({hash.Length})";
        }
    }
}
