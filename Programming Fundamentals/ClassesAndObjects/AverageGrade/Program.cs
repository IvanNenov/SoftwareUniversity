using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, double> result = new Dictionary<string, double>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var name = input[0];
                var allGrade = input.Skip(1);
                var grade = allGrade.Select(double.Parse).ToList();

                var average = grade.Average();

                if (!result.ContainsKey(name))
                {
                    result.Add(name, average);
                }
                
            }

            foreach (var student in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
