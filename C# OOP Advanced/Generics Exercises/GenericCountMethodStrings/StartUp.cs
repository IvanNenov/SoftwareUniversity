using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();
                boxes.Add(new Box<string>(input));
            }

            var elementToCompare = Console.ReadLine();
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
