using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var james = new Tuple<string, int>("James", 40);

            var mary = Tuple.Create("Mary", 19);

            Console.WriteLine($"{james.Item1} is {james.Item2}");

            Console.WriteLine($"{mary.Item1} is {mary.Item2}");

        }
    }
}
