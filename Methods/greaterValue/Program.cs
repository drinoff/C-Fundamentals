using System;
using System.Runtime.ExceptionServices;

namespace greaterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(GreaterValue(a,b,inputType);
        }
        static void GreaterValue(int a, int b, string inputType)
        {
            int result = 0;
            switch (inputType)
            {
                
                case "int":
                    if (a>b)
                    {
                        result = (int)a;
                    }
                    else
                    {
                        result = (int)b;
                    }
                    break;
                case "char":
                    if ((char)a>(char)b)
                    {
                        result = a;
                    }
                    else
                    {
                        result = b;
                    }    
                    break;
                case "string":
                    if ((char)a> (char)b)
                    {
                        result = a;
                    }
                    else
                    {
                        result = b;
                    }
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
