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
            var dnaLength = Console.ReadLine();
            var input = Console.ReadLine();
            var maxSequence = 0;
            var bestSequence = new int[dnaLength.Length];
            var bestLeftIndex = 0;

            var bestCounter = 0;
            var currentCounter = 0;
            int leftIndex = 0;
            var bestDna = new int[dnaLength.Length];
            var result1 = 0;
            var result2 = 0;
            var anotherFokinCOunter = 0;
            var bestSeqinputCount = 0;

            while (input != "Clone them!")
            {
                var sequence = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == 1)
                    {
                        if (sequence[i + 1] == 1)
                        {
                            currentCounter++;
                        }
                        else
                        {
                            currentCounter++;
                            bestDna = sequence;
                            bestCounter = currentCounter;
                            leftIndex = i - currentCounter + 1;
                            if (anotherFokinCOunter > 1)
                            {
                                bestLeftIndex = leftIndex;
                            }


                        }
                    }
                    else
                    {
                        currentCounter = 0;
                    }
                }
                if (bestCounter > maxSequence)
                {
                    bestLeftIndex = leftIndex;
                    bestSequence = bestDna;
                    maxSequence = bestCounter;
                    bestSeqinputCount++;
                }
                else if (bestCounter < maxSequence)
                {

                }
                else
                {
                    if (leftIndex < bestLeftIndex)
                    {
                        bestLeftIndex = leftIndex;
                        bestSequence = bestDna;
                        maxSequence = bestCounter;
                        bestSeqinputCount++;
                    }
                    else if (leftIndex == bestLeftIndex)
                    {
                        result1 = bestSequence.Sum();
                        result2 = bestDna.Sum();
                        if (result1 > result2)
                        {

                        }
                        else if (result1 < result2)
                        {
                            bestLeftIndex = leftIndex;
                            bestSequence = bestDna;
                            maxSequence = bestCounter;
                            bestSeqinputCount++;
                        }
                    }
                }
                bestCounter = 0;
                currentCounter = 0;
                leftIndex = 0;
                anotherFokinCOunter++;

                input = Console.ReadLine();
            }
            result1 = bestSequence.Sum();
            Console.WriteLine($"Best DNA sample {bestSeqinputCount} with sum: {result1}.");
            Console.WriteLine(string.Join(" ", bestSequence));

        }
    }
}