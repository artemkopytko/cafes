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
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ingredient chocolate = new Chocolate();
            double expected = 15.0;
            double actual = chocolate.GetPrice();

            Assert.AreEqual(expected, actual);
        }
    }
}
