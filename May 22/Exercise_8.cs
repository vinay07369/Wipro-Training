using System;

class Program
{
    static void Main()
    {
        Dictionary<int, decimal> employee = new Dictionary<int, decimal>();

        employee.Add(1, 20000);
        employee.Add(2, 25000);
        employee.Add(3, 23000);
        employee.Add(4, 26000);
        employee.Add(5, 28000);

        Console.WriteLine("Enter the EmployeeID:");
        int id = Convert.ToInt32(Console.ReadLine());

        if (employee.ContainsKey(id))
        {
            Console.WriteLine($"Salary for Employee {id}:{employee[id]}");
        }
        else
        {
            Console.WriteLine($"Employee with {id} Not found");
        }
    }
}