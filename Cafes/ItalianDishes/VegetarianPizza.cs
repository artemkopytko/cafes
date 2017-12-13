using System;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;

namespace Cafes.ItalianDishes
{
    public class VegetarianPizza : Dish
    {
        public VegetarianPizza()
        {
            name = "Pizza";
            ingredients.Add(new Dough());
            ingredients.Add(new Flour());
            ingredients.Add(new Cheese());
            ingredients.Add(new Sauce());
            ingredients.Add(new Spice());
            cookingTime = 15;
            price = GetPrice(ingredients);
        }
        public override void Request()
        {
            Console.WriteLine("Original {0}", this.name);
        }
    }
}
