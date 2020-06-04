using System;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.XPath;

namespace bombNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bomber = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bomb = bomber[0];
            var power = bomber[1];
            var index = 0;

            while (numbers.Contains(bomb))
            {
                index = numbers.IndexOf(bomb);
                var leftRange = power;
                var rightRange = power;

                if (index - leftRange < 0)
                {
                    leftRange = index;
                }
                if (index + rightRange > numbers.Count - 1)
                {
                    rightRange = numbers.Count - index -  1;
                }
                numbers.RemoveRange(index - leftRange, leftRange + rightRange + 1);
            }
            
            var result = numbers.Sum();
            Console.WriteLine(result);
        }
    }
}
