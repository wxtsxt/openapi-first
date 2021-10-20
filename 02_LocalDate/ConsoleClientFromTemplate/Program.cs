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
            var client = new swaggerClient("https://localhost:5021/", httpClient);

            var response = await client.WeatherForecastAsync(new WeatherForecast
            {
                Date = new LocalDate {Year = 2020, Month = 5, Day = 3},
                Summary = "cold",
                TemperatureC = 0
            });

            Console.WriteLine(response.Date);
            Console.ReadLine();
        }
    }
}
