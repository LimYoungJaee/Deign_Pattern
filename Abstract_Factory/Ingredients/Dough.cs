using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class ThickCrustDough : IDough
    {
        string IDough.ToString()
        {
            return "ThickCrust style extra thick crust dough";
        }
    }

    public class ThinCrustDough : IDough
    {
        string IDough.ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
