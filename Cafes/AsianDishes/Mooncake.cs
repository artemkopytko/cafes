using System;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Common;

namespace Cafes.AsianDishes
{
    public class Mooncake : Dish
    {
        public Mooncake()
        {
            name = "Mooncake";
            ingredients.Add(new Sugar());
            ingredients.Add(new Dough());
            ingredients.Add(new Paste());
            ingredients.Add(new Flour());
            ingredients.Add(new Water());
            cookingTime = 40;
            price = GetPrice(ingredients);
        }
        public override void Request()
        {
            Console.WriteLine("Original {0}", this.name);
        }
    }
}
