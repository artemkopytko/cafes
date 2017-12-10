using System;
using Cafes.ItalianDishes;
using Cafes.AsianDishes;
using System.Collections.Generic;

namespace Cafes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strarting...");
            Cafe italianCafe = new ItalianCafe();
            Cafe asianCafe = new AsianCafe();
            String chosenCafe = "";
        start:
            do
            {
                Console.WriteLine("Choose cafe you want to visit");
                Console.WriteLine("1)Italian\t\t2)Asian");
                chosenCafe = Console.ReadLine();
                Console.WriteLine(chosenCafe);
            } while (chosenCafe != "1" && chosenCafe != "2");
            if (chosenCafe == "1")
            {
                Dish minestrone = new Minestrone();
                Dish pizza = new Pizza();
                Dish tiramisu = new Tiramisu();
                List<Dish> italianDishes = new List<Dish> { minestrone, pizza, tiramisu };
                PrintLine();
                Console.WriteLine("Welcome to italian cafe!");
                Console.WriteLine("Your menu: ");

                PrintMenu(italianDishes);
            }

            //for (int i = 0; i < 25; i += 1)
            //{
            //    Console.WriteLine();
            //}
            goto start;
            /* TODO : 
             * Логика клиента.
             * Выбираем кафе.
             * Выбираем блюдо.
             * Возвращаемся к меню.
             * Выбираем блюдо.
             * Возвращаемся к меню.
             * Возвращаемся к выбору кафе.
             * Завершаем программу.
             */
            //italianCafe.GetDish("Minestrone");
            //Console.WriteLine("\n");
            //italianCafe.GetDish("Pizza");
            //Console.WriteLine("\n");
            //italianCafe.GetDish("Tiramisu");
            //Console.WriteLine("\n");

            //Console.ReadLine();

            void PrintMenu(List<Dish> dishes)
            {
                PrintMenuHeading();

                foreach (Dish dishItem in dishes)
                {
                    PrintMenuItem(dishItem);
                }

                PrintMenuEnding();
            }
            void PrintMenuHeading()
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("| {0,-15}{1,-15} |", "Product", "Price");
            }
            void PrintMenuItem(Dish dish)
            {
                Console.WriteLine("| {0,-15}{1,-15} |", dish.GetDishName(), dish.GetPrice(dish.GetIngredients()).ToString());

            }
            void PrintMenuEnding()
            {
                Console.WriteLine("----------------------------------");
            }
            void PrintLine()
            {
                Console.WriteLine("==================================");
            }
        }

    }
}
