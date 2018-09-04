using System;
namespace AirportDI
{
    public class SolarEngine : IEngine
    {
        public void Start() => Console.WriteLine("Turbines firing ...");
    }
}