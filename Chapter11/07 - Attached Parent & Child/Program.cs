using System;
using System.Threading;
using System.Threading.Tasks;
using Serilog;

namespace Attached_Parent___Child
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var parent = Task.Factory.StartNew(() =>
            {
                Log.Information("Parent started ...");
                var child = Task.Factory.StartNew(() =>
                {
                    Log.Information("Attached child started ...");
                    Thread.SpinWait(TimeSpan.FromSeconds(5).Seconds);
                    Log.Information("Attached child completed ...");
                }, TaskCreationOptions.AttachedToParent);
            });
            parent.Wait();
            Log.Information("Parent completed ...");
        }
    }
}