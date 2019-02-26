using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ship Creator:");
            ClientCode(new ShipFactory());

            Console.WriteLine("Truck Creator:");
            ClientCode(new TruckFactory());

            Console.ReadKey();

        }

        public static void ClientCode(Creator factory)
        {
            Console.WriteLine(factory.GetTransportation()); 
        }
    }
}
