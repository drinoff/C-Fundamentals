using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace archeryTournament
{
    static class GlobalVar
    {
        public static int points;
    }
    class Program
    {


        static void Main(string[] args)
        {

            var targetField = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "Game over")
            {
                if (input == "Reverse")
                {
                    targetField = targetField.Reverse().ToArray();

                }
                else
                {

                    var command1 = input.Split();
                    var command = command1[1].Split("@");
                    switch (command[0])
                    {
                        case "Left":
                            var startIndex = int.Parse(command[1]);
                            var length = int.Parse(command[2]);
                            if (startIndex >= 0 && startIndex <= targetField.Length - 1)
                            {
                                while (length != 0)
                                {
                                    if (startIndex > 0)
                                    {
                                        startIndex--;
                                        length--;
                                    }
                                    else if (startIndex == 0)
                                    {
                                        startIndex = targetField.Length - 1;
                                        length--;
                                    }
                                }

                                if (targetField[startIndex] <= 5)
                                {
                                    targetField[startIndex] = 0;
                                    GlobalVar.points += targetField[startIndex];
                                }
                                else
                                {
                                    targetField[startIndex] -= 5;
                                    GlobalVar.points += 5;
                                }
                            }
                            break;
                        case "Right":
                            startIndex = int.Parse(command[1]);
                            length = int.Parse(command[2]);

                            if (startIndex >= 0 && startIndex <= targetField.Length - 1)
                            {
                                while (length != 0)
                                {
                                    if (startIndex < targetField.Length - 1)
                                    {
                                        startIndex++;
                                        length--;
                                    }
                                    else if (startIndex == targetField.Length - 1)
                                    {
                                        startIndex = 0;
                                        length--;
                                    }
                                }

                                if (targetField[startIndex] <= 5)
                                {
                                    targetField[startIndex] = 0;
                                    GlobalVar.points += targetField[startIndex];
                                }
                                else
                                {
                                    targetField[startIndex] -= 5;
                                    GlobalVar.points += 5;
                                }
                            }
                            break;

                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", targetField));
            Console.WriteLine($"Iskren finished the archery tournament with {GlobalVar.points} points!");
        }
    }
}
