using System;

namespace TupleMultiElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tuple with 10 elements
            var tup = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));
            // Print the items to verify
            Console.WriteLine(tup.Item1);
            Console.WriteLine("Skipping the rest ...");
            Console.WriteLine(tup.Item7);
            Console.WriteLine(tup.Rest.Item1.Item1);
            Console.WriteLine(tup.Rest.Item1.Item2);
            Console.WriteLine(tup.Rest.Item1.Item3);
        }
    }
}
