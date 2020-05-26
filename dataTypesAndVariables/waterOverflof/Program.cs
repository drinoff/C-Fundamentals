using System;

namespace waterOverflof
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = 255;
            var poursCount = int.Parse(Console.ReadLine());

            var sumLiters = 0;
            for (int i = 0; i < poursCount; i++)
            {
                var litersAdd = int.Parse(Console.ReadLine());
                if (sumLiters + litersAdd <= tank)
                    sumLiters += litersAdd;
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sumLiters);
        }
    }
}
