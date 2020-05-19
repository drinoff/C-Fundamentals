using System;
using System.Linq;

namespace arrRot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int temp = 0;
            for (int i = 0; i < number; i++)
            {
                temp = arr[0];
                for (int item = 0; item < arr.Length-1; item++)
                {
                    arr[item] = arr[item + 1];
                    
                }
                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
