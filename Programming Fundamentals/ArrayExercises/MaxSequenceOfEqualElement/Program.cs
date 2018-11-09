using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int maxCount = 0;
            int bestNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestNumber = numbers[i];
                    }
                    count = 1;
                }

                if (i + 1 == numbers.Length -1)
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestNumber = numbers[i];

                    }
                    count = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(bestNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
