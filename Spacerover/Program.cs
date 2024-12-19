using System;
using System.Collections.Generic;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of rovers and satellites
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            // Add all to a collection of IDirectable
            List<IDirectable> devices = new List<IDirectable> { lunokhod, apollo, sojourner, sputnik };

            // Iterate through each device and interact with it
            foreach (IDirectable device in devices)
            {
                Console.WriteLine(device.GetInfo());
                Console.WriteLine(device.Explore());
                Console.WriteLine(device.Collect());
                Console.WriteLine();
            }
        }
    }
}
