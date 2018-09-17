using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Starting ...");
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("Done");
            });
            task.Wait();
            Console.WriteLine("Completed");
        }
    }
}
