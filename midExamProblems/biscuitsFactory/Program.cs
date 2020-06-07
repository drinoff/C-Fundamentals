using System;

namespace biscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var biscuitsPerDayPerWorker = long.Parse(Console.ReadLine());
            var workers = long.Parse(Console.ReadLine());
            var competingFactoryProduction = long.Parse(Console.ReadLine());

            var biscuitsPerDay = workers * biscuitsPerDayPerWorker;
            var biscuitsPerMonth = (decimal)(20 * biscuitsPerDay + 10 * Math.Floor(biscuitsPerDay * 0.75));
            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");

            var percentageMore = ((biscuitsPerMonth - competingFactoryProduction) / competingFactoryProduction) * 100;
            var percentageLess = ((competingFactoryProduction - biscuitsPerMonth) / competingFactoryProduction) * 100;

            if (biscuitsPerMonth > competingFactoryProduction)
            {
                Console.WriteLine($"You produce {percentageMore:f2} percent more biscuits.");
            }
            else if (biscuitsPerMonth < competingFactoryProduction)
            {
                Console.WriteLine($"You produce {percentageLess:f2} percent less biscuits.");
            }

        }
    }
}