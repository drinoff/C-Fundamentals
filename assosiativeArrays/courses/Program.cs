using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courseStudent = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command!= "end")
            {
                var input = command.Split(" : ").ToArray();

                string courseName = input[0];
                string studentName = input[1];

                if (courseStudent.ContainsKey(courseName)==false)
                {
                    courseStudent.Add(courseName,new  List<string>());
                }
                courseStudent[courseName].Add(studentName);
                command = Console.ReadLine();
            }
            var result = courseStudent.OrderByDescending(x => x.Value.Count());
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
                item.Value.Sort();
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"-- {element}");
                }
            }
        }
    }
}
