using System;
using System.Collections;

namespace employeePortal
{
    class Program
    {
        static void Main()
        { 
            //creating the dictionary
            Dictionary<int,string> employees= new Dictionary<int, string>
            {
                { 1, "Vinay"},
                { 2, "Sanjay"},
                { 3, "Varun"}
            };

            //updating the name with id 2
            employees[2] = "Sai seshu";

            //looping through dictionary
            foreach (var pair in employees)
            {
                Console.WriteLine($"ID:{pair.Key}, Name:{pair.Value}");
            }
        }
    }
}
