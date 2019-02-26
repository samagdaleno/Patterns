using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class WeatherAdapter : IAdapter
    {
        private readonly IWeather _oldWeather;

        public WeatherAdapter(IWeather oldWeather) {
            _oldWeather = oldWeather;
        }

        public string Date()
        {
            string date = _oldWeather.Date().ToString("dddd, dd MMMM yyyy h:mm tt");
            return date;
        }

        public string Location() => _oldWeather.City();

        public double Temperature()
        {
            string tempStr = Regex.Match(_oldWeather.TemperatureF(), @"\d+").Value;
            double temp = Math.Round(((double.Parse(tempStr) - 32) * 5) / 9,2);

            return temp;
        }

        public string Time()
        {
            string time = _oldWeather.Date().TimeOfDay.ToString();
            return time;
        }

        public string Unit() => " C°";
    }
}
