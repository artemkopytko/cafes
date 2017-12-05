using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Cafes.ItalianDishes;
//namespace Caf

namespace Cafes
{
    public class ItalianCafe : Cafe
    {
        public override Dish CreateDish(string type)
        {
            Dish dish = new Dish();

            switch (type)
            {
                case "Минестроне":
                    dish = new Minestrone();
                    break;
                case "Пицца":
                    dish = new Pizza();
                    break;
                case "Тирамису":
                    dish = new Tiramisu();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        public ItalianCafe()
        {
        }
    }
}
