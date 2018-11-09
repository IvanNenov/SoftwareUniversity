using System;

namespace Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            try
            {
                int.Parse(inputLine);
                Console.WriteLine("It is a number.");
            }

            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }
        }
    }
}
