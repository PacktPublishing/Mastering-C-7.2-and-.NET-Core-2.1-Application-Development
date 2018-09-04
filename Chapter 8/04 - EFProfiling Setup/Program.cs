using System;
using System.Linq;
using EFProfiling.Models;
using HibernatingRhinos.Profiler.Appender.EntityFramework;

namespace EFProfiling
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkProfiler.Initialize();
            using (var ctx = new NorthwndContext())
            {
                var query = ctx.Customers.Where(x => x.CompanyName.StartsWith("A")).ToList();
                foreach (var result in query)
                    Console.WriteLine($"Company: {result.CompanyName}");
            }
        }
    }
}

