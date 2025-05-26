using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    internal class Student
    {   
        public string Name { get; set; }
        public double Marks { get; set; }
        public string Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Vinay", Marks = 85, Grade = "A" },
                new Student { Name = "Aravind", Marks = 70, Grade = "B" },
                new Student { Name = "Kishore", Marks = 90, Grade = "A" },
                new Student { Name = "Sakthi", Marks = 60, Grade = "C" },
                new Student { Name = "Ganesh", Marks = 75, Grade = "B" },
                new Student { Name = "Priya", Marks = 95, Grade = "A" },
                new Student { Name = "Lakshmi", Marks = 80, Grade = "B" },
                new Student { Name = "Raj", Marks = 55, Grade = "C" },
                new Student { Name = "Anitha", Marks = 65, Grade = "C" },
                new Student { Name = "Suresh", Marks = 88, Grade = "A" }
            };

            var topStudents = students.OrderByDescending(s => s.Marks)
                                      .GroupBy(s => s.Grade)
                                      .SelectMany(g => g.Take(3))
                                      .ToList();

            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Marks} - {student.Grade}");
            }
        }
    }
}