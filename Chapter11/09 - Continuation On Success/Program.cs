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
            var firstTask = Task.Factory.StartNew(() =>
            {
                Log.Information("I am running first");
                Thread.Sleep(TimeSpan.FromSeconds(5));
            });
            var secondTask = firstTask.ContinueWith(previous =>
            {
                Log.Information("I am running second");
            });
            firstTask.Wait();
        }
    }
}
