using System;

namespace IntToHexAndBinarry
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var converted = Convert.ToString(number, 16).ToUpper();

            int tobase = 2;
            var binary = Convert.ToString(number, tobase);
            Console.WriteLine(converted);
            Console.WriteLine(binary);



        }
    }
}
