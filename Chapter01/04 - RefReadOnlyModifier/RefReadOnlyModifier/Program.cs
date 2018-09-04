using System;
using System.Drawing;

namespace RefReadOnlyModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a point object
            var samplePoint = new Point(10, 20);
            // Obtain a readonly reference to the origin
            ref readonly Point Origin = ref samplePoint;
            // Print both to screen
            Console.WriteLine(samplePoint);
            Console.WriteLine(Origin);
            // We can change the sample point
            samplePoint.X++;
            // But the Origin gives a compiler error if we try to change it
            //Origin.X++;
            Console.ReadLine();
        }
    }
}
