using System;
using System.Reactive.Subjects;

namespace NativeSubscription
{
    class Program
    {
        static void Main(string[] args)
        {
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
            seq.Subscribe(val => Console.WriteLine($"{val} has been added"));
        }
    }
}
