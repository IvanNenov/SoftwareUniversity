using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            GetMaxNumber(number, number2, number3);
            
        }

        static void GetMaxNumber(int num , int num2 , int num3)
        {
            var maxNumber = Math.Max(num, num2);
            if (maxNumber < num3)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine(maxNumber);
            }
        }
    }
}
