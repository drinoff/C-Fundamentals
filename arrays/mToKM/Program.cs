using System;

namespace mToKM
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            var kilometers = meters* 1.0 / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
