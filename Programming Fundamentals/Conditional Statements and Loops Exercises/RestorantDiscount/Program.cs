using System;

namespace RestorantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            var smallHall = 2500;
            var terrace = 5000;
            var greatHall = 7500;

            var normalPrice = 500;
            var goldPrice = 750;
            var platinumPrice = 1000;

            var price = 0.0;
            var discount = 0.0;
            var pricePerson = 0.0;

            string hallName = string.Empty;
            if (groupSize <= 50 && groupSize > 0)
            {
                hallName = "Small Hall";
                if (package == "Normal")
                {
                    price = normalPrice + smallHall;
                    discount = price - (price * 0.05);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    price = goldPrice + smallHall;
                    discount = price - (price * 0.1);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = platinumPrice + smallHall;
                    discount = price - (price * 0.15);
                    pricePerson = discount / groupSize;
                }
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                if (package == "Normal")
                {
                    price = normalPrice + terrace;
                    discount = price - (price * 0.05);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    price = goldPrice + terrace;
                    discount = price - (price * 0.1);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = platinumPrice + terrace;
                    discount = price - (price * 0.15);
                    pricePerson = discount / groupSize;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                if (package == "Normal")
                {
                    price = normalPrice + greatHall;
                    discount = price - (price * 0.05);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Gold")
                {
                    price = goldPrice + greatHall;
                    discount = price - (price * 0.1);
                    pricePerson = discount / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = platinumPrice + greatHall;
                    discount = price - (price * 0.15);
                    pricePerson = discount / groupSize;
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;

            }
           
            

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerson:f2}$");

        }
    }
}
