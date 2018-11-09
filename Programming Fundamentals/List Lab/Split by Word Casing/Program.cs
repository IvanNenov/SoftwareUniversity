using System;
using System.Linq;
using System.Collections.Generic;
namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in text)
            {
                if (UpperCase(word))
                {
                    upperCase.Add(word);

                }
                else if (LowerCase(word))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
        static bool UpperCase(string word)
        {
            bool isupper = false;

            foreach (var symbol in word)
            {
                if (symbol >= 'A' && symbol <= 'Z')
                {
                    isupper = true;                   
                }
                else
                {
                    isupper = false;
                    return false;
                }
                
            }
            if (isupper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool LowerCase(string word)
        {
            bool isLower = false;
            foreach (var symbol in word)
            {
                if (symbol >= 'a' && symbol <= 'z')
                {
                    isLower = true;
                }
                else
                {
                    isLower = false;
                    return false;
                }
            }
            if (isLower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
