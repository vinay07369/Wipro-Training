using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class AsyncAwait
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Work started.");

            // Call the asynchronous method
            await DoAsyncWork();

            Console.WriteLine("Work Completed.");
        }
        static async Task DoAsyncWork()
        {
            Console.WriteLine("Working Asynchronously...");
            // Simulate a long-running task
            await Task.Delay(5000);
            Console.WriteLine("Async Work completed.");
        }
    }
}