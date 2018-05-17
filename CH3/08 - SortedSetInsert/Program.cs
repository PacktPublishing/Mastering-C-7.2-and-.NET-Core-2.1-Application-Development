using System;
using System.Collections.Generic;

namespace SortedSetInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = new SortedSet<string>();
            // Add items to the sorted set
            ss.Add("Xylophone");
            ss.Add("Trumpet");
            ss.Add("Drum");
            ss.Add("Recorder");

            foreach (var item in ss)
                Console.WriteLine(item);
        }
    }
}
