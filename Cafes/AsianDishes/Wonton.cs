using System;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Common;

namespace Cafes.AsianDishes
{
    public class Wonton : Dish
    {
        public Wonton()
        {
            name = "Wonton";
            ingredients.Add(new Meat());
            ingredients.Add(new Grass());
            ingredients.Add(new Spice());
            ingredients.Add(new Water());
            cookingTime = 20;
            price = GetPrice(ingredients);
        }
    }
}
