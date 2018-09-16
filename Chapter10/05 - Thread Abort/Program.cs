using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        public static void Main()
        {
            var t = new Thread(Greet);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            t.Abort();
            Console.WriteLine("Completed");
        }
        static void Greet()
        {
            Thread.SpinWait((int)TimeSpan.FromMinutes(1).TotalMilliseconds);
            Console.WriteLine("This will never print");
        }
    }
}
