using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WindowsCompatibilityPack
{
    class Program
    {
        static void Main(string[] args)
        {
            var backupLocation = "";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Only do this on Windows, as Linux & MacOS don't support the registry
                using (var key = Registry.CurrentUser.OpenSubKey(@"Software\MyApp"))
                {
                    backupLocation = (string)key?.GetValue("BackupLocation");
                }
                // If could not get it from the registry, assume the current location
                if (string.IsNullOrEmpty(backupLocation))
                    backupLocation = Path.Combine(Environment.CurrentDirectory, $"BackupLocation-Win");
            }
            else
            {
                // This is runing under Linux or OSX
                backupLocation = Path.Combine(Environment.CurrentDirectory, "BackupLocation-XNix");
            }
            Console.WriteLine($"The backup location is {backupLocation}");
        }
    }
}
