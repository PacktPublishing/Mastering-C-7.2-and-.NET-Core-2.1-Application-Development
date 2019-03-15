using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace RSADecryption
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
                // Load the public key
                rsa.FromXmlString(File.ReadAllText(keysPath));
                // Now decrypt the data in the file
                byte[] decryptedData = rsa.Decrypt(File.ReadAllBytes(encryptedDataPath), true);
                // Write this text to screen
                Log.Information("The decrypted text is {text}", Encoding.Default.GetString(decryptedData));
            }
        }
    }
}
