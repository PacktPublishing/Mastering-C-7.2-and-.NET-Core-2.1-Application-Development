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
            using (var sha = new SHA1CryptoServiceProvider())
            {
                Log.Information("The hash for {input1} is {hash}", "12345", Hash(sha, "12345"));
                Log.Information("The hash for {input2} is {hash}", "12346", Hash(sha, "12346"));
            }
        }
        static string Hash(SHA1 sha, string input)
        {
            return string.Join("", sha.ComputeHash(Encoding.Default.GetBytes(input)).SelectMany(x => x.ToString("x2")));
        }
    }
}
