using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            var cq = new ConcurrentQueue<int>();

            for (int i = 0; i < 5_000; i++)
                cq.Enqueue(i);

            int total = 0;

            Action sum = () =>
            {
                int localSum = 0;
                int value;
                while (cq.TryDequeue(out value))
                    localSum += value;

                // Do thread-safe atomic increment to the shared sum
                Interlocked.Add(ref total, localSum);
            };

            // Run the action in four threads
            Parallel.Invoke(sum, sum, sum, sum);
            Console.WriteLine($"The sum is {total:#,0}");
        }
    }
}
