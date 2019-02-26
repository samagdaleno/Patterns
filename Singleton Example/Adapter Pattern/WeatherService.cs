using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class WeatherService : IWeather
    {
        Random rnd = new Random();

        public string City() => "Tijuana";

        public DateTime Date() => DateTime.Now;

        public string TemperatureF() => rnd.Next(-22, 122).ToString() + " F°";
    }
}
