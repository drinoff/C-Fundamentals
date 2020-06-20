using System;
using System.Collections.Generic;
using System.Linq;


namespace seizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            var fireCells = Console.ReadLine().Split(new string[] {" = ","#" }, StringSplitOptions.RemoveEmptyEntries);
            var water = int.Parse(Console.ReadLine());
            var fireValidNumbers = new List<int>();
            var firesPuttedOut = new List<int>();
            var effort = 0.0;

            for (int i = 1; i < fireCells.Length; i += 2)
            {
                if (fireCells[i - 1] == "High")
                {
                    if (125 >= int.Parse(fireCells[i]) && int.Parse(fireCells[i]) >= 81)
                    {
                        fireValidNumbers.Add(int.Parse(fireCells[i]));
                    }
                }
                else if (fireCells[i - 1] == "Medium")
                {
                    if (80 >= int.Parse(fireCells[i]) && int.Parse(fireCells[i]) >= 51)
                    {
                        fireValidNumbers.Add(int.Parse(fireCells[i]));
                    }
                }
                else
                {

                    if (50 >= int.Parse(fireCells[i]) && int.Parse(fireCells[i]) >= 1)
                    {
                        fireValidNumbers.Add(int.Parse(fireCells[i]));
                    }

                }
            }
            for (int i = 0; i < fireValidNumbers.Count; i++)
            {
                if (fireValidNumbers[i] <= water)
                {
                    firesPuttedOut.Add(fireValidNumbers[i]);
                    water -= fireValidNumbers[i];
                    effort += fireValidNumbers[i] * 0.25;
                }
            }
            Console.WriteLine("Cells:");
            foreach (var fire in firesPuttedOut)
            {
                Console.WriteLine($" - {fire}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {firesPuttedOut.Sum()}");
        }
    }
}
