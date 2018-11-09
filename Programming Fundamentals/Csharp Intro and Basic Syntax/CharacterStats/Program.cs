using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //name, current health, maximum health, current energy and maximum energy 

            string name = Console.ReadLine();
            
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealt = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string('|',currentHealth));
            Console.Write(new string('.', maximumHealt - currentHealth));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maximumEnergy - currentEnergy));
            Console.WriteLine("|");


        }
    }
}
