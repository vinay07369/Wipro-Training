using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Calculator
    {
        //Addition overloading
        public int Add(int a, int b){
            return a + b;
        }

        public double Add(double a, double b) { 
            return a + b;
        }

        public int Add(int a, int b, int c) { 
            return a + b + c;
        }

        //Subtraction overloading

        public int Sub(int a, int b) {
            return a - b;
        }

        public double Sub(double a, double b) {
            return a - b;
        }

        public double Sub(double a, int b, int c) {
            return a - b - c;
        }

        //Multiplication overloading

        public int Mul(int a, int b) {
            return a * b;
        }

        public double Mul(double a, int b) { 
            return (double)a * b;
        }

        public double Mul(int a, double b, int c) {
            return a * b * c;
        }
    }
}
