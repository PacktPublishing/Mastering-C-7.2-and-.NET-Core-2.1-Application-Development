using System;
using System.Reactive.Subjects;
using Serilog;

namespace RelayCacheCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var subject = new ReplaySubject<string>(2);
            //Add items. John is never published
            subject.OnNext("John");
            subject.OnNext("Mary");
            subject.OnNext("Jane");
            //Register the subscription
            PrintNames(subject);
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Log.Information("{val} has been added", val));
        }
    }
}
