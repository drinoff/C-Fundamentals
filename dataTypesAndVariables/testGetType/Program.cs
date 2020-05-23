using System;

namespace testGetType
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var result = input.GetTypeCode();
                switch (result)
                {                                     
                    case TypeCode.Boolean:
                        Console.WriteLine($"{input} is boolean type");
                        break;
        
                    case TypeCode.Char:
                        Console.WriteLine($"{input} is character type");
                        break;
                   
                    case TypeCode.Int32:
                        Console.WriteLine($"{input} is integer type");
                        break;
                 
                    case TypeCode.Double:
                        Console.WriteLine($"{input} is floating point type");
                        break;
                   
                    case TypeCode.String:
                        Console.WriteLine($"{input} is string type");
                        break;
                    
                }
            }
        }
    }
}
