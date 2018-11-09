using System;
using System.Linq;

namespace CompareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(arr.Length , arr2.Length); i++)
            {
                if (arr[i] == arr2[i])
                {
                    if (i == Math.Min(arr.Length, arr2.Length)-1)
                    {
                        if (arr.Length > arr2.Length)
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr));

                            return;                        
                        }                                  
                        else                               
                        {                                  
                            Console.WriteLine(string.Join("", arr));
                            Console.WriteLine(string.Join("", arr2));

                            return;
                        }
                    }
                }
                else if(arr[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));

                    Console.WriteLine(string.Join("", arr));
                    return;
                }
                else
                {
                    Console.WriteLine(string.Join("", arr));
                    Console.WriteLine(string.Join("", arr2));

                    return;

                }
            }

        }
    }
}
