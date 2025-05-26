using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    class Program
    {
        static async Task Main()
        {
            // Simulate 20 image file names
            var images = new List<string>();
            for (int i = 1; i <= 20; i++)
            {
                images.Add($"Image_{i}.jpg");
            }

            int totalImages = images.Count;
            int processedCount = 0;

            Console.WriteLine("Starting batch image processing...\n");

            var options = new ParallelOptions
            {
                MaxDegreeOfParallelism = 4 // Adjust concurrency level
            };

            await Parallel.ForEachAsync(images, options, async (image, token) =>
            {
                // Simulate processing time
                await Task.Delay(200, token);

                int done = Interlocked.Increment(ref processedCount);
                double percentage = (double)done / totalImages * 100;

                Console.WriteLine($"Processed {image} - {percentage:F1}% complete");
            });

            Console.WriteLine("\nAll images processed.");
        }
    }
}
