using System;
using System.Linq;

namespace lastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var paintingNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];

                switch (action)
                {
                    case "Change":
                        var number1 = int.Parse(command[1]);
                        var number2 = int.Parse(command[2]);
                        if (paintingNumbers.Contains(number1))
                        {
                            var index = paintingNumbers.IndexOf(number1);
                            paintingNumbers[index] = number2;
                        }
                        break;
                    case "Hide":
                        var number = int.Parse(command[1]);
                        paintingNumbers.Remove(number);
                        break;
                    case "Switch":
                        number1 = int.Parse(command[1]);
                        number2 = int.Parse(command[2]);
                        if (paintingNumbers.Contains(number1) && paintingNumbers.Contains(number2))
                        {
                            var index = paintingNumbers.IndexOf(number1);
                            var index2 = paintingNumbers.IndexOf(number2);
                            var temp = number1;
                            paintingNumbers[index] = number2;
                            paintingNumbers[index2] = number1;
                        }
                        break;
                    case "Insert":
                        var place = int.Parse(command[1]);
                        number = int.Parse(command[2]);
                        if (place + 1 <= paintingNumbers.Count - 1)
                        {
                            paintingNumbers.Insert(place + 1, number);
                        }

                        break;
                    case "Reverse":
                        paintingNumbers.Reverse();
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",paintingNumbers));
        }
    }
}
