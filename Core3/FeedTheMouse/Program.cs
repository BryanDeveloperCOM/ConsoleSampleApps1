using System;

namespace ConsoleSampleApps1.Core3.FeedTheMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today everyone gets a free mouse! What would you like to name your mouse?");
            string mouse = Console.ReadLine();

            string food = "";
            while (food != "cracker" && food != "candy" && food != "cheese")
            {
                Console.WriteLine($"\nWhat would you like to feed {mouse}? A cracker, candy, or cheese?");
                food = Console.ReadLine().ToLower();
            }

            int count = 0;
            while (count <= 0)
            {
                Console.WriteLine($"\nHow many?");
                try { count = Convert.ToInt16(Console.ReadLine()); }
                catch (Exception) { }
            }

            for (int fed = 1; fed <= count; fed++)
            {
                if (food == "cracker")
                    Console.WriteLine($"{mouse} ate a cracker!");
                else if (food == "candy")
                    Console.WriteLine($"{mouse} ate a piece of candy!");
                else if (food == "cheese")
                    Console.WriteLine($"{mouse} ate some cheese!");
            }

            Console.ReadKey();
        }
    }
}
