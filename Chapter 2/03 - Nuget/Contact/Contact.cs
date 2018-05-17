using Newtonsoft.Json;
using NodaTime;
using System;

namespace Contact
{
    public class Contact
    {
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Age => Period.Between(LocalDate.FromDateTime(DateofBirth),
            LocalDate.FromDateTime(DateTime.Now),
            PeriodUnits.Years).Years;

        /// <summary>
        /// Return a json representation of the contact
        /// </summary>
        /// <returns></returns>
        public string GetJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
