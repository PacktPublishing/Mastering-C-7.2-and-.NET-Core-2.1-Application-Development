using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var result = await DownloadHomePages();
            Console.WriteLine(result);
        }
        static Task<List<string>> DownloadHomePages()
        {
            var client = new HttpClient();
            var bag = new List<string>();
            var sites = new string[] {"https://www.packtpub.com","https://www.amazon.com","https://www.google.com",
    "https://www.apple.com","https://www.salesforce.com","http://www.microsoft.com","http://www.oracle.com",
    "https://www.ibm.com","https://www.redhat.com","https://www.ubuntu.com","https://www.adobe.com",
    "https://www.autodesk.com","https://www.embarcadero.com"};

            foreach (var site in sites)
            {
                bag.Add(client.GetStringAsync(site).Result);
            }
            return Task.FromResult(bag);
        }
    }
}
