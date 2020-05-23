using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            

            
            int count = 1;
            
            int longestNum = input[0];
            
            int longestCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                
                if (input[i] != input[i - 1])
                {
                    count = 0;
                }

                count++;
                
                if (count > longestCount)
                {
                    longestCount = count;
                    longestNum = input[i];
                }
            }

            
            Console.WriteLine(
                string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));

            
        }
    }
}
