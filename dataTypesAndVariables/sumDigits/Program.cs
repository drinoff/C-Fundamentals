using System;
using System.Collections.Generic;
using System.Linq;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().ToCharArray();
            var sum = 0.0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += char.GetNumericValue(number[i]);

            }
        Console.WriteLine(sum);
            
        }
    }
}
