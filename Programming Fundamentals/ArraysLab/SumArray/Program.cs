using System;
using System.Linq;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {


            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxArr = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i <= maxArr; i++)
            {
                maxArr = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                if (i >= arr1.Length && i >= arr2.Length)
                {
                    break;
                }

                Console.Write(maxArr + " ");
            }

            Console.WriteLine();

        }
    }
}
