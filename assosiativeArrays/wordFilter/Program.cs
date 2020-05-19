using System;
using System.Linq;

namespace wordFilter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] result = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
