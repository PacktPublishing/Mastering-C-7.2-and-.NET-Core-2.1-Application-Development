using System;

namespace BasicObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer = new SimpleObservable();
            var sequence = new SimpleObserver<string>();
            observer.Subscribe(sequence);
        }
    }
}
