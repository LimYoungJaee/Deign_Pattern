using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.Name);
            Console.WriteLine();
            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.Name);
        }
    }
}
