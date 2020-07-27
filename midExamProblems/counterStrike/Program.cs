using System;
using System.IO;

namespace counterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int counter = 0;
            int distance = 0;
            bool hasEnded = false;
            int battlesWon = 0;
            bool hasFinished = false;

            while (energy > 0)
            {
                string command = Console.ReadLine();
                if (command == "End of battle")
                {
                    hasEnded = true;
                    break;
                }
                distance = int.Parse(command);

                if (energy >= distance)
                {

                    battlesWon++;
                    energy -= distance;
                }

                if (energy == 0 || energy < distance)
                {
                    hasFinished = true;
                    break;
                }
                counter++;
                if (counter == 3)
                {
                    energy += battlesWon;
                    counter = 0;
                }
            }
            if (hasFinished)
            {
                Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
            }
            else if (hasEnded)
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
        }
    }
}