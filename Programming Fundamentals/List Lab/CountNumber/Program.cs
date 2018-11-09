using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();
            int counter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {                   
                    numbersCount.Add(numbers[i], counter);                
                }
                else
                {                  
                    numbersCount[numbers[i]] += counter;
                }
            }

            foreach (var kvp in numbersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
