using System;

class Employee
{ 
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    { 
        List<Employee> list = new List<Employee>();
        list.Add(new Employee { EmployeeId = 1, Name = "Vinay kumar G", Salary = 20000});
        list.Add(new Employee { EmployeeId = 2, Name = "Sai seshu", Salary = 25000 });
        list.Add(new Employee { EmployeeId = 3, Name = "Kishore", Salary = 15000 });
        list.Add(new Employee { EmployeeId = 4, Name = "Praveen", Salary = 28000 });
        list.Add(new Employee { EmployeeId = 5, Name = "Surya", Salary = 18000 });

        Console.WriteLine("Employee List:");
        foreach (var employee in list)
        {
            Console.WriteLine($"EmployeeID:{employee.EmployeeId}, Name:{employee.Name}, Salary:{employee.Salary}");
        }

        Console.WriteLine("-----------------------------------------------");

        Employee highSalary = list.OrderByDescending(e => e.Salary).FirstOrDefault();

        if (highSalary != null)
        {
            Console.WriteLine("Highest Paid Salary:");
            Console.WriteLine($"Name: {highSalary.Name}, His Salary: {highSalary.Salary} ");
        }
        else
        {
            Console.WriteLine("No employees in the list.");
        }

        Console.WriteLine("-----------------------------------------------");

        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1, "Vinay Kumar G");
        emp.Add(2, "Sai sheshu");
        emp.Add(3, "Kishore");
        emp.Add(4, "Praveen");
        emp.Add(5, "Surya");

        Console.WriteLine("Employee Dictionary:");
        foreach (var employee in emp)
        {
            Console.WriteLine($"ID:{employee.Key}, Name:{employee.Value}");
        }

        Console.Write("Enter an Employee ID to search: ");

        if (int.TryParse(Console.ReadLine(), out int searchId))
        {
            if (emp.ContainsKey(searchId))
            {
                Console.WriteLine($"Employee with ID {searchId} found.");
                Console.WriteLine($"Name: { emp[searchId]}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {searchId} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for Employee ID.");
        }

    }
}