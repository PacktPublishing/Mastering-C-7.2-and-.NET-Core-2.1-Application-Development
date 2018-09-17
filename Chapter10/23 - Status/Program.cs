using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
            });
            Console.WriteLine($"State is {thread.ThreadState}");
            thread.Start();
            Console.WriteLine($"State is {thread.ThreadState}");
            thread.Join();
            Console.WriteLine($"State is {thread.ThreadState}");
        }
    }
}
