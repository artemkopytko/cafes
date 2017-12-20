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
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dish pizza = new Pizza();
            int expected = 15;
            int actual = pizza.GetCookingTime();

            Assert.AreEqual(expected, actual);
        }
    }
}
