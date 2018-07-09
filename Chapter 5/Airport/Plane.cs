namespace Airport
{
    public class Plane
    {
        private Engine m_Engine;
        public Plane()
        {
            this.m_Engine = new Engine();
        }
        public void Start()
        {
            m_Engine.Start();
        }
        public void Taxi() { }
    }
}
