
using System;
using System.Linq;
using System.Numerics;

namespace fromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                long leftNum = long.Parse(input[0]);
                long rightNum = long.Parse(input[1]);
                if (leftNum > rightNum)
                {
                    if (leftNum < 0)
                        {
                        leftNum *= -1;
                        }
                    var leftString = leftNum
                        .ToString()
                        .Select(digit => int.Parse(digit.ToString()));
                    var leftSum = leftString.Sum();
                    Console.WriteLine(leftSum);

                }
                else
                {
                    if (rightNum < 0)
                    {
                        rightNum *= -1;
                    }
                    var rightString = rightNum
                        .ToString()
                        .Select(digit => int.Parse(digit.ToString()));
                    var rightSum = rightString.Sum();
                    Console.WriteLine(rightSum);
                }
            }
        }
    }
}
