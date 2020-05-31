using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace multiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());
            var list = new List<int>()
            {
                numOne,
                numTwo,
                numThree
            };           
            Console.WriteLine(ProductSign(numOne,numTwo,numThree, list));
        }
        static string ProductSign(int numOne, int numTwo, int numThree, List<int> list)
        {
            if (list.Contains(0))
            {
                return "zero";
            }
            else
            {
               var negativeCount =  list.FindAll(x => x < 0).Count;
                if (negativeCount % 2 == 0)
                {
                    return "positive";
                }
                else
                    return "negative";
            }
        }
    }
}
