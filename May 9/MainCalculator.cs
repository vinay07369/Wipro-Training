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

            Console.WriteLine("--------------------------------");

            int s1 = c.Sub(9, 4);

            double s2 = c.Sub(8.5, 4.2);

            double s3 = c.Sub(2.3, 3, 4);

            Console.WriteLine($"The Subtraction of two numbers:{s1}");
            Console.WriteLine($"The Subtraction of two decimal numbers:{s2}");
            Console.WriteLine($"The Subtraction of three numbers:{s3}");

            Console.WriteLine("--------------------------------");

            int m1 = c.Mul(9, 4);

            double m2 = c.Mul(8.5, 2);

            double m3 = c.Mul(2, 3.2, 4);

            Console.WriteLine($"The Multiplication of two numbers:{m1}");
            Console.WriteLine($"The Multiplication of two decimal numbers:{m2}");
            Console.WriteLine($"The Multiplication of three numbers:{m3}");

        }
    }
}