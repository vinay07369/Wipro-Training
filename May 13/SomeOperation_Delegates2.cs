using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_practice
{
    internal class Delegates
    {
        //Without using delegate keyword...
        class Program
        {
            static int Sum(int x, int y)
            { 
                return x + y;
            }
            static void Main(string[] args)
            {
                Func<int, int, int> add = Sum; // using Func keyword, it accepts two parameters as an inputs, and the third one is output based on the return type...

                int result = add(5, 2);

                Console.WriteLine(result);
            }
        }      
    }
}