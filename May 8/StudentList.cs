using System;
using System.Collections;

namespace myApp 
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
        {
            new Student { Id = 1, Name = "Vinay Kumar G" },
            new Student { Id = 2, Name = "Sai seshu" }
        };

            //Adding another student
            list.Add(new Student { Id = 3, Name = "Gokul" });

            foreach (Student student in list)
            {
                Console.WriteLine($" ID: {student.Id}, Name: {student.Name}");
            }
        }
    }
}


    
