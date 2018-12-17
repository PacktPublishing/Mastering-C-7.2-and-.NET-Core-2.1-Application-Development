using System;
using System.Reactive.Linq;

namespace Observables
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameReturn = Observable.Return<string>("Jane");

            var emptyReturn = Observable.Empty<string>();

            var neverReturn = Observable.Never<string>();

            var throwReturn  = Observable.Throw<string>(new DivideByZeroException());
        }
    }
}
