using System;

namespace BasicObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new SimpleObserver<string>();
            o.OnNext("first");
            o.OnNext("second");
            o.OnNext("third");
            o.OnCompleted();
        }
    }
}
