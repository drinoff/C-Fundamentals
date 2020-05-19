using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter1 = 0;
            int counter2 = 0;
            int[] bestDNA = new int[dnaLength];
            int result1 = 0;
            int result2 = 0;
            while (input != "Clone them!")
            {

                int[] sequence = input.Split("!").Select(int.Parse).ToArray();

                foreach (var item in sequence)
                {
                    if (item == item+1)
                    {
                       
                    }

                }

                if (counter1 > counter2)
                {
                    bestDNA = sequence;
                }
                else if (counter2 > counter1)
                {
                    continue;
                }
                else
                {
                    if (sequence[0] > bestDNA[0])
                    {
                        bestDNA = sequence;
                    }
                    else if (sequence[0] < bestDNA[0])
                    {
                        continue;

                    }
                    else
                    {
                        result2 = bestDNA.Sum();
                        result1 = sequence.Sum();
                        if (result1 > result2)
                        {
                            bestDNA = sequence;
                            counter1 = counter2;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                var result3 = Array.FindAll(sequence, x => x == 1);
                Console.WriteLine(string.Join(" ",result3));
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Best DNA sample {counter1} with sum: {result1}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}
