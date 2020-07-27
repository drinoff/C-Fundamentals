using System;
using System.Linq;

namespace numberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input !="End")
            {
                var command = input.Split().ToArray();
                var action = command[0];
                switch (action)
                {
                    case "Switch":
                        var index = int.Parse(command[1]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers[index] *= -1;
                        }
                        break;
                    case "Change":
                        index = int.Parse(command[1]);
                        var value = int.Parse(command[2]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers[index] = value;
                        }
                        break;
                    case "Sum":
                        var numberType = command[1];
                        switch (numberType)
                        {
                            case "Negative":
                                var negativeSum = numbers.Where(x => x < 0).Sum();
                                Console.WriteLine(negativeSum);
                                break;
                            case "Positive":
                                var positiveSum = numbers.Where(x => x > 0).Sum();
                                Console.WriteLine(positiveSum);
                                break;
                            case "All":
                                var allSum = numbers.Sum();
                                Console.WriteLine(allSum);
                                break;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers.Where(x=>x>=0)));
        }
    }
}
