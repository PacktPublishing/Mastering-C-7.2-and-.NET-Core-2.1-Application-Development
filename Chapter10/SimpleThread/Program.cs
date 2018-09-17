using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var low = new Thread(Lower);
            var high = new Thread(Higher);
            high.Priority= ThreadPriority.Highest;
            low.Start();
            high.Start();
        }
        static void Lower() => Console.WriteLine($"Hello. My priority is {Thread.CurrentThread.Priority}");
        static void Higher() => Console.WriteLine($"Hello. My priority is {Thread.CurrentThread.Priority}");
    }
}
