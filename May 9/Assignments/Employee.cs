using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeApp
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public void PrintDetails()
        {
            Console.WriteLine($"EmployeeID = {EmployeeID}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Department = {Department}");
            Console.WriteLine($"Salary = {Salary}");
        }

        public void UpdateDetails(string newName, double newSalary)
        { 
            Name = newName;
            Salary = newSalary;
            Console.WriteLine("Details updated successfully");
        }

        public void AnnualSalary(double annualSalary)
        {
            annualSalary = Salary * 12;

            Console.WriteLine("Annual salary for the employee:"+annualSalary);
        }
    }
}
