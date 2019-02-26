using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Truck : ITransport
    {
        public string TransportMode()
        {
            return "Delivered by land in a box.";
        }
    }
}
