using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM23
{
    internal class ParameterThread
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Sum: {a + b}");
            });

            thread.Start();
        }
    }  
}