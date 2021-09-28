using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleClientFromTemplate
{
    static class Program
    {
        static async Task Main()
        {
            var httpClient = new HttpClient();
            var client = new swaggerClient("https://localhost:5001/", httpClient);
            var results = (await client.WeatherForecastAsync());
            var firstForecast = results.First();
            Console.WriteLine(JsonSerializer.Serialize(firstForecast, new JsonSerializerOptions()
            {
                WriteIndented = true
            }));
        }
    }
}
