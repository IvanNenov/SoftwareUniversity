using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());

            int lastPairValue = 0;
            int maxDifference = int.MinValue;
            for ( int i = 0;
                 i < numberOfPairs;
                 i++)
            {
                int firstElement = int.Parse(Console.ReadLine());
                int secoundElement = int.Parse(Console.ReadLine());

                int pairValue = firstElement + secoundElement;
                if (i > 0)
                {
                    int difference = Math.Abs(pairValue - lastPairValue);

                    if (difference > maxDifference)
                        maxDifference = difference;
                }
              

                lastPairValue = pairValue;

            }
            if (maxDifference == 0 || maxDifference == int.MinValue)
            {
                Console.WriteLine("Yes, value={0}", lastPairValue);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}",maxDifference);
            }
        }
    }
}
