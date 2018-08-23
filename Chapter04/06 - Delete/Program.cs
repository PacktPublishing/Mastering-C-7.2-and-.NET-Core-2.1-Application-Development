using System;
using System.Linq;

namespace MappedModel
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var ctx = new StudentContext())
            {
                var James = ctx.Students.Where(x => x.FullNames == "James Cunningham").Single();
                ctx.Remove(James);
                ctx.SaveChanges();
                Console.Write("Done");
            }
        }
    }
}
