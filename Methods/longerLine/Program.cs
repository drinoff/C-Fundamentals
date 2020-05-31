using System;

namespace longerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3  = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var firstLane = LongerLine(x, y, x1, y1);
            var secondLine = LongerLine(x2, y2, x3, y3);
            if (firstLane >= secondLine)
            {
                var firstPoint = LongerLine(x, y, 0.0, 0.0);
                var secondPoint = LongerLine(x1, y1, 0.0, 0.0);
                if (firstPoint >= secondPoint)
                    Console.WriteLine($"({x}, {y})({x1}, {y1})");
                else
                    Console.WriteLine($"({x1}, {y1})({x}, {y})");
            }
            else
            {
                var firstPoint = LongerLine(x2, y2, 0.0, 0.0);
                var secondPoint = LongerLine(x3, x3, 0.0, 0.0);
                if (firstPoint >= secondPoint)
                    Console.WriteLine($"({x2}, {y2})({x3}, {y3})");
                else
                    Console.WriteLine($"({x3}, {y3})({x2}, {y2})");
            }

            static double LongerLine(double x, double y, double x1, double y1)
            {
                var LineLength = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1-y, 2));
                return LineLength;
            }            
        }
    }
}
