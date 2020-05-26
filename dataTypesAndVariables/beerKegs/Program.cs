using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var kegs = new Dictionary<string, double>();
            var kegsCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= kegsCount; i++)
            {
                var kegModel = Console.ReadLine();
                var kegRadius = double.Parse(Console.ReadLine());
                var kegHeight = int.Parse(Console.ReadLine());
                kegs.Add(kegModel, Math.PI * kegRadius * kegRadius * kegHeight);
            }

            var bigestKeg = kegs
                .Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine(bigestKeg);

        }
    }
}
