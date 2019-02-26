using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class VeganPizza : PizzaTemplate
    {
        public override void addCheese()
        {
            Console.WriteLine("Adding vegan cheese.");
        }

        public override void preapareDough()
        {
            Console.WriteLine("Making Vegan Pizza. \nPreparing wheat-free dough.");
        }

        public override void addVeggies()
        {
            Console.WriteLine("Adding tomato.");
            Console.WriteLine("Adding pepper.");
            Console.WriteLine("Adding onions.");
            Console.WriteLine("Adding mushrooms.");
            Console.WriteLine("Adding black olives.");
        }
    }
}
