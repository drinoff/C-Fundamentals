using System;

namespace printingTriangle
{
    class Program
    {
        static void PrintTriangle()
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols+ " ");

                }
                Console.WriteLine();
            }
            for (int rows = n-1; rows>0 ; rows--)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols + " ");

                }
                Console.WriteLine();


            }
        }

        static void Main(string[] args)
        {
            PrintTriangle();
        }
    }
}
