using System;

namespace recursiveFibonachi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var fibNumber = int.Parse(Console.ReadLine());


            Console.WriteLine(GetFibonacci(fibNumber));
        }
        private static int GetFibonacci(int fibNumber)
        {
            var fibArray = new int[fibNumber];
            

            int result;
            if (fibNumber == 1)
            {
                fibArray[0] = 1;
                return 1;
            }
            else if (fibNumber == 2)
            {
                fibArray[1] = 1;
                return 1;
            }
            else
            {
                result = GetFibonacci(fibNumber-1) + GetFibonacci(fibNumber-2);

                return result;
            }
        }
    }
        
}
