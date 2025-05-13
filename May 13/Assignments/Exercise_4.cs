using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Employee
    {
        public abstract void CalculateSalary();
        public void ShowInfo() => Console.WriteLine("Employee Details");
    }

    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary:Basic + Allowance");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary:Hourly rate * Hourly worked");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee;

            employee = new FullTimeEmployee();
            employee.ShowInfo();
            employee.CalculateSalary();

            employee = new PartTimeEmployee();
            employee.ShowInfo();
            employee.CalculateSalary();
        }
    }