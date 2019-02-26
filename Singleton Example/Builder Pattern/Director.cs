using Builder_Pattern.Builders;
using Builder_Pattern.Engines;
using Builder_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Director
    {
        public Car buildSportsCar(CarBuilder builder) {
            builder.setName("SPORTS CAR 4000");
            builder.setEngine(new SportEngine());
            builder.setGPS("2039 GPS 2.0");
            builder.setTripComputer("SPORT Computer");
            builder.setSeats(2);

            return builder.getCar();
        }

        public Car buildSedan(CarBuilder builder)
        {
            builder.setName("SEDAN CAR 2019");
            builder.setEngine(new SedanEngine());
            builder.setGPS("None");
            builder.setTripComputer("Standard Computer");
            builder.setSeats(4);

            return builder.getCar();
        }

        public CarManual buildSedanManual(CarManualBuilder builder)
        {
            builder.setName("SEDAN CAR 2019 Manual");
            builder.setEngine(new SedanEngine());
            builder.setGPS("This car doesn't have a GPS.");
            builder.setTripComputer("The Standard Computer description.");
            builder.setSeats(4);

            return builder.getManual();
        }

    }
}
