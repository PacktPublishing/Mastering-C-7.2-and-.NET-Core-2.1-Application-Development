using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var task = DownloadHomePages();
            Log.Information(task.Result);
        }
        static async Task<string> DownloadHomePages()
        {
            var client = new HttpClient();
            var bag = new ConcurrentBag<string>();
            var sites = new string[] {"https://www.packtpub.com","https://www.amazon.com","https://www.google.com",
    "https://www.apple.com","https://www.salesforce.com","http://www.microsoft.com","http://www.oracle.com",
    "https://www.ibm.com","https://www.redhat.com","https://www.ubuntu.com","https://www.adobe.com",
    "https://www.autodesk.com","https://www.embarcadero.com"};

            foreach (var site in sites)
            {
                bag.Add(await client.GetStringAsync(site));
            }
            var sb = new StringBuilder();
            foreach (var str in bag.ToArray())
                sb.AppendLine(str);
            return sb.ToString();
        }
    }
}
