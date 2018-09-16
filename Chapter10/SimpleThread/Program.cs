using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => { Console.WriteLine("Starting a thread"); Thread.SpinWait(1000); });
            Console.WriteLine($"Thread is background? {thread.IsBackground}");
        }
    }
}
