using System;
using System.Collections.Generic;

namespace HashSetSymmetricExceptWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var goldMedalists = new string[] { "Usain", "Asafa", "Donovan" };
            var silverMedalists = new string[] { "Nesta", "Shawn", "Justin", "Usain" };

            var hs = new HashSet<string>(goldMedalists);

            // Return athletes with only one medal

            hs.SymmetricExceptWith(silverMedalists);

            foreach (var item in hs)
                Console.WriteLine($"{item} ");

        }
    }
}
