using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PepperoniPizza pepPizza = new PepperoniPizza();
            VeganPizza vegPizza = new VeganPizza();
            MexicanPizza mexPizza = new MexicanPizza();

            pepPizza.makePizza();
            vegPizza.makePizza();
            mexPizza.makePizza();
            Console.ReadKey();
        }
    }
}
