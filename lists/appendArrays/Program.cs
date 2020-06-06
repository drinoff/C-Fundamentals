using System;
using System.Collections.Generic;
using System.Linq;

namespace appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var apendArrays = new List<int>();
            var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = input.Length-1; i >=0; i--)
            {
                var splittedInput = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < splittedInput.Length; j++)
                {
                    apendArrays.Add(int.Parse(splittedInput[j]));
                }
            }
            Console.WriteLine(string.Join(" ",apendArrays));
        }
    }
}
