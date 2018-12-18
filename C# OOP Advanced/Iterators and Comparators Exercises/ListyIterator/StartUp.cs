using System;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var createList = Console.ReadLine().Split().Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(createList);

            string input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;

                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "Print":
                        listyIterator.Print();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
