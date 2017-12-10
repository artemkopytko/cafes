﻿using System;
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

        public virtual void ServeFirst()
        {
            Console.WriteLine("Подаем первое");
        }

        public abstract void CookSecond();

        public virtual void ServeSecond()
        {
            Console.WriteLine("Подаем второе");
        }

        public abstract void CookDesert();

        public virtual void ServeDesert()
        {
            Console.WriteLine("Подаем десерт");
        }
    }
}
