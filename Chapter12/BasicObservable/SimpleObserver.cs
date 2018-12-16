using System;
namespace BasicObservable
{
    public class SimpleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Sequence received {0}", value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("Sequence threw exception {0}", error);
        }
        public void OnCompleted()
        {
            Console.WriteLine("Sequence terminated");
        }
    }
}