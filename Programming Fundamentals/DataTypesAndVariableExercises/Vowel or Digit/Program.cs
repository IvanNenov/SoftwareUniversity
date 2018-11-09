using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            //a o u e i
            string input = Console.ReadLine();

            try
            {
                var parsed = int.Parse(input);
                
                    Console.WriteLine("digit");
                
                
            }
            catch (Exception)
            {
                if (input == "a" || input == "o" || input == "u" || input == "e" || input == "i")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
                
            }
        }
    }
}
