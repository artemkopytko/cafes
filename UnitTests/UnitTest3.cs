using System;
using Cafes;
using Cafes.Ingredients.Asian;
using Cafes.Ingredients.Italian;
using Cafes.Ingredients.Common;
using Cafes.AsianDishes;
using Cafes.ItalianDishes;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dish pizza = new Pizza();
            Dish vegetarianPizza = new Pizza();

            double pizzaP = pizza.GetPrice(pizza.GetIngredients());
            double vegPizzaP = vegetarianPizza.GetPrice(vegetarianPizza.GetIngredients());

            int expected = 1;
            int actual;
            if(pizzaP >= vegPizzaP)
            {
                actual = 1;
            } else
            {
                actual = 2;
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
