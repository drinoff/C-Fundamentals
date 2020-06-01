using System;

namespace topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            for (int i = 1; i <= int.Parse(num); i++)
            {
                if (SumDigitsDivisibleBy8(i) && HoldAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
        static bool SumDigitsDivisibleBy8(int num)
        {                       
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 8 == 0)
                return true;
            else
                return false;            
        }
        static bool HoldAtLeastOneOddDigit(int num)
        {
            while(num >0)
            {
                if (num % 2 != 0)
                {
                    return true;                    
                }
                num /= 10;
            }
            return false;
        }
    }
}
