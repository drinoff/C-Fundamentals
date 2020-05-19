using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace oddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputA = Console.ReadLine().ToLower();
            string[] input = inputA.Split().ToArray();
            var oddNumApp = new Dictionary<string, int>();
            
            foreach (var item in input)
            {
                if (oddNumApp.ContainsKey(item))
                {
                    oddNumApp[item]++;
                }
                else
                {
                    oddNumApp.Add(item, 1);
                }
            }
            var result = new List<string>();

            foreach (var item in oddNumApp)
            {
                if (item.Value % 2 != 0)
                { result.Add(item.Key); }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
