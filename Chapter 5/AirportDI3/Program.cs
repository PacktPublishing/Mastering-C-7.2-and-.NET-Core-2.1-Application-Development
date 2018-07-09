using System;
namespace AirportDI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jet plane
            var jetEngine = new JetEngine();
            var fokker = new Plane();
            fokker.Start(jetEngine);
        }
    }
}
