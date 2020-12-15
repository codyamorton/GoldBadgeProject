using MenuList;
using MenuRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MenuTest
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void SetMenuName()
        {
            Menu menu = new Menu();

            menu.MealName = "Hamburger";

            string expected = "Hamburger";
            string actual = menu.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
