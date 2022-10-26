using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class FreshClams : IClams
    {
        string IClams.ToString()
        {
            return "FreshClams";
        }
    }
    public class FrozenClams : IClams
    {
        string IClams.ToString()
        {
            return "FrozenClams";
        }
    }
}
