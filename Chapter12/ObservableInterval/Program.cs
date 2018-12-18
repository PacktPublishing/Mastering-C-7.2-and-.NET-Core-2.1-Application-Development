using System;
using System.Reactive.Linq;

namespace ObservableIntervalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Publish every second
            var obs = Observable.Interval(TimeSpan.FromSeconds(1));

            using (obs.Subscribe(x => Console.WriteLine($"Produced item #{x}")))
            {
                Console.ReadLine();
            }
        }
    }
}
