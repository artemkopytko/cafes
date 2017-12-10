using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafes
{
    public class Dish
    {
        protected string name = "";
        protected List<Ingredient> ingredients = new List<Ingredient>();
        protected double price = 0.0;
        protected string cookingTime = "";

        public Dish()
        {
        }

        public void Configure()
        {
            Console.WriteLine("Dish name: {0}", name);
            Console.WriteLine("Dish {0} costs {1}", name, price);
            Console.WriteLine("Cooking time: {0}", cookingTime);
            PrintIngredientsList();
        }

        public void PrintIngredientsList()
        {
            Console.WriteLine("Ingredients are: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
            PrintLine();
        }
        public void PrintLine()
        {
            Console.WriteLine("=========================");
        }
        public void CookBase()
        {
            Console.WriteLine("Base is ready");
        }
        public void CookFilling()
        {
            Console.WriteLine("Filling is ready");
        }
        public void CookDressing()
        {
            Console.WriteLine("Dressing is ready");
        }

    }
}
