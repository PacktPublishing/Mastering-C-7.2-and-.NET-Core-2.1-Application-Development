using System;

namespace LeadingDigitSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is valid from C# 7.0
            var flag = 0b100_100;
            // This is valid from C# 7.2
            var newFlag = 0b_100_100;

            Console.WriteLine($"Flag: {flag}; New Flag: {newFlag}");
            Console.Read();
        }
    }
}
