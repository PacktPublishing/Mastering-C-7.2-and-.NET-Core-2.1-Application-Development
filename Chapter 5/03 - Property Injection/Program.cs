using System;
namespace AirportDI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jet plane, the default
            var fokker = new Plane();
            fokker.Start();

            // Create a properller plane
            var cessna = new Plane();
            var propellerEngine = new PropellerEngine();
            cessna.Engine = propellerEngine;

            cessna.Start();
        }
    }
}
