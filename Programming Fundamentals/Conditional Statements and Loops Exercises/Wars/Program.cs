using System;

namespace Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healtPesho = 100;
            int healtGosho = 100;

            int round = 0;

            while (healtPesho > 0 && healtGosho > 0)
            {
                round++;
                if (round % 2 == 1)
                {
                    healtGosho -= damagePesho;
                    if (healtGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healtGosho} health.");

                    }
                 
                }
                else
                {
                    healtPesho -= damageGosho;
                    if (healtPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healtPesho} health.");

                    }
                }
                if (round % 3 == 0 && healtPesho > 0 && healtGosho > 0)
                {
                    healtPesho += 10;
                    healtGosho += 10;
                }
                
            }
            if (round % 2 == 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");

            }
            else
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }

        }
    }
}
