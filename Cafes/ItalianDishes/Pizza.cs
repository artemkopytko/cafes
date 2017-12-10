using System;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;

namespace Cafes.ItalianDishes
{
    public class Pizza : Dish
    {
        public Pizza()
        {
            name = "Pizza";
            ingredients.Add(new Dough());
            ingredients.Add(new Flour());
            ingredients.Add(new Salami());
            ingredients.Add(new Cheese());
            ingredients.Add(new Sauce());
            ingredients.Add(new Spice());
            cookingTime = "15 minutes";
            price = GetPrice(ingredients);
        }
    }
}
