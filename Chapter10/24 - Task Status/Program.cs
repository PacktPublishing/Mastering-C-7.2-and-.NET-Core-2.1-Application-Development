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
            var task = new Task(() => Console.WriteLine("This is a task"));
            Console.WriteLine($"Task status is {task.Status}");
            task.Start();
            Console.WriteLine($"Task status is {task.Status}");
            task.Wait();
            Console.WriteLine($"Task status is {task.Status}");
        }
    }
}
