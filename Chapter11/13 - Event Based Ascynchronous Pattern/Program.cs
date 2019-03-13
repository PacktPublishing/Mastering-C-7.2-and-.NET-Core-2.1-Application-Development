using System;
using System.Net;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var wc = new WebClient();
            wc.DownloadStringAsync(new Uri("https://www.packtpub.com"));
            // Wire up the event handler
            wc.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) =>
            {
                Log.Information(e.Result);
            };
            Console.Read();
        }
    }
}
