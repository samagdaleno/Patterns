using Adapter_Pattern.Employee_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherService oldWeather = new WeatherService();

            IAdapter currentWeather = new WeatherAdapter(oldWeather);
            string location = currentWeather.Location(),
                   date = currentWeather.Date(),
                   time = currentWeather.Time(),
                   unit = currentWeather.Unit();
            double temperature = currentWeather.Temperature();


            Console.WriteLine("Adapted: \n" + oldWeather.Date().ToString() + " " + oldWeather.City() + " " + oldWeather.TemperatureF());
            Console.WriteLine("to ");
            Console.WriteLine(location + ": " + temperature + unit + ", " + date);
            Console.ReadKey();

            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
