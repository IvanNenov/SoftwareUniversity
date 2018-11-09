using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var greatestnumber = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currerntNumber = int.Parse(Console.ReadLine());
                if (currerntNumber > greatestnumber)
                {
                    sum += greatestnumber;
                    greatestnumber = currerntNumber;
                }
                else
                {
                    sum += currerntNumber;
                }
            }
        }
    }
}
