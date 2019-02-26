using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Products
{
    public class CarManual
    {
        public string Title { get; set; }
        public string SeatsDescription { get; set; }
        public string EngineDescription { get; set; }
        public string TripComputerDescription { get; set; }
        public string GPSDescription { get; set; }
    }
}
