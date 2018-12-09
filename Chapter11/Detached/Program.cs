using System;
using System.Threading;
using System.Threading.Tasks;

namespace Detached
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent started ...");

                var child = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Child started ... ");
                    Thread.SpinWait(TimeSpan.FromSeconds(5).Seconds);
                    Console.WriteLine("Child completed ...");
                });
            });

            parent.Wait();
            Console.WriteLine("Parent completed ...");
        }
    }
}
