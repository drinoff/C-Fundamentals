using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.OrderByDescending(x => x);
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
