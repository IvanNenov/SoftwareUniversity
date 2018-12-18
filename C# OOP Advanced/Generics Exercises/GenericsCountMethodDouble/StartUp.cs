using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<double>>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = double.Parse(Console.ReadLine());
                boxes.Add(new Box<double>(input));
            }

            var elementToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(CountOfGreaterElement(boxes, elementToCompare));
        }

         static int CountOfGreaterElement<T>(IEnumerable<Box<T>> collection, T element)
            where T : IComparable<T>
        {
            var counter = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
