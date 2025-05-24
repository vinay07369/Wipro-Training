using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Seq
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed.");
    }

    static async Task Main()
    {
        var stopwatch = new Stopwatch();

        // Sequential Execution
        stopwatch.Start();
        await SimulateWorkAsync("Task 1", 1000);
        await SimulateWorkAsync("Task 2", 2000);
        await SimulateWorkAsync("Task 3", 3000);
        stopwatch.Stop();
        Console.WriteLine($"Sequential execution time: {stopwatch.ElapsedMilliseconds} ms\n");

        // Parallel Execution
        stopwatch.Restart();
        var task1 = SimulateWorkAsync("Task 1", 1000);
        var task2 = SimulateWorkAsync("Task 2", 2000);
        var task3 = SimulateWorkAsync("Task 3", 3000);
        await Task.WhenAll(task1, task2, task3);
        stopwatch.Stop();
        Console.WriteLine($"Parallel execution time: {stopwatch.ElapsedMilliseconds} ms");
    }
}
