using System;

namespace Spans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of integers
            var ages = new int[] { 18, 21, 25, 27, 30, 45, 40, 50 };
            // Get a span
            Span<int> spanAges = ages;
            
            // Modify the span
            spanAges[0] = 19;
            
            // Get a slice of the span - first 3 elements
            var first = spanAges.Slice(start: 0, length: 3);
            
            Console.WriteLine("First");
            foreach (var item in first)
                Console.WriteLine(item);
            
            // Get a slice of the span - last 3 elements
            
            var last = spanAges.Slice(5);
            Console.WriteLine("Last");
            foreach (var item in last)
                Console.WriteLine(item);
        }
    }
}
