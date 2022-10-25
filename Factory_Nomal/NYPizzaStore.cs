using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_2
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}
