using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerDecleration
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            // Declare an integer variable
            int age = 18;

            // Declare a pointer to the integer
            int* ptrAge = &age;

            //Print the value of the variable
            Console.WriteLine($"The age is {*ptrAge}");

            //Print the value of the pointer
            Console.WriteLine($"The address is {(int)ptrAge}");

            Console.ReadLine();
        }
    }
}
