using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersToTake = arr[0];
            var numbersToDelete = arr[1];
            var numbersToSearch = arr[2];

            numbers.Take(numbersToTake);
            numbers.RemoveRange(0, numbersToDelete);
           
            
            if (numbers.Contains(numbersToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
