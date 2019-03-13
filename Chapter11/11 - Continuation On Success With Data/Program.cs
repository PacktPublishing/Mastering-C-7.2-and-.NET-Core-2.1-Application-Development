using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Task.Factory.StartNew<DateTime>(() => DateTime.Now)
            .ContinueWith(previous =>
            {
                Log.Information("The time from the previous task was {time}", previous.Result);
            }).Wait();
        }
    }
}
