using System;
using System.Collections.Generic;
using System.Linq;

namespace randomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Random rand = new Random();
            for (int i = 0; i < input.Count; i++)
            {
                
                int temp = rand.Next(0, input.Count);
                string temp2 = input[temp];
                input[temp] = input[i];

                input[i] = temp2;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
