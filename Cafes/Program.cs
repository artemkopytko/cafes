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
            List<Dish> chosenDishes = new List<Dish>();
            String chosenCafe = "";
            String chosenDish = "";
            String extraDish = "";
            String payForOrder = "";
            Random rnd = new Random();
            int randomNumber = 0;

        chooseCafe:
            chosenDishes.Clear();
            do
            {
                Console.WriteLine("Choose cafe you want to visit");
                Console.WriteLine("1)Italian\t\t2)Asian");
                Console.WriteLine("0)Go away from the cafes");
                chosenCafe = Console.ReadLine();
            } while (chosenCafe != "0" && chosenCafe != "1" && chosenCafe != "2");
            if (chosenCafe == "1")
            {
                Dish minestrone = new Minestrone();
                Dish pizza = new Pizza();
                Dish tiramisu = new Tiramisu();
                VegetarianPizza vegetarianPizza = new VegetarianPizza();
                List<Dish> italianDishes = new List<Dish> { minestrone, pizza, tiramisu };

                PrintLine();
                PrintCafeWelcome("italian");
            /*
            Console.WriteLine("Cooking time: {0}", pizza.GetCookingTime());
            Console.WriteLine("Cooking time vegan: {0}", vegetarianPizza.GetCookingTime());
            // pizza.Request();
            // vegetarianPizza.Request();
            Console.WriteLine("vegan pizza price: {0}", pizza.GetPrice(pizza.GetIngredients()));
            Console.WriteLine("vegan pizza name: {0}", pizza.GetDishName());
            Console.WriteLine("vegan pizza price: {0}", vegetarianPizza.GetPrice(vegetarianPizza.GetIngredients()));
            Console.WriteLine("vegan pizza name: {0}", vegetarianPizza.GetDishName());*/

            chooseItalianDish:

                randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    italianDishes = new List<Dish> { minestrone, pizza, tiramisu };
                }
                else
                {
                    Console.WriteLine("Sorry, meat pizza is not avaliable now...");
                    Console.WriteLine("But you can choose vegetarian one!");
                    italianDishes = new List<Dish> { minestrone, vegetarianPizza, tiramisu };
                }
                PrintMenu(italianDishes);
                Console.WriteLine("0) I want nothing\n");

                do
                {
                    Console.Write("Your choice: ");
                    chosenDish = Console.ReadLine();
                } while (chosenDish != "0" && chosenDish != "1" && chosenDish != "2" && chosenDish != "3");
                if (chosenDish == "0")
                {
                    if (chosenDishes.Count > 0)
                    {
                        goto italianCheckout;
                    }
                    else
                    {
                        Console.WriteLine("What a pity!\n" +
                                          "Hoping to see you again...");
                        goto chooseCafe;
                    }
                }

                int resultCode = HandleDishChoice(italianDishes, chosenDish);
                if (resultCode == 0)
                {

                    goto chooseCafe;
                }
                chosenDishes.Add(italianDishes[resultCode - 1]);
                do
                {
                    Console.WriteLine("Something else? (y/n)");
                    extraDish = Console.ReadLine();
                } while (extraDish != "y" && extraDish != "n");
                if (extraDish == "y")
                {
                    goto chooseItalianDish;
                }
            italianCheckout:
                PrintCheckout(chosenDishes);
                do
                {
                    Console.WriteLine("Pay for an order? (y/n)");
                    payForOrder = Console.ReadLine();
                } while (payForOrder != "y" && payForOrder != "n");
                if (payForOrder == "n")
                {
                    PrintNotPaid();
                    goto chooseCafe;
                }
                Console.WriteLine("Great to hear!");
                Console.WriteLine("We've alreay started cooking your meal!\n\n");
                foreach (Dish dish in chosenDishes)
                {
                    italianCafe.GetDish(dish.GetDishName());
                    switch (dish.GetDishName())
                    {
                        case "Minestrone":
                            italianCafe.CookFirst();
                            italianCafe.ServeFirst();
                            break;
                        case "Pizza":
                            italianCafe.CookSecond();
                            italianCafe.ServeSecond();
                            break;
                        case "Tiramisu":
                            italianCafe.CookDesert();
                            italianCafe.ServeDesert();
                            break;
                        case "Vegan Pizza":
                            italianCafe.CookSecond();
                            italianCafe.ServeSecond();
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
            }
            else if (chosenCafe == "2")
            {
                Dish wonton = new Wonton();
                Dish dimsum = new Dimsum();
                Dish mooncake = new Mooncake();
                Dish vegetarianDimsum = new VegetarianDimsum();
                List<Dish> asianDishes = new List<Dish> { wonton, dimsum, mooncake };

                PrintLine();
                PrintCafeWelcome("asian");

            chooseAsianDish:

                randomNumber = rnd.Next(1, 3);
                if (randomNumber == 1)
                {
                    asianDishes = new List<Dish> { wonton, dimsum, mooncake };
                }
                else
                {
                    Console.WriteLine("Sorry, fish dimsum is not avaliable now...");
                    Console.WriteLine("But you can choose vegetarian one!");
                    asianDishes = new List<Dish> { wonton, vegetarianDimsum, mooncake };
                }


                PrintMenu(asianDishes);
                Console.WriteLine("0) I want nothing\n");

                do
                {
                    Console.Write("Your choice: ");
                    chosenDish = Console.ReadLine();
                } while (chosenDish != "0" && chosenDish != "1" && chosenDish != "2" && chosenDish != "3");
                if (chosenDish == "0")
                {
                    if (chosenDishes.Count > 0)
                    {
                        goto asianCheckout;
                    }
                    else
                    {
                        Console.WriteLine("What a pity!\n" +
                                          "Hoping to see you again...");
                        goto chooseCafe;
                    }
                }
                int resultCode = HandleDishChoice(asianDishes, chosenDish);
                if (resultCode == 0)
                {

                    goto chooseCafe;

                }
                chosenDishes.Add(asianDishes[resultCode - 1]);
                do
                {
                    Console.WriteLine("Something else? (y/n)");
                    extraDish = Console.ReadLine();
                } while (extraDish != "y" && extraDish != "n");
                if (extraDish == "y")
                {
                    goto chooseAsianDish;
                }
            asianCheckout:
                PrintCheckout(chosenDishes);

                do
                {
                    Console.WriteLine("Pay for an order? (y/n)");
                    payForOrder = Console.ReadLine();
                } while (payForOrder != "y" && payForOrder != "n");
                if (payForOrder == "n")
                {
                    PrintNotPaid();
                    goto chooseCafe;
                }
                Console.WriteLine("Great to hear!");
                Console.WriteLine("We've alreay started cooking your meal!\n\n");
                foreach (Dish dish in chosenDishes)
                {
                    asianCafe.GetDish(dish.GetDishName());
                    switch (dish.GetDishName())
                    {
                        case "Wonton":
                            asianCafe.CookFirst();
                            asianCafe.ServeFirst();
                            break;
                        case "Dimsum":
                            asianCafe.CookSecond();
                            asianCafe.ServeSecond();
                            break;
                        case "Mooncake":
                            asianCafe.CookDesert();
                            asianCafe.ServeDesert();
                            break;
                        case "Vegan Dimsum":
                            asianCafe.CookSecond();
                            asianCafe.ServeSecond();
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }


            }
            else
            {
                Console.WriteLine("I'm not hungry yet");
                Console.WriteLine("Walking,walking,walking...");
                Thread.Sleep(2000);
                goto chooseCafe;
            }

            goto chooseCafe;

            // METHODS

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
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| {0,-2}{1,-15}{2,-15} |", "№", "Product", "Price");
            }
            void PrintMenuItem(Dish dish, int ind)
            {
                Console.WriteLine("| {0,-2}{1,-15}{2,-15} |", ind.ToString(), dish.GetDishName(), dish.GetPrice(dish.GetIngredients()).ToString());

            }
            void PrintMenuEnding()
            {
                Console.WriteLine("-----------------------------------");
            }
            void PrintLine()
            {
                Console.WriteLine("***********************************");
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
            void PrintCheckout(List<Dish> orderedDishes)
            {
                PrintLine();
                Console.WriteLine("Here is your check");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| {0,-2}{1,-15}{2,-10}{3,-5} |", "№", "Product", "Price", "Sum");
                int index = 0;
                double totalPrice = 0.0;
                foreach (Dish dish in orderedDishes)
                {
                    ++index;
                    totalPrice += dish.GetPrice(dish.GetIngredients());
                    Console.WriteLine("| {0,-2}{1,-15}{2,-10}{3,-5} |", index.ToString(), dish.GetDishName(), dish.GetPrice(dish.GetIngredients()).ToString(), totalPrice);
                }
                Console.WriteLine("| {0,-27}{1,-5} |", "Total sum ", totalPrice.ToString());
                Console.WriteLine("-----------------------------------");
            }
            void PrintNotPaid()
            {
                Console.WriteLine("What a pity...");
                Console.WriteLine("Hope to see you again!");
                Console.WriteLine("Have a nice day");
            }
            void LeaveCafe()
            {
                Console.WriteLine("Thanks for coming!");
                Console.WriteLine("See you soon!");
            }
        }
    }
}
