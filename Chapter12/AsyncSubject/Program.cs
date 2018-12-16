using System;
using System.Reactive.Subjects;

namespace AsyncSubject
{
    class Program
    {
        static void Main(string[] args)
        {
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
            seq.Subscribe(val => Console.WriteLine($"{val} has been added"));
        }
    }
}
