using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char digit = char.Parse(Console.ReadLine());
            char digit2 = char.Parse(Console.ReadLine());
            char digit3 = char.Parse(Console.ReadLine());

            List<char> character = new List<char>();
            character.Add(digit);
            character.Add(digit2);
            character.Add(digit3);

            character.Reverse();
            Console.WriteLine(string.Join("", character));
        }
    }
}
