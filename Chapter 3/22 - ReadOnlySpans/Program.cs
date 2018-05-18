using System;

namespace ReadOnlySpans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a string
            var str = "The Quick Brown Fox";
            // Obtain a read only span
            var fifthLetter = str.AsSpan().Slice(start: 4, length: 1);
            // Check that the fifth letter is Q
            Console.WriteLine(fifthLetter[0]);
            // This raises a compile error
            //fifthLetter[0]='q';
        }
    }
}
