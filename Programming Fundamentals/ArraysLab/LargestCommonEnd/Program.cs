using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray();
            string[] secoundWord = Console.ReadLine().Split().ToArray();

            var getMinArr = Math.Min(word.Length, secoundWord.Length);

            int leftcounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < getMinArr; i++)
            {
                if (word[i] == secoundWord[i])
                {
                    leftcounter++;
                }
            }

            for (int i = 0; i < word.Length && i < secoundWord.Length; i++)
            {
                if (word[word.Length - 1 -i] == secoundWord[secoundWord.Length - 1 -i])
                {
                    rightCounter++;
                }
            }

            if (leftcounter >= rightCounter)
            {
                Console.WriteLine(leftcounter);
            }

            else if (rightCounter > leftcounter)
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
