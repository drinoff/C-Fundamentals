using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            NxNMatrix(num);
        }
        static void NxNMatrix(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols < num; cols++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
