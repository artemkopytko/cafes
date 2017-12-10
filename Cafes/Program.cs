using System;

namespace Cafes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strarting...");
            Cafe italianCafe = new ItalianCafe();
            Cafe asianCafe = new AsianCafe();

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
            italianCafe.GetDish("Minestrone");
            Console.WriteLine("\n");
            italianCafe.GetDish("Pizza");
            Console.WriteLine("\n");
            italianCafe.GetDish("Tiramisu");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
