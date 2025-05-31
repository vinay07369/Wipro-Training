using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class WeatherFetch
    {
        public async Task<string> GetWeatherAsync(string city)
        {
            // Simulate an asynchronous operation (e.g., fetching weather data)
            Console.WriteLine($"Fetching weather data for {city}...");

            await Task.Delay(3000); // Simulating network delay

            return $"Weather data for {city} : {new Random().Next(20,35)} degree celcius";
        }

        public async Task FetchWeatherForCitiesAsync(List<string> cities)
        {
            List<Task<string>> weatherTasks = new List<Task<string>>();
            
            foreach (var city in cities)
            {
                weatherTasks.Add(GetWeatherAsync(city));
            }

            // Wait for all tasks to complete
            var results = await Task.WhenAll(weatherTasks);

            // Display the results
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        
        class Program
        {
            static async Task Main(string[] args)
            {
                WeatherFetch weatherFetch = new WeatherFetch();
                
                Console.WriteLine("Welcome to the Weather Fetching System!");
                Console.WriteLine("-----------------------------------------------");

                Stopwatch sw = new Stopwatch();

                sw.Start();

                List<string> cities = new List<string> { "Chennai", "Hyderabad", "Bangalore", "Mumbai", "Patna" };
                
                await weatherFetch.FetchWeatherForCitiesAsync(cities);

                sw.Stop();

                Console.WriteLine($"\nTime taken to fetch weather data: {sw.ElapsedMilliseconds} ms");
            }
        }   
    }
}