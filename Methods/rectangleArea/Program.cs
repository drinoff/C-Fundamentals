using System;

namespace rectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(length, width));
        }

        static double RectangleArea(double length, double width)
        {
            double result = length * width;
            return result;
        }
    }
}
