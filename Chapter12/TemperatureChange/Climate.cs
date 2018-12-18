using System;

namespace TemperatureChange
{
    public class Climate
    {
        private decimal m_Temperature;
        public Climate(decimal temp)
        {
            this.m_Temperature = temp;
        }
        public decimal Temperature => m_Temperature;
        public event EventHandler<TemperatureChangedEventArgs> ChangeTemperature;
        public void UpdateTemperature(decimal newTemp)
        {
            OnTemperatureChange(new TemperatureChangedEventArgs(this.Temperature, newTemp));
            m_Temperature = newTemp;
        }

        protected virtual void OnTemperatureChange(TemperatureChangedEventArgs e)
        {
            EventHandler<TemperatureChangedEventArgs> handler = ChangeTemperature;
            if (handler != null)
                handler(this, e);
        }
    }

}