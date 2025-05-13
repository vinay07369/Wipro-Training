using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_practice
{
    public delegate int SomeOperation(int x, int y);

    class Program
    {
        static int Sum(int x, int y)
        { 
            return x + y;
        }
        static void Main(string[] args)
        {
            SomeOperation add = Sum;

            int result = add(1, 2);

            Console.WriteLine(result);
        }
    }
            
}