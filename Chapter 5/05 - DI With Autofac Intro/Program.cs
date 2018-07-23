using System;
using Autofac;
namespace AirportDI
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            // Register the Jet engine with the container
            builder.RegisterType<JetEngine>().As<IEngine>();
            // Construct the container
            Container = builder.Build();
            //get a jet engine from our container
            using (var scope = Container.BeginLifetimeScope())
            {
                var jet = scope.Resolve<IEngine>();
                jet.Start();
            }
        }
    }
}
