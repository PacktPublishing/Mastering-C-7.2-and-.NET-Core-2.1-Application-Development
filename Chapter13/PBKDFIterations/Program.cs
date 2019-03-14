using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace PBKDFIterations
{
    class Program
    {
         static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var sp = Stopwatch.StartNew();
            // Create a salt array of 8 bytes
            byte[] salt = new byte[8];
            // Create a random number generator
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            // Get the password into an array of bytes
            var password = Encoding.Default.GetBytes("password");
            // hash the password using 100,000 iterations
            var pbk = new Rfc2898DeriveBytes(password, salt, 100_000);
            var hash = pbk.GetBytes(16);
            Log.Information("Hashed password is {hash} after {time} ms",
                string.Join("", hash.SelectMany(x => x.ToString("x2"))), sp.Elapsed.TotalMilliseconds);
        }
    }
}
