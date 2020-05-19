using System;
using System.Linq;

namespace commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();
            string[] arrThree = new string[arrOne.Length];
            int k = 0;

            for (int i = 0; i < arrTwo.Length; i++)
            {
                foreach (string element in arrOne)
                {
                    if (element == arrTwo[i])
                    {
                        
                        arrThree[k] = element;
                        k++;
                    }

                }
            }
            Console.WriteLine(String.Join(" ", arrThree));
        }
    }
}
