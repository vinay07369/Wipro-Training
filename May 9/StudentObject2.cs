using System;
using System.Collections;

using ConsoleApp2;
class Program
{
    static void Main()
    {

        //Student s = new Student();

        Student s = new Student { RollNumber = 1, Name = "Vinay Kumar G", Marks = 80};

        //s.RollNumber = 1;
        //s.Name = "Vinay Kumar G";
        //s.Marks = 80;

        s.printDetaile();
            
    }
}