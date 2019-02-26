using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public class PepperoniPizza : PizzaTemplate
    {
        public override void preapareDough()
        {
            Console.WriteLine("Making Pepperoni Pizza. \nPreparing standard dough.");
        }

        public override void addCheese()
        {
            Console.WriteLine("Adding mozzarella cheese.");
        }

        public override void addMeats()
        {
            Console.WriteLine("Adding pepperoni.");
        }
    }
}
