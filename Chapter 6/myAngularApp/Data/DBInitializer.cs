using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace myAngularApp
{
    public class DBInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // Get the context
            using (var context = new StudentContext(
                serviceProvider.GetRequiredService<DbContextOptions<StudentContext>>()))
            {
                // Check if there are any students. If yes, return
                if (context.Students.Any()) return;

                context.Students.AddRange(
                   new Student
                   {
                       Surname = "Bond",
                       OtherNames = "James",
                       DateOfBirth = new DateTime(1960, 1, 1),
                       Height = 6.0M,
                       Notes = "Shaken, not stirred"
                   },
                    new Student
                    {
                        Surname = "Bond",
                        OtherNames = "Jane",
                        DateOfBirth = new DateTime(1980, 1, 1),
                        Height = 5.6M,
                        Notes = "Fiernce"
                    }, new Student
                    {
                        Surname = "Bourne",
                        OtherNames = "Jason",
                        DateOfBirth = new DateTime(1970, 1, 1),
                        Height = 6.2M,
                        Notes = "Who am I?"
                    }, new Student
                    {
                        Surname = "Hari",
                        OtherNames = "Mata",
                        DateOfBirth = new DateTime(1920, 1, 1),
                        Height = 5.7M,
                        Notes = "Venus flytrap"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}