using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = Process.GetCurrentProcess().Threads;
            foreach (ProcessThread thread in threads)
                Console.WriteLine($"{thread.Id} started at {thread.StartTime} at {thread.StartAddress}");
        }
    }
}
