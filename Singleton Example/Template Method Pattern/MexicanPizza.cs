using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class MexicanPizza : PizzaTemplate
    {
        public override void addFoundation()
        {
            Console.WriteLine("Adding frijol base.");
        }

        public override void addCheese()
        {
            Console.WriteLine("Adding Cheddar, Asadero & Monterrey cheese.");
        }

        public override void preapareDough()
        {
            Console.WriteLine("Making Mexican Pizza. \nPreparing traditional dough.");
        }

        public override void addVeggies()
        {
            Console.WriteLine("Adding pepper.");
            Console.WriteLine("Adding onions.");
            Console.WriteLine("Adding jalapeños.");
        }

        public override void addMeats()
        {
            Console.WriteLine("Adding chorizo.");
            Console.WriteLine("Adding meat.");
        }
    }
}
