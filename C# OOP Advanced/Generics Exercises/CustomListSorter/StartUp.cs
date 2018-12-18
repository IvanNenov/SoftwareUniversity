using System;

namespace CustomListSorter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var customList = new CustomList<string>();

            while (input != "END")
            {
                var tokens = input.Split();
                var command = tokens[0];

                switch (command)
                {
                   case "Add":
                        var elementToAdd = tokens[1];
                        customList.Add(elementToAdd);
                        break;

                    case "Remove":
                        var index = int.Parse(tokens[1]);
                        customList.Remove(index);
                        break;

                    case "Contains":
                        var element = tokens[1];
                        Console.WriteLine(customList.Contains(element));
                        break;

                    case "Swap":
                        var index1 = int.Parse(tokens[1]);
                        var index2 = int.Parse(tokens[2]);

                        customList.Swap(index1, index2);

                        break;

                    case "Greater":
                        element = tokens[1];

                        Console.WriteLine(customList.CountGreaterThan(element));
                        break;

                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;

                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;

                    case "Sort":
                        customList.Sort();
                        break;

                    case "Print":
                        Console.WriteLine(customList);
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
