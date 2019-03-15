using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace RSAEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var rsa = new RSACryptoServiceProvider())
            {
                // Get the file path to store the keys
                var keysPath = Path.Combine(Path.GetTempPath(), "keys.xml");
                // Get the file path to store encrypted data
                var encryptedDataPath = Path.Combine(Path.GetTempPath(), "Encrypted.bin");
                // Save the public and private keys to disk
                File.WriteAllText(keysPath, rsa.ToXmlString(true));
                // Now encrypt our custom text
                byte[] encryptedData = rsa.Encrypt(Encoding.Default.GetBytes("This is a test to encrypt"), true);
                // Write this text to screen
                Log.Information("The encrypted text is {text}", Encoding.Default.GetString(encryptedData));
                // Save the encrypted data to file
                File.WriteAllBytes(encryptedDataPath, encryptedData);
                Log.Information("Keys were saved to {path}", keysPath);
                Log.Information("Encrypted data was saved to {path}", encryptedDataPath);
            }
        }
    }
}
