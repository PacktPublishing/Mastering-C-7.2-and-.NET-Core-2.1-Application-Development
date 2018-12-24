using System;
using System.Reactive.Linq;
using Serilog;

namespace ObservableTimerSingle
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            // Start after 5 seconds and publish once
            var obs = Observable.Timer(TimeSpan.FromSeconds(5));
            Log.Information("Current time {time:hh:mm ss}", DateTime.Now);
            using (obs.Subscribe(x => Log.Information("Produced item at {x:hh:mm ss}", DateTime.Now)))
            {
                Console.ReadLine();
            }
        }
    }
}
