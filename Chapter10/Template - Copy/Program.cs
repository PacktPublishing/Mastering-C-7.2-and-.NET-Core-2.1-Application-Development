using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The current thread is :{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"The current process has {Process.GetCurrentProcess().Threads.Count} threads");
            Console.Read();
        }
    }
}
