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
            // Register the Jet engine & propeller engine with the container
            builder.RegisterType<JetEngine>();
            builder.RegisterType<PropellerEngine>();
            // Construct the container
            Container = builder.Build();
            //get both engines from our container
            using (var scope = Container.BeginLifetimeScope())
            {
                var jet = scope.Resolve<JetEngine>();
                jet.Start();
                var prop = scope.Resolve<PropellerEngine>();
                prop.Start();
            }
        }
    }
}
