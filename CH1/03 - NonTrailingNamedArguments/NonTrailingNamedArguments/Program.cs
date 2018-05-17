using System;

namespace NonTrailingNamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // These two calls are equivalent
            Marry("Jane", "John", 1);
            Marry(groom: "John", bride: "Jane", weddingCount: 1);

            // This will yield a compile error in C# 7.1
            Marry("Jane", groom: "John", 1);
        }
        static void Marry(string bride, string groom = "John", int weddingCount = 1)
        {
            Console.WriteLine($"The bride is {bride} and the groom is {groom} for wedding #{weddingCount}");
        }
    }
}
