

using System;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            var sum1 = Factorial(num1);
            var sum2 = Factorial(num2);

            double totalSum = sum1/ sum2;
            Console.WriteLine($"{totalSum:f2}");
        }
        static double Factorial(double num)
        {
            double sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
