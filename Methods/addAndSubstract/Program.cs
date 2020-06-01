using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace addAndSubstract
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            int sum2 = Substract(sum, num3);
            Console.WriteLine(sum2);
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Substract(int x, int z)
        {
            return x - z;
        }
    }
}
