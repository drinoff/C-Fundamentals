using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace carRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var trackField = Console.ReadLine().Split().Select(int.Parse).ToList();

            var sum1 = TimeCalculate(trackField);
            trackField.Reverse();
            var sum2 = TimeCalculate(trackField);
            if (sum1 < sum2)
            {
                Console.WriteLine($"The winner is left with total time: {sum1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sum2}");
            }
                     
        }
        static double TimeCalculate(List<int>trackField)
        {
            var sum = 0.0;
            for (int i = 0; i < (trackField.Count) / 2; i++)
            {
                if (trackField[i] == 0)
                {
                    sum *= 0.8;
                }
                sum += trackField[i];
            }
            return sum;
        }
    }
}
