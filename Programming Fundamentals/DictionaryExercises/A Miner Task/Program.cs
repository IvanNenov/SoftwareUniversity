using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, int>();

            while (input != "stop")
            {
                var value = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, value);
                }
                else
                {
                    dict[input] += value;
                }

                input = Console.ReadLine();
            }
            

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
