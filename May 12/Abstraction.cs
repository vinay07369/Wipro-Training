using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Shape
    {
        public abstract void Draw();

        public void Display()
        {
            Console.WriteLine("This a Shape...");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Circle circle = new Circle();
            
            circle.Draw();
        }
    }
}