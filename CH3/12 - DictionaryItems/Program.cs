using System;
using System.Collections.Generic;

namespace DictionaryItems
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobbies = new Dictionary<string, string>();
            hobbies.Add("James", "Fishing");
            hobbies.Add("Arnold", "Driving");
            hobbies.Add("Bill", "Archery");

            // This will throw a key not found error
            //Console.Write(hobbies["Jack"]);

            // This is a safer way to do it
            if (hobbies.ContainsKey("Jack"))
                Console.Write(hobbies["Jack"]);

            // Or this way
            string result;
            hobbies.TryGetValue("Jack", out result);

            // Iterate and print each person and their hobby
            foreach (var item in hobbies)
                Console.WriteLine($"The hobby for {item.Key} is {item.Value}");
        }
    }
}
