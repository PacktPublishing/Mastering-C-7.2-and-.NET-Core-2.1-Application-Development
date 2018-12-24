using System;
using Serilog;

namespace BasicObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            var o = new SimpleObserver<string>();
            o.OnNext("first");
            o.OnNext("second");
            o.OnNext("third");
            o.OnCompleted();
        }
    }
}
