using System;
using System.Reactive.Linq;
using Serilog;

namespace ObservableTimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            // Start after 5 seconds and publish every five seconds
            var obs = Observable.Timer(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));

            Log.Information("Current time: {time:hh:mm ss}", DateTime.Now);

            using (obs.Subscribe(x => Log.Information("Produced item at {item:hh:mm ss}", DateTime.Now)))
            {
                Console.ReadLine();
            }
        }
    }
}
