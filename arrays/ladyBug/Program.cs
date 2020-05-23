using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ladyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugStartingIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var ladyBugStartingPositionsList = new int[fieldSize];

            for (int i = 0; i < ladyBugStartingIndexes.Length; i++)
            {
                if (ladyBugStartingIndexes[i] < fieldSize && ladyBugStartingIndexes[i] >= 0)
                {
                    ladyBugStartingPositionsList[ladyBugStartingIndexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                var move = command
                    .Split()
                    .ToArray();
                var initialPos = int.Parse(move[0]);
                var direction = move[1];
                var movesCount = int.Parse(move[2]);
                if (movesCount < 0)
                {
                    if (direction == "left")
                    {
                        direction = "right";
                        movesCount *= -1;

                    }
                    else
                    {
                        direction = "left";
                        movesCount *= -1;
                    }
                }
                if (direction == "right")
                {
                    if (initialPos + movesCount <= fieldSize - 1 && initialPos >= 0 && initialPos <= fieldSize-1)
                    {
                        if (ladyBugStartingPositionsList[initialPos] == 1 && ladyBugStartingPositionsList[initialPos + movesCount] == 0)
                        {
                            ladyBugStartingPositionsList[initialPos + movesCount] = 1;
                            if (movesCount == 0)
                            {

                            }
                            else
                            {
                                ladyBugStartingPositionsList[initialPos] = 0;
                            }
                        }
                        else if (ladyBugStartingPositionsList[initialPos] == 1 && ladyBugStartingPositionsList[initialPos + movesCount] == 1)
                        {
                            if (movesCount == 0)
                            {
                            }
                            else
                            {
                                for (int i = initialPos + movesCount + movesCount; i <= fieldSize - 1; i += movesCount)
                                {
                                    if (ladyBugStartingPositionsList[i] == 0)
                                    {
                                        ladyBugStartingPositionsList[i] = 1;
                                        break;
                                    }
                                }
                                ladyBugStartingPositionsList[initialPos] = 0;
                            }
                        }
                    }
                    else if (initialPos + movesCount > fieldSize - 1 && initialPos >= 0 && initialPos <= fieldSize-1)
                    {
                        if (movesCount == 0)
                        {
                        }
                        else
                        {
                            ladyBugStartingPositionsList[initialPos] = 0;
                        }
                    }
                }
                else
                {
                    if (initialPos - movesCount >= 0 && initialPos >= 0 && initialPos <= fieldSize-1)
                    {
                        if (ladyBugStartingPositionsList[initialPos] == 1 && ladyBugStartingPositionsList[initialPos - movesCount] == 0)
                        {
                            ladyBugStartingPositionsList[initialPos - movesCount] = 1;
                            if (movesCount == 0)
                            {
                            }
                            else
                            {
                                ladyBugStartingPositionsList[initialPos] = 0;
                            }
                        }
                        else if (ladyBugStartingPositionsList[initialPos] == 1 && ladyBugStartingPositionsList[initialPos - movesCount] == 1)
                        {
                            if (movesCount == 0)
                            {
                            }
                            else
                            {
                                for (int i = initialPos - movesCount - movesCount; i <= 0; i -= movesCount)
                                {
                                    if (ladyBugStartingPositionsList[i] == 0)
                                    {
                                        ladyBugStartingPositionsList[i] = 1;
                                        break;
                                    }
                                }
                                ladyBugStartingPositionsList[initialPos] = 0;
                            }
                        }
                    }
                    else if (initialPos - movesCount < 0 && initialPos >= 0 && initialPos <= fieldSize-1)
                    {
                        if (movesCount == 0)
                        {
                        }
                        else
                        {
                            ladyBugStartingPositionsList[initialPos] = 0;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugStartingPositionsList));
        }
    }
}
