using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var skipList = new List<int>();
            var takeList = new List<int>();
            StringBuilder result = new StringBuilder();

            string pattern = @"\d";
            Regex rg = new Regex(pattern);

            MatchCollection digits = rg.Matches(inputString);
            var modifiedInputString = rg.Replace(inputString, "");

            for (int i = 0; i < digits.Count; i++)
            {
                int output = int.Parse(digits[i].Value);

                if (i % 2 == 0)
                {
                    takeList.Add(output);
                }
                else
                {
                    skipList.Add(output);
                }
            }

            for (int i = 0; i < takeList.Count; i++)
            {               
                var takenChars = modifiedInputString.Take(takeList[i]).ToList();
                var mazaloChars = string.Join("", takenChars);
                if (takeList[i] > modifiedInputString.Length)
                {
                    takeList[i] = modifiedInputString.Length;
                }
                modifiedInputString = modifiedInputString.Remove(0, takeList[i]);
                result.Append(mazaloChars);
                if (skipList[i] > modifiedInputString.Length)
                {
                    skipList[i] = modifiedInputString.Length;
                }
                modifiedInputString = modifiedInputString.Remove(0, skipList[i]);
            }
            var finalResult = result.ToString();

            Console.WriteLine(string.Join("", finalResult));
        }
    }
}
