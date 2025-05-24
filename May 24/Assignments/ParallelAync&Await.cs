using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM24
{
    internal class ParellelAsyn_Await
    {
        static async Task DownloadFileAsync(string fileName, int delay)
        {
            Console.WriteLine($"Starting download of {fileName} with a delay of {delay}ms...");

            // Simulate a delay for downloading
            await Task.Delay(delay);

            Console.WriteLine($"{fileName} downloaded with a delay of {delay}ms.");
        }

        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Start multiple downloads in parallel
            Task download1 = DownloadFileAsync("File1.txt", 2000);
            Task download2 = DownloadFileAsync("File2.txt", 3000);
            Task download3 = DownloadFileAsync("File3.txt", 1000);

            // Wait for all downloads to complete
            await Task.WhenAll(download1, download2, download3);

            stopwatch.Stop();

            Console.WriteLine("All downloads completed.");
            Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}