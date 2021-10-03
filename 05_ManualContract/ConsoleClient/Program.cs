using System;
using NodaTime;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleClient;
using WebApiFromTemplate;

namespace ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var client = new swaggerClient("https://localhost:5051/", httpClient);
            var response = await client.WeatherForecastAsync(new WeatherForecast
            {
                DateOf = LocalDate.FromDateTime(DateTime.Now),
                Summary = "cold",
                TemperatureC = 0
            });
            Console.WriteLine(response.DateOf);
        }
    }
}
