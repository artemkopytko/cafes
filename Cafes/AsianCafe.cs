﻿using System;
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
                case "Wonton":
                    dish = new Wonton();
                    break;
                case "Dimsum":
                    dish = new Dimsum();
                    break;
                case "Mooncake":
                    dish = new Mooncake();
                    break;
                case "Vegan Dimsum":
                    dish = new VegetarianDimsum();
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
            Console.WriteLine("Wonton is ready");
        }
        public override void ServeFirst()
        {
            Console.WriteLine("Wonton is served\n");
        }
        public override void CookSecond()
        {
            Console.WriteLine("Dimsum is ready");
        }
        public override void ServeSecond()
        {
            Console.WriteLine("Dimsum is served\n");
        }
        public override void CookDesert()
        {
            Console.WriteLine("Mooncake is ready");
        }
        public override void ServeDesert()
        {
            Console.WriteLine("Mooncake is served\n");
        }

    }
}
