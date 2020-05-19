using System;
using System.Collections.Generic;
using System.Linq;

namespace shootForWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int shotTargets = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index < target.Count)
                {
                    if (target[index] != -1)
                    {
                        int temp = target[index];
                        target[index] = -1;
                        shotTargets++;
                        for (int i = 0; i < target.Count; i++)
                        {
                            if (target[i] > temp)
                            {
                                if (target[i] != -1)
                                {
                                    target[i] -= temp;
                                }
                            }
                            else
                            {
                                if (target[i] != -1)
                                {
                                    target[i] += temp;
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", target)}");
        }
    }
}
