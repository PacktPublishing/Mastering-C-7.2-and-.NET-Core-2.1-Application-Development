using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace MD5Salt
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var firstSalt = new byte[8];
            var secondSalt = new byte[8];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(firstSalt);
                rng.GetBytes(secondSalt);

                using (var md5 = MD5.Create())
                {
                    Log.Information("The hash for {input} is {hash}", "password", Hash(md5, firstSalt, "password"));
                    Log.Information("The hash for {input} is {hash}", "password", Hash(md5, secondSalt, "password"));
                }
            }
        }
        static string Hash(MD5 md5, byte[] salt, string input)
        {
            var password = $"{input}{Encoding.Default.GetString(salt)}";
            return string.Join("", md5.ComputeHash(Encoding.Default.GetBytes(password)).Select(x => x.ToString("x2")));
        }
    }
}
