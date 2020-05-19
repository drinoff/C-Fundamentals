using System;

namespace grades
{
    class Program
    {
        static void Grade(double grade)
        {
            if (grade >=2 && grade<3)
                Console.WriteLine("Fail");
            else if (grade >= 3 && grade < 3.50)
                Console.WriteLine("Poor");
            else if (grade >= 3.50 && grade < 4.50)
                Console.WriteLine("Good");
            if (grade >= 4.50 && grade < 5.50)
                Console.WriteLine("Very good");
            if (grade >= 5.50 && grade <= 6)
                Console.WriteLine("Excellent");
        }
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);
        }
    }
}
