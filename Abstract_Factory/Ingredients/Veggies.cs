using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class BlackOlives : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Black Olives";
        }
    }

    public class Garlic : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Garlic";
        }
    }

    public class Eggplant : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Eggplant";
        }
    }

    public class Mushroom : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Mushrooms";
        }
    }

    public class Onion : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Onion";
        }
    }

    public class RedPepper : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Red Pepper";
        }
    }

    public class Spinach : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Spinach";
        }
    }
}
