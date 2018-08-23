using System;
using System.Collections.Generic;

namespace HashSetRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<string>();
            hs.Add("Anne");
            hs.Add("Carol");
            hs.Add("Cynthia");
            hs.Add("Annabel");

            // Remove all items with a length less han 6

            var removedCount = hs.RemoveWhere(x => x.Length < 6);

            Console.WriteLine($"{removedCount} items where removed, leaving these:");

            foreach (var item in hs)
                Console.WriteLine(item);

        }
    }
}
