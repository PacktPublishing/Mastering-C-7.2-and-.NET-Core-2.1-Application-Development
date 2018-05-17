using System;
using NodaTime;

namespace Build20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! {SystemClock.Instance.GetCurrentInstant()}");
        }
    }
}
