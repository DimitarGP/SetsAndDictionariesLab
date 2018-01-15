using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyGraduation
{
    public class Program
    {
        public static void Main()
        {
            int line = int.Parse(Console.ReadLine());
            SortedDictionary<string,double> students = new SortedDictionary<string, double>();
            for (int i = 0; i < line; i++)
            {
                string name = Console.ReadLine();
                var graduates = Console.ReadLine()
                    .Split(new char[] {' '}
                        , StringSplitOptions
                            .RemoveEmptyEntries)
                    .Select(double.Parse);
                var averageGraduate = graduates.Average();

                students.Add(name,averageGraduate);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
