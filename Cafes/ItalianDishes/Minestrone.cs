using System;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;

namespace Cafes.ItalianDishes
{
    public class Minestrone : Dish
    {
        public Minestrone()
        {
            name = "Minestrone";
            ingredients.Add(new Water());
            ingredients.Add(new Meat());
            ingredients.Add(new Grass());
            ingredients.Add(new Spice());
            cookingTime = "30 minutes";
            price = GetPrice(ingredients);
        }
    }
}
