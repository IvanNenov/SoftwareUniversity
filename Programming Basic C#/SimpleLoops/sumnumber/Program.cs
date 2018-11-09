using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double sum = 0;            
            for (int i = 0; i < number;
                i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num; 
            }
            Console.WriteLine(sum);

         
        }
    }
}
