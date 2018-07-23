using System;
namespace AirportDI
{
    public class JetEngine : IEngine
    {
        public void Start() => Console.WriteLine("Jet firing ...");
    }
}
