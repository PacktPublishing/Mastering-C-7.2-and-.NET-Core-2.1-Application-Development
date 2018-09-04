using System;

namespace SpanStackAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allocate stack memory for 2 bytes
            Span<byte> flags = stackalloc byte[2];
            // Assign values
            flags[0] = 1;
            flags[1] = 100;
            // Verify the values
            Console.WriteLine($"Is Byte 0 = 1? {flags[0] == 1}");
            Console.WriteLine($"Is Byte 1 = 100? {flags[0] == 001}");
            Console.ReadLine();
        }
    }
}
