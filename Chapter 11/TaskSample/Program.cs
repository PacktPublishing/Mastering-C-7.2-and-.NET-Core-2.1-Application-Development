using System;
using System.Net.Http;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var resultTask = client.GetStringAsync("https://www.packtpub.com");
            Console.WriteLine("Performing other operations...");
            //Now obtain the resu;t
            Console.WriteLine(resultTask.Result);
        }
    }
}
