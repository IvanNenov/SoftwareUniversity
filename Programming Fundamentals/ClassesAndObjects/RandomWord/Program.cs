using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int firstWord = rnd.Next(0, words.Count);
                int secondWord = rnd.Next(0, words.Count);

                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;

            }

            Console.WriteLine(string.Join("\r\n" , words));
        }
    }
}
