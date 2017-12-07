using System;
namespace Cafes
{
    abstract public class Cafe
    {
        public abstract Dish CreateDish(string type);

        public Dish GetDish(string type)
        {
            Dish dish = CreateDish(type);

            /* DISH CREATION METHODS*/
            //dish. ;
            //dish. ;

            return dish;
        }
    }
}
