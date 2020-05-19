using System;

namespace NumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = new string[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[numbers.Length -i -1] = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}