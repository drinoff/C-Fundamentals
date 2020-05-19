using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace topInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> arrTwo = new List<int>();



            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length-1)
                {
                    arrTwo.Add(arr[i]);
                }
                else
                {
                    var result = arr.Skip(i + 1).Max();
                    if (arr[i] > result)
                    {
                        arrTwo.Add(arr[i]);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", arrTwo));


        }
    }
}
