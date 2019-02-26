using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public abstract class Creator
    {
        public abstract ITransport Transport();

        public string GetTransportation() {

            return Transport().TransportMode();
        }
    }
}
