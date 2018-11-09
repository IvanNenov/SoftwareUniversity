using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double biggestnumber = int.MinValue;
            for (int i = 0;
                i < number;
                i++)
            {
                double input = double.Parse(Console.ReadLine());
                
                if (input > biggestnumber)
                {
                    biggestnumber = input;
                }
                
            }
            Console.WriteLine(biggestnumber);
        }
    }
}
