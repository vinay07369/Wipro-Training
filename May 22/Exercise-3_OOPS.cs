using System;

public interface IAttendance
{
    void MarkAttendance();
}

abstract class Staff : IAttendance
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public abstract void CalculateSalary();

    public void MarkAttendance()
    { 
        Console.WriteLine($"{Name} has marked attendance.");
    }
}

class PermanentStaff : Staff, IAttendance
{
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public override void CalculateSalary()
    {
        double totalSalary = BasicSalary + HRA + DA;

        Console.WriteLine($"Total Salary of {Name} is: {totalSalary}");
    }
}

class ContractStaff : Staff, IAttendance
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public override void CalculateSalary()
    {
        double totalSalary = HourlyRate * HoursWorked;

        Console.WriteLine($"Total Salary of {Name} is: {totalSalary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PermanentStaff permanentStaff = new PermanentStaff
        {
            Id = 1,
            Name = "Vinay Kumar G",
            Department = "IT",
            BasicSalary = 50000,
            HRA = 10000,
            DA = 5000
        };
        permanentStaff.CalculateSalary();
        permanentStaff.MarkAttendance();

        Console.WriteLine("-------------------------------------");

        ContractStaff contractStaff = new ContractStaff
        {
            Id = 2,
            Name = "Sai Seshu D",
            Department = "HR",
            HourlyRate = 200,
            HoursWorked = 40
        };
        contractStaff.CalculateSalary();
        contractStaff.MarkAttendance();
    }
}