using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_practice
{
    internal class Delegates
    {
        class Program
        {
            static void Main()
            {
                Action<int> printActionDel = ConsolePrint;
                Action<int> printToPrinter = PrinterPrint;

                printActionDel(12);
                printToPrinter(45);
                Console.Read();
             
            }

            public static void ConsolePrint(int i)
            { 
                Console.WriteLine(i);
            }

            public static void PrinterPrint(int i)
            {
                Console.WriteLine($"The number {i} is printed to the printer");
            }
        }     
    }
}
