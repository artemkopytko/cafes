using System;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Common;

namespace Cafes.AsianDishes
{
    public class VegetarianDimsum : Dish
    {

        public VegetarianDimsum()
        {

            name = "Dimsum";
            ingredients.Add(new Shrimps());
            ingredients.Add(new Dough());
            ingredients.Add(new Spice());
            ingredients.Add(new Flour());
            cookingTime = 30;
            price = GetPrice(ingredients);

        }
        public override void Request()
        {
            Console.WriteLine("Original {0}", this.name);
        }
    }
}
