using System;
using System.Reactive.Subjects;
using Serilog;

namespace NativeSubscription
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var subject = new Subject<string>();
            //Register the subscription
            PrintNames(subject);
            //Add items
            subject.OnNext("John");
            subject.OnNext("Mary");
            subject.OnNext("Jane");
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Log.Information("{val} has been added", val));
        }
    }
}
