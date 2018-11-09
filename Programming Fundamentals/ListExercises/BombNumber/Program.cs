using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = commands[0];
            int power = commands[1];
            
            int position = numbers.IndexOf(bomb);

            while (numbers.Contains(bomb))
            {
                if (position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }

                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, 1 + power + position);
                }

                else if (position + power >= numbers.Count)
                {
                    numbers.RemoveRange(position - power, power + 1 + numbers.Count - 1 - position);
                }

                else
                {
                    numbers.RemoveRange(position - power , 2 * power + 1);
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
