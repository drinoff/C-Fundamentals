using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingYield = long.Parse(Console.ReadLine());
            
            var days = 0;
            long totalAmountYield = 0;
            

            while (true)
            {
                if (startingYield < 100)
                {
                    if (totalAmountYield >= 26)
                    {
                        totalAmountYield -= 26;
                    }
                    else
                    {
                        totalAmountYield = 0;
                    }
                    break;
                }
                else
                {
                    totalAmountYield += startingYield;
                    days++;
                    startingYield -= 10;
                    if (totalAmountYield >= 26)
                    {
                        totalAmountYield -= 26;
                    }
                    else
                    {
                        totalAmountYield = 0;
                    }

                }

            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmountYield);
        }
    }
}
