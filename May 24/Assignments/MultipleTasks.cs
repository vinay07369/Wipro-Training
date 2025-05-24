using System;
using System.Threading;

class MultiThreadJoinExample
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(Printing);
        Thread thread2 = new Thread(Computing);
        Thread thread3 = new Thread(Waiting);

        Console.WriteLine("Starting all tasks...\n");

        thread1.Start();
        thread1.Join();

        thread2.Start();
        thread2.Join();

        thread3.Start();
        thread3.Join();

        Console.WriteLine("All tasks done!");
    }

    static void Printing()
    {
        Console.WriteLine("Printing started.");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Printing {i}");
            Thread.Sleep(500); // Simulate delay
        }
        Console.WriteLine("Printing finished.\n");
    }

    static void Computing()
    {
        Console.WriteLine("Computing started.");
        long sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Thread.Sleep(1000);
        Console.WriteLine($"Computing result: {sum}");

        Thread.Sleep(500);
        Console.WriteLine("Computing finished.\n");
    }

    static void Waiting()
    {
        Console.WriteLine("Waiting started.");
        Thread.Sleep(3000); // Simulate wait
        Console.WriteLine("Waiting finished.\n");
    }
}