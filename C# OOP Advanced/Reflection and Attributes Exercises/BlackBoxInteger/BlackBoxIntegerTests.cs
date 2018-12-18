namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var typeOfClass = typeof(BlackBoxInteger);
            var instance =(BlackBoxInteger)Activator.CreateInstance(typeOfClass,true);

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split("_");

                var methodName = tokens[0];
                var value = int.Parse(tokens[1]);

                var method = typeOfClass.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                var invokeMethod = method.Invoke(instance, new object[] { value });

                int currentValue = (int)typeOfClass.GetField("innerValue", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                     .GetValue(instance);

                Console.WriteLine(currentValue);
                command = Console.ReadLine();
            }
        }
    }
}
