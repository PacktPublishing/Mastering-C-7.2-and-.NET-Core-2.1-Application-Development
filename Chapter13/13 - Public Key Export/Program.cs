using System;
using System.IO;
using System.Security.Cryptography;
using Serilog;

namespace PublicKeyExport
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var rsa = new RSACryptoServiceProvider())
            {
                // Get the file path to store the keys
                var publicKeyPath = Path.Combine(Path.GetTempPath(), "PublicKey.xml");
                var publicAndPrivateKeyPath = Path.Combine(Path.GetTempPath(), "AllKeys.xml");
                // Save the keys to disk
                File.WriteAllText(publicKeyPath, rsa.ToXmlString(includePrivateParameters: false));
                File.WriteAllText(publicAndPrivateKeyPath, rsa.ToXmlString(includePrivateParameters: true));
                Log.Information("Public Key was saved to {path}", publicKeyPath);
                Log.Information("Public & Private Keys were saved to {path}", publicAndPrivateKeyPath);
            }
        }
    }
}
