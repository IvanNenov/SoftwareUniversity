using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i < rotation; i++)
            {
                int[] result = new int[array.Length];
                result[0] = array[array.Length - 1];

                for (int j = 1; j < result.Length; j++)
                {
                    result[j] = array[j - 1];
                }

                for (int k = 0; k < array.Length; k++)
                {
                    sum[k] += result[k];
                }
                array = result;
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
