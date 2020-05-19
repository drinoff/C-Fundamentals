using System;

namespace mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            double power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberPow(number, power));
        }
        static double NumberPow(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
