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
            new Student{ Name = "Vinay", Marks = 79},
            new Student{ Name = "Aravind", Marks = 74},
            new Student{ Name = "Ashok", Marks = 78},
            new Student{ Name = "Dinesh", Marks = 72},
            new Student{ Name = "Manoj", Marks = 85}
        };

        var averageMarks = students.Average(s => s.Marks);

        var count = students.Count(s => s.Marks > averageMarks);

        Console.WriteLine($"Average Marks: {averageMarks}");

        Console.WriteLine($"Count of Students who scored Above average: {count}");

    }
}