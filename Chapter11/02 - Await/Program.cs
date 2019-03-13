using System;
using System.Net.Http;
using System.Threading.Tasks;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var client = new HttpClient();
            var homePage = await client.GetStringAsync("https://www.packtpub.com");
            Log.Information(homePage);
        }
    }
}
