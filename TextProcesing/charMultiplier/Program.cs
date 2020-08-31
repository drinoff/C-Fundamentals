using System;

namespace charMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];
            var result = CharMultiplier(str1, str2);
            Console.WriteLine(result);

        }
        public static int CharMultiplier(string str1, string str2)
        {
            var charArray1 = str1.ToCharArray();
            var charArray2 = str2.ToCharArray();
            var result = 0;
            var count = 0;
            var firstIsBigger = false;
            if (charArray1.Length > charArray2.Length)
            {
                count = charArray2.Length;
                firstIsBigger = true;

            }
            else if (charArray1.Length<=charArray2.Length)
            {
                count = charArray1.Length;
            }

            for (int i = 0; i < count; i++)
            {
                var sum = charArray1[i] * charArray2[i];
                result += sum;
            }
            if (firstIsBigger)
            {
                
                for (int i = charArray2.Length; i < charArray1.Length; i++)
                {
                    result += charArray1[i];
                }
            }
            else
            {
                for (int i = charArray1.Length; i < charArray2.Length; i++)
                {
                    result += charArray2[i];
                }
            }

            return result;
        }
    }
}
