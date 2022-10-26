using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Ingredients
{
    public class MarinaraSauce : ISauce
    {
        string ISauce.ToString()
        {
            return "Marinara Sauce";
        }
    }

    public class PlumTomatoSauce : ISauce
    {
        string ISauce.ToString()
        {
            return "PlumTomato Sauce";
        }
    }

}
