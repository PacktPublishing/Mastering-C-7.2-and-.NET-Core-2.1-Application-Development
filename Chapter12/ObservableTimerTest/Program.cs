using System;
using System.Reactive.Linq;

namespace ObservableTimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start after 5 seconds and publish every five seconds
            var obs = Observable.Timer(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));

            Console.WriteLine($"{DateTime.Now:hh:mm ss}");
            
            using (obs.Subscribe(x => Console.WriteLine($"Produced item #{x} : {DateTime.Now:hh:mm ss}")))
            {
                Console.ReadLine();
            }
        }
    }
}
