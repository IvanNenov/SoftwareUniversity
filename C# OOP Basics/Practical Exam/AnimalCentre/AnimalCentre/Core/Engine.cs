using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Core
{
    public class Engine
    {
        public void Run()
        {
            var animalCentre = new AnimalCentre();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split();
                var procedureName = tokens[0];

                if (tokens[0] == "RegisterAnimal")
                {
                    var type = tokens[1];
                    var name = tokens[2];
                    var energy = int.Parse(tokens[3]);
                    var happiness = int.Parse(tokens[4]);
                    var proceduretime = int.Parse(tokens[5]);

                    try
                    {
                        Console.WriteLine(animalCentre.RegisterAnimal(type, name, energy, happiness,proceduretime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch(ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "Chip")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.Chip(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "Vaccinate")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.Vaccinate(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "Fitness")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.Fitness(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "Play")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.Play(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "DentalCare")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.DentalCare(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "NailTrim")
                {
                    var name = tokens[1];
                    var procedureTime = int.Parse(tokens[2]);

                    try
                    {
                        Console.WriteLine(animalCentre.NailTrim(name, procedureTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "Adopt")
                {
                    var name = tokens[1];
                    var owner = tokens[2];

                    try
                    {
                        Console.WriteLine(animalCentre.Adopt(name, owner));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }

                else if (tokens[0] == "History")
                {
                    var procTime = tokens[1];

                    try
                    {
                        Console.WriteLine(animalCentre.History(procTime));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("InvalidOperationException: " + e.Message);
                    }

                    catch (ArgumentException e)
                    {
                        Console.WriteLine("ArgumentException: " + e.Message);
                    }
                }
                input = Console.ReadLine();
            }

            animalCentre.Print();
        }
    }
}
