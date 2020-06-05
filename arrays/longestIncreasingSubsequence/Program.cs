using System;
using System.Collections.Generic;
using System.Linq;

namespace longestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var maxSeq = new Dictionary<int, List<int>>();
            var firstKVP = new List<int>();
            firstKVP.Add(numbers[0]);

            maxSeq.Add(0, firstKVP);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    
                    
                }
            }
        }
    }
}
