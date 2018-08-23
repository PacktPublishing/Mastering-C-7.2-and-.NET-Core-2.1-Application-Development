using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SpanMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allocate memory to a pointer
            IntPtr ptr = Marshal.AllocHGlobal(1);
            try
            {
                // Declare a span
                Span<int> ages;
                // Allow usage of unsafe code
                unsafe
                {
                    // Allocate a span of size 1
                    ages = new Span<int>((int*)ptr, 1);
                }
                // Asssign a value
                ages[0] = 18;
                // Confirm allocaton using managed runtine
                var item = Marshal.ReadInt32(ptr);
                Console.WriteLine($"Is the assignment successful? {item == 18}");
            }
            finally
            {
                // Free memory
                Marshal.FreeHGlobal(ptr);
            }
            Console.ReadLine();
        }
    }
}
