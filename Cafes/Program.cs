using System;
using Cafes.ItalianDishes;
using Cafes.AsianDishes;
using System.Collections.Generic;
using System.Threading;

namespace Cafes
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintCafeOnStart();

            Cafe italianCafe = new ItalianCafe();
            Cafe asianCafe = new AsianCafe();
            String chosenCafe = "";
            String chosenDish = "";
            String extraDish = "";
        chooseCafe:
            do
            {
                Console.WriteLine("Choose cafe you want to visit");
                Console.WriteLine("1)Italian\t\t2)Asian");
                chosenCafe = Console.ReadLine();
            } while (chosenCafe != "1" && chosenCafe != "2");
            if (chosenCafe == "1")
            {
                Dish minestrone = new Minestrone();
                Dish pizza = new Pizza();
                Dish tiramisu = new Tiramisu();
                List<Dish> italianDishes = new List<Dish> { minestrone, pizza, tiramisu };
                List<Dish> chosenDishes = new List<Dish>();

                PrintLine();
                PrintCafeWelcome("italian");

            chooseItalianDish:
                PrintMenu(italianDishes);

                Console.WriteLine();

                do
                {
                    Console.Write("Your choice: ");
                    chosenDish = Console.ReadLine();
                } while (chosenDish != "0" && chosenDish != "1" && chosenDish != "2" && chosenDish != "3");
                int resultCode = HandleDishChoice(italianDishes, chosenDish);
                if (resultCode == 0)
                {
                    goto chooseCafe;
                }
                chosenDishes.Add(italianDishes[resultCode - 1]);
                Console.WriteLine("Something else? (y/n)");

                extraDish = Console.ReadLine();

                if (extraDish == "y")
                {
                    goto chooseItalianDish;
                }
                else
                {

                }

            }
            else if (chosenCafe == "2")
            {
                Dish wonton = new Wonton();
                Dish dimsum = new Dimsum();
                Dish mooncake = new Mooncake();
                List<Dish> asianDishes = new List<Dish> { wonton, dimsum, mooncake };

                PrintLine();
                PrintCafeWelcome("asian");
                PrintMenu(asianDishes);

                Console.WriteLine();
                do
                {
                    Console.Write("Your choice: ");
                    chosenDish = Console.ReadLine();
                } while (chosenDish != "0" && chosenDish != "1" && chosenDish != "2" && chosenDish != "3");

            }

            //for (int i = 0; i < 25; i += 1)
            //{
            //    Console.WriteLine();
            //}
            goto chooseCafe;
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
            void PrintCafeOnStart()
            {
                Console.WriteLine("Cafes are closed...");
                Thread.Sleep(400);
                Console.WriteLine("Staff is getting into cafes");
                Thread.Sleep(700);
                Console.WriteLine("Tables are being cleared");
                Thread.Sleep(500);
                Console.WriteLine("Windows are being washed");
                Thread.Sleep(700);
                Console.WriteLine("The door sign is turned");
                Thread.Sleep(200);
                Console.WriteLine("Cafes are opened now!");
            }
            void PrintCafeWelcome(string type)
            {

                Console.WriteLine("Welcome to {0} cafe!", type);
                Console.WriteLine("Our menu: ");
            }
            void PrintMenu(List<Dish> dishes)
            {
                PrintMenuHeading();
                int index = 0;
                foreach (Dish dishItem in dishes)
                {
                    ++index;
                    PrintMenuItem(dishItem, index);
                }

                PrintMenuEnding();
            }
            void PrintMenuHeading()
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("| {0,-2}{1,-15}{2,-15} |", "№", "Product", "Price");
            }
            void PrintMenuItem(Dish dish, int ind)
            {
                Console.WriteLine("| {0,-2}{1,-15}{2,-15} |", ind.ToString(), dish.GetDishName(), dish.GetPrice(dish.GetIngredients()).ToString());

            }
            void PrintMenuEnding()
            {
                Console.WriteLine("----------------------------------");
            }
            void PrintLine()
            {
                Console.WriteLine("==================================");
            }
            void PrintDishChoice(Dish dish)
            {
                Console.WriteLine(dish.GetDishName() + " is a great choice!");
                Console.WriteLine("It'll be cooked in a {0} minutes", dish.GetCookingTime());
            }
            int HandleDishChoice(List<Dish> dishes, string dishChoice)
            {
                if (dishChoice == "0")
                {
                    LeaveCafe();
                    return 0;
                }
                else
                {
                    PrintDishChoice(dishes[Int32.Parse(dishChoice) - 1]);
                    return Int32.Parse(dishChoice);
                }
            }

            void LeaveCafe()
            {
                Console.WriteLine("Thanks for coming!");
                Console.WriteLine("See you soon!");
            }
        }
    }
}
