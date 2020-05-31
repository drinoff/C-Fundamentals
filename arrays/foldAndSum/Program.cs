using System;
using System.Linq;

namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            var len = arr.Length/4;
            var secondArr = arr
                .Skip(len)
                .Take(2 * len)
                .ToArray();
            var thirdArr = arr
                .Take(len)
                .Reverse()               
                .ToArray();
            var helperArr = arr.Skip(3 * len).Take(len).Reverse().ToArray();
            var resultArrThirdplusForth = new int[thirdArr.Length + helperArr.Length];
            thirdArr.CopyTo(resultArrThirdplusForth, 0);
            helperArr.CopyTo(resultArrThirdplusForth, thirdArr.Length);

            var resultArr = new int[len*2];
            for (int i = 0; i < len*2; i++)
            {
                resultArr[i] = secondArr[i] + resultArrThirdplusForth[i];
            }
            Console.WriteLine(string.Join(" ", resultArr));
            
        }
    }
}
