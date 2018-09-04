using System;

namespace StructPointers
{
    struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

    }
    unsafe class Program
    {
        static void Main(string[] args)
        {
            // Declare a point
            Point3D point;
            // Get a pointer to the point
            Point3D* pt = &point;

            pt->X = 0;
            pt->Y = 100;
            (*pt).Z = 200;

            // Print the values
            Console.WriteLine($"X is {pt->X}, Y is {pt->Y} and Z is {(*pt).Z}");

            Console.Read();
        }
    }
}
