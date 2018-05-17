using System;
using System.Collections.Generic;

namespace DictionaryAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, int>();
            people.Add("Mary", 18);
            people.Add("Jane", 25);
            people.Add("Martha", 35);

            Console.WriteLine($"There are {people.Count} items in the dictionary");

            // Now add an item using the index syntax

            people["Elizabeth"] = 40;

            Console.WriteLine($"There are {people.Count} items in the dictionary");
        }
    }
}
