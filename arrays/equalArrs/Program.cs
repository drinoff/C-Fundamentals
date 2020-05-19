using System;
using System.Linq;

namespace equalArrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int arrIndex = 0;
            bool notIdentical = false;
            int sumArrOne = 0;
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    sumArrOne += arrOne[i];
                }
                else
                {
                    arrIndex = i;
                    notIdentical = true;
                    break;
                }
            }
            if (notIdentical)
                Console.WriteLine($"Arrays are not identical. Found difference at {arrIndex} index");
            else
                Console.WriteLine($"Arrays are identical. Sum: {sumArrOne}");
        }

    }
}
