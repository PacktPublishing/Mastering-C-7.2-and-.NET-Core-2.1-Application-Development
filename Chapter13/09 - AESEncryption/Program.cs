using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace AESEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var aes = Aes.Create())
            {
                byte[] encryptedData;
                // Declare storage for the Key and and Initialization Vector
                byte[] key, iv;
                aes.GenerateIV();
                aes.GenerateKey();
                // Get the generated key and IV
                key = aes.Key; iv = aes.IV;
                // Create an encryptor to carry out the encryption
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                // Carry out the encryption
                using (var ms = new MemoryStream())
                {
                    using (var encrypt = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        encrypt.Write(Encoding.Default.GetBytes("Encrypt this please!"));
                    }
                    encryptedData = ms.ToArray();
                    // Write the encrypted data
                    Log.Information("Encrypted data is {data}", Encoding.Default.GetString(encryptedData));
                }
                // Now create a decryptor
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                // Carry out the decryption
                using (var ms = new MemoryStream(encryptedData))
                {
                    using (var decrypt = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(decrypt))
                        {
                            Log.Information("Decrypted text is {text}", reader.ReadToEnd());
                        }
                    }
                }
            }
        }
    }
}
