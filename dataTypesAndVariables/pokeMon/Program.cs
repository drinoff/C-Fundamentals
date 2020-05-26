using System;

namespace pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            var energy = long.Parse(Console.ReadLine());
            var distance = long.Parse(Console.ReadLine());
            var exhaustFactor = int.Parse(Console.ReadLine());
            var targetsPoked = 0;

            var exhaustingPoint = energy / 2;
            while (energy >0)
            {
                if (energy < distance)
                {
                    break;
                }
                energy -= distance;
                targetsPoked++;
                if (energy == exhaustingPoint && exhaustFactor != 0)
                {
                    energy /= exhaustFactor;
                }

            }
            Console.WriteLine(energy);
            Console.WriteLine(targetsPoked);


        }
    }
}
