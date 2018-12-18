using System;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Serilog;

namespace ObservableDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
              .Enrich.WithThreadId()
              .WriteTo.Console(outputTemplate: "{Timestamp:HH:mm} [{Level:u3}] <Thread: {ThreadId}> {Message}{NewLine}")
              .CreateLogger();

            Log.Information("Starting");
            var ob = Observable.Create<string>(
                o =>
                {
                    o.OnNext("Jane");
                    o.OnNext("Mary");
                    o.OnNext("Lucy");
                    o.OnCompleted();
                    Log.Information("Publishing Completed");
                    return Disposable.Empty;
                });

            ob.Subscribe(
                str => Log.Information("Received name {str}", str),
                () => Log.Information("Subscription Completed")
            );
            Log.Information("Subscribed");
            Console.Read();
        }
    }
}
