using Builder_Pattern.Engines;
using Builder_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builders
{
    public class CarManualBuilder : IBuilder
    {
        private CarManual _manual = new CarManual();

        public void setEngine(Engine engine)
        {
            _manual.EngineDescription = "The " + engine.name + " "+ engine.type +" engine has a max speed of " + engine.maxSpeed + " and "  + engine.HP + " horsepower.";
        }

        public void setGPS(string gps)
        {
            _manual.GPSDescription = gps;
        }

        public void setName(string name)
        {
            _manual.Title = name;
        }

        public void setSeats(int number)
        {
            _manual.SeatsDescription = "Number of seats: " + number.ToString();
        }

        public void setTripComputer(string tripcomp)
        {
            _manual.TripComputerDescription = tripcomp;
        }

        public CarManual getManual()
        {
            return _manual;
        }
    }
}
