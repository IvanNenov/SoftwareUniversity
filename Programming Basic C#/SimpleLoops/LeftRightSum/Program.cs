using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftsum = 0;
            for (int i = 1;
                i <= n;
                i ++)
            {
                int number = int.Parse(Console.ReadLine());
                leftsum += number;
            }

            
            int rightsum = 0;
            for (int i = 1;
                i <= n;
                i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightsum += number;
            }

            if (leftsum == rightsum)
            {
                Console.WriteLine("Yes, sum = {0}", leftsum);
            }
            else
            {
                int difference = Math.Abs(leftsum - rightsum);
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
