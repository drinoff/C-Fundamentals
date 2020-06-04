using System;
using System.Collections.Generic;
using System.Linq;

namespace listOps
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var command = input.Split().ToArray();
                var action = command[0];
                switch (action)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) > numbers.Count-1 || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > numbers.Count - 1 || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Shift":
                        numbers = ShiftLeftorRightXTimes(numbers, int.Parse(command[2]), command[1]);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
        static List<int> ShiftLeftorRightXTimes(List<int> numbers, int count, string leftOrRight)
        {
            var temp = 0;
            if (leftOrRight == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    temp = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(temp);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    temp = numbers[numbers.Count-1];
                    numbers.RemoveAt(numbers.Count-1);
                    numbers = numbers.Prepend(temp).ToList();
                }
            }
            return numbers;
        }
    }
}
