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

        Employee[] employees = new Employee[10];

        int i = 0;

        foreach (Employee employee in employeeArray)
        {
            if (employee.Age > 12 && employee.Age < 20)
            {
                employees[i] = employee;
                Console.WriteLine(employee.EmployeeName);
                i++;
            }
        }
    }
}

