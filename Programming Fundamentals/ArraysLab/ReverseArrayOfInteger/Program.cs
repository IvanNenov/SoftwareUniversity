using System;
using System.Linq;

namespace ReverseArrayOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
           var reversed = numbers.Reverse();

            Console.WriteLine(string.Join(" ",reversed));
        }
    }
}
