using Builder_Pattern.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    interface IBuilder
    {
        void setName(string name);
        void setSeats(int number);
        void setEngine(Engine engine);
        void setTripComputer(string tripcomp);
        void setGPS(string gps);
    }
}
