using System;
using System.Threading;
using System.Diagnostics;
namespace SimpleThread
{
    class Program
    {
        public static void Main()
        {
            using (var token = new CancellationTokenSource())
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Greet), token.Token);
                Thread.Sleep(TimeSpan.FromSeconds(5));
                token.Cancel();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("Completed");
            }
        }
        static void Greet(object o)
        {
            var token = (CancellationToken)o;
            for (int i = 0; i < 5_000; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine($"Cancel greeting on {i++}");
                    break;
                }
                Thread.SpinWait((int)TimeSpan.FromMinutes(1).TotalMilliseconds);
            }
        }
    }
}
