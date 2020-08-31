using System;
using System.Linq;
using System.Collections.Generic;

namespace stringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var result = new List<char>();
            int i = 0;
            while (true)
            {
                if (str[i] == '>')
                {
                    result.Add('>');
                    var power = int.Parse((str[i + 1]).ToString());
                    for (int j = 0; j < power; j++)
                    {
                        str.Remove(i + j + 1, 1);
                        if (str[i + j + 1] == '>')
                        {
                            result.Add(str[i+j+1]);
                            power += int.Parse((str[i + j + 1 + 1]).ToString());
                        }                        
                    }
                    i++;
                    if (i == str.Length - 1)
                    {
                        break;
                    }

                }
                else
                {
                    result.Add(str[i]);
                }
            }
        }
    }
}
