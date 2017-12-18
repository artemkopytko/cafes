using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cafes.ItalianDishes;


namespace Cafes
{
    public class ItalianCafe : Cafe
    {
        public override Dish CreateDish(string type)
        {
            Dish dish = new Dish();

            switch (type)
            {
                case "Minestrone":
                    dish = new Minestrone();
                    break;
                case "Pizza":
                    dish = new Pizza();
                    break;
                case "Tiramisu":
                    dish = new Tiramisu();
                    break;
                case "Vegan Pizza":
                    dish = new VegetarianPizza();
                    break;
                default:

                    Console.WriteLine("Here");
                    Console.WriteLine("Error");
                    break;
            }
            return dish;
        }

        public ItalianCafe()
        {
        }
        public override void CookFirst()
        {
            Console.WriteLine("Minestrone is ready");
        }
        public override void ServeFirst()
        {
            Console.WriteLine("Minestrone is served\n");
        }
        public override void CookSecond()
        {
            Console.WriteLine("Pizza is ready");
        }
        public override void ServeSecond()
        {
            Console.WriteLine("Pizza is served\n");
        }
        public override void CookDesert()
        {
            Console.WriteLine("Tiramisu is ready");
        }
        public override void ServeDesert()
        {
            Console.WriteLine("Tiramisu is served\n");
        }

    }
}
