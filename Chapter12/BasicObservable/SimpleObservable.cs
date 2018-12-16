using System;
using System.Reactive.Disposables;

namespace BasicObservable
{
    public class SimpleObservable : IObservable<string>
    {
        public IDisposable Subscribe(IObserver<string> observer)
        {
            observer.OnNext("John");
            observer.OnNext("Mary");
            observer.OnNext("Jack");
            observer.OnNext("Jill");
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
}
