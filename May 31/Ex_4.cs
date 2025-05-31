using System;
using System.IO;
using System.Threading;

class Program
{
    static int totalLines = 0;
    static readonly object lockObj = new object();

    static void Main(string[] args)
    {
        // Example files to count lines in
        string[] files = { "A.txt", "B.txt", "C.txt" };

        Thread[] threads = new Thread[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            string file = files[i]; // capture loop variable
            threads[i] = new Thread(() => CountLines(file));
            threads[i].Start();
        }

        foreach (var t in threads)
        {
            t.Join(); // Waiting for each thread to complete
        }

        Console.WriteLine("Total lines: " + totalLines);
        Console.ReadLine();
    }

    // Method to count lines in a file
    static void CountLines(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File not found: {filename}");
                return;
            }

            int count = File.ReadAllLines(filename).Length;

            lock (lockObj)
            {
                totalLines += count;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file {filename}: {ex.Message}");
        }
    }
}
