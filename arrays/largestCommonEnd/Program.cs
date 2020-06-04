using System;
using System.Collections.Generic;
using System.Linq;

namespace largestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().ToArray();
            var arr2 = Console.ReadLine().Split().ToArray();
            var list1 = new List<int>();
            var list2 = new List<int>();

            var arrCommon = arr1.Intersect(arr2).ToArray();
            var element = arrCommon[0];

            foreach (var item in arrCommon)
            {
                var indexArrr1 = Array.IndexOf(arr1, item);
                var indexArrr2 = Array.IndexOf(arr2, item);
                list1.Add(indexArrr1);
                list2.Add(indexArrr2);
            }
           

            var commonIndexes = list1.Intersect(list2).ToList();

            int count = commonIndexes.Count;
            var findLeftOrRight = Array.IndexOf(arr1, commonIndexes[0]);
            if (findLeftOrRight > arr1.Length / 2)
            {
                var result = arr1.Skip(arr1.Length - count).ToArray();
                Console.WriteLine($"The largest common end is at the right: {string.Join(" ", result)}");
            }
            else
            {
                var result = arr1.Take(count).ToArray();
                Console.WriteLine($"The largest common end is at the left: {string.Join(" ", result)}");
            }
        }
    }
}
