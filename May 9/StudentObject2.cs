using System;
using System.Collections;

using ConsoleApp2;
class Program
{
    static void Main()
    {

        //Student s = new Student();

        Student s1 = new Student { RollNumber = 1, Name = "Vinay Kumar G", Marks = 80};
        Student s2 = new Student { RollNumber = 2, Name = "Aravind D", Marks = 85 };

        //s.RollNumber = 1;
        //s.Name = "Vinay Kumar G";
        //s.Marks = 80;

        s1.printDetaile();
        Console.WriteLine("------------");
        s2.printDetaile();
            
    }
}