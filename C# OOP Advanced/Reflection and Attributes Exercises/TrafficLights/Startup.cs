using System;
using System.Collections.Generic;
using System.Reflection;

namespace TrafficLights
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var trafficLights = new TrafficLight[input.Length];

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<string> result = new List<string>();

                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Update();
                    var typeOfClass = typeof(TrafficLight);
                    var field = typeOfClass.GetField("currentSignal", BindingFlags.NonPublic | BindingFlags.Instance);

                    result.Add(field.GetValue(trafficLight).ToString());
                }
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
