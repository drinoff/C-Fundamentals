using System;
using System.Diagnostics.CodeAnalysis;

namespace calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (operation == "add")
                Add(num, num1);
            else if (operation == "multiply")
                Multiply(num, num1);
            else if (operation == "subtract")
                Subtract(num, num1);
            else
                Divide(num, num1);
        }

        static void Add(int num, int num1)
        {
            int result = num + num1;
            Console.WriteLine(result);
        }

        static void Multiply(int num, int num1)
        {
            int result = num * num1;
            Console.WriteLine(result);
        }

        static void Subtract(int num, int num1)
        {
            int result = num - num1;
            Console.WriteLine(result);
        }

        static void Divide(int num, int num1)
        {
            int result = (num / num1);
            Console.WriteLine(result);
        }
    }

}
