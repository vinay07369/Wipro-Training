using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working...");
        }
    }

    class Manager : Employee {
        public override void Work()
        {
            Console.WriteLine("Manager is supervising...");
        }
    }

    class main {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Work();

            Manager manager = new Manager();
            manager.Work(); 

            Employee e = new Manager();
            e.Work();

        }
    }
}
