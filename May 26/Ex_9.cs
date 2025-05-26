using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ParallelTaskErrors
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting parallel tasks with potential exceptions...");

        // Create a list of tasks, some of which will throw exceptions
        List<Task> tasks = new List<Task>
        {
            ProcessDataAsync("Task 1 (Success)", 200, false),
            ProcessDataAsync("Task 2 (Error)", 300, true),   
            ProcessDataAsync("Task 3 (Success)", 150, false), 
            ProcessDataAsync("Task 4 (Error)", 400, true),   
            ProcessDataAsync("Task 5 (Success)", 250, false) 
        };

        try
        {
            await Task.WhenAll(tasks);
            Console.WriteLine("\nAll tasks completed successfully (this message should not appear if errors occurred).");
        }
        catch (AggregateException ae)
        {
            Console.WriteLine("\nCaught AggregateException!");
            Console.WriteLine("--------------------------");

            // Log individual error messages
            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.WriteLine($"Error Message: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"  Inner Error: {ex.InnerException.Message}");
                }
                Console.WriteLine("--------------------------");
            }
        }
        catch (Exception ex)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine($"\nCaught an unexpected exception: {ex.GetType().Name} - {ex.Message}");
        }
        finally
        {
            // This block will always execute after the try/catch, regardless of exceptions.
            Console.WriteLine("\nSummary: All parallel tasks have finished execution.");
            Console.WriteLine("Program finished.");
        }

        Console.ReadKey();
    }

    private static async Task ProcessDataAsync(string taskName, int delayMs, bool shouldThrow)
    {
        Console.WriteLine($"{taskName}: Starting (Delay: {delayMs}ms)");
        await Task.Delay(delayMs); // Simulate work

        if (shouldThrow)
        {
            Console.WriteLine($"{taskName}: !!! Simulating an error !!!");
            throw new InvalidOperationException($"Error in {taskName}: Something went wrong during processing.");
        }
        else
        {
            Console.WriteLine($"{taskName}: Completed successfully.");
        }
    }
}
