using System;
using System.Collections;

namespace employeePortal
{
    class Employee
    { 
        public int EmpID { get; set; }
        public string Name { get; set; }

    }
    class Program
    {
        static void Main()
        { 
            List<Employee> e = new List<Employee>(); // Creating an Employee list

            //Adding five employees With Id and Name
            e.Add(new Employee { EmpID = 1, Name = "Ramesh"});
            e.Add(new Employee { EmpID = 2, Name = "Suresh" });
            e.Add(new Employee { EmpID = 3, Name = "Ganesh" });
            e.Add(new Employee { EmpID = 4, Name = "Karthik" });
            e.Add(new Employee { EmpID = 5, Name = "Anand" });

            //Removing an employee by his name
            e.RemoveAll(e => e.Name == "Anand");

            //Check if a name exists
            if (e.Any(e => e.Name.Contains("Ganesh")))
            {
                Console.WriteLine("Name Exists");
            }

            //Printing total number of Employees
            Console.WriteLine("Total Number of Employees:" + e.Count);


        }
    }
}

