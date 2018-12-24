using System;
using System.Reactive.Subjects;
using Serilog;

namespace AsyncSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var subject = new AsyncSubject<string>();
            //Add items
            subject.OnNext("John");
            subject.OnNext("Mary");
            subject.OnNext("Jane");
            //Register the subscription
            PrintNames(subject);
            //You must complete to obtain the published value
            subject.OnCompleted();
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Log.Information("{val} has been added",val));
        }
    }
}
