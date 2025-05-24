using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        var workTask = DoWorkAsync(token);

        // Cancel the task after 2 seconds
        await Task.Delay(2000);
        cts.Cancel();

        try
        {
            await workTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Work was canceled.");
        }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 5; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Working... {i + 1}");
            await Task.Delay(1000); // Simulate work
        }
    }
}
