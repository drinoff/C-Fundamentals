using System;

namespace floatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var eps = 0.000001;
            if (Math.Abs(a - b) >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else
                Console.WriteLine("True");
        }
    }
}
