using System;

namespace Methods
{
    class Program
    {
        static void IntegerSign(double num)
        {

            if (num > 0)
                Console.WriteLine($"The number {num} is positive.");
            else if (num < 0)
                Console.WriteLine($"The number {num} is negative.");
            else
                Console.WriteLine($"The number {num} is zero.");
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            IntegerSign(num);

        }
    }
}
