using System;
using System.Collections.Generic;
using System.Linq;

namespace GausTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNumbers = new List<int>();

            
                int k = 0;
            if (numbers.Count % 2 != 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    newNumbers.Add(numbers[i] + numbers[numbers.Count- i - 1]);

                }
                k = numbers[numbers.Count / 2];
                newNumbers.Add(k);
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    newNumbers.Add(numbers[i] + numbers[numbers.Count - i - 1]);
                    

                }
                
            }
            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
