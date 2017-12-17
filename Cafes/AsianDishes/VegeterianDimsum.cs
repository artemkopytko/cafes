using System;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Common;

namespace Cafes.AsianDishes
{
    public class VegetarianDimsum : Dish
    {
        Dimsum dimsum = new Dimsum();
        public VegetarianDimsum()
        {

            name = "Vegan Dimsum";
            ingredients.Add(new Dough());
            ingredients.Add(new Spice());
            ingredients.Add(new Flour());
            cookingTime = 30;
            price = GetPrice(ingredients);

        }

        public override int GetCookingTime()
        {
            return dimsum.GetCookingTime();
        }
    }
}
