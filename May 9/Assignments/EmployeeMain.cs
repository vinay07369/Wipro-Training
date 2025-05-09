using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeApp
{
    class EmployeeMain
    {
        static void Main()
        {
            Employee e1 = new Employee { EmployeeID = 101, Name = "Vinay Kumar G", Department = "IT", Salary = 20000.0 };

            //Print details
            e1.PrintDetails();

            Console.WriteLine("--------------");

            //Update details
            e1.UpdateDetails("Kiran",30000.0);

            Console.WriteLine("--------------");

            //Annual salary
            e1.AnnualSalary(30000.0);

        }
    }
}