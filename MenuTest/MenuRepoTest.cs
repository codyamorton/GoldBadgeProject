using MenuList;
using MenuRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MenuTest
{
    [TestClass]
    public class MenuRepoTest
    {

        private MenuRepo _repo;
        private Menu _menu;


        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepo();
            _menu = new Menu ("burger", "Basic beef hamburger", 1, IngredientList.Beef, 2.99);
            _repo.AddMenuItemToList(_menu);
        }
        
        // add 
        [TestMethod]
        public void AddToList()
        {
           

            // Arrange
            Menu menu = new Menu();
            menu.MealName = "Burger";
            MenuRepo repo = new MenuRepo();

            // Act or run code we want to test 
            repo.AddMenuItemToList(menu);
            Menu menuFromDirectory = repo.GetMenuItemByName("Burger");


            // Assert to verify expected outcome 
            Assert.IsNotNull(menuFromDirectory);
        }

        // Update 
        [TestMethod]

        public void UpdateMeal_ShouldReturnTrue()
        {
            //Arrange
            //TestInitialize
            Menu newMeal = new Menu("Burger", "Basic beef hamburger", 1, IngredientList.Beef, 5.99);
            // Act
            bool updateResult = _repo.UpdateMeal("Burger", newMeal);

            //Assert 
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Hamburger", true)]
        
        public void UpdateMeal_ShouldMatchBool(string originalMeal, bool shouldUpdate)
        {
            Menu newMeal = new Menu("Burger", "Basic beef hamburger", 1, IngredientList.Beef, 5.99);
            // Act
            bool updateResult = _repo.UpdateMeal("Burger", newMeal);

            //Assert 
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteMeals()
        {
            //Arrange
            string menuName = "burger";
            // Act
            bool deleteResult = _repo.RemoveItemFromList(menuName);

            // Assert
            Assert.IsTrue(deleteResult);

        }
    }
}
