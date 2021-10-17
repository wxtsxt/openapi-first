using System;
using NodaTime;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiFromTemplate;

namespace ConsoleClientEnriched
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var client = new contract_first_swaggerClient("https://localhost:5041/", httpClient);
            var response = await client.WeatherForecastAsync(new WeatherForecast
            {
                DateOf = new LocalDate(2020,1,31),
                Summary = "cold",
                TemperatureC = 0
            });
            Console.WriteLine(response.DateOf);
            Console.ReadLine();
        }
    }
}
