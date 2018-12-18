using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var stack = new Stack<string>();
            while (command != "END")
            {
                var tokens = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Push")
                {
                    string[] elements = tokens.Skip(1)
                         .Select(i => i.Split(',').First())
                         .ToArray();

                    stack.Push(elements);
                }

                else if (tokens[0] == "Pop")
                {
                    stack.Pop();
                }

                command = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
