using System;

class Employee
{ 
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{ 
    static void Main()
    {
        List<Employee> e = new List<Employee>()
        { 
            new Employee { Name = "Vinay", Department = "IT"},
            new Employee { Name = "Kishore", Department = "IT"},
            new Employee { Name = "Sai", Department = "HR"},
            new Employee { Name = "Sonu", Department = "HR"},
            new Employee { Name = "Naveen", Department = "Finance"},
            new Employee { Name = "Aravind", Department = "Admin" }
        };

        var groupdept = e.GroupBy(e => e.Department)
                         .ToList();

        foreach (var group in groupdept)
        {
            Console.WriteLine();
            Console.WriteLine($"Department: {group.Key}");
            Console.WriteLine("---------------------------");
           
            foreach (var emp in group)
            {
                Console.WriteLine($"Name:{emp.Name}");
            }
        }
    }
}