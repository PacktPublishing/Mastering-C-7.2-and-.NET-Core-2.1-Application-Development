using System;
using System.Reactive.Subjects;
using Serilog;

namespace BehaviorSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var subject = new BehaviorSubject<string>("[Blank]");
            //Register the subscription
            PrintNames(subject);
            //Add the first item
            subject.OnNext("John");
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Log.Information("{val} has been added", val));
        }
    }
}
