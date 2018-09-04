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
                var query = ctx.Students.Where(x => x.Height >= 6.0M);
                Console.WriteLine($"There are {query.Count()} students 6 feet and over");
            }
        }
    }
}
