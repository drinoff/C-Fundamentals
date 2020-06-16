using System;
using System.Collections.Generic;
using System.Linq;

namespace mixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();
            var counter = 0;
            list2.Reverse();
            bool firstIsBigger = false;
            if (list1.Count > list2.Count)
            {
                counter = list2.Count;
                firstIsBigger = true;
            }
            else
            {
                counter = list1.Count;
            }
            MixList(list1, list2, resultList, counter);
            var finalResult = new List<int>();
            if (firstIsBigger)
            {
                if (list1[list1.Count - 2] > list1[list1.Count - 1])
                {
                    finalResult = resultList.Where(x => x > list1[list1.Count - 1] && x < list1[list1.Count - 2]).ToList();
                }
                else
                {
                    finalResult = resultList.Where(x => x > list1[list1.Count - 2] && x < list1[list1.Count - 1]).ToList();
                }
            }
            else
            {
                if (list2[list2.Count - 2] > list2[list2.Count - 1])
                {
                    finalResult = resultList.Where(x => x > list2[list2.Count - 1] && x < list2[list2.Count - 2]).ToList();
                }
                else
                {
                    finalResult = resultList.Where(x => x > list2[list2.Count - 2] && x < list2[list2.Count - 1]).ToList();
                }
            }
            Console.WriteLine(string.Join(" ",finalResult.OrderBy(x=>x)));
            
        }
        static List<int> MixList(List<int> list1, List<int> list2, List<int> resultList, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                resultList.Add(list1[i]);
                resultList.Add(list2[i]);
            }
            return resultList;
        }
    }
}
