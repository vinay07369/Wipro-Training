using System;
using System.Collections;

namespace customers
{
    class Program
    {
        static void Main()
        {
            //Creating queue of strings
            Queue<string> customers = new Queue<string>();

            //Enqueue the elements
            customers.Enqueue("Vinay");
            customers.Enqueue("Sai");
            customers.Enqueue("Sanjay");
            customers.Enqueue("saran");

            Console.WriteLine("Serving customers:");
            while (customers.Count > 0) 
            {
                Console.WriteLine("Serving:"+customers.Dequeue());
            }
        }
    }
}
