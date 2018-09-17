using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };
            Parallel.Invoke(options,
                () => Console.WriteLine(client.GetStringAsync("https://www.amazon.com").Result),
                () => Console.WriteLine(client.GetStringAsync("https://www.google.com").Result),
                () => Console.WriteLine(client.GetStringAsync("https://www.apple.com").Result),
                () => Console.WriteLine(client.GetStringAsync("https://www.microsoft.com").Result));
        }
    }
}
