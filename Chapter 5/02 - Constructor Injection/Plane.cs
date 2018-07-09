namespace AirportDI
{
    public class Plane
    {
        private IEngine m_Engine;
        public Plane(IEngine engine)
        {
            this.m_Engine = engine;
        }
        public void Start() => m_Engine.Start();
        public void Taxi() { }
    }
}
