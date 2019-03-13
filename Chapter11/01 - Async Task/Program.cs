using System;
using System.Net.Http;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var client = new HttpClient();
            var resultTask = client.GetStringAsync("https://www.packtpub.com");
            Console.WriteLine("Performing other operations...");
            //Now obtain the resu;t
            Log.Information(resultTask.Result);
        }
    }
}
