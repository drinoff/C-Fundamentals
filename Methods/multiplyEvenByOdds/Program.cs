using System;

namespace multiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int one = GetSumOfEvenDigits(number);
            int two = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdd(one, two));   
        }
        static int GetMultipleOfEvenAndOdd(int one, int two)
        {
            int result = one * two;
            return result;
        }
        static int GetSumOfEvenDigits(int number)
        {
            
            int evenSum = 0;
            while (number >= 1)
            {
                if (number % 10 != 0)
                {
                    if (number % 10 % 2 == 0)
                    {
                        evenSum += number % 10;
                    }
                }

                number = number / 10;                               
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {

            int oddSum = 0;
            while (number >= 1)
            {
                if (number % 10 != 0)
                {
                    if (number % 10 % 2 != 0)
                    {
                        oddSum += number % 10;
                    }
                }

                number = number / 10;
            }

            return oddSum;
        }
    }
}
