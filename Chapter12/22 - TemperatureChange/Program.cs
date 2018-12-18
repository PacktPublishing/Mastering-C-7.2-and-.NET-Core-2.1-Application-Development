using System;
using System.Reactive.Linq;
using Serilog;

namespace TemperatureChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithThreadId()
                .WriteTo.Console(
                    outputTemplate: "{Timestamp:MM-dd HH:mm} [{Level:u3}] <Thread: {ThreadId}> {Message}{NewLine}")
                .CreateLogger();

            var climate = new Climate(30M);

            var changes = Observable
                .FromEventPattern<EventHandler<TemperatureChangedEventArgs>, TemperatureChangedEventArgs>
                    (handler => climate.ChangeTemperature += handler, handler => climate.ChangeTemperature -= handler)
                .Select(x => x.EventArgs);

            var mediumChanges = changes.Where(x => Math.Abs(x.OldTemperature - x.NewTemperature) <= 20);
            var extremeChanages = changes.Where(x => Math.Abs(x.OldTemperature - x.NewTemperature) > 20);

            var mediumSub = mediumChanges.Subscribe(evt =>
            {
                var delta = evt.OldTemperature - evt.NewTemperature;
                Log.Information("A medium change of {delta} was detected: {old} to {new}",
                    delta, evt.OldTemperature, evt.NewTemperature);
            });

            var extremeSub = extremeChanages.Subscribe(evt =>
            {
                var delta = evt.OldTemperature - evt.NewTemperature;
                Log.Warning("A DRASTIC change of {delta} was detected: {old} to {new}",
                    delta, evt.OldTemperature, evt.NewTemperature);
            });

            climate.UpdateTemperature(50M);
            climate.UpdateTemperature(60M);
            climate.UpdateTemperature(20M);
            climate.UpdateTemperature(40M);
            climate.UpdateTemperature(90M);
        }
    }
}