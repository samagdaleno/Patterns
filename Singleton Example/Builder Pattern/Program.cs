using Builder_Pattern.Builders;
using Builder_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            CarBuilder cb = new CarBuilder();
            CarManualBuilder cmb = new CarManualBuilder();

            Car sportsCar = director.buildSportsCar(cb);
            printCarInfo(sportsCar);
            printCarInfo(director.buildSedan(cb));
            printManual(director.buildSedanManual(cmb));
            

            Console.ReadKey();
        }

        static void printCarInfo(Car car) {
            Console.WriteLine("Car Built - " + car.Name +
                              "\n\tSeats: " + car.Seats +
                              "\n\tComputer: " + car.TripComputer +
                              "\n\tGPS: " + car.GPS +
                              "\n\tEngine: " + car.engine.name +
                              "\n\t\t Type: " + car.engine.type +
                              "\n\t\t Max Speed: " + car.engine.maxSpeed +
                              "\n\t\t Horsepower: " + car.engine.HP);
            Console.WriteLine("-------------------------------------------");
        }

        static void printManual(CarManual manual) {
            Console.WriteLine(manual.Title + "\n" + 
                              manual.EngineDescription + "\n" +
                              manual.SeatsDescription + "\n" +
                              manual.GPSDescription + "\n" +
                              manual.TripComputerDescription);
            Console.WriteLine("-------------------------------------------");
        }

    }
}
