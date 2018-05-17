using Newtonsoft.Json;
using NodaTime;
using System;

namespace TimeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a contact
            var contact = new Contact() { Name = "James Bond", DateofBirth = new DateTime(1920, 1, 1) };
            //serialize the contact to json. Indent it for easy display
            var json = JsonConvert.SerializeObject(contact, Formatting.Indented);
            Console.WriteLine(json);
            Console.Read();
        }
        public class Contact
        {
            public string Name { get; set; }
            public DateTime DateofBirth { get; set; }
            public int Age => Period.Between(LocalDate.FromDateTime(DateofBirth),
                LocalDate.FromDateTime(DateTime.Now),
                PeriodUnits.Years).Years;
        }
    }
}
