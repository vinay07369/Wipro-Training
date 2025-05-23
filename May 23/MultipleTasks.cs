using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class MultipleTasks
    {
        static async Task Main()
        {
            Console.WriteLine("Starting All the Tasks...");

            // Start multiple tasks simultaneously (they begin running now)
            Task t1 = DoWorkAsync("Task 1", 2000);
            Task t2 = DoWorkAsync("Task 2", 3000);
            Task t3 = DoWorkAsync("Task 3", 1000);

            // Await for all tasks to complete...
            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("All Tasks Completed.");
        }

        static async Task DoWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} Started");
            await Task.Delay(delay);
            Console.WriteLine($"{name} Completed after {delay}ms.");
        }
    }
}