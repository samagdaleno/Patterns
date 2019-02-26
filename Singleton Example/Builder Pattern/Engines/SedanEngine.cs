using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Engines
{
    public class SedanEngine : Engine
    {
        public SedanEngine() {
            name = "p$d3L1 2.3";
            maxSpeed = "180 Km/h";
            type = "Fuel Standard";
            HP = "300";

        }
    }
}
