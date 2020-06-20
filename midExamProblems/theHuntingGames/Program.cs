using System;

namespace theHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var players = int.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var waterPerPersonPerDay = double.Parse(Console.ReadLine());
            var foodPerPersonPerDay = double.Parse(Console.ReadLine());

            var totalWater = days * players * waterPerPersonPerDay;
            var totalFood = days * players * foodPerPersonPerDay;
            bool isNotSuccessful = false;
            var food = 0.0;
            var water = 0.0;

            for (int i = 1; i <= days; i++)
            {
                var energyLoss = double.Parse(Console.ReadLine());
                food = totalFood;
                water = totalWater;
                energy -= energyLoss;
                

                if (i % 2 == 0)
                {
                    totalWater -= totalWater*0.3;
                    energy *= 1.05;
                }
                if (i % 3 == 0)
                {
                    totalFood -= totalFood / players;
                    energy *= 1.1;
                }
                if (energy <= 0)
                {
                    isNotSuccessful = true;
                    break;
                }
            }
            if (isNotSuccessful)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
