using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(500); //Pause for 0.5 s
        }
    }

    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500); //Pause for 0.5 s
        }
    }
}