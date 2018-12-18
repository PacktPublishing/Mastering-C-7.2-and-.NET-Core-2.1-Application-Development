using System;
using System.Reactive;
using System.Reactive.Linq;

namespace ObservableRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var topFive = Observable.Range(1, 5);
            topFive.Subscribe(val => Console.WriteLine(val),
                () => Console.WriteLine("Completed"));
        }
    }
}
