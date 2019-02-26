using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class ShipFactory : Creator
    {
        public override ITransport Transport()
        {
            return new Ship();
        }
    }
}
