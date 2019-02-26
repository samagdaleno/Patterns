using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    public abstract class PizzaTemplate
    {
        public virtual void makePizza() {
            preapareDough();

            addFoundation();

            addCheese();

            addMeats();

            addVeggies();

            bakePizza();

            boxPizza();

        }

        public abstract void preapareDough();
        public abstract void addCheese();
        public virtual void addFoundation() { Console.WriteLine("Adding tomato sauce base."); } //Hooks
        public virtual void addMeats() { } //Hooks
        public virtual void addVeggies() { } //Hooks

        private void bakePizza(){
            Console.WriteLine("Baking pizza.");
        }

        private void boxPizza(){
            Console.WriteLine("Boxing pizza.");
            Console.WriteLine("Delivering it to client.\n------------------------------------");
        }

        bool pizzaHasMeats() { return true; }
        bool pizzaHasVeggies() { return true; }
    }
}
