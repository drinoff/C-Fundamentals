using System;
using System.Linq;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == number)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
            }


        }
    }
}
