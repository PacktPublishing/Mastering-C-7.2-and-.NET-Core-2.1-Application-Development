using System;
using System.Threading.Tasks;
using Serilog;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var taskWork = Task.Factory.StartNew(() => throw new ApplicationException("Error!"));

            var failure = taskWork.ContinueWith(prior =>
            {
                Log.Error("I failed: {error}", prior.Exception.InnerException.GetType().Name);
            }, TaskContinuationOptions.OnlyOnFaulted);

            var success = taskWork.ContinueWith(prior =>
            {
                Log.Information("I succeeded!");
            }, TaskContinuationOptions.NotOnFaulted);
            Console.ReadLine();
        }
    }
}
