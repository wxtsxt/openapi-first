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
            var client = new swagger1Client("https://localhost:5023/", httpClient);
            var response = await client.WeatherForecastAsync(new WeatherForecast
            {
                Date = new DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero),
                Summary = "cold",
                TemperatureC = 0
            });

            Console.WriteLine(response.Date);

            Console.ReadLine();
        }
    }
}
