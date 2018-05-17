using System;
using System.Collections.Concurrent;

namespace ConcurrentStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new ConcurrentStack<string>();
            cs.Push("John");
            cs.Push("Mary");

            if (cs.TryPeek(out var first))
                Console.WriteLine($"Peeked and got {first}");

            if (cs.TryPop(out var second))
                Console.WriteLine($"Popped {second} from the stack");

            Console.WriteLine($"There should be one item in the stack and there are {cs.Count}");

            cs.Clear();

            Console.WriteLine($"Is the stack empty? {cs.IsEmpty}");

        }
    }
}
