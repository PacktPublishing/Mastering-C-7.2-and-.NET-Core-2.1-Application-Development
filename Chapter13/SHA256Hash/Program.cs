using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace SHA256Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var sha = SHA256.Create())
            {
                Log.Information("The hash for {input1} is {hash}", "12345", Hash(sha, "12345"));
                Log.Information("The hash for {input2} is {hash}", "12346", Hash(sha, "12346"));
            }
        }
        static string Hash(SHA256 sha, string input)
        {
            return string.Join("", sha.ComputeHash(Encoding.Default.GetBytes(input)).SelectMany(x => x.ToString("x2")));
        }
    }
}
