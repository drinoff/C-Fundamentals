using System;
using System.Linq;

namespace pascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rowsCount = long.Parse(Console.ReadLine());
            int[,] pascalMatrix = new int[rowsCount, rowsCount];           
            if (rowsCount >= 1)
            {
                pascalMatrix[0, 0] = 1;
            }
            if (rowsCount >= 2)
            {
                pascalMatrix[1, 0] = 1;
                pascalMatrix[1, 1] = 1;

            }

            if (rowsCount>=3)
            for (int rows = 2; rows < rowsCount; rows++)
            {
                for (int cols = 1; cols < rowsCount; cols++)
                {
                    pascalMatrix[rows, 0] = 1;
                    pascalMatrix[rows, cols] = 1;
                    pascalMatrix[rows, cols] = pascalMatrix[rows - 1, cols] + pascalMatrix[rows - 1, cols - 1];
                }
            }

            for (int rows = 0; rows < rowsCount; rows++)
            {
                for (int cols = 0; cols < rows+1; cols++)
                {
                    Console.Write(pascalMatrix[rows, cols] + " ");
                }
                    Console.WriteLine();
            } 
        }
    }
}
