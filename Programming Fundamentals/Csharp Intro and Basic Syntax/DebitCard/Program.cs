using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secoundNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.Write($"{number:d4} ");
            Console.Write($"{secoundNumber:d4} ");
            Console.Write($"{thirdNumber:d4} ");
            Console.Write($"{fourthNumber:d4}");


        }
    }
}
