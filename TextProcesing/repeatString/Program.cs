using System;
using System.Text;

namespace repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sb.Append(arr[i]);
                }
            }
            var result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
