using System;
using System.Collections.Generic;
using System.Linq;


namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "Even" && input != "Odd")
            {
                var commmand = input.Split();

                if (commmand[0] == "Delete")
                {
                    var tokens = input.Split().ToArray();
                    var numberToRemove = int.Parse(tokens[1]);

                    numbers.RemoveAll(x => x == numberToRemove);
                }

                else if (commmand[0] == "Insert")
                {
                    var tokens = input.Split().ToArray();

                    var element = int.Parse(tokens[1]);
                    var position =int.Parse(tokens[2]);

                    numbers.Insert(position, element);
                }
                input = Console.ReadLine();
            }

            if (input == "Even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            else if (input == "Odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
        }
    }
}
