using System;
using System.Linq;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(train.Sum());

        }
    }
}
