using System;
using System.Threading;
using System.Threading.Tasks;

namespace Attached_Parent___Child
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
                    Console.WriteLine("Attached child started ...");
                    Thread.SpinWait(TimeSpan.FromSeconds(5).Seconds);
                    Console.WriteLine("Attached child completed ...");
                }, TaskCreationOptions.AttachedToParent);
            });
            parent.Wait();
            Console.WriteLine("Parent completed ...");
        }
    }
}

