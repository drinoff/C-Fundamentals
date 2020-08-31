using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace digitsLettersOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToCharArray();
            var digitList = new List<char>();
            var letterList = new List<char>();
            var restList = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    digitList.Add(str[i]);
                }
                else if (char.IsLetter(str[i]))
                {
                    letterList.Add(str[i]);
                }
                else
                {
                    restList.Add(str[i]);
                }
            }
            Console.WriteLine(string.Join("", digitList));
            Console.WriteLine(string.Join("", letterList));
            Console.WriteLine(string.Join("", restList));
        }
    }
}
