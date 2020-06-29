using System;

namespace easterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var flourPrice = double.Parse(Console.ReadLine());

            var eggsPrice = flourPrice * 0.75;
            var milkPrice = flourPrice * 1.25 / 4;
            var cozunacPrice = flourPrice + eggsPrice + milkPrice;
            var coloredEggsCount = 0;
            var cozonacCount = 0;

            while (budget>=cozunacPrice)
            {
                budget -= cozunacPrice;
                coloredEggsCount += 3;
                cozonacCount++;
                if (cozonacCount % 3 == 0)
                {
                    coloredEggsCount -= cozonacCount - 2;
                }
            }
            Console.WriteLine($"You made {cozonacCount} cozonacs! Now you have {coloredEggsCount} eggs and {budget:f2}BGN left.");
        }
    }
}
