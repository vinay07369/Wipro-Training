using System;
using System.Collections.Generic;
using System.Threading;

public class DynamicWorker
{
    private static Queue<string> taskQueue = new Queue<string>();
    private static readonly object queueLock = new object(); // Object for locking access to the queue
    private static ManualResetEvent allTasksProcessed = new ManualResetEvent(false); // Signify when all tasks are done

    public static void Main(string[] args)
    {
        Console.WriteLine("Main thread: Starting worker thread...");

        // Start the worker thread
        Thread workerThread = new Thread(ProcessTasks);
        workerThread.Start();

        // Enqueue 5 tasks from the main thread
        for (int i = 1; i <= 5; i++)
        {
            string task = $"Task {i}";
            Console.WriteLine($"Main thread: Enqueuing {task}");
            lock (queueLock)
            {
                taskQueue.Enqueue(task);
            }
            // Give the worker a small moment to potentially pick up tasks
            Thread.Sleep(100); 
        }

        Console.WriteLine("Main thread: All tasks enqueued. Waiting for worker to finish...");

        // Wait for the worker thread to signal that all tasks are processed
        allTasksProcessed.WaitOne();

        Console.WriteLine("Main thread: Worker thread has finished processing all tasks. Exiting.");
    }

    private static void ProcessTasks()
    {
        Console.WriteLine("Worker thread: Started.");

        int tasksProcessedCount = 0;
        const int totalTasksToExpect = 5; // We know we'll enqueue 5 tasks

        while (true)
        {
            string task = null;

            lock (queueLock)
            {
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                }
            }

            if (task != null)
            {
                Console.WriteLine($"Worker thread: Processing {task}");
                Thread.Sleep(500); // Simulate work
                tasksProcessedCount++;
            }
            else
            {
                // No task available. Check if all expected tasks have been processed.
                if (tasksProcessedCount >= totalTasksToExpect)
                {
                    Console.WriteLine("Worker thread: All expected tasks processed. Signalling main thread.");
                    allTasksProcessed.Set(); // Signal that all tasks are done
                    break; // Exit the loop
                }
                else
                {
                    // No task, but not all tasks processed yet. Wait a bit before checking again.
                    // This prevents busy-waiting.
                    Thread.Sleep(50); 
                }
            }
        }
        Console.WriteLine("Worker thread: Exiting.");
    }
}
