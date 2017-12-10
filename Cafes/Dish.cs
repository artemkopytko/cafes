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
        protected int cookingTime = 0;

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
            Console.Write("Ingredients are: ");
            foreach (var ingredient in ingredients)
            {
                Console.Write(ingredient.GetName() + ", ");
            }
            Console.WriteLine();
            PrintLine();
        }
        private void PrintLine()
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
        public int GetCookingTime()
        {
            return this.cookingTime;
        }
        public List<Ingredient> GetIngredients()
        {
            return this.ingredients;
        }
        public double GetPrice(List<Ingredient> ingredients)
        {
            double totalPrice = 0.0;
            foreach (var ingredient in ingredients)
            {
                totalPrice += ingredient.GetPrice();
            }
            return totalPrice;
        }

        public string GetDishName()
        {
            return this.name;
        }

    }
}
