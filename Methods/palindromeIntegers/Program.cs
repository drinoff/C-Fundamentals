using System;
using System.Linq;
using System.Text;

namespace palindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(PalindromeNumber(input).ToString().ToLower());

                

                input = Console.ReadLine();
            }
        }
        static bool PalindromeNumber(string input)
        {
            string paliNumber = string.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                paliNumber += input[i];
            }
                
            if (input == paliNumber)
                return true;
            else
                return false;
        }
    }
}
