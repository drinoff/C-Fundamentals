using System;

namespace charsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharsInRange(first, second);
        }
        static void CharsInRange(int first, int second)
        {
            if (first < second)
            {
                for (char i = (char)(first + 1); i < (char)second; i++)
                {
                    Console.Write(i + " ");

                }
            }
            else
                for (char i = (char)(second + 1); i < (char)first; i++)
                {
                    Console.Write(i + " ");

                }



        }
    }
}
