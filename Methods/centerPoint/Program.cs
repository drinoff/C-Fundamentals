using System;

namespace centerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var result = LongerLine(x, y, 0.0, 0.0);
            var result1 = LongerLine(x1, y1, 0.0, 0.0);

            if (result<=result1)
                Console.WriteLine($"({x}, {y})");
            else
                Console.WriteLine($"({x1}, {y1})");
        }
        static double LongerLine(double x, double y, double x1, double y1)
        {
            var LineLength = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));
            return LineLength;
        }
    }
}
