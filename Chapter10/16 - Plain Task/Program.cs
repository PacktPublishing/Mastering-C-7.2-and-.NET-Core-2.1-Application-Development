using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(Greet);
            task.Start();
            Console.WriteLine("Continuing with other work");
            Console.Read();
        }
        static void Greet()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("Greetings");
        }
    }
}
