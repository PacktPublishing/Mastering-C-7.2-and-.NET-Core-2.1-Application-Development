using System;
using System.Net;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var wc = new WebClient();
            wc.DownloadStringAsync(new Uri("https://www.packtpub.com"));
            // Wire up the event handler
            wc.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) =>
            {
                Console.WriteLine(e.Result);
            };
        }
    }
}
