using System;
using System.Reactive.Subjects;

namespace Replay
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new ReplaySubject<string>();
            //Add items
            subject.OnNext("John");
            subject.OnNext("Mary");
            subject.OnNext("Jane");
            //Register the subscription
            PrintNames(subject);
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Console.WriteLine($"{val} has been added"));
        }
    }
}
