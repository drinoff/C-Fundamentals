using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace listManipulationBasics
{
    class Program
    {
        static void PrintEvenNums(List<int> numbers)
        {
            
            List<int> evenNums = new List<int>();
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                {
                    evenNums.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", evenNums));
        }
        static void PrintOddNums(List<int> numbers)
        {
            List<int> oddNums = new List<int>();
            foreach (int element in numbers)
            {
                if (element % 2 != 0)
                {
                    oddNums.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", oddNums));
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersCopy = numbers;
            string input = Console.ReadLine();
            bool isChanged = false;

            while (input != "end")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEvenNums(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNums(numbers);

                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        isChanged = true;
                        break;
                    case "Filter":
                        switch (commands[1])
                        {
                            case ">":
                                List<int> num1 = new List<int>();
                                foreach (int element in numbers)
                                {
                                    if (element > int.Parse(commands[2]))
                                    {
                                        num1.Add(element);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", num1));
                                break;
                            case "<":
                                List<int> num2 = new List<int>();
                                foreach (int element in numbers)
                                {
                                    if (element < int.Parse(commands[2]))
                                    {
                                        num2.Add(element);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", num2));
                                break;
                            case ">=":
                                List<int> num3 = new List<int>();
                                foreach (int element in numbers)
                                {
                                    if (element >= int.Parse(commands[2]))
                                    {
                                        num3.Add(element);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", num3));
                                break;
                            case "<=":
                                List<int> num4 = new List<int>();
                                foreach (int element in numbers)
                                {
                                    if (element <= int.Parse(commands[2]))
                                    {
                                        num4.Add(element);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", num4));
                                break;
                        }
                        break;

                }

                input = Console.ReadLine();

            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }


        }
    }
}