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
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello from the parent");

                var detached = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Hello from detached task");
                });

                var child = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Hello from child");
                }, TaskCreationOptions.AttachedToParent);
            });

            parent.Wait();
            Console.WriteLine("Completed");
        }
    }
}
