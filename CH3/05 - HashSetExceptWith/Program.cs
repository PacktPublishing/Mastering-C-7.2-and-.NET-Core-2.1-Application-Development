using System;
using System.Collections.Generic;

namespace HashSetExceptWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var allStudents = new string[] { "Mary", "John", "Lewis", "Jane", "Anne" };
            var newStudents = new string[] { "John", "Jane" };

            // Create the hashset
            var hs = new HashSet<string>(allStudents);
            // Print all the students
            Console.WriteLine("ALL STUDENTS");
            foreach (var item in hs)
                Console.WriteLine($"{item} ");
            // Run the Except to only have non-new students
            hs.ExceptWith(newStudents);
           // Print all the non-new students
            Console.WriteLine("OLDER STUDENTS");
            foreach (var item in hs)
                Console.WriteLine($"{item} ");
        }
    }
}
