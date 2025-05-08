using System;
using System.Collections;

namespace city
{
    class Program
    {
        static void Main()
        {
            //Creating queue of strings
            Queue<string> queue = new Queue<string>();

            //Enqueue the elements
            queue.Enqueue("Vinay");
            queue.Enqueue("Sai");
            queue.Enqueue("Sanjay");
            queue.Enqueue("saran");

            Console.WriteLine("Queue Elements:");
            foreach (var name in queue) { 
                Console.WriteLine(name);
            }

            //Dequeue elements
            Console.WriteLine("\nDequeued:"+queue.Dequeue());

            //Peek at the front element
            Console.WriteLine("Next in line:"+queue.Peek());

        }
    }
}
