using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafes
{
    public class Ingredient
    {
        protected string name = "";
        protected double price = 0.0;

        public double GetPrice()
        {
            return this.price;
        }

        public Ingredient()
        {
        }
    }
}
