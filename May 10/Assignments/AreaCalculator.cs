using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class AreaCalculator
    {
        public double Area(double length, double breadth)
        { 
            double areaOfRectangle = length * breadth;

            return areaOfRectangle;
        }

        public double Area(int radius)
        {

            double pi = 3.14;

            double areaOfCircle = pi * radius * radius ;

            return areaOfCircle;
        }

        public double Area(int Base, int Height)
        {

            return 0.5 * Base * Height;
        }
    }

    class Program : AreaCalculator
    {
        static void Main()
        { 

            AreaCalculator area = new AreaCalculator();

            double res1 = area.Area(5, 4);
            double res2 = area.Area(4);
            double res3 = area.Area(6, 3);

            Console.WriteLine($"The area of Rectangle:{res1}");
            Console.WriteLine($"The area of Circle:{res2}");
            Console.WriteLine($"The area of Triangle:{res3}");
        }
    }
}
    
