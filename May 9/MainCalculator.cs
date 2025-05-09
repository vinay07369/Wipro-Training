using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class MainCalculator
    {
        static void Main(string[] args) { 
            
            Calculator c = new Calculator();

            int c1 = c.Add(4, 6);

            double c2 = c.Add(2.3, 4.5);

            int c3 = c.Add(4, 2, 7);

            Console.WriteLine($"The Addition of two numbers:{c1}");
            Console.WriteLine($"The Addition of two decimal numbers:{c2}");
            Console.WriteLine($"The Addition of three numbers:{c3}");

        }
    }
}