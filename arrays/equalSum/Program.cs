using System;
using System.Linq;

namespace equalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 )
                {
                    leftSum = 0;
                    rightSum = input.Sum() - input[i];
                }
                else if (i == input.Length)
                {
                    rightSum = 0;
                    leftSum = input.Sum() - input[input.Length];
                }
                else
                {
                    leftSum = input.Take(i).Sum();
                    rightSum = input.Skip(i + 1).Sum();
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    break;
                }
                
            }
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
