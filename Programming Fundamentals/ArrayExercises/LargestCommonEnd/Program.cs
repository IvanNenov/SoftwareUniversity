using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split().ToArray();
            var secoundArray = Console.ReadLine().Split().ToArray();
            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < Math.Min(firstArray.Length , secoundArray.Length); i++)
            {
                if (firstArray[i] == secoundArray[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(firstArray.Length, secoundArray.Length); i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secoundArray[secoundArray.Length -1 -i])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }

            if (rightCounter <= leftCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else if (rightCounter > leftCounter)
            {
                Console.WriteLine(rightCounter);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
