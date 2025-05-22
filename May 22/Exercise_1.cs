using System;

class StudentNames
{
    static void Main()
    { 
        List<string> students = new List<string>(); // Creating a List Called Students

        students.Add("Vinay Kumar G");
        students.Add("Sai Seshu D");
        students.Add("Sonu Kumar P");
        students.Add("Kishore");
        students.Add("Lokesh Kumar B");

        Console.WriteLine("\nStudent Names ");
        Console.WriteLine("------------------");

        foreach (var name in students)
        { 
            Console.WriteLine(name);
        }

        students.Sort(); // Sorting the List

        Console.WriteLine(); // Giving space after sorting

        Console.WriteLine("After Sorting the Student Names");
        Console.WriteLine("----------------------------------");

        foreach (var name in students)
        {
            Console.WriteLine(name);
        }
    }
}