using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using Serilog;

namespace ObservableGenerateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var obs = Observable.Generate('A',               // This is the initial state
                                    x => (char)(x) <= 'Z',   // This is the exit condition
                                    x => (char)(x + 1),      // This is the increment step
                                    x => (char)x,            // This is what to output
                                    Scheduler.Default);

            using (obs.Subscribe(x => Log.Information("Produced {val}", x)))
            {
                Console.ReadLine();
            }
        }
    }
}
