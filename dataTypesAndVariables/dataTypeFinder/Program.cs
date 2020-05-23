
using System;


namespace dataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            while (input != "END")
            {
                int number;
                bool intSucces = int.TryParse(input, out int integer);
                if (intSucces)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else
                {
                    double floatingNumber;
                    bool doubleSucces = double.TryParse(input, out double floating);
                    if (doubleSucces)
                    {
                        Console.WriteLine($"{input} is floating point type");

                    }
                    else
                    {
                        char character;
                        bool charSuccess = char.TryParse(input, out char mychar);
                        if (charSuccess)
                        {
                            Console.WriteLine($"{input} is character type");

                        }
                        else
                        {
                            bool boolSucces = bool.TryParse(input, out bool boolean);
                            if (boolSucces)
                            {
                                Console.WriteLine($"{input} is boolean type");
                            }
                            else
                            {
                                Console.WriteLine($"{input} is string type");
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
