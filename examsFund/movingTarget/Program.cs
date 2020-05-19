using System;
using System.Collections.Generic;
using System.Linq;

namespace movingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
            string[] command = input.Split();
                int index = int.Parse(command[1]);
                int actionPower = int.Parse(command[2]);
                switch (command[0])
                {
                    case "Shoot":
                        if (index < target.Count && target[index] != 0)
                        {
                            target[index] -= actionPower;
                            if (target[index] <=0)
                            {
                                target.RemoveAt(index);
                            }
                        }
                        else
                        {

                        }

                        break;
                    case "Add":
                        if (index < target.Count)
                        {
                            target.Insert(index, actionPower);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;
                    case "Strike":
                        if (index+actionPower< target.Count && index-actionPower>=0)
                        {
                            target.RemoveRange(index - actionPower, actionPower * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", target));
        }
    }
}
