using System;
using System.Reactive.Linq;

namespace Observables
{
    class Program
    {
        static void Main(string[] args)
        {
            // This returns a single, typed element
            var nameReturn = Observable.Return<string>("Jane");

            // This returns a sequence with no elements
            var emptyReturn = Observable.Empty<string>();

            // This returns a sequence whose observers will never be called
            var neverReturn = Observable.Never<string>();

            // This terminates with a typed exception
            var throwReturn  = Observable.Throw<string>(new DivideByZeroException());
        }
    }
}
