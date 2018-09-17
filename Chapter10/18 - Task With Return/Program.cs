using System;
using System.Threading;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Factory.StartNew<string>(GetIP);
            Console.WriteLine(task.Result);
        }
        static string GetIP()
        {
            var client = new HttpClient();
            return client.GetStringAsync("https://api.ipify.org").Result;
        }
    }
}
