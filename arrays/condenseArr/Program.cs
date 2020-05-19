using System;
using System.Linq;

namespace condenseArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (numbers.Length==1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
            one:
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];


                }
                Array.Resize(ref numbers, numbers.Length - 1);
                if (numbers.Length == 1)
                    Console.WriteLine(numbers[0]);
                else
                    goto one;

            }
           
        }
    }
}
