using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class MozzarellaCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "MozzarellaCheese";
        }
    }

    public class ParmesanCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "ParmesanCheese";
        }
    }

    public class ReggianoCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "ReggianoCheese";
        }
    }
}
