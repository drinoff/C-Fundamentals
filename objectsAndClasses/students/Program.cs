using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "end")
                {
                    break;
                }

                List<string> studentInfo = command.Split().ToList();
                Students student = new Students();
                bool isInTheList = false;
                isInTheList = students.Any(student => student.FirstName == studentInfo[0]);
                bool isInTheList2 = false;
                isInTheList2 = students.Any(student => student.LastName == studentInfo[1]);

                if (isInTheList && isInTheList2)
                {
                    Students match = students.FirstOrDefault(student => student.FirstName == studentInfo[0] && student.LastName == studentInfo[1]);
                    if (match != null)
                    {
                        match.Age = int.Parse(studentInfo[2]);
                        match.Hometown = studentInfo[3];
                    }
                }
                else
                {
                    student.FirstName = studentInfo[0];
                    student.LastName = studentInfo[1];
                    student.Age = int.Parse(studentInfo[2]);
                    student.Hometown = studentInfo[3];
                    students.Add(student);
                }



                command = Console.ReadLine();
            }
            string city = Console.ReadLine();

            foreach (Students student in students)
            {
                if (student.Hometown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }

        }
    }
}
