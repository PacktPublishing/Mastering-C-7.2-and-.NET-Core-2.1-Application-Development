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
            var ob = Observable.Create<DateTime>(
            observer =>
            {
                var tim = new Timer();
                tim.Interval = TimeSpan.FromSeconds(5).TotalMilliseconds;
                // Publish clock ticks
                tim.Elapsed += (s, e) => observer.OnNext(e.SignalTime);
                tim.Start();
                return tim;
            });

            var subscription = ob.Subscribe(val => Log.Information("{val:hh:mm ss tt} was published", val));
            Console.Read();
            subscription.Dispose();
        }
    }
}