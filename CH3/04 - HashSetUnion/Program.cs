using System;
using System.Collections.Generic;

namespace HashSetUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<string>();

            // Add items the traditional way

            hs.Add("Mary");
            hs.Add("Had A");

            Console.WriteLine($"The hashset has {hs.Count} items");

            // create a list
            var list = new List<string>() { "Little", "Lamb" };
            // create an array
            var array = new string[] { "White", "As", "Snow" };
            
            // Join the list items to the hashset
            hs.UnionWith(list);

            Console.WriteLine($"The hashset has {hs.Count} items");

            // Join the array items to the hashset
            hs.UnionWith(array);

            Console.WriteLine($"The hashset has {hs.Count} items");
        }
    }
}
