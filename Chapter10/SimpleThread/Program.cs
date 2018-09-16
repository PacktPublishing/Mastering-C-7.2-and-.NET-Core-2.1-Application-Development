using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Thread(() => Console.WriteLine("Hello from the first child"));
            first.Start();
            var second = new Thread(() => Console.WriteLine("Hello from the second child"));
            second.Start();
            first.Join();
            second.Join();
            Console.WriteLine("The parent waited for the children");
        }
    }
}
