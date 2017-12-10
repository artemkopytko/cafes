using System;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Common;

namespace Cafes.AsianDishes
{
    public class Dimsum : Dish
    {

        public Dimsum()
        {

            name = "Dim Sum";
            ingredients.Add(new Shrimps());
            ingredients.Add(new Dough());
            ingredients.Add(new Spice());
            ingredients.Add(new Flour());
            cookingTime = 30;
            price = GetPrice(ingredients);

        }
    }
}
