using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentensec
{
    class Program
    {
        static void Main(string[] args)
        {
            string worldToFind = Console.ReadLine();

            string[] text = Console.ReadLine().Split(new[] {'.', '!', '?' }).ToArray();

            foreach (var sentence in text)
            {
                string pattern = $@"\b{worldToFind}\b";
                var ismatched = Regex.IsMatch(sentence, pattern);

                if (ismatched)
                {
                    Console.WriteLine(sentence.Trim());
                }
               
            }

            
        }
    }
}
