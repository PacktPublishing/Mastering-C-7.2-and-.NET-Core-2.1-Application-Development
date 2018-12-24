using System;
using System.Reactive.Linq;
using Serilog;

namespace ObservableIntervalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            // Publish every second
            var obs = Observable.Interval(TimeSpan.FromSeconds(1));

            using (obs.Subscribe(x => Log.Information("Produced item #{item}", x)))
            {
                Console.ReadLine();
            }
        }
    }
}
