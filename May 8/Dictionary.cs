using System;
using System.Collections;

namespace employeePortal
{
    class Program
    {
        static void Main()
        { 
            //creating the dictionary
            Dictionary<int,string> students = new Dictionary<int,string>();

            //adding the elements
            students.Add(101, "Vinay Kumar G");
            students.Add(102, "Arpit shivam");
            students.Add(103, "Sai sheshu");

            //Accessing values using keys
            Console.WriteLine("Student with Id 102:"+students[102]);

            //looping through dictionary
            foreach (var pair in students)
            {
                Console.WriteLine($"ID:{pair.Key}, Name:{pair.Value}");
            }
        }
    }
}
