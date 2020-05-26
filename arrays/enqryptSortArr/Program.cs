using System;
using System.Collections.Generic;
using System.Linq;

namespace enqryptSortArr
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringsCount = int.Parse(Console.ReadLine());
            var vowels = new char[]
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'A',
                'E',
                'I',
                'O',
                'U'
            };
            var result = new List<int>();
            var finalResult = new List<int>();

            for (int i = 0; i < stringsCount; i++)
            {
                var str = Console.ReadLine().ToCharArray();
                for (int j = 0; j < str.Length; j++)
                {
                    if (vowels.Contains(str[j]))
                    {
                        result.Add(str[j] * str.Length);

                    }
                    else
                    {
                        result.Add(str[j] / str.Length);
                    }
                }
                finalResult.Add(result.Sum());
                result.Clear();
            }
            var sorted = finalResult.OrderBy(x => x);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
