using System;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;

namespace Cafes.ItalianDishes
{
    public class VegetarianPizza : Dish
    {
        Pizza pizza = new Pizza();
        public VegetarianPizza()
        {
            name = "Vegan Pizza";
            ingredients.Add(new Dough());
            ingredients.Add(new Flour());
            ingredients.Add(new Cheese());
            ingredients.Add(new Sauce());
            ingredients.Add(new Spice());
            cookingTime = 15;
            price = GetPrice(ingredients);

            // Console.WriteLine("Veg pizza initialized");
        }
        public override int GetCookingTime()
        {
            return pizza.GetCookingTime();
        }
    }
}
