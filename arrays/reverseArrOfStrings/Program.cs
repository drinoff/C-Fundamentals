using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace NumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}