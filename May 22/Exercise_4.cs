using System;

class Student
{
    public string Name { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    { 
        List<Student> students = new List<Student>()
        { 
            new Student {Name = "Vinay", Marks = 79.0},
            new Student {Name  = "Surya", Marks = 75.0},
            new Student {Name  = "Sai Seshu", Marks = 80.0},
            new Student {Name  = "Kishore", Marks = 74.2},
            new Student {Name  = "Naveen", Marks = 70.0},
            new Student {Name  = "Arya", Marks = 68.0}
        };

        var topthree = students.OrderByDescending(student => student.Marks)
                               .Take(3)
                               .ToList();

        Console.WriteLine("Top 3 students by their Marks:");
        Console.WriteLine("---------------------------------");

        foreach (var student in topthree)
        { 
            Console.WriteLine($"Name = {student.Name}, Marks = {student.Marks}");
        }
    }
}