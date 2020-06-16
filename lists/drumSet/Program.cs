using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace drumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            var reserveDrumSet = new List<int>();
            for (int i = 0; i < drumSet.Count; i++)
            {
                reserveDrumSet.Add(drumSet[i]);
            }
            var input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                var power = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;
                    if (drumSet[i] <= 0)
                    {
                        if (reserveDrumSet[i] * 3 <= money)
                        {
                            drumSet[i] = reserveDrumSet[i];
                            money -= reserveDrumSet[i] * 3;
                        }
                   }
                }
                input = Console.ReadLine();
            }
            drumSet.RemoveAll(x => x == 0 || x < 0);
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
