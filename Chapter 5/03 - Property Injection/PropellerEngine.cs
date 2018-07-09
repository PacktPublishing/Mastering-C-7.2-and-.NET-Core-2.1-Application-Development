using System;
namespace AirportDI
{
    public class PropellerEngine : IEngine
    {
        public void Start() => Console.WriteLine("Properller spinning ...");
    }
}
