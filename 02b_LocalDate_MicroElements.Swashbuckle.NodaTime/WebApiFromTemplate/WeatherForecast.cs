using System;
using NodaTime;

namespace WebApiFromTemplate
{
    public class WeatherForecast
    {
        public LocalDate Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
