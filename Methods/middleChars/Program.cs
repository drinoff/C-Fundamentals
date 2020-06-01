using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace middleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomText = Console.ReadLine();
            Console.WriteLine(string.Join("",MiddleChars(randomText)));
        }
        static char[] MiddleChars(string randomText)
        {
            if (randomText.Length % 2 == 0)
            {
                var index = randomText.Length / 2;
                var middleChars = randomText
                    .Skip((randomText.Length / 2) - 1)
                    .Take(2)
                    .ToArray();
                return middleChars;
            }
            else
            {
                var middleChars = randomText
                   .Skip(randomText.Length / 2)
                   .Take(1)
                   .ToArray();
                return middleChars;
            }
        }
    }
}
