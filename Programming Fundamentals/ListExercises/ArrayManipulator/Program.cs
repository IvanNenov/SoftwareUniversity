using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                var tokens = command.Split();
                if (tokens[0] == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);

                    numbers.Insert(index, element);
                }
                else if (tokens[0] == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    var elements = tokens.Skip(2).Select(int.Parse).ToList();

                    numbers.InsertRange(index, elements);
                }
                else if (tokens[0] == "contains")
                {

                    int element2 = int.Parse(tokens[1]);
                    Console.WriteLine(numbers.IndexOf(element2));
                    
                }
                else if (tokens[0] == "remove")
                {
                    var index = int.Parse(tokens[1]);

                    numbers.RemoveAt(index);
                }
                else if (tokens[0] == "shift")
                {
                    int positions = int.Parse(tokens[1]);
                    for (int i = 0; i < positions; i++)
                    {
                        int lastElement = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = lastElement;
                    }
                }
                else if (tokens[0] == "sumPairs")
                {
                    List<int> newList = new List<int>();
                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        newList.Add(numbers[i] + numbers[i + 1]);
                    }
                    if (numbers.Count % 2 == 1)
                    {
                        newList.Add(numbers[numbers.Count - 1]);
                    }
                    numbers = newList;
                }

                    command = Console.ReadLine();
                }

            Console.WriteLine("[{0}]" , string.Join(", ", numbers));
            }
        }
    }
