using System;
using Serilog;

namespace TemperatureChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
             .Enrich.WithThreadId()
             .WriteTo.Console(outputTemplate: "{Timestamp:MM-dd HH:mm} [{Level:u3}] <Thread: {ThreadId}> {Message}{NewLine}")
             .CreateLogger();

            var climate = new Climate(30M);
            climate.ChangeTemperature += (s, e) =>
            {
                Log.Information("Temp changed from {old} to {new}", e.OldTemperature, e.NewTemperature);
            };
            climate.UpdateTemperature(50M);
            climate.UpdateTemperature(60M);
            climate.UpdateTemperature(20M);
            climate.UpdateTemperature(40M);
            climate.UpdateTemperature(90M);
        }
    }
}
