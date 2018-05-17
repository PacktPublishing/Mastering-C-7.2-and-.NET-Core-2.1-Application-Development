using System;

namespace ValueTupleLimits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the ValueTuple
            var numbers = (One: 1, Two: 2, Three: 3, Four: 4, Five: 5,
                Six: 6, Seven: 7, Eight: 8, Nine: 9, Ten: 10);
            
            // Print the tenth item
            Console.WriteLine(numbers.Ten);
        }
    }
}
