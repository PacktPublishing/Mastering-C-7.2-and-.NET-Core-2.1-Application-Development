using System;
using System.Collections.Generic;

namespace HashSetDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<string>();

            hs.Add("Mary");
            hs.Add("John");
            hs.Add("Mary");
            hs.Add("Jack");

            Console.WriteLine($"The hashset has {hs.Count} items");
            
        }
    }
}
