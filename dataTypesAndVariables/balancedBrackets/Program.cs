using System;

namespace balancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isOpen = false;
            var isClosed = false;
            var isUnbal = false;
            var openCount = 0;
            var closedCount = 0;

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine();
                if (input == "(")
                    openCount++;
                else if (input == ")")
                {
                    closedCount++;
                    if (openCount - closedCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                if (input != "(" && input != ")")
                {
                    
                    continue;
                }
                else
                {
                    if (input == "(" && isOpen)
                    {
                        
                        isUnbal = true;
                        break;
                    }
                    else if(input == ")" && isClosed)
                    {
                        
                        isUnbal = true;
                        break;
                    }
                }

            }
            if(isUnbal)
                Console.WriteLine("UNBALANCED");
            else if (openCount!=closedCount)
                Console.WriteLine("UNBALANCED");
            else
                Console.WriteLine("BALANCED");
        }
    }
}
