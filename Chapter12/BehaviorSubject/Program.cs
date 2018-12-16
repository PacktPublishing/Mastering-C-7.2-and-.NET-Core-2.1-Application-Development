using System;
using System.Reactive.Subjects;

namespace BehaviorSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new BehaviorSubject<string>("[Blank]");
            //Register the subscription
            PrintNames(subject);
            //Add items
            subject.OnNext("John");
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Console.WriteLine($"{val} has been added"));
        }
    }
}
