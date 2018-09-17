using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() => Console.WriteLine($"Hello from thread {Thread.CurrentThread.Name}"));
            thread.Name = "MyThreadName";
            thread.Start();
            thread.Join();
        }
    }
}
