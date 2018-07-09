namespace AirportDI
{
    public class Plane
    {
        public IEngine Engine { get; set; }
        public Plane()
        {
            this.Engine = new JetEngine();
        }
        public void Start() => Engine.Start();
        public void Taxi() { }
    }
}
