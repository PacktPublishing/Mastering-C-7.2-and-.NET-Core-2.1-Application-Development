using System;
using System.Reactive;
using System.Reactive.Linq;
using Serilog;

namespace ObservableRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var topFive = Observable.Range(1, 5);
            topFive.Subscribe(val => Log.Information("{val} was published", val),
                () => Log.Information("Completed"));
        }
    }
}
