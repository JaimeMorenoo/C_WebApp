using System.Security.Cryptography.X509Certificates;

namespace Rover_Control_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            // MoonRover and MarsRover inherit from Rover so they can be in the same Rover array.
            Rover[] rover_array = new Rover[] { lunokhod, apollo, sojourner };



            // We create an Object array to get all together as it is the only way to do it right now

            Object[] space_gang = new Object[] { lunokhod, apollo, sojourner, sputnik };

            // We created a IDirectable interface where Rover and Satelites inherits from so now we can put all together better.

            IDirectable[] space = new IDirectable[] {lunokhod, apollo, sojourner, sputnik };



            DirectAll(space);


        }

        // We create this method to iterate in the rover_array to get all their methods printed.
        public static void DirectAll(IDirectable[] r)
        {
            foreach(IDirectable rover in r)
            {
                Console.WriteLine($"{rover.GetInfo()}, {rover.Explore()}, {rover.Collect()}");
            }
        }

    }
}