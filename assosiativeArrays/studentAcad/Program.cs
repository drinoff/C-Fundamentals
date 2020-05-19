using System;
using System.Collections.Generic;
using System.Linq;

namespace studentAcad
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPairs = int.Parse(Console.ReadLine());
            var studentGrade = new Dictionary<string, List<double>>();
            var nameAvgGrade = new Dictionary<string, double>();
            for (int i = 0; i < nPairs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGrade.ContainsKey(studentName) ==false)
                {
                    studentGrade.Add(studentName, new List<double>());
                }
                    studentGrade[studentName].Add(grade);
            }

            foreach (var item in studentGrade)
            {
                var avgGrade = item.Value.Sum() / item.Value.Count();
                nameAvgGrade.Add(item.Key, avgGrade);
            }

            var result = nameAvgGrade.OrderByDescending(x => x.Value);
            foreach (var element in result)
            {
                if (element.Value >=4.5)
                Console.WriteLine($"{element.Key} -> {element.Value:f2}");
            }
        }
    }
}
