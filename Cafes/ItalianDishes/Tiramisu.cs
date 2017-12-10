using System;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;

namespace Cafes.ItalianDishes
{
    public class Tiramisu : Dish
    {
        public Tiramisu()
        {
            name = "Tiramisu";
            ingredients.Add(new Sugar());
            ingredients.Add(new Water());
            ingredients.Add(new Chocolate());
            ingredients.Add(new Flour());
            cookingTime = "40 minutes";
            price = GetPrice(ingredients);
        }
    }
}
