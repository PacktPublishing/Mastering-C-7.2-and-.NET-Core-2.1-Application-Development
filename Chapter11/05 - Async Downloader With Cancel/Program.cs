using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            try
            {
                var result = await DownloadHomePages();
                foreach (var item in result)
                    Log.Information(item);
            }
            catch (AggregateException ex)
            {
                Log.Error(ex.Flatten().InnerException.Message);
            }
        }
        static Task<List<string>> DownloadHomePages()
        {
            var client = new HttpClient();
            var bag = new List<string>();
            var source = new CancellationTokenSource();
            var token = source.Token;
            var sites = new string[] {"https://www.packtpub.com","https://www.amazon.com","https://www.google.com",
    "https://www.apple.com","https://www.salesforce.com","http://www.microsoft.com","http://www.oracle.com",
    "https://www.ibm.com","https://www.redhat.com","https://www.ubuntu.com","https://www.adobe.com",
    "https://www.autodesk.com","https://www.embarcadero.com"};
            var task = Task.Factory.StartNew(() =>
             {
                 foreach (var site in sites)
                 {
                     Log.Information("Processing {site}", site);
                     token.ThrowIfCancellationRequested();
                     bag.Add(client.GetStringAsync(site).Result);
                 }
             }, token);
            // Cancel after 3 seconds
            source.CancelAfter(TimeSpan.FromSeconds(3));
            task.Wait();
            return Task.FromResult(bag);
        }
    }
}
