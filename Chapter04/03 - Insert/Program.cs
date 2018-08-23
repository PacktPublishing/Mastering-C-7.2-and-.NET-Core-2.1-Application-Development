using System;
namespace MappedModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var student = new Student()
                {
                    StudentID = Guid.NewGuid(),
                    FullNames = "Mary Jane",
                    Surname = "Bond",
                    Gender = "M",
                    DateOfBirth = new DateTime(1980, 1, 1),
                    Height = 5.5M,
                    Weight = 60,
                    FeesOutstanding = 0

                };
                ctx.Add(student);
                ctx.SaveChanges();
                Console.Write("Completed");
            }
        }
    }
}
