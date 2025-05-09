using System;
using System.Collections;

namespace myApplication
{

    class Student
    {
        //Fields
        public int RollNumber;
        public string Name;
        public int Marks;

        //Method to print student details
        public void printDetaile()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks}");
        }
    
    }
    class Program
    {
        static void Main()
        {
            //Student object creation
            Student s = new Student();

            //Assigning values to student
            s.RollNumber = 1;
            s.Name = "Vinay Kumar G";
            s.Marks = 80;

            //Printing details
            s.printDetaile();
            
        }
    }
}

