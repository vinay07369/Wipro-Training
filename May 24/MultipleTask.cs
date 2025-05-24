using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string filename, int delayMs)
    {
        Console.WriteLine($"Starting Download : {filename}");
        await Task.Delay( delayMs );
        Console.WriteLine($"Completed Download : {filename} {delayMs}");
    }

    static async Task Main()
    { 
       Console.WriteLine("Starting All Downloads...\n");

        Task task1 = DownloadFileAsync("file1.pdf", 3000);
        Task task2 = DownloadFileAsync("file2.jpg", 2000);
        Task task3 = DownloadFileAsync("file3.zip", 4000);


        await Task.WhenAll( task1, task2, task3);

        Console.WriteLine("\nAll downloads Completed..");
    }
}