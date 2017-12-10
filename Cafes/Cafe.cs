using System;
using System.Threading;

namespace Cafes
{
    abstract public class Cafe
    {
        public abstract Dish CreateDish(string type);

        public Dish GetDish(string type)
        {
            Dish dish = CreateDish(type);

            dish.Configure();
            dish.CookBase();
            Thread.Sleep(dish.GetCookingTime() * 50);
            dish.CookFilling();
            Thread.Sleep(dish.GetCookingTime() * 30);
            dish.CookDressing();
            Thread.Sleep(dish.GetCookingTime() * 20);

            return dish;
        }
        public void TemplateMethod()
        {
            CookFirst();
            ServeFirst();
            CookSecond();
            ServeSecond();
            CookDesert();
            ServeDesert();
        }
        public abstract void CookFirst();

        public abstract void ServeFirst();

        public abstract void CookSecond();

        public abstract void ServeSecond();

        public abstract void CookDesert();

        public abstract void ServeDesert();
    }
}
