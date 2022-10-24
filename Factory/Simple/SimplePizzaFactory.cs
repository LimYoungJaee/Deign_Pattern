using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Simple
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
