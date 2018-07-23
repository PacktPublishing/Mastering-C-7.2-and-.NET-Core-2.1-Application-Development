using System;
namespace AirportDI
{
    public class PropellerEngine : IEngine
    {
        public void Start() => Console.WriteLine("Propeller spinning ...");
    }
}