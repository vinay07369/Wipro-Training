using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Icalculator
    {
        void Add(int a, int b);

        void Subtract(int a, int b);

        void Multiply(int a, int b);

        void Divide(int a, int b);
    }

    class SimpleCalculator : Icalculator
    {

        public void Add(int a, int b)
        {
            int c = a + b;

            Console.WriteLine($"The Addition of {a} and {b} = {c}");
        }

        public void Subtract(int a, int b)
        {
            int c = a - b;

            Console.WriteLine($"The Subtraction of {a} and {b} = {c}");
        }

        public void Multiply(int a, int b)
        {
            int c = a * b;

            Console.WriteLine($"The Multiplication of {a} and {b} = {c}");
        }

        public void Divide(int a, int b)
        {
            int c = a / b;

            Console.WriteLine($"The Division of {a} and {b} = {c}");
        }
    }

    class Program
    {
        static void Main(string[] args) {

            Icalculator calc;

            calc = new SimpleCalculator();

            calc.Add(1, 2);
            calc.Subtract(7, 4);
            calc.Multiply(5, 2);
            calc.Divide(6, 2);
        }
    }
}
