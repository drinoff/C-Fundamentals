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


            var bestcounter = 1;
            var currentCounter = 1;
            int leftIndex = 0;
            var bestDna = new int[dnaLength.Length];


            while (input != "Clone them!")
            {
                var sequence = input
                    .Split("!")
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (i + 1 == i && i == 1)
                    {
                        currentCounter++;
                    }
                    else
                    {
                        if (currentCounter > bestcounter)
                        {
                            bestDna = sequence;
                            bestcounter = currentCounter;
                            leftIndex = currentCounter - i;
                            currentCounter = 1;
                        }



                    }
                }
            }   

        }
    }
}