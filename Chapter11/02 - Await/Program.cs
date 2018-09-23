using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var homePage = await client.GetStringAsync("https://www.packtpub.com");
            Console.WriteLine(homePage);
        }
    }
}
