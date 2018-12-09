using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew<DateTime>(() => DateTime.Now)
            .ContinueWith(previous =>
            {
                Console.WriteLine($"The time from the previous task was {previous.Result}");
            }).Wait();
        }
    }
}
