using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(Greet));
            t.Start();
            Console.WriteLine($"Hello from main: {Thread.CurrentThread.ManagedThreadId} ");
        }
        static void Greet()
        {
            Console.WriteLine($"Hello from thread: {Thread.CurrentThread.ManagedThreadId} ");
        }
    }
}
