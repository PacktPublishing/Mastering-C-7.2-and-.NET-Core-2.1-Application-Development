using System;
using System.Collections.Generic;

namespace SortedSetMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Sorted set of integers
            var ss = new SortedSet<int>();
            // Add items
            ss.Add(100);
            ss.Add(0);
            ss.Add(50);
            ss.Add(500);

            //Print the largest item
            Console.WriteLine($"Max is {ss.Max}");
            // Print the smallest item
            Console.WriteLine($"Min is {ss.Min}");
        }
    }
}
