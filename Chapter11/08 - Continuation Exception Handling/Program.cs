using System;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskWork = Task.Factory.StartNew(() => throw new ApplicationException("Error!"));

            var failure = taskWork.ContinueWith(prior =>
            {
                Console.WriteLine($"I failed: {prior.Exception.InnerException.GetType().Name}");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var success = taskWork.ContinueWith(prior =>
            {
               Console.WriteLine($"I failed: {prior.Exception.InnerException.GetType().Name}");
            }, TaskContinuationOptions.NotOnFaulted);
            Console.ReadLine();
        }
    }
}
