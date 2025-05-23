using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM23
{
    internal class ParameterThread
    {
        static void PrintMessage(object message)
        { 
            string msg = message.ToString();

            Console.WriteLine("Message:" +msg);
        }

        static void Main()
        { 
            Thread mythread = new Thread(new ParameterizedThreadStart(PrintMessage));
            mythread.Start("Hello from the Thread!");
        }
    }  
}