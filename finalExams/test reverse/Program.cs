using System;
using System.Linq;

namespace test_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            Console.WriteLine(ReverseString(test));

        }

        private static string ReverseString(string test)
        {
            var reversed = test.Reverse();
            var result = string.Join("", reversed);
            return result;
        }
    }
}
