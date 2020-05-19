using System;
using System.Linq;

namespace evenOddSubtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int sumDiff = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                }
                else
                {
                    oddSum += nums[i];
                }
            }
            sumDiff = evenSum - oddSum;
            Console.WriteLine(sumDiff);

        }
    }
}
