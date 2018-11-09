using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int count = 0;

            while (inputLine != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {inputLine}.");
                count++;
                inputLine = Console.ReadLine();
            }
            if (inputLine == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {count} ingredients.");
            }
        }
    }
}
