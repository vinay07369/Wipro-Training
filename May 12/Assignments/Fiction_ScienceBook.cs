using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Book
    {
        public abstract void Read();

        public void GetInfo()
        {
            Console.WriteLine("This is a Book");
        }
    }

    class FictionBook : Book
    {
        public override void Read()
        {
            Console.WriteLine("Reading a Fiction Book");
        }
    }

    class ScienceBook : Book
    {
        public override void Read()
        {
            Console.WriteLine("Reading a Science Book");
        }
    }

    class Program
    {
        static void Main()
        {
            Book b;

            b = new FictionBook(); //creating object for FictionBook using Book reference

            b.GetInfo();
            b.Read();

            Console.WriteLine();

            b = new ScienceBook(); //creating object for ScienceBook using Book reference

            b.GetInfo();
            b.Read();   
        }
    }
}
