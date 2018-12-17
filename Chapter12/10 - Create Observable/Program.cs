using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Timers;

namespace CreateTestObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = Observable.Create<string>(
            observer =>
            {
                var tim = new Timer();
                tim.Interval = TimeSpan.FromSeconds(5).TotalMilliseconds;
                // Publush clock ticks
                tim.Elapsed += (sender, eArgs) => observer.OnNext("Recevied event");
                // Attach the event halder
                tim.Elapsed += OnTimerElapsed;
                tim.Start();
                return tim;
            });

            var subscription = ob.Subscribe(val => Console.WriteLine(val));
            Console.Read();
            subscription.Dispose();
        }
        private static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Clock tick: {e.SignalTime:hh:mm ss tt}");
        }
    }
}