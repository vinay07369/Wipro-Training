using System;
using System.Threading.Tasks;

class ManualThreading
{
    public static bool pause = false;
    public static bool stop = false;

    static void PrintNumbers()
    {
        for (int i = 1; i <= 100 && !stop; i++)
        {
            if (pause)
            {
                while (pause && !stop)
                {
                    Thread.Sleep(100); // Wait while paused
                }
            }

            Console.WriteLine("Number: " + i);
            Thread.Sleep(100); // Simulate work
        }
    }

    static void Main()
    {
        Thread manual = new Thread(PrintNumbers);
        manual.Start();

        Console.WriteLine($"Start Thread State: {manual.ThreadState}");

        Thread.Sleep(3000); // Let the thread run for a 3 seconds...
        pause = true; // Pause the thread...
        Console.WriteLine($"Pause Thread State: {manual.ThreadState}");

        Thread.Sleep(3000); // Wait for 3 seconds before resuming...
        pause = false; // Resume the thread...
        Console.WriteLine($"Resuming the work...");

        Thread.Sleep(3000); // Let the thread run for another 3 seconds...  
        stop = true; // Stop the thread...  
        Console.WriteLine($"Stop Thread State: {manual.ThreadState}");
    }
}

// Output:

//Number: 1
//Start Thread State: Running
//Number: 2
//Number: 3
//Number: 4
//Number: 5
//Number: 6
//Number: 7
//Number: 8
//Number: 9
//Number: 10
//Number: 11
//Number: 12
//Number: 13
//Number: 14
//Number: 15
//Number: 16
//Number: 17
//Number: 18
//Number: 19
//Number: 20
//Number: 21
//Number: 22
//Number: 23
//Number: 24
//Number: 25
//Number: 26
//Number: 27
//Number: 28
//Pause Thread State: WaitSleepJoin
//Resuming the work...
//Number: 29
//Number: 30
//Number: 31
//Number: 32
//Number: 33
//Number: 34
//Number: 35
//Number: 36
//Number: 37
//Number: 38
//Number: 39
//Number: 40
//Number: 41
//Number: 42
//Number: 43
//Number: 44
//Number: 45
//Number: 46
//Number: 47
//Number: 48
//Number: 49
//Number: 50
//Number: 51
//Number: 52
//Number: 53
//Number: 54
//Number: 55
//Stop Thread State: Stopped
