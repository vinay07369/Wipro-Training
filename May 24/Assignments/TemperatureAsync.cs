using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class RandomTemperature
    {
        public static async Task<int> GetTemperatureAsync(string city)
        {
            Random r = new Random();
            await Task.Delay(500);
            int temp = r.Next(1, 45);

            Console.WriteLine("City:" + city + ","+" Temperature:" + temp + "°C");
            return temp;
        }
        public static async Task Main()
        {
            Task<int> t1 = GetTemperatureAsync("Chennai");
            Task<int> t2 = GetTemperatureAsync("Coimbator");
            Task<int> t3 = GetTemperatureAsync("Hyderabad");

            await Task.WhenAll(t1, t2, t3);
        }
    }
}