using System;
using System.Collections.Generic;
using System.Linq;

namespace studentsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var studentsList = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                var studentInfo = Console.ReadLine().Split();
                var student = new Student();
                student.FristName = studentInfo[0];
                student.LastName = studentInfo[1];
                student.Grade = studentInfo[2];
                studentsList.Add(student);
            }
            var result = studentsList.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in result)
            {
                PrintStudent(student);
            }
        }
        public class Student
        {
            public string FristName { get; set; }
            public string LastName { get; set; }
            public string Grade { get; set; }



        }
        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"{student.FristName} {student.LastName}: {student.Grade}");
        }
    }
}
