using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class SlicedPepperoni : IPepperoni
    {
        string IPepperoni.ToString()
        {
            return "Sliced Pepperoni";
        }
    }


}
