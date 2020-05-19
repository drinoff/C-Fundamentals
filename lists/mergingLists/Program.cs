using System;
using System.Collections.Generic;
using System.Linq;

namespace mergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNumbers = new List<int>();

                    int j = 0;
                    int k = 0;
            if (numbers1.Count >= numbers2.Count)
            {
                newNumbers = numbers1;
                for (int i = 0; i < numbers2.Count*2; i+=2)
                {
                    newNumbers.Insert(i + 1, numbers2[k]);
                    k++;
                }
            }
            else
            {
                newNumbers = numbers2;
                for (int i = 0; i < numbers1.Count*2; i += 2)
                {
                    newNumbers.Insert(i, numbers1[j]);
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
