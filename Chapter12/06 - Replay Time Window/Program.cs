﻿using System;
using System.Reactive.Subjects;
using System.Threading;
using Serilog;

namespace ReplayTimeWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            // Chache items for 3 seconds
            var subject = new ReplaySubject<string>(TimeSpan.FromSeconds(3));
            //Add items. John is never received as it times out
            subject.OnNext("John");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            subject.OnNext("Mary");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            subject.OnNext("Jane");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            //Register the subscription
            PrintNames(subject);
        }
        static void PrintNames(IObservable<string> seq)
        {
            seq.Subscribe(val => Log.Information("{val} has been added", val));
        }
    }
}
