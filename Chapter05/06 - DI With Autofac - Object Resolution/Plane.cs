namespace AirportDI
{
    public class Plane
    {
        public Plane()
        {
        }
        public void Start(IEngine m_Engine) => m_Engine.Start();
        public void Taxi() { }
    }
}
