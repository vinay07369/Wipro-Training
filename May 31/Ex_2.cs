using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

    }

    class MainProgram
    { 
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {

                new Employee { Id = 1, Name = "Tharun", Department = "HR", Salary = 50000 },
                new Employee { Id = 2, Name = "Kishore", Department = "IT", Salary = 60000 },
                new Employee { Id = 3, Name = "Arun", Department = "Finance", Salary = 70000 },
                new Employee { Id = 4, Name = "Vinay Kumar", Department = "Marketing", Salary = 55000 },
                new Employee { Id = 5, Name = "Sai", Department = "Sales", Salary = 65000 },
                new Employee { Id = 6, Name = "Ram", Department = "IT", Salary = 72000 },
                new Employee { Id = 7, Name = "Praveen", Department = "HR", Salary = 48000 },
                new Employee { Id = 8, Name = "Surya", Department = "Finance", Salary = 75000 },
                new Employee { Id = 9, Name = "Shankar", Department = "Marketing", Salary = 53000 },
                new Employee { Id = 10, Name = "Aravind", Department = "Sales", Salary = 68000 }

            };

            Console.WriteLine("List of Employees:");
            Console.WriteLine("-------------------");
            // Displaying the list of employees
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }

            // Filter Employees by Department
            Console.Write("\nEnter the Employee Department:");
            string department = Console.ReadLine();

            // filtered employees by department and sorted them by salary in descending order
            var filteredEmployees = employees.Where(e => e.Department == department)
                                             .OrderByDescending(e => e.Salary)
                                             .ToList();  

            Console.WriteLine($"\nEmployees in {department} Department (sorted by Salary):");
            Console.WriteLine("-------------------------------------------------------------");

            if (filteredEmployees.Any())
            {
                foreach (var employee in filteredEmployees)
                {
                    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine($"No employees found in the {department} department.");
            }

            Thread.Sleep(3000); // Pause for 2 seconds before displaying the next section
            Console.WriteLine("\nAverage Salary Per Department:");
            Console.WriteLine("---------------------------------");

            // Calculate and display the average salary per department
            var averageSalaries = employees.GroupBy(e => e.Department)
                                           .Select(g => new
                                           {
                                               Department = g.Key,
                                               AverageSalary = g.Average(e => e.Salary)
                                           })
                                           .OrderByDescending(x => x.AverageSalary);


            foreach (var avg in averageSalaries)
            {
                Console.WriteLine($"Department: {avg.Department}, Average Salary: {avg.AverageSalary}");
            }
        }
    }
}
