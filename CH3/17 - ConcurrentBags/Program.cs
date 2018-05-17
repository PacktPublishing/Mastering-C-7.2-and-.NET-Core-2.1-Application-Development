using System;
using System.Collections.Concurrent;

namespace ConcurrentBags
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new ConcurrentBag<string>();
            cb.Add("John");
            cb.Add("Jane");
            cb.Add("Jack");

            var name = "";
            while (!cb.IsEmpty)
            {
                if (cb.TryTake(out name))
                    Console.WriteLine($"{name} has been retrieved");
                else
                    Console.WriteLine("Failed! Bag is empty");
            }
        }
    }
}
