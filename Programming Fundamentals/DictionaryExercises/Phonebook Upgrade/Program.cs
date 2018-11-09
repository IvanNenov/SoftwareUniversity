using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var tokens = command.Split();

                if (tokens[0] == "A")
                {
                    var name = tokens[1];
                    var number = tokens[2];
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, number);
                    }

                    else
                    {
                        phoneBook[name] = number;
                    }
                }

                else if (tokens[0] == "S")
                {
                    var name = tokens[1];
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {string.Join("", phoneBook[name])}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (tokens[0] == "ListAll")
                {
                    foreach (var kvp in phoneBook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
