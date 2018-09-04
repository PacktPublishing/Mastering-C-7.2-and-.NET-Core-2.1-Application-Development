using System;
using System.Linq;
using EFProfiling.Models;

namespace EFProfiling
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NorthwndContext())
            {
                var query = ctx.Customers.Where(x => x.CompanyName.StartsWith("A"));
                foreach (var result in query)
                    Console.WriteLine($"Company: {result.CompanyName}");

            }
        }
    }
}
