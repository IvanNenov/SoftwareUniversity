using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secoundSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSum += number;
            }

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secoundSum += number;
            }

            if(firstSum == secoundSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(firstSum - secoundSum));
            }
        }
    }
}
