using System;
using System.Drawing;

namespace InModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var origin = new Point(0, 0);
            var target = new Point(4, 4);

            Console.WriteLine(CalculateDistance(origin, target));
            Console.Read();
        }
        private static double CalculateDistance(in Point first, in Point second)
        {
            // Attempting to modoify this causes a compiler error
            //first.Y = 0;

            double xDifferential = first.X - second.X;
            double yDifferential = first.Y - second.Y;

            return Math.Sqrt(xDifferential * xDifferential + yDifferential * yDifferential);
        }
    }
}