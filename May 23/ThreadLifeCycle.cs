using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM23
{
    internal class ThreadLifeCycle
    {
        static bool pause = false;
        static bool stop = false;
        static void DoWork()
        {
            while (!stop)
            {
                if (pause)
                {
                    Console.WriteLine("Thread Paused...");
                    Thread.Sleep(500);
                    continue;
                }

                Console.WriteLine("Thread is Working...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread has stopped!");
        }

        static void Main()
        { 
            Thread worker = new Thread(DoWork);

            Console.WriteLine("Initial Thread State: "+worker.ThreadState);
            worker.Start();

            Thread.Sleep(3000);
            pause = true;
            Console.WriteLine("Paused Thread State: "+worker.ThreadState);

            Thread.Sleep(3000);
            pause = false;
            Console.WriteLine("Resuming the work...");

            Thread.Sleep(3000);
            stop = true;
            Console.WriteLine("Stopping the thread...");

            worker.Join(); // Wait for the thread to finish
            Console.WriteLine("Final Thread State: "+worker.ThreadState);     

        }
    }
}
