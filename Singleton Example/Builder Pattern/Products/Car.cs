using Builder_Pattern.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Products
{
    public class Car
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public Engine engine { get; set; }
        public string TripComputer { get; set; }
        public string GPS { get; set; }
    }
}
