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
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dish myDish = new Pizza();

            int actual = myDish.GetIngredients().Count;
            Console.WriteLine(actual);

            List<Ingredient> actualDish = new List<Ingredient>
            {   new Dough(),
                new Flour(),
                new Salami(),
                new Cheese(),
                new Sauce(),
                new Spice()
            };
            int expected = 6;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
