using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace FileHashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            using (var sha = SHA256.Create())
            {
                Log.Information("The hash for the file is is {hash}", Hash(sha, File.OpenRead("test.txt")));
            }
        }
        static string Hash(SHA256 sha, Stream file)
        {
            return string.Join("", sha.ComputeHash(file).Select(x => x.ToString("x2")));
        }
    }
}
