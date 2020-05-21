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

            int counter1 = 0;
            int counter2 = 0;
            int result1 = 0;
            int result2 = 0;
            var leftMostIndex = 0;
            var dnaSample = 0;

            while (input != "Clone them!")
            {

                string sequence = input.Split("!").ToString();
                int[] oneSeq = sequence.Split("0").Select(int.Parse).ToArray();
                Console.WriteLine(string.Join(" ",oneSeq));

                var countOnes = sequence.Count(x => x == 1);

              
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {result2}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}
