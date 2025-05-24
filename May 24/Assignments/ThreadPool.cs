using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM24
{
    internal class ThreadPoolLightWeight
    {
        static void ProcessItem(object item)
        {
            // Simulate some work with the item
       
            Console.WriteLine($"Processing item: {item}");
            Thread.Sleep(2000); // Simulate work delay
        }
        static void Main()
        { 
            ThreadPool.QueueUserWorkItem(ProcessItem, "Computer");
            ThreadPool.QueueUserWorkItem(ProcessItem, "Laptop");
            ThreadPool.QueueUserWorkItem(ProcessItem, "TV");
            ThreadPool.QueueUserWorkItem(ProcessItem, "Speaker");
            ThreadPool.QueueUserWorkItem(ProcessItem, "Mobile");

            Thread.Sleep(5000);
            Console.WriteLine("Completed...");

        }
    }
}