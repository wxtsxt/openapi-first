using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NodaTime;
using NodaTime.Serialization.SystemTextJson;

namespace ConsoleClientFromTemplate
{
    static class Program
    {
        static async Task Main()
        {
            var httpClient = new HttpClient();
            var client = new swaggerClient("https://localhost:5001/", httpClient);
            var results = await client.WeatherForecastAsync();
            WeatherForecast firstForecast = results.First();
            Console.WriteLine(JsonSerializer.Serialize(firstForecast, new JsonSerializerOptions()
            {
                WriteIndented = true
            }));
        }
    }

    public partial class swaggerClient
    {
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings)
        {
            // we may adjust JsonSerializerSettings, but NodaTime.Serialization.SystemTextJson package supports only adjusting JsonSerializerOptions
        }

    }
}
