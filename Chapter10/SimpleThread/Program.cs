using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var tMary = new Thread(Program.Greet);
            tMary.Start("Mary");
        }
        static void Greet(object Name)
        {
            Console.WriteLine($"Hello {Name} from {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
