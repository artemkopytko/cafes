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
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dish pizza = new Dish();
            bool actual = true;
            bool expected = pizza.GetDishName() != null ? true : false;

            Assert.AreEqual(expected, actual);
        }
    }
}
