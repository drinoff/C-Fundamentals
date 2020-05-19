using System;
using System.Linq;

namespace zigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrOne = new string[n];
            string[] arrTwo = new string[n];
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] arrTemp = Console.ReadLine().Split().ToArray();

                if (i % 2 != 0)
                {
                    arrOne[k] = arrTemp[0];
                    arrTwo[k] = arrTemp[1];
                }
                else
                {
                    arrOne[k] = arrTemp[1];
                    arrTwo[k] = arrTemp[0];
                }
                k++;
            }
            Console.WriteLine(String.Join(" ", arrOne));
            Console.WriteLine(String.Join(" ", arrTwo));
        }
    }
}
