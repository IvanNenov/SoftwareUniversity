namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            var typeOfClass = typeof(HarvestingFields);
            string accesModifier = string.Empty;

            while (command != "HARVEST")
            {
                if (command == "private")
                {
                    var allPrivateField = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
                        .Where(x => x.IsPrivate);

                    foreach (var field in allPrivateField)
                    {
                        accesModifier = "private";
                        Console.WriteLine($"{accesModifier} {field.FieldType.Name} {field.Name}");
                    }
                }

                else if (command == "protected")
                {
                    var protectedFields = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                        .Where(x => x.IsFamily);

                    accesModifier = "protected";

                    foreach (var field in protectedFields)
                    {
                        Console.WriteLine($"{accesModifier} {field.FieldType.Name} {field.Name}");
                    }
                }

                else if (command == "public")
                {
                    var publicFields = typeOfClass.GetFields();

                    foreach (var field in publicFields)
                    {
                        accesModifier = "public";
                        Console.WriteLine($"{accesModifier} {field.FieldType.Name} {field.Name}");
                    }
                }

                else if (command == "all")
                {
                    var allDeclaredFields = typeOfClass.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

                    foreach (var field in allDeclaredFields)
                    {
                        if (field.IsPrivate)
                        {
                            accesModifier = "private";
                        }

                        else if (field.IsPublic)
                        {
                            accesModifier = "public";
                        }

                        else
                        {
                            accesModifier = "protected";
                        }

                        Console.WriteLine($"{accesModifier} {field.FieldType.Name} {field.Name}");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
