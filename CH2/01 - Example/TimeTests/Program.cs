using NodaTime;
using System;

namespace TimeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a local date
            LocalDate today = new LocalDate(2018, 1, 1);
            // Using adjusters, determine the end of the month
            LocalDate endOfMonth = today.With(DateAdjusters.EndOfMonth);
            // Print to screen
            Console.WriteLine($"Given date {today:d MMM yyyy}, the end of the month is {endOfMonth:d MMM yyyy}");
            Console.Read();
        }
    }
}
