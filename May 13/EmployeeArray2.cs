using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


public class Employee
{ 
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        Employee[] employeeArray = {
            new Employee() { EmployeeId = 1, EmployeeName = "John" ,Age = 18 },
            new Employee() { EmployeeId = 2, EmployeeName = "Steve" ,Age = 21 },
            new Employee() { EmployeeId = 3, EmployeeName = "Bill" ,Age = 25 },
            new Employee() { EmployeeId = 4, EmployeeName = "Ram" ,Age = 30 },
            new Employee() { EmployeeId = 5, EmployeeName = "Ron" ,Age = 31 },
            new Employee() { EmployeeId = 6, EmployeeName = "Chris" ,Age = 17 },
            new Employee() { EmployeeId = 7, EmployeeName = "Rob" ,Age = 19 },
        };

        //Employee[] employees = new Employee[10];

        //int i = 0;

        //foreach (Employee employee in employeeArray)
        //{
        //    if (employee.Age > 12 && employee.Age < 20)
        //    {
        //        employees[i] = employee;
        //        Console.WriteLine(employee.EmployeeName);
        //        i++;
        //    }
        //}

        //Use LINQ to find teenager Employees
        Employee[] teenAgeEmployee = employeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

        //Use LINQ to find first employee whose name is Bill
        Employee bill = employeeArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();

        //Use LINQ to find whose id is 5
        Employee employee5 = employeeArray.Where(s => s.EmployeeId == 5).FirstOrDefault();

        
        Console.WriteLine("For teenAgeEmployee details");
        Console.WriteLine("-------------------------------");

        foreach (Employee employee in teenAgeEmployee)
        {
            Console.WriteLine(employee.EmployeeName);
        }

        Console.WriteLine("For employee name who is bill");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(bill.EmployeeName);

       
        Console.WriteLine("Details of employee whose id is 5");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"{employee5.EmployeeId},{employee5.EmployeeName},{employee5.Age}");
        
    }
}
