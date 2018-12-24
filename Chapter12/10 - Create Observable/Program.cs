using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Timers;
using Serilog;

namespace CreateTestObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var ob = Observable.Create<string>(
            observer =>
            {
                var tim = new Timer();
                tim.Interval = TimeSpan.FromSeconds(5).TotalMilliseconds;
                // Publish clock ticks
                tim.Elapsed += (sender, eArgs) => observer.OnNext("Recevied event");
                // Attach the event hanlder
                tim.Elapsed += OnTimerElapsed;
                tim.Start();
                return tim;
            });

            var subscription = ob.Subscribe(val => Log.Information("{val} was published", val));
            Console.Read();
            subscription.Dispose();
        }
        private static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Log.Information("Clock tick: {time:hh:mm ss tt}", e.SignalTime);
        }
    }
}