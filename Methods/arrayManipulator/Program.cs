using System;
using System.Collections.Generic;
using System.Linq;

namespace arrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var command = Console.ReadLine();
            while (command != "end")
            {
                var splittedCommand = command.Split().ToArray();
                var operation = splittedCommand[0];
                var operationParameter = splittedCommand[1];
                string evenOrOdd = string.Empty;

                if (splittedCommand.Length == 3)
                {
                    evenOrOdd = splittedCommand[2];
                }
                switch (operation)
                {
                    case "exchange":
                        var operationParameterasNumber = int.Parse(operationParameter);
                        if (operationParameterasNumber < 0 || operationParameterasNumber > array.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            array = Exchange(operationParameter, array);
                        }
                        break;
                    case "max":
                        MaxEvenorOdd(operationParameter, array);
                        break;
                    case "min":
                        MinEvenorOdd(operationParameter, array);
                        break;
                    case "first":
                        FirstEvenOdd(operationParameter, evenOrOdd, array);
                        break;
                    case "last":
                        LastEvenOdd(operationParameter, evenOrOdd, array);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.Write("]");
        }
        static int[] Exchange(string operationParameter, int[] array)
        {
            var operationParameterasNumber = int.Parse(operationParameter);
            var helperArray = new int[array.Length - operationParameterasNumber - 1];
            Array.Copy(array, operationParameterasNumber + 1, helperArray, 0, array.Length - operationParameterasNumber - 1);
            var anotherFockinhelperArray = helperArray.Concat(array.Take(operationParameterasNumber + 1));
            array = anotherFockinhelperArray.ToArray();
            return array;
        }
        static void MaxEvenorOdd(string operationParameter, int[] array)
        {
            var isFound = false;
            var index = 0;
            var maxEven = 0;
            var maxOdd = 0;
            if (operationParameter.ToString() == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= maxEven && array[i] % 2 == 0)
                    {
                        maxEven = array[i];
                        index = i;
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }           
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= maxOdd && array[i] % 2 != 0)
                    {
                        maxOdd = array[i];
                        index = i;
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(index);                    
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }            
        }
        static void MinEvenorOdd(string operationParameter, int[] array)
        {
            var index = 0;
            bool isFound = false;
            var minEven = 999999999;
            var minOdd = 999999999;
           
            if (operationParameter.ToString() == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= minEven && array[i] % 2 == 0)
                    {
                        minEven = array[i];
                        index = i;
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= minOdd && array[i] % 2 != 0)
                    {
                        minOdd = array[i];
                        index = i;
                        isFound = true;
                    }
                }
                if (isFound)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }            
        }
        static void FirstEvenOdd(string operationParameter, string evenOrOdd, int[] array)
        {
            var operationParameterasAnotherNumber = int.Parse(operationParameter);
            if (operationParameterasAnotherNumber > array.Length||operationParameterasAnotherNumber <=0)
            {
                Console.WriteLine("Invalid count");
            }
            else if (evenOrOdd == "even")
            {
                var even = Array.FindAll(array, x => x % 2 == 0).Take(operationParameterasAnotherNumber).ToArray();
                Console.Write("[");
                Console.Write(string.Join(", ", even));
                Console.Write("]");
                Console.WriteLine();
            }
            else
            {
                var odd = Array.FindAll(array, x => x % 2 != 0).Take(operationParameterasAnotherNumber).ToArray();
                Console.Write("[");
                Console.Write(string.Join(", ", odd));
                Console.Write("]");
                Console.WriteLine();
            }
        }
        static void LastEvenOdd(string operationParameter, string evenOrOdd, int[] array)
        {
            var operationParameterasAnotherFockinNumber = int.Parse(operationParameter);
            if (operationParameterasAnotherFockinNumber > array.Length || operationParameterasAnotherFockinNumber <= 0)
            {
                Console.WriteLine("Invalid count");
            }
            else if (evenOrOdd == "even")
            {
                var even = Array.FindAll(array, x => x % 2 == 0).TakeLast(operationParameterasAnotherFockinNumber).ToArray();
                Console.Write("[");
                Console.Write(string.Join(", ", even));
                Console.Write("]");
                Console.WriteLine();
            }
            else
            {
                var odd = Array.FindAll(array, x => x % 2 != 0).Take(operationParameterasAnotherFockinNumber).ToArray();
                Console.Write("[");
                Console.Write(string.Join(", ", odd));
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}