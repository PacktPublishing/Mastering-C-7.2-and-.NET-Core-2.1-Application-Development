using System;
using System.Security.Cryptography;
using Serilog;
namespace AESCusomKeyIV
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var aes = Aes.Create())
            {
                // Declare storage for the Key and and Initialization Vector
                var key = new byte[16];
                var iv = new byte[16];
                // Use a cryptographic random number generator to generate the keys
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(key);
                    rng.GetBytes(iv);
                }
                // Assign the key and iv
                aes.Key = key;
                aes.IV = iv;
            }
        }
    }
}
