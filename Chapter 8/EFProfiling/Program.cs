using System;
using System.Linq;
using EFProfiling.Models;
using HibernatingRhinos.Profiler.Appender.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace EFProfiling
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkProfiler.Initialize();
            using (var ctx = new NorthwndContext())
            {
                var customersV1 = ctx.Customers.Where(x => x.CompanyName.StartsWith("A")).ToList();
                var customersV2 = ctx.Customers.Where(x => EF.Functions.Like(x.CompanyName, "A%")).ToList();
                Console.WriteLine($"Version 1 returned {customersV1.Count} And 2 {customersV2.Count}");
            }
        }
    }
}

