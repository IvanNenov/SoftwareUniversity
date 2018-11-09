using System;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            var waterPrice = 0.70;
            var coffeePrice = 1.00;
            var beerPrice = 1.70;
            var teaPrice = 1.20;

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity * waterPrice):f2}.");
                    break;

                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * coffeePrice):f2}.");

                    break;

                case "SoftUni Student":
                    Console.WriteLine($"The { profession} has to pay { (quantity * beerPrice):f2}.");
                    break;

                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * teaPrice):f2}.");
                    break;

            }
        }
    }
}
