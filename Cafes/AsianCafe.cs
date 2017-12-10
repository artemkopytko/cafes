using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cafes.AsianDishes;


namespace Cafes
{
    public class AsianCafe : Cafe
    {
        public override Dish CreateDish(string type)
        {
            Dish dish = new Dish();

            switch (type)
            {
                case "Вонтон":
                    dish = new Wonton();
                    break;
                case "Димсам":
                    dish = new Dimsum();
                    break;
                case "Лунный кекс":
                    dish = new Mooncake();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            return dish;
        }

        public AsianCafe()
        {
        }
        public override void CookFirst()
        {

        }
        public override void CookSecond()
        {

        }
        public override void CookDesert()
        {

        }
    }
}
