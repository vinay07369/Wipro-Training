using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var tasks = new[]
        {
            RiskyTaskAsync("Task 1"),
            RiskyTaskAsync("Task 2 (will fail)"),
            RiskyTaskAsync("Task 3")
        };

        // Using Task.WhenAll to run tasks in parallel and handle exceptions
        try
        {
            await Task.WhenAll(tasks);
        }
        // Catching exceptions from all tasks
        catch (Exception)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].IsFaulted)
                    Console.WriteLine($"{tasks[i].AsyncState ?? $"Task {i + 1}"} failed with: {tasks[i].Exception?.GetBaseException().Message}");
            }
        }
    }

    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(500);
        if (name.Contains("fail"))
            throw new InvalidOperationException($"{name} encountered an error.");
        Console.WriteLine($"{name} completed successfully.");
    }
}
