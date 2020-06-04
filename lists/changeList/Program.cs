using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (input !="end")
            {
                var command = input.Split().ToArray();
                var action = command[0];
                switch (action)
                {
                    case "Delete":
                        var element = int.Parse(command[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == element)
                                numbers.Remove(numbers[i]);
                        }
                        break;
                    case "Insert":
                        element = int.Parse(command[1]);
                        var position = int.Parse(command[2]);
                        numbers.Insert(position, element);
                        break;                        
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
