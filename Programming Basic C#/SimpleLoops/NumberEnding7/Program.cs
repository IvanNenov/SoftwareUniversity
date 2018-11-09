using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberEnding7
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int day = 1;
                day < 1000;
                day++)
            
                if (day % 10 == 7)
                {
                    Console.WriteLine(day);
                }
        }
    }
}
