using Builder_Pattern.Engines;
using Builder_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builders
{
    public class CarBuilder : IBuilder
    {
        private Car _car = new Car();

        public void setName(string name)
        {
            _car.Name = name;
        }

        public void setEngine(Engine engine)
        {
            _car.engine = engine;
        }

        public void setGPS(string gps)
        {
            _car.GPS = gps;
        }

        public void setSeats(int number)
        {
            _car.Seats = number;
        }

        public void setTripComputer(string tripcomp)
        {
            _car.TripComputer = tripcomp;
        }

        public Car getCar() {
            return _car;
        }
    }
}
