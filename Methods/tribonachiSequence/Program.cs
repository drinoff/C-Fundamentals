using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace tribonachiSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            var array = Tribonacci(num);
            Console.WriteLine(string.Join(" ", array));
        }
        static long[] Tribonacci(long num)
        {
            var array = new long[num];
            if (num == 1)
            {
                array[0] = 1;
                return array;
            }
            else if (num == 2)
            {
                array[0] = 1;
                array[1] = 1;
                return array;
            }
            else if (num == 3)
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                return array;
            }
            else
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                for (int i = 3; i < num; i++)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
                return array;
            }
        }
    }
}
