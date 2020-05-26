using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int[] bestDNA = new int[dnaLength];

            int counter1 = 1;
            int counter2 = 0;
            int result1 = 0;
            int result2 = 0;
            var startingIndex = 0;
            var dnaSample = 0;

            while (input != "Clone them!")
            {

                int[] sequence = input.Split("!").Select(int.Parse).ToArray();

                for (int i = 1; i < sequence.Length; i++)
                {
                    if (sequence[i] != sequence[i - 1])
                    {
                        counter1 = 0;
                    }
                    counter1++;
                }

                

                if (counter1 + 1 > counter2)
                {
                    bestDNA = sequence;
                    dnaSample++;
                    counter2 = counter1 + 1;
                    counter1 = 0;
                }
                else if (counter2 > counter1)
                {
                    goto End;
                }
                else
                {
                    foreach (var item in sequence)
                    {
                        if (sequence[item] > bestDNA[item])
                        {
                            bestDNA = sequence;
                            dnaSample++;
                            break;
                        }

                    }
                    result2 = bestDNA.Sum();
                    result1 = sequence.Sum();
                    if (result1 > result2)
                    {
                        bestDNA = sequence;
                        dnaSample++;
                        counter1 = counter2;
                    }


                }

            End:
                input = Console.ReadLine();

            }

            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {result2}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}