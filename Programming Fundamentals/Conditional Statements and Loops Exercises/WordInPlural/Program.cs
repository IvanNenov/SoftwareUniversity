using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char lastDigit = word[word.Length - 1];
            char two = word[word.Length - 2];
            

            if (lastDigit == 'y')
            {
                word = word.Remove(word.Length - 1);
                Console.WriteLine(word + "ies");
            }

            else if (lastDigit == 'o' || lastDigit == 's' || lastDigit == 'x' || lastDigit == 'z' || lastDigit == 'h')
            {
                
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }
        }
    }
}
