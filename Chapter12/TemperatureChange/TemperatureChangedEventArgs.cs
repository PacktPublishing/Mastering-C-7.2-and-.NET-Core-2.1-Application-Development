using System;

namespace TemperatureChange
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public TemperatureChangedEventArgs(decimal oldTemp, decimal newTemp)
        {
            OldTemperature = oldTemp;
            NewTemperature = newTemp;
        }
        public decimal OldTemperature { get; }
        public decimal NewTemperature { get; }
    }
}