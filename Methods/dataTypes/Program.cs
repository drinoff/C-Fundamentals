using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                Console.WriteLine(IntType(int.Parse(Console.ReadLine())));
            }
            else if (input == "real")
            {
                Console.WriteLine($"{RealType(double.Parse(Console.ReadLine())):f2}");
            }
            else
                Console.WriteLine($"${Console.ReadLine()}$");
        }
        static int IntType(int a)
        {
            return a * 2;
        }
        static double RealType(double a)
        {
            return a * 1.50;
        }       
    }
}
