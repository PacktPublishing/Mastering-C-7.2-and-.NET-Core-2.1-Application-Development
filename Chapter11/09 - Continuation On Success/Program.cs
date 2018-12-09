using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("I am running first");
                Thread.Sleep(TimeSpan.FromSeconds(5));
            });
            var secondTask = firstTask.ContinueWith(previous =>
            {
                Console.WriteLine("I am running second");
            });
            firstTask.Wait();
        }
    }
}
