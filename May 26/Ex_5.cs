using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<string> Server1(CancellationToken token)
    {
        int delay = new Random().Next(1000, 5000);
        await Task.Delay(delay, token);
        return $"Server1 responded in {delay}ms";
    }

    static async Task<string> Server2(CancellationToken token)
    {
        int delay = new Random().Next(1000, 5000);
        await Task.Delay(delay, token);
        return $"Server2 responded in {delay}ms";
    }

    static async Task<string> Server3(CancellationToken token)
    {
        int delay = new Random().Next(1000, 5000);
        await Task.Delay(delay, token);
        return $"Server3 responded in {delay}ms";
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var token = cts.Token;
       
        var tasks = new[]
        {
            Server1(token),
            Server2(token),
            Server3(token)
        };
       
        Task<string> fastest = await Task.WhenAny(tasks);

        Console.WriteLine($"Fastest Response: {fastest.Result}");

        cts.Cancel();

        try
        {   
            await Task.WhenAll(tasks);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Remaining server requests were cancelled.");
        }

        Console.WriteLine("Simulation complete.");
    }
}