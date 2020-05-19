using System;

namespace mathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(MathOps(a, operand, b));
        }
        static double MathOps(int a , string operand, double b)
        {
            double result = 0;
            switch (operand)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a * 1.0/ b;
                    break;

            }
            return result;
        }
    }
}
