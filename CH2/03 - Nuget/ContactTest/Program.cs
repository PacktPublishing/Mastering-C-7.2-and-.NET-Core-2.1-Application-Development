using System;

namespace ContactTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact.Contact()
            {
                Name = "James Bond",
                DateofBirth = new DateTime(1970, 1, 1)
            };

            Console.Write(contact.GetJSON());
            Console.Read();
        }
    }
}
