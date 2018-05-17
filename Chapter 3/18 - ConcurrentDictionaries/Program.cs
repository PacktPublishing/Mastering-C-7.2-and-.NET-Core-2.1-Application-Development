using System;
using System.Collections.Concurrent;

namespace ConcurrentDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var cd = new ConcurrentDictionary<string, int>();
            // OK
            Console.WriteLine($"Adding Mary should be true: {cd.TryAdd("Mary", 30)}");
            // Fail: key in use
            Console.WriteLine($"Adding Mary should return false: {cd.TryAdd("Mary", 35)}");
            // OK to change Mary's age ..
            Console.WriteLine($"Updating Mary should succeed: {!cd.TryUpdate("Mary", 30, 35)}");
            // Fail: expected value is different
            Console.WriteLine($"Updating Mary should return false: {cd.TryUpdate("Mary", 20, 18)}");
            // OK to get Mary's age
            int age = 0;
            var result = cd.TryRemove("Mary", out age);
            Console.WriteLine($"Should have gotten Mary's age {age} return true: {result}");
        }
    }
}
