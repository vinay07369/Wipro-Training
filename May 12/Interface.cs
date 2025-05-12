using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Ishape
    {
        void Draw();
    }

    class Circle : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle...");
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