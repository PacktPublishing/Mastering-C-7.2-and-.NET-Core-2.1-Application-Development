using System;

namespace AirportDI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jet plane
            var jetEngine = new JetEngine();
            var fokker = new Plane(jetEngine);
            fokker.Start();

            // Create a Propeller plane
            var propellerEngine = new PropellerEngine();
            var cessna = new Plane(propellerEngine);
            cessna.Start();
        }
    }
}
