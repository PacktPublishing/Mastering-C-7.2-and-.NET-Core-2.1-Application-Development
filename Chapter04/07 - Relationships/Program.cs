using System;
using System.Linq;
using System.Collections.Generic;

namespace MappedModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var James = new Student()
                {
                    FullNames = "Charles Cunningham",
                    DateOfBirth = new DateTime(1970, 1, 1),
                    Gender = "M",
                    Surname = "Bond",
                    Height = 6,
                    Weight = 80
                };
                James.Siblings.Add(new Sibling() { SiblingID = Guid.NewGuid(), Name = "Anita Bond" });
                ctx.Add(James);
                ctx.SaveChanges();
                Console.WriteLine("Done");

            }
        }
    }
}
