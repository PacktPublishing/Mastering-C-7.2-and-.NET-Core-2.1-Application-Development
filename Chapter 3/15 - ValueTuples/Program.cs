using System;

namespace ValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a local ValueTuple
            (int hour, int minute) timeStamp = (11, 10);
            Console.WriteLine($"The Hour: {timeStamp.hour}");
            Console.WriteLine($"The Minute: {timeStamp.minute}");
            var agent = GetAgent();
            // Print the agent information
            Console.WriteLine($"The agent name is {agent.Name}");
            Console.WriteLine($"The agent height is {agent.Height:#.00}");
            Console.WriteLine($"The agent Date of Birth is {agent.DateOfBirth:d MMM yyyy}");
        }
        static (string Name, decimal Height, DateTime DateOfBirth) GetAgent()
        {
            return ("James Bond", 6.0M, new DateTime(1970, 1, 1));
        }
    }
}
