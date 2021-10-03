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
            var client = new swaggerClient("https://localhost:5011/", httpClient);
            //var results = (await client.WeatherForecastAsync());
            await client.WeatherForecastAsync(new WeatherForecast
            {
                Date = new DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero),
                Summary = "cold",
                TemperatureC = 0
            });
        }
    }
}
