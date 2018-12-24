using System;
using Serilog;

namespace BasicObserver
{
    public class SimpleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Log.Information("Sequence received {0}", value);
        }
        public void OnError(Exception error)
        {
            Log.Error("Sequence threw exception {0}", error.Message);
        }
        public void OnCompleted()
        {
            Log.Information("Sequence terminated");
        }
    }
}

