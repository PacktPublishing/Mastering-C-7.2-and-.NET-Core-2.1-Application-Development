using System;
using Serilog;

namespace BasicObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            var observer = new SimpleObservable();
            var sequence = new SimpleObserver<string>();
            observer.Subscribe(sequence);
        }
    }
}
