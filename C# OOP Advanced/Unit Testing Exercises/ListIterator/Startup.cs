using System;
using System.Linq;

namespace ListIterator
{
    class Startup
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split();

                switch (tokens[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(tokens.Skip(1).ToArray());
                        break;

                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;

                    case "Print":
                        try
                        {
                            Console.WriteLine(listyIterator.Print());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message); 
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
